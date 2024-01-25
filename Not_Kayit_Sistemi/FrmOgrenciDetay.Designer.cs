namespace Not_Kayit_Sistemi
{
	partial class FrmOgrenciDetay
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
			label1 = new Label();
			LblAdSoyad = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			LblSinav1 = new Label();
			LblSinav2 = new Label();
			LblSinav3 = new Label();
			label9 = new Label();
			label10 = new Label();
			lblOrtalama = new Label();
			label12 = new Label();
			lblDurum = new Label();
			LblNumara = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 46);
			label1.Name = "label1";
			label1.Size = new Size(103, 24);
			label1.TabIndex = 0;
			label1.Text = "Ad Soyad :";
			// 
			// LblAdSoyad
			// 
			LblAdSoyad.AutoSize = true;
			LblAdSoyad.Location = new Point(140, 46);
			LblAdSoyad.Name = "LblAdSoyad";
			LblAdSoyad.Size = new Size(64, 24);
			LblAdSoyad.TabIndex = 1;
			LblAdSoyad.Text = "NULL";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(36, 144);
			label3.Name = "label3";
			label3.Size = new Size(84, 24);
			label3.TabIndex = 2;
			label3.Text = "Sınav 1 :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(34, 180);
			label4.Name = "label4";
			label4.Size = new Size(86, 24);
			label4.TabIndex = 3;
			label4.Text = "Sınav 2 :";
			//label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(34, 216);
			label5.Name = "label5";
			label5.Size = new Size(86, 24);
			label5.TabIndex = 4;
			label5.Text = "Sınav 3 :";
			// 
			// LblSinav1
			// 
			LblSinav1.AutoSize = true;
			LblSinav1.Location = new Point(135, 144);
			LblSinav1.Name = "LblSinav1";
			LblSinav1.Size = new Size(34, 24);
			LblSinav1.TabIndex = 5;
			LblSinav1.Text = "00";
			// 
			// LblSinav2
			// 
			LblSinav2.AutoSize = true;
			LblSinav2.Location = new Point(135, 180);
			LblSinav2.Name = "LblSinav2";
			LblSinav2.Size = new Size(34, 24);
			LblSinav2.TabIndex = 6;
			LblSinav2.Text = "00";
			// 
			// LblSinav3
			// 
			LblSinav3.AutoSize = true;
			LblSinav3.Location = new Point(135, 216);
			LblSinav3.Name = "LblSinav3";
			LblSinav3.Size = new Size(34, 24);
			LblSinav3.TabIndex = 7;
			LblSinav3.Text = "00";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(36, 89);
			label9.Name = "label9";
			label9.Size = new Size(94, 24);
			label9.TabIndex = 8;
			label9.Text = "Numara :";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(25, 259);
			label10.Name = "label10";
			label10.Size = new Size(105, 24);
			label10.TabIndex = 9;
			label10.Text = "Ortalama :";
			// 
			// lblOrtalama
			// 
			lblOrtalama.AutoSize = true;
			lblOrtalama.Location = new Point(135, 259);
			lblOrtalama.Name = "lblOrtalama";
			lblOrtalama.Size = new Size(34, 24);
			lblOrtalama.TabIndex = 10;
			lblOrtalama.Text = "00";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(36, 296);
			label12.Name = "label12";
			label12.Size = new Size(86, 24);
			label12.TabIndex = 11;
			label12.Text = "Durum :";
			// 
			// lblDurum
			// 
			lblDurum.AutoSize = true;
			lblDurum.Location = new Point(135, 296);
			lblDurum.Name = "lblDurum";
			lblDurum.Size = new Size(64, 24);
			lblDurum.TabIndex = 12;
			lblDurum.Text = "NULL";
			// 
			// LblNumara
			// 
			LblNumara.AutoSize = true;
			LblNumara.Location = new Point(135, 89);
			LblNumara.Name = "LblNumara";
			LblNumara.Size = new Size(58, 24);
			LblNumara.TabIndex = 13;
			LblNumara.Text = "0000";
			// 
			// FrmOgrenciDetay
			// 
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			ClientSize = new Size(398, 468);
			Controls.Add(LblNumara);
			Controls.Add(lblDurum);
			Controls.Add(label12);
			Controls.Add(lblOrtalama);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(LblSinav3);
			Controls.Add(LblSinav2);
			Controls.Add(LblSinav1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(LblAdSoyad);
			Controls.Add(label1);
			Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "FrmOgrenciDetay";
			Text = "Öğrenci Not Kayıt Sistemi";
			Load += FrmOgrenciDetay_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label LblAdSoyad;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label LblSinav1;
		private Label LblSinav2;
		private Label LblSinav3;
		private Label label9;
		private Label label10;
		private Label lblOrtalama;
		private Label label12;
		private Label lblDurum;
		private Label LblNumara;
	}
}