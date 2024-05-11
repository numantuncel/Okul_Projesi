using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Okul_Projesi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();

        public string numara;

        SqlBaglantı bgl = new SqlBaglantı();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();

            SqlCommand komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();

            labelçıkış.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(textad.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapıldı.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(textad.Text,byte.Parse(textno.Text));// tinyint olarak tanımladık bu yüzden dönüşüm olması lazım
            MessageBox.Show("Ders Güncelleme İşlemi Yapıldı.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(textno.Text));
            MessageBox.Show("Ders Silme İşlemi Yapıldı.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            FrmÖğretmen frmÖğretmen=new FrmÖğretmen();
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
            labelçıkış.Visible=false;
            btnÇıkış.Width = 36;
            btnÇıkış.Height = 37;
        }
    }
}
