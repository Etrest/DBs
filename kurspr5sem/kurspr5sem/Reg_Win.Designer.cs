namespace kurspr5sem
{
	partial class Reg_Win
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
			tbLog = new TextBox();
			tbPass = new TextBox();
			tbConPass = new TextBox();
			Back_to_Login = new Label();
			label2 = new Label();
			lbPassword = new Label();
			label4 = new Label();
			Reg_but = new Button();
			SuspendLayout();
			// 
			// tbLog
			// 
			tbLog.Location = new Point(80, 72);
			tbLog.Name = "tbLog";
			tbLog.Size = new Size(212, 23);
			tbLog.TabIndex = 0;
			// 
			// tbPass
			// 
			tbPass.Location = new Point(80, 144);
			tbPass.Name = "tbPass";
			tbPass.Size = new Size(212, 23);
			tbPass.TabIndex = 1;
			// 
			// tbConPass
			// 
			tbConPass.Location = new Point(80, 188);
			tbConPass.Name = "tbConPass";
			tbConPass.Size = new Size(212, 23);
			tbConPass.TabIndex = 2;
			// 
			// Back_to_Login
			// 
			Back_to_Login.AutoSize = true;
			Back_to_Login.Location = new Point(12, 9);
			Back_to_Login.Name = "Back_to_Login";
			Back_to_Login.Size = new Size(20, 15);
			Back_to_Login.TabIndex = 3;
			Back_to_Login.Text = "<-";
			Back_to_Login.Click += Back_to_Login_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(80, 54);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 4;
			label2.Text = "Mail/Login";
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new Point(80, 126);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new Size(57, 15);
			lbPassword.TabIndex = 5;
			lbPassword.Text = "Password";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(80, 170);
			label4.Name = "label4";
			label4.Size = new Size(104, 15);
			label4.TabIndex = 6;
			label4.Text = "Confirm password";
			// 
			// Reg_but
			// 
			Reg_but.Location = new Point(147, 217);
			Reg_but.Name = "Reg_but";
			Reg_but.Size = new Size(75, 23);
			Reg_but.TabIndex = 7;
			Reg_but.Text = "Regist";
			Reg_but.UseVisualStyleBackColor = true;
			Reg_but.Click += Reg_but_Click;
			// 
			// Reg_Win
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(394, 296);
			Controls.Add(Reg_but);
			Controls.Add(label4);
			Controls.Add(lbPassword);
			Controls.Add(label2);
			Controls.Add(Back_to_Login);
			Controls.Add(tbConPass);
			Controls.Add(tbPass);
			Controls.Add(tbLog);
			Name = "Reg_Win";
			Text = "Registration";
			FormClosed += Reg_Win_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbLog;
		private TextBox tbPass;
		private TextBox tbConPass;
		private Label Back_to_Login;
		private Label label2;
		private Label lbPassword;
		private Label label4;
		private Button Reg_but;
	}
}