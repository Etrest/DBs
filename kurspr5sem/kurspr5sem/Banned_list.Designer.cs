namespace kurspr5sem
{
	partial class Banned_list
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
			Danned_List = new DataGridView();
			Back_to_Admin_panel = new Label();
			lbUnban = new Label();
			tbUnban = new TextBox();
			Unban_but = new Button();
			((System.ComponentModel.ISupportInitialize)Danned_List).BeginInit();
			SuspendLayout();
			// 
			// Danned_List
			// 
			Danned_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Danned_List.Location = new Point(162, 12);
			Danned_List.Name = "Danned_List";
			Danned_List.RowTemplate.Height = 25;
			Danned_List.Size = new Size(626, 426);
			Danned_List.TabIndex = 0;
			// 
			// Back_to_Admin_panel
			// 
			Back_to_Admin_panel.AutoSize = true;
			Back_to_Admin_panel.Location = new Point(12, 12);
			Back_to_Admin_panel.Name = "Back_to_Admin_panel";
			Back_to_Admin_panel.Size = new Size(20, 15);
			Back_to_Admin_panel.TabIndex = 1;
			Back_to_Admin_panel.Text = "<-";
			Back_to_Admin_panel.Click += Back_to_Admin_panel_Click;
			// 
			// lbUnban
			// 
			lbUnban.AutoSize = true;
			lbUnban.Location = new Point(12, 32);
			lbUnban.Name = "lbUnban";
			lbUnban.Size = new Size(42, 15);
			lbUnban.TabIndex = 2;
			lbUnban.Text = "Unban";
			// 
			// tbUnban
			// 
			tbUnban.Location = new Point(12, 50);
			tbUnban.Name = "tbUnban";
			tbUnban.Size = new Size(144, 23);
			tbUnban.TabIndex = 3;
			// 
			// Unban_but
			// 
			Unban_but.Location = new Point(12, 79);
			Unban_but.Name = "Unban_but";
			Unban_but.Size = new Size(144, 23);
			Unban_but.TabIndex = 4;
			Unban_but.Text = "Go";
			Unban_but.UseVisualStyleBackColor = true;
			Unban_but.Click += Unban_but_Click;
			// 
			// Banned_list
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Unban_but);
			Controls.Add(tbUnban);
			Controls.Add(lbUnban);
			Controls.Add(Back_to_Admin_panel);
			Controls.Add(Danned_List);
			Name = "Banned_list";
			Text = "Banned list";
			FormClosed += Banned_list_FormClosed;
			((System.ComponentModel.ISupportInitialize)Danned_List).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView Danned_List;
		private Label Back_to_Admin_panel;
		private Label lbUnban;
		private TextBox tbUnban;
		private Button Unban_but;
	}
}