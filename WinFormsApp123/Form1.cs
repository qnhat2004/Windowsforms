using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp123
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string stringConnect = @"Data Source=SUNSHINE;Initial Catalog=demo;Integrated Security=True";
		SqlConnection cnn = null;
		SqlDataAdapter da = null;
		DataTable dt = null;
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cnn = new SqlConnection(stringConnect);
			cnn.Open();
			string sqlCommand = "select * from SACH";
			da = new SqlDataAdapter(sqlCommand, cnn);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			getData();
		}

		// Display data when start
		private void getData()
		{
			string sqlCommand = "select * from SACH";
			da = new SqlDataAdapter(sqlCommand, cnn);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			string sqlCommand = "delete from SACH where MASACH = '" + txt_masach.Text + "'";
			SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
			cmd.ExecuteNonQuery();
			getData();
		}

		private void btn_Luu_Click(object sender, EventArgs e)
		{
			string sqlCommand = "update SACH set TIEUDE = N'" + txt_tieude.Text + "', TACGIA = N'" + textBox7.Text + "', NHAXUATBAN = N'" + textBox2.Text + "', NAMXUATBAN = N'" + textBox8.Text + "', GIA = N'" + txt_gia.Text + "', SOLUONG = N'" + txt_soluong.Text + "' where MASACH = '" + txt_masach.Text + "'";
			SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
			cmd.ExecuteNonQuery();
			getData();
		}

		private void btn_Boqua_Click(object sender, EventArgs e)
		{
			getData();
		}
		//private void btn_Them_Click(object sender, EventArgs e)
				//{
				//	string sqlCommand = "insert into SACH values('" + txt_masach.Text + "', N'" + tieude_txt.Text + "', N'" + textBox7.Text + "', N'" + textBox2.Text + "', N'" + textBox8.Text + "', N'" + gia_txt.Text + "', N'" + soluong_txt.Text + "')";
				//	SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
				//	cmd.ExecuteNonQuery();
				//	getData();
				//}

		// Insert data
		private void btn_Them_Click(object sender, EventArgs e)
		{
			string sqlCommand = "INSERT INTO SACH VALUES (@ma, @ten)";

			//string sqlCommand = "INSERT INTO SACH VALUES ('" + txt_masach.Text + "', '" + txt_tieude + "', " + txt_gia + ", " + txt_soluong + ");";
			SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
			cmd.Parameters.AddWithValue("@ma", txt_masach.Text);
			cmd.Parameters.AddWithValue("@ten", txt_tieude.Text);

			cmd.ExecuteNonQuery();
			getData();
		}

		private void btn_Luu_Click_1(object sender, EventArgs e)
		{

		}

		private void btn_Xoa_Click_1(object sender, EventArgs e)
		{

		}
	}
}
