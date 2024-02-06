namespace kurspr5sem
{
	partial class User_page
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
			pictureBox1 = new PictureBox();
			lbNick = new Label();
			lbTrueName = new Label();
			lbSur = new Label();
			User_Disc = new ListBox();
			Back_to_Section = new Label();
			Change_info_but = new Button();
			tbSur = new TextBox();
			tbName = new TextBox();
			tbDesc = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(45, 35);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(108, 97);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// lbNick
			// 
			lbNick.AutoSize = true;
			lbNick.Location = new Point(159, 44);
			lbNick.Name = "lbNick";
			lbNick.Size = new Size(61, 15);
			lbNick.TabIndex = 1;
			lbNick.Text = "Nickname";
			lbNick.Click += lbNick_Click;
			// 
			// lbTrueName
			// 
			lbTrueName.AutoSize = true;
			lbTrueName.Location = new Point(159, 68);
			lbTrueName.Name = "lbTrueName";
			lbTrueName.Size = new Size(64, 15);
			lbTrueName.TabIndex = 2;
			lbTrueName.Text = "True Name";
			// 
			// lbSur
			// 
			lbSur.AutoSize = true;
			lbSur.Location = new Point(159, 94);
			lbSur.Name = "lbSur";
			lbSur.Size = new Size(79, 15);
			lbSur.TabIndex = 3;
			lbSur.Text = "True Surname";
			// 
			// User_Disc
			// 
			User_Disc.FormattingEnabled = true;
			User_Disc.ItemHeight = 15;
			User_Disc.Location = new Point(45, 152);
			User_Disc.Name = "User_Disc";
			User_Disc.Size = new Size(222, 259);
			User_Disc.TabIndex = 4;
			// 
			// Back_to_Section
			// 
			Back_to_Section.AutoSize = true;
			Back_to_Section.Location = new Point(12, 9);
			Back_to_Section.Name = "Back_to_Section";
			Back_to_Section.Size = new Size(20, 15);
			Back_to_Section.TabIndex = 5;
			Back_to_Section.Text = "<-";
			Back_to_Section.Click += Back_to_Section_Click;
			// 
			// Change_info_but
			// 
			Change_info_but.Location = new Point(272, 179);
			Change_info_but.Name = "Change_info_but";
			Change_info_but.Size = new Size(100, 23);
			Change_info_but.TabIndex = 6;
			Change_info_but.Text = "Change info";
			Change_info_but.UseVisualStyleBackColor = true;
			Change_info_but.Click += Change_info_but_Click;
			// 
			// tbSur
			// 
			tbSur.Location = new Point(272, 94);
			tbSur.Name = "tbSur";
			tbSur.Size = new Size(100, 23);
			tbSur.TabIndex = 7;
			// 
			// tbName
			// 
			tbName.Location = new Point(272, 65);
			tbName.Name = "tbName";
			tbName.Size = new Size(100, 23);
			tbName.TabIndex = 8;
			// 
			// tbDesc
			// 
			tbDesc.Location = new Point(272, 152);
			tbDesc.Name = "tbDesc";
			tbDesc.Size = new Size(100, 23);
			tbDesc.TabIndex = 9;
			// 
			// User_page
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(452, 463);
			Controls.Add(tbDesc);
			Controls.Add(tbName);
			Controls.Add(tbSur);
			Controls.Add(Change_info_but);
			Controls.Add(Back_to_Section);
			Controls.Add(User_Disc);
			Controls.Add(lbSur);
			Controls.Add(lbTrueName);
			Controls.Add(lbNick);
			Controls.Add(pictureBox1);
			Name = "User_page";
			Text = "User_page";
			FormClosed += User_page_FormClosed;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label lbNick;
		private Label lbTrueName;
		private Label lbSur;
		private ListBox User_Disc;
		private Label Back_to_Section;
		private Button Change_info_but;
		private TextBox tbSur;
		private TextBox tbName;
		private TextBox tbDesc;
	}
}