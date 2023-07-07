using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İkiliağaç_yapısı_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class yaprakveri
        {
            public int sayı;
            public yaprakveri ileri;
            public int geciciduzey;
        }
        yaprakveri yaprakilk = null, yaprakson = null;
        public class ikiliagac
        {
            public ikiliagac sol;
            public ikiliagac sag;
            public ikiliagac back;
            public int veri;
            public int düzey;
        }
        ikiliagac kok = null;
        int dugumsayısı = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen eklemek istediğiniz değeri giriniz.");
            }
            else
            {
                int dadet = 1;//kökün düzeyi birden başlar.
                int sayı = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                ikiliagac yeni = new ikiliagac();
                yeni.veri = sayı;
                yeni.sol = null;
                yeni.sag = null;
                ikiliagac dönen = kok;
                ikiliagac aile = null;
                while (dönen != null)
                {
                    aile = dönen;
                    if (sayı == dönen.veri)
                    {
                        return;
                    }
                    else if (sayı < dönen.veri)
                    {
                        dönen = dönen.sol;
                    }
                    else
                    {
                        dönen = dönen.sag;
                    }
                    dadet++;
                }
                yeni.düzey = dadet;
                if (kok == null)
                {
                    kok = yeni;
                }
                else if (sayı < aile.veri)
                {
                    aile.sol = yeni;
                    aile.sol.back = aile;
                }
                else
                {
                    aile.sag = yeni;
                    aile.sag.back = aile;
                }
                dugumsayısı++;
                label11.Text = dugumsayısı.ToString();
            }
        }
        private void Bulma_Click(object sender, EventArgs e)
        {
            if (textBox3.Text=="")
            {
                MessageBox.Show("Lütfen aranacak değeri giriniz.");
            }
            else
            {
                int sayı = int.Parse(textBox3.Text);
                textBox3.Clear();
                textBox3.Focus();
                textBox13.Clear();
                ikiliagac ara = kok;
                ikiliagac a = Bul(ara, sayı);
                if (a == null)
                {
                    MessageBox.Show("Lütfen olmayan değeri aramaya çalışmayınız.");
                }
                else
                {
                    textBox2.Text = a.veri.ToString();
                    label16.Text = a.düzey.ToString();
                }
            }
        }
        public ikiliagac Bul(ikiliagac ara, int sayı)
        {
            //buraya elemanların yolunu yazdıracagın textbox += ile kok ü yazdır .
            if (ara == null)
            {
                return null;
            }
            if (sayı == ara.veri)
            {
                textBox13.Text += ara.veri.ToString() + ",";
                return ara;
            }
            else if (sayı < ara.veri)
            {
                textBox13.Text += ara.veri.ToString() + ",";
                return Bul(ara.sol, sayı);
            }
            else
            {
                textBox13.Text += ara.veri.ToString() + ",";
                return Bul(ara.sag, sayı);
            }
        }
        private void Silme_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen olmayan değeri silmeye çalışmayınız.");
            }
            else
            {
                int aranan = int.Parse(textBox2.Text);
                textBox2.Focus();
                Sil(aranan);
                label13.Text = textBox2.Text;
            }
        }
        public void Sil(int aranan)
        {
            ikiliagac dönen = new ikiliagac();
            dönen = kok;
            ikiliagac dönen2;
            if (dönen == null)
            {
                MessageBox.Show("Ağaç bos. Silinecek veri yok.");
            }
            if (dönen.veri == aranan && (dönen.sag == null && dönen.sol == null))
            {
                dönen = null;
            }
            else
            {
                while (dönen != null)
                {
                    if (dönen.veri < aranan)
                    {
                        dönen = dönen.sag;
                        if ((dönen.sag == null && dönen.sol == null) && dönen.veri == aranan)
                        {
                            dönen.back.sag = null;
                            break;
                        }
                        else if ((dönen.sag != null && dönen.sol == null) && dönen.veri == aranan)
                        {
                            dönen.back.sag = dönen.sag;
                            dönen.sag.back = dönen.back;
                            break;
                        }
                        else if ((dönen.sag != null && dönen.sol != null) && dönen.veri == aranan)
                        {
                            dönen2 = dönen.sol;
                            while (dönen2.sag != null)
                            {
                                dönen2 = dönen2.sag;
                            }
                            dönen.veri = dönen2.veri;
                            if (dönen2.sol == null)
                            {
                                dönen2.back.sol = null;
                            }
                            else
                            {
                                dönen2.back.sol = null;
                            }
                            break;
                        }
                    }
                    else if (dönen.veri > aranan)
                    {
                        dönen = dönen.sol;
                        if (dönen.sag == null && dönen.sol == null && dönen.veri == aranan)
                        {
                            dönen.back.sol = null;
                            break;
                        }
                        else if (dönen.sol != null & dönen.sag == null && dönen.veri == aranan)
                        {
                            dönen.back.sol = dönen.sol;
                            dönen.sol.back = dönen.back;
                            break;
                        }
                        else if (dönen.sag != null && dönen.sol != null && dönen.veri == aranan)
                        {
                            dönen2 = dönen.sol;
                            while (dönen2.sag != null)
                            {
                                dönen2 = dönen2.sag;
                            }
                            dönen.veri = dönen2.veri;
                            if (dönen.sol == null)
                            {
                                dönen2.back.sol = null;
                            }
                            else
                            {
                                dönen2.back.sol = null;
                            }
                            break;
                        }
                    }
                }
            }
            dugumsayısı--;
        }
        public ikiliagac Max()
        {
            if (kok == null)
            {
                return null;
            }
            ikiliagac dönen = kok;
            while (dönen.sag != null)
            {
                dönen = dönen.sag;
            }
            return dönen;
        }
        public ikiliagac Min()
        {
            if (kok == null)
            {
                return null;
            }
            ikiliagac dönen = kok;
            while (dönen.sol != null)
            {
                dönen = dönen.sol;
            }
            return dönen;
        }
        public void Preorder2(ikiliagac dön)
        {
            if (dön == null)
            {
                return;
            }
            else
            {
                textBox6.Text += dön.veri + ",";
                Preorder2(dön.sol);
                Preorder2(dön.sag);
            }
        }
        public void Postorder2(ikiliagac dön2)
        {
            if (dön2 == null)
            {
                return;
            }
            else
            {
                Postorder2(dön2.sol);
                Postorder2(dön2.sag);
                textBox7.Text += dön2.veri + ",";
            }
        }
        public void İnorder2(ikiliagac dön3)
        {
            if (dön3 == null)
            {
                return;
            }
            if (dön3.sol == null && dön3.sag == null)
            {
                yaprakveri yap = new yaprakveri();
                yap.sayı = dön3.veri;
                yap.geciciduzey = dön3.düzey;
                if (yaprakilk == null)
                {
                    yaprakilk = yap;
                    yaprakson = yap;
                }
                else
                {
                    yaprakson.ileri = yap;
                    yaprakson = yap;
                    yaprakson.ileri = null;
                }
                textBox9.Text += dön3.veri.ToString() + ",";
            }
            else
            {
                İnorder2(dön3.sol);
                İnorder2(dön3.sag);
            }
        }
        public void İnorder3(ikiliagac dön4)
        {
            if (dön4 == null)
            {
                return;
            }
            else
            {
                İnorder3(dön4.sol);
                textBox8.Text += dön4.veri + ",";
                İnorder3(dön4.sag);
            }
        }
        public void İnorder4(ikiliagac dön5)
        {
            if (dön5 == null)
            {
                return;
            }
            else
            {
                İnorder4(dön5.sol);
                textBox10.Text += dön5.veri + "" + Environment.NewLine;
                İnorder4(dön5.sag);
            }
        }
        public void yukselik()
        {
            yaprakveri dene;
            dene = yaprakilk;
            while (yaprakilk != null)
            {
                if (dene.ileri == null)
                {
                    yaprakilk = dene;
                    break;
                }
                if (yaprakilk.sayı > dene.ileri.sayı)
                {
                    dene = dene.ileri;
                }
                else
                {
                    yaprakilk = dene;
                    dene = dene.ileri;
                }
            }
        }
        private void Agac_Click(object sender, EventArgs e)
        {
            //Max yazdırma
            textBox4.Clear();
            if (kok == null)
            {
                textBox4.Text = "Max değer bulunamaz.";
            }
            else
            {
                textBox4.Text = Max().veri.ToString();
            }
            //Min yazdırma
            textBox5.Clear();
            if (kok == null)
            {
                textBox5.Text = "Min değer bulunamaz.";
            }
            else
            {
                textBox5.Text = Min().veri.ToString();
            }
            //Preorder yazdırma
            textBox6.Clear();
            Preorder2(kok);
            //Postorder yazdırma
            textBox7.Clear();
            Postorder2(kok);
            //İnorder yazdırma
            textBox8.Clear();
            İnorder3(kok);
            //Yaprakları yazdırma
            textBox9.Clear();
            İnorder2(kok);
            //Dügüm sayısı yazdırma
            textBox11.Text = dugumsayısı.ToString();
            //Ağacın yüksekliği
            if (yaprakilk==null)
            {
                MessageBox.Show("Lütfen boş bir ağacın bilgilerini yazdırmak istemeyiniz.");
            }
            else
            {
                yukselik();
                textBox12.Text = yaprakilk.geciciduzey.ToString();
            }
        }
        private void agacekle_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            ikiliagac gelen = kok;
            TreeNode bas = new TreeNode();
            agac(gelen, bas);
            treeView1.ExpandAll();
        }
        public void agac(ikiliagac gelen, TreeNode bas)
        {
            if (gelen == null)
            {
                return;
            }
            else
            {
                if (kok == gelen)
                {
                    bas = new TreeNode(kok.veri.ToString());
                    treeView1.Nodes.Add(bas);
                }
                else
                {
                    TreeNode node = new TreeNode(gelen.veri.ToString());
                    bas.Nodes.Add(node);
                    bas = node;
                }
            }
            agac(gelen.sol, bas);
            agac(gelen.sag, bas);
        }
        private void DugumleriGoster_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            İnorder4(kok);
        }
    }
}
