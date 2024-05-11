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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl=new SqlBaglantı();
        public string numara;

        SqlCommand komut;
        SqlDataAdapter da;
        DataTable dt;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            labelçıkış.Visible = false;

            komut = new SqlCommand("Select dersAd,sınav1,sınav2,sınav3,proje,ortalama,durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.dersid=Tbl_Dersler.id  where ogrid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
           
            da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            //  ad soyad çekme
            komut = new SqlCommand("Select ad, soyad from Tbl_Öğrenciler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku=komut.ExecuteReader();
            while(veriOku.Read())
            {
                this.Text = " "+veriOku[0] + " " + veriOku[1]+" "+ "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();
         
            
        }

        private void btnÇıkış_MouseLeave(object sender, EventArgs e)
        {
            labelçıkış.Visible = false;

            btnÇıkış.Width = 36;
            btnÇıkış.Height = 37;
        }

        private void btnÇıkış_MouseHover(object sender, EventArgs e)
        {
            
            labelçıkış.Visible = true;

            btnÇıkış.Width = 40;
            btnÇıkış.Height = 41;
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            FrmGirisler frmGirisler =new FrmGirisler();
            frmGirisler.Show();
            this.Hide();
        }
    }
}
