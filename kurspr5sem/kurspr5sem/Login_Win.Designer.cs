namespace kurspr5sem
{
	partial class Login_Win
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbLogin = new TextBox();
			tbPasswd = new TextBox();
			To_regist = new Label();
			label2 = new Label();
			label3 = new Label();
			log_but = new Button();
			SuspendLayout();
			// 
			// tbLogin
			// 
			tbLogin.Location = new Point(76, 93);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(211, 23);
			tbLogin.TabIndex = 0;
			// 
			// tbPasswd
			// 
			tbPasswd.Location = new Point(76, 168);
			tbPasswd.Name = "tbPasswd";
			tbPasswd.Size = new Size(211, 23);
			tbPasswd.TabIndex = 1;
			// 
			// To_regist
			// 
			To_regist.AutoSize = true;
			To_regist.Location = new Point(263, 9);
			To_regist.Name = "To_regist";
			To_regist.Size = new Size(101, 15);
			To_regist.TabIndex = 2;
			To_regist.Text = "To Registration ->";
			To_regist.Click += To_regist_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(76, 75);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 3;
			label2.Text = "Mail/Login";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(76, 150);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 4;
			label3.Text = "Password";
			// 
			// log_but
			// 
			log_but.Location = new Point(140, 215);
			log_but.Name = "log_but";
			log_but.Size = new Size(75, 23);
			log_but.TabIndex = 5;
			log_but.Text = "Login";
			log_but.UseVisualStyleBackColor = true;
			log_but.Click += log_but_Click_1;
			// 
			// Login_Win
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 433);
			Controls.Add(log_but);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(To_regist);
			Controls.Add(tbPasswd);
			Controls.Add(tbLogin);
			Name = "Login_Win";
			Text = "Login";
			Load += Login_Win_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbLogin;
		private TextBox tbPasswd;
		private Label To_regist;
		private Label label2;
		private Label label3;
		private Button log_but;
	}
}