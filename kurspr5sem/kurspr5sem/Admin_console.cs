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
	public partial class Admin_console : Form
	{
		UserInfo user;
		DB dB;
		Bitmap bmp;
		PrintPreviewDialog previewDialog = new PrintPreviewDialog();
		public Admin_console(UserInfo user, DB dB)
		{
			this.user = user;
			this.dB = dB;
			InitializeComponent();
			string comm = "Select * from FORUM_LOG";
			LoadData(dB, comm);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void LoadData(DB dB, string comm)
		{
			SqlCommand cmd = new SqlCommand(comm, dB.GetCon());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void SendQuery_Click(object sender, EventArgs e)
		{
			if (CustomQueryTextBox.Text == "")
			{
				MessageBox.Show("You left query field empty");
				return;
			}
			else
			{
				try
				{
					{
						dB.OpenCon();

						string comm = CustomQueryTextBox.Text;

						SqlCommand cmd = new SqlCommand(comm, dB.GetCon());
						SqlDataAdapter adapter = new SqlDataAdapter(cmd);

						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridView1.DataSource = dt;
						dataGridView1.Refresh();
						dB.CloseCon();
						if (dataGridView1.Rows.Count == 0)
						{
							string def_com = "Select * from FORUM_LOG";
							LoadData(dB, def_com);

						}
						else
							LoadData(dB, comm);

						MessageBox.Show("Command executed");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			}
		}

		private void Back_to_Admin_Panel_Click(object sender, EventArgs e)
		{
			Admin_panel ap = new Admin_panel(user, dB);
			this.Hide();
			ap.Show();
		}

		private void btTo_Excel_Click(object sender, EventArgs e)
		{

			if (dataGridView1[0, 0].Value == null)
			{
				MessageBox.Show("Select data");
				return;
			}

			Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 15;
			for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
			{
				for (int j = 0; j < dataGridView1.RowCount - 1; j++)
				{
					ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
				}
			}
			ExcelApp.Visible = true;

		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			e.Graphics?.DrawImage(bmp, 0, 0);

		}

		private void btPrint_Click(object sender, EventArgs e)
		{

			if (dataGridView1[0, 0].Value == null)
			{
				MessageBox.Show("Select data");
				return;
			}


			var height = dataGridView1.Height;
			dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
			bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);

			dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
			dataGridView1.Height = height;

			previewDialog.Document = printDocument1;
			previewDialog.ShowDialog();

		}

		private void Admin_console_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Admin_console_Load(object sender, EventArgs e)
		{

		}
	}
}
