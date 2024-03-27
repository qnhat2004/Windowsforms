namespace BanVeXemPhim1
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
			this.lbl_tenphim = new System.Windows.Forms.Label();
			this.cbb_tenphim = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_thanhtien = new System.Windows.Forms.Label();
			this.btn_thanhtoan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn phim";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mời bạn chọn ghế trong phòng chiếu phim: ";
			// 
			// lbl_tenphim
			// 
			this.lbl_tenphim.AutoSize = true;
			this.lbl_tenphim.Location = new System.Drawing.Point(302, 67);
			this.lbl_tenphim.Name = "lbl_tenphim";
			this.lbl_tenphim.Size = new System.Drawing.Size(0, 16);
			this.lbl_tenphim.TabIndex = 2;
			// 
			// cbb_tenphim
			// 
			this.cbb_tenphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbb_tenphim.FormattingEnabled = true;
			this.cbb_tenphim.Items.AddRange(new object[] {
            "naruto",
            "titanic",
            "7 viên ngọc rồng",
            "bé xuân mai",
            "vscode",
            "vs2022"});
			this.cbb_tenphim.Location = new System.Drawing.Point(111, 18);
			this.cbb_tenphim.Name = "cbb_tenphim";
			this.cbb_tenphim.Size = new System.Drawing.Size(321, 24);
			this.cbb_tenphim.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 465);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Thành tiền: ";
			// 
			// lbl_thanhtien
			// 
			this.lbl_thanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_thanhtien.AutoSize = true;
			this.lbl_thanhtien.BackColor = System.Drawing.Color.Yellow;
			this.lbl_thanhtien.Location = new System.Drawing.Point(91, 465);
			this.lbl_thanhtien.Name = "lbl_thanhtien";
			this.lbl_thanhtien.Size = new System.Drawing.Size(25, 16);
			this.lbl_thanhtien.TabIndex = 7;
			this.lbl_thanhtien.Text = "0 đ";
			this.lbl_thanhtien.Click += new System.EventHandler(this.label5_Click);
			// 
			// btn_thanhtoan
			// 
			this.btn_thanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_thanhtoan.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_thanhtoan.Location = new System.Drawing.Point(596, 454);
			this.btn_thanhtoan.Name = "btn_thanhtoan";
			this.btn_thanhtoan.Size = new System.Drawing.Size(91, 38);
			this.btn_thanhtoan.TabIndex = 8;
			this.btn_thanhtoan.Text = "Thanh toán";
			this.btn_thanhtoan.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 504);
			this.Controls.Add(this.btn_thanhtoan);
			this.Controls.Add(this.lbl_thanhtien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbb_tenphim);
			this.Controls.Add(this.lbl_tenphim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_tenphim;
		private System.Windows.Forms.ComboBox cbb_tenphim;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_thanhtien;
		private System.Windows.Forms.Button btn_thanhtoan;
	}
}

