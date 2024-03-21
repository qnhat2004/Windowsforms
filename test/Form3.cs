using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		public Form3(Form2 form2)
		{
			label1.Text = 
		}
		public void SetLabel(string label)
		{
			if (label != null)
			{
				label1.Text = label;
			}
		}
		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}
