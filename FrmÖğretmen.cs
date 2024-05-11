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
    public partial class FrmÖğretmen : Form
    {
        public FrmÖğretmen()
        {
            InitializeComponent();
            
        }
        SqlBaglantı bgl = new SqlBaglantı();
        SqlCommand komut;

        public string numara;
        
        
        private void FrmÖğretmen_Load(object sender, EventArgs e)
        {
            //  ad soyad çekme
            komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();

            labelçıkış.Visible= false;

        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler = new FrmGirisler();
            frmGirisler.Show();
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

        private void btnKulüpler_Click(object sender, EventArgs e)
        {
            FrmKulüpler frmKulüpler=new FrmKulüpler();
            frmKulüpler.numara=numara;
            frmKulüpler.Show();
            this.Hide();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            FrmDersler frmDersler = new FrmDersler();
            frmDersler.numara=numara;
            frmDersler.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciİşlemleri frmOİ=new FrmOgrenciİşlemleri();
            frmOİ.numara=numara;
            frmOİ.Show();
            this.Hide();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar frmSınavNotlar = new FrmSınavNotlar();
            frmSınavNotlar.numara=numara;
            frmSınavNotlar.Show();
            this.Hide();
        }

        private void btnİşlemlerim_Click(object sender, EventArgs e)
        {
            Frm_Öğretmenİşlemleri frm_Öğretmenİşlemleri = new Frm_Öğretmenİşlemleri();
            frm_Öğretmenİşlemleri.numara=numara;
            frm_Öğretmenİşlemleri.Show();
            this.Hide();
        }
    }
}
