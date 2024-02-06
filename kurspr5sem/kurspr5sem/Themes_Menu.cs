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
	public partial class Themes_Menu : Form
	{
		UserInfo user;
		int forum_id;
		DB dB = new DB();
		Forum_menu fm;

		public Themes_Menu(UserInfo user, int forum_id, Forum_menu fm)
		{
			InitializeComponent();
			this.user = user;
			this.forum_id = forum_id;
			this.fm = fm;
			Load_Buttons(user, forum_id);
			this.User_nickname_and_page.Text = this.user.nick;
			if (this.user.acc_level < 1)
			{
				lbCreate_Theme.Hide();
				Theme_name_Text_box.Hide();
				Start_msg.Hide();
				tbStart_msg.Hide();
				Create_Theme_But.Hide();
			}
		}

		private void Load_Buttons(UserInfo user, int for_id)
		{

			int count_of;
			dB.OpenCon();

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select top 1 id from DBO.themes where forum_ID = @si  order by id desc", dB.GetCon());
			cmd.Parameters.Add("@si", SqlDbType.NVarChar).Value = for_id;
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
			MenuElem[] themes = new MenuElem[count_of];




			for (int i = 0; i < count_of; i++)
			{
				string name_item = " ";
				int count_item;
				int id_item;

				if (dt.Rows.Count == 1)
				{
					cmd = new SqlCommand("select id from themes WHERE ID = @count_of and forum_id = @fi", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@fi", SqlDbType.NVarChar).Value = for_id;
					id_item = 0;
					if (cmd.ExecuteScalar() == null)
						id_item = 0;
					else
						id_item = (int)cmd.ExecuteScalar();

					cmd = new SqlCommand("select NAME_THEME from THEMES WHERE ID = @count_of and forum_id = @fi", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@fi", SqlDbType.NVarChar).Value = for_id;


					name_item = (string)cmd.ExecuteScalar();

					cmd = new SqlCommand("select COUNT_OF_MSG from THEMES WHERE ID = @count_of and forum_id = @fi", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					cmd.Parameters.Add("@fi", SqlDbType.NVarChar).Value = for_id;

					count_item = 0;
					if (cmd.ExecuteScalar() == null)
						count_item = 0;
					else
						count_item = (int)cmd.ExecuteScalar();

					themes[i] = new MenuElem(id_item, name_item, count_item);


					name_to_btn = themes[i].item_name;
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
					btn[i].Click += (sender, e) => Item_But_Click(btn[currentIt], e, themes[currentIt], user);

				}

			}
			dB.CloseCon();

		}
		private void Item_But_Click(object sender, EventArgs e, MenuElem menuElem, UserInfo user)
		{
			this.Hide();
			Theme_tread tt = new Theme_tread(user, menuElem.item_id, this.lbTheme.Text, this);
			tt.Show();
		}

		private void Create_Theme_But_Click(object sender, EventArgs e)
		{
			if (Theme_name_Text_box.Text == "" || Theme_name_Text_box.Text == " " || tbStart_msg.Text == " " || tbStart_msg.Text == "")
			{
				MessageBox.Show("Check your data");
				return;
			}


			dB.OpenCon();

			SqlCommand cmd = new SqlCommand("insert into themes(FORUM_id, NAME_THEME, TYPE_OF, COUNT_OF_MSG, START_MSG_USR_ID, LAST_MSG_USER_ID, START_MSG_TXT) VALUES (@fm, @nm, 0, 0, (Select id from users where nickname = @un), (Select id from users where nickname = @un), @txt)", dB.GetCon());
			cmd.Parameters.Add("@nm", SqlDbType.NVarChar).Value = Theme_name_Text_box.Text;
			cmd.Parameters.Add("@fm", SqlDbType.Int).Value = this.forum_id;
			cmd.Parameters.Add("@un", SqlDbType.NVarChar).Value = this.user.nick;
			cmd.Parameters.Add("@txt", SqlDbType.NVarChar).Value = tbStart_msg.Text;
			if (cmd.ExecuteNonQuery() == 1)
			{

				MessageBox.Show("Something went wrong");


			}
			else
			{

				MessageBox.Show("Theme was added");

			}
			cmd = new SqlCommand("insert into post values (@txt, @nm, (select id from Themes where name_theme = @nm), GetDate(), (Select id from users where nickname = @un))");
			cmd.Parameters.Add("@txt", SqlDbType.Int).Value = tbStart_msg.Text;
			cmd.Parameters.Add("@nm", SqlDbType.NVarChar).Value = Theme_name_Text_box.Text;
			cmd.Parameters.Add("@un", SqlDbType.NVarChar).Value = this.user.nick;

			dB.CloseCon();
			Themes_Menu tm = new Themes_Menu(this.user, this.forum_id, this.fm);
			this.Hide();
			tm.Show();
		}

		private void Back_to_Forums_Click(object sender, EventArgs e)
		{
			this.Hide();
			fm.Show();
		}

		private void Themes_Menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
