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
			string sql = "select * from douong";
			dtgv.DataSource = FillData(sql);
		}

		DataTable dt = new DataTable();
		string connectionString = "Data Source=SUNSHINE;Initial Catalog=quancafe;Integrated Security=True";

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

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		// yêu cầu người dùng chọn bàn trước khi chọn đồ uống
		void SelectBan()
		{
			if (txt_tenban.Text == "")
			{
				MessageBox.Show("Vui lòng chọn bàn trước khi chọn đồ uống");
				//listBox1.Focus();
			}
			else
				return;
		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string selected = listBox1.SelectedItem.ToString();
			txt_tenban.Text = selected;
			string sql = "select douong.gia, soban as 'Số bàn', ban.tendouong as 'Tên đồ uống', ghichu as 'Ghi chú', soluong as 'Số lượng', thanhtien as 'Thành tiền' from ban join douong on ban.tendouong = douong.tendouong where soban = @soban ";
			object[] para = { selected };
			dtgv.DataSource = FillData(sql, para);
			//dtgv.Columns["gia"].Visible = false;
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
				string selected = cbb_douong.SelectedItem.ToString();
				string sql = "select douong.gia from douong where tendouong = @tendouong ";
				object[] para = { selected };
				dt = FillData(sql, para);
				if (dt.Rows.Count > 0)
				{
					txt_gia.Text = dt.Rows[0]["gia"].ToString();
					dtgv.DataSource = FillData(sql, para);
				}
			}
		}

		private void txt_tenban_TextChanged(object sender, EventArgs e)
		{

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
				cbb_douong.Text = dtgv.Rows[e.RowIndex].Cells["Tên đồ uống"].Value.ToString();
				txt_ghichu.Text = dtgv.Rows[e.RowIndex].Cells["Ghi chú"].Value.ToString();
				nud_soluong.Text = dtgv.Rows[e.RowIndex].Cells["Số lượng"].Value.ToString();
				txt_gia.Text = dtgv.Rows[e.RowIndex].Cells["gia"].Value.ToString();
			}		
		}
	}
}
