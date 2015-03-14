using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MT4LiquidityIndicator.Net.Settings;

namespace MT4LiquidityIndicator.Net.View
{
	internal partial class ChartSettingsDialog : Form
	{
		internal ChartSettingsDialog(Chart chart)
		{
			if (null == chart)
			{
				throw new ArgumentNullException("chart");
			}
			InitializeComponent();

			this.Text += chart.Parameters.Symbol;
			m_chart = chart;
			m_originalSettings = new ChartSettings(chart.Settings);
			m_propertyGrid.SelectedObject = chart.Settings;
			m_propertyGrid.PropertyValueChanged += OnChanged;
		}


		#region event handlers
		protected override void WndProc(ref Message m)
		{
			if (WM_CHAR == m.Msg)
			{
			}
			base.WndProc(ref m);
		}
		private void OnChanged(object sender, EventArgs e)
		{
			m_chart.ReloadSettings();
		}
		#endregion

		#region members
		private const int WM_CHAR = 0x0102;
		private readonly Chart m_chart;
		private readonly ChartSettings m_originalSettings;
		#endregion
	}
}
