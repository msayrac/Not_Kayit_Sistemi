using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Not_Kayit_Sistemi
{
	public partial class FrmOgretmenDetay : Form
	{
		public FrmOgretmenDetay()
		{
			InitializeComponent();
		}


		SqlConnection baglanti = new SqlConnection(@"Data Source=msyc; Initial catalog=DbNotKayit; Integrated Security=True");

		SqlDataAdapter adpt;
		DataTable dt;



		private void FrmOgretmenDetay_Load(object sender, EventArgs e)
		{
			showDataCustomer();

		}

		private void showDataCustomer()
		{

			adpt = new SqlDataAdapter("select * from TBLDERS", baglanti);
			dt = new DataTable();
			adpt.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA, OGRAD,OGRSOYAD) values (@P1, @P2, @P3)", baglanti);
			komut.Parameters.AddWithValue("@P1", MskNumara.Text);
			komut.Parameters.AddWithValue("@P2", TxtAd.Text);
			komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Öğrenci Sisteme Eklendi");
			showDataCustomer();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

			TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			double ortalama, s1, s2, s3;
			int kalan = 0;
			int gecen = 0;
			string durum;

			s1 = Convert.ToDouble(TxtSinav1.Text);
			s2 = Convert.ToDouble(TxtSinav2.Text);
			s3 = Convert.ToDouble(TxtSinav3.Text);			

			ortalama = (s1 + s2 + s3) / 3;
			LblOrtalama.Text = ortalama.ToString();

			if (ortalama >= 50)
			{
				durum = "True";
				//gecen += 1;
			}
			else
			{
				durum = "False";
				//kalan += 1;
			}

			baglanti.Open();

			SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1, OGRS2=@P2, OGRS3 =@P3, ORTALAMA=@P4, DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);

			komut.Parameters.AddWithValue("@P1", TxtSinav1.Text);
			komut.Parameters.AddWithValue("@P2", TxtSinav2.Text);
			komut.Parameters.AddWithValue("@P3", TxtSinav3.Text);
			komut.Parameters.AddWithValue("@P4", decimal.Parse(LblOrtalama.Text));
			komut.Parameters.AddWithValue("@P5", durum);
			komut.Parameters.AddWithValue("@P6", MskNumara.Text);

			//int i = dataGridView1.SelectedCells[0].RowIndex;
			//dataGridView1.Rows[i].Cells[1].Value.ToString();

			for (int i=0; i< 13; i++)
			{

				string x = dataGridView1.Rows[i].Cells[8].Value.ToString();
				if (dataGridView1.Rows[i].Cells[8].Value.ToString().Equals("True"))
				{
					gecen += 1;
				}
				else
				{
					kalan += 1;
				}
			}
			

			LblKalanSayisi.Text = kalan.ToString();
			LblGecenSayisi.Text = gecen.ToString();


			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Öğrenci Notları Güncellendi");
			showDataCustomer();


		}
	}
}
