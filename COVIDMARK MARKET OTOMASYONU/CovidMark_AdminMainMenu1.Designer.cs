namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_adminMainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_adminMainmenu));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_firma = new System.Windows.Forms.Button();
            this.btn_alis = new System.Windows.Forms.Button();
            this.btn_personel = new System.Windows.Forms.Button();
            this.btn_stok = new System.Windows.Forms.Button();
            this.btn_kategori = new System.Windows.Forms.Button();
            this.btn_satis = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fatura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo.Image")));
            this.lbl_logo.Location = new System.Drawing.Point(626, 258);
            this.lbl_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(300, 187);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseDown);
            this.lbl_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseMove);
            // 
            // btn_urun
            // 
            this.btn_urun.BackColor = System.Drawing.Color.Orange;
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urun.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_urun.Location = new System.Drawing.Point(38, 50);
            this.btn_urun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(158, 75);
            this.btn_urun.TabIndex = 1;
            this.btn_urun.Text = "ÜRÜNLER";
            this.btn_urun.UseVisualStyleBackColor = false;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_firma
            // 
            this.btn_firma.BackColor = System.Drawing.Color.Yellow;
            this.btn_firma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_firma.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_firma.Location = new System.Drawing.Point(229, 50);
            this.btn_firma.Margin = new System.Windows.Forms.Padding(2);
            this.btn_firma.Name = "btn_firma";
            this.btn_firma.Size = new System.Drawing.Size(158, 75);
            this.btn_firma.TabIndex = 2;
            this.btn_firma.Text = "FİRMALAR";
            this.btn_firma.UseVisualStyleBackColor = false;
            this.btn_firma.Click += new System.EventHandler(this.btn_firma_Click);
            // 
            // btn_alis
            // 
            this.btn_alis.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_alis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alis.Location = new System.Drawing.Point(412, 50);
            this.btn_alis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_alis.Name = "btn_alis";
            this.btn_alis.Size = new System.Drawing.Size(158, 75);
            this.btn_alis.TabIndex = 3;
            this.btn_alis.Text = "ÜRÜN ALIŞ";
            this.btn_alis.UseVisualStyleBackColor = false;
            this.btn_alis.Click += new System.EventHandler(this.btn_alis_Click);
            // 
            // btn_personel
            // 
            this.btn_personel.BackColor = System.Drawing.Color.Blue;
            this.btn_personel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_personel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_personel.Location = new System.Drawing.Point(229, 164);
            this.btn_personel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.Size = new System.Drawing.Size(158, 75);
            this.btn_personel.TabIndex = 4;
            this.btn_personel.Text = "PERSONEL";
            this.btn_personel.UseVisualStyleBackColor = false;
            this.btn_personel.Click += new System.EventHandler(this.btn_personel_Click);
            // 
            // btn_stok
            // 
            this.btn_stok.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_stok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stok.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_stok.Location = new System.Drawing.Point(38, 164);
            this.btn_stok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.Size = new System.Drawing.Size(158, 75);
            this.btn_stok.TabIndex = 5;
            this.btn_stok.Text = "STOK HAREKETLERİ";
            this.btn_stok.UseVisualStyleBackColor = false;
            this.btn_stok.Click += new System.EventHandler(this.btn_stok_Click);
            // 
            // btn_kategori
            // 
            this.btn_kategori.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_kategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kategori.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategori.Location = new System.Drawing.Point(412, 164);
            this.btn_kategori.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kategori.Name = "btn_kategori";
            this.btn_kategori.Size = new System.Drawing.Size(158, 75);
            this.btn_kategori.TabIndex = 6;
            this.btn_kategori.Text = "KATEGORİLER";
            this.btn_kategori.UseVisualStyleBackColor = false;
            this.btn_kategori.Click += new System.EventHandler(this.btn_kategori_Click);
            // 
            // btn_satis
            // 
            this.btn_satis.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_satis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_satis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satis.Location = new System.Drawing.Point(38, 258);
            this.btn_satis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(158, 75);
            this.btn_satis.TabIndex = 7;
            this.btn_satis.Text = "SATIŞ EKRANI";
            this.btn_satis.UseVisualStyleBackColor = false;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Red;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(412, 258);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(158, 75);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(915, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(844, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseMove);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(916, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "v0.80";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseMove);
            // 
            // btn_fatura
            // 
            this.btn_fatura.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_fatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fatura.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fatura.Location = new System.Drawing.Point(229, 258);
            this.btn_fatura.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fatura.Name = "btn_fatura";
            this.btn_fatura.Size = new System.Drawing.Size(158, 75);
            this.btn_fatura.TabIndex = 13;
            this.btn_fatura.Text = "FATURALAR";
            this.btn_fatura.UseVisualStyleBackColor = false;
            this.btn_fatura.Click += new System.EventHandler(this.btn_fatura_Click);
            // 
            // form_adminMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.btn_fatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.btn_kategori);
            this.Controls.Add(this.btn_stok);
            this.Controls.Add(this.btn_personel);
            this.Controls.Add(this.btn_alis);
            this.Controls.Add(this.btn_firma);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.lbl_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_adminMainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVIDMARK ALISVERIS PROGRAMI";
            this.Load += new System.EventHandler(this.form_adminMainmenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_adminMainmenu_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_firma;
        private System.Windows.Forms.Button btn_alis;
        private System.Windows.Forms.Button btn_personel;
        private System.Windows.Forms.Button btn_stok;
        private System.Windows.Forms.Button btn_kategori;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_fatura;
    }
}

