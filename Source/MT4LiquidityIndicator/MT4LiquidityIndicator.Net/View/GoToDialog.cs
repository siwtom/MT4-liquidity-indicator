using MT4LiquidityIndicator.Net.Fdk;
using SoftFX.Extended;
using SoftFX.Extended.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MT4LiquidityIndicator.Net.View
{
	public partial class GoToDialog : Form
	{
		#region construction

		public GoToDialog(string symbol, int duration)
		{
			InitializeComponent();

			m_symbol = symbol;
			m_duration = duration;
		}

		#endregion

		public Quote[] Quotes { get; private set; }

		#region event handlers

		private void OnGo(object sender, EventArgs e)
		{
			DateTime value = m_dateTime.Value;
			m_timestamp = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, DateTimeKind.Utc);

			try
			{
				m_go.Enabled = false;
				m_cancel.Enabled = false;
				m_thread = new Thread(Download);
				m_thread.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK);
				this.Close();
			}
		}

		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			if (null != m_thread)
			{
				e.Cancel = true;
			}
		}

		#endregion

		#region helper methods
		private void Log(string message)
		{
			if (this.InvokeRequired)
			{
				Action<string> func = Log;
				BeginInvoke(func, message);
			}
			else
			{
				m_log.Items.Add(message);
			}
		}

		private void Log(string format, params object[] args)
		{
			string message = string.Format(format, args);
			Log(message);
		}

		private void Close(DialogResult result)
		{
			if (this.InvokeRequired)
			{
				Action<DialogResult> func = Close;
				BeginInvoke(func, result);
			}
			else
			{
				this.DialogResult = result;
				this.Close();
			}
		}

		#endregion


		#region downloading quotes

		private void Download()
		{
			string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			Log("Using of a temporary directory = {0}", path);

			bool isSuccessfull = SafeDownload(path) && SafeDeleteDirectory(path);
			m_thread = null;

			if (isSuccessfull)
			{
				Close(DialogResult.OK);
			}
		}

		private bool SafeDownload(string path)
		{
			bool result = false;

			try
			{
				Log("Downloading quotes...");
				using (DataFeedImpl impl = DataFeedImpl.Create())
				{
					DataFeed feed = impl.Instance;
					using (DataFeedStorage storage = new DataFeedStorage(path, StorageProvider.Ntfs, 1, feed, false))
					{
						DateTime startTime = m_timestamp.AddSeconds(-m_duration);
						Log("Start time = {0}", startTime);
						DateTime endTime = m_timestamp;
						Log("End time = {0}", endTime);
						this.Quotes = storage.Online.GetQuotes(m_symbol, startTime, endTime, 0);
					}
				}

				Log("{0} quotes have been loaded", this.Quotes.Length);

				result = true;
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}

			return result;
		}

		private bool SafeDeleteDirectory(string path)
		{
			bool result = false;

			try
			{
				Log("Trying to delete a directory = {0}", path);
				if (Directory.Exists(path))
				{
					Directory.Delete(path, true);
				}
				Log("The directory has been deleted successfully");
				result = true;
			}
			catch (Exception ex)
			{
				Log(ex.Message);
			}
			return result;
		}
		#endregion

		#region input arguments

		private readonly string m_symbol;
		private readonly int m_duration;

		#endregion

		#region members
		private DateTime m_timestamp;
		private Thread m_thread;
		#endregion
	}
}
