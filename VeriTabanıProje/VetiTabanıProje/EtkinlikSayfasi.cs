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
    public partial class EtkinlikSayfasi : Form
    {
        public EtkinlikSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-G5DHSM1\\SQLEXPRESS;Initial Catalog=VeriTabaniVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa syf = new Anasayfa();
            syf.Show();
            this.Hide();

        }

      

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmnupdate = new SqlCommand("exec etkinlikguncelle @id,@ad,@il,@ilce,@date", baglan);
                baglan.Open();
                cmnupdate.Parameters.AddWithValue("@id", selectid);
                cmnupdate.Parameters.AddWithValue("@ad", etkinlikad.Text);
                cmnupdate.Parameters.AddWithValue("@il", textBoxil.Text);
                cmnupdate.Parameters.AddWithValue("@ilce", textBoxilce.Text);
                cmnupdate.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimeetkinlik.Text));
                cmnupdate.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
                etkinlikad.Text = String.Empty;
                textBoxil.Text = String.Empty;
                textBoxilce.Text = String.Empty;
                dateTimeetkinlik.Text = String.Empty;


            }
            catch (Exception)
            {
                MessageBox.Show("Güncelle işlemi başarısız.Lütfen kontrol ettikten sonra tekrar deneyiniz.");
 
            }

        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand command = new SqlCommand("exec etkinlikekle @ad,@il,@ilce,@tarih", baglan);
                command.Parameters.AddWithValue("@ad", etkinlikad.Text);
                command.Parameters.AddWithValue("@il", textBoxil.Text);
                command.Parameters.AddWithValue("@ilce", textBoxilce.Text);
                command.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dateTimeetkinlik.Text));
                command.ExecuteNonQuery();
                baglan.Close();

                MessageBox.Show("Ekleme İşlemi Başarılı");
                etkinlikad.Clear();
                textBoxil.Clear();
                textBoxilce.Clear();
                dateTimeetkinlik.Text= String.Empty;

            }
            catch (Exception)
            {
                baglan.Close();
                MessageBox.Show("Ekleme İşlemi Başarısız");

            }

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            SqlCommand list = new SqlCommand("exec etkinliklistesi",baglan);
            baglan.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(list);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        int selectid;
        String selectad;
        String selectil;
        String selectilce;
        DateTime selectdate;
      
        private void sil_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand cmndelete = new SqlCommand("exec etkinliksilme @id", baglan);
                baglan.Open();
                cmndelete.Parameters.AddWithValue("@id", selectid);
                cmndelete.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Silme işlemi başarıyla tamamlanmıştır.");

            }
            catch (Exception)
            {

                baglan.Close();
                MessageBox.Show("Silme işlemi başarısız.Lütfen işleminizi kontrol edip tekrar deneyiniz");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {   
                selectid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                selectad = (dataGridView1.CurrentRow.Cells["Etkinlik Adı"].Value).ToString();
                selectil= (dataGridView1.CurrentRow.Cells["Etkinlik Şehri"].Value).ToString();
                selectilce=(dataGridView1.CurrentRow.Cells["Etkinlik İlçesi"].Value).ToString();
                selectdate= Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Etkinlik Tarihi"].Value);

            }
            catch (Exception)
            {
                
            }

        }

        private void sec_Click(object sender, EventArgs e)
        {
            etkinlikad.Text = selectad;
            textBoxil.Text = selectil;
            textBoxilce.Text = selectilce;
            dateTimeetkinlik.Text = selectdate.ToLongDateString();

        }

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand bursara = new SqlCommand("exec etkinlikara @id", baglan);
                baglan.Open();
                bursara.Parameters.AddWithValue("@id", selectid);
                SqlDataAdapter adapter = new SqlDataAdapter(bursara);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                baglan.Close();
            }
            catch (Exception)
            {

                baglan.Close();
            }
        }

     
    }
}
