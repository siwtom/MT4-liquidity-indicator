namespace MT4LiquidityIndicator.Launcher
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
			this.m_indicator = new MT4LiquidityIndicator.Net.View.Chart();
			this.SuspendLayout();
			// 
			// m_indicator
			// 
			this.m_indicator.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_indicator.Location = new System.Drawing.Point(0, 0);
			this.m_indicator.Name = "m_indicator";
			this.m_indicator.Size = new System.Drawing.Size(284, 262);
			this.m_indicator.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.m_indicator);
			this.Name = "MainForm";
			this.Text = "MT4LiquidityIndicator Launcher";
			this.ResumeLayout(false);

		}

		#endregion

		private Net.View.Chart m_indicator;
	}
}

