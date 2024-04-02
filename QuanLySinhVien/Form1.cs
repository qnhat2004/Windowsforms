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

namespace QuanLySinhVien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		internal DataTable FillData(string sql, object[] para = null)
		{
			string connectionString = "Data Source=SUNSHINE;Initial Catalog=QuanLySinhVien;Integrated Security=True";
			SqlConnection cnn = new SqlConnection(connectionString);
			cnn.Open();
			SqlCommand cmd = new SqlCommand(sql, cnn);
			SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			if (para != null)
			{
				string[] tmp = sql.Split(' ');
				List<string> strings = new List<string>();
				foreach(string s in tmp)
				{
					if(s != "" && s[0] == '@')
					{
						strings.Add(s);
					}
				}
				for (int i = 0; i < para.Length; ++i)
				{
					cmd.Parameters.AddWithValue(strings[i], para[i]);
				}
				cmd.ExecuteNonQuery();
			}
			cnn.Close();
			return dt;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{

		}
	}
}
