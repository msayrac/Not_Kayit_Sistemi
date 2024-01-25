namespace Not_Kayit_Sistemi
{
	public partial class FrmGiris : Form
	{
		public FrmGiris()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmOgrenciDetay frm = new FrmOgrenciDetay();

			frm.numara = maskedTextBox1.Text;

			frm.Show();

		}
	}
}