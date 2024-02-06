namespace kurspr5sem
{
	partial class Admin_panel
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
			dataGridView1 = new DataGridView();
			Save_DB = new Button();
			To_admin_console = new Button();
			textBox1 = new TextBox();
			Ban_but = new Button();
			To_Admin_but = new Button();
			Us_log_lab = new Label();
			Back_to_sections = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(165, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(451, 426);
			dataGridView1.TabIndex = 0;
			// 
			// Save_DB
			// 
			Save_DB.Location = new Point(12, 36);
			Save_DB.Name = "Save_DB";
			Save_DB.Size = new Size(103, 46);
			Save_DB.TabIndex = 1;
			Save_DB.Text = "Save DB";
			Save_DB.UseVisualStyleBackColor = true;
			Save_DB.Click += Save_DB_Click;
			// 
			// To_admin_console
			// 
			To_admin_console.Location = new Point(12, 95);
			To_admin_console.Name = "To_admin_console";
			To_admin_console.Size = new Size(103, 46);
			To_admin_console.TabIndex = 2;
			To_admin_console.Text = "To console";
			To_admin_console.UseVisualStyleBackColor = true;
			To_admin_console.Click += To_admin_console_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(622, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(166, 23);
			textBox1.TabIndex = 3;
			// 
			// Ban_but
			// 
			Ban_but.Location = new Point(713, 59);
			Ban_but.Name = "Ban_but";
			Ban_but.Size = new Size(75, 23);
			Ban_but.TabIndex = 4;
			Ban_but.Text = "Ban";
			Ban_but.UseVisualStyleBackColor = true;
			Ban_but.Click += Ban_but_Click;
			// 
			// To_Admin_but
			// 
			To_Admin_but.Location = new Point(622, 59);
			To_Admin_but.Name = "To_Admin_but";
			To_Admin_but.Size = new Size(75, 23);
			To_Admin_but.TabIndex = 5;
			To_Admin_but.Text = "Rise";
			To_Admin_but.UseVisualStyleBackColor = true;
			To_Admin_but.Click += To_Admin_but_Click;
			// 
			// Us_log_lab
			// 
			Us_log_lab.AutoSize = true;
			Us_log_lab.Location = new Point(622, 12);
			Us_log_lab.Name = "Us_log_lab";
			Us_log_lab.Size = new Size(95, 15);
			Us_log_lab.TabIndex = 6;
			Us_log_lab.Text = "User's Nickname";
			// 
			// Back_to_sections
			// 
			Back_to_sections.AutoSize = true;
			Back_to_sections.Location = new Point(12, 9);
			Back_to_sections.Name = "Back_to_sections";
			Back_to_sections.Size = new Size(20, 15);
			Back_to_sections.TabIndex = 7;
			Back_to_sections.Text = "<-";
			Back_to_sections.Click += Back_to_sections_Click;
			// 
			// Admin_panel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Back_to_sections);
			Controls.Add(Us_log_lab);
			Controls.Add(To_Admin_but);
			Controls.Add(Ban_but);
			Controls.Add(textBox1);
			Controls.Add(To_admin_console);
			Controls.Add(Save_DB);
			Controls.Add(dataGridView1);
			Name = "Admin_panel";
			Text = "Admin panel";
			FormClosed += Admin_panel_FormClosed;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button Save_DB;
		private Button To_admin_console;
		private TextBox textBox1;
		private Button Ban_but;
		private Button To_Admin_but;
		private Label Us_log_lab;
		private Label Back_to_sections;
	}
}