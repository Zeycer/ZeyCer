
namespace FinalTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEkle = new System.Windows.Forms.TextBox();
            this.txbSil = new System.Windows.Forms.TextBox();
            this.txbDugumDuzey = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnShowNodes = new System.Windows.Forms.Button();
            this.rchTxtNodes = new System.Windows.Forms.RichTextBox();
            this.btnShowInfoTree = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbYaprak = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTotalNode = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rchPostOrder = new System.Windows.Forms.RichTextBox();
            this.rchInOrder = new System.Windows.Forms.RichTextBox();
            this.rchTxtPreOrder = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Düğüm Ekleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Düğüm Silme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(31, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aranacak Düğüm";
            // 
            // txbEkle
            // 
            this.txbEkle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEkle.Location = new System.Drawing.Point(184, 39);
            this.txbEkle.Multiline = true;
            this.txbEkle.Name = "txbEkle";
            this.txbEkle.Size = new System.Drawing.Size(100, 46);
            this.txbEkle.TabIndex = 3;
            this.txbEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSil
            // 
            this.txbSil.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSil.Location = new System.Drawing.Point(184, 107);
            this.txbSil.Multiline = true;
            this.txbSil.Name = "txbSil";
            this.txbSil.Size = new System.Drawing.Size(100, 46);
            this.txbSil.TabIndex = 4;
            this.txbSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDugumDuzey
            // 
            this.txbDugumDuzey.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDugumDuzey.Location = new System.Drawing.Point(184, 177);
            this.txbDugumDuzey.Multiline = true;
            this.txbDugumDuzey.Name = "txbDugumDuzey";
            this.txbDugumDuzey.Size = new System.Drawing.Size(100, 46);
            this.txbDugumDuzey.TabIndex = 5;
            this.txbDugumDuzey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.White;
            this.btnBul.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBul.Location = new System.Drawing.Point(310, 186);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(96, 37);
            this.btnBul.TabIndex = 8;
            this.btnBul.Text = "Düğüm Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(310, 115);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 37);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Düğüm Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(310, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 37);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Düğüm Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnShowNodes
            // 
            this.btnShowNodes.BackColor = System.Drawing.Color.White;
            this.btnShowNodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowNodes.Location = new System.Drawing.Point(31, 274);
            this.btnShowNodes.Name = "btnShowNodes";
            this.btnShowNodes.Size = new System.Drawing.Size(375, 45);
            this.btnShowNodes.TabIndex = 11;
            this.btnShowNodes.Text = "Ağaçtaki Düğümleri Göster";
            this.btnShowNodes.UseVisualStyleBackColor = false;
            this.btnShowNodes.Click += new System.EventHandler(this.btnShowNodes_Click);
            // 
            // rchTxtNodes
            // 
            this.rchTxtNodes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchTxtNodes.Location = new System.Drawing.Point(31, 335);
            this.rchTxtNodes.Name = "rchTxtNodes";
            this.rchTxtNodes.Size = new System.Drawing.Size(375, 335);
            this.rchTxtNodes.TabIndex = 12;
            this.rchTxtNodes.Text = "";
            // 
            // btnShowInfoTree
            // 
            this.btnShowInfoTree.BackColor = System.Drawing.Color.White;
            this.btnShowInfoTree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowInfoTree.Location = new System.Drawing.Point(546, 40);
            this.btnShowInfoTree.Name = "btnShowInfoTree";
            this.btnShowInfoTree.Size = new System.Drawing.Size(448, 45);
            this.btnShowInfoTree.TabIndex = 13;
            this.btnShowInfoTree.Text = " Ağaç Bilgilerini Göster";
            this.btnShowInfoTree.UseVisualStyleBackColor = false;
            this.btnShowInfoTree.Click += new System.EventHandler(this.btnShowInfoTree_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbYaprak);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbTotalNode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rchPostOrder);
            this.groupBox1.Controls.Add(this.rchInOrder);
            this.groupBox1.Controls.Add(this.rchTxtPreOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(546, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 506);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç Bilgileri";
            // 
            // txbYaprak
            // 
            this.txbYaprak.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbYaprak.Location = new System.Drawing.Point(118, 416);
            this.txbYaprak.Name = "txbYaprak";
            this.txbYaprak.Size = new System.Drawing.Size(302, 41);
            this.txbYaprak.TabIndex = 26;
            this.txbYaprak.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(21, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Yapraklar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(281, 344);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(139, 41);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(64, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ağacın Yüksekliği";
            // 
            // txbTotalNode
            // 
            this.txbTotalNode.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTotalNode.Location = new System.Drawing.Point(281, 278);
            this.txbTotalNode.Name = "txbTotalNode";
            this.txbTotalNode.Size = new System.Drawing.Size(139, 41);
            this.txbTotalNode.TabIndex = 22;
            this.txbTotalNode.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(17, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ağaçtaki Toplam Düğüm Sayısı";
            // 
            // rchPostOrder
            // 
            this.rchPostOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchPostOrder.Location = new System.Drawing.Point(118, 171);
            this.rchPostOrder.Name = "rchPostOrder";
            this.rchPostOrder.Size = new System.Drawing.Size(302, 41);
            this.rchPostOrder.TabIndex = 20;
            this.rchPostOrder.Text = "";
            // 
            // rchInOrder
            // 
            this.rchInOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchInOrder.Location = new System.Drawing.Point(118, 98);
            this.rchInOrder.Name = "rchInOrder";
            this.rchInOrder.Size = new System.Drawing.Size(302, 41);
            this.rchInOrder.TabIndex = 19;
            this.rchInOrder.Text = "";
            // 
            // rchTxtPreOrder
            // 
            this.rchTxtPreOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchTxtPreOrder.Location = new System.Drawing.Point(118, 22);
            this.rchTxtPreOrder.Name = "rchTxtPreOrder";
            this.rchTxtPreOrder.Size = new System.Drawing.Size(302, 41);
            this.rchTxtPreOrder.TabIndex = 18;
            this.rchTxtPreOrder.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "PostOrder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "InOrder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "PreOrder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1060, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowInfoTree);
            this.Controls.Add(this.rchTxtNodes);
            this.Controls.Add(this.btnShowNodes);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txbDugumDuzey);
            this.Controls.Add(this.txbSil);
            this.Controls.Add(this.txbEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEkle;
        private System.Windows.Forms.TextBox txbSil;
        private System.Windows.Forms.TextBox txbDugumDuzey;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnShowNodes;
        private System.Windows.Forms.RichTextBox rchTxtNodes;
        private System.Windows.Forms.Button btnShowInfoTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rchPostOrder;
        private System.Windows.Forms.RichTextBox rchInOrder;
        private System.Windows.Forms.RichTextBox rchTxtPreOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txbYaprak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txbTotalNode;
        private System.Windows.Forms.Label label7;
    }
}

