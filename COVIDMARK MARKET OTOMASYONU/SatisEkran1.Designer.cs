namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_satis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_satis));
            this.gb_fiyat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_toplam1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_cizgi = new System.Windows.Forms.Label();
            this.lbl_bindirim1 = new System.Windows.Forms.Label();
            this.lbl_bindirim = new System.Windows.Forms.Label();
            this.lbl_atoplam1 = new System.Windows.Forms.Label();
            this.lbl_atoplam = new System.Windows.Forms.Label();
            this.gb_odeme = new System.Windows.Forms.GroupBox();
            this.btn_kk = new System.Windows.Forms.Button();
            this.btn_nakit = new System.Windows.Forms.Button();
            this.gb_urun = new System.Windows.Forms.GroupBox();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.tb_adet = new System.Windows.Forms.TextBox();
            this.tb_uad = new System.Windows.Forms.TextBox();
            this.tb_ubarkod = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_uad = new System.Windows.Forms.Label();
            this.lbl_ukod = new System.Windows.Forms.Label();
            this.gb_isemler = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lv_liste = new System.Windows.Forms.ListView();
            this.İslemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün_Kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÜrünAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_hizliislem = new System.Windows.Forms.GroupBox();
            this.btn_bazlama = new System.Windows.Forms.Button();
            this.btn_ekmek250 = new System.Windows.Forms.Button();
            this.btn_su5 = new System.Windows.Forms.Button();
            this.btn_su1 = new System.Windows.Forms.Button();
            this.btn_su05 = new System.Windows.Forms.Button();
            this.btn_ekmek200 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tumUrunler = new System.Windows.Forms.Button();
            this.gb_fiyat.SuspendLayout();
            this.gb_odeme.SuspendLayout();
            this.gb_urun.SuspendLayout();
            this.gb_isemler.SuspendLayout();
            this.gb_hizliislem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_fiyat
            // 
            this.gb_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.gb_fiyat.Controls.Add(this.label2);
            this.gb_fiyat.Controls.Add(this.lbl_toplam1);
            this.gb_fiyat.Controls.Add(this.lbl_toplam);
            this.gb_fiyat.Controls.Add(this.lbl_cizgi);
            this.gb_fiyat.Controls.Add(this.lbl_bindirim1);
            this.gb_fiyat.Controls.Add(this.lbl_bindirim);
            this.gb_fiyat.Controls.Add(this.lbl_atoplam1);
            this.gb_fiyat.Controls.Add(this.lbl_atoplam);
            this.gb_fiyat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_fiyat.ForeColor = System.Drawing.Color.White;
            this.gb_fiyat.Location = new System.Drawing.Point(755, 312);
            this.gb_fiyat.Margin = new System.Windows.Forms.Padding(2);
            this.gb_fiyat.Name = "gb_fiyat";
            this.gb_fiyat.Padding = new System.Windows.Forms.Padding(2);
            this.gb_fiyat.Size = new System.Drawing.Size(286, 218);
            this.gb_fiyat.TabIndex = 0;
            this.gb_fiyat.TabStop = false;
            this.gb_fiyat.Text = "TUTAR İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "TL";
            // 
            // lbl_toplam1
            // 
            this.lbl_toplam1.AutoSize = true;
            this.lbl_toplam1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam1.Location = new System.Drawing.Point(129, 154);
            this.lbl_toplam1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam1.Name = "lbl_toplam1";
            this.lbl_toplam1.Size = new System.Drawing.Size(106, 31);
            this.lbl_toplam1.TabIndex = 6;
            this.lbl_toplam1.Text = "0.00 TL";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(3, 154);
            this.lbl_toplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(141, 31);
            this.lbl_toplam.TabIndex = 5;
            this.lbl_toplam.Text = "TOPLAM:";
            // 
            // lbl_cizgi
            // 
            this.lbl_cizgi.AutoSize = true;
            this.lbl_cizgi.Location = new System.Drawing.Point(-3, 115);
            this.lbl_cizgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cizgi.Name = "lbl_cizgi";
            this.lbl_cizgi.Size = new System.Drawing.Size(232, 17);
            this.lbl_cizgi.TabIndex = 4;
            this.lbl_cizgi.Text = "________________________________";
            // 
            // lbl_bindirim1
            // 
            this.lbl_bindirim1.AutoSize = true;
            this.lbl_bindirim1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bindirim1.Location = new System.Drawing.Point(130, 81);
            this.lbl_bindirim1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bindirim1.Name = "lbl_bindirim1";
            this.lbl_bindirim1.Size = new System.Drawing.Size(17, 19);
            this.lbl_bindirim1.TabIndex = 3;
            this.lbl_bindirim1.Text = "0";
            // 
            // lbl_bindirim
            // 
            this.lbl_bindirim.AutoSize = true;
            this.lbl_bindirim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bindirim.Location = new System.Drawing.Point(5, 80);
            this.lbl_bindirim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bindirim.Name = "lbl_bindirim";
            this.lbl_bindirim.Size = new System.Drawing.Size(125, 19);
            this.lbl_bindirim.TabIndex = 2;
            this.lbl_bindirim.Text = "Komisyon Tutarı:";
            // 
            // lbl_atoplam1
            // 
            this.lbl_atoplam1.AutoSize = true;
            this.lbl_atoplam1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_atoplam1.Location = new System.Drawing.Point(103, 38);
            this.lbl_atoplam1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_atoplam1.Name = "lbl_atoplam1";
            this.lbl_atoplam1.Size = new System.Drawing.Size(37, 19);
            this.lbl_atoplam1.TabIndex = 1;
            this.lbl_atoplam1.Text = "0.00";
            // 
            // lbl_atoplam
            // 
            this.lbl_atoplam.AutoSize = true;
            this.lbl_atoplam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_atoplam.Location = new System.Drawing.Point(5, 38);
            this.lbl_atoplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_atoplam.Name = "lbl_atoplam";
            this.lbl_atoplam.Size = new System.Drawing.Size(92, 19);
            this.lbl_atoplam.TabIndex = 0;
            this.lbl_atoplam.Text = "Ara Toplam:";
            // 
            // gb_odeme
            // 
            this.gb_odeme.BackColor = System.Drawing.Color.Transparent;
            this.gb_odeme.Controls.Add(this.btn_kk);
            this.gb_odeme.Controls.Add(this.btn_nakit);
            this.gb_odeme.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_odeme.ForeColor = System.Drawing.Color.White;
            this.gb_odeme.Location = new System.Drawing.Point(620, 328);
            this.gb_odeme.Margin = new System.Windows.Forms.Padding(2);
            this.gb_odeme.Name = "gb_odeme";
            this.gb_odeme.Padding = new System.Windows.Forms.Padding(2);
            this.gb_odeme.Size = new System.Drawing.Size(114, 186);
            this.gb_odeme.TabIndex = 1;
            this.gb_odeme.TabStop = false;
            this.gb_odeme.Text = "SATIŞ İŞLEMLERİ";
            // 
            // btn_kk
            // 
            this.btn_kk.BackColor = System.Drawing.Color.Tomato;
            this.btn_kk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kk.ForeColor = System.Drawing.Color.Black;
            this.btn_kk.Location = new System.Drawing.Point(16, 110);
            this.btn_kk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kk.Name = "btn_kk";
            this.btn_kk.Size = new System.Drawing.Size(76, 44);
            this.btn_kk.TabIndex = 1;
            this.btn_kk.Text = "KREDİ KARTI";
            this.btn_kk.UseVisualStyleBackColor = false;
            this.btn_kk.Click += new System.EventHandler(this.btn_kk_Click);
            // 
            // btn_nakit
            // 
            this.btn_nakit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_nakit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nakit.ForeColor = System.Drawing.Color.Black;
            this.btn_nakit.Location = new System.Drawing.Point(16, 37);
            this.btn_nakit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nakit.Name = "btn_nakit";
            this.btn_nakit.Size = new System.Drawing.Size(76, 44);
            this.btn_nakit.TabIndex = 0;
            this.btn_nakit.Text = "NAKİT";
            this.btn_nakit.UseVisualStyleBackColor = false;
            this.btn_nakit.Click += new System.EventHandler(this.btn_nakit_Click);
            // 
            // gb_urun
            // 
            this.gb_urun.BackColor = System.Drawing.Color.Transparent;
            this.gb_urun.Controls.Add(this.lbl_tarih);
            this.gb_urun.Controls.Add(this.tb_adet);
            this.gb_urun.Controls.Add(this.tb_uad);
            this.gb_urun.Controls.Add(this.tb_ubarkod);
            this.gb_urun.Controls.Add(this.lbl_date);
            this.gb_urun.Controls.Add(this.lbl_adet);
            this.gb_urun.Controls.Add(this.lbl_uad);
            this.gb_urun.Controls.Add(this.lbl_ukod);
            this.gb_urun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_urun.ForeColor = System.Drawing.Color.White;
            this.gb_urun.Location = new System.Drawing.Point(12, 32);
            this.gb_urun.Margin = new System.Windows.Forms.Padding(2);
            this.gb_urun.Name = "gb_urun";
            this.gb_urun.Padding = new System.Windows.Forms.Padding(2);
            this.gb_urun.Size = new System.Drawing.Size(593, 133);
            this.gb_urun.TabIndex = 2;
            this.gb_urun.TabStop = false;
            this.gb_urun.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(379, 82);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(109, 17);
            this.lbl_tarih.TabIndex = 13;
            this.lbl_tarih.Text = "00.00.0000 00:00";
            // 
            // tb_adet
            // 
            this.tb_adet.Location = new System.Drawing.Point(127, 75);
            this.tb_adet.Margin = new System.Windows.Forms.Padding(2);
            this.tb_adet.Name = "tb_adet";
            this.tb_adet.Size = new System.Drawing.Size(123, 23);
            this.tb_adet.TabIndex = 12;
            // 
            // tb_uad
            // 
            this.tb_uad.Enabled = false;
            this.tb_uad.Location = new System.Drawing.Point(379, 44);
            this.tb_uad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_uad.Name = "tb_uad";
            this.tb_uad.Size = new System.Drawing.Size(194, 23);
            this.tb_uad.TabIndex = 10;
            // 
            // tb_ubarkod
            // 
            this.tb_ubarkod.Location = new System.Drawing.Point(127, 44);
            this.tb_ubarkod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ubarkod.MaxLength = 10;
            this.tb_ubarkod.Name = "tb_ubarkod";
            this.tb_ubarkod.Size = new System.Drawing.Size(123, 23);
            this.tb_ubarkod.TabIndex = 8;
            this.tb_ubarkod.TextChanged += new System.EventHandler(this.tb_ukod_TextChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AllowDrop = true;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(305, 80);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(45, 17);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "Tarih:";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(25, 76);
            this.lbl_adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(42, 17);
            this.lbl_adet.TabIndex = 3;
            this.lbl_adet.Text = "Adet:";
            // 
            // lbl_uad
            // 
            this.lbl_uad.AutoSize = true;
            this.lbl_uad.Location = new System.Drawing.Point(305, 48);
            this.lbl_uad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uad.Name = "lbl_uad";
            this.lbl_uad.Size = new System.Drawing.Size(69, 17);
            this.lbl_uad.TabIndex = 2;
            this.lbl_uad.Text = "Ürün Adı:";
            // 
            // lbl_ukod
            // 
            this.lbl_ukod.AutoSize = true;
            this.lbl_ukod.Location = new System.Drawing.Point(25, 48);
            this.lbl_ukod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ukod.Name = "lbl_ukod";
            this.lbl_ukod.Size = new System.Drawing.Size(94, 17);
            this.lbl_ukod.TabIndex = 1;
            this.lbl_ukod.Text = "Ürün Barkod:";
            // 
            // gb_isemler
            // 
            this.gb_isemler.BackColor = System.Drawing.Color.Transparent;
            this.gb_isemler.Controls.Add(this.btn_cikis);
            this.gb_isemler.Controls.Add(this.btn_temizle);
            this.gb_isemler.Controls.Add(this.btn_sil);
            this.gb_isemler.Controls.Add(this.btn_ekle);
            this.gb_isemler.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_isemler.ForeColor = System.Drawing.Color.White;
            this.gb_isemler.Location = new System.Drawing.Point(620, 32);
            this.gb_isemler.Margin = new System.Windows.Forms.Padding(2);
            this.gb_isemler.Name = "gb_isemler";
            this.gb_isemler.Padding = new System.Windows.Forms.Padding(2);
            this.gb_isemler.Size = new System.Drawing.Size(112, 291);
            this.gb_isemler.TabIndex = 3;
            this.gb_isemler.TabStop = false;
            this.gb_isemler.Text = "İŞLEMLER";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.Location = new System.Drawing.Point(16, 229);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(76, 44);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(16, 162);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(76, 44);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_sil.Location = new System.Drawing.Point(16, 98);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(76, 44);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "ÇIKAR";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Green;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.Location = new System.Drawing.Point(16, 37);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(76, 44);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lv_liste
            // 
            this.lv_liste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.İslemNo,
            this.Barkod,
            this.Ürün_Kod,
            this.ÜrünAdı,
            this.Birim,
            this.Adet,
            this.birimFiyat,
            this.Tutar,
            this.tarih});
            this.lv_liste.FullRowSelect = true;
            this.lv_liste.GridLines = true;
            this.lv_liste.HideSelection = false;
            this.lv_liste.Location = new System.Drawing.Point(13, 185);
            this.lv_liste.Margin = new System.Windows.Forms.Padding(2);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(592, 330);
            this.lv_liste.TabIndex = 4;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            // 
            // İslemNo
            // 
            this.İslemNo.Text = "İslemNo";
            this.İslemNo.Width = 90;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.Width = 130;
            // 
            // Ürün_Kod
            // 
            this.Ürün_Kod.Text = "Ürün Kod";
            // 
            // ÜrünAdı
            // 
            this.ÜrünAdı.Text = "Ürün Adı";
            this.ÜrünAdı.Width = 87;
            // 
            // Birim
            // 
            this.Birim.Text = "Birim";
            // 
            // Adet
            // 
            this.Adet.Text = "Adet";
            // 
            // birimFiyat
            // 
            this.birimFiyat.Text = "Birim Fiyat";
            // 
            // Tutar
            // 
            this.Tutar.Text = "Tutar";
            this.Tutar.Width = 49;
            // 
            // tarih
            // 
            this.tarih.Text = "Tarih";
            // 
            // gb_hizliislem
            // 
            this.gb_hizliislem.BackColor = System.Drawing.Color.Transparent;
            this.gb_hizliislem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_hizliislem.Controls.Add(this.tumUrunler);
            this.gb_hizliislem.Controls.Add(this.btn_bazlama);
            this.gb_hizliislem.Controls.Add(this.btn_ekmek250);
            this.gb_hizliislem.Controls.Add(this.btn_su5);
            this.gb_hizliislem.Controls.Add(this.btn_su1);
            this.gb_hizliislem.Controls.Add(this.btn_su05);
            this.gb_hizliislem.Controls.Add(this.btn_ekmek200);
            this.gb_hizliislem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_hizliislem.ForeColor = System.Drawing.Color.White;
            this.gb_hizliislem.Location = new System.Drawing.Point(755, 32);
            this.gb_hizliislem.Margin = new System.Windows.Forms.Padding(2);
            this.gb_hizliislem.Name = "gb_hizliislem";
            this.gb_hizliislem.Padding = new System.Windows.Forms.Padding(2);
            this.gb_hizliislem.Size = new System.Drawing.Size(286, 273);
            this.gb_hizliislem.TabIndex = 5;
            this.gb_hizliislem.TabStop = false;
            this.gb_hizliislem.Text = "HIZLI İŞLEMLER";
            // 
            // btn_bazlama
            // 
            this.btn_bazlama.ForeColor = System.Drawing.Color.Black;
            this.btn_bazlama.Location = new System.Drawing.Point(135, 82);
            this.btn_bazlama.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bazlama.Name = "btn_bazlama";
            this.btn_bazlama.Size = new System.Drawing.Size(139, 39);
            this.btn_bazlama.TabIndex = 5;
            this.btn_bazlama.Text = "BAZLAMA(200 Gr.)";
            this.btn_bazlama.UseVisualStyleBackColor = true;
            this.btn_bazlama.Click += new System.EventHandler(this.btn_bazlama_Click);
            // 
            // btn_ekmek250
            // 
            this.btn_ekmek250.ForeColor = System.Drawing.Color.Black;
            this.btn_ekmek250.Location = new System.Drawing.Point(135, 27);
            this.btn_ekmek250.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekmek250.Name = "btn_ekmek250";
            this.btn_ekmek250.Size = new System.Drawing.Size(139, 39);
            this.btn_ekmek250.TabIndex = 4;
            this.btn_ekmek250.Text = "EKMEK(250 Gr.)";
            this.btn_ekmek250.UseVisualStyleBackColor = true;
            this.btn_ekmek250.Click += new System.EventHandler(this.btn_ekmek250_Click);
            // 
            // btn_su5
            // 
            this.btn_su5.ForeColor = System.Drawing.Color.Black;
            this.btn_su5.Location = new System.Drawing.Point(8, 201);
            this.btn_su5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_su5.Name = "btn_su5";
            this.btn_su5.Size = new System.Drawing.Size(122, 39);
            this.btn_su5.TabIndex = 3;
            this.btn_su5.Text = "SU 5 L";
            this.btn_su5.UseVisualStyleBackColor = true;
            this.btn_su5.Click += new System.EventHandler(this.btn_su5_Click);
            // 
            // btn_su1
            // 
            this.btn_su1.ForeColor = System.Drawing.Color.Black;
            this.btn_su1.Location = new System.Drawing.Point(8, 141);
            this.btn_su1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_su1.Name = "btn_su1";
            this.btn_su1.Size = new System.Drawing.Size(122, 39);
            this.btn_su1.TabIndex = 2;
            this.btn_su1.Text = "SU 1 L";
            this.btn_su1.UseVisualStyleBackColor = true;
            this.btn_su1.Click += new System.EventHandler(this.btn_su1_Click);
            // 
            // btn_su05
            // 
            this.btn_su05.ForeColor = System.Drawing.Color.Black;
            this.btn_su05.Location = new System.Drawing.Point(8, 82);
            this.btn_su05.Margin = new System.Windows.Forms.Padding(2);
            this.btn_su05.Name = "btn_su05";
            this.btn_su05.Size = new System.Drawing.Size(122, 39);
            this.btn_su05.TabIndex = 1;
            this.btn_su05.Text = "SU 0.5 L";
            this.btn_su05.UseVisualStyleBackColor = true;
            this.btn_su05.Click += new System.EventHandler(this.btn_su05_Click);
            // 
            // btn_ekmek200
            // 
            this.btn_ekmek200.ForeColor = System.Drawing.Color.Black;
            this.btn_ekmek200.Location = new System.Drawing.Point(8, 27);
            this.btn_ekmek200.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekmek200.Name = "btn_ekmek200";
            this.btn_ekmek200.Size = new System.Drawing.Size(122, 39);
            this.btn_ekmek200.TabIndex = 0;
            this.btn_ekmek200.Text = "EKMEK(200 Gr.)";
            this.btn_ekmek200.UseVisualStyleBackColor = true;
            this.btn_ekmek200.Click += new System.EventHandler(this.btn_ekmek_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(973, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseMove);
            // 
            // sayac
            // 
            this.sayac.Enabled = true;
            this.sayac.Interval = 1000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(899, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseMove);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tumUrunler
            // 
            this.tumUrunler.ForeColor = System.Drawing.Color.Black;
            this.tumUrunler.Location = new System.Drawing.Point(135, 141);
            this.tumUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.tumUrunler.Name = "tumUrunler";
            this.tumUrunler.Size = new System.Drawing.Size(139, 39);
            this.tumUrunler.TabIndex = 6;
            this.tumUrunler.Text = "Tüm Ürünler Ekle";
            this.tumUrunler.UseVisualStyleBackColor = true;
            this.tumUrunler.Click += new System.EventHandler(this.tumUrunler_Click);
            // 
            // form_satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_hizliislem);
            this.Controls.Add(this.lv_liste);
            this.Controls.Add(this.gb_isemler);
            this.Controls.Add(this.gb_urun);
            this.Controls.Add(this.gb_odeme);
            this.Controls.Add(this.gb_fiyat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIS EKRANI";
            this.Load += new System.EventHandler(this.form_satis_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_satis_MouseMove);
            this.gb_fiyat.ResumeLayout(false);
            this.gb_fiyat.PerformLayout();
            this.gb_odeme.ResumeLayout(false);
            this.gb_urun.ResumeLayout(false);
            this.gb_urun.PerformLayout();
            this.gb_isemler.ResumeLayout(false);
            this.gb_hizliislem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_fiyat;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label lbl_cizgi;
        private System.Windows.Forms.Label lbl_bindirim1;
        private System.Windows.Forms.Label lbl_bindirim;
        private System.Windows.Forms.Label lbl_atoplam;
        private System.Windows.Forms.GroupBox gb_odeme;
        private System.Windows.Forms.Button btn_kk;
        private System.Windows.Forms.Button btn_nakit;
        private System.Windows.Forms.GroupBox gb_urun;
        private System.Windows.Forms.GroupBox gb_isemler;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_adet;
        private System.Windows.Forms.TextBox tb_uad;
        private System.Windows.Forms.TextBox tb_ubarkod;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label lbl_uad;
        private System.Windows.Forms.Label lbl_ukod;
        private System.Windows.Forms.ColumnHeader İslemNo;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader ÜrünAdı;
        private System.Windows.Forms.ColumnHeader Birim;
        private System.Windows.Forms.ColumnHeader Adet;
        private System.Windows.Forms.ColumnHeader Tutar;
        private System.Windows.Forms.GroupBox gb_hizliislem;
        private System.Windows.Forms.Button btn_bazlama;
        private System.Windows.Forms.Button btn_ekmek250;
        private System.Windows.Forms.Button btn_su5;
        private System.Windows.Forms.Button btn_su1;
        private System.Windows.Forms.Button btn_su05;
        private System.Windows.Forms.Button btn_ekmek200;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader birimFiyat;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Ürün_Kod;
        public System.Windows.Forms.ListView lv_liste;
        public System.Windows.Forms.Label lbl_toplam1;
        public System.Windows.Forms.Label lbl_atoplam1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button tumUrunler;
    }
}

