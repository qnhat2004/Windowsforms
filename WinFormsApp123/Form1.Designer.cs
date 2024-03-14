namespace WinFormsApp123
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			txt_masach = new TextBox();
			txt_tieude = new TextBox();
			textBox7 = new TextBox();
			textBox2 = new TextBox();
			textBox8 = new TextBox();
			txt_gia = new TextBox();
			txt_soluong = new TextBox();
			dataGridView1 = new DataGridView();
			btn_Them = new Button();
			btn_Luu = new Button();
			btn_Xoa = new Button();
			btn_Boqua = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.Control;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Location = new Point(22, 28);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 20);
			textBox1.TabIndex = 0;
			textBox1.Text = "Mã sách:";
			// 
			// txt_masach
			// 
			txt_masach.Location = new Point(100, 28);
			txt_masach.Name = "txt_masach";
			txt_masach.Size = new Size(125, 27);
			txt_masach.TabIndex = 2;
			// 
			// txt_tieude
			// 
			txt_tieude.Location = new Point(100, 71);
			txt_tieude.Name = "txt_tieude";
			txt_tieude.Size = new Size(368, 27);
			txt_tieude.TabIndex = 3;
			// 
			// textBox7
			// 
			textBox7.BackColor = SystemColors.Control;
			textBox7.BorderStyle = BorderStyle.None;
			textBox7.Location = new Point(22, 78);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(72, 20);
			textBox7.TabIndex = 6;
			textBox7.Text = "Tiêu đề:";
			textBox7.TextChanged += textBox7_TextChanged;
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.Control;
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Location = new Point(567, 28);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 20);
			textBox2.TabIndex = 7;
			textBox2.Text = "Giá:";
			textBox2.TextChanged += textBox2_TextChanged_1;
			// 
			// textBox8
			// 
			textBox8.BackColor = SystemColors.Control;
			textBox8.BorderStyle = BorderStyle.None;
			textBox8.Location = new Point(567, 78);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(125, 20);
			textBox8.TabIndex = 8;
			textBox8.Text = "Số lượng:";
			// 
			// txt_gia
			// 
			txt_gia.Location = new Point(646, 25);
			txt_gia.Name = "txt_gia";
			txt_gia.Size = new Size(125, 27);
			txt_gia.TabIndex = 9;
			// 
			// txt_soluong
			// 
			txt_soluong.Location = new Point(646, 71);
			txt_soluong.Name = "txt_soluong";
			txt_soluong.Size = new Size(125, 27);
			txt_soluong.TabIndex = 10;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToOrderColumns = true;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 127);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(856, 237);
			dataGridView1.TabIndex = 11;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btn_Them
			// 
			btn_Them.Location = new Point(237, 381);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(94, 29);
			btn_Them.TabIndex = 12;
			btn_Them.Text = "Thêm mới";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// btn_Luu
			// 
			btn_Luu.Location = new Point(337, 381);
			btn_Luu.Name = "btn_Luu";
			btn_Luu.Size = new Size(94, 29);
			btn_Luu.TabIndex = 13;
			btn_Luu.Text = "Lưu";
			btn_Luu.UseVisualStyleBackColor = true;
			btn_Luu.Click += btn_Luu_Click_1;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Location = new Point(437, 381);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(94, 29);
			btn_Xoa.TabIndex = 14;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = true;
			btn_Xoa.Click += btn_Xoa_Click_1;
			// 
			// btn_Boqua
			// 
			btn_Boqua.Location = new Point(540, 381);
			btn_Boqua.Name = "btn_Boqua";
			btn_Boqua.Size = new Size(94, 29);
			btn_Boqua.TabIndex = 15;
			btn_Boqua.Text = "Bỏ qua";
			btn_Boqua.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(880, 422);
			Controls.Add(btn_Boqua);
			Controls.Add(btn_Xoa);
			Controls.Add(btn_Luu);
			Controls.Add(btn_Them);
			Controls.Add(dataGridView1);
			Controls.Add(txt_soluong);
			Controls.Add(txt_gia);
			Controls.Add(textBox8);
			Controls.Add(textBox2);
			Controls.Add(textBox7);
			Controls.Add(txt_tieude);
			Controls.Add(txt_masach);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox txt_masach;
		private TextBox txt_tieude;
		private TextBox textBox7;
		private TextBox textBox2;
		private TextBox textBox8;
		private TextBox txt_gia;
		private TextBox txt_soluong;
		private DataGridView dataGridView1;
		private Button btn_Them;
		private Button btn_Luu;
		private Button btn_Xoa;
		private Button btn_Boqua;
	}
}
