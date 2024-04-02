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

namespace QuanLyQuanCafe_Version2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		internal DataTable fillData(string sql, object[] para = null)
		{
			string cnnString = @"Data Source=SUNSHINE;Initial Catalog=QLCAFE;Integrated Security=True";
			SqlConnection cnn = new SqlConnection(cnnString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			if (para != null)
			{
				string[] words = sql.Split();
				List<string> list = new List<string>();
				foreach(string s in words)
				{
					if (s.Contains("@"))
						list.Add(s);
				}
				for (int i = 0; i < para.Length; i++)
				{
					cmd.Parameters.AddWithValue(list[i], para[i]);
				}
			}
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cnn.Close();
			return dt;
		}

		internal void getAllData()
		{
			string sql = "select madh, soban as 'Số bàn', douong as 'Tên đồ uống', soluong as 'Số lượng', gia as 'Giá', ngay as 'Ngày' from dathang";
			dtgv.DataSource = fillData(sql);
		}
		private void btn_thongke_Click(object sender, EventArgs e)
		{
			if (!cb_douong.Checked && !cb_ngaythang.Checked)
			{
				MessageBox.Show("Vui lòng chọn ít nhất một trong hai ô chọn!", "Thông báo");
				return;
			}
			string sql = "select madh, soban as 'Số bàn', douong as 'Tên đồ uống', soluong as 'Số lượng', gia as 'Giá', ngay as 'Ngày' from dathang where ";
			object[] para = null;
			if (cb_douong.Checked && cb_ngaythang.Checked)
			{
				sql += "douong = @douong and @dtp_from <= ngay and ngay <= @dtp_to ";
				para = new object[]{ cbb_douong.Text, dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd") }; 
			}
			else if (cb_douong.Checked)
			{
				sql += "douong = @douong ";
				para = new object[] { cbb_douong.Text };
			}
			else
			{ 
				sql += " @dtp_from <= ngay and ngay <= @dtp_to ";
				para = new object[] { dtp_from.Value.ToString("yyyy-MM-dd"), dtp_to.Value.ToString("yyyy-MM-dd") };
			}
			dtgv.DataSource = fillData(sql, para);
		}

		private void cbb_douong_DropDown(object sender, EventArgs e)
		{
			string sql = "select distinct douong from dathang";
			cbb_douong.DataSource = fillData(sql);
			cbb_douong.DisplayMember = "douong"; // hien thi cot douong
		}
	}
}
