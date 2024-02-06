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
	public partial class Admin_panel : Form
	{
		UserInfo user;
		DB dB;

		public Admin_panel(UserInfo user, DB dB)
		{
			InitializeComponent();
			this.user = user;
			this.dB = dB;
			LoadData(this.dB);
		}

		private void To_admin_console_Click(object sender, EventArgs e)
		{
			if(this.user.adm_status < 3)
			{
				MessageBox.Show("Access denied");
				return;
			}

			Admin_console console = new Admin_console(user, dB);
			this.Hide();
			console.Show();
		}

		private void Save_DB_Click(object sender, EventArgs e)
		{
			dB.OpenCon();
			SqlCommand cmd = new SqlCommand("backup database kurspr5sem to disk = 'E:\\backup\\kurspr5sem.bak'", dB.GetCon());
			cmd.ExecuteNonQuery();
			MessageBox.Show("DB saved");

			dB.CloseCon();
		}

		private void Back_to_sections_Click(object sender, EventArgs e)
		{
			Section_menu sm = new Section_menu(user, dB);
			this.Hide();
			sm.Show();
		}

		private void To_Excel_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application exEx = new Microsoft.Office.Interop.Excel.Application();
			System.Data.DataTable dt = new System.Data.DataTable();
			int count = 0;
			string command = "forum_log";
			SqlCommand cmd = cmdSelect(command, dB);
			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			ad.Fill(dt);

			exEx.Workbooks.Add(Type.Missing);
			Microsoft.Office.Interop.Excel.Worksheet wsh = (Microsoft.Office.Interop.Excel.Worksheet)exEx.ActiveSheet;
			dataGridView1.DataSource = dt;
			for (int i = 0; i <= dataGridView1.RowCount; i++)
			{
				for (int j = 0; j < dataGridView1.ColumnCount; i++)
				{

					wsh.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();



				}
			}
			wsh.SaveAs("testbook");
			command = "ADMIN_STATUS";
			cmd = cmdSelect(command, dB);


			exEx.Visible = true;
		}

		private SqlCommand cmdSelect(string str, DB dB)
		{
			SqlCommand cmd = new SqlCommand($"select * from {str}", dB.GetCon());
			return cmd;
		}


		private void LoadData(DB dB)
		{

			SqlCommand cmd = new SqlCommand($"select * from Users", dB.GetCon());
			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			dataGridView1.DataSource = dt;

		}

		private void To_Admin_but_Click(object sender, EventArgs e)
		{
			dB.OpenCon();
			SqlCommand cmd = new SqlCommand("update access_level set acc_lev = 1 where nickname = @nk", dB.GetCon());
			cmd.Parameters.Add("@nk", SqlDbType.NVarChar).Value = textBox1.Text;
			if (cmd.ExecuteNonQuery() == 1)
			{
				MessageBox.Show($"Hail to new admin {textBox1.Text}!");
			}
			cmd = new SqlCommand("Select * from Access_level where acc_lev > 0 order by NICKNAME", dB.GetCon());

			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			ad.Fill(dt);
			dataGridView1.DataSource = dt;
			dB.CloseCon();

		}

		private void Ban_but_Click(object sender, EventArgs e)
		{
			dB.OpenCon();

			SqlCommand cmd = new SqlCommand("insert into FORUM_SECURITY(NICKNAME, BANNED_STATUS, BAN_REASON) VALUES (@nk, 1, null)", dB.GetCon());
			cmd.Parameters.Add("@nk", SqlDbType.NVarChar).Value = textBox1.Text;
			if (cmd.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("Something went wrong");
			}
			else
			{
				MessageBox.Show("User was banned");
			}
			dB.CloseCon();
		}

		private void Admin_panel_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
