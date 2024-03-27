using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeXemPhim1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//cbb_tenphim.SelectedIndex = 0; // chọn phim đầu tiên
			//re();
			//lbl_thanhtien.Text = cbb_tenphim.SelectedItem.ToString(); // hiển thị giá tiền của phim đầu tiên
			InitializeLayouts();
		}
		Dictionary<string, TableLayoutPanel> movieLayouts = new Dictionary<string, TableLayoutPanel>();

		private void InitializeLayouts()
		{
			foreach (string item in cbb_tenphim.Items)
			{
				movieLayouts.Add(item, CreateLayout());
			}
		}

		private TableLayoutPanel CreateLayout()
		{
			TableLayoutPanel layoutPanel = new TableLayoutPanel();
			layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
			layoutPanel.RowCount = 6;
			layoutPanel.BackColor = Color.FromArgb(255, 255, 24);
			layoutPanel.Location = new Point(111, 45);
			char row = 'F';
			int col = 6;
			for (int i = 0; i < 36; i++)
			{
				Button btn = new Button();
				btn.Text = row.ToString() + col.ToString();

				col--;

				if (col == 0)
				{
					row--;
					col = 6;
				}
			}
			//MessageBox.Show(btn.Location.ToString());
			this.Controls.Add(layoutPanel);
			return layoutPanel;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
	}
}
