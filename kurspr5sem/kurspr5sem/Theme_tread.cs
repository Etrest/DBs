using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurspr5sem
{
	public partial class Theme_tread : Form
	{

		UserInfo user;
		int theme_id;
		string theme_name;
		Themes_Menu theme_menu;
		DB dB = new DB();

		public Theme_tread(UserInfo user, int theme_id, string theme_name, Themes_Menu themes_Menu)
		{
			this.user = user;
			this.theme_id = theme_id;
			this.theme_name = theme_name;
			this.theme_menu = themes_Menu;
			InitializeComponent();
			this.User_nickname_and_page.Text = this.user.nick;
			LoadThread(user);
		}


		private void LoadThread(UserInfo user)
		{

			thread_log.Items.Clear();
			dB.OpenCon();
			SqlCommand cmd = new SqlCommand("select * from Post where theme_id = @tid", dB.GetCon());
			cmd.Parameters.Add("@tid", SqlDbType.Int).Value = theme_id;
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			int it = 0;

			for (it = 0; it < dt.Rows.Count; it++)
			{

				string time = dt.Rows[it][4].ToString();
				string txt = dt.Rows[it][1].ToString();
				int user_id = Int32.Parse(dt.Rows[it][5].ToString());
				cmd = new SqlCommand("select nickname from users where id = @id", dB.GetCon());
				cmd.Parameters.Add("@id", SqlDbType.Int).Value = user_id;
				string nickname = (string)cmd.ExecuteScalar();
				thread_log.Items.Add($"{time}| {nickname}: {txt}");

			}


			dB.CloseCon();

		}

		private void lbBack_to_Click(object sender, EventArgs e)
		{
			this.theme_menu.Show();
			this.Hide();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			LoadThread(user);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dB.OpenCon();

			SqlCommand cmd = new SqlCommand("insert into post values (@txt, (select name_theme from themes where id = @id), @id, getdate(), (select id from users where nickname = @nk))", this.dB.GetCon());
			cmd.Parameters.Add("@txt", SqlDbType.NVarChar).Value = textBox1.Text;
			cmd.Parameters.Add("@nk", SqlDbType.NVarChar).Value = this.user.nick;
			cmd.Parameters.Add("@id", SqlDbType.Int).Value = this.theme_id;

			if (cmd.ExecuteNonQuery() == 1)
			{
			}
			else
			{
			}

			dB.CloseCon();

			LoadThread(this.user);
		}

		private void Theme_tread_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
