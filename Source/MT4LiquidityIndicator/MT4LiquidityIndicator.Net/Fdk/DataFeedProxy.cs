using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftFX.Extended;
using SoftFX.Extended.Events;

namespace MT4LiquidityIndicator.Net.Fdk
{
	internal class DataFeedProxy : IDisposable
	{
		internal DataFeedProxy(string symbol)
		{
			if (null == symbol)
			{
				throw new ArgumentNullException("symbol");
			}
			m_symbol = symbol;
			m_impl = DataFeedImpl.Create();
			m_impl.Subscribe(symbol);
		}
		internal bool IsInitialized
		{
			get
			{
				DataFeed feed = m_impl.Instance;
				bool result = (null != feed);
				return result;
			}
		}
		internal event TickHandler Tick
		{
			add
			{
				DataFeed feed = m_impl.Instance;
				if (null != feed)
				{
					feed.Tick += value;
				}
			}
			remove
			{
				DataFeed feed = m_impl.Instance;
				if (null != feed)
				{
					feed.Tick -= value;
				}
			}
		}
		internal string Symbol
		{
			get
			{
				return m_symbol;
			}
		}
		public void Dispose()
		{
			DataFeedImpl impl = m_impl;
			m_impl = null;
			if (null != impl)
			{
				impl.Unsubscribe(m_symbol);
				impl.Dispose();
			}
		}
		#region members
		private readonly string m_symbol;
		private DataFeedImpl m_impl;
		#endregion
	}
}
