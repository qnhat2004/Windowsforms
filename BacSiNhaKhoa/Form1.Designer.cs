namespace BacSiNhaKhoa
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lb_chucdanh = new System.Windows.Forms.ListBox();
			this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.btn_timkiem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_ten = new System.Windows.Forms.TextBox();
			this.rbtn_nu = new System.Windows.Forms.RadioButton();
			this.rbtn_nam = new System.Windows.Forms.RadioButton();
			this.cbb_quequan = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtgv = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lb_chucdanh);
			this.groupBox1.Controls.Add(this.dtp_ngaysinh);
			this.groupBox1.Controls.Add(this.btn_timkiem);
			this.groupBox1.Controls.Add(this.btn_xoa);
			this.groupBox1.Controls.Add(this.btn_sua);
			this.groupBox1.Controls.Add(this.btn_them);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_ten);
			this.groupBox1.Controls.Add(this.rbtn_nu);
			this.groupBox1.Controls.Add(this.rbtn_nam);
			this.groupBox1.Controls.Add(this.cbb_quequan);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 248);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin cá nhân";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lb_chucdanh
			// 
			this.lb_chucdanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lb_chucdanh.FormattingEnabled = true;
			this.lb_chucdanh.ItemHeight = 16;
			this.lb_chucdanh.Items.AddRange(new object[] {
            "Bác sĩ CKI",
            "Bác sĩ CKII",
            "Thạc sĩ",
            "Tiến sĩ",
            "GS",
            "PGS"});
			this.lb_chucdanh.Location = new System.Drawing.Point(550, 34);
			this.lb_chucdanh.Name = "lb_chucdanh";
			this.lb_chucdanh.ScrollAlwaysVisible = true;
			this.lb_chucdanh.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lb_chucdanh.Size = new System.Drawing.Size(200, 84);
			this.lb_chucdanh.TabIndex = 15;
			this.lb_chucdanh.SelectedIndexChanged += new System.EventHandler(this.lb_chucdanh_SelectedIndexChanged);
			// 
			// dtp_ngaysinh
			// 
			this.dtp_ngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_ngaysinh.Location = new System.Drawing.Point(550, 137);
			this.dtp_ngaysinh.Name = "dtp_ngaysinh";
			this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaysinh.TabIndex = 13;
			// 
			// btn_timkiem
			// 
			this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_timkiem.Location = new System.Drawing.Point(369, 199);
			this.btn_timkiem.Name = "btn_timkiem";
			this.btn_timkiem.Size = new System.Drawing.Size(75, 29);
			this.btn_timkiem.TabIndex = 12;
			this.btn_timkiem.Text = "Tìm kiếm";
			this.btn_timkiem.UseVisualStyleBackColor = false;
			this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_xoa.Location = new System.Drawing.Point(251, 199);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(75, 29);
			this.btn_xoa.TabIndex = 11;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = false;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_sua.Location = new System.Drawing.Point(140, 199);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(75, 29);
			this.btn_sua.TabIndex = 10;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = false;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_them
			// 
			this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_them.Location = new System.Drawing.Point(29, 199);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(75, 29);
			this.btn_them.TabIndex = 9;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = false;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(456, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ngày sinh";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(453, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Chức danh";
			// 
			// txt_ten
			// 
			this.txt_ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_ten.Location = new System.Drawing.Point(105, 34);
			this.txt_ten.Name = "txt_ten";
			this.txt_ten.Size = new System.Drawing.Size(305, 22);
			this.txt_ten.TabIndex = 6;
			// 
			// rbtn_nu
			// 
			this.rbtn_nu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbtn_nu.AutoSize = true;
			this.rbtn_nu.Location = new System.Drawing.Point(186, 86);
			this.rbtn_nu.Name = "rbtn_nu";
			this.rbtn_nu.Size = new System.Drawing.Size(45, 20);
			this.rbtn_nu.TabIndex = 5;
			this.rbtn_nu.TabStop = true;
			this.rbtn_nu.Text = "Nữ";
			this.rbtn_nu.UseVisualStyleBackColor = true;
			// 
			// rbtn_nam
			// 
			this.rbtn_nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbtn_nam.AutoSize = true;
			this.rbtn_nam.Location = new System.Drawing.Point(104, 88);
			this.rbtn_nam.Name = "rbtn_nam";
			this.rbtn_nam.Size = new System.Drawing.Size(57, 20);
			this.rbtn_nam.TabIndex = 4;
			this.rbtn_nam.TabStop = true;
			this.rbtn_nam.Text = "Nam";
			this.rbtn_nam.UseVisualStyleBackColor = true;
			// 
			// cbb_quequan
			// 
			this.cbb_quequan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_quequan.FormattingEnabled = true;
			this.cbb_quequan.Location = new System.Drawing.Point(105, 134);
			this.cbb_quequan.Name = "cbb_quequan";
			this.cbb_quequan.Size = new System.Drawing.Size(305, 24);
			this.cbb_quequan.TabIndex = 3;
			this.cbb_quequan.DropDown += new System.EventHandler(this.cbb_quequan_DropDown);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quê quán";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giới tính";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ và tên";
			// 
			// dtgv
			// 
			this.dtgv.AllowUserToAddRows = false;
			this.dtgv.AllowUserToDeleteRows = false;
			this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv.Location = new System.Drawing.Point(13, 267);
			this.dtgv.Name = "dtgv";
			this.dtgv.ReadOnly = true;
			this.dtgv.RowHeadersWidth = 51;
			this.dtgv.RowTemplate.Height = 24;
			this.dtgv.Size = new System.Drawing.Size(775, 228);
			this.dtgv.TabIndex = 1;
			this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
			this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 507);
			this.Controls.Add(this.dtgv);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý thông tin bác sĩ - Vũ Quang Nhật";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_timkiem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_ten;
		private System.Windows.Forms.RadioButton rbtn_nu;
		private System.Windows.Forms.RadioButton rbtn_nam;
		private System.Windows.Forms.ComboBox cbb_quequan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtgv;
		private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
		private System.Windows.Forms.ListBox lb_chucdanh;
	}
}

