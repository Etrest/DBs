using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace kurspr5sem
{
	public partial class Section_menu : Form
	{
		public UserInfo user;
		public DB dB;

		public Section_menu(UserInfo user, DB dB)
		{
			this.user = user;
			this.dB = dB;
			InitializeComponent();
			Load_Buttons(user);
			dB.OpenCon();
			User_nickname_and_page.Text = user.nick;
			User_nickname_and_page.Tag = user.nick;
			if(this.user.adm_status < 1)
			{
				Sec_name_Text_box.Hide();
				Create_Sec_But.Hide();
				To_banned_list.Hide();
				To_admin_panel.Hide();
				lbCreate_Sec.Hide();
			}
		}



		private void Log_Out_But_Click(object sender, EventArgs e)
		{
			this.Hide();
			var backTo = new Login_Win();
			backTo.Show();
		}

		private void Item_But_Click(object sender, EventArgs e, MenuElem menuElem, UserInfo user)
		{
			this.Hide();
			Forum_menu forumMenu = new Forum_menu(user, menuElem.item_id);
			forumMenu.Show();
		}

		private void Create_Sec_But_Click(object sender, EventArgs e)
		{

			dB.OpenCon();
			SqlCommand cmd = new SqlCommand("Insert into DBO.SECTIONS VALUES (@name, ((select top 1 SECTION_ORDER from DBO.SECTIONS ORDER BY SECTION_ORDER DESC ) + 1), 0, 0 )", dB.GetCon());
			cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = Sec_name_Text_box.Text;
			if (Sec_name_Text_box.Text == "" || Sec_name_Text_box.Text == " " || Sec_name_Text_box == null)
			{
				MessageBox.Show("Field is empty");
				return;
			}

			if (cmd.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("Something went wrong");
				this.Update();
			}
			else
			{
				MessageBox.Show("Section has been added");
				this.Invalidate();
			}
			dB.CloseCon();



		}

		private void Load_Buttons(UserInfo user)
		{

			int count_of;
			dB.OpenCon();

			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select top 1 id from DBO.SECTIONS order by id desc", dB.GetCon());

			adapter.SelectCommand = cmd;
			adapter.Fill(dt);

			count_of = (int)cmd.ExecuteScalar();

			string name_to_btn = "noname";
			Button[] btn = new Button[count_of];
			EventArgs Item_Event = new EventArgs();
			MenuElem[] sections = new MenuElem[count_of];




			for (int i = 0; i < count_of; i++)
			{
				string name_item = " ";
				int count_item;
				int id_item;

				if (dt.Rows.Count == 1)
				{
					cmd = new SqlCommand("select id from SECTIONS WHERE ID = @count_of", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					id_item = (int)cmd.ExecuteScalar();
					cmd = new SqlCommand("select NAME_SECTION from SECTIONS WHERE ID = @count_of", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					name_item = (string)cmd.ExecuteScalar();
					cmd = new SqlCommand("select COUNT_OF_FORUMS from SECTIONS WHERE ID = @count_of", dB.GetCon());
					cmd.Parameters.Add("@count_of", SqlDbType.Int).Value = i + 1;
					count_item = (int)cmd.ExecuteScalar();

					sections[i] = new MenuElem(id_item, name_item, count_item);


					name_to_btn = sections[i].item_name;
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
					btn[i].Click += (sender, e) => Item_But_Click(btn[currentIt], e, sections[currentIt], user);

				}

			}
			dB.CloseCon();

		}



		private void To_banned_list_Click(object sender, EventArgs e)
		{
			this.Hide();
			Banned_list bn = new Banned_list(user, dB);
			bn.Show();
		}

		private void To_admin_panel_Click(object sender, EventArgs e)
		{
			this.Hide();
			Admin_panel ap = new Admin_panel(user, dB);
			ap.Show();
		}

		private void User_nickname_and_page_Click(object sender, EventArgs e, string user_nickname)
		{
			User_page up = new User_page(user, this, dB);
			this.Hide();
			up.ShowDialog();
		}

		private void Section_menu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
