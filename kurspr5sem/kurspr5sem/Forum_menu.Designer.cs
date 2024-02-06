namespace kurspr5sem
{
	partial class Forum_menu
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
			lbForum = new Label();
			Back_to_sections = new Label();
			User_nickname_and_page = new Label();
			Create_Forum_But = new Button();
			Forum_name_Text_box = new TextBox();
			lbCreate_Forum = new Label();
			SuspendLayout();
			// 
			// lbForum
			// 
			lbForum.AutoSize = true;
			lbForum.Location = new Point(12, 33);
			lbForum.Name = "lbForum";
			lbForum.Size = new Size(76, 15);
			lbForum.TabIndex = 0;
			lbForum.Text = "Forum menu";
			lbForum.Click += label1_Click;
			// 
			// Back_to_sections
			// 
			Back_to_sections.AutoSize = true;
			Back_to_sections.Location = new Point(12, 9);
			Back_to_sections.Name = "Back_to_sections";
			Back_to_sections.Size = new Size(20, 15);
			Back_to_sections.TabIndex = 1;
			Back_to_sections.Text = "<-";
			Back_to_sections.Click += Back_to_sections_Click;
			// 
			// User_nickname_and_page
			// 
			User_nickname_and_page.AutoSize = true;
			User_nickname_and_page.Location = new Point(750, 9);
			User_nickname_and_page.Name = "User_nickname_and_page";
			User_nickname_and_page.Size = new Size(38, 15);
			User_nickname_and_page.TabIndex = 3;
			User_nickname_and_page.Text = "label1";
			User_nickname_and_page.Click += User_nickname_and_page_Click;
			// 
			// Create_Forum_But
			// 
			Create_Forum_But.Location = new Point(12, 114);
			Create_Forum_But.Name = "Create_Forum_But";
			Create_Forum_But.Size = new Size(122, 23);
			Create_Forum_But.TabIndex = 8;
			Create_Forum_But.Text = "Create";
			Create_Forum_But.UseVisualStyleBackColor = true;
			Create_Forum_But.Click += Create_Forum_But_Click;
			// 
			// Forum_name_Text_box
			// 
			Forum_name_Text_box.Location = new Point(12, 85);
			Forum_name_Text_box.Name = "Forum_name_Text_box";
			Forum_name_Text_box.Size = new Size(122, 23);
			Forum_name_Text_box.TabIndex = 7;
			// 
			// lbCreate_Forum
			// 
			lbCreate_Forum.AutoSize = true;
			lbCreate_Forum.Location = new Point(12, 67);
			lbCreate_Forum.Name = "lbCreate_Forum";
			lbCreate_Forum.Size = new Size(117, 15);
			lbCreate_Forum.TabIndex = 6;
			lbCreate_Forum.Text = "Create forum named";
			lbCreate_Forum.Click += lbCreate_Sec_Click;
			// 
			// Forum_menu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(800, 450);
			Controls.Add(Create_Forum_But);
			Controls.Add(Forum_name_Text_box);
			Controls.Add(lbCreate_Forum);
			Controls.Add(User_nickname_and_page);
			Controls.Add(Back_to_sections);
			Controls.Add(lbForum);
			Name = "Forum_menu";
			Text = "Forum_menu";
			FormClosed += Forum_menu_FormClosed;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbForum;
		private Label Back_to_sections;
		private Label User_nickname_and_page;
		private Button Create_Forum_But;
		private TextBox Forum_name_Text_box;
		private Label lbCreate_Forum;
	}
}