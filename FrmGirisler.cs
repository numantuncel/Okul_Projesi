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
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();

        private void btnÖğrenci_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Öğrenciler where id=@p1 and şifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textno.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                FrmOgrenciNotlar frmOgrenciNotlar = new FrmOgrenciNotlar();
                frmOgrenciNotlar.numara = textno.Text;
                frmOgrenciNotlar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı No Veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void btnÖğretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Öğretmenler where id=@p1 and şifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textno.Text);
            komut.Parameters.AddWithValue("@p2", textsifre.Text);
            SqlDataReader verioku = komut.ExecuteReader();
            if (verioku.Read())
            {
                FrmÖğretmen frmÖğretmen=new FrmÖğretmen();
                frmÖğretmen.numara = textno.Text;
                frmÖğretmen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı No Veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnÖğrenci_MouseHover(object sender, EventArgs e)
        {
            labelÖgr.Visible = true;
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {
            labelÖgr.Visible= false;
            labelOgrtmn.Visible= false;
        }

        private void btnÖğrenci_MouseLeave(object sender, EventArgs e)
        {
            labelÖgr.Visible = false;
          
        }

        private void btnÖğretmen_MouseHover(object sender, EventArgs e)
        {
            labelOgrtmn.Visible = true;
        }

        private void btnÖğretmen_MouseLeave(object sender, EventArgs e)
        {
            labelOgrtmn.Visible = false;
        }
    }
}
