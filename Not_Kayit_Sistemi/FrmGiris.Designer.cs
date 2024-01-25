namespace Not_Kayit_Sistemi
{
	partial class FrmGiris
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
			label = new Label();
			maskedTextBox1 = new MaskedTextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(116, 37);
			label.Name = "label";
			label.Size = new Size(208, 24);
			label.TabIndex = 0;
			label.Text = "ÖĞRENCİ NUMARA :";
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(330, 37);
			maskedTextBox1.Mask = "0000";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(144, 30);
			maskedTextBox1.TabIndex = 1;
			maskedTextBox1.ValidatingType = typeof(int);
			// 
			// button1
			// 
			button1.Location = new Point(334, 73);
			button1.Name = "button1";
			button1.Size = new Size(140, 40);
			button1.TabIndex = 2;
			button1.Text = "Giriş Yap";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// FrmGiris
			// 
			AutoScaleDimensions = new SizeF(12F, 24F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 224, 192);
			ClientSize = new Size(596, 337);
			Controls.Add(button1);
			Controls.Add(maskedTextBox1);
			Controls.Add(label);
			Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "FrmGiris";
			Text = "Öğrenci Not Kayıt Sistemi";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label;
		private MaskedTextBox maskedTextBox1;
		private Button button1;
	}
}