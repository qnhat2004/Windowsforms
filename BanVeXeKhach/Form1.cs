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

namespace BanVeXeKhach
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			tlp = new TableLayoutPanel[]{ tableLayoutPanel1, tableLayoutPanel2, tableLayoutPanel3 };
			initAll();
		}

		TableLayoutPanel[] tlp;
		DataTable fillData(string sql, object[] para = null)
		{
			string connStr = @"Data Source=SUNSHINE;Initial Catalog=banvexekhach;Integrated Security=True";
			SqlConnection cnn = new SqlConnection(connStr);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			if (para != null)
			{
				string[] words = sql.Split(' ');
				List<string> list = new List<string>();
				foreach (string word in words)
				{
					if (word != "" && word[0] == '@')
						list.Add(word);
				}
				for (int i = 0; i < para.Length; i++)
					cmd.Parameters.AddWithValue(list[i], para[i]);
			}
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cnn.Close();
			return dt;
		}

		void getAllData()
		{
			string sql = "select * from khach";
			dtgv.DataSource = fillData(sql);
		}

		internal void init(TableLayoutPanel tableLayoutPanel)
		{
			foreach (Control c in tableLayoutPanel.Controls)
			{
				c.Text = getNumber(c.Name);
				if (c.BackColor != Color.Red)
					c.BackColor = Color.LightGray;
			}
		}

		void initAll()
		{
			init(tableLayoutPanel1);
			init(tableLayoutPanel2);
			init(tableLayoutPanel3);
		}

		string getNumber(string s)
		{
			string res = "";
			foreach(char c in s)
			{
				if ('0' <= c && c <= '9')
					res += c;
			}
			return res;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if (btn.BackColor != Color.Orange)
			{
				initAll(); // Dat lai mau cho tat ca button
				btn.BackColor = Color.Orange;
			}
			else
			{
				btn.BackColor = Color.LightGray;
			}
		}
		bool AnyEmpty()
		{
			return txt_hoten.Text == "" || nud_tuoi.Value == 0 || txt_gia.Text == "";
		}

		internal Button findBtn()
		{
			foreach(TableLayoutPanel t in tlp)
			{
				foreach(Control c in t.Controls)
				{
					if (c is Button && c.BackColor == Color.Orange)
						return c as Button;
				}
			}
			return null;
		}

		void makeEmpty()
		{
			txt_hoten.Text = "";
			nud_tuoi.Value = 0;
		}

		private void btn_thanhtoan_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ban co muon thanh toan?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (AnyEmpty())
				{
					MessageBox.Show("Ban chua nhap du thong tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Button selected = findBtn();
				if (selected == null)
				{
					MessageBox.Show("Ban chua chon vi tri", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				string sql = "insert into khach values( @vitri , @ten , @tuoi , @gia )";
				object[] para = { selected.Text, txt_hoten.Text, nud_tuoi.Value.ToString(), txt_gia.Text };
				selected.BackColor = Color.Red;
				selected.Enabled = false;
				fillData(sql, para);
				getAllData();
				makeEmpty();
			}
		}

		private void nud_tuoi_ValueChanged(object sender, EventArgs e)
		{
			int tuoi = (int)nud_tuoi.Value;
			if (tuoi == 0)
			{
				txt_gia.Text = "";
				return;
			}
			int gia = 50000;
			if (tuoi < 18)
				gia = 40000;
			else if (tuoi >= 50)
				gia = 25000;
			txt_gia.Text = gia.ToString();
		}
	}
}
