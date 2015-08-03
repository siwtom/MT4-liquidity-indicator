using SoftFX.Extended;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftFX.Extended.Events;
using System.Threading;
using System.Xml.Serialization;
using System.IO;


namespace MT4LiquidityIndicator.Net.Fdk
{
	internal class DataFeedImpl : IDisposable
	{
		#region construction
		private DataFeedImpl()
		{
		}
		private DataFeedImpl(string connectionString)
		{
			m_feed = new DataFeed(connectionString);

			m_feed.Logon += OnLogon;
			m_feed.Logout += OnLogout;
			m_feed.Start();

			m_continue = true;
			m_thread = new Thread(Loop);
			m_thread.Start();
		}
		internal static DataFeedImpl Create()
		{
			lock (s_synchronizer)
			{
				if (null == s_impl)
				{
					FixConnectionStringBuilder builder = LoadConnectionSettings();
					if (null != builder)
					{
						string connectionString = builder.ToString();
						s_impl = new DataFeedImpl(connectionString);
					}
					else
					{
						s_impl = new DataFeedImpl();
					}
				}
				s_counter++;
				return s_impl;
			}
		}
		internal static void UpdateConnectionSettings(FixConnectionStringBuilder builder)
		{
			DataFeedImpl dataFeedImpl = Create();
			lock (s_synchronizer)
			{
				DataFeed feed = dataFeedImpl.Instance;
				if (null != feed)
				{
					feed.Stop();
					feed.Initialize(builder.ToString());
					feed.Start();
				}
				string path = ConfirugationPath;
				TrySaveFixConnectionStringBuilder(path, builder);
			}
		}
		internal static string ConfirugationPath
		{
			get
			{
				string result = typeof(DataFeedImpl).Assembly.Location + ".xml";
				return result;
			}
		}
		internal static FixConnectionStringBuilder LoadConnectionSettings()
		{
			string path = ConfirugationPath;
			FixConnectionStringBuilder result = TryLoadFixConnectionStringBuilder(path);
			return result;
		}
		private static FixConnectionStringBuilder TryLoadFixConnectionStringBuilder(string path)
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(FixConnectionStringBuilder));
				using (StreamReader stream = new StreamReader(path))
				{
					object obj = serializer.Deserialize(stream);
					FixConnectionStringBuilder result = (FixConnectionStringBuilder)obj;
					return result;
				}
			}
			catch (System.Exception)
			{
				return null;
			}
		}
		private static void TrySaveFixConnectionStringBuilder(string path, FixConnectionStringBuilder builder)
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(FixConnectionStringBuilder));
				using (StreamWriter stream = new StreamWriter(path))
				{
					serializer.Serialize(stream, builder);
				}
			}
			catch (System.Exception)
			{
			}
		}
		#endregion
		#region subscription methods
		internal void Subscribe(string symbol)
		{
			lock (m_synchronizer)
			{
				int value = 0;
				m_required.TryGetValue(symbol, out value);
				m_required[symbol] = value + 1;
			}
			m_event.Set();
		}
		internal void Unsubscribe(string symbol)
		{
			lock (m_synchronizer)
			{
				int value = 0;
				m_required.TryGetValue(symbol, out value);
				if (value <= 0)
				{
					throw new InvalidOperationException("Mismatching of subscribe/unsubscribe methods using");
				}
				m_required[symbol] = value - 1;
			}
			m_event.Set();
		}
		private void Loop()
		{
			HashSet<string> symbols = new HashSet<string>();
			for (m_event.WaitOne(); m_continue; m_event.WaitOne())
			{
				Step();
			}
		}
		private void Step()
		{
			try
			{
				DoStep();
			}
			catch (System.Exception)
			{
				m_event.WaitOne(5000);
				m_event.Set();
			}
		}
		private void DoStep()
		{
			HashSet<string> add = new HashSet<string>();
			HashSet<string> remove = new HashSet<string>();

			lock (m_synchronizer)
			{
				foreach (var element in m_required)
				{
					if (element.Value > 0)
					{
						if (!m_actual.Contains(element.Key))
						{
							add.Add(element.Key);
						}
					}
					else
					{
						if (m_actual.Contains(element.Key))
						{
							remove.Add(element.Key);
						}
					}
				}
				m_wasActualSymbolsReset = false;
			}
			if (add.Count > 0)
			{
				m_feed.Server.SubscribeToQuotes(add, 5);
			}
			if (remove.Count > 0)
			{
				m_feed.Server.UnsubscribeQuotes(remove);
			}

			lock (m_synchronizer)
			{
				if (!m_wasActualSymbolsReset)
				{
					foreach (var element in remove)
					{
						m_actual.Remove(element);
					}
					foreach (var element in add)
					{
						m_actual.Add(element);
					}
				}
			}
		}
		#endregion
		#region event handlers
		private void OnLogon(object sender, LogonEventArgs e)
		{
			lock (m_synchronizer)
			{
				m_wasActualSymbolsReset = true;
				m_actual.Clear();
			}
			m_event.Set();
		}
		private void OnLogout(object sender, LogoutEventArgs e)
		{
			lock (m_synchronizer)
			{
				m_wasActualSymbolsReset = true;
				m_actual.Clear();
			}
			m_event.Set();
		}
		#endregion
		#region properties
		public DataFeed Instance
		{
			get
			{
				return m_feed;
			}
		}
		#endregion
		#region IDisposable implementation
		public void Dispose()
		{
			lock (s_synchronizer)
			{
				if (null == s_impl)
				{
					throw new InvalidOperationException();
				}
				--s_counter;
				if (0 == s_counter)
				{
					s_impl = null;
					DoDispose();
				}
			}
		}
		private void DoDispose()
		{
			DataFeed feed = m_feed;
			m_feed = null;
			if (null != feed)
			{
				feed.Stop();
				feed.Dispose();
			}
			m_continue = false;
			m_event.Set();
			if (null != m_thread)
			{
				m_thread.Join();
				m_thread = null;
			}
		}
		#endregion
		#region members
		private DataFeed m_feed;
		private readonly object m_synchronizer = new object();
		private readonly Dictionary<string, int> m_required = new Dictionary<string, int>();
		private readonly HashSet<string> m_actual = new HashSet<string>();
		private bool m_wasActualSymbolsReset;
		#endregion
		#region thread members
		private Thread m_thread;
		private volatile bool m_continue;
		private readonly AutoResetEvent m_event = new AutoResetEvent(false);
		#endregion

		#region static members
		private static int s_counter;
		private readonly static object s_synchronizer = new object();
		private static DataFeedImpl s_impl;
		#endregion
	}
}
