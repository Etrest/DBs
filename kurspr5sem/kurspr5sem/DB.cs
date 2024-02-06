using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;


//@"

namespace kurspr5sem
{
	public class DB
	{
		public SqlConnection conn;
		public DB()
		{
			this.conn = new SqlConnection(@"Data Source=DESKTOP-5NBK8KU\MSSQLSERVER1;Initial Catalog=kurspr5sem;Integrated Security=True; TrustServerCertificate=True");
		}
		

		public void OpenCon() 
		{
			if(conn.State == System.Data.ConnectionState.Closed) 
			{
				conn.Open();
			}
		}

		public void CloseCon()
		{
			if (conn.State == System.Data.ConnectionState.Open)
			{
				conn.Close();
			}
		}

		public SqlConnection GetCon()
		{
			return conn;
		}
	}
}
