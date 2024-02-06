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
	public partial class User_page : Form
	{
		UserInfo user;
		Form back_to;
		DB dB;

		public User_page(UserInfo user, Form from, DB dB)
		{

			this.user = user;
			this.back_to = from;
			this.dB = dB;
			dB.OpenCon();

			InitializeComponent();


			Load_Desk(dB);



			SqlCommand cmd = new SqlCommand("Select TRUE_NAME FROM USERS_SPECIFIED WHERE NICKNAME = @ud", dB.GetCon());
			cmd.Parameters.Add("@ud", SqlDbType.NVarChar).Value = this.user.nick;

			this.lbNick.Text = user.nick;
			if (cmd.ExecuteScalar() == System.DBNull.Value)
				this.lbTrueName.Text = " ";
			else
				this.lbTrueName.Text = (String)cmd.ExecuteScalar();

			cmd = new SqlCommand("Select TRUE_SURNAME FROM USERS_SPECIFIED WHERE NICKNAME = @ud", dB.GetCon());
			cmd.Parameters.Add("@ud", SqlDbType.NVarChar).Value = this.user.nick;

			this.lbNick.Text = user.nick;
			if (cmd.ExecuteScalar() == System.DBNull.Value)
				this.lbSur.Text = " ";
			else
				this.lbSur.Text = (String)cmd.ExecuteScalar();



		}

		private void Change_info_but_Click(object sender, EventArgs e)
		{

			if (tbName.Text == null || tbName.Text == " " || tbSur.Text == null || tbSur.Text == " ")
			{
				MessageBox.Show("Check your entered data");
			}
			else
			{
				if (tbDesc == null)
				{
					SqlCommand cmd = new SqlCommand("update USERS_SPECIFIED set TRUE_NAME = @tn, " +
				"TRUE_SURNAME = @ts " +
				"where NICKNAME = @nk", dB.GetCon());
					cmd.Parameters.Add("@tn", SqlDbType.NVarChar).Value = this.tbName.Text;
					cmd.Parameters.Add("@ts", SqlDbType.NVarChar).Value = this.tbSur.Text;
					cmd.Parameters.Add("@nk", SqlDbType.NVarChar).Value = this.user.nick;
					int i = cmd.ExecuteNonQuery();
					if (cmd.ExecuteNonQuery() >= 1)
					{
						MessageBox.Show("Settings has been updated");
					}
					else
					{
						MessageBox.Show("Something went wrong");
					}
				}
				else
				{
					SqlCommand cmd = new SqlCommand("update USERS_SPECIFIED set TRUE_NAME = @tn, " +
				"TRUE_SURNAME = @ts, " +
				"USER_DESCRIPTION = @ud " +
				"where NICKNAME = @nk", dB.GetCon());
					cmd.Parameters.Add("@tn", SqlDbType.NVarChar).Value = this.tbName.Text;
					cmd.Parameters.Add("@ts", SqlDbType.NVarChar).Value = this.tbSur.Text;
					cmd.Parameters.Add("@ud", SqlDbType.NVarChar).Value = this.tbDesc.Text;
					cmd.Parameters.Add("@nk", SqlDbType.NVarChar).Value = this.user.nick;
					int i;
					cmd.ExecuteNonQuery();
					i = cmd.ExecuteNonQuery();
					if (i >= 1)
					{
						MessageBox.Show("Data was updated");
					}
					else
					{
						MessageBox.Show("Something went wrong");
					}
				}
				User_page up = new User_page(user, back_to, dB);
				this.Hide();
				up.Show();


			}

		}

		private void Back_to_Section_Click(object sender, EventArgs e)
		{
			dB.CloseCon();
			this.Hide();
			back_to.Show();
		}

		private void lbNick_Click(object sender, EventArgs e)
		{

		}

		private void Load_Desk(DB dB)
		{
			String desc;
			SqlCommand cmd = new SqlCommand("Select USER_DESCRIPTION FROM USERS_SPECIFIED WHERE NICKNAME = @ud", dB.GetCon());
			cmd.Parameters.Add("@ud", SqlDbType.NVarChar).Value = this.user.nick;
			if(cmd.ExecuteScalar() == System.DBNull.Value)
			{
				desc = "";
			}
			else
				desc = (String)cmd.ExecuteScalar();
			this.User_Disc.Items.Add(desc);
		}

		private void User_page_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
