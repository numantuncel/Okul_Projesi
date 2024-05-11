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
    public partial class Frm_Öğretmenİşlemleri : Form
    {
        public Frm_Öğretmenİşlemleri()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl=new SqlBaglantı();
        public string numara;
        DataSet1TableAdapters.DataTable2TableAdapter ds = new DataSet1TableAdapters.DataTable2TableAdapter();

        private void Frm_Öğretmenİşlemleri_Load(object sender, EventArgs e)
        {
            labelçıkış.Visible = false;

            DataTable dt = ds.ÖğretmenListele(byte.Parse(numara));
            foreach (DataRow row in dt.Rows)
            {
                
                textno.Text = numara;
                textadsoyad.Text = row["adsoyad"].ToString();
                textşifre.Text = row["şifre"].ToString();
                textbrnas.Text = row["dersAd"].ToString();
                
            }
            //  ad soyad çekme
            SqlCommand komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.ÖğretmenGüncelle(textadsoyad.Text,textşifre.Text, byte.Parse(numara));
            MessageBox.Show("Güncelleme İşlemi Tamamlanmıştır.");
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
            this.Close();
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
    }
}
