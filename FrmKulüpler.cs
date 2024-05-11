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
    public partial class FrmKulüpler : Form
    {
        public FrmKulüpler()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl=new SqlBaglantı();
        public string numara;
        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id ,ad as 'Kulüp Adı' from Tbl_Kulüpler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulüpler_Load(object sender, EventArgs e)
        {
            listele();  

            labelçıkış.Visible = false;

            SqlCommand komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
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
            labelçıkış.Visible = false;
            btnÇıkış.Width = 36;
            btnÇıkış.Height = 37;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kulüpler (ad) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşlemi Yapılmıştır.");
            listele();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Kulüpler set ad=@p1 where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textno.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncellene İşlemi Yapılmıştır.");

            listele();
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Kulüpler where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textno.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Yapılmıştır.");

            listele();
        }
    }
}
