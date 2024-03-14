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

namespace WindowsFormsApp11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string connetionString;
		SqlConnection cnn = null;
		private void button1_Click(object sender, EventArgs e)
		{
			/*
			 * Data Source: The name of the server on which the database is located.
			 * Initial Catalog: The name of the database you want to connect to.
			 * User ID: The user name used to connect to the database.
			 * Password: The password for the user name.
			 */

			connetionString = @"Data Source=SUNSHINE;Initial Catalog=QLSV;User ID=sa;Password=nhat123;Trust Server Certificate=True";

			try
			{
				cnn = new SqlConnection(connetionString);

				// Open the connection
				if (cnn.State == ConnectionState.Closed)
				{
					cnn.Open();
					MessageBox.Show("Open Successful!");
					cnn.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Can not open connection!");
			}

			
		}
	}
}
