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

namespace RapChieuPhim
{
	public partial class Form1 : Form
	{
		char hang = 'F'; // hang
		int cot = 6;
		public Form1()
		{
			InitializeComponent();
			foreach(Control c in this.tableLayoutPanel1.Controls)
			{
				if(c is Button)
				{
					c.Text = hang.ToString() + cot.ToString();
				}
				cot--;
				if(cot == 0)
				{
					hang--;
					cot = 6;
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//lbl_tenphim.Text = comboBox1.Text;
			//Dictionary<>
		}

		int sum = 0;
		private void button1_Click_1(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if(btn.BackColor == Color.Green)
			{
				if (btn.Text.Contains("A"))
				{
					sum -= 25000;
					btn.BackColor = Color.Cyan;
				}
				else if (btn.Text.Contains("B"))
				{
					sum -= 30000;
					btn.BackColor = Color.SpringGreen;
				}
				else if (btn.Text.Contains("C"))
				{
					sum -= 35000;
					btn.BackColor = Color.LemonChiffon;
				}
				else if (btn.Text.Contains("D"))
				{
					sum -= 40000;
					btn.BackColor = Color.Violet;
				}
				else if (btn.Text.Contains("E"))
				{
					sum -= 45000;
					btn.BackColor = Color.Pink;
				}
				else if (btn.Text.Contains("F"))
				{
					sum -= 50000;
					btn.BackColor = Color.CornflowerBlue;
				}
			}
			else
			{
				btn.BackColor = Color.Green;
				if (btn.Text.Contains("A"))
					sum += 25000;
				else if (btn.Text.Contains("B"))
					sum += 30000;
				else if (btn.Text.Contains("C"))
					sum += 35000;
				else if (btn.Text.Contains("D"))
					sum += 40000;
				else if (btn.Text.Contains("E"))
					sum += 45000;
				else if (btn.Text.Contains("F"))
					sum += 50000;
			}
			lbl_tongtien.Text = sum.ToString() + " đ";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button37_Click(object sender, EventArgs e)
		{
			if (sum == 0)
			{
				MessageBox.Show("Vui lòng chọn ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				DialogResult dr = MessageBox.Show("Đặt vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if(dr == DialogResult.OK)
				{
					foreach (Control c in this.tableLayoutPanel1.Controls)
					{
						if (c is Button && c.BackColor == Color.Green)
						{
							c.BackColor = Color.Red;
							c.Enabled = false;
						}
					}
				}
				sum = 0;
				lbl_tongtien.Text = "0 đ";
			}
		}

		private void button38_Click(object sender, EventArgs e)
		{
			string connectionString = "Data Source=SUNSHINE;Initial Catalog=CuaHangTruyen;Integrated Security=True";
			DataTable dt = null;
			SqlDataAdapter da = null;
			SqlConnection cnn = null;
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string sql = "select * from user where tk = @tk and mk = @mk";
			SqlCommand cmd = new SqlCommand(sql, cnn);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.HasRows)
			{
				MessageBox.Show("thanh cong");
			}
			else
				MessageBox.Show("that bai");
		}
	}
}
