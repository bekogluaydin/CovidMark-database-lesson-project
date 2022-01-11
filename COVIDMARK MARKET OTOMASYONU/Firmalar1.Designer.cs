namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_firma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_firma));
            this.gb_firma = new System.Windows.Forms.GroupBox();
            this.lb_plakaNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_pk = new System.Windows.Forms.Label();
            this.cb_fdahili = new System.Windows.Forms.ComboBox();
            this.cb_fmah = new System.Windows.Forms.ComboBox();
            this.cb_fbolge = new System.Windows.Forms.ComboBox();
            this.lbl_fmah = new System.Windows.Forms.Label();
            this.lbl_fbolge = new System.Windows.Forms.Label();
            this.cb_filce = new System.Windows.Forms.ComboBox();
            this.cb_fil = new System.Windows.Forms.ComboBox();
            this.tb_fvno = new System.Windows.Forms.TextBox();
            this.tb_fadres = new System.Windows.Forms.TextBox();
            this.tb_ftel = new System.Windows.Forms.TextBox();
            this.tb_fad = new System.Windows.Forms.TextBox();
            this.lbl_fadres = new System.Windows.Forms.Label();
            this.lbl_filce = new System.Windows.Forms.Label();
            this.lbl_fİl = new System.Windows.Forms.Label();
            this.lbl_ftel = new System.Windows.Forms.Label();
            this.lbl_fvno = new System.Windows.Forms.Label();
            this.lbl_fad = new System.Windows.Forms.Label();
            this.btn_fKayıt = new System.Windows.Forms.Button();
            this.btn_fSil = new System.Windows.Forms.Button();
            this.btn_fTemizle = new System.Windows.Forms.Button();
            this.btn_fmainmenu = new System.Windows.Forms.Button();
            this.lv_liste = new System.Windows.Forms.ListView();
            this.firma_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vergi_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firma_ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Posta_Kodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İlçe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bolge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mahalle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_fGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_firma.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_firma
            // 
            this.gb_firma.BackColor = System.Drawing.Color.Transparent;
            this.gb_firma.Controls.Add(this.lb_plakaNo);
            this.gb_firma.Controls.Add(this.label2);
            this.gb_firma.Controls.Add(this.label3);
            this.gb_firma.Controls.Add(this.lb_pk);
            this.gb_firma.Controls.Add(this.cb_fdahili);
            this.gb_firma.Controls.Add(this.cb_fmah);
            this.gb_firma.Controls.Add(this.cb_fbolge);
            this.gb_firma.Controls.Add(this.lbl_fmah);
            this.gb_firma.Controls.Add(this.lbl_fbolge);
            this.gb_firma.Controls.Add(this.cb_filce);
            this.gb_firma.Controls.Add(this.cb_fil);
            this.gb_firma.Controls.Add(this.tb_fvno);
            this.gb_firma.Controls.Add(this.tb_fadres);
            this.gb_firma.Controls.Add(this.tb_ftel);
            this.gb_firma.Controls.Add(this.tb_fad);
            this.gb_firma.Controls.Add(this.lbl_fadres);
            this.gb_firma.Controls.Add(this.lbl_filce);
            this.gb_firma.Controls.Add(this.lbl_fİl);
            this.gb_firma.Controls.Add(this.lbl_ftel);
            this.gb_firma.Controls.Add(this.lbl_fvno);
            this.gb_firma.Controls.Add(this.lbl_fad);
            this.gb_firma.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_firma.ForeColor = System.Drawing.Color.White;
            this.gb_firma.Location = new System.Drawing.Point(13, 24);
            this.gb_firma.Margin = new System.Windows.Forms.Padding(4);
            this.gb_firma.Name = "gb_firma";
            this.gb_firma.Padding = new System.Windows.Forms.Padding(4);
            this.gb_firma.Size = new System.Drawing.Size(708, 310);
            this.gb_firma.TabIndex = 0;
            this.gb_firma.TabStop = false;
            this.gb_firma.Text = "Firma İşlemleri";
            // 
            // lb_plakaNo
            // 
            this.lb_plakaNo.AutoSize = true;
            this.lb_plakaNo.Location = new System.Drawing.Point(555, 230);
            this.lb_plakaNo.Name = "lb_plakaNo";
            this.lb_plakaNo.Size = new System.Drawing.Size(22, 17);
            this.lb_plakaNo.TabIndex = 24;
            this.lb_plakaNo.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Plaka No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Posta Kodu: ";
            // 
            // lb_pk
            // 
            this.lb_pk.AutoSize = true;
            this.lb_pk.Enabled = false;
            this.lb_pk.Location = new System.Drawing.Point(552, 258);
            this.lb_pk.Name = "lb_pk";
            this.lb_pk.Size = new System.Drawing.Size(43, 17);
            this.lb_pk.TabIndex = 21;
            this.lb_pk.Text = "00000";
            // 
            // cb_fdahili
            // 
            this.cb_fdahili.Enabled = false;
            this.cb_fdahili.FormattingEnabled = true;
            this.cb_fdahili.Location = new System.Drawing.Point(110, 79);
            this.cb_fdahili.Name = "cb_fdahili";
            this.cb_fdahili.Size = new System.Drawing.Size(52, 25);
            this.cb_fdahili.TabIndex = 20;
            // 
            // cb_fmah
            // 
            this.cb_fmah.Enabled = false;
            this.cb_fmah.FormattingEnabled = true;
            this.cb_fmah.Location = new System.Drawing.Point(504, 179);
            this.cb_fmah.Name = "cb_fmah";
            this.cb_fmah.Size = new System.Drawing.Size(191, 25);
            this.cb_fmah.TabIndex = 19;
            this.cb_fmah.SelectedIndexChanged += new System.EventHandler(this.cb_fmah_SelectedIndexChanged);
            // 
            // cb_fbolge
            // 
            this.cb_fbolge.Enabled = false;
            this.cb_fbolge.FormattingEnabled = true;
            this.cb_fbolge.Location = new System.Drawing.Point(504, 126);
            this.cb_fbolge.Name = "cb_fbolge";
            this.cb_fbolge.Size = new System.Drawing.Size(191, 25);
            this.cb_fbolge.TabIndex = 18;
            this.cb_fbolge.SelectedIndexChanged += new System.EventHandler(this.cb_fbolge_SelectedIndexChanged);
            // 
            // lbl_fmah
            // 
            this.lbl_fmah.AutoSize = true;
            this.lbl_fmah.Location = new System.Drawing.Point(392, 180);
            this.lbl_fmah.Name = "lbl_fmah";
            this.lbl_fmah.Size = new System.Drawing.Size(44, 17);
            this.lbl_fmah.TabIndex = 17;
            this.lbl_fmah.Text = "Mah: ";
            // 
            // lbl_fbolge
            // 
            this.lbl_fbolge.AutoSize = true;
            this.lbl_fbolge.Location = new System.Drawing.Point(390, 130);
            this.lbl_fbolge.Name = "lbl_fbolge";
            this.lbl_fbolge.Size = new System.Drawing.Size(51, 17);
            this.lbl_fbolge.TabIndex = 16;
            this.lbl_fbolge.Text = "Bölge: ";
            // 
            // cb_filce
            // 
            this.cb_filce.Enabled = false;
            this.cb_filce.FormattingEnabled = true;
            this.cb_filce.Location = new System.Drawing.Point(110, 128);
            this.cb_filce.Name = "cb_filce";
            this.cb_filce.Size = new System.Drawing.Size(205, 25);
            this.cb_filce.TabIndex = 15;
            this.cb_filce.SelectedIndexChanged += new System.EventHandler(this.cb_filce_SelectedIndexChanged);
            // 
            // cb_fil
            // 
            this.cb_fil.FormattingEnabled = true;
            this.cb_fil.Location = new System.Drawing.Point(504, 81);
            this.cb_fil.Name = "cb_fil";
            this.cb_fil.Size = new System.Drawing.Size(191, 25);
            this.cb_fil.TabIndex = 14;
            this.cb_fil.SelectedIndexChanged += new System.EventHandler(this.cb_fil_SelectedIndexChanged);
            // 
            // tb_fvno
            // 
            this.tb_fvno.Location = new System.Drawing.Point(504, 36);
            this.tb_fvno.MaxLength = 10;
            this.tb_fvno.Name = "tb_fvno";
            this.tb_fvno.Size = new System.Drawing.Size(191, 23);
            this.tb_fvno.TabIndex = 11;
            // 
            // tb_fadres
            // 
            this.tb_fadres.Enabled = false;
            this.tb_fadres.Location = new System.Drawing.Point(110, 180);
            this.tb_fadres.Multiline = true;
            this.tb_fadres.Name = "tb_fadres";
            this.tb_fadres.Size = new System.Drawing.Size(219, 106);
            this.tb_fadres.TabIndex = 10;
            // 
            // tb_ftel
            // 
            this.tb_ftel.Enabled = false;
            this.tb_ftel.Location = new System.Drawing.Point(168, 79);
            this.tb_ftel.MaxLength = 7;
            this.tb_ftel.Name = "tb_ftel";
            this.tb_ftel.Size = new System.Drawing.Size(147, 23);
            this.tb_ftel.TabIndex = 8;
            // 
            // tb_fad
            // 
            this.tb_fad.Location = new System.Drawing.Point(110, 34);
            this.tb_fad.MaxLength = 500;
            this.tb_fad.Name = "tb_fad";
            this.tb_fad.Size = new System.Drawing.Size(205, 23);
            this.tb_fad.TabIndex = 7;
            // 
            // lbl_fadres
            // 
            this.lbl_fadres.AutoSize = true;
            this.lbl_fadres.Location = new System.Drawing.Point(8, 180);
            this.lbl_fadres.Name = "lbl_fadres";
            this.lbl_fadres.Size = new System.Drawing.Size(49, 17);
            this.lbl_fadres.TabIndex = 6;
            this.lbl_fadres.Text = "Adres:";
            // 
            // lbl_filce
            // 
            this.lbl_filce.AutoSize = true;
            this.lbl_filce.Location = new System.Drawing.Point(8, 130);
            this.lbl_filce.Name = "lbl_filce";
            this.lbl_filce.Size = new System.Drawing.Size(36, 17);
            this.lbl_filce.TabIndex = 5;
            this.lbl_filce.Text = "İlçe:";
            // 
            // lbl_fİl
            // 
            this.lbl_fİl.AutoSize = true;
            this.lbl_fİl.Location = new System.Drawing.Point(390, 84);
            this.lbl_fİl.Name = "lbl_fİl";
            this.lbl_fİl.Size = new System.Drawing.Size(23, 17);
            this.lbl_fİl.TabIndex = 4;
            this.lbl_fİl.Text = "İl:";
            // 
            // lbl_ftel
            // 
            this.lbl_ftel.AutoSize = true;
            this.lbl_ftel.Location = new System.Drawing.Point(8, 87);
            this.lbl_ftel.Name = "lbl_ftel";
            this.lbl_ftel.Size = new System.Drawing.Size(58, 17);
            this.lbl_ftel.TabIndex = 2;
            this.lbl_ftel.Text = "Telefon:";
            // 
            // lbl_fvno
            // 
            this.lbl_fvno.AutoSize = true;
            this.lbl_fvno.Location = new System.Drawing.Point(390, 39);
            this.lbl_fvno.Name = "lbl_fvno";
            this.lbl_fvno.Size = new System.Drawing.Size(66, 17);
            this.lbl_fvno.TabIndex = 1;
            this.lbl_fvno.Text = "Vergi No:";
            // 
            // lbl_fad
            // 
            this.lbl_fad.AutoSize = true;
            this.lbl_fad.Location = new System.Drawing.Point(8, 42);
            this.lbl_fad.Name = "lbl_fad";
            this.lbl_fad.Size = new System.Drawing.Size(70, 17);
            this.lbl_fad.TabIndex = 0;
            this.lbl_fad.Text = "Firma Ad:";
            // 
            // btn_fKayıt
            // 
            this.btn_fKayıt.BackColor = System.Drawing.Color.Green;
            this.btn_fKayıt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fKayıt.Location = new System.Drawing.Point(728, 58);
            this.btn_fKayıt.Name = "btn_fKayıt";
            this.btn_fKayıt.Size = new System.Drawing.Size(211, 52);
            this.btn_fKayıt.TabIndex = 2;
            this.btn_fKayıt.Text = "FİRMA KAYIT";
            this.btn_fKayıt.UseVisualStyleBackColor = false;
            this.btn_fKayıt.Click += new System.EventHandler(this.btn_fKayıt_Click);
            // 
            // btn_fSil
            // 
            this.btn_fSil.BackColor = System.Drawing.Color.Red;
            this.btn_fSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fSil.Location = new System.Drawing.Point(728, 136);
            this.btn_fSil.Name = "btn_fSil";
            this.btn_fSil.Size = new System.Drawing.Size(211, 52);
            this.btn_fSil.TabIndex = 3;
            this.btn_fSil.Text = "FİRMA SİL";
            this.btn_fSil.UseVisualStyleBackColor = false;
            this.btn_fSil.Click += new System.EventHandler(this.btn_fSil_Click);
            // 
            // btn_fTemizle
            // 
            this.btn_fTemizle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_fTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fTemizle.Location = new System.Drawing.Point(728, 206);
            this.btn_fTemizle.Name = "btn_fTemizle";
            this.btn_fTemizle.Size = new System.Drawing.Size(211, 52);
            this.btn_fTemizle.TabIndex = 4;
            this.btn_fTemizle.Text = "TEMİZLE";
            this.btn_fTemizle.UseVisualStyleBackColor = false;
            this.btn_fTemizle.Click += new System.EventHandler(this.btn_ftemizle_Click);
            // 
            // btn_fmainmenu
            // 
            this.btn_fmainmenu.BackColor = System.Drawing.Color.Aqua;
            this.btn_fmainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fmainmenu.Location = new System.Drawing.Point(728, 282);
            this.btn_fmainmenu.Name = "btn_fmainmenu";
            this.btn_fmainmenu.Size = new System.Drawing.Size(211, 52);
            this.btn_fmainmenu.TabIndex = 5;
            this.btn_fmainmenu.Text = "ANA MENÜYE DÖN";
            this.btn_fmainmenu.UseVisualStyleBackColor = false;
            this.btn_fmainmenu.Click += new System.EventHandler(this.btn_fmainmenu_Click);
            // 
            // lv_liste
            // 
            this.lv_liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firma_id,
            this.Vergi_no,
            this.firma_ad,
            this.Telefon,
            this.Posta_Kodu,
            this.İl,
            this.İlçe,
            this.Bolge,
            this.Mahalle,
            this.Adres});
            this.lv_liste.FullRowSelect = true;
            this.lv_liste.GridLines = true;
            this.lv_liste.HideSelection = false;
            this.lv_liste.Location = new System.Drawing.Point(13, 387);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(942, 267);
            this.lv_liste.TabIndex = 6;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            this.lv_liste.SelectedIndexChanged += new System.EventHandler(this.lv_liste_SelectedIndexChanged);
            // 
            // firma_id
            // 
            this.firma_id.Text = "Firma_id";
            this.firma_id.Width = 106;
            // 
            // Vergi_no
            // 
            this.Vergi_no.Text = "Vergi No";
            this.Vergi_no.Width = 123;
            // 
            // firma_ad
            // 
            this.firma_ad.Text = "Ad";
            this.firma_ad.Width = 98;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 105;
            // 
            // Posta_Kodu
            // 
            this.Posta_Kodu.Text = "Posta Kodu";
            this.Posta_Kodu.Width = 90;
            // 
            // İl
            // 
            this.İl.Text = "İl";
            this.İl.Width = 77;
            // 
            // İlçe
            // 
            this.İlçe.Text = "İlçe";
            this.İlçe.Width = 62;
            // 
            // Bolge
            // 
            this.Bolge.Text = "Bolge";
            // 
            // Mahalle
            // 
            this.Mahalle.Text = "Mahalle";
            this.Mahalle.Width = 138;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 124;
            // 
            // btn_fGuncelle
            // 
            this.btn_fGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fGuncelle.BackColor = System.Drawing.Color.Salmon;
            this.btn_fGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.btn_fGuncelle.Location = new System.Drawing.Point(29, 349);
            this.btn_fGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fGuncelle.Name = "btn_fGuncelle";
            this.btn_fGuncelle.Size = new System.Drawing.Size(163, 24);
            this.btn_fGuncelle.TabIndex = 9;
            this.btn_fGuncelle.Text = "FİRMA GÜNCELLE";
            this.btn_fGuncelle.UseVisualStyleBackColor = false;
            this.btn_fGuncelle.Click += new System.EventHandler(this.btn_fGuncelle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(926, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(834, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Personel No:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseMove);
            // 
            // form_firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_fGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_liste);
            this.Controls.Add(this.btn_fmainmenu);
            this.Controls.Add(this.btn_fTemizle);
            this.Controls.Add(this.btn_fSil);
            this.Controls.Add(this.btn_fKayıt);
            this.Controls.Add(this.gb_firma);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_firma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.form_firma_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_firma_MouseMove);
            this.gb_firma.ResumeLayout(false);
            this.gb_firma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_firma;
        private System.Windows.Forms.Label lbl_fvno;
        private System.Windows.Forms.Label lbl_fad;
        private System.Windows.Forms.TextBox tb_fvno;
        private System.Windows.Forms.TextBox tb_fadres;
        private System.Windows.Forms.TextBox tb_ftel;
        private System.Windows.Forms.TextBox tb_fad;
        private System.Windows.Forms.Label lbl_fadres;
        private System.Windows.Forms.Label lbl_filce;
        private System.Windows.Forms.Label lbl_fİl;
        private System.Windows.Forms.Label lbl_ftel;
        private System.Windows.Forms.Button btn_fKayıt;
        private System.Windows.Forms.Button btn_fSil;
        private System.Windows.Forms.Button btn_fTemizle;
        private System.Windows.Forms.Button btn_fmainmenu;
        private System.Windows.Forms.ListView lv_liste;
        private System.Windows.Forms.ColumnHeader firma_id;
        private System.Windows.Forms.ColumnHeader firma_ad;
        private System.Windows.Forms.ColumnHeader Vergi_no;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader İl;
        private System.Windows.Forms.ColumnHeader İlçe;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Posta_Kodu;
        private System.Windows.Forms.Button btn_fGuncelle;
        private System.Windows.Forms.ComboBox cb_filce;
        private System.Windows.Forms.ComboBox cb_fil;
        private System.Windows.Forms.ComboBox cb_fmah;
        private System.Windows.Forms.ComboBox cb_fbolge;
        private System.Windows.Forms.Label lbl_fmah;
        private System.Windows.Forms.Label lbl_fbolge;
        private System.Windows.Forms.ComboBox cb_fdahili;
        private System.Windows.Forms.ColumnHeader Mahalle;
        private System.Windows.Forms.ColumnHeader Bolge;
        private System.Windows.Forms.Label lb_pk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_plakaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

