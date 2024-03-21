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

namespace QuanLyCanBo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string connectionString = @"Data Source=SUNSHINE;Initial Catalog=db;Integrated Security=True";
		SqlConnection cnn = null;
		SqlDataAdapter da = null;
		DataTable dt = null;

		private void getData()
		{
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "select id, hoten as 'Họ tên', gioitinh as 'Giới tính', quequan as 'Quê quán', donvi as 'Đơn vị', hocvi as 'Học hàm / Học vị' from canbo";
			da = new SqlDataAdapter(sql, cnn);
			dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			cnn.Close();
		}

		private bool CheckEmpty()
		{
			return txt_hoten.Text == "" || (!cb_nam.Checked && !cb_nu.Checked) || cbb_quequan.Text == "" || cbb_donvi.Text == "" || cbb_hocvi.Text == "";
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			getData();
			dataGridView1.Columns[0].Visible = false; // Hide 'id' column
		}

		private void FillComboboxWithDistinctValues(string column, ComboBox cbb)
		{
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = $"select distinct {column} from canbo";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			SqlDataReader dr = cmd.ExecuteReader();
			cbb.Items.Clear();
			while(dr.Read())
			{
				cbb.Items.Add(dr[column]).ToString();
			}
		}

		private void cbb_quequan_DropDown(object sender, EventArgs e)
		{
			FillComboboxWithDistinctValues("quequan", cbb_quequan);
		}

		private void cbb_donvi_DropDown(object sender, EventArgs e)
		{
			FillComboboxWithDistinctValues("donvi", cbb_donvi);
		}

		private void cbb_hocvi_DropDown(object sender, EventArgs e)
		{
			FillComboboxWithDistinctValues("hocvi", cbb_hocvi);
		}

		private void btn_them_Click(object sender, EventArgs e)
		{
			if (CheckEmpty())
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				cnn = new SqlConnection(connectionString);
				cnn.Open();
				string gioitinh = cb_nam.Checked ? "Nam" : "Nữ";
				string sql = "insert into canbo(hoten, gioitinh, quequan, donvi, hocvi) values (@hoten, @gioitinh, @quequan, @donvi, @hocvi)";
				SqlCommand cmd = new SqlCommand(sql, cnn);
				cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
				cmd.Parameters.AddWithValue("@gioitinh", cb_nam.Checked ? "Nam" : "Nữ");
				cmd.Parameters.AddWithValue("@quequan", cbb_quequan.Text);
				cmd.Parameters.AddWithValue("@donvi", cbb_donvi.Text);
				cmd.Parameters.AddWithValue("@hocvi", cbb_hocvi.Text);
				cmd.ExecuteNonQuery();
				getData();
				cnn.Close();
			}
		}

		private void cb_nam_Click(object sender, EventArgs e)
		{
			if (cb_nu.Checked)
				cb_nu.Checked = false;
		}

		private void cb_nu_Click(object sender, EventArgs e)
		{
			if (cb_nam.Checked)
				cb_nam.Checked = false;
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			string selected_id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "update canbo set hoten = @hoten, gioitinh = @gioitinh, quequan = @quequan, donvi = @donvi, hocvi = @hocvi where id = @selected_id";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
			cmd.Parameters.AddWithValue("@gioitinh", cb_nam.Checked ? "Nam" : "Nữ");
			cmd.Parameters.AddWithValue("@quequan", cbb_quequan.Text);
			cmd.Parameters.AddWithValue("@donvi", cbb_donvi.Text);
			cmd.Parameters.AddWithValue("@hocvi", cbb_hocvi.Text);
			cmd.Parameters.AddWithValue("@selected_id", selected_id);
			cmd.ExecuteNonQuery();
			getData();
			cnn.Close();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Make sure user select at least 1 row
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				txt_hoten.Text = row.Cells["Họ tên"].Value.ToString();
				if (row.Cells["Giới tính"].Value.ToString() == "Nam")
				{
					cb_nam.Checked = true;
					cb_nu.Checked = false;
				}
				else
				{
					cb_nu.Checked = true;
					cb_nam.Checked = false;
				}
				cbb_quequan.Text = row.Cells["Quê quán"].Value.ToString();
				cbb_donvi.Text = row.Cells["Đơn vị"].Value.ToString();
				cbb_hocvi.Text = row.Cells["Học hàm / Học vị"].Value.ToString();
			}
		}

		private void btn_xoa_Click(object sender, EventArgs e)
		{
			string selected_id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "delete from canbo where id = @selected_id";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			cmd.Parameters.AddWithValue("@selected_id", selected_id);
			cmd.ExecuteNonQuery();
			getData();
			cnn.Close();
		}

		private void btn_timkiem_Click(object sender, EventArgs e)
		{

		}
	}
}
