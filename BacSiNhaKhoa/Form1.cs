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

namespace BacSiNhaKhoa
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GetAllData();
		}

		string connectionString = @"Data Source=SUNSHINE;Initial Catalog=bacsinhakhoa;Integrated Security=True";
		DataTable dt;
		SqlConnection cnn;
		internal DataTable FillData(string sql, object[] para = null)
		{
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			if (para != null)
			{
				string[] words = sql.Split();
				List<string> values = new List<string>();
				foreach(string word in words)
				{
					if (word != "" && word[0] == '@')
					{
						values.Add(word);
					}
				}
				for (int i = 0; i < para.Length; ++i)
					cmd.Parameters.AddWithValue(values[i], para[i]);
			}
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		internal void GetAllData()
		{
			string sql = "select id, hoten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', ngaysinh as 'Ngày sinh' from bacsi";
			dtgv.DataSource = FillData(sql);
			dtgv.Columns["id"].Visible = false;
		}
		bool AnyEmpty()
		{
			return (txt_ten.Text == "" || cbb_quequan.Text == "" || lb_chucdanh.Text == "" || dtp_ngaysinh.Text == "" || (!rbtn_nam.Checked && !rbtn_nu.Checked));
		}
		internal string Convert_chucdanh_From_Listbox_toString()
		{
			int count = lb_chucdanh.SelectedItems.Count;
			string chucdanh = "";
			if (count > 1)
			{
				for (int i = 0; i < count; ++i)
				{
					chucdanh += lb_chucdanh.SelectedItems[i].ToString();
					if (i != count - 1)
						chucdanh += ".";
				}
			}
			else
				chucdanh = lb_chucdanh.SelectedItem.ToString();
			return chucdanh;
		}
		private void btn_them_Click(object sender, EventArgs e)
		{
			int count = lb_chucdanh.SelectedItems.Count;
			if(AnyEmpty() || count == 0)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
				return;
			}
			string chucdanh = Convert_chucdanh_From_Listbox_toString();
			string ngaysinh = dtp_ngaysinh.Value.ToString("yyyy-MM-dd");
			string sql = "insert into bacsi(hoten, gioitinh, quequan, chucdanh, ngaysinh) values ( @hoten , @gioitinh , @quequan , @chucdanh , @ngaysinh )";
			object[] para = { txt_ten.Text, (rbtn_nam.Checked ? "Nam" : "Nữ") , cbb_quequan.Text,  chucdanh, ngaysinh };
			dtgv.DataSource = FillData(sql, para);
			GetAllData();
		}

		private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void cbb_quequan_DropDown(object sender, EventArgs e)
		{
			string sql = "select distinct quequan from bacsi";
			cbb_quequan.DataSource = FillData(sql);
			cbb_quequan.DisplayMember = "quequan";
		}
		internal void Convert_chucdanh_from_string_to_listbox(string chucdanh)
		{
			string[] words = chucdanh.Split('.');
			// clear all selected items in listbox
			lb_chucdanh.ClearSelected();
			for (int i = 0; i < words.Length; ++i)
			{
				lb_chucdanh.SetSelected(lb_chucdanh.FindString(words[i]), true);
			}
		}
		internal void get_chucdanh_From_ListBox()
		{

		}
		private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				txt_ten.Text = dtgv.Rows[e.RowIndex].Cells["Tên"].Value.ToString();
				if (dtgv.Rows[e.RowIndex].Cells["Giới tính"].Value.ToString() == "Nam")
					rbtn_nam.Checked = true;
				else
					rbtn_nu.Checked = true;
				cbb_quequan.Text = dtgv.Rows[e.RowIndex].Cells["Quê quán"].Value.ToString();
				string chucdanh = dtgv.Rows[e.RowIndex].Cells["Chức danh"].Value.ToString();
				Convert_chucdanh_from_string_to_listbox(chucdanh);
				dtp_ngaysinh.Value = DateTime.Parse(dtgv.Rows[e.RowIndex].Cells["Ngày sinh"].Value.ToString());
			}
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			if (AnyEmpty())
			{
				MessageBox.Show("Vui lòng chọn 1 bản ghi để sửa");
				return;
			}
			string id = dtgv.CurrentRow.Cells["id"].Value.ToString();
			string sql = "update bacsi set hoten = @hoten , gioitinh = @gioitinh , quequan = @quequan , chucdanh = @chucdanh , ngaysinh = @ngaysinh where id = @id ";
			string chucdanh = Convert_chucdanh_From_Listbox_toString();
			object[] para = { txt_ten.Text, rbtn_nam.Checked ? 1 : 0, cbb_quequan.Text, chucdanh, dtp_ngaysinh.Value.ToString("yyyy-MM-dd"), id };
			FillData(sql, para);
			GetAllData();
		}

		private void lb_chucdanh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string id = dtgv.CurrentRow.Cells["id"].Value.ToString();
			string sql = "delete from bacsi where id = @id ";
			object[] para = { id };
			FillData(sql, para);
			GetAllData();
		}

		private void btn_timkiem_Click(object sender, EventArgs e)
		{
			string chucdanh = Convert_chucdanh_From_Listbox_toString();
			string sql = "select hoten as 'Tên', gioitinh as 'Giới tính', quequan as 'Quê quán', chucdanh as 'Chức danh', ngaysinh as 'Ngày sinh' from bacsi where chucdanh = @chucdanh ";
			object[] para = { chucdanh };
			dtgv.DataSource = FillData(sql, para);
		}
	}
}
