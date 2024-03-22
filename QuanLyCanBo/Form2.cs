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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			
		}
		
		Form1 f1 = new Form1();
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			getDataFilteredByComboBoxes();
		}

		private void cbb_quequan_DropDown(object sender, EventArgs e)
		{
			f1.FillComboboxWithDistinctValues("quequan", cbb_quequan);
		}

		private void cbb_donvi_DropDown(object sender, EventArgs e)
		{
			f1.FillComboboxWithDistinctValues("donvi", cbb_donvi);
		}

		private void cbb_hocvi_DropDown(object sender, EventArgs e)
		{
			f1.FillComboboxWithDistinctValues("hocvi", cbb_hocvi);
		}

		private void cbb_quequan_TextChanged(object sender, EventArgs e)
		{
			if (AllComboBoxesIsEmpty())
			{
				f1.getAllDataFromTable();
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			f1.getAllDataFromTable();
			Mapping();
		}
		bool AllComboBoxesIsEmpty()
		{
			return cbb_quequan.Text == "" && cbb_donvi.Text == "" && cbb_hocvi.Text == "";
		}

		Dictionary<string, string> map = new Dictionary<string, string>();
		void Mapping()
		{
			map.Add("cbb_quequan", "quequan");
			map.Add("cbb_donvi", "donvi");
			map.Add("cbb_hocvi", "hocvi");
		}

		internal void getDataFilteredByComboBoxes()
		{
			if(!AllComboBoxesIsEmpty())
			{
				f1.cnn = new SqlConnection(f1.connectionString);
				f1.cnn.Open();
				string sql = "select hoten as 'Họ tên', gioitinh as 'Giới tính', quequan as 'Quê quán', donvi as 'Đơn vị', hocvi as 'Học hàm / Học vị' from canbo where ";
				int cnt = 0;
				foreach(Control control in this.Controls)
				{
					if (control is ComboBox)
					{
						ComboBox cb = control as ComboBox;
						if (cb.Text != "")
						{
							if (cnt > 0)
							{
								sql += " and ";
							}
							sql += map[cb.Name] + " = '" + cb.Text + "'";
							cnt++;
						}
					}
				}
				f1.fillDataToDataGridview(dataGridView1, sql);
				f1.cnn.Close();
			}
			else
			{
				string sql = "select id, hoten as 'Họ tên', gioitinh as 'Giới tính', quequan as 'Quê quán', donvi as 'Đơn vị', hocvi as 'Học hàm / Học vị' from canbo";
				f1.fillDataToDataGridview(dataGridView1, sql);
			}
		}
		private void cbb_quequan_SelectedIndexChanged(object sender, EventArgs e)
		{
			getDataFilteredByComboBoxes();
		}

		private void cbb_hocvi_SelectedIndexChanged(object sender, EventArgs e)
		{
			getDataFilteredByComboBoxes();
		}
	}
}
