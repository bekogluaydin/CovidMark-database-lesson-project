namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_urunler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_urunler));
            this.gb_urun = new System.Windows.Forms.GroupBox();
            this.tb_ukod = new System.Windows.Forms.TextBox();
            this.lbl_ukod = new System.Windows.Forms.Label();
            this.tb_uozellik = new System.Windows.Forms.TextBox();
            this.lbl_uozellik = new System.Windows.Forms.Label();
            this.cb_urunBirim = new System.Windows.Forms.ComboBox();
            this.cb_altukat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ufiyat = new System.Windows.Forms.TextBox();
            this.cb_ukat = new System.Windows.Forms.ComboBox();
            this.tb_uad = new System.Windows.Forms.TextBox();
            this.tb_ubarkod = new System.Windows.Forms.TextBox();
            this.lbl_ukat = new System.Windows.Forms.Label();
            this.lbl_ufiyat = new System.Windows.Forms.Label();
            this.lbl_ubirim = new System.Windows.Forms.Label();
            this.lbl_uad = new System.Windows.Forms.Label();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.lv_liste = new System.Windows.Forms.ListView();
            this.urunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunBarkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategoriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunBirim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunOzellik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_urun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_urun
            // 
            this.gb_urun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_urun.BackColor = System.Drawing.Color.Transparent;
            this.gb_urun.Controls.Add(this.tb_ukod);
            this.gb_urun.Controls.Add(this.lbl_ukod);
            this.gb_urun.Controls.Add(this.tb_uozellik);
            this.gb_urun.Controls.Add(this.lbl_uozellik);
            this.gb_urun.Controls.Add(this.cb_urunBirim);
            this.gb_urun.Controls.Add(this.cb_altukat);
            this.gb_urun.Controls.Add(this.label2);
            this.gb_urun.Controls.Add(this.tb_ufiyat);
            this.gb_urun.Controls.Add(this.cb_ukat);
            this.gb_urun.Controls.Add(this.tb_uad);
            this.gb_urun.Controls.Add(this.tb_ubarkod);
            this.gb_urun.Controls.Add(this.lbl_ukat);
            this.gb_urun.Controls.Add(this.lbl_ufiyat);
            this.gb_urun.Controls.Add(this.lbl_ubirim);
            this.gb_urun.Controls.Add(this.lbl_uad);
            this.gb_urun.Controls.Add(this.lbl_barkod);
            this.gb_urun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_urun.ForeColor = System.Drawing.Color.White;
            this.gb_urun.Location = new System.Drawing.Point(22, 30);
            this.gb_urun.Margin = new System.Windows.Forms.Padding(2);
            this.gb_urun.Name = "gb_urun";
            this.gb_urun.Padding = new System.Windows.Forms.Padding(2);
            this.gb_urun.Size = new System.Drawing.Size(558, 276);
            this.gb_urun.TabIndex = 0;
            this.gb_urun.TabStop = false;
            this.gb_urun.Text = "Ürün İşlemleri";
            // 
            // tb_ukod
            // 
            this.tb_ukod.Location = new System.Drawing.Point(103, 74);
            this.tb_ukod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ukod.MaxLength = 10;
            this.tb_ukod.Name = "tb_ukod";
            this.tb_ukod.Size = new System.Drawing.Size(159, 23);
            this.tb_ukod.TabIndex = 23;
            // 
            // lbl_ukod
            // 
            this.lbl_ukod.AutoSize = true;
            this.lbl_ukod.Location = new System.Drawing.Point(5, 77);
            this.lbl_ukod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ukod.Name = "lbl_ukod";
            this.lbl_ukod.Size = new System.Drawing.Size(73, 17);
            this.lbl_ukod.TabIndex = 22;
            this.lbl_ukod.Text = "Ürün Kod:";
            // 
            // tb_uozellik
            // 
            this.tb_uozellik.Location = new System.Drawing.Point(378, 161);
            this.tb_uozellik.Multiline = true;
            this.tb_uozellik.Name = "tb_uozellik";
            this.tb_uozellik.Size = new System.Drawing.Size(162, 91);
            this.tb_uozellik.TabIndex = 21;
            // 
            // lbl_uozellik
            // 
            this.lbl_uozellik.AutoSize = true;
            this.lbl_uozellik.Location = new System.Drawing.Point(265, 161);
            this.lbl_uozellik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uozellik.Name = "lbl_uozellik";
            this.lbl_uozellik.Size = new System.Drawing.Size(94, 17);
            this.lbl_uozellik.TabIndex = 17;
            this.lbl_uozellik.Text = "Ürün Özellik:";
            // 
            // cb_urunBirim
            // 
            this.cb_urunBirim.FormattingEnabled = true;
            this.cb_urunBirim.Items.AddRange(new object[] {
            "Ürün Birim Seç...",
            "Kilo",
            "Adet",
            "Litre"});
            this.cb_urunBirim.Location = new System.Drawing.Point(378, 36);
            this.cb_urunBirim.Name = "cb_urunBirim";
            this.cb_urunBirim.Size = new System.Drawing.Size(162, 25);
            this.cb_urunBirim.TabIndex = 16;
            // 
            // cb_altukat
            // 
            this.cb_altukat.FormattingEnabled = true;
            this.cb_altukat.Items.AddRange(new object[] {
            "Alt Kategoriyi Seç..."});
            this.cb_altukat.Location = new System.Drawing.Point(380, 111);
            this.cb_altukat.Margin = new System.Windows.Forms.Padding(2);
            this.cb_altukat.Name = "cb_altukat";
            this.cb_altukat.Size = new System.Drawing.Size(160, 25);
            this.cb_altukat.TabIndex = 15;
            this.cb_altukat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alt Kategori:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_ufiyat
            // 
            this.tb_ufiyat.Location = new System.Drawing.Point(380, 74);
            this.tb_ufiyat.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ufiyat.Name = "tb_ufiyat";
            this.tb_ufiyat.Size = new System.Drawing.Size(160, 23);
            this.tb_ufiyat.TabIndex = 13;
            // 
            // cb_ukat
            // 
            this.cb_ukat.FormattingEnabled = true;
            this.cb_ukat.Items.AddRange(new object[] {
            "Kategoriyi Seç..."});
            this.cb_ukat.Location = new System.Drawing.Point(101, 153);
            this.cb_ukat.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ukat.Name = "cb_ukat";
            this.cb_ukat.Size = new System.Drawing.Size(160, 25);
            this.cb_ukat.TabIndex = 10;
            this.cb_ukat.SelectedIndexChanged += new System.EventHandler(this.cb_ukat_SelectedIndexChanged);
            // 
            // tb_uad
            // 
            this.tb_uad.Location = new System.Drawing.Point(101, 115);
            this.tb_uad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_uad.MaxLength = 25;
            this.tb_uad.Name = "tb_uad";
            this.tb_uad.Size = new System.Drawing.Size(160, 23);
            this.tb_uad.TabIndex = 9;
            // 
            // tb_ubarkod
            // 
            this.tb_ubarkod.Location = new System.Drawing.Point(103, 33);
            this.tb_ubarkod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ubarkod.MaxLength = 10;
            this.tb_ubarkod.Name = "tb_ubarkod";
            this.tb_ubarkod.Size = new System.Drawing.Size(159, 23);
            this.tb_ubarkod.TabIndex = 8;
            // 
            // lbl_ukat
            // 
            this.lbl_ukat.AutoSize = true;
            this.lbl_ukat.Location = new System.Drawing.Point(4, 157);
            this.lbl_ukat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ukat.Name = "lbl_ukat";
            this.lbl_ukat.Size = new System.Drawing.Size(66, 17);
            this.lbl_ukat.TabIndex = 6;
            this.lbl_ukat.Text = "Kategori:";
            // 
            // lbl_ufiyat
            // 
            this.lbl_ufiyat.AutoSize = true;
            this.lbl_ufiyat.Location = new System.Drawing.Point(275, 74);
            this.lbl_ufiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ufiyat.Name = "lbl_ufiyat";
            this.lbl_ufiyat.Size = new System.Drawing.Size(44, 17);
            this.lbl_ufiyat.TabIndex = 5;
            this.lbl_ufiyat.Text = "Fiyat:";
            // 
            // lbl_ubirim
            // 
            this.lbl_ubirim.AutoSize = true;
            this.lbl_ubirim.Location = new System.Drawing.Point(275, 36);
            this.lbl_ubirim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ubirim.Name = "lbl_ubirim";
            this.lbl_ubirim.Size = new System.Drawing.Size(84, 17);
            this.lbl_ubirim.TabIndex = 4;
            this.lbl_ubirim.Text = "Ürün Birim:";
            this.lbl_ubirim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_uad
            // 
            this.lbl_uad.AutoSize = true;
            this.lbl_uad.Location = new System.Drawing.Point(3, 115);
            this.lbl_uad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uad.Name = "lbl_uad";
            this.lbl_uad.Size = new System.Drawing.Size(69, 17);
            this.lbl_uad.TabIndex = 3;
            this.lbl_uad.Text = "Ürün Adı:";
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Location = new System.Drawing.Point(5, 36);
            this.lbl_barkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(94, 17);
            this.lbl_barkod.TabIndex = 2;
            this.lbl_barkod.Text = "Ürün Barkod:";
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kayıt.BackColor = System.Drawing.Color.Green;
            this.btn_kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kayıt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kayıt.Location = new System.Drawing.Point(609, 57);
            this.btn_kayıt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(123, 28);
            this.btn_kayıt.TabIndex = 1;
            this.btn_kayıt.Text = "ÜRÜN KAYIT ";
            this.btn_kayıt.UseVisualStyleBackColor = false;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(609, 112);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(123, 28);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "ÜRÜN SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(609, 169);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(123, 28);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "TEMİZLE";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mainmenu.BackColor = System.Drawing.Color.Aqua;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainmenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainmenu.Location = new System.Drawing.Point(609, 226);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(123, 56);
            this.btn_mainmenu.TabIndex = 4;
            this.btn_mainmenu.Text = "ANA EKRANA DÖN";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guncelle.BackColor = System.Drawing.Color.Salmon;
            this.btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Guncelle.Location = new System.Drawing.Point(40, 320);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(163, 24);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "ÜRÜN GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // lv_liste
            // 
            this.lv_liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunID,
            this.urunBarkod,
            this.urunKod,
            this.urunAd,
            this.kategoriAd,
            this.urunBirim,
            this.urunStok,
            this.urunFiyat,
            this.urunOzellik});
            this.lv_liste.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_liste.FullRowSelect = true;
            this.lv_liste.GridLines = true;
            this.lv_liste.HideSelection = false;
            this.lv_liste.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lv_liste.Location = new System.Drawing.Point(22, 357);
            this.lv_liste.Margin = new System.Windows.Forms.Padding(2);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(715, 201);
            this.lv_liste.TabIndex = 6;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            this.lv_liste.SelectedIndexChanged += new System.EventHandler(this.lv_liste_SelectedIndexChanged);
            // 
            // urunID
            // 
            this.urunID.Text = "Ürün ID";
            this.urunID.Width = 87;
            // 
            // urunBarkod
            // 
            this.urunBarkod.Text = "Barkod";
            this.urunBarkod.Width = 103;
            // 
            // urunKod
            // 
            this.urunKod.Text = "Ürün Kod";
            // 
            // urunAd
            // 
            this.urunAd.Text = "Ad";
            this.urunAd.Width = 105;
            // 
            // kategoriAd
            // 
            this.kategoriAd.Text = "Kategori";
            this.kategoriAd.Width = 102;
            // 
            // urunBirim
            // 
            this.urunBirim.Text = "Birim";
            this.urunBirim.Width = 93;
            // 
            // urunStok
            // 
            this.urunStok.Text = "Stok";
            this.urunStok.Width = 80;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Text = "Fiyat";
            // 
            // urunOzellik
            // 
            this.urunOzellik.Text = "Ürün Özellikler";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(653, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseMove);
            // 
            // form_urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_liste);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.gb_urun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.form_urunler_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_urunler_MouseMove);
            this.gb_urun.ResumeLayout(false);
            this.gb_urun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_urun;
        private System.Windows.Forms.Label lbl_ubirim;
        private System.Windows.Forms.Label lbl_uad;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label lbl_ukat;
        private System.Windows.Forms.Label lbl_ufiyat;
        private System.Windows.Forms.TextBox tb_ufiyat;
        private System.Windows.Forms.ComboBox cb_ukat;
        private System.Windows.Forms.TextBox tb_uad;
        private System.Windows.Forms.TextBox tb_ubarkod;
        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.ListView lv_liste;
        private System.Windows.Forms.ColumnHeader urunID;
        private System.Windows.Forms.ColumnHeader urunBarkod;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader kategoriAd;
        private System.Windows.Forms.ColumnHeader urunStok;
        private System.Windows.Forms.ColumnHeader urunBirim;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_altukat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_urunBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_uozellik;
        private System.Windows.Forms.TextBox tb_uozellik;
        private System.Windows.Forms.ColumnHeader urunKod;
        private System.Windows.Forms.TextBox tb_ukod;
        private System.Windows.Forms.Label lbl_ukod;
        private System.Windows.Forms.ColumnHeader urunOzellik;
    }
}

