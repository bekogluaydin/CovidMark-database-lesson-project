namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_kategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_kategori));
            this.gb_kategori = new System.Windows.Forms.GroupBox();
            this.btn_ksil = new System.Windows.Forms.Button();
            this.btn_kekle = new System.Windows.Forms.Button();
            this.cb_vergi = new System.Windows.Forms.ComboBox();
            this.tb_katkod = new System.Windows.Forms.TextBox();
            this.tb_kad = new System.Windows.Forms.TextBox();
            this.lbl_vergi = new System.Windows.Forms.Label();
            this.lbl_katkod = new System.Windows.Forms.Label();
            this.lbl_kad = new System.Windows.Forms.Label();
            this.gb_altkat = new System.Windows.Forms.GroupBox();
            this.cb_altkadkod = new System.Windows.Forms.ComboBox();
            this.btn_altsil = new System.Windows.Forms.Button();
            this.btn_altkolustur = new System.Windows.Forms.Button();
            this.tb_altkad = new System.Windows.Forms.TextBox();
            this.lbl_altkkod = new System.Windows.Forms.Label();
            this.lbl_altkad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ktemizle = new System.Windows.Forms.Button();
            this.lv_kategori = new System.Windows.Forms.ListView();
            this.Kategori_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KategoriKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KategoriAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VergiOranı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_altKategori = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.katAltAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alt_katKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_kategori.SuspendLayout();
            this.gb_altkat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_kategori
            // 
            this.gb_kategori.BackColor = System.Drawing.Color.Transparent;
            this.gb_kategori.Controls.Add(this.btn_ksil);
            this.gb_kategori.Controls.Add(this.btn_kekle);
            this.gb_kategori.Controls.Add(this.cb_vergi);
            this.gb_kategori.Controls.Add(this.tb_katkod);
            this.gb_kategori.Controls.Add(this.tb_kad);
            this.gb_kategori.Controls.Add(this.lbl_vergi);
            this.gb_kategori.Controls.Add(this.lbl_katkod);
            this.gb_kategori.Controls.Add(this.lbl_kad);
            this.gb_kategori.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_kategori.ForeColor = System.Drawing.Color.White;
            this.gb_kategori.Location = new System.Drawing.Point(9, 35);
            this.gb_kategori.Margin = new System.Windows.Forms.Padding(2);
            this.gb_kategori.Name = "gb_kategori";
            this.gb_kategori.Padding = new System.Windows.Forms.Padding(2);
            this.gb_kategori.Size = new System.Drawing.Size(449, 143);
            this.gb_kategori.TabIndex = 0;
            this.gb_kategori.TabStop = false;
            this.gb_kategori.Text = "Kategori İşlemleri";
            // 
            // btn_ksil
            // 
            this.btn_ksil.BackColor = System.Drawing.Color.Red;
            this.btn_ksil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ksil.ForeColor = System.Drawing.Color.Black;
            this.btn_ksil.Location = new System.Drawing.Point(273, 84);
            this.btn_ksil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ksil.Name = "btn_ksil";
            this.btn_ksil.Size = new System.Drawing.Size(158, 42);
            this.btn_ksil.TabIndex = 7;
            this.btn_ksil.Text = "KATEGORİ SİL";
            this.btn_ksil.UseVisualStyleBackColor = false;
            this.btn_ksil.Click += new System.EventHandler(this.btn_ksil_Click);
            // 
            // btn_kekle
            // 
            this.btn_kekle.BackColor = System.Drawing.Color.Green;
            this.btn_kekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kekle.ForeColor = System.Drawing.Color.Black;
            this.btn_kekle.Location = new System.Drawing.Point(273, 30);
            this.btn_kekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kekle.Name = "btn_kekle";
            this.btn_kekle.Size = new System.Drawing.Size(158, 42);
            this.btn_kekle.TabIndex = 6;
            this.btn_kekle.Text = "KATEGORİ OLUŞTUR";
            this.btn_kekle.UseVisualStyleBackColor = false;
            this.btn_kekle.Click += new System.EventHandler(this.btn_kekle_Click);
            // 
            // cb_vergi
            // 
            this.cb_vergi.FormattingEnabled = true;
            this.cb_vergi.Items.AddRange(new object[] {
            "Oran Seç...",
            "3",
            "8",
            "10",
            "16",
            "18"});
            this.cb_vergi.Location = new System.Drawing.Point(105, 105);
            this.cb_vergi.Margin = new System.Windows.Forms.Padding(2);
            this.cb_vergi.Name = "cb_vergi";
            this.cb_vergi.Size = new System.Drawing.Size(110, 25);
            this.cb_vergi.TabIndex = 5;
            // 
            // tb_katkod
            // 
            this.tb_katkod.Location = new System.Drawing.Point(105, 30);
            this.tb_katkod.Margin = new System.Windows.Forms.Padding(2);
            this.tb_katkod.MaxLength = 10;
            this.tb_katkod.Name = "tb_katkod";
            this.tb_katkod.Size = new System.Drawing.Size(110, 23);
            this.tb_katkod.TabIndex = 4;
            // 
            // tb_kad
            // 
            this.tb_kad.Location = new System.Drawing.Point(105, 67);
            this.tb_kad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kad.MaxLength = 30;
            this.tb_kad.Name = "tb_kad";
            this.tb_kad.Size = new System.Drawing.Size(110, 23);
            this.tb_kad.TabIndex = 3;
            // 
            // lbl_vergi
            // 
            this.lbl_vergi.AutoSize = true;
            this.lbl_vergi.Location = new System.Drawing.Point(4, 105);
            this.lbl_vergi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vergi.Name = "lbl_vergi";
            this.lbl_vergi.Size = new System.Drawing.Size(86, 17);
            this.lbl_vergi.TabIndex = 2;
            this.lbl_vergi.Text = "Vergi Oranı:";
            // 
            // lbl_katkod
            // 
            this.lbl_katkod.AutoSize = true;
            this.lbl_katkod.Location = new System.Drawing.Point(5, 30);
            this.lbl_katkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_katkod.Name = "lbl_katkod";
            this.lbl_katkod.Size = new System.Drawing.Size(94, 17);
            this.lbl_katkod.TabIndex = 1;
            this.lbl_katkod.Text = "Kategori Kod:";
            // 
            // lbl_kad
            // 
            this.lbl_kad.AutoSize = true;
            this.lbl_kad.Location = new System.Drawing.Point(5, 70);
            this.lbl_kad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kad.Name = "lbl_kad";
            this.lbl_kad.Size = new System.Drawing.Size(86, 17);
            this.lbl_kad.TabIndex = 0;
            this.lbl_kad.Text = "Kategori Ad:";
            // 
            // gb_altkat
            // 
            this.gb_altkat.BackColor = System.Drawing.Color.Transparent;
            this.gb_altkat.Controls.Add(this.cb_altkadkod);
            this.gb_altkat.Controls.Add(this.btn_altsil);
            this.gb_altkat.Controls.Add(this.btn_altkolustur);
            this.gb_altkat.Controls.Add(this.tb_altkad);
            this.gb_altkat.Controls.Add(this.lbl_altkkod);
            this.gb_altkat.Controls.Add(this.lbl_altkad);
            this.gb_altkat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_altkat.ForeColor = System.Drawing.Color.White;
            this.gb_altkat.Location = new System.Drawing.Point(9, 197);
            this.gb_altkat.Margin = new System.Windows.Forms.Padding(2);
            this.gb_altkat.Name = "gb_altkat";
            this.gb_altkat.Padding = new System.Windows.Forms.Padding(2);
            this.gb_altkat.Size = new System.Drawing.Size(449, 145);
            this.gb_altkat.TabIndex = 1;
            this.gb_altkat.TabStop = false;
            this.gb_altkat.Text = "Alt Kategori İşlemleri";
            // 
            // cb_altkadkod
            // 
            this.cb_altkadkod.FormattingEnabled = true;
            this.cb_altkadkod.Location = new System.Drawing.Point(134, 43);
            this.cb_altkadkod.Margin = new System.Windows.Forms.Padding(2);
            this.cb_altkadkod.Name = "cb_altkadkod";
            this.cb_altkadkod.Size = new System.Drawing.Size(110, 25);
            this.cb_altkadkod.TabIndex = 8;
            this.cb_altkadkod.SelectedIndexChanged += new System.EventHandler(this.cb_altkadkod_SelectedIndexChanged);
            // 
            // btn_altsil
            // 
            this.btn_altsil.BackColor = System.Drawing.Color.Red;
            this.btn_altsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_altsil.ForeColor = System.Drawing.Color.Black;
            this.btn_altsil.Location = new System.Drawing.Point(284, 89);
            this.btn_altsil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_altsil.Name = "btn_altsil";
            this.btn_altsil.Size = new System.Drawing.Size(158, 42);
            this.btn_altsil.TabIndex = 5;
            this.btn_altsil.Text = "ALT KATEGORİ SİL";
            this.btn_altsil.UseVisualStyleBackColor = false;
            this.btn_altsil.Click += new System.EventHandler(this.btn_altsil_Click);
            // 
            // btn_altkolustur
            // 
            this.btn_altkolustur.BackColor = System.Drawing.Color.Green;
            this.btn_altkolustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_altkolustur.ForeColor = System.Drawing.Color.Black;
            this.btn_altkolustur.Location = new System.Drawing.Point(284, 32);
            this.btn_altkolustur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_altkolustur.Name = "btn_altkolustur";
            this.btn_altkolustur.Size = new System.Drawing.Size(158, 42);
            this.btn_altkolustur.TabIndex = 4;
            this.btn_altkolustur.Text = "ALT KATEGORİ OLUŞTUR";
            this.btn_altkolustur.UseVisualStyleBackColor = false;
            this.btn_altkolustur.Click += new System.EventHandler(this.btn_altkolustur_Click);
            // 
            // tb_altkad
            // 
            this.tb_altkad.Enabled = false;
            this.tb_altkad.Location = new System.Drawing.Point(135, 85);
            this.tb_altkad.Margin = new System.Windows.Forms.Padding(2);
            this.tb_altkad.MaxLength = 20;
            this.tb_altkad.Name = "tb_altkad";
            this.tb_altkad.Size = new System.Drawing.Size(109, 23);
            this.tb_altkad.TabIndex = 2;
            // 
            // lbl_altkkod
            // 
            this.lbl_altkkod.AutoSize = true;
            this.lbl_altkkod.Location = new System.Drawing.Point(11, 43);
            this.lbl_altkkod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_altkkod.Name = "lbl_altkkod";
            this.lbl_altkkod.Size = new System.Drawing.Size(106, 17);
            this.lbl_altkkod.TabIndex = 1;
            this.lbl_altkkod.Text = "Kategori  Kodu:";
            this.lbl_altkkod.Click += new System.EventHandler(this.lbl_altkkod_Click);
            // 
            // lbl_altkad
            // 
            this.lbl_altkad.AutoSize = true;
            this.lbl_altkad.Location = new System.Drawing.Point(8, 89);
            this.lbl_altkad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_altkad.Name = "lbl_altkad";
            this.lbl_altkad.Size = new System.Drawing.Size(109, 17);
            this.lbl_altkad.TabIndex = 0;
            this.lbl_altkad.Text = "Alt Kategori Ad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(9, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "ANA MENÜYE DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ktemizle
            // 
            this.btn_ktemizle.BackColor = System.Drawing.Color.Blue;
            this.btn_ktemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ktemizle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ktemizle.Location = new System.Drawing.Point(254, 357);
            this.btn_ktemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ktemizle.Name = "btn_ktemizle";
            this.btn_ktemizle.Size = new System.Drawing.Size(158, 42);
            this.btn_ktemizle.TabIndex = 3;
            this.btn_ktemizle.Text = "TEMİZLE";
            this.btn_ktemizle.UseVisualStyleBackColor = false;
            this.btn_ktemizle.Click += new System.EventHandler(this.btn_ktemizle_Click);
            // 
            // lv_kategori
            // 
            this.lv_kategori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kategori_id,
            this.KategoriKod,
            this.KategoriAd,
            this.VergiOranı});
            this.lv_kategori.FullRowSelect = true;
            this.lv_kategori.GridLines = true;
            this.lv_kategori.HideSelection = false;
            this.lv_kategori.Location = new System.Drawing.Point(485, 43);
            this.lv_kategori.Margin = new System.Windows.Forms.Padding(2);
            this.lv_kategori.Name = "lv_kategori";
            this.lv_kategori.Size = new System.Drawing.Size(356, 152);
            this.lv_kategori.TabIndex = 4;
            this.lv_kategori.UseCompatibleStateImageBehavior = false;
            this.lv_kategori.View = System.Windows.Forms.View.Details;
            this.lv_kategori.SelectedIndexChanged += new System.EventHandler(this.lv_kategori_SelectedIndexChanged);
            // 
            // Kategori_id
            // 
            this.Kategori_id.Text = "Kategori ID";
            this.Kategori_id.Width = 85;
            // 
            // KategoriKod
            // 
            this.KategoriKod.Text = "Kategori Kod";
            this.KategoriKod.Width = 91;
            // 
            // KategoriAd
            // 
            this.KategoriAd.Text = "Kategori Ad";
            this.KategoriAd.Width = 91;
            // 
            // VergiOranı
            // 
            this.VergiOranı.Text = "Vergi Oranı";
            this.VergiOranı.Width = 86;
            // 
            // lv_altKategori
            // 
            this.lv_altKategori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.katAltAd,
            this.alt_katKod});
            this.lv_altKategori.FullRowSelect = true;
            this.lv_altKategori.GridLines = true;
            this.lv_altKategori.HideSelection = false;
            this.lv_altKategori.Location = new System.Drawing.Point(482, 227);
            this.lv_altKategori.Margin = new System.Windows.Forms.Padding(2);
            this.lv_altKategori.Name = "lv_altKategori";
            this.lv_altKategori.Size = new System.Drawing.Size(356, 152);
            this.lv_altKategori.TabIndex = 5;
            this.lv_altKategori.UseCompatibleStateImageBehavior = false;
            this.lv_altKategori.View = System.Windows.Forms.View.Details;
            this.lv_altKategori.SelectedIndexChanged += new System.EventHandler(this.lv_altKategori_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Alt Kategori ID";
            this.id.Width = 85;
            // 
            // katAltAd
            // 
            this.katAltAd.Text = "Alt Kategori Ad";
            this.katAltAd.Width = 91;
            // 
            // alt_katKod
            // 
            this.alt_katKod.Text = "Kategori Kod";
            this.alt_katKod.Width = 91;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(802, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(728, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseMove);
            // 
            // form_kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_altKategori);
            this.Controls.Add(this.lv_kategori);
            this.Controls.Add(this.btn_ktemizle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_altkat);
            this.Controls.Add(this.gb_kategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KATEGORİLER";
            this.Load += new System.EventHandler(this.form_kategori_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_kategori_MouseMove);
            this.gb_kategori.ResumeLayout(false);
            this.gb_kategori.PerformLayout();
            this.gb_altkat.ResumeLayout(false);
            this.gb_altkat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_kategori;
        private System.Windows.Forms.Button btn_ksil;
        private System.Windows.Forms.Button btn_kekle;
        private System.Windows.Forms.ComboBox cb_vergi;
        private System.Windows.Forms.TextBox tb_kad;
        private System.Windows.Forms.Label lbl_vergi;
        private System.Windows.Forms.Label lbl_katkod;
        private System.Windows.Forms.Label lbl_kad;
        private System.Windows.Forms.GroupBox gb_altkat;
        private System.Windows.Forms.Button btn_altsil;
        private System.Windows.Forms.Button btn_altkolustur;
        private System.Windows.Forms.TextBox tb_altkad;
        private System.Windows.Forms.Label lbl_altkkod;
        private System.Windows.Forms.Label lbl_altkad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ktemizle;
        private System.Windows.Forms.ListView lv_kategori;
        private System.Windows.Forms.ColumnHeader Kategori_id;
        private System.Windows.Forms.ColumnHeader KategoriAd;
        private System.Windows.Forms.ColumnHeader KategoriKod;
        private System.Windows.Forms.ColumnHeader VergiOranı;
        private System.Windows.Forms.ListView lv_altKategori;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader katAltAd;
        private System.Windows.Forms.ColumnHeader alt_katKod;
        private System.Windows.Forms.ComboBox cb_altkadkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_katkod;
        private System.Windows.Forms.Label label3;
    }
}

