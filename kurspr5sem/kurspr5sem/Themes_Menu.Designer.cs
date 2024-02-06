namespace kurspr5sem
{
	partial class Themes_Menu
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
			Create_Theme_But = new Button();
			Theme_name_Text_box = new TextBox();
			lbCreate_Theme = new Label();
			Back_to_Forums = new Label();
			lbTheme = new Label();
			User_nickname_and_page = new Label();
			tbStart_msg = new TextBox();
			Start_msg = new Label();
			SuspendLayout();
			// 
			// Create_Theme_But
			// 
			Create_Theme_But.Location = new Point(12, 160);
			Create_Theme_But.Name = "Create_Theme_But";
			Create_Theme_But.Size = new Size(122, 23);
			Create_Theme_But.TabIndex = 13;
			Create_Theme_But.Text = "Create";
			Create_Theme_But.UseVisualStyleBackColor = true;
			Create_Theme_But.Click += Create_Theme_But_Click;
			// 
			// Theme_name_Text_box
			// 
			Theme_name_Text_box.Location = new Point(12, 88);
			Theme_name_Text_box.Name = "Theme_name_Text_box";
			Theme_name_Text_box.Size = new Size(122, 23);
			Theme_name_Text_box.TabIndex = 12;
			// 
			// lbCreate_Theme
			// 
			lbCreate_Theme.AutoSize = true;
			lbCreate_Theme.Location = new Point(12, 70);
			lbCreate_Theme.Name = "lbCreate_Theme";
			lbCreate_Theme.Size = new Size(118, 15);
			lbCreate_Theme.TabIndex = 11;
			lbCreate_Theme.Text = "Create theme named";
			// 
			// Back_to_Forums
			// 
			Back_to_Forums.AutoSize = true;
			Back_to_Forums.Location = new Point(12, 12);
			Back_to_Forums.Name = "Back_to_Forums";
			Back_to_Forums.Size = new Size(20, 15);
			Back_to_Forums.TabIndex = 10;
			Back_to_Forums.Text = "<-";
			Back_to_Forums.Click += Back_to_Forums_Click;
			// 
			// lbTheme
			// 
			lbTheme.AutoSize = true;
			lbTheme.Location = new Point(12, 36);
			lbTheme.Name = "lbTheme";
			lbTheme.Size = new Size(82, 15);
			lbTheme.TabIndex = 9;
			lbTheme.Text = "Themes menu";
			// 
			// User_nickname_and_page
			// 
			User_nickname_and_page.AutoSize = true;
			User_nickname_and_page.Location = new Point(750, 12);
			User_nickname_and_page.Name = "User_nickname_and_page";
			User_nickname_and_page.Size = new Size(38, 15);
			User_nickname_and_page.TabIndex = 14;
			User_nickname_and_page.Text = "label1";
			// 
			// tbStart_msg
			// 
			tbStart_msg.Location = new Point(12, 131);
			tbStart_msg.Name = "tbStart_msg";
			tbStart_msg.Size = new Size(122, 23);
			tbStart_msg.TabIndex = 15;
			// 
			// Start_msg
			// 
			Start_msg.AutoSize = true;
			Start_msg.Location = new Point(12, 114);
			Start_msg.Name = "Start_msg";
			Start_msg.Size = new Size(80, 15);
			Start_msg.TabIndex = 16;
			Start_msg.Text = "Start message";
			// 
			// Themes_Menu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(800, 450);
			Controls.Add(Start_msg);
			Controls.Add(tbStart_msg);
			Controls.Add(User_nickname_and_page);
			Controls.Add(Create_Theme_But);
			Controls.Add(Theme_name_Text_box);
			Controls.Add(lbCreate_Theme);
			Controls.Add(Back_to_Forums);
			Controls.Add(lbTheme);
			Name = "Themes_Menu";
			Text = "Themes_Menu";
			FormClosed += Themes_Menu_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Create_Theme_But;
		private TextBox Theme_name_Text_box;
		private Label lbCreate_Theme;
		private Label Back_to_Forums;
		private Label lbTheme;
		private Label User_nickname_and_page;
		private TextBox tbStart_msg;
		private Label Start_msg;
	}
}