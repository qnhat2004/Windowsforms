namespace QuanLyCuaHangTruyen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dtgv = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_tenkhach = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.txt_dongia = new System.Windows.Forms.TextBox();
			this.dtp_ngaymuon = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
			this.btn_muon = new System.Windows.Forms.Button();
			this.cbb_tentruyen = new System.Windows.Forms.ComboBox();
			this.btn_tra = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgv
			// 
			this.dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv.Location = new System.Drawing.Point(12, 276);
			this.dtgv.Name = "dtgv";
			this.dtgv.ReadOnly = true;
			this.dtgv.RowHeadersWidth = 51;
			this.dtgv.RowTemplate.Height = 24;
			this.dtgv.Size = new System.Drawing.Size(855, 254);
			this.dtgv.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(391, 258);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txt_tenkhach
			// 
			this.txt_tenkhach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_tenkhach.Location = new System.Drawing.Point(533, 12);
			this.txt_tenkhach.Name = "txt_tenkhach";
			this.txt_tenkhach.Size = new System.Drawing.Size(334, 22);
			this.txt_tenkhach.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(430, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tên khách";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(430, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Số điện thoại";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(430, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên truyện";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(430, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Đơn giá/ngày";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(430, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Ngày mượn";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(430, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Ngày trả";
			// 
			// txt_sdt
			// 
			this.txt_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_sdt.Location = new System.Drawing.Point(533, 56);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(334, 22);
			this.txt_sdt.TabIndex = 9;
			this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
			this.txt_sdt.Leave += new System.EventHandler(this.txt_sdt_Leave);
			// 
			// txt_dongia
			// 
			this.txt_dongia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_dongia.Enabled = false;
			this.txt_dongia.Location = new System.Drawing.Point(533, 149);
			this.txt_dongia.Name = "txt_dongia";
			this.txt_dongia.ReadOnly = true;
			this.txt_dongia.Size = new System.Drawing.Size(334, 22);
			this.txt_dongia.TabIndex = 11;
			this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
			// 
			// dtp_ngaymuon
			// 
			this.dtp_ngaymuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_ngaymuon.Location = new System.Drawing.Point(533, 192);
			this.dtp_ngaymuon.Name = "dtp_ngaymuon";
			this.dtp_ngaymuon.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaymuon.TabIndex = 12;
			// 
			// dtp_ngaytra
			// 
			this.dtp_ngaytra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_ngaytra.Location = new System.Drawing.Point(533, 236);
			this.dtp_ngaytra.Name = "dtp_ngaytra";
			this.dtp_ngaytra.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaytra.TabIndex = 13;
			// 
			// btn_muon
			// 
			this.btn_muon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_muon.Location = new System.Drawing.Point(744, 186);
			this.btn_muon.Name = "btn_muon";
			this.btn_muon.Size = new System.Drawing.Size(123, 38);
			this.btn_muon.TabIndex = 14;
			this.btn_muon.Text = "Mượn truyện";
			this.btn_muon.UseVisualStyleBackColor = true;
			this.btn_muon.Click += new System.EventHandler(this.btn_muon_Click);
			// 
			// cbb_tentruyen
			// 
			this.cbb_tentruyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_tentruyen.FormattingEnabled = true;
			this.cbb_tentruyen.Location = new System.Drawing.Point(533, 107);
			this.cbb_tentruyen.Name = "cbb_tentruyen";
			this.cbb_tentruyen.Size = new System.Drawing.Size(334, 24);
			this.cbb_tentruyen.TabIndex = 16;
			this.cbb_tentruyen.DropDown += new System.EventHandler(this.cbb_tentruyen_DropDown);
			this.cbb_tentruyen.SelectedIndexChanged += new System.EventHandler(this.cbb_tentruyen_SelectedIndexChanged);
			this.cbb_tentruyen.TextUpdate += new System.EventHandler(this.cbb_tentruyen_TextUpdate);
			this.cbb_tentruyen.DropDownClosed += new System.EventHandler(this.cbb_tentruyen_DropDownClosed);
			// 
			// btn_tra
			// 
			this.btn_tra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_tra.Location = new System.Drawing.Point(744, 232);
			this.btn_tra.Name = "btn_tra";
			this.btn_tra.Size = new System.Drawing.Size(123, 35);
			this.btn_tra.TabIndex = 15;
			this.btn_tra.Text = "Trả truyện";
			this.btn_tra.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 531);
			this.Controls.Add(this.cbb_tentruyen);
			this.Controls.Add(this.btn_tra);
			this.Controls.Add(this.btn_muon);
			this.Controls.Add(this.dtp_ngaytra);
			this.Controls.Add(this.dtp_ngaymuon);
			this.Controls.Add(this.txt_dongia);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_tenkhach);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dtgv);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chương trình quản lý cửa hàng truyện tranh(Vũ Quang Nhật - 2251172445)";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgv;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txt_tenkhach;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.TextBox txt_dongia;
		private System.Windows.Forms.DateTimePicker dtp_ngaymuon;
		private System.Windows.Forms.DateTimePicker dtp_ngaytra;
		private System.Windows.Forms.Button btn_muon;
		private System.Windows.Forms.ComboBox cbb_tentruyen;
		private System.Windows.Forms.Button btn_tra;
	}
}

