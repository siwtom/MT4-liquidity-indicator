namespace MT4LiquidityIndicator.Net.View
{
	partial class ConnectionsSettingsDialog
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.GroupBox groupBox1;
			this.m_ssl = new System.Windows.Forms.CheckBox();
			this.m_password = new System.Windows.Forms.TextBox();
			this.m_username = new System.Windows.Forms.TextBox();
			this.m_port = new System.Windows.Forms.TextBox();
			this.m_address = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.m_toolTip = new System.Windows.Forms.ToolTip(this.components);
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			groupBox1 = new System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(34, 21);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(45, 13);
			label1.TabIndex = 0;
			label1.Text = "Address";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(53, 50);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(26, 13);
			label2.TabIndex = 1;
			label2.Text = "Port";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(24, 79);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(55, 13);
			label3.TabIndex = 2;
			label3.Text = "Username";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(26, 108);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(53, 13);
			label4.TabIndex = 3;
			label4.Text = "Password";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.m_ssl);
			groupBox1.Controls.Add(this.m_password);
			groupBox1.Controls.Add(this.m_username);
			groupBox1.Controls.Add(this.m_port);
			groupBox1.Controls.Add(this.m_address);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new System.Drawing.Point(25, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(382, 147);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Connection parameters";
			// 
			// m_ssl
			// 
			this.m_ssl.AutoSize = true;
			this.m_ssl.Location = new System.Drawing.Point(199, 49);
			this.m_ssl.Name = "m_ssl";
			this.m_ssl.Size = new System.Drawing.Size(46, 17);
			this.m_ssl.TabIndex = 6;
			this.m_ssl.Text = "SSL";
			this.m_ssl.UseVisualStyleBackColor = true;
			// 
			// m_password
			// 
			this.m_password.Location = new System.Drawing.Point(96, 105);
			this.m_password.Name = "m_password";
			this.m_password.Size = new System.Drawing.Size(264, 20);
			this.m_password.TabIndex = 8;
			this.m_password.UseSystemPasswordChar = true;
			// 
			// m_username
			// 
			this.m_username.Location = new System.Drawing.Point(96, 76);
			this.m_username.Name = "m_username";
			this.m_username.Size = new System.Drawing.Size(264, 20);
			this.m_username.TabIndex = 7;
			// 
			// m_port
			// 
			this.m_port.Location = new System.Drawing.Point(96, 47);
			this.m_port.Name = "m_port";
			this.m_port.Size = new System.Drawing.Size(85, 20);
			this.m_port.TabIndex = 5;
			this.m_port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
			// 
			// m_address
			// 
			this.m_address.Location = new System.Drawing.Point(96, 18);
			this.m_address.Name = "m_address";
			this.m_address.Size = new System.Drawing.Size(264, 20);
			this.m_address.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(241, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.OnOK);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(332, 188);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ConnectionsSettingsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 224);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectionsSettingsDialog";
			this.Text = "Connections Settings";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox m_ssl;
		private System.Windows.Forms.TextBox m_password;
		private System.Windows.Forms.TextBox m_username;
		private System.Windows.Forms.TextBox m_port;
		private System.Windows.Forms.TextBox m_address;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip m_toolTip;
	}
}