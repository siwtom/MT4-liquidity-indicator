namespace MT4LiquidityIndicator.Net.View
{
	partial class Chart
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripMenuItem viewOptionsToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem connectionsSettingsToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem goToNowToolStripMenuItem;
			System.Windows.Forms.ToolStripMenuItem saveAsCSVToolStripMenuItem;
			this.m_resetPricesWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_timer = new System.Windows.Forms.Timer(this.components);
			this.m_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_help = new System.Windows.Forms.Label();
			this.m_site = new System.Windows.Forms.LinkLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_spreads = new MT4LiquidityIndicator.Net.View.Prices();
			viewOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			connectionsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			goToNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			saveAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// viewOptionsToolStripMenuItem
			// 
			viewOptionsToolStripMenuItem.Name = "viewOptionsToolStripMenuItem";
			viewOptionsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			viewOptionsToolStripMenuItem.Text = "View options";
			viewOptionsToolStripMenuItem.Click += new System.EventHandler(this.OnOptions);
			// 
			// connectionsSettingsToolStripMenuItem
			// 
			connectionsSettingsToolStripMenuItem.Name = "connectionsSettingsToolStripMenuItem";
			connectionsSettingsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			connectionsSettingsToolStripMenuItem.Text = "Connections settings";
			connectionsSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnConnectionsSettings);
			// 
			// m_resetPricesWindowPositionToolStripMenuItem
			// 
			this.m_resetPricesWindowPositionToolStripMenuItem.Name = "m_resetPricesWindowPositionToolStripMenuItem";
			this.m_resetPricesWindowPositionToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.m_resetPricesWindowPositionToolStripMenuItem.Text = "Reset prices window position";
			this.m_resetPricesWindowPositionToolStripMenuItem.Click += new System.EventHandler(this.OnResetPricesWindowPosition);
			// 
			// m_timer
			// 
			this.m_timer.Enabled = true;
			this.m_timer.Interval = 500;
			this.m_timer.Tick += new System.EventHandler(this.OnTick);
			// 
			// m_contextMenu
			// 
			this.m_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            connectionsSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            viewOptionsToolStripMenuItem,
            this.m_resetPricesWindowPositionToolStripMenuItem,
            this.toolStripSeparator2,
            goToToolStripMenuItem,
            goToNowToolStripMenuItem,
            saveAsCSVToolStripMenuItem});
			this.m_contextMenu.Name = "m_contextMenu";
			this.m_contextMenu.Size = new System.Drawing.Size(228, 170);
			// 
			// m_help
			// 
			this.m_help.AutoSize = true;
			this.m_help.Location = new System.Drawing.Point(16, 48);
			this.m_help.Name = "m_help";
			this.m_help.Size = new System.Drawing.Size(27, 13);
			this.m_help.TabIndex = 2;
			this.m_help.Text = "help";
			// 
			// m_site
			// 
			this.m_site.AutoSize = true;
			this.m_site.Location = new System.Drawing.Point(16, 16);
			this.m_site.Name = "m_site";
			this.m_site.Size = new System.Drawing.Size(248, 13);
			this.m_site.TabIndex = 3;
			this.m_site.TabStop = true;
			this.m_site.Text = "https://github.com/marmysh/MT4-liquidity-indicator";
			this.m_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLink);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
			// 
			// goToToolStripMenuItem
			// 
			goToToolStripMenuItem.Name = "goToToolStripMenuItem";
			goToToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			goToToolStripMenuItem.Text = "Go to ...";
			goToToolStripMenuItem.Click += new System.EventHandler(this.OnGoTo);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
			// 
			// m_spreads
			// 
			this.m_spreads.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_spreads.Location = new System.Drawing.Point(19, 94);
			this.m_spreads.Name = "m_spreads";
			this.m_spreads.Size = new System.Drawing.Size(215, 121);
			this.m_spreads.TabIndex = 1;
			this.m_spreads.Visible = false;
			// 
			// goToNowToolStripMenuItem
			// 
			goToNowToolStripMenuItem.Name = "goToNowToolStripMenuItem";
			goToNowToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			goToNowToolStripMenuItem.Text = "Go to now";
			goToNowToolStripMenuItem.Click += new System.EventHandler(this.OnGoToNow);
			// 
			// saveAsCSVToolStripMenuItem
			// 
			saveAsCSVToolStripMenuItem.Name = "saveAsCSVToolStripMenuItem";
			saveAsCSVToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			saveAsCSVToolStripMenuItem.Text = "Save as CSV";
			saveAsCSVToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsCSV);
			// 
			// Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.m_contextMenu;
			this.Controls.Add(this.m_site);
			this.Controls.Add(this.m_help);
			this.Controls.Add(this.m_spreads);
			this.Name = "Chart";
			this.Size = new System.Drawing.Size(556, 315);
			this.Click += new System.EventHandler(this.OnClick);
			this.m_contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer m_timer;
		private System.Windows.Forms.ContextMenuStrip m_contextMenu;
		private MT4LiquidityIndicator.Net.View.Prices m_spreads;
		private System.Windows.Forms.Label m_help;
		private System.Windows.Forms.LinkLabel m_site;
		private System.Windows.Forms.ToolStripMenuItem m_resetPricesWindowPositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
