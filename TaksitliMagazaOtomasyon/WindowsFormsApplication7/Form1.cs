using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
//using System.Data.OleDb;  Access veritabanı için



namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {

        //global Değişkenler
        SqlConnection baglanti = new SqlConnection("Data Source=MAINBILMUHLAB;Initial Catalog=magaza;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        int musterino;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            komut.CommandText = "select * from musteriler";
            DataTable dt = new DataTable();
            komut.Connection = baglanti;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dt.Dispose();
            dr.Dispose();
            komut.Dispose();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut.CommandText = "taksitekle";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@odemetarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@odemetutar", textBox2.Text);
            komut.Parameters.AddWithValue("@musterino", musterino);
            //komut.Parameters["@musterino"].Direction = ParameterDirection.Output;
            komut.Connection = baglanti;
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            baglanti.Close();

            taksitlerigoster();

        }

        public void taksitlerigoster()
        {
            komut.CommandText = "taksitlerigetir";
            komut.Parameters.Add("@musno", SqlDbType.Int);
            komut.Parameters["@musno"].Value = musterino;
            komut.CommandType = CommandType.StoredProcedure;

            komut.Connection = baglanti;
            DataTable dt = new DataTable();
            baglanti.Open();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            baglanti.Close();
            //baglanti.Dispose();
            komut.CommandType = CommandType.Text;
            komut.Parameters.Clear();
            komut.Dispose();
            dt.Dispose();
        
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            musterino = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label4.Text = Convert.ToString(musterino);





            komut.CommandText = "toplamborc";
            komut.Parameters.Add("@musno", SqlDbType.Int);
            komut.Parameters["@musno"].Value = musterino;
            komut.Parameters.Add("@borc", SqlDbType.Money);
            komut.Parameters["@borc"].Direction = ParameterDirection.Output;
            komut.CommandType = CommandType.StoredProcedure;

            komut.Connection = baglanti;
            DataTable dt = new DataTable();
            baglanti.Open();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;

            label5.Text = "Toplam Borç = " + komut.Parameters["@borc"].Value.ToString();
            baglanti.Close();
            komut.CommandType = CommandType.Text;
            komut.Parameters.Clear();
            komut.Dispose();
            dt.Dispose();

            taksitlerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            komut.CommandText = "borclularlistesi";
            komut.Parameters.Add("@odemetarih", SqlDbType.Date);
            komut.Parameters["@odemetarih"].Value = DateTime.Now.Date;
            komut.CommandType = CommandType.StoredProcedure;

            komut.Connection = baglanti;
            DataTable dt = new DataTable();
            baglanti.Open();
            dt.Load(komut.ExecuteReader());
            dataGridView2.DataSource = dt;
            baglanti.Close();
            //baglanti.Dispose();
            komut.CommandType = CommandType.Text;
            komut.Parameters.Clear();
            komut.Dispose();
            dt.Dispose();
        }




    }
}
