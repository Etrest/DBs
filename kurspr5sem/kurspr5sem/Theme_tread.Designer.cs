namespace kurspr5sem
{
	partial class Theme_tread
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
			components = new System.ComponentModel.Container();
			thread_log = new ListBox();
			textBox1 = new TextBox();
			button1 = new Button();
			lbBack_to = new Label();
			User_nickname_and_page = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// thread_log
			// 
			thread_log.FormattingEnabled = true;
			thread_log.ItemHeight = 15;
			thread_log.Location = new Point(179, 12);
			thread_log.Name = "thread_log";
			thread_log.Size = new Size(434, 319);
			thread_log.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(179, 361);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(356, 77);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(538, 361);
			button1.Name = "button1";
			button1.Size = new Size(75, 77);
			button1.TabIndex = 2;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// lbBack_to
			// 
			lbBack_to.AutoSize = true;
			lbBack_to.Location = new Point(12, 12);
			lbBack_to.Name = "lbBack_to";
			lbBack_to.Size = new Size(20, 15);
			lbBack_to.TabIndex = 4;
			lbBack_to.Text = "<-";
			lbBack_to.Click += lbBack_to_Click;
			// 
			// User_nickname_and_page
			// 
			User_nickname_and_page.AutoSize = true;
			User_nickname_and_page.Location = new Point(750, 12);
			User_nickname_and_page.Name = "User_nickname_and_page";
			User_nickname_and_page.Size = new Size(38, 15);
			User_nickname_and_page.TabIndex = 15;
			User_nickname_and_page.Text = "label1";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Theme_tread
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(User_nickname_and_page);
			Controls.Add(lbBack_to);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(thread_log);
			Name = "Theme_tread";
			Text = "Form1";
			FormClosed += Theme_tread_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox thread_log;
		private TextBox textBox1;
		private Button button1;
		private Label lbBack_to;
		private Label User_nickname_and_page;
		private System.Windows.Forms.Timer timer1;
	}
}