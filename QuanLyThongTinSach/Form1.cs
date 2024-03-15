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
using System.Data.SqlClient;


namespace WinFormsApp123
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string stringConnect = @"Data Source=SUNSHINE;Initial Catalog=demo;Integrated Security=True";
		SqlConnection cnn = null;
		SqlDataAdapter da = null;
		DataSet ds = null;
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cnn = new SqlConnection(stringConnect);
			cnn.Open();
			string sqlCommand = "select * from SACH";
			da = new SqlDataAdapter(sqlCommand, cnn); // DataAdapter is a bridge between database and dataset, in this case, it helps connect to the database and fill the data to the dataset
			ds = new DataSet();
			da.Fill(ds); // Fill the data from the database to the dataset
			dataGridView1.DataSource = ds; // Display the data from the dataset to the dataGridView1
			getData(); // 

			//Disable all the textBoxes
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
					((TextBox)control).Enabled = false;
			}

			// Disable all the buttons except "btn_Them"
			foreach (Control control in this.Controls)
			{
				if (control is Button && control.Name != "btn_Them")
					((Button)control).Enabled = false;
			}
		}

		// Display data when start
		private void getData()
		{
			string sqlCommand = "select * from SACH";
			da = new SqlDataAdapter(sqlCommand, cnn); // Connect to the database and do the command
			ds = new DataSet();
			da.Fill(ds); // Fill the data from the database to the dataset
			dataGridView1.DataSource = ds; // assign the data from the dataset to dataGridView1

			// Display real number of column "Gia" to 4 numbers after the dot
			// dataGridView1.Columns["GIA"].DefaultCellStyle.Format = "N4";
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			string sqlCommand = "delete from SACH where MASACH = '" + txt_masach.Text + "'";
			//string sqlCommand = ""
			SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
			cmd.ExecuteNonQuery();
			getData();
		}

		// Cancel
		private void btn_Boqua_Click(object sender, EventArgs e)
		{
			getData();
		}

		// Insert data
		private void btn_Them_Click(object sender, EventArgs e)
		{
			//string sqlCommand = "INSERT INTO SACH VALUES (@txt_ma.Text, @ten)";

			string sqlCommand = "INSERT INTO SACH VALUES ('" + txt_masach.Text + "', '" + txt_tieude + "', " + txt_gia + ", " + txt_soluong + ");";
			SqlCommand cmd = new SqlCommand(sqlCommand, cnn);
			cmd.Parameters.AddWithValue("@ma", txt_masach.Text);
			cmd.Parameters.AddWithValue("@tieude", txt_tieude.Text);
			cmd.Parameters.AddWithValue("@gia", txt_gia.Text);
			cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text);

			try
			{
				cmd.ExecuteNonQuery(); // Execute the command, if it's invalid it'll raise the exception, otherwise it'll execute the command and return the number of rows affected
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: " + ex);
			}
			getData();
		}

		// Save data
		private void btn_Luu_Click_1(object sender, EventArgs e)
		{

		}

		// Delete data
		private void btn_Xoa_Click_1(object sender, EventArgs e)
		{

		}
	}
}
