using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim1
{
	public partial class Form1 : Form
	{
		Dictionary<char, KeyValuePair<int, Color>> infoRow = new Dictionary<char, KeyValuePair<int, Color>>(); // Thong tin hang ghe
		Dictionary<string, HashSet<string>> stateChairsOfMovie = new Dictionary<string, HashSet<string>>(); // Trang thai ghe cua phim
		public Form1()
		{
			InitializeComponent();
			InitializeNameButton();
			InitializeInfoRow();
		}

		internal void InitializeInfoRow()
		{
			infoRow.Add('A', new KeyValuePair<int, Color>(25000, Color.Cyan));
			infoRow.Add('B', new KeyValuePair<int, Color>(30000, Color.PaleGreen));
			infoRow.Add('C', new KeyValuePair<int, Color>(35000, Color.LemonChiffon));
			infoRow.Add('D', new KeyValuePair<int, Color>(40000, Color.Violet));
			infoRow.Add('E', new KeyValuePair<int, Color>(50000, Color.Pink));
			infoRow.Add('F', new KeyValuePair<int, Color>(45000, Color.PaleGoldenrod));
		}

		internal void InitializeNameButton()
		{
			char row = 'F';
			int col = 6;
			foreach(Control control in tableLayoutPanel1.Controls)
			{
				if(control is Button)
				{
					control.Text = row.ToString() + col.ToString();
					col--;
				}
				if(col == 0)
				{
					row--;
					col = 6;
				}
			}
		}
		private void Form1_Load()
		{
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedMovie = cbb_tenphim.SelectedItem.ToString();
			lbl_tenphim.Text = selectedMovie;
			foreach(Control control in tableLayoutPanel1.Controls)
			{
				if(!stateChairsOfMovie.ContainsKey(selectedMovie)) // Neu chua co phim trong danh sahc
				{
					stateChairsOfMovie.Add(selectedMovie, new HashSet<string>());
				}
				if(control is Button && stateChairsOfMovie[selectedMovie].Contains(control.Text))
				{
					control.BackColor = Color.Red;
					control.Enabled = false;
				}
				else
				{
					control.BackColor = infoRow[control.Text[0]].Value;
					control.Enabled = true;
				}
			}
		}

		int total = 0;
		private void button1_Click_1(object sender, EventArgs e)
		{
			if(cbb_tenphim.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn phim", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Button btn = (Button)sender;
			if(btn.BackColor != Color.Green)
			{
				btn.BackColor = Color.Green;
				total += infoRow[btn.Text[0]].Key;
			}
			else
			{
				btn.BackColor = Color.Red;
				total -= infoRow[btn.Text[0]].Key;
			}
			lbl_thanhtien.Text = total.ToString() + " đ";
		}

		private void btn_thanhtoan_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dr == DialogResult.Yes)
			{
				foreach(Control control in this.tableLayoutPanel1.Controls)
				{
					if(control is Button && control.BackColor == Color.Green)
					{
						control.BackColor = Color.Red;
						control.Enabled = false;
						string selected = cbb_tenphim.SelectedItem.ToString();
						stateChairsOfMovie[selected].Add(control.Text);
					}
				}
				lbl_thanhtien.Text = "0 đ";
			}
		}
	}
}
