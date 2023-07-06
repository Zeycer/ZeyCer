using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetiTabanıProje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        EtkinlikSayfasi esyf = new EtkinlikSayfasi();
        OgrenciIslemleriSayfasi oisyf = new OgrenciIslemleriSayfasi();
        BursIslemleriSayfasi bisyf = new BursIslemleriSayfasi();

        private void button5_Click(object sender, EventArgs e)
        {
           
            esyf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            oisyf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bisyf.Show();
            this.Hide();
        }

    }
}
