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
			System.Windows.Forms.ToolStripMenuItem saveAsCSVToolStripMenuItem;
			this.m_viewOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_connectionsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_goToNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_resetPricesWindowPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_timer = new System.Windows.Forms.Timer(this.components);
			this.m_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.m_help = new System.Windows.Forms.Label();
			this.m_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.m_spreads = new MT4LiquidityIndicator.Net.View.Prices();
			saveAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveAsCSVToolStripMenuItem
			// 
			saveAsCSVToolStripMenuItem.Name = "saveAsCSVToolStripMenuItem";
			saveAsCSVToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			saveAsCSVToolStripMenuItem.Text = "Save as CSV";
			saveAsCSVToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsCSV);
			// 
			// m_viewOptionsToolStripMenuItem
			// 
			this.m_viewOptionsToolStripMenuItem.Name = "m_viewOptionsToolStripMenuItem";
			this.m_viewOptionsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.m_viewOptionsToolStripMenuItem.Text = "View options";
			this.m_viewOptionsToolStripMenuItem.Click += new System.EventHandler(this.OnOptions);
			// 
			// m_connectionsSettingsToolStripMenuItem
			// 
			this.m_connectionsSettingsToolStripMenuItem.Name = "m_connectionsSettingsToolStripMenuItem";
			this.m_connectionsSettingsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.m_connectionsSettingsToolStripMenuItem.Text = "Connections settings";
			this.m_connectionsSettingsToolStripMenuItem.Click += new System.EventHandler(this.OnConnectionsSettings);
			// 
			// m_goToToolStripMenuItem
			// 
			this.m_goToToolStripMenuItem.Name = "m_goToToolStripMenuItem";
			this.m_goToToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.m_goToToolStripMenuItem.Text = "View quotes history";
			this.m_goToToolStripMenuItem.Click += new System.EventHandler(this.OnGoTo);
			// 
			// m_goToNowToolStripMenuItem
			// 
			this.m_goToNowToolStripMenuItem.Checked = true;
			this.m_goToNowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_goToNowToolStripMenuItem.Name = "m_goToNowToolStripMenuItem";
			this.m_goToNowToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.m_goToNowToolStripMenuItem.Text = "View current quotes";
			this.m_goToNowToolStripMenuItem.Click += new System.EventHandler(this.OnGoToNow);
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
            this.m_connectionsSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.m_viewOptionsToolStripMenuItem,
            this.m_resetPricesWindowPositionToolStripMenuItem,
            this.toolStripSeparator2,
            this.m_goToToolStripMenuItem,
            this.m_goToNowToolStripMenuItem,
            this.toolStripSeparator3,
            saveAsCSVToolStripMenuItem});
			this.m_contextMenu.Name = "m_contextMenu";
			this.m_contextMenu.Size = new System.Drawing.Size(228, 154);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
			// 
			// m_help
			// 
			this.m_help.AutoSize = true;
			this.m_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.m_help.Location = new System.Drawing.Point(16, 48);
			this.m_help.Name = "m_help";
			this.m_help.Size = new System.Drawing.Size(350, 40);
			this.m_help.TabIndex = 2;
			this.m_help.Text = "Please select \"Connections settings\"\r\nin context menu and specify required inform" +
    "ation";
			// 
			// m_saveFileDialog
			// 
			this.m_saveFileDialog.Filter = "CSV files|*.csv|All files|*.*";
			// 
			// m_spreads
			// 
			this.m_spreads.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_spreads.Location = new System.Drawing.Point(19, 94);
			this.m_spreads.Name = "m_spreads";
			this.m_spreads.Size = new System.Drawing.Size(215, 121);
			this.m_spreads.TabIndex = 1;
			// 
			// Chart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.m_contextMenu;
			this.Controls.Add(this.m_spreads);
			this.Controls.Add(this.m_help);
			this.Name = "Chart";
			this.Size = new System.Drawing.Size(672, 318);
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
		private System.Windows.Forms.ToolStripMenuItem m_resetPricesWindowPositionToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.SaveFileDialog m_saveFileDialog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem m_viewOptionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem m_connectionsSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem m_goToToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem m_goToNowToolStripMenuItem;
	}
}
