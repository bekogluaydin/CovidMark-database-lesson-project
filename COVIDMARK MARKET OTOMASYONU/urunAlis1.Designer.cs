namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_alis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_alis));
            this.gb_fatura = new System.Windows.Forms.GroupBox();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.tb_fvergiNo = new System.Windows.Forms.TextBox();
            this.lbl_fvergiNo = new System.Windows.Forms.Label();
            this.tb_alısfiyat = new System.Windows.Forms.TextBox();
            this.tb_adet = new System.Windows.Forms.TextBox();
            this.tb_afad = new System.Windows.Forms.TextBox();
            this.lbl_atutar = new System.Windows.Forms.Label();
            this.tb_auad = new System.Windows.Forms.TextBox();
            this.tb_ubarkod = new System.Windows.Forms.TextBox();
            this.lbl_afirma = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_atarih = new System.Windows.Forms.Label();
            this.lbl_fuad = new System.Windows.Forms.Label();
            this.lbl_fuBarkod = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.islemNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firma_vergiNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Firma_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün_Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün_Kod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alınan_Adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alış_Fiyatı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Toplam_Tutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_alisTamamla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayac = new System.Windows.Forms.Timer(this.components);
            this.gb_fiyat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_toplam1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_cizgi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gb_fatura.SuspendLayout();
            this.gb_fiyat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_fatura
            // 
            this.gb_fatura.BackColor = System.Drawing.Color.Transparent;
            this.gb_fatura.Controls.Add(this.lbl_tarih);
            this.gb_fatura.Controls.Add(this.tb_fvergiNo);
            this.gb_fatura.Controls.Add(this.lbl_fvergiNo);
            this.gb_fatura.Controls.Add(this.tb_alısfiyat);
            this.gb_fatura.Controls.Add(this.tb_adet);
            this.gb_fatura.Controls.Add(this.tb_afad);
            this.gb_fatura.Controls.Add(this.lbl_atutar);
            this.gb_fatura.Controls.Add(this.tb_auad);
            this.gb_fatura.Controls.Add(this.tb_ubarkod);
            this.gb_fatura.Controls.Add(this.lbl_afirma);
            this.gb_fatura.Controls.Add(this.lbl_adet);
            this.gb_fatura.Controls.Add(this.lbl_atarih);
            this.gb_fatura.Controls.Add(this.lbl_fuad);
            this.gb_fatura.Controls.Add(this.lbl_fuBarkod);
            this.gb_fatura.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_fatura.ForeColor = System.Drawing.Color.White;
            this.gb_fatura.Location = new System.Drawing.Point(8, 34);
            this.gb_fatura.Margin = new System.Windows.Forms.Padding(2);
            this.gb_fatura.Name = "gb_fatura";
            this.gb_fatura.Padding = new System.Windows.Forms.Padding(2);
            this.gb_fatura.Size = new System.Drawing.Size(533, 224);
            this.gb_fatura.TabIndex = 0;
            this.gb_fatura.TabStop = false;
            this.gb_fatura.Text = "Alınan Ürün İşlemleri";
            this.gb_fatura.Enter += new System.EventHandler(this.gb_fatura_Enter);
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(387, 128);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(109, 17);
            this.lbl_tarih.TabIndex = 14;
            this.lbl_tarih.Text = "00.00.0000 00:00";
            // 
            // tb_fvergiNo
            // 
            this.tb_fvergiNo.Location = new System.Drawing.Point(115, 122);
            this.tb_fvergiNo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_fvergiNo.MaxLength = 10;
            this.tb_fvergiNo.Name = "tb_fvergiNo";
            this.tb_fvergiNo.Size = new System.Drawing.Size(146, 23);
            this.tb_fvergiNo.TabIndex = 15;
            this.tb_fvergiNo.TextChanged += new System.EventHandler(this.tb_fvergiNo_TextChanged);
            // 
            // lbl_fvergiNo
            // 
            this.lbl_fvergiNo.AutoSize = true;
            this.lbl_fvergiNo.Location = new System.Drawing.Point(5, 124);
            this.lbl_fvergiNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fvergiNo.Name = "lbl_fvergiNo";
            this.lbl_fvergiNo.Size = new System.Drawing.Size(107, 17);
            this.lbl_fvergiNo.TabIndex = 14;
            this.lbl_fvergiNo.Text = "Firma Vergi No:";
            // 
            // tb_alısfiyat
            // 
            this.tb_alısfiyat.Location = new System.Drawing.Point(370, 86);
            this.tb_alısfiyat.Margin = new System.Windows.Forms.Padding(2);
            this.tb_alısfiyat.Name = "tb_alısfiyat";
            this.tb_alısfiyat.Size = new System.Drawing.Size(157, 23);
            this.tb_alısfiyat.TabIndex = 13;
            // 
            // tb_adet
            // 
            this.tb_adet.Location = new System.Drawing.Point(370, 44);
            this.tb_adet.Margin = new System.Windows.Forms.Padding(2);
            this.tb_adet.Name = "tb_adet";
            this.tb_adet.Size = new System.Drawing.Size(157, 23);
            this.tb_adet.TabIndex = 10;
            // 
            // tb_afad
            // 
            this.tb_afad.Enabled = false;
            this.tb_afad.Location = new System.Drawing.Point(115, 163);
            this.tb_afad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_afad.Name = "tb_afad";
            this.tb_afad.Size = new System.Drawing.Size(146, 23);
            this.tb_afad.TabIndex = 9;
            // 
            // lbl_atutar
            // 
            this.lbl_atutar.AutoSize = true;
            this.lbl_atutar.Location = new System.Drawing.Point(278, 88);
            this.lbl_atutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_atutar.Name = "lbl_atutar";
            this.lbl_atutar.Size = new System.Drawing.Size(76, 17);
            this.lbl_atutar.TabIndex = 5;
            this.lbl_atutar.Text = "Alış Fiyatı:";
            // 
            // tb_auad
            // 
            this.tb_auad.Enabled = false;
            this.tb_auad.Location = new System.Drawing.Point(115, 81);
            this.tb_auad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_auad.Name = "tb_auad";
            this.tb_auad.Size = new System.Drawing.Size(146, 23);
            this.tb_auad.TabIndex = 8;
            // 
            // tb_ubarkod
            // 
            this.tb_ubarkod.Location = new System.Drawing.Point(115, 44);
            this.tb_ubarkod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ubarkod.MaxLength = 10;
            this.tb_ubarkod.Name = "tb_ubarkod";
            this.tb_ubarkod.Size = new System.Drawing.Size(146, 23);
            this.tb_ubarkod.TabIndex = 7;
            this.tb_ubarkod.TextChanged += new System.EventHandler(this.tb_ubarkod_TextChanged);
            // 
            // lbl_afirma
            // 
            this.lbl_afirma.AutoSize = true;
            this.lbl_afirma.Location = new System.Drawing.Point(7, 166);
            this.lbl_afirma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_afirma.Name = "lbl_afirma";
            this.lbl_afirma.Size = new System.Drawing.Size(74, 17);
            this.lbl_afirma.TabIndex = 6;
            this.lbl_afirma.Text = "Firma Adı:";
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(278, 47);
            this.lbl_adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(42, 17);
            this.lbl_adet.TabIndex = 3;
            this.lbl_adet.Text = "Adet:";
            // 
            // lbl_atarih
            // 
            this.lbl_atarih.AutoSize = true;
            this.lbl_atarih.Location = new System.Drawing.Point(278, 125);
            this.lbl_atarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_atarih.Name = "lbl_atarih";
            this.lbl_atarih.Size = new System.Drawing.Size(45, 17);
            this.lbl_atarih.TabIndex = 2;
            this.lbl_atarih.Text = "Tarih:";
            // 
            // lbl_fuad
            // 
            this.lbl_fuad.AutoSize = true;
            this.lbl_fuad.Location = new System.Drawing.Point(7, 85);
            this.lbl_fuad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fuad.Name = "lbl_fuad";
            this.lbl_fuad.Size = new System.Drawing.Size(69, 17);
            this.lbl_fuad.TabIndex = 1;
            this.lbl_fuad.Text = "Ürün Adı:";
            // 
            // lbl_fuBarkod
            // 
            this.lbl_fuBarkod.AutoSize = true;
            this.lbl_fuBarkod.Location = new System.Drawing.Point(5, 49);
            this.lbl_fuBarkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fuBarkod.Name = "lbl_fuBarkod";
            this.lbl_fuBarkod.Size = new System.Drawing.Size(94, 17);
            this.lbl_fuBarkod.TabIndex = 0;
            this.lbl_fuBarkod.Text = "Ürün Barkod:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Green;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ekle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_ekle.Location = new System.Drawing.Point(549, 42);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(158, 42);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.Black;
            this.btn_sil.Location = new System.Drawing.Point(549, 100);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(158, 42);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "ÇIKAR";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.Location = new System.Drawing.Point(549, 161);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(158, 42);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Aqua;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.Location = new System.Drawing.Point(549, 216);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(158, 42);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.islemNo,
            this.Firma_vergiNo,
            this.Firma_Ad,
            this.Ürün_Barkod,
            this.Ürün_Kod,
            this.Ürün_Ad,
            this.Birim,
            this.Alınan_Adet,
            this.Alış_Fiyatı,
            this.Toplam_Tutar,
            this.Tarih});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 303);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(968, 226);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // islemNo
            // 
            this.islemNo.Text = "İşlem No";
            // 
            // Firma_vergiNo
            // 
            this.Firma_vergiNo.Text = "Firma Vergi No";
            this.Firma_vergiNo.Width = 100;
            // 
            // Firma_Ad
            // 
            this.Firma_Ad.Text = "Firma Ad";
            // 
            // Ürün_Barkod
            // 
            this.Ürün_Barkod.Text = "Ürün Barkod";
            this.Ürün_Barkod.Width = 80;
            // 
            // Ürün_Kod
            // 
            this.Ürün_Kod.Text = "Ürün Kod";
            // 
            // Ürün_Ad
            // 
            this.Ürün_Ad.Text = "Ürün Ad";
            // 
            // Birim
            // 
            this.Birim.Text = "Birim";
            // 
            // Alınan_Adet
            // 
            this.Alınan_Adet.Text = "Adet";
            this.Alınan_Adet.Width = 38;
            // 
            // Alış_Fiyatı
            // 
            this.Alış_Fiyatı.Text = "Birim Fiyat";
            this.Alış_Fiyatı.Width = 118;
            // 
            // Toplam_Tutar
            // 
            this.Toplam_Tutar.Text = "Toplam Tutar";
            this.Toplam_Tutar.Width = 114;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 121;
            // 
            // btn_alisTamamla
            // 
            this.btn_alisTamamla.BackColor = System.Drawing.Color.Tomato;
            this.btn_alisTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alisTamamla.ForeColor = System.Drawing.Color.Black;
            this.btn_alisTamamla.Location = new System.Drawing.Point(716, 42);
            this.btn_alisTamamla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_alisTamamla.Name = "btn_alisTamamla";
            this.btn_alisTamamla.Size = new System.Drawing.Size(109, 216);
            this.btn_alisTamamla.TabIndex = 6;
            this.btn_alisTamamla.Text = "ALIŞI TAMAMLA";
            this.btn_alisTamamla.UseVisualStyleBackColor = false;
            this.btn_alisTamamla.Click += new System.EventHandler(this.btn_alisTamamla_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(942, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseMove);
            // 
            // sayac
            // 
            this.sayac.Enabled = true;
            this.sayac.Interval = 1000;
            this.sayac.Tick += new System.EventHandler(this.sayac_Tick_1);
            // 
            // gb_fiyat
            // 
            this.gb_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.gb_fiyat.Controls.Add(this.label2);
            this.gb_fiyat.Controls.Add(this.lbl_toplam1);
            this.gb_fiyat.Controls.Add(this.lbl_toplam);
            this.gb_fiyat.Controls.Add(this.lbl_cizgi);
            this.gb_fiyat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_fiyat.ForeColor = System.Drawing.Color.White;
            this.gb_fiyat.Location = new System.Drawing.Point(829, 38);
            this.gb_fiyat.Margin = new System.Windows.Forms.Padding(2);
            this.gb_fiyat.Name = "gb_fiyat";
            this.gb_fiyat.Padding = new System.Windows.Forms.Padding(2);
            this.gb_fiyat.Size = new System.Drawing.Size(148, 218);
            this.gb_fiyat.TabIndex = 12;
            this.gb_fiyat.TabStop = false;
            this.gb_fiyat.Text = "TUTAR İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "TL";
            // 
            // lbl_toplam1
            // 
            this.lbl_toplam1.AutoSize = true;
            this.lbl_toplam1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam1.Location = new System.Drawing.Point(34, 159);
            this.lbl_toplam1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam1.Name = "lbl_toplam1";
            this.lbl_toplam1.Size = new System.Drawing.Size(85, 31);
            this.lbl_toplam1.TabIndex = 6;
            this.lbl_toplam1.Text = "TPYZ";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(7, 46);
            this.lbl_toplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(132, 31);
            this.lbl_toplam.TabIndex = 5;
            this.lbl_toplam.Text = "TOPLAM";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(868, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseMove);
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
            // form_alis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_fiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alisTamamla);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.gb_fatura);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_alis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN ALIŞ";
            this.Load += new System.EventHandler(this.form_fatura_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_alis_MouseMove);
            this.gb_fatura.ResumeLayout(false);
            this.gb_fatura.PerformLayout();
            this.gb_fiyat.ResumeLayout(false);
            this.gb_fiyat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_fatura;
        private System.Windows.Forms.TextBox tb_auad;
        private System.Windows.Forms.TextBox tb_ubarkod;
        private System.Windows.Forms.Label lbl_afirma;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label lbl_atarih;
        private System.Windows.Forms.Label lbl_fuad;
        private System.Windows.Forms.Label lbl_fuBarkod;
        private System.Windows.Forms.TextBox tb_fvergiNo;
        private System.Windows.Forms.Label lbl_fvergiNo;
        private System.Windows.Forms.TextBox tb_alısfiyat;
        private System.Windows.Forms.TextBox tb_adet;
        private System.Windows.Forms.TextBox tb_afad;
        private System.Windows.Forms.Label lbl_atutar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ürün_Barkod;
        private System.Windows.Forms.ColumnHeader Firma_vergiNo;
        private System.Windows.Forms.ColumnHeader Alınan_Adet;
        private System.Windows.Forms.ColumnHeader Birim;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Alış_Fiyatı;
        private System.Windows.Forms.ColumnHeader Toplam_Tutar;
        private System.Windows.Forms.Button btn_alisTamamla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader islemNo;
        private System.Windows.Forms.ColumnHeader Firma_Ad;
        private System.Windows.Forms.ColumnHeader Ürün_Ad;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.GroupBox gb_fiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_toplam1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label lbl_cizgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Ürün_Kod;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

