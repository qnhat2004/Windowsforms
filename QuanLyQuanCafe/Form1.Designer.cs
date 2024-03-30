namespace QuanLyQuanCafe
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
			this.dtgv = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nud_soluong = new System.Windows.Forms.NumericUpDown();
			this.txt_ghichu = new System.Windows.Forms.TextBox();
			this.cbb_douong = new System.Windows.Forms.ComboBox();
			this.txt_gia = new System.Windows.Forms.TextBox();
			this.btn_them = new System.Windows.Forms.Button();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_thanhtien = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txt_tenban = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgv
			// 
			this.dtgv.AllowUserToAddRows = false;
			this.dtgv.AllowUserToDeleteRows = false;
			this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv.Location = new System.Drawing.Point(144, 276);
			this.dtgv.Name = "dtgv";
			this.dtgv.ReadOnly = true;
			this.dtgv.RowHeadersWidth = 51;
			this.dtgv.RowTemplate.Height = 24;
			this.dtgv.Size = new System.Drawing.Size(792, 251);
			this.dtgv.TabIndex = 0;
			this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
			this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nud_soluong);
			this.groupBox1.Controls.Add(this.txt_ghichu);
			this.groupBox1.Controls.Add(this.cbb_douong);
			this.groupBox1.Controls.Add(this.txt_gia);
			this.groupBox1.Controls.Add(this.btn_them);
			this.groupBox1.Controls.Add(this.btn_sua);
			this.groupBox1.Controls.Add(this.btn_xoa);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(144, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(792, 245);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin";
			// 
			// nud_soluong
			// 
			this.nud_soluong.Location = new System.Drawing.Point(555, 38);
			this.nud_soluong.Name = "nud_soluong";
			this.nud_soluong.Size = new System.Drawing.Size(221, 22);
			this.nud_soluong.TabIndex = 13;
			this.nud_soluong.ValueChanged += new System.EventHandler(this.nud_soluong_ValueChanged);
			// 
			// txt_ghichu
			// 
			this.txt_ghichu.Location = new System.Drawing.Point(116, 82);
			this.txt_ghichu.Multiline = true;
			this.txt_ghichu.Name = "txt_ghichu";
			this.txt_ghichu.Size = new System.Drawing.Size(335, 139);
			this.txt_ghichu.TabIndex = 12;
			// 
			// cbb_douong
			// 
			this.cbb_douong.FormattingEnabled = true;
			this.cbb_douong.Items.AddRange(new object[] {
            "Nâu đen",
            "Nâu đá",
            "Cà phê",
            "sting",
            "coca",
            "Chồn"});
			this.cbb_douong.Location = new System.Drawing.Point(116, 38);
			this.cbb_douong.Name = "cbb_douong";
			this.cbb_douong.Size = new System.Drawing.Size(335, 24);
			this.cbb_douong.TabIndex = 11;
			this.cbb_douong.DropDown += new System.EventHandler(this.cbb_douong_DropDown);
			this.cbb_douong.SelectedIndexChanged += new System.EventHandler(this.cbb_douong_SelectedIndexChanged);
			this.cbb_douong.TextChanged += new System.EventHandler(this.cbb_douong_TextChanged);
			// 
			// txt_gia
			// 
			this.txt_gia.Enabled = false;
			this.txt_gia.Location = new System.Drawing.Point(555, 82);
			this.txt_gia.Name = "txt_gia";
			this.txt_gia.Size = new System.Drawing.Size(221, 22);
			this.txt_gia.TabIndex = 9;
			// 
			// btn_them
			// 
			this.btn_them.BackColor = System.Drawing.Color.Gainsboro;
			this.btn_them.Location = new System.Drawing.Point(476, 188);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(96, 33);
			this.btn_them.TabIndex = 8;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = false;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.BackColor = System.Drawing.Color.Gainsboro;
			this.btn_sua.Location = new System.Drawing.Point(578, 188);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(96, 33);
			this.btn_sua.TabIndex = 7;
			this.btn_sua.Text = "Chỉnh sửa";
			this.btn_sua.UseVisualStyleBackColor = false;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.BackColor = System.Drawing.Color.Gainsboro;
			this.btn_xoa.Location = new System.Drawing.Point(680, 188);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(96, 33);
			this.btn_xoa.TabIndex = 6;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = false;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(473, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(473, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số lượng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ghi chú";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đồ uống";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(459, 558);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Thành tiền";
			// 
			// txt_thanhtien
			// 
			this.txt_thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_thanhtien.Enabled = false;
			this.txt_thanhtien.Location = new System.Drawing.Point(543, 555);
			this.txt_thanhtien.Name = "txt_thanhtien";
			this.txt_thanhtien.ReadOnly = true;
			this.txt_thanhtien.Size = new System.Drawing.Size(259, 22);
			this.txt_thanhtien.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Gainsboro;
			this.button1.Location = new System.Drawing.Point(824, 545);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 42);
			this.button1.TabIndex = 5;
			this.button1.Text = "Hoàn thành";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4",
            "Bàn 5",
            "Bàn 6",
            "Bàn 7",
            "Bàn 8",
            "Bàn 9",
            "Bàn 10",
            "",
            ""});
			this.listBox1.Location = new System.Drawing.Point(12, 59);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(126, 468);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
			// 
			// txt_tenban
			// 
			this.txt_tenban.Location = new System.Drawing.Point(12, 31);
			this.txt_tenban.Name = "txt_tenban";
			this.txt_tenban.Size = new System.Drawing.Size(126, 22);
			this.txt_tenban.TabIndex = 7;
			this.txt_tenban.TextChanged += new System.EventHandler(this.txt_tenban_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 601);
			this.Controls.Add(this.txt_tenban);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_thanhtien);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtgv);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý quán cafe - Vũ Quang Nhật";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgv;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbb_douong;
		private System.Windows.Forms.TextBox txt_gia;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_thanhtien;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txt_ghichu;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txt_tenban;
		private System.Windows.Forms.NumericUpDown nud_soluong;
	}
}

