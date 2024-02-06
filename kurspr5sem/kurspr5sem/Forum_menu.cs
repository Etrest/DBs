using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurspr5sem
{
	public partial class Forum_menu : Form
	{
		UserInfo user;
		int section_id;
		DB dB = new DB();

		public Forum_menu(UserInfo user, int section_id)
		{
			this.user = user;
			this.section_id = section_id;
			InitializeComponent();
			Load_Buttons(this.user, this.section_id);
			this.User_nickname_and_page.Text = this.user.nick;
			if(this.user.acc_level < 1)
			{
				Create_Forum_But.Hide();
				lbCreate_Forum.Hide();
				Forum_name_Text_box.Hide();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lbCreate_Sec_Click(object sender, EventArgs e)
		{

		}

		private void Load_Buttons(UserInfo user, int sec_id)
		{

			int count_of;
			dB.OpenCon();

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select top 1 id from DBO.FORUMS where SECTION_ID = @si  order by id desc", dB.GetCon());
			cmd.Parameters.Add("@si", SqlDbType.NVarChar).Value = sec_id;
			adapter.SelectCommand = cmd;
			adapter.Fill(dt);
			count_of = 0;
			if (cmd.ExecuteScalar() == null)
				count_of = 0;
			else
				count_of = (int)cmd.ExecuteScalar();

			string name_to_btn = "noname";
			Button[] btn = new Button[count_of];
			EventArgs Item_Event = new EventArgs();
			MenuElem[] forums = new MenuElem[count_of];




			for (int i = 0; i < count_of; i++)
			{
				string name_item = " ";
				int count_item;
				int id_item;

				if (dt.Rows.Count == 1)
				{
					cmd = new SqlCommand("select id from FORUMS WHERE ID = @count_of and SECTION_ID = @si", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@si", SqlDbType.NVarChar).Value = sec_id;
					id_item = 0;
					if (cmd.ExecuteScalar() == null)
						id_item = 0;
					else
						id_item = (int)cmd.ExecuteScalar();

					cmd = new SqlCommand("select NAME_FORUM from FORUMS WHERE ID = @count_of and SECTION_ID = @si", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@si", SqlDbType.NVarChar).Value = sec_id;


					name_item = (string)cmd.ExecuteScalar();

					cmd = new SqlCommand("select COUNT_OF_THEMES from FORUMS WHERE ID = @count_of and SECTION_ID = @si", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@si", SqlDbType.NVarChar).Value = sec_id;

					count_item = 0;
					if (cmd.ExecuteScalar() == null)
						count_item = 0;
					else
						count_item = (int)cmd.ExecuteScalar();

					forums[i] = new MenuElem(id_item, name_item, count_item);


					name_to_btn = forums[i].item_name;
					btn[i] = new Button();
					btn[i].Height = 84;
					btn[i].Width = 355;
					if (i == 0)
					{
						btn[i].Location = new Point(240, 12);
					}
					else
					{
						btn[i].Location = new Point(btn[i - 1].Location.X, btn[i - 1].Location.Y + 104);
					}
					btn[i].Text = name_to_btn;
					int currentIt = i;
					this.Controls.Add(btn[i]);
					btn[i].Click += (sender, e) => Item_But_Click(btn[currentIt], e, forums[currentIt], user);

				}

			}
			dB.CloseCon();

		}

		private void Item_But_Click(object sender, EventArgs e, MenuElem menuElem, UserInfo user)
		{
			this.Hide();
			Themes_Menu themeMenu = new Themes_Menu(user, menuElem.item_id, this);
			themeMenu.Show();
		}

		private void User_nickname_and_page_Click(object sender, EventArgs e)
		{
			User_page up = new User_page(user, this, dB);
			this.Hide();
			up.ShowDialog();
		}

		private void Back_to_sections_Click(object sender, EventArgs e)
		{
			Section_menu sm = new Section_menu(this.user, this.dB);
			this.Hide();
			sm.Show();
		}

		private void Create_Forum_But_Click(object sender, EventArgs e)
		{
			if (Forum_name_Text_box.Text == "" || Forum_name_Text_box.Text == " ")
			{
				MessageBox.Show("Check your data");
				return;
			}


			dB.OpenCon();

			SqlCommand cmd = new SqlCommand("insert into FORUMS(NAME_FORUM, TYPE_OF, SECTION_ID, COUNT_OF_THEMES, COUNT_OF_MSG, FORUM_ORDER) VALUES (@nm, 0, @si, 0, 0, ((SELECT TOP 1 ID FROM FORUMS order by id DESC) + 1))", dB.GetCon());
			cmd.Parameters.Add("@nm", SqlDbType.NVarChar).Value = Forum_name_Text_box.Text;
			cmd.Parameters.Add("@si", SqlDbType.Int).Value = this.section_id;
			if (cmd.ExecuteNonQuery() == 1)
			{

				MessageBox.Show("Something went wrong");


			}
			else
			{

				MessageBox.Show("Forum was added");

				Forum_menu fm = new Forum_menu(this.user, this.section_id);
				this.Hide();
				fm.Show();
			}

			dB.CloseCon();
		}

		private void Forum_menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
