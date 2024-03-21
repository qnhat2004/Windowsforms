using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTruyen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string connectionString = "Data Source=SUNSHINE;Initial Catalog=CuaHangTruyen;Integrated Security=True";
		DataTable dt = null;
		SqlDataAdapter da = null;
		SqlConnection cnn = null;

		private void getData()
		{
			string sql = "select stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', thanhtien as 'Thành tiền', ghichu as 'Ghi chú' from thongtin"; 
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			da = new SqlDataAdapter(sql, cnn);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			cnn.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void txt_sdt_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_sdt_Leave(object sender, EventArgs e)
		{
			long sdt;
			if (!long.TryParse(txt_sdt.Text, out sdt))
			{
				MessageBox.Show("Số điện thoại không hợp lệ");
			}
			else
			{
				sdt = long.Parse(txt_sdt.Text);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getData();
		}

		private void btn_muon_Click(object sender, EventArgs e)
		{
			if (txt_tenkhach.Text == "" || txt_sdt.Text == "" || cbb_tentruyen.Text == "")
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
			else
			{
				int days = (dtp_ngaytra.Value - dtp_ngaymuon.Value).Days;
				int thanh_tien = days * Convert.ToInt32(txt_dongia.Text);
				cnn = new SqlConnection(connectionString);
				cnn.Open();
				string sql = "insert into thongtin (tenkhach, sdt, tentruyen, dongia, ngaymuon, ngaytra, thanhtien, ghichu) values (@tenkhach, @sdt, @tentruyen, @dongia, @ngaymuon, @ngaytra, @thanhtien, @ghichu";
				using (SqlCommand cmd = new SqlCommand(sql, cnn))
				{
					cmd.Parameters.AddWithValue("@tenkhach", txt_tenkhach.Text);
					cmd.Parameters.AddWithValue("@sdt", txt_sdt.Text);
					cmd.Parameters.AddWithValue("@tentruyen", cbb_tentruyen.Text);
					cmd.Parameters.AddWithValue("@ngaymuon", dtp_ngaymuon.Value);
					cmd.Parameters.AddWithValue("@ngaytra", dtp_ngaytra.Text);
					cmd.Parameters.AddWithValue("@thanhtien", Convert.ToString(thanh_tien));
					cmd.Parameters.AddWithValue("@ghichu", "Chưa trả");
					cmd.ExecuteNonQuery();
					getData();
					cnn.Close();
				}
			}
		}

		private void cbb_tentruyen_DropDown(object sender, EventArgs e)
		{
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "select tentruyen from thongtin";
			using(SqlCommand cmd = new SqlCommand(sql, cnn))
			{
				using(SqlDataReader dr = cmd.ExecuteReader())
				{
					cbb_tentruyen.Items.Clear();
					while(dr.Read())
					{
						cbb_tentruyen.Items.Add(dr["tentruyen"]);
					}
				}
			}
		}

		private void cbb_tentruyen_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbb_tentruyen.SelectedItem.ToString();
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "select dongia from thongtin where tentruyen = @tentruyen;";
			using(SqlCommand cmd = new SqlCommand(sql, cnn))
			{
				cmd.Parameters.AddWithValue("@tentruyen", selected);
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					if (dr.Read())
						txt_dongia.Text = dr["dongia"].ToString();
					
				}
			}
			cnn.Close();
		}
	}
}
