namespace WindowsFormsApp1
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.textUserLogin = new System.Windows.Forms.TextBox();
			this.textUserPass = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textUserLogin
			// 
			this.textUserLogin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textUserLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.textUserLogin.Location = new System.Drawing.Point(30, 60);
			this.textUserLogin.Name = "textUserLogin";
			this.textUserLogin.Size = new System.Drawing.Size(236, 32);
			this.textUserLogin.TabIndex = 1;
			this.textUserLogin.Text = "UserLogin";
			// 
			// textUserPass
			// 
			this.textUserPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textUserPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.textUserPass.Location = new System.Drawing.Point(30, 124);
			this.textUserPass.Name = "textUserPass";
			this.textUserPass.Size = new System.Drawing.Size(236, 32);
			this.textUserPass.TabIndex = 2;
			this.textUserPass.Text = "Password";
			this.textUserPass.UseSystemPasswordChar = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.checkBox1.Location = new System.Drawing.Point(30, 182);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(102, 17);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Show Password";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(30, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 73);
			this.button1.TabIndex = 4;
			this.button1.Text = "Log in";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(301, 360);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textUserPass);
			this.Controls.Add(this.textUserLogin);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "Login Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textUserLogin;
		private System.Windows.Forms.TextBox textUserPass;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
	}
}

