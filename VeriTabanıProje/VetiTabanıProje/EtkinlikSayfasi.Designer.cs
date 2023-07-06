
namespace VetiTabanıProje
{
    partial class EtkinlikSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.etkinlikad = new System.Windows.Forms.TextBox();
            this.dateTimeetkinlik = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Listele = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.Button();
            this.buttonOlustur = new System.Windows.Forms.Button();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniVTDataSet = new VetiTabanıProje.VeriTabaniVTDataSet();
            this.illerTableAdapter = new VetiTabanıProje.VeriTabaniVTDataSetTableAdapters.illerTableAdapter();
            this.ilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniVTDataSet1 = new VetiTabanıProje.VeriTabaniVTDataSet1();
            this.ilcelerTableAdapter = new VetiTabanıProje.VeriTabaniVTDataSet1TableAdapters.ilcelerTableAdapter();
            this.illerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniVTDataSet11 = new VetiTabanıProje.VeriTabaniVTDataSet1();
            this.ilcelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniVTDataSet2 = new VetiTabanıProje.VeriTabaniVTDataSet2();
            this.sehiradinagöreilcelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehiradinagöreilcelistTableAdapter = new VetiTabanıProje.VeriTabaniVTDataSet2TableAdapters.sehiradinagöreilcelistTableAdapter();
            this.textBoxil = new System.Windows.Forms.TextBox();
            this.textBoxilce = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehiradinagöreilcelistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(793, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etkinlikad
            // 
            this.etkinlikad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.etkinlikad.Location = new System.Drawing.Point(122, 24);
            this.etkinlikad.Multiline = true;
            this.etkinlikad.Name = "etkinlikad";
            this.etkinlikad.Size = new System.Drawing.Size(156, 32);
            this.etkinlikad.TabIndex = 1;
            // 
            // dateTimeetkinlik
            // 
            this.dateTimeetkinlik.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeetkinlik.Location = new System.Drawing.Point(122, 207);
            this.dateTimeetkinlik.Name = "dateTimeetkinlik";
            this.dateTimeetkinlik.Size = new System.Drawing.Size(156, 22);
            this.dateTimeetkinlik.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Etkinlik Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Etkinlik İli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Etkinlik İlçesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Etkinlik Tarihi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 299);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Listele
            // 
            this.Listele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Listele.ForeColor = System.Drawing.Color.Black;
            this.Listele.Location = new System.Drawing.Point(292, 325);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(183, 30);
            this.Listele.TabIndex = 11;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = false;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sil.ForeColor = System.Drawing.Color.Black;
            this.sil.Location = new System.Drawing.Point(737, 325);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(183, 30);
            this.sil.TabIndex = 12;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // sec
            // 
            this.sec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sec.ForeColor = System.Drawing.Color.Black;
            this.sec.Location = new System.Drawing.Point(520, 325);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(183, 30);
            this.sec.TabIndex = 13;
            this.sec.Text = "Seç";
            this.sec.UseVisualStyleBackColor = false;
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuncelle.ForeColor = System.Drawing.Color.Black;
            this.buttonGuncelle.Location = new System.Drawing.Point(58, 325);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(183, 30);
            this.buttonGuncelle.TabIndex = 14;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ara.ForeColor = System.Drawing.Color.Black;
            this.ara.Location = new System.Drawing.Point(253, 394);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(106, 30);
            this.ara.TabIndex = 15;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // buttonOlustur
            // 
            this.buttonOlustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOlustur.ForeColor = System.Drawing.Color.Black;
            this.buttonOlustur.Location = new System.Drawing.Point(58, 266);
            this.buttonOlustur.Name = "buttonOlustur";
            this.buttonOlustur.Size = new System.Drawing.Size(183, 30);
            this.buttonOlustur.TabIndex = 17;
            this.buttonOlustur.Text = "Oluştur";
            this.buttonOlustur.UseVisualStyleBackColor = false;
            this.buttonOlustur.Click += new System.EventHandler(this.buttonOlustur_Click);
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            this.illerBindingSource.DataSource = this.veriTabaniVTDataSet;
            // 
            // veriTabaniVTDataSet
            // 
            this.veriTabaniVTDataSet.DataSetName = "VeriTabaniVTDataSet";
            this.veriTabaniVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // ilcelerBindingSource
            // 
            this.ilcelerBindingSource.DataMember = "ilceler";
            this.ilcelerBindingSource.DataSource = this.veriTabaniVTDataSet1;
            // 
            // veriTabaniVTDataSet1
            // 
            this.veriTabaniVTDataSet1.DataSetName = "VeriTabaniVTDataSet1";
            this.veriTabaniVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // illerBindingSource1
            // 
            this.illerBindingSource1.DataMember = "iller";
            this.illerBindingSource1.DataSource = this.veriTabaniVTDataSet;
            // 
            // veriTabaniVTDataSet11
            // 
            this.veriTabaniVTDataSet11.DataSetName = "VeriTabaniVTDataSet1";
            this.veriTabaniVTDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilcelerBindingSource1
            // 
            this.ilcelerBindingSource1.DataMember = "ilceler";
            this.ilcelerBindingSource1.DataSource = this.veriTabaniVTDataSet11;
            // 
            // veriTabaniVTDataSet2
            // 
            this.veriTabaniVTDataSet2.DataSetName = "VeriTabaniVTDataSet2";
            this.veriTabaniVTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehiradinagöreilcelistBindingSource
            // 
            this.sehiradinagöreilcelistBindingSource.DataMember = "sehiradinagöreilcelist";
            this.sehiradinagöreilcelistBindingSource.DataSource = this.veriTabaniVTDataSet2;
            // 
            // sehiradinagöreilcelistTableAdapter
            // 
            this.sehiradinagöreilcelistTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxil
            // 
            this.textBoxil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxil.Location = new System.Drawing.Point(122, 80);
            this.textBoxil.Multiline = true;
            this.textBoxil.Name = "textBoxil";
            this.textBoxil.Size = new System.Drawing.Size(156, 32);
            this.textBoxil.TabIndex = 18;
            // 
            // textBoxilce
            // 
            this.textBoxilce.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxilce.Location = new System.Drawing.Point(122, 142);
            this.textBoxilce.Multiline = true;
            this.textBoxilce.Name = "textBoxilce";
            this.textBoxilce.Size = new System.Drawing.Size(156, 32);
            this.textBoxilce.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(58, 395);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 32);
            this.textBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID";
            // 
            // EtkinlikSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxilce);
            this.Controls.Add(this.textBoxil);
            this.Controls.Add(this.buttonOlustur);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeetkinlik);
            this.Controls.Add(this.etkinlikad);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "EtkinlikSayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniVTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehiradinagöreilcelistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox etkinlikad;
        private System.Windows.Forms.DateTimePicker dateTimeetkinlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button buttonOlustur;
        private VeriTabaniVTDataSet veriTabaniVTDataSet;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private VeriTabaniVTDataSetTableAdapters.illerTableAdapter illerTableAdapter;
        private VeriTabaniVTDataSet1 veriTabaniVTDataSet1;
        private System.Windows.Forms.BindingSource ilcelerBindingSource;
        private VeriTabaniVTDataSet1TableAdapters.ilcelerTableAdapter ilcelerTableAdapter;
        private System.Windows.Forms.BindingSource illerBindingSource1;
        private VeriTabaniVTDataSet1 veriTabaniVTDataSet11;
        private System.Windows.Forms.BindingSource ilcelerBindingSource1;
        private VeriTabaniVTDataSet2 veriTabaniVTDataSet2;
        private System.Windows.Forms.BindingSource sehiradinagöreilcelistBindingSource;
        private VeriTabaniVTDataSet2TableAdapters.sehiradinagöreilcelistTableAdapter sehiradinagöreilcelistTableAdapter;
        private System.Windows.Forms.TextBox textBoxil;
        private System.Windows.Forms.TextBox textBoxilce;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}