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

	public partial class Banned_list : Form
	{

		public UserInfo user;
		public DB dB;

		public Banned_list(UserInfo user, DB dB)
		{
			this.user = user;
			this.dB = dB;
			InitializeComponent();
			Load_Data();
		}

		private void Load_Data()
		{
			DB dB = new DB();
			DataTable dt = new DataTable();
			dB.OpenCon();

			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand cmd = new SqlCommand("Select * from FORUM_SECURITY", dB.GetCon());
			adapter.SelectCommand = cmd;
			adapter.Fill(dt);

			Danned_List.DataSource = dt;

			dB.CloseCon();
		}

		private void Unban_but_Click(object sender, EventArgs e)
		{
			DB dB = new DB();

			dB.OpenCon();

			SqlCommand sqlCommand = new SqlCommand("UPDATE FORUM_SECURITY SET BANNED_STATUS = 0 WHERE NICKNAME = @nick", dB.GetCon());
			sqlCommand.Parameters.Add("@nick", SqlDbType.NVarChar).Value = tbUnban.Text;
			if (sqlCommand.ExecuteNonQuery() == 1)
			{

				MessageBox.Show("Something went wrong");
				Load_Data();

			}
			else
			{

				MessageBox.Show("User was unbanned");
				Load_Data();

			}

			dB.CloseCon();

		}

		private void Back_to_Admin_panel_Click(object sender, EventArgs e)
		{
			this.Hide();
			Section_menu sm = new Section_menu(user, dB);
			sm.Show();

		}

		private void Banned_list_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
