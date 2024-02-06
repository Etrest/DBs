using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;


namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Получаем текущие дату и время, выводим их в консоль
			Console.WriteLine("Сейчас " + DateTime.Now);
			// Ждем ввода любой клавиши чтобы окно не закрылось

			ConsoleKeyInfo keyInfo;

			string connectionString = @"Data Source=DESKTOP-5NBK8KU\MSSQLSERVER1;Initial Catalog=kurspr5sem;Integrated Security=True; TrustServerCertificate=True";
			// connect to db
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// open db
				connection.Open();
				// получаем данные из таблицы
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [POST]", connection);
				DataSet dataset = new DataSet();
				int rows = adapter.Fill(dataset, "[POST]");
				// построчно считываем данные
				int i = 0;
				foreach (DataRow row in dataset.Tables["[POST]"].Rows)
				{
					
					int tid = (int)row["SENDER_ID"];
					string msgtxt = (string)row["MSG_TXT"];
					// выводим на экран
					Console.WriteLine("КодМеста={0}, Название={1}", tid, msgtxt);

					// ждем ввода символа чтобы окно не закрылось
					Console.ReadLine();
					i++;
					if(i == 10)
					{
						connection.Close();
						break;
					}
				}
				i = 0;


				using (connection)
				{
					// open db
					connection.Open();
					// init sql Command
					using (SqlCommand command = new SqlCommand())
					{
						// connection
						command.Connection = connection;
						// Count
						command.CommandText = "SELECT COUNT(*) from POST";
						object result1 = command.ExecuteScalar();
						// выводим на экран
						Console.WriteLine("Число записей={0}", result1);
						// MIN
						command.CommandText = "SELECT MIN(SENDER_ID) from POST";
						object result2 = command.ExecuteScalar();
						// выводим на экран
						Console.WriteLine("MIN (SENDER_ID)={0}", result2);
						// ждем ввода символа чтобы окно не закрылось
						Console.ReadLine();
					}
				}

				SqlConnection con2 = new SqlConnection(connectionString);
				using (con2)
				{
					// open db
					con2.Open();
					// добавляем данные
					string SQLQuery1 = "SET IDENTITY_INSERT lr2 ON INSERT INTO lr2(id, val, cost) VALUES (@Id1, @N1, 10)";
					// insert into post values (@txt, (select name_theme from themes where id = @id), @id, getdate(), (select id from users where nickname = @nk))
					using (SqlCommand cmd1 = new SqlCommand(SQLQuery1, con2))
					{
						// заполняем значения
						cmd1.Parameters.AddWithValue("@Id1", 10);
						cmd1.Parameters.AddWithValue("@N1", "name1");
						// выполняем запрос
						cmd1.ExecuteNonQuery();
					}

					string SQLQuery2 = "SET IDENTITY_INSERT lr2 ON INSERT INTO lr2(id, val, cost) VALUES (@Id2, @N2, 10)";
					using (SqlCommand cmd2 = new SqlCommand(SQLQuery2, con2))
					{
						cmd2.Parameters.AddWithValue("@Id2", 11);
						cmd2.Parameters.AddWithValue("@N2", "name2");
						// выполняем запрос
						cmd2.ExecuteNonQuery();
					}
					con2.Close();
				}

				do
				{
					keyInfo = Console.ReadKey();

					// Ваш код для вывода текста
					Console.WriteLine("| Текст после нажатия на клавишу");
				}
				while (keyInfo.Key != ConsoleKey.Escape);
			}
		}
	}
}
