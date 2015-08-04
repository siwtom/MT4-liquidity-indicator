namespace MT4LiquidityIndicator.Net.View
{
	partial class GoToDialog
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
			System.Windows.Forms.Label label1;
			this.m_cancel = new System.Windows.Forms.Button();
			this.m_go = new System.Windows.Forms.Button();
			this.m_dateTime = new System.Windows.Forms.DateTimePicker();
			this.m_log = new System.Windows.Forms.ListBox();
			label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(30, 27);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(32, 13);
			label1.TabIndex = 5;
			label1.Text = "UTC:";
			// 
			// m_cancel
			// 
			this.m_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_cancel.Location = new System.Drawing.Point(375, 21);
			this.m_cancel.Name = "m_cancel";
			this.m_cancel.Size = new System.Drawing.Size(75, 23);
			this.m_cancel.TabIndex = 3;
			this.m_cancel.Text = "Cancel";
			this.m_cancel.UseVisualStyleBackColor = true;
			// 
			// m_go
			// 
			this.m_go.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_go.Location = new System.Drawing.Point(263, 21);
			this.m_go.Name = "m_go";
			this.m_go.Size = new System.Drawing.Size(75, 23);
			this.m_go.TabIndex = 2;
			this.m_go.Text = "Go";
			this.m_go.UseVisualStyleBackColor = true;
			this.m_go.Click += new System.EventHandler(this.OnGo);
			// 
			// m_dateTime
			// 
			this.m_dateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.m_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.m_dateTime.Location = new System.Drawing.Point(74, 21);
			this.m_dateTime.Name = "m_dateTime";
			this.m_dateTime.Size = new System.Drawing.Size(136, 20);
			this.m_dateTime.TabIndex = 1;
			// 
			// m_log
			// 
			this.m_log.FormattingEnabled = true;
			this.m_log.Location = new System.Drawing.Point(30, 64);
			this.m_log.Name = "m_log";
			this.m_log.Size = new System.Drawing.Size(420, 160);
			this.m_log.TabIndex = 4;
			// 
			// GoToDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 241);
			this.Controls.Add(label1);
			this.Controls.Add(this.m_cancel);
			this.Controls.Add(this.m_log);
			this.Controls.Add(this.m_go);
			this.Controls.Add(this.m_dateTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GoToDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Go to ...";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker m_dateTime;
		private System.Windows.Forms.ListBox m_log;
		private System.Windows.Forms.Button m_go;
		private System.Windows.Forms.Button m_cancel;
	}
}