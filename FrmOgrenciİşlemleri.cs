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
    public partial class FrmOgrenciİşlemleri : Form
    {
        public FrmOgrenciİşlemleri()
        {
            InitializeComponent();
        }
        public string numara;
        
        DataSet1TableAdapters.DataTable1TableAdapter ds=new DataSet1TableAdapters.DataTable1TableAdapter();

        public void listele()
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        SqlBaglantı bgl=new SqlBaglantı();

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            FrmÖğretmen frmÖğretmen =new FrmÖğretmen();
            frmÖğretmen.numara = numara;
            frmÖğretmen.Show();
            this.Close();
        }

        private void FrmOgrenciİşlemleri_Load(object sender, EventArgs e)
        {
            labelçıkış.Visible=false;

            
            // Öğretmen Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select adsoyad from Tbl_Öğretmenler where id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", numara);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                this.Text = " " + veriOku[0] + " " + "Hoşgeldiniz.";
            }
            bgl.baglanti().Close();

            // datagrid doldur
            listele();

            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kulüpler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combokulüp.DisplayMember = "ad";
            //DisplayMember: Bu özellik, ComboBox içinde görüntülenecek metni temsil eder.
            //Yani, kullanıcıya görüntülenecek olan öğenin hangi özelliğinin (veya sütununun) kullanılacağını belirtir.
            //Örneğin, eğer ad öğesini DisplayMember olarak belirlerseniz, ComboBox içinde her öğe olarak adları göreceksiniz.
            combokulüp.ValueMember = "id";
            //ValueMember: Bu özellik ise, ComboBox'te seçilen öğenin hangi değeri temsil ettiğini belirtir.
            //Yani, ComboBox'ten bir öğe seçildiğinde, arkasındaki veri kaynağından alınacak olan değerin hangi özelliği (veya sütunu) kullanılacağını belirtir.
            //Örneğin, id öğesini ValueMember olarak belirlediğinizde, ComboBox'ten bir öğe seçildiğinde geri dönecek değer, o öğenin id özelliği olacaktır.
            combokulüp.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.OgrenciEkle(textad.Text,textsoyad.Text,byte.Parse(combokulüp.SelectedValue.ToString()),combocinsiyet.Text,textşifre.Text);
            MessageBox.Show("Öğrenci Ekleme İşlemi Yapıldı.");
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrSil(byte.Parse(textno.Text));
            MessageBox.Show("Öğrenci Silme İşlemi Yapıldı.");
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            combocinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textşifre.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            combokulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.OgrGüncelle(textad.Text, textsoyad.Text, byte.Parse(combokulüp.SelectedValue.ToString()), combocinsiyet.Text, textşifre.Text,Convert.ToInt16(textno.Text));
            MessageBox.Show("Öğrenci Güncelleme İşlemi Yapıldı.");
            listele();
        }

        private void textAdAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(textAdAra.Text);

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

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();  
        }
    }
}
