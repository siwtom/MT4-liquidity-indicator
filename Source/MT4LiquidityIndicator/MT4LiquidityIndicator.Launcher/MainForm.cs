using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MT4LiquidityIndicator.Net;

namespace MT4LiquidityIndicator.Launcher
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			string st = "This=0|Symbol=EURUSD|Period=60|Digits=5|LotSize=100000|Func=0";
			Parameters parameters = new Parameters(st);
			m_indicator.Construct(parameters);
		}
	}
}
