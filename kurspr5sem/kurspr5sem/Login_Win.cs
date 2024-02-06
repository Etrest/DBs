using System.Data;
using Microsoft.Data.SqlClient;


namespace kurspr5sem
{
	public partial class Login_Win : Form
	{
		public UserInfo user;
		public DB dB = new DB();

		public Login_Win()
		{
			
			InitializeComponent();
			tbLogin.Text = "admin";
			tbPasswd.Text = "admin";
		}

		private void To_regist_Click(object sender, EventArgs e)
		{//переходим к странице регистрации
			this.Hide();
			var Reg_win_op = new Reg_Win();
			Reg_win_op.Show();
		}


		private void log_but_Click_1(object sender, EventArgs e)
		{

			try
			{
				BannedCatch();
			}
			catch (Exception ex)
			{
				var filePath = string.Empty;
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					MessageBox.Show(ex + "DB is damaged. Please, restore it.");

					openFileDialog.InitialDirectory = "E:\\";
					openFileDialog.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
					openFileDialog.FilterIndex = 2;
					openFileDialog.RestoreDirectory = true;
					if(openFileDialog.ShowDialog() == DialogResult.OK)
					{
						filePath = openFileDialog.FileName;
						SqlCommand cmd = new SqlCommand("restore database kurspr5sem from disk ='@fd' WITH REPLACE");
						cmd.Parameters.Add("@fd", SqlDbType.NVarChar).Value = filePath;
						//if(cmd.ExecuteNonQuery() == 1)
						//{
						//	MessageBox.Show("DB was successfully restored");
						//}
					}
					this.dB = new DB();
					this.dB.conn = new SqlConnection(@"Data Source=DESKTOP-5NBK8KU\MSSQLSERVER1;Initial Catalog=kurspr5sem;Integrated Security=True; TrustServerCertificate=True");
					this.dB.conn.Open();
					loginCourse();
				}
			}

			
				


		}

		private void Login_Win_Load(object sender, EventArgs e)
		{
			

			
		}

		private void loginCourse()
		{
			dB.OpenCon();

			String nick = this.tbLogin.Text;
			String pwd = this.tbPasswd.Text;

			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select * from DBO.USERS where NICKNAME = @nick and PASSWD = @pwd", dB.GetCon());
			cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
			cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;
			SqlDataAdapter sqlAdapter = new SqlDataAdapter();
			sqlAdapter.SelectCommand = cmd;
			sqlAdapter.Fill(dt);
			if (dt.Rows.Count == 1)
			{
				cmd = new SqlCommand("select ACC_LEV from DBO.ACCESS_LEVEL where NICKNAME = @nick", dB.GetCon());
				cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
				var acc_l = (int)cmd.ExecuteScalar();
				cmd = new SqlCommand("select ADM_STATUS from DBO.ADMIN_STATUS where NICKNAME = @nick", dB.GetCon());
				cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
				sqlAdapter.SelectCommand = cmd;
				dt.Clear();
				sqlAdapter.Fill(dt);
				var acc_s = 0;
				if (dt.Rows.Count == 0)
				{
					acc_s = 0;
				}
				else
				{
					acc_s = (int)cmd.ExecuteScalar();
				}
				user = new UserInfo(nick, acc_l, acc_s);
				Section_menu to_win = new Section_menu(user, dB);
				this.Hide();
				to_win.Show();

			}
			else
			{
				MessageBox.Show("There is no such user or you entered wrong password. Try again.");
				dB.CloseCon();
			}
		}

		private void BannedCatch()
		{
			dB.OpenCon();

			string nick = tbLogin.Text;
			DataTable dt = new DataTable();	
			SqlCommand cmd = new SqlCommand("select * from DBO.FORUM_SECURITY where NICKNAME = @nick", dB.GetCon());
			cmd.Parameters.Add("@nick", SqlDbType.NVarChar).Value = nick;
			SqlDataAdapter sqlAdapter = new SqlDataAdapter();
			sqlAdapter.SelectCommand = cmd;
			sqlAdapter.Fill(dt);
			if (dt.Rows.Count == 1)
			{
				MessageBox.Show("You are banned");
			}
			else
			{
				loginCourse();
			}
		}
	}
}