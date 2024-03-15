using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangInternet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
			if (btn.BackColor != Color.Red)
				btn.BackColor = Color.Red;
			else
				MessageBox.Show("Máy đang dùng! Mời chọn máy khác");
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
			//try
			//{
			//	int hour = int.Parse(textBox1.Text);
			//}
			//catch
			//{
			//	MessageBox.Show("Invalid");
			//}

			int hour;
			if(int.TryParse(textBox1.Text, out hour))
			{
				// successful
				if (txt_ra1.Name.Contains("ra1"))
				{
					txt_tongtien1.Text = 
				}
			}
			else
			{
				MessageBox.Show("Invalid");
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
	}
}
