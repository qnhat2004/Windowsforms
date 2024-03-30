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

namespace QuanLyQuanCafe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GetAllData();
			foreach(string s in listBox1.Items)
			{
				if (!valueOfTale.ContainsKey(s))
					valueOfTale.Add(s, 0);
			}
		}

		DataTable dt = new DataTable();
		string connectionString = "Data Source=SUNSHINE;Initial Catalog=quancafe;Integrated Security=True";

		// Gia tien cua tung ban
		Dictionary<string, int> valueOfTale = new Dictionary<string, int>();

		internal DataTable FillData(string sql, object[] para = null)
		{
			SqlConnection cnn = new SqlConnection(connectionString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			if (para != null)
			{
				string[] strings = sql.Split(' ');
				List<string> tmp = new List<string>();
				foreach(string s in strings)
				{
					if(s.Contains("@"))
					{
						tmp.Add(s);
					}	
				}
				for (int i = 0; i < para.Length; ++i)
				{
					cmd.Parameters.AddWithValue(tmp[i], para[i]);
				}
			}
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cnn.Close();
			return dt;
		}

		internal void GetAllData()
		{
			string sql = "select douong.gia, stt, soban as 'Số bàn', ban.tendouong as 'Tên đồ uống', ghichu as 'Ghi chú', soluong as 'Số lượng', thanhtien as 'Thành tiền' from ban join douong on ban.tendouong = douong.tendouong\r\n";
			dtgv.DataSource = FillData(sql);
			dtgv.Columns["gia"].Visible = false;
			//dtgv.Columns["stt"].Visible = false;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		// yêu cầu người dùng chọn bàn trước khi chọn đồ uống
		void SelectBan()
		{
			if (txt_tenban.Text == "")
			{
				MessageBox.Show("Vui lòng chọn bàn trước khi chọn đồ uống");
			}
		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string selected = listBox1.SelectedItem.ToString();
			txt_tenban.Text = selected;
			string sql = "select douong.gia, soban as 'Số bàn', ban.tendouong as 'Tên đồ uống', ghichu as 'Ghi chú', soluong as 'Số lượng', thanhtien as 'Thành tiền' from ban join douong on ban.tendouong = douong.tendouong where soban = @soban ";
			object[] para = { selected };
			dtgv.DataSource = FillData(sql, para);
			txt_thanhtien.Text = valueOfTale[selected].ToString();
		}

		private void cbb_douong_DropDown(object sender, EventArgs e)
		{
			//SelectBan();
			string sql = "select tendouong from douong";
			cbb_douong.DataSource = FillData(sql);
			cbb_douong.DisplayMember = "tendouong";
		}

		private void cbb_douong_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbb_douong.SelectedItem != null)
			{
				string selected = cbb_douong.Text;
				string sql = "select douong.gia from douong where tendouong = @tendouong ";
				object[] para = { selected };
				dt = FillData(sql, para); // sau khi lọc ra bản ghi, lưu tạm vào DataTable dt
				if (dt.Rows.Count > 0)
				{
					txt_gia.Text = dt.Rows[0]["gia"].ToString();
				}
			}
		}

		private void txt_tenban_TextChanged(object sender, EventArgs e)
		{
			if (txt_tenban.Text == "")
				GetAllData();
		}

		private void cbb_douong_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txt_tenban.Text = dtgv.Rows[e.RowIndex].Cells["Số bàn"].Value.ToString();
				cbb_douong.Text = dtgv.Rows[e.RowIndex].Cells["Tên đồ uống"].Value.ToString();
				txt_ghichu.Text = dtgv.Rows[e.RowIndex].Cells["Ghi chú"].Value.ToString();
				nud_soluong.Text = dtgv.Rows[e.RowIndex].Cells["Số lượng"].Value.ToString();
				txt_gia.Text = dtgv.Rows[e.RowIndex].Cells["gia"].Value.ToString();
			}		
		}

		private void nud_soluong_ValueChanged(object sender, EventArgs e)
		{
			int soluong = Convert.ToInt32(nud_soluong.Value);
			if (txt_gia.Text != "")
			{
				int gia = Convert.ToInt32(txt_gia.Text);
				txt_thanhtien.Text = (soluong * gia).ToString();
			}
		}

		bool ĐoUongEmpty()
		{
			return cbb_douong.Text == "" || txt_gia.Text == "";	
		}

		bool AnyEmpty()
		{
			return txt_tenban.Text == "" || txt_gia.Text == "" || txt_thanhtien.Text == "" || cbb_douong.Text == "";
		}
		private void btn_them_Click(object sender, EventArgs e)
		{
			SelectBan();
			if (AnyEmpty())
			{
				MessageBox.Show("Vui lòng chọn đồ uống");
				return;
			}
			string sql = "insert into ban values( @soban , @tendouong , @ghichu , @soluong , @thanhtien )";
			object[] para = { txt_tenban.Text, cbb_douong.Text, txt_ghichu.Text, nud_soluong.Value, txt_thanhtien.Text };
			FillData(sql, para);
			GetAllData();
			valueOfTale[txt_tenban.Text] += Convert.ToInt32(txt_thanhtien.Text);
			txt_thanhtien.Text = valueOfTale[txt_tenban.Text].ToString();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (AnyEmpty() || dtgv.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn 1 bản ghi để sửa");
				return;
			}
			int thanhtien = Convert.ToInt32(txt_thanhtien.Text);
			// Lay stt cua ban ghi
			string stt = dtgv.CurrentRow.Cells["stt"].Value.ToString();
			// Lay thanh tien hien tai cua ban ghi
			string cur_thanhtien = dtgv.CurrentRow.Cells["Thành tiền"].Value.ToString();
			thanhtien -= Convert.ToInt32(cur_thanhtien);
			string sql = "update ban set tendouong = @tendouong , ghichu = @ghichu , soluong = @soluong where stt = @stt ";
			object[] para = { cbb_douong.Text, txt_ghichu.Text, nud_soluong.Value, stt };
			// Cap nhat lai thanh tien cua ban
			thanhtien += Convert.ToInt32(nud_soluong.Value) * Convert.ToInt32(txt_gia.Text);
			FillData(sql, para);
			GetAllData();
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			if (AnyEmpty() || dtgv.CurrentRow == null)
			{
				MessageBox.Show("Vui lòng chọn 1 bản ghi để sửa");
				return;
			}
			int thanhtien = Convert.ToInt32(txt_thanhtien.Text);
			// Lay stt cua ban ghi
			string stt = dtgv.CurrentRow.Cells["stt"].Value.ToString();
			// Lay thanh tien hien tai cua ban ghi
			string cur_thanhtien = dtgv.CurrentRow.Cells["Thành tiền"].Value.ToString();
			thanhtien -= Convert.ToInt32(cur_thanhtien);
			string sql = "delete from ban where stt = @stt ";
			object[] para = { stt };
			FillData(sql, para);
			GetAllData();
		}
	}
}
