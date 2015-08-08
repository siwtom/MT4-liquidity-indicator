namespace MT4LiquidityIndicator.Setup
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_metaTraders = new System.Windows.Forms.CheckedListBox();
			this.m_install = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_metaTraders
			// 
			this.m_metaTraders.FormattingEnabled = true;
			this.m_metaTraders.Location = new System.Drawing.Point(24, 48);
			this.m_metaTraders.Name = "m_metaTraders";
			this.m_metaTraders.Size = new System.Drawing.Size(562, 364);
			this.m_metaTraders.TabIndex = 0;
			this.m_metaTraders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnCheck);
			// 
			// m_install
			// 
			this.m_install.Enabled = false;
			this.m_install.Location = new System.Drawing.Point(511, 12);
			this.m_install.Name = "m_install";
			this.m_install.Size = new System.Drawing.Size(75, 23);
			this.m_install.TabIndex = 1;
			this.m_install.Text = "Install";
			this.m_install.UseVisualStyleBackColor = true;
			this.m_install.Click += new System.EventHandler(this.OnInstall);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "List of detected Meta Trader4 clients";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 436);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_install);
			this.Controls.Add(this.m_metaTraders);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MT4 Liquidity Indicator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox m_metaTraders;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_install;
	}
}

