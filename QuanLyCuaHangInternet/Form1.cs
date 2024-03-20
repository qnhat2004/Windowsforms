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

namespace QuanLyCuaHangInternet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string stringConnection = @"Data Source=SUNSHINE;Initial Catalog=QL_Internet;Integrated Security=True";
		SqlConnection cnn = null;
		SqlDataAdapter da = null;
		DataTable dt = null;

		private void GetData()
		{
			cnn = new SqlConnection(stringConnection);
			cnn.Open();
			string sql = "Select STT, SoMay as 'Số máy', GioVao as 'Giờ vào', GioRa as 'Giờ ra', SoGio as 'Số giờ sử dụng', DonGia as 'Đơn giá/Giờ', ThanhTien as 'Thành tiền' From BangKe";
			da = new SqlDataAdapter(sql, cnn);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			ErrorBlinkStyle error = new ErrorBlinkStyle();
			if (btn.BackColor == Color.Red)
			{
				MessageBox.Show("Máy đang dùng! Mời chọn máy khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
				btn.BackColor = Color.Red;
		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			TextBox txt = (TextBox)sender;
			int hour;
			bool check = true;
			if (txt.Text == "" || int.TryParse(txt.Text, out hour) == false)
			{
				check = false;
			}
			else if (hour < 0)
			{
				check = false;
			}
			if (check == false)
			{
				MessageBox.Show("Số giờ không hợp lệ! Hãy nhập số nguyên dương lớn hơn hoặc bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt.Focus();
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetData();
		}

		private void Form1_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_ra1_TextChange(object sender, EventArgs e)
		{

		}

		private void txt_ra1_TextChanged(object sender, EventArgs e)
		{
			if (txt_vao1.Text == "" || txt_ra1.Text == "")
			{
				txt_tien1.Text = "";
			}
			else
			{
				int start = int.TryParse(txt_vao1.Text, out start) ? int.Parse(txt_vao1.Text) : -1;
				int end = int.TryParse(txt_ra1.Text, out end) ? int.Parse(txt_ra1.Text) : -1;
				if (start == -1 || end == -1) 
					txt_tien1.Text = "";
				else
					txt_tien1.Text = Convert.ToString((end - start) * 5000);
			}
		}

		private void txt_ra2_TextChanged(object sender, EventArgs e)
		{
			if (txt_vao2.Text == "" || txt_ra2.Text == "")
			{
				txt_tien2.Text = "";
			}
			else
			{
				int start = int.TryParse(txt_vao2.Text, out start) ? int.Parse(txt_vao2.Text) : -1;
				int end = int.TryParse(txt_ra2.Text, out end) ? int.Parse(txt_ra2.Text) : -1;
				if (start == -1 || end == -1)
					txt_tien2.Text = "";
				else
					txt_tien2.Text = Convert.ToString((end - start) * 5000);
			}
		}

		private void txt_ra3_TextChanged(object sender, EventArgs e)
		{
			if (txt_vao3.Text == "" || txt_ra3.Text == "")
			{
				txt_tien3.Text = "";
			}
			else
			{
				int start = int.TryParse(txt_vao3.Text, out start) ? int.Parse(txt_vao3.Text) : -1;
				int end = int.TryParse(txt_ra3.Text, out end) ? int.Parse(txt_ra3.Text) : -1;
				if (start == -1 || end == -1)
					txt_tien3.Text = "";
				else
					txt_tien3.Text = Convert.ToString((end - start) * 5000);
			}
		}

		private void txt_ra4_TextChanged(object sender, EventArgs e)
		{
			if (txt_vao4.Text == "" || txt_ra4.Text == "")
			{
				txt_tien1.Text = "";
			}
			else
			{
				int start = int.TryParse(txt_vao4.Text, out start) ? int.Parse(txt_vao4.Text) : -1;
				int end = int.TryParse(txt_ra4.Text, out end) ? int.Parse(txt_ra4.Text) : -1;
				if (start == -1 || end == -1)
					txt_tien4.Text = "";
				else
					txt_tien4.Text = Convert.ToString((end - start) * 5000);
			}
		}

		private void txt_ra5_TextChanged(object sender, EventArgs e)
		{
			if (txt_vao5.Text == "" || txt_ra5.Text == "")
			{
				txt_tien5.Text = "";
			}
			else
			{
				int start = int.TryParse(txt_vao5.Text, out start) ? int.Parse(txt_vao5.Text) : -1;
				int end = int.TryParse(txt_ra5.Text, out end) ? int.Parse(txt_ra5.Text) : -1;
				if (start == -1 || end == -1)
					txt_tien5.Text = "";
				else
					txt_tien5.Text = Convert.ToString((end - start) * 5000);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_tt1_Click(object sender, EventArgs e)
		{
			if (txt_vao1.Text == "" || txt_ra1.Text == "" || txt_tien1.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{
				btn_may1.BackColor = Color.LightGray;
				string hour = Convert.ToString(Convert.ToInt32(txt_tien1.Text) / 5000);
				using(SqlConnection conn = new SqlConnection(stringConnection))
				{
					conn.Open();
					string sql = "Insert into BangKe(SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) Values(@SoMay, @GioVao, @GioRa, @SoGio, @DonGia, @ThanhTien)";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@SoMay", btn_may1.Text);
					cmd.Parameters.AddWithValue("@GioVao", txt_vao1.Text);
					cmd.Parameters.AddWithValue("@GioRa", txt_ra1.Text);
					cmd.Parameters.AddWithValue("@SoGio", hour);
					cmd.Parameters.AddWithValue("@DonGia", "5000đ/giờ");
					cmd.Parameters.AddWithValue("@ThanhTien", txt_tien1.Text);
					cmd.ExecuteNonQuery();
					GetData();
					cnn.Close();
					txt_vao1.Text = txt_ra1.Text = "";
				}
			}
		}

		private void btn_tt2_Click(object sender, EventArgs e)
		{
			if (txt_vao2.Text == "" || txt_ra2.Text == "" || txt_tien2.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{
				btn_may2.BackColor = Color.LightGray;
				string hour = Convert.ToString(Convert.ToInt32(txt_tien2.Text) / 5000);
				using (SqlConnection cnn = new SqlConnection(stringConnection))
				{
					cnn.Open();
					string sql = "Insert into BangKe(SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) Values(@SoMay, @GioVao, @GioRa, @SoGio, @DonGia, @ThanhTien);";
					SqlCommand cmd = new SqlCommand(sql, cnn);
					cmd.Parameters.AddWithValue("@SoMay", btn_may2.Text);	
					cmd.Parameters.AddWithValue("@GioVao", txt_vao2.Text);
					cmd.Parameters.AddWithValue("@GioRa", txt_ra2.Text);
					cmd.Parameters.AddWithValue("@SoGio", hour);
					cmd.Parameters.AddWithValue("@DonGia", "5000đ/giờ");
					cmd.Parameters.AddWithValue("@ThanhTien", txt_tien2.Text);
					GetData();
					txt_vao2.Text = txt_ra2.Text = "";
					cnn.Close();
				}
			}
		}

		private void btn_tt3_Click(object sender, EventArgs e)
		{
			if (txt_ra3.Text == "" || txt_vao3.Text == "" || txt_tien3.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{
				btn_may3.BackColor = Color.LightGray;
				string hour = Convert.ToString(Convert.ToInt32(txt_tien3.Text) / 5000);
				using (SqlConnection cnn = new SqlConnection(stringConnection))
				{
					cnn.Open();
					string sql = "Insert into BangKe(SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) Values(@SoMay, @GioVao, @GioRa, @SoGio, @DonGia, @ThanhTien);";
					SqlCommand cmd = new SqlCommand(sql, cnn);
					cmd.Parameters.AddWithValue("@SoMay", btn_may3.Text);
					cmd.Parameters.AddWithValue("@GioVao", txt_vao3.Text);
					cmd.Parameters.AddWithValue("@GioRa", txt_ra3.Text);
					cmd.Parameters.AddWithValue("@SoGio", hour);
					cmd.Parameters.AddWithValue("@DonGia", "5000đ/giờ");
					cmd.Parameters.AddWithValue("@ThanhTien", txt_tien3.Text);
					cmd.ExecuteNonQuery();
					GetData();
					txt_vao3.Text = txt_ra3.Text = "";
					cnn.Close();
				}
			}
		}

		private void btn_tt4_Click(object sender, EventArgs e)
		{
			if (txt_ra4.Text == "" || txt_vao4.Text == "" || txt_tien4.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{
				btn_may4.BackColor = Color.LightGray;
				string hour = Convert.ToString(Convert.ToInt32(txt_tien4.Text) / 5000);
				using (SqlConnection cnn = new SqlConnection(stringConnection))
				{
					cnn.Open();
					string sql = "Insert into BangKe(SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) Values(@SoMay, @GioVao, @GioRa, @SoGio, @DonGia, @ThanhTien);";
					SqlCommand cmd = new SqlCommand(sql, cnn);
					cmd.Parameters.AddWithValue("@SoMay", btn_may4.Text);
					cmd.Parameters.AddWithValue("@GioVao", txt_vao4.Text);
					cmd.Parameters.AddWithValue("@GioRa", txt_ra4.Text);
					cmd.Parameters.AddWithValue("@SoGio", hour);
					cmd.Parameters.AddWithValue("@DonGia", "5000đ/giờ");
					cmd.Parameters.AddWithValue("@ThanhTien", txt_tien4.Text);
					cmd.ExecuteNonQuery();
					GetData();
					txt_vao4.Text = txt_ra4.Text = "";
					cnn.Close();
				}
			}
		}

		private void btn_tt5_Click(object sender, EventArgs e)
		{
			if (txt_ra5.Text == "" || txt_vao5.Text == "" || txt_tien5.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{
				btn_may5.BackColor = Color.LightGray;
				string hour = Convert.ToString(Convert.ToInt32(txt_tien5.Text) / 5000);
				using (SqlConnection cnn = new SqlConnection(stringConnection))
				{
					cnn.Open();
					string sql = "Insert into BangKe(SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) Values(@SoMay, @GioVao, @GioRa, @SoGio, @DonGia, @ThanhTien);";
					SqlCommand cmd = new SqlCommand(sql, cnn);
					cmd.Parameters.AddWithValue("@SoMay", btn_may5.Text);
					cmd.Parameters.AddWithValue("@GioVao", txt_vao5.Text);
					cmd.Parameters.AddWithValue("@GioRa", txt_ra5.Text);
					cmd.Parameters.AddWithValue("@SoGio", hour);
					cmd.Parameters.AddWithValue("@DonGia", "5000đ/giờ");
					cmd.Parameters.AddWithValue("@ThanhTien", txt_tien5.Text);
					cmd.ExecuteNonQuery();
					GetData();
					txt_vao5.Text = txt_ra5.Text = "";
					cnn.Close();
				}
			}
		}
	}
}
