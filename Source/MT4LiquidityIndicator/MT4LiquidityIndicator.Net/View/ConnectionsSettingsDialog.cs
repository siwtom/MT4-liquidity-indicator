using MT4LiquidityIndicator.Net.Fdk;
using SoftFX.Extended;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MT4LiquidityIndicator.Net.View
{
	public partial class ConnectionsSettingsDialog : Form
	{
		public ConnectionsSettingsDialog()
		{
			InitializeComponent();
			FixConnectionStringBuilder builder = DataFeedImpl.LoadConnectionSettings();
			if (null == builder)
			{
				builder = new FixConnectionStringBuilder();
			}
			m_address.Text = builder.TradingPlatformAddress;
			m_port.Text = builder.TradingPlatformPort.ToString();
			m_ssl.Checked = builder.SecureConnection;
			m_username.Text = builder.Username;
			m_password.Text = builder.Password;
			m_port.Validating += OnPortValidating;
		}

		private void OnPortValidating(object sender, CancelEventArgs e)
		{
			string st = m_port.Text;
			short port = 0;
			if (!short.TryParse(st, out port) || (port <= 0))
			{
				string message = string.Format("You should enter a positive number from 1 to {0}", short.MaxValue);
				m_toolTip.Show(message, m_port);
				e.Cancel = true;
			}
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			m_toolTip.Hide(m_port);
		}

		private void OnOK(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			FixConnectionStringBuilder builder = new FixConnectionStringBuilder();
			builder.TradingPlatformAddress = m_address.Text;
			builder.TradingPlatformPort = int.Parse(m_port.Text);
			builder.Username = m_username.Text;
			builder.Password = m_password.Text;
			builder.SecureConnection = m_ssl.Checked;

			DataFeedImpl.UpdateConnectionSettings(builder);
		}

	}
}
