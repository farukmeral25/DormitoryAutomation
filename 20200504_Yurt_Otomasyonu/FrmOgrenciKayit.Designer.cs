namespace _20200504_Yurt_Otomasyonu
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.lblVeliAdSoyad = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.msktxtTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.msktxtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.cbxOdaNo = new System.Windows.Forms.ComboBox();
            this.msktxtVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.rchtxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblOgrId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVeliAdSoyad
            // 
            this.lblVeliAdSoyad.AutoSize = true;
            this.lblVeliAdSoyad.Location = new System.Drawing.Point(15, 315);
            this.lblVeliAdSoyad.Name = "lblVeliAdSoyad";
            this.lblVeliAdSoyad.Size = new System.Drawing.Size(76, 13);
            this.lblVeliAdSoyad.TabIndex = 16;
            this.lblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.BackColor = System.Drawing.Color.White;
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(98, 312);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtVeliAdSoyad.TabIndex = 17;
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Location = new System.Drawing.Point(28, 15);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(63, 13);
            this.lblOgrAd.TabIndex = 0;
            this.lblOgrAd.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.White;
            this.txtOgrAd.Location = new System.Drawing.Point(98, 12);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(156, 20);
            this.txtOgrAd.TabIndex = 1;
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Location = new System.Drawing.Point(12, 50);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(80, 13);
            this.lblOgrSoyad.TabIndex = 2;
            this.lblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.BackColor = System.Drawing.Color.White;
            this.txtOgrSoyad.Location = new System.Drawing.Point(98, 47);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(65, 86);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(24, 13);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "TC:";
            // 
            // msktxtTC
            // 
            this.msktxtTC.BackColor = System.Drawing.Color.White;
            this.msktxtTC.Location = new System.Drawing.Point(98, 86);
            this.msktxtTC.Mask = "00000000000";
            this.msktxtTC.Name = "msktxtTC";
            this.msktxtTC.Size = new System.Drawing.Size(156, 20);
            this.msktxtTC.TabIndex = 5;
            this.msktxtTC.ValidatingType = typeof(int);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(3, 134);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(86, 13);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Öğrenci Telefon:";
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.BackColor = System.Drawing.Color.White;
            this.msktxtTelefon.Location = new System.Drawing.Point(98, 127);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(156, 20);
            this.msktxtTelefon.TabIndex = 7;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(16, 167);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblDogumTarihi.TabIndex = 8;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // msktxtDogumTarihi
            // 
            this.msktxtDogumTarihi.BackColor = System.Drawing.Color.White;
            this.msktxtDogumTarihi.Location = new System.Drawing.Point(98, 164);
            this.msktxtDogumTarihi.Mask = "00/00/0000";
            this.msktxtDogumTarihi.Name = "msktxtDogumTarihi";
            this.msktxtDogumTarihi.Size = new System.Drawing.Size(156, 20);
            this.msktxtDogumTarihi.TabIndex = 9;
            this.msktxtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(50, 204);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(39, 13);
            this.lblBolum.TabIndex = 10;
            this.lblBolum.Text = "Bölüm:";
            // 
            // cbxBolum
            // 
            this.cbxBolum.BackColor = System.Drawing.Color.White;
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Location = new System.Drawing.Point(98, 201);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(156, 21);
            this.cbxBolum.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(60, 239);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(98, 236);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(156, 20);
            this.txtMail.TabIndex = 13;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(44, 276);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(47, 13);
            this.lblOdaNo.TabIndex = 14;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // cbxOdaNo
            // 
            this.cbxOdaNo.BackColor = System.Drawing.Color.White;
            this.cbxOdaNo.FormattingEnabled = true;
            this.cbxOdaNo.Location = new System.Drawing.Point(98, 273);
            this.cbxOdaNo.Name = "cbxOdaNo";
            this.cbxOdaNo.Size = new System.Drawing.Size(156, 21);
            this.cbxOdaNo.TabIndex = 15;
            // 
            // msktxtVeliTelefon
            // 
            this.msktxtVeliTelefon.BackColor = System.Drawing.Color.White;
            this.msktxtVeliTelefon.Location = new System.Drawing.Point(98, 347);
            this.msktxtVeliTelefon.Mask = "(999) 000-0000";
            this.msktxtVeliTelefon.Name = "msktxtVeliTelefon";
            this.msktxtVeliTelefon.Size = new System.Drawing.Size(156, 20);
            this.msktxtVeliTelefon.TabIndex = 19;
            // 
            // lblVeliTelefon
            // 
            this.lblVeliTelefon.AutoSize = true;
            this.lblVeliTelefon.Location = new System.Drawing.Point(25, 354);
            this.lblVeliTelefon.Name = "lblVeliTelefon";
            this.lblVeliTelefon.Size = new System.Drawing.Size(66, 13);
            this.lblVeliTelefon.TabIndex = 18;
            this.lblVeliTelefon.Text = "Veli Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(52, 384);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adres:";
            // 
            // rchtxtAdres
            // 
            this.rchtxtAdres.BackColor = System.Drawing.Color.White;
            this.rchtxtAdres.Location = new System.Drawing.Point(95, 384);
            this.rchtxtAdres.Name = "rchtxtAdres";
            this.rchtxtAdres.Size = new System.Drawing.Size(159, 65);
            this.rchtxtAdres.TabIndex = 21;
            this.rchtxtAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(95, 455);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(159, 37);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblOgrId
            // 
            this.lblOgrId.AutoSize = true;
            this.lblOgrId.Location = new System.Drawing.Point(25, 426);
            this.lblOgrId.Name = "lblOgrId";
            this.lblOgrId.Size = new System.Drawing.Size(56, 13);
            this.lblOgrId.TabIndex = 23;
            this.lblOgrId.Text = "Ogrenci Id";
            this.lblOgrId.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(273, 504);
            this.Controls.Add(this.lblOgrId);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchtxtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.msktxtVeliTelefon);
            this.Controls.Add(this.lblVeliTelefon);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.lblVeliAdSoyad);
            this.Controls.Add(this.cbxOdaNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cbxBolum);
            this.Controls.Add(this.lblBolum);
            this.Controls.Add(this.msktxtDogumTarihi);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.msktxtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.msktxtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.lblOgrAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVeliAdSoyad;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.MaskedTextBox msktxtTC;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.MaskedTextBox msktxtDogumTarihi;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.ComboBox cbxOdaNo;
        private System.Windows.Forms.MaskedTextBox msktxtVeliTelefon;
        private System.Windows.Forms.Label lblVeliTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.RichTextBox rchtxtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblOgrId;
    }
}

