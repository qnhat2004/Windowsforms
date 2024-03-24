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

		internal DataTable FillData(string sql, object[] para = null)
		{
			DataTable dt = new DataTable();
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			if (para != null)
			{
				string[] tmp = sql.Split(' ');
				List<string> strings = new List<string>();
				foreach (string s in tmp)
				{
					if (s[0] == '@')
						strings.Add(s);
				}
				for (int i = 0; i < para.Length; ++i)
				{
					cmd.Parameters.AddWithValue(strings[i], para[i]);
				}
			}
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			cnn.Close();
			return dt;
		}

		private void getAllData()
		{
			string sql = "select truyen.giatruyen, stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', khachhang.tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', thanhtien as 'Thành tiền', ghichu as 'Ghi chú' from khachhang join truyen on khachhang.tentruyen = truyen.tentruyen";
			dtgv.DataSource = FillData(sql); 
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
			if (txt_sdt.Text != "")
			{
				if (!long.TryParse(txt_sdt.Text, out sdt))
				{
					MessageBox.Show("Số điện thoại không hợp lệ");
				}
				else
				{
					sdt = long.Parse(txt_sdt.Text);
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getAllData();
		}

		private void btn_muon_Click(object sender, EventArgs e)
		{
			if (txt_tenkhach.Text == "" || txt_sdt.Text == "" || cbb_tentruyen.Text == "")
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
			else
			{
				int days = (dtp_ngaytra.Value - dtp_ngaymuon.Value).Days;
				int thanh_tien = days * Convert.ToInt32(txt_dongia.Text);
				string sql = "insert into khachhang (tenkhach, sdt, tentruyen, dongia, ngaymuon, ngaytra, thanhtien, ghichu) values ( @tenkhach, @sdt, @tentruyen, @dongia, @ngaymuon, @ngaytra, @thanhtien, @ghichu )";
				object[] para = new object[]{ txt_tenkhach.Text, txt_sdt.Text, cbb_tentruyen.Text, txt_dongia.Text, dtp_ngaymuon.Text, dtp_ngaytra.Text, thanh_tien.ToString(), "Chưa trả" };
				FillData(sql, para);
			}
		}

		private void cbb_tentruyen_DropDown(object sender, EventArgs e)
		{
			string sql = "select tentruyen from truyen";
			cbb_tentruyen.DataSource = FillData(sql);
			cbb_tentruyen.DisplayMember = "tentruyen";
		}

		private void cbb_tentruyen_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = cbb_tentruyen.Text;
			if (selected == "")
				txt_dongia.Text = "";
			else
			{
				string sql = "select giatruyen from truyen where tentruyen = @selected";
				object[] para = { selected };
				dt = FillData(sql, para);
				if (dt.Rows.Count > 0)
					txt_dongia.Text = dt.Rows[0][0].ToString();
				cnn.Close();
			}
		}


		private void cbb_tentruyen_DropDownClosed(object sender, EventArgs e)
		{

		}

		private void txt_dongia_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void cbb_tentruyen_TextUpdate(object sender, EventArgs e)
		{
			string selected = cbb_tentruyen.Text;
			if (selected == "")
				txt_dongia.Text = "";
			else
			{
				string sql = "select giatruyen from truyen where tentruyen = @selected";
				object[] para = { cbb_tentruyen.Text };
				dtgv.DataSource = FillData(sql, para);
				cnn.Close();
			}
		}

		// TODO: Phải chia ra 2 bảng riêng: 1 bảng khách mượn, 1 bảng truyện. Tên truyện trong bảng truyện là khóa chính tham chiếu đến tên truyện trong bảng khách mượn
	}
}
