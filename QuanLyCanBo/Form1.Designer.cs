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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txt_hoten = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbb_quequan = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_timkiem = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_sua = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_them = new System.Windows.Forms.Button();
			this.cbb_donvi = new System.Windows.Forms.ComboBox();
			this.cbb_hocvi = new System.Windows.Forms.ComboBox();
			this.cb_nam = new System.Windows.Forms.RadioButton();
			this.cb_nu = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
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
			this.dataGridView1.Location = new System.Drawing.Point(8, 202);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(780, 266);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.TabStop = false;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(8, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Cyan;
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Panel1.Controls.Add(this.txt_hoten);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.cbb_quequan);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Cyan;
			this.splitContainer1.Panel2.Controls.Add(this.btn_timkiem);
			this.splitContainer1.Panel2.Controls.Add(this.btn_xoa);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.btn_sua);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.btn_them);
			this.splitContainer1.Panel2.Controls.Add(this.cbb_donvi);
			this.splitContainer1.Panel2.Controls.Add(this.cbb_hocvi);
			this.splitContainer1.Size = new System.Drawing.Size(780, 184);
			this.splitContainer1.SplitterDistance = 375;
			this.splitContainer1.TabIndex = 0;
			// 
			// txt_hoten
			// 
			this.txt_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_hoten.Location = new System.Drawing.Point(84, 15);
			this.txt_hoten.Name = "txt_hoten";
			this.txt_hoten.Size = new System.Drawing.Size(250, 22);
			this.txt_hoten.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên";
			// 
			// cbb_quequan
			// 
			this.cbb_quequan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_quequan.FormattingEnabled = true;
			this.cbb_quequan.Location = new System.Drawing.Point(85, 138);
			this.cbb_quequan.Name = "cbb_quequan";
			this.cbb_quequan.Size = new System.Drawing.Size(249, 24);
			this.cbb_quequan.TabIndex = 3;
			this.cbb_quequan.DropDown += new System.EventHandler(this.cbb_quequan_DropDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giới tính";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quê quán";
			// 
			// btn_timkiem
			// 
			this.btn_timkiem.Location = new System.Drawing.Point(301, 123);
			this.btn_timkiem.Name = "btn_timkiem";
			this.btn_timkiem.Size = new System.Drawing.Size(84, 52);
			this.btn_timkiem.TabIndex = 9;
			this.btn_timkiem.Text = "Tìm kiếm";
			this.btn_timkiem.UseVisualStyleBackColor = true;
			this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(205, 123);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(86, 52);
			this.btn_xoa.TabIndex = 8;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Đơn vị";
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(108, 123);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(87, 52);
			this.btn_sua.TabIndex = 7;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Học hàm / Học vị";
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(24, 123);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(79, 52);
			this.btn_them.TabIndex = 6;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// cbb_donvi
			// 
			this.cbb_donvi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_donvi.FormattingEnabled = true;
			this.cbb_donvi.Location = new System.Drawing.Point(99, 15);
			this.cbb_donvi.Name = "cbb_donvi";
			this.cbb_donvi.Size = new System.Drawing.Size(275, 24);
			this.cbb_donvi.TabIndex = 4;
			this.cbb_donvi.DropDown += new System.EventHandler(this.cbb_donvi_DropDown);
			// 
			// cbb_hocvi
			// 
			this.cbb_hocvi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_hocvi.FormattingEnabled = true;
			this.cbb_hocvi.Location = new System.Drawing.Point(146, 72);
			this.cbb_hocvi.Name = "cbb_hocvi";
			this.cbb_hocvi.Size = new System.Drawing.Size(228, 24);
			this.cbb_hocvi.TabIndex = 5;
			this.cbb_hocvi.DropDown += new System.EventHandler(this.cbb_hocvi_DropDown);
			// 
			// cb_nam
			// 
			this.cb_nam.AutoSize = true;
			this.cb_nam.Location = new System.Drawing.Point(3, 3);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(57, 18);
			this.cb_nam.TabIndex = 1;
			this.cb_nam.TabStop = true;
			this.cb_nam.Text = "Nam";
			this.cb_nam.UseVisualStyleBackColor = true;
			// 
			// cb_nu
			// 
			this.cb_nu.AutoSize = true;
			this.cb_nu.Location = new System.Drawing.Point(103, 3);
			this.cb_nu.Name = "cb_nu";
			this.cb_nu.Size = new System.Drawing.Size(45, 18);
			this.cb_nu.TabIndex = 2;
			this.cb_nu.TabStop = true;
			this.cb_nu.Text = "Nữ";
			this.cb_nu.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.cb_nu, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.cb_nam, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 72);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 24);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 474);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân sự (Vũ Quang Nhật - 2251172445)";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txt_hoten;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbb_quequan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_timkiem;
		private System.Windows.Forms.Button btn_xoa;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_them;
		private System.Windows.Forms.ComboBox cbb_donvi;
		private System.Windows.Forms.ComboBox cbb_hocvi;
		private System.Windows.Forms.RadioButton cb_nu;
		private System.Windows.Forms.RadioButton cb_nam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

