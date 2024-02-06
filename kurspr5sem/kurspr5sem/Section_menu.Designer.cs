using Microsoft.VisualBasic.ApplicationServices;

namespace kurspr5sem
{
	partial class Section_menu
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
			To_banned_list = new Button();
			To_admin_panel = new Button();
			User_nickname_and_page = new Label();
			lbCreate_Sec = new Label();
			Sec_name_Text_box = new TextBox();
			Create_Sec_But = new Button();
			Log_Out_But = new Button();
			SuspendLayout();
			// 
			// To_banned_list
			// 
			To_banned_list.Location = new Point(22, 101);
			To_banned_list.Name = "To_banned_list";
			To_banned_list.Size = new Size(122, 47);
			To_banned_list.TabIndex = 0;
			To_banned_list.Text = "To banned list";
			To_banned_list.UseVisualStyleBackColor = true;
			To_banned_list.Click += To_banned_list_Click;
			// 
			// To_admin_panel
			// 
			To_admin_panel.Location = new Point(22, 168);
			To_admin_panel.Name = "To_admin_panel";
			To_admin_panel.Size = new Size(122, 47);
			To_admin_panel.TabIndex = 1;
			To_admin_panel.Text = "To admin panel";
			To_admin_panel.UseVisualStyleBackColor = true;
			To_admin_panel.Click += To_admin_panel_Click;
			// 
			// User_nickname_and_page
			// 
			User_nickname_and_page.AutoSize = true;
			User_nickname_and_page.Location = new Point(738, 12);
			User_nickname_and_page.Name = "User_nickname_and_page";
			User_nickname_and_page.Size = new Size(38, 15);
			User_nickname_and_page.TabIndex = 2;
			User_nickname_and_page.Text = "label1";
			User_nickname_and_page.Click += (sender, e) => User_nickname_and_page_Click(sender, e, User_nickname_and_page.Text);
			// 
			// lbCreate_Sec
			// 
			lbCreate_Sec.AutoSize = true;
			lbCreate_Sec.Location = new Point(22, 12);
			lbCreate_Sec.Name = "lbCreate_Sec";
			lbCreate_Sec.Size = new Size(122, 15);
			lbCreate_Sec.TabIndex = 3;
			lbCreate_Sec.Text = "Create section named";
			// 
			// Sec_name_Text_box
			// 
			Sec_name_Text_box.Location = new Point(22, 30);
			Sec_name_Text_box.Name = "Sec_name_Text_box";
			Sec_name_Text_box.Size = new Size(122, 23);
			Sec_name_Text_box.TabIndex = 4;
			// 
			// Create_Sec_But
			// 
			Create_Sec_But.Location = new Point(22, 59);
			Create_Sec_But.Name = "Create_Sec_But";
			Create_Sec_But.Size = new Size(122, 23);
			Create_Sec_But.TabIndex = 5;
			Create_Sec_But.Text = "Create";
			Create_Sec_But.UseVisualStyleBackColor = true;
			Create_Sec_But.Click += Create_Sec_But_Click;
			// 
			// Log_Out_But
			// 
			Log_Out_But.Location = new Point(713, 30);
			Log_Out_But.Name = "Log_Out_But";
			Log_Out_But.Size = new Size(75, 23);
			Log_Out_But.TabIndex = 6;
			Log_Out_But.Text = "Logout";
			Log_Out_But.UseVisualStyleBackColor = true;
			Log_Out_But.Click += Log_Out_But_Click;
			// 
			// Section_menu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(800, 450);
			Controls.Add(Log_Out_But);
			Controls.Add(Create_Sec_But);
			Controls.Add(Sec_name_Text_box);
			Controls.Add(lbCreate_Sec);
			Controls.Add(User_nickname_and_page);
			Controls.Add(To_admin_panel);
			Controls.Add(To_banned_list);
			Name = "Section_menu";
			Text = "Section menu";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button To_banned_list;
		private Button To_admin_panel;
		private Label User_nickname_and_page;
		private Label lbCreate_Sec;
		private TextBox Sec_name_Text_box;
		private Button Create_Sec_But;
		private Button Log_Out_But;
	}
}