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

namespace Okul_Projesi
{
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();

        public string numara;

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();


        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            labelçıkış.Visible = false;
            labelAra.Visible = false;
            
            textno.Focus();
            // ad soyad çekme
            SqlCommand komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(textno.Text));
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            FrmÖğretmen frmÖğretmen = new FrmÖğretmen();
            frmÖğretmen.numara = numara;
            frmÖğretmen.Show();
            this.Close();
        }

        private void btnÇıkış_MouseHover(object sender, EventArgs e)
        {
            labelçıkış.Visible = true;

            btnÇıkış.Width = 40;
            btnÇıkış.Height = 41;
        }

        private void btnÇıkış_MouseLeave(object sender, EventArgs e)
        {
            labelçıkış.Visible = false;

            btnÇıkış.Width = 36;
            btnÇıkış.Height = 37;
        }

        private void btnara_MouseHover(object sender, EventArgs e)
        {
            labelAra.Visible = true;
        }

        private void btnara_MouseLeave(object sender, EventArgs e)
        {
            labelAra.Visible = false;
        }
        int notid;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textders.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textProje.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        public string durum;
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, proje;
            double ortalama;

            sınav1 = Convert.ToInt16(textSınav1.Text);
            sınav2 = Convert.ToInt16(textSınav2.Text);
            sınav3 = Convert.ToInt16(textSınav3.Text);
            proje = Convert.ToInt16(textProje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4.0;// .0 koymak bölme işlemini ondalık sayılar üzerinden yapmayı sağlar
            textOrtalama.Text = ortalama.ToString("N");// virgüllü ifade için n 
            if (ortalama > 45)
            {
                textDurum.Text = "True";
            }
            else
            {
                textDurum.Text = "False";
            }
            durum = textDurum.Text;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.OgrGüncelle(byte.Parse(textSınav1.Text), byte.Parse(textSınav2.Text), byte.Parse(textSınav3.Text), byte.Parse(textProje.Text), decimal.Parse(textOrtalama.Text), bool.Parse(durum), byte.Parse(notid.ToString()));
            MessageBox.Show("Not Güncelleme İşlemi Yapılmıştır.");
            dataGridView1.DataSource = ds.NotListesi(int.Parse(textno.Text));
        }

        private void labelçıkış_Click(object sender, EventArgs e)
        {

        }
    }
}
