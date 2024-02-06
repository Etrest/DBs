using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace kurspr5sem
{
	public partial class Reg_Win : Form
	{
		public Reg_Win()
		{
			InitializeComponent();
		}

		private void Back_to_Login_Click(object sender, EventArgs e)
		{
			this.Hide();
			var backTo = new Login_Win();
			backTo.Show();

		}

		private void Reg_but_Click(object sender, EventArgs e)
		{
			DB dB = new DB();
			if (tbPass.Text != tbConPass.Text || tbLog.Text == null || tbLog.Text == " " || tbPass.Text == null || tbPass.Text == " ")
			{
				MessageBox.Show("Check your entered data");
			}
			else
			{
				dB.OpenCon();

				var nick = tbLog.Text;
				var pwd = tbConPass.Text;
				if (UserEx(nick))
					return;


				SqlDataAdapter adapter = new SqlDataAdapter();
				SqlCommand cmd = new SqlCommand("insert into DBO.USERS values (@nick, @pwd, 0, 0, ' ', 0, null)", dB.GetCon());
				cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
				cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;

				if (cmd.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Something went wrong");
				}
				else
				{
					MessageBox.Show("Account has been created");
				}
			}
			dB.CloseCon();

		}

		public Boolean UserEx(String nick)
		{
			bool uniq = true;

			DB conn = new DB();
			conn.OpenCon();


			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select * from DBO.USERS where NICKNAME = @nick", conn.GetCon());
			cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
			SqlDataAdapter sqlAdapter = new SqlDataAdapter();
			sqlAdapter.SelectCommand = cmd;
			sqlAdapter.Fill(dt);
			if (dt.Rows.Count >= 1)
			{
				MessageBox.Show("There is already such user");
			}
			else
			{
				uniq = false;
			}

			return uniq;
		}

		private void Reg_Win_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
