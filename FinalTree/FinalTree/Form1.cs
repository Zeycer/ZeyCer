using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Node
        {
            public int data;

            public Node right;
            public Node left;

            // Burası yaprakları ben stackte tutmak istediğim için sadece stackte kullanmak için
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        int toplamNodeSayisi = 0;
        int toplamYaprakSayisi = 0;
        int yukseklik = 0;
        Node kok = null;

        Node yaprakStackIlk = null;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Node yeni = new Node(Convert.ToInt32(txbEkle.Text));
            txbEkle.Text = "";

            if (kok == null)
            {
                yeni.right = null;
                yeni.left = null;
                kok = yeni;

             
            }
            else
            {
                Node yedekKok = kok;
                Node gecici = kok;

                while (true)
                {
                    yedekKok = gecici;
                    if (yeni.data >= yedekKok.data)
                    {
                        gecici = gecici.right;
                        if (gecici == null)
                        {
                            yedekKok.right = yeni;
                            yedekKok = yedekKok.right;
                            yedekKok.right = null;
                            yedekKok.left = null;
                           
                            return;
                        }
                    }
                    else
                    {
                        gecici = gecici.left;
                        if (gecici == null)
                        {
                            yedekKok.left = yeni;
                            yedekKok = yedekKok.left;
                            yedekKok.right = null;
                            yedekKok.left = null;
                           
                            return;
                        }

                    }
                }
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(txbSil.Text);
            sil(ref kok, deger);
        }





        private void btnShowInfoTree_Click(object sender, EventArgs e)
        {
            rchTxtPreOrder.Text = null;
            rchInOrder.Text = null;
            rchPostOrder.Text = null;

            toplamNodeSayisi = 0;

            // Her butona bastığımızda stack sıfırlansın ki değerleri baştan stacke eklesin bunu yapmaz isek
            //birdeğer eklemeden önce yaprak olan ama değer eklendikten sonra yaprak olmaktan çıkan değerleride yazdırır.
            yaprakStackIlk = null;

            PreOrder(kok, rchTxtPreOrder);
            PostOrder(kok, rchPostOrder);
            InOrder(kok, rchInOrder);

            txbTotalNode.Text = toplamNodeSayisi.ToString();
            // Yaprakları yazdırma

            txbYaprak.Text = null;
            Node gecici = yaprakStackIlk;
            while (gecici != null)
            {
                txbYaprak.Text += gecici.data + " ";
                gecici = gecici.next;
            }

        }


        private void PreOrder(Node kok, RichTextBox rchText)
        {
            if (kok == null)
            {
                return;
            }
            toplamNodeSayisi++;
            rchText.Text += kok.data + " ";
            PreOrder(kok.left, rchText);
            PreOrder(kok.right, rchText);
        }

        private void PostOrder(Node kok, RichTextBox rchText)
        {
            if (kok == null)
            {
                return;
            }
            else
            {
                PostOrder(kok.left, rchText);
                PostOrder(kok.right, rchText);
                rchText.Text += kok.data + " ";



            }
        }

        private void InOrder(Node kok, RichTextBox rchText)
        {
            if (kok == null)
            {
                return;
            }
            else
            {
                if (kok.right == null && kok.left == null)
                {
                    Node yeniYaprak = new Node(kok.data);
                    yeniYaprak.next = null;

                    if (yaprakStackIlk == null)
                    {
                        yaprakStackIlk = yeniYaprak;
                    }
                    else
                    {
                        yeniYaprak.next = yaprakStackIlk;
                        yaprakStackIlk = yeniYaprak;
                    }

                }
                InOrder(kok.left, rchText);
                rchText.Text += kok.data + " ";
                InOrder(kok.right, rchText);
            }
        }

        private void btnShowNodes_Click(object sender, EventArgs e)
        {
            rchTxtNodes.Text = null;
            PreOrder(kok, rchTxtNodes);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(txbDugumDuzey.Text);

            find(kok, data);

        }

        private void find(Node kok, int arananDeger)
        {

            if (kok == null)
            {
                MessageBox.Show("Aradığınız değer ağaçta bulunmamaktadır.");
            }
            else if (arananDeger == kok.data)
            {
                rchTxtNodes.Text = null;
                rchTxtNodes.Text = "Aradığınız değer olan " + arananDeger + " ağaçta bulundu.";


            }
            else if (arananDeger < kok.data)
            {
                find(kok.left, arananDeger);
            }
            else
            {
                find(kok.right, arananDeger);
            }


        }

        private void sil(ref Node kok, int silinecekDeger)
        {

            txbSil.Text = null;

            if (kok == null)
            {
                MessageBox.Show("Ağaçta herhangi bir değer bulunmamaktadır.");
            }
            else
            {
                Node yedekKok = kok;
                Node gecici = kok;

                while (true)
                {
                    yedekKok = gecici;
                    if (yedekKok.data == silinecekDeger)
                    {
                        kok = null;
                        return;
                    }
                    else if (silinecekDeger >= yedekKok.data)
                    {
                        gecici = gecici.right;
                        if (gecici == null)
                        {
                            MessageBox.Show("Aranan Değer Ağaçta bulunmamaktadır");
                            return;
                        }
                        else if (gecici.data == silinecekDeger)
                        {

                            if (gecici.right == null && gecici.left == null)
                            {
                                yedekKok.right = null;
                            }
                            else if ((gecici.right != null && gecici.left == null))
                            {
                                yedekKok.right = gecici.right;
                            }
                            else if ((gecici.left != null && gecici.right == null))
                            {
                                yedekKok.left = gecici.left;
                            }
                            else if (gecici.right != null && gecici.left != null)
                            {
                                Node enKucukEleman = gecici.right;

                                while (true)
                                {
                                    if (enKucukEleman.left != null)
                                    {
                                        enKucukEleman = enKucukEleman.left;
                                    }
                                }

                                enKucukEleman.left = gecici.left;
                                enKucukEleman.right = gecici.right;
                            }

                            return;
                        }
                    }
                    else
                    {
                        gecici = gecici.left;
                        if (gecici == null)
                        {
                            MessageBox.Show("Aranan Değer Ağaçta bulunmamaktadır");
                            return;
                        }

                        else if (gecici.data == silinecekDeger)
                        {

                            if (gecici.right == null && gecici.left == null)
                            {
                                yedekKok.left = null;
                            }
                            else if (gecici.left != null && gecici.right == null)
                            {
                                yedekKok.left = gecici.left;
                            }
                            else if ((gecici.right != null && gecici.left == null))
                            {
                                yedekKok.left = gecici.right;
                            }
                            else if (gecici.right != null && gecici.left != null)
                            {
                                Node enKucukEleman = gecici.right;
                                while (true)
                                {


                                    if (enKucukEleman.left != null)
                                    {
                                        enKucukEleman = enKucukEleman.left;
                                        return;
                                    }
                                }

                                enKucukEleman.left = gecici.left;
                                enKucukEleman.right = gecici.right;
                            }

                            return;
                        }

                    }
                }
            }

        }
    }
}



