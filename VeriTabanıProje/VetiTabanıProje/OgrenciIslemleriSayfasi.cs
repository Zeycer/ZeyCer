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

namespace VetiTabanıProje
{
    public partial class OgrenciIslemleriSayfasi : Form
    {
        public OgrenciIslemleriSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G5DHSM1\\SQLEXPRESS;Initial Catalog=VeriTabaniVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa syf = new Anasayfa();
            syf.Show();
            this.Hide();
        }

        private void buttobbasvurulist_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand basvurulistcommand = new SqlCommand("exec basvurulist", baglanti);
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(basvurulistcommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();

            }
            catch (Exception)
            {
                baglanti.Close();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand basvurudelete = new SqlCommand("exec deletebasvuru @id", baglanti);
                baglanti.Open();
                basvurudelete.Parameters.AddWithValue("@id", selectidbasvuru);
                basvurudelete.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız.İşleminizi Kontrol Ettikten Sonra Tekrar Deneyiniz.");
            }
        }
        int selectidbasvuru;
        int selectidogrenci;
        string isim;
        string soyisim;
        string mail;
        string il;
        string ilce;
        string telno;
        string okul;
        string fakulte;
        string bolum;
        string adres;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    selectidbasvuru = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Başvuru No"].Value);
                 
                }
                catch (Exception)
                {

                    selectidogrenci = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Öğrenci No"].Value);
                    isim = Convert.ToString(dataGridView1.CurrentRow.Cells["İsim"].Value);
                    soyisim = Convert.ToString(dataGridView1.CurrentRow.Cells["Soy İsim"].Value);
                    mail = Convert.ToString(dataGridView1.CurrentRow.Cells["Mail Adresi"].Value);
                    il = Convert.ToString(dataGridView1.CurrentRow.Cells["Yaşadığı İl"].Value);
                    ilce = Convert.ToString(dataGridView1.CurrentRow.Cells["Yaşadığı İlce"].Value);
                    telno = Convert.ToString(dataGridView1.CurrentRow.Cells["Telefon Numarası"].Value);
                    okul = Convert.ToString(dataGridView1.CurrentRow.Cells["Okuduğu Üniversite"].Value);
                    fakulte = Convert.ToString(dataGridView1.CurrentRow.Cells["Okuduğu Fakülte"].Value);
                    bolum = Convert.ToString(dataGridView1.CurrentRow.Cells["Okuduğu Bölüm"].Value);
                    adres = Convert.ToString(dataGridView1.CurrentRow.Cells["Adres"].Value);
                }
            }
            catch (Exception)
            {
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand basvuruara = new SqlCommand("exec basvuruara @id", baglanti);
                baglanti.Open();
                basvuruara.Parameters.AddWithValue("@id", Convert.ToInt32(textBox11.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(basvuruara);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {

               
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand onay = new SqlCommand("exec basvuruonay @id", baglanti);
                baglanti.Open();
                onay.Parameters.AddWithValue("@id", selectidbasvuru);
                onay.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Onay İşlemi Başarıyla Gerçekleştirildi.");

            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("İşlem Gerçekleştirilemedi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ogrencilist = new SqlCommand("exec ogrencilist",baglanti);
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(ogrencilist);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand basvurudelete = new SqlCommand("exec deletebasvuru @id", baglanti);
                baglanti.Open();
                basvurudelete.Parameters.AddWithValue("@id", selectidogrenci);
                basvurudelete.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız.İşleminizi Kontrol Ettikten Sonra Tekrar Deneyiniz.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand basvuruara = new SqlCommand("exec ogrenciara @id", baglanti);
                baglanti.Open();
                basvuruara.Parameters.AddWithValue("@id", Convert.ToInt32(textBox12.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(basvuruara);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textisim.Text = isim;
            textsoyisim.Text = soyisim;
            textmail.Text = mail;
            textil.Text = il;
            textilce.Text = ilce;
            texttelno.Text = telno;
            textokul.Text = okul;
            textfakulte.Text = fakulte;
            textbolum.Text = bolum;
            textadres.Text = adres;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand ogrenciguncelle = new SqlCommand("exec ogrenciguncelle @isim,@soyisim,@mail,@il,@ilce,@telno,@okul,@bolum,@fakulte,@adres,@id",baglanti);
                baglanti.Open();
                ogrenciguncelle.Parameters.AddWithValue("@isim", textisim.Text);
                ogrenciguncelle.Parameters.AddWithValue("@soyisim", textsoyisim.Text);
                ogrenciguncelle.Parameters.AddWithValue("@mail", textmail.Text);
                ogrenciguncelle.Parameters.AddWithValue("@il", textil.Text);
                ogrenciguncelle.Parameters.AddWithValue("@ilce", textilce.Text);
                ogrenciguncelle.Parameters.AddWithValue("@telno", texttelno.Text);
                ogrenciguncelle.Parameters.AddWithValue("@okul", textokul.Text);
                ogrenciguncelle.Parameters.AddWithValue("@bolum", textbolum.Text);
                ogrenciguncelle.Parameters.AddWithValue("@fakulte", textfakulte.Text);
                ogrenciguncelle.Parameters.AddWithValue("@adres", textadres.Text);
                ogrenciguncelle.Parameters.AddWithValue("@id", selectidogrenci);
                ogrenciguncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleştirilmiştir.");
                textisim.Clear();
                textsoyisim.Clear();
                textmail.Clear();
                textil.Clear();
                textilce.Clear();
                texttelno.Clear();
                textokul.Clear();
                textfakulte.Clear();
                textbolum.Clear();
                textadres.Clear();
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Güncelleme İşlemi Başarısız.Lütfen Koktrol Edip Tekrar Deneyiniz");
               
            }

        }
    }
}
