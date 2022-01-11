namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class CovidMark_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidMark_Login));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.tb_kadi = new System.Windows.Forms.TextBox();
            this.tb_parola = new System.Windows.Forms.TextBox();
            this.lbl_kadiicon = new System.Windows.Forms.Label();
            this.lbl_pasicon = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_logo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_logo.Image")));
            this.lbl_logo.Location = new System.Drawing.Point(166, 27);
            this.lbl_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(289, 131);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseDown);
            this.lbl_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseMove);
            // 
            // tb_kadi
            // 
            this.tb_kadi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kadi.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_kadi.Location = new System.Drawing.Point(227, 170);
            this.tb_kadi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kadi.MaxLength = 4;
            this.tb_kadi.Multiline = true;
            this.tb_kadi.Name = "tb_kadi";
            this.tb_kadi.Size = new System.Drawing.Size(164, 28);
            this.tb_kadi.TabIndex = 10;
            this.tb_kadi.Text = "Kullanıcı Adı";
            this.tb_kadi.Enter += new System.EventHandler(this.tb_Enter);
            // 
            // tb_parola
            // 
            this.tb_parola.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_parola.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_parola.Location = new System.Drawing.Point(227, 211);
            this.tb_parola.Margin = new System.Windows.Forms.Padding(2);
            this.tb_parola.MaxLength = 4;
            this.tb_parola.Multiline = true;
            this.tb_parola.Name = "tb_parola";
            this.tb_parola.PasswordChar = '*';
            this.tb_parola.Size = new System.Drawing.Size(164, 28);
            this.tb_parola.TabIndex = 11;
            this.tb_parola.Text = "Şifre";
            this.tb_parola.Enter += new System.EventHandler(this.tb_Enter);
            // 
            // lbl_kadiicon
            // 
            this.lbl_kadiicon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kadiicon.Image = ((System.Drawing.Image)(resources.GetObject("lbl_kadiicon.Image")));
            this.lbl_kadiicon.Location = new System.Drawing.Point(182, 158);
            this.lbl_kadiicon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kadiicon.Name = "lbl_kadiicon";
            this.lbl_kadiicon.Size = new System.Drawing.Size(40, 39);
            this.lbl_kadiicon.TabIndex = 5;
            // 
            // lbl_pasicon
            // 
            this.lbl_pasicon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pasicon.Image = ((System.Drawing.Image)(resources.GetObject("lbl_pasicon.Image")));
            this.lbl_pasicon.Location = new System.Drawing.Point(180, 204);
            this.lbl_pasicon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pasicon.Name = "lbl_pasicon";
            this.lbl_pasicon.Size = new System.Drawing.Size(43, 34);
            this.lbl_pasicon.TabIndex = 6;
            this.lbl_pasicon.Click += new System.EventHandler(this.lbl_pasicon_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Green;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_giris.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(227, 250);
            this.btn_giris.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(164, 24);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseMnemonic = false;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(227, 279);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(164, 24);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "TEMİZLE";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Red;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(227, 307);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(164, 24);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(554, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "v0.80";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseMove);
            // 
            // CovidMark_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.lbl_pasicon);
            this.Controls.Add(this.lbl_kadiicon);
            this.Controls.Add(this.tb_parola);
            this.Controls.Add(this.tb_kadi);
            this.Controls.Add(this.lbl_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CovidMark_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVIDMARK ALISVERIS PROGRAMI";
            this.Load += new System.EventHandler(this.CovidMark_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CovidMark_Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.TextBox tb_kadi;
        private System.Windows.Forms.Label lbl_kadiicon;
        private System.Windows.Forms.Label lbl_pasicon;
        public System.Windows.Forms.TextBox tb_parola;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label4;
    }
}

