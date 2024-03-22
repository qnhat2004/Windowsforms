namespace QuanLyCanBo
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbb_quequan = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbb_donvi = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbb_hocvi = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cbb_quequan
			// 
			this.cbb_quequan.FormattingEnabled = true;
			this.cbb_quequan.Location = new System.Drawing.Point(83, 28);
			this.cbb_quequan.Name = "cbb_quequan";
			this.cbb_quequan.Size = new System.Drawing.Size(121, 24);
			this.cbb_quequan.TabIndex = 0;
			this.cbb_quequan.DropDown += new System.EventHandler(this.cbb_quequan_DropDown);
			this.cbb_quequan.SelectedIndexChanged += new System.EventHandler(this.cbb_quequan_SelectedIndexChanged);
			this.cbb_quequan.TextUpdate += new System.EventHandler(this.cbb_quequan_TextUpdate);
			this.cbb_quequan.TextChanged += new System.EventHandler(this.cbb_quequan_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Quê quán";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(250, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Đơn vị";
			// 
			// cbb_donvi
			// 
			this.cbb_donvi.FormattingEnabled = true;
			this.cbb_donvi.Location = new System.Drawing.Point(300, 28);
			this.cbb_donvi.Name = "cbb_donvi";
			this.cbb_donvi.Size = new System.Drawing.Size(121, 24);
			this.cbb_donvi.TabIndex = 2;
			this.cbb_donvi.DropDown += new System.EventHandler(this.cbb_donvi_DropDown);
			this.cbb_donvi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(466, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Học vị";
			// 
			// cbb_hocvi
			// 
			this.cbb_hocvi.FormattingEnabled = true;
			this.cbb_hocvi.Location = new System.Drawing.Point(517, 28);
			this.cbb_hocvi.Name = "cbb_hocvi";
			this.cbb_hocvi.Size = new System.Drawing.Size(121, 24);
			this.cbb_hocvi.TabIndex = 4;
			this.cbb_hocvi.DropDown += new System.EventHandler(this.cbb_hocvi_DropDown);
			this.cbb_hocvi.SelectedIndexChanged += new System.EventHandler(this.cbb_hocvi_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(626, 214);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 301);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbb_hocvi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbb_donvi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbb_quequan);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbb_quequan;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbb_donvi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbb_hocvi;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}