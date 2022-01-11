namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_stok));
            this.lv_liste = new System.Windows.Forms.ListView();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.cm_tur = new System.Windows.Forms.ComboBox();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.tb_deger = new System.Windows.Forms.TextBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.gb_arama = new System.Windows.Forms.GroupBox();
            this.rb_satilan = new System.Windows.Forms.RadioButton();
            this.rb_alınan = new System.Windows.Forms.RadioButton();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_liste
            // 
            this.lv_liste.FullRowSelect = true;
            this.lv_liste.GridLines = true;
            this.lv_liste.HideSelection = false;
            this.lv_liste.Location = new System.Drawing.Point(9, 157);
            this.lv_liste.Margin = new System.Windows.Forms.Padding(2);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(748, 304);
            this.lv_liste.TabIndex = 0;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            // 
            // lbl_tur
            // 
            this.lbl_tur.AutoSize = true;
            this.lbl_tur.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tur.ForeColor = System.Drawing.Color.White;
            this.lbl_tur.Location = new System.Drawing.Point(4, 64);
            this.lbl_tur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tur.Name = "lbl_tur";
            this.lbl_tur.Size = new System.Drawing.Size(161, 19);
            this.lbl_tur.TabIndex = 1;
            this.lbl_tur.Text = "Arama Türünü Seçiniz:";
            // 
            // cm_tur
            // 
            this.cm_tur.Enabled = false;
            this.cm_tur.FormattingEnabled = true;
            this.cm_tur.Items.AddRange(new object[] {
            "Arama Türünü Seçin....",
            "Vergi No",
            "Personel No",
            "Ürün Barkod"});
            this.cm_tur.Location = new System.Drawing.Point(165, 61);
            this.cm_tur.Margin = new System.Windows.Forms.Padding(2);
            this.cm_tur.Name = "cm_tur";
            this.cm_tur.Size = new System.Drawing.Size(151, 25);
            this.cm_tur.TabIndex = 2;
            this.cm_tur.SelectedIndexChanged += new System.EventHandler(this.cm_tur_SelectedIndexChanged);
            // 
            // lbl_deger
            // 
            this.lbl_deger.AutoSize = true;
            this.lbl_deger.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deger.ForeColor = System.Drawing.Color.White;
            this.lbl_deger.Location = new System.Drawing.Point(61, 100);
            this.lbl_deger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(104, 19);
            this.lbl_deger.TabIndex = 3;
            this.lbl_deger.Text = "Değer Giriniz:";
            // 
            // tb_deger
            // 
            this.tb_deger.Enabled = false;
            this.tb_deger.Location = new System.Drawing.Point(165, 97);
            this.tb_deger.Margin = new System.Windows.Forms.Padding(2);
            this.tb_deger.MaxLength = 10;
            this.tb_deger.Multiline = true;
            this.tb_deger.Name = "tb_deger";
            this.tb_deger.Size = new System.Drawing.Size(151, 23);
            this.tb_deger.TabIndex = 4;
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.Blue;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_list.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.Location = new System.Drawing.Point(398, 52);
            this.btn_list.Margin = new System.Windows.Forms.Padding(2);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(124, 63);
            this.btn_list.TabIndex = 5;
            this.btn_list.Text = "LİSTELE";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Orange;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(527, 52);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(124, 63);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.Aqua;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainmenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainmenu.Location = new System.Drawing.Point(655, 52);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(124, 63);
            this.btn_mainmenu.TabIndex = 7;
            this.btn_mainmenu.Text = "ANA MENÜYE DÖN";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // gb_arama
            // 
            this.gb_arama.BackColor = System.Drawing.Color.Transparent;
            this.gb_arama.Controls.Add(this.rb_satilan);
            this.gb_arama.Controls.Add(this.rb_alınan);
            this.gb_arama.Controls.Add(this.lbl_urun);
            this.gb_arama.Controls.Add(this.lbl_deger);
            this.gb_arama.Controls.Add(this.lbl_tur);
            this.gb_arama.Controls.Add(this.cm_tur);
            this.gb_arama.Controls.Add(this.tb_deger);
            this.gb_arama.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_arama.ForeColor = System.Drawing.Color.White;
            this.gb_arama.Location = new System.Drawing.Point(9, 10);
            this.gb_arama.Margin = new System.Windows.Forms.Padding(2);
            this.gb_arama.Name = "gb_arama";
            this.gb_arama.Padding = new System.Windows.Forms.Padding(2);
            this.gb_arama.Size = new System.Drawing.Size(376, 132);
            this.gb_arama.TabIndex = 8;
            this.gb_arama.TabStop = false;
            this.gb_arama.Text = "Arama İşlemleri";
            // 
            // rb_satilan
            // 
            this.rb_satilan.AutoSize = true;
            this.rb_satilan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_satilan.Location = new System.Drawing.Point(269, 29);
            this.rb_satilan.Margin = new System.Windows.Forms.Padding(2);
            this.rb_satilan.Name = "rb_satilan";
            this.rb_satilan.Size = new System.Drawing.Size(110, 23);
            this.rb_satilan.TabIndex = 7;
            this.rb_satilan.TabStop = true;
            this.rb_satilan.Text = "Satılan Ürün";
            this.rb_satilan.UseVisualStyleBackColor = true;
            this.rb_satilan.CheckedChanged += new System.EventHandler(this.rb_sat_CheckedChanged);
            // 
            // rb_alınan
            // 
            this.rb_alınan.AutoSize = true;
            this.rb_alınan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_alınan.Location = new System.Drawing.Point(158, 29);
            this.rb_alınan.Margin = new System.Windows.Forms.Padding(2);
            this.rb_alınan.Name = "rb_alınan";
            this.rb_alınan.Size = new System.Drawing.Size(107, 23);
            this.rb_alınan.TabIndex = 6;
            this.rb_alınan.TabStop = true;
            this.rb_alınan.Text = "Alınan Ürün";
            this.rb_alınan.UseVisualStyleBackColor = true;
            this.rb_alınan.CheckedChanged += new System.EventHandler(this.rb_alınan_CheckedChanged);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urun.Location = new System.Drawing.Point(61, 28);
            this.lbl_urun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(97, 19);
            this.lbl_urun.TabIndex = 5;
            this.lbl_urun.Text = "Ürün Seçiniz:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(729, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(655, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseMove);
            // 
            // form_stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_arama);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.lv_liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK HAREKETLERİ";
            this.Load += new System.EventHandler(this.form_stok_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_stok_MouseMove);
            this.gb_arama.ResumeLayout(false);
            this.gb_arama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_liste;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.ComboBox cm_tur;
        private System.Windows.Forms.Label lbl_deger;
        private System.Windows.Forms.TextBox tb_deger;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.GroupBox gb_arama;
        private System.Windows.Forms.RadioButton rb_satilan;
        private System.Windows.Forms.RadioButton rb_alınan;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

