namespace kurspr5sem
{
	partial class Admin_console
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
			label1 = new Label();
			dataGridView1 = new DataGridView();
			CustomQueryTextBox = new TextBox();
			SelfQuery = new Label();
			SendQuery = new Button();
			Back_to_Admin_Panel = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			btTo_Excel = new Button();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			btPrint = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 24);
			label1.Name = "label1";
			label1.Size = new Size(782, 15);
			label1.TabIndex = 0;
			label1.Text = "___________________________________________________________________________________________________________________________________________________________";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(46, 42);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(562, 507);
			dataGridView1.TabIndex = 21;
			// 
			// CustomQueryTextBox
			// 
			CustomQueryTextBox.Location = new Point(46, 579);
			CustomQueryTextBox.Name = "CustomQueryTextBox";
			CustomQueryTextBox.Size = new Size(585, 23);
			CustomQueryTextBox.TabIndex = 22;
			// 
			// SelfQuery
			// 
			SelfQuery.AutoSize = true;
			SelfQuery.Location = new Point(46, 561);
			SelfQuery.Name = "SelfQuery";
			SelfQuery.Size = new Size(82, 15);
			SelfQuery.TabIndex = 23;
			SelfQuery.Text = "Custom query";
			// 
			// SendQuery
			// 
			SendQuery.Location = new Point(637, 578);
			SendQuery.Name = "SendQuery";
			SendQuery.Size = new Size(123, 24);
			SendQuery.TabIndex = 24;
			SendQuery.Text = "Send query";
			SendQuery.UseVisualStyleBackColor = true;
			SendQuery.Click += SendQuery_Click;
			// 
			// Back_to_Admin_Panel
			// 
			Back_to_Admin_Panel.AutoSize = true;
			Back_to_Admin_Panel.Location = new Point(12, 9);
			Back_to_Admin_Panel.Name = "Back_to_Admin_Panel";
			Back_to_Admin_Panel.Size = new Size(20, 15);
			Back_to_Admin_Panel.TabIndex = 25;
			Back_to_Admin_Panel.Text = "<-";
			Back_to_Admin_Panel.Click += Back_to_Admin_Panel_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(637, 42);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 26;
			label2.Text = "Reminder:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(671, 57);
			label3.Name = "label3";
			label3.Size = new Size(85, 15);
			label3.TabIndex = 27;
			label3.Text = "ACCESS_LEVEL";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(671, 72);
			label4.Name = "label4";
			label4.Size = new Size(89, 15);
			label4.TabIndex = 28;
			label4.Text = "ADMIN_STATUS";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(671, 87);
			label5.Name = "label5";
			label5.Size = new Size(76, 15);
			label5.TabIndex = 29;
			label5.Text = "FORUM_LOG";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(671, 102);
			label6.Name = "label6";
			label6.Size = new Size(104, 15);
			label6.TabIndex = 30;
			label6.Text = "FORUM_SECURITY";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(671, 117);
			label7.Name = "label7";
			label7.Size = new Size(54, 15);
			label7.TabIndex = 31;
			label7.Text = "FORUMS";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(671, 132);
			label8.Name = "label8";
			label8.Size = new Size(35, 15);
			label8.TabIndex = 32;
			label8.Text = "POST";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(671, 147);
			label9.Name = "label9";
			label9.Size = new Size(60, 15);
			label9.TabIndex = 33;
			label9.Text = "SECTIONS";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(671, 162);
			label10.Name = "label10";
			label10.Size = new Size(51, 15);
			label10.TabIndex = 34;
			label10.Text = "THEMES";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(671, 177);
			label11.Name = "label11";
			label11.Size = new Size(40, 15);
			label11.TabIndex = 35;
			label11.Text = "USERS";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(671, 192);
			label12.Name = "label12";
			label12.Size = new Size(98, 15);
			label12.TabIndex = 36;
			label12.Text = "USERS_SPECIFIED";
			// 
			// btTo_Excel
			// 
			btTo_Excel.Location = new Point(637, 237);
			btTo_Excel.Name = "btTo_Excel";
			btTo_Excel.Size = new Size(123, 93);
			btTo_Excel.TabIndex = 37;
			btTo_Excel.Text = "To Excel";
			btTo_Excel.UseVisualStyleBackColor = true;
			btTo_Excel.Click += btTo_Excel_Click;
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// btPrint
			// 
			btPrint.Location = new Point(637, 12);
			btPrint.Name = "btPrint";
			btPrint.Size = new Size(123, 23);
			btPrint.TabIndex = 38;
			btPrint.Text = "Print";
			btPrint.UseVisualStyleBackColor = true;
			btPrint.Click += btPrint_Click;
			// 
			// Admin_console
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 655);
			Controls.Add(btPrint);
			Controls.Add(btTo_Excel);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(Back_to_Admin_Panel);
			Controls.Add(SendQuery);
			Controls.Add(SelfQuery);
			Controls.Add(CustomQueryTextBox);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			Name = "Admin_console";
			Text = "Admin console";
			FormClosed += Admin_console_FormClosed;
			Load += Admin_console_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label8;
		private DataGridView dataGridView1;
		private TextBox CustomQueryTextBox;
		private Label SelfQuery;
		private Button SendQuery;
		private Label Back_to_Admin_Panel;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Button btTo_Excel;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private Button btPrint;
	}
}