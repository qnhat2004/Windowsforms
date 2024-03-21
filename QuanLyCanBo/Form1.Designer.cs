namespace QuanLyCanBo
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_hoten = new System.Windows.Forms.TextBox();
			this.cbb_quequan = new System.Windows.Forms.ComboBox();
			this.cb_nam = new System.Windows.Forms.CheckBox();
			this.cb_nu = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbb_donvi = new System.Windows.Forms.ComboBox();
			this.cbb_hocvi = new System.Windows.Forms.ComboBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_timkiem = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giới tính";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quê quán";
			// 
			// txt_hoten
			// 
			this.txt_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_hoten.Location = new System.Drawing.Point(81, 13);
			this.txt_hoten.Name = "txt_hoten";
			this.txt_hoten.Size = new System.Drawing.Size(281, 22);
			this.txt_hoten.TabIndex = 1;
			// 
			// cbb_quequan
			// 
			this.cbb_quequan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_quequan.FormattingEnabled = true;
			this.cbb_quequan.Location = new System.Drawing.Point(82, 129);
			this.cbb_quequan.Name = "cbb_quequan";
			this.cbb_quequan.Size = new System.Drawing.Size(280, 24);
			this.cbb_quequan.TabIndex = 4;
			this.cbb_quequan.DropDown += new System.EventHandler(this.cbb_quequan_DropDown);
			// 
			// cb_nam
			// 
			this.cb_nam.AutoSize = true;
			this.cb_nam.Location = new System.Drawing.Point(82, 72);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(58, 20);
			this.cb_nam.TabIndex = 2;
			this.cb_nam.Text = "Nam";
			this.cb_nam.UseVisualStyleBackColor = true;
			this.cb_nam.Click += new System.EventHandler(this.cb_nam_Click);
			// 
			// cb_nu
			// 
			this.cb_nu.AutoSize = true;
			this.cb_nu.Location = new System.Drawing.Point(165, 72);
			this.cb_nu.Name = "cb_nu";
			this.cb_nu.Size = new System.Drawing.Size(46, 20);
			this.cb_nu.TabIndex = 3;
			this.cb_nu.Text = "Nữ";
			this.cb_nu.UseVisualStyleBackColor = true;
			this.cb_nu.Click += new System.EventHandler(this.cb_nu_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Cyan;
			this.panel1.Controls.Add(this.cb_nu);
			this.panel1.Controls.Add(this.cb_nam);
			this.panel1.Controls.Add(this.cbb_quequan);
			this.panel1.Controls.Add(this.txt_hoten);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(371, 164);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Cyan;
			this.panel2.Controls.Add(this.btn_timkiem);
			this.panel2.Controls.Add(this.btn_xoa);
			this.panel2.Controls.Add(this.btn_sua);
			this.panel2.Controls.Add(this.btn_them);
			this.panel2.Controls.Add(this.cbb_hocvi);
			this.panel2.Controls.Add(this.cbb_donvi);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(385, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(403, 164);
			this.panel2.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(780, 291);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn vị";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Học hàm / Học vị";
			// 
			// cbb_donvi
			// 
			this.cbb_donvi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_donvi.FormattingEnabled = true;
			this.cbb_donvi.Location = new System.Drawing.Point(93, 11);
			this.cbb_donvi.Name = "cbb_donvi";
			this.cbb_donvi.Size = new System.Drawing.Size(290, 24);
			this.cbb_donvi.TabIndex = 0;
			this.cbb_donvi.DropDown += new System.EventHandler(this.cbb_donvi_DropDown);
			// 
			// cbb_hocvi
			// 
			this.cbb_hocvi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_hocvi.FormattingEnabled = true;
			this.cbb_hocvi.Location = new System.Drawing.Point(140, 68);
			this.cbb_hocvi.Name = "cbb_hocvi";
			this.cbb_hocvi.Size = new System.Drawing.Size(243, 24);
			this.cbb_hocvi.TabIndex = 1;
			this.cbb_hocvi.DropDown += new System.EventHandler(this.cbb_hocvi_DropDown);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(18, 119);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(78, 42);
			this.btn_them.TabIndex = 2;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(102, 119);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(91, 42);
			this.btn_sua.TabIndex = 3;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(199, 119);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(90, 42);
			this.btn_xoa.TabIndex = 4;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_timkiem
			// 
			this.btn_timkiem.Location = new System.Drawing.Point(295, 119);
			this.btn_timkiem.Name = "btn_timkiem";
			this.btn_timkiem.Size = new System.Drawing.Size(88, 42);
			this.btn_timkiem.TabIndex = 5;
			this.btn_timkiem.Text = "Tìm kiếm";
			this.btn_timkiem.UseVisualStyleBackColor = true;
			this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 474);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân sự (Vũ Quang Nhật - 2251172445)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_hoten;
		private System.Windows.Forms.ComboBox cbb_quequan;
		private System.Windows.Forms.CheckBox cb_nam;
		private System.Windows.Forms.CheckBox cb_nu;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cbb_donvi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cbb_hocvi;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_timkiem;
	}
}

