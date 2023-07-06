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
    public partial class BursIslemleriSayfasi : Form
    {
        public BursIslemleriSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-G5DHSM1\\SQLEXPRESS;Initial Catalog=VeriTabaniVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa syf = new Anasayfa();
            syf.Show();
            this.Hide();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmn = new SqlCommand("exec bursekle @ad,@adet,@miktar,@aciklama", con);
                cmn.Parameters.AddWithValue("@ad", textad.Text);
                cmn.Parameters.AddWithValue("@adet", int.Parse(textadet.Text));
                cmn.Parameters.AddWithValue("@miktar", int.Parse(textmiktar.Text));
                cmn.Parameters.AddWithValue("@aciklama", textaciklama.Text);
                cmn.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ekleme Başarılı");
                textad.Clear();
                textadet.Clear();
                textmiktar.Clear();
                textaciklama.Clear();

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Ekleme Başarısız,Lütfen Tekrar Deneyin");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand list = new SqlCommand("exec burslistele", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(list);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        int selectid;
        String selectbursad;
        int selectmiktar;
        int selectadet;
        String selectbursarti;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmndelete = new SqlCommand("exec burssilme @id", con);
                con.Open();
                cmndelete.Parameters.AddWithValue("@id", selectid);
                cmndelete.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Silme işlemi başarıyla tamamlanmıştır.");

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Silme işlemi başarısız.Lütfen işleminizi kontrol edip tekrar deneyiniz");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                selectbursad = Convert.ToString(dataGridView1.CurrentRow.Cells["Adı"].Value);
                selectmiktar = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Burs Tutarı"].Value);
                selectadet = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Verilecek Kişi Sayısı"].Value);
                selectbursarti = Convert.ToString(dataGridView1.CurrentRow.Cells["Şartı"].Value);

            }
            catch (Exception)
            {

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textad.Text = selectbursad;
            textadet.Text = selectadet.ToString();
            textmiktar.Text = selectmiktar.ToString();
            textaciklama.Text = selectbursarti;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmnupdate = new SqlCommand("exec bursguncelle @id,@ad,@adet,@miktar,@aciklama", con);
                con.Open();
                cmnupdate.Parameters.AddWithValue("@id", selectid);
                cmnupdate.Parameters.AddWithValue("@ad", textad.Text);
                cmnupdate.Parameters.AddWithValue("@adet", Convert.ToInt32(textadet.Text));
                cmnupdate.Parameters.AddWithValue("@miktar", Convert.ToInt32(textmiktar.Text));
                cmnupdate.Parameters.AddWithValue("@aciklama", textaciklama.Text);
                cmnupdate.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                textad.Clear();
                textadet.Clear();
                textmiktar.Clear();
                textaciklama.Clear();

            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Güncelleme İşleminiz Başarısız.Lütfen İşleminizi Kontrol Edip Tekrar Deneyiniz.");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand bursara = new SqlCommand("exec bursara @id", con);
                con.Open();
                bursara.Parameters.AddWithValue("@id", selectid);
                SqlDataAdapter adapter = new SqlDataAdapter(bursara);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                con.Close();
            }
        }
    }
}
