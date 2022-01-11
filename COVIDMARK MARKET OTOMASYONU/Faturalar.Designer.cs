namespace COVIDMARK_MARKET_OTOMASYONU
{
    partial class form_Faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Faturalar));
            this.lv_liste = new System.Windows.Forms.ListView();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.lbl_tur = new System.Windows.Forms.Label();
            this.cm_tur = new System.Windows.Forms.ComboBox();
            this.tb_deger = new System.Windows.Forms.TextBox();
            this.gb_arama = new System.Windows.Forms.GroupBox();
            this.rb_satilan = new System.Windows.Forms.RadioButton();
            this.rb_alınan = new System.Windows.Forms.RadioButton();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.gb_arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_liste
            // 
            this.lv_liste.FullRowSelect = true;
            this.lv_liste.GridLines = true;
            this.lv_liste.HideSelection = false;
            this.lv_liste.Location = new System.Drawing.Point(15, 147);
            this.lv_liste.Margin = new System.Windows.Forms.Padding(2);
            this.lv_liste.Name = "lv_liste";
            this.lv_liste.Size = new System.Drawing.Size(886, 366);
            this.lv_liste.TabIndex = 13;
            this.lv_liste.UseCompatibleStateImageBehavior = false;
            this.lv_liste.View = System.Windows.Forms.View.Details;
            this.lv_liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_liste_MouseDoubleClick);
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
            this.cm_tur.Location = new System.Drawing.Point(165, 61);
            this.cm_tur.Margin = new System.Windows.Forms.Padding(2);
            this.cm_tur.Name = "cm_tur";
            this.cm_tur.Size = new System.Drawing.Size(151, 25);
            this.cm_tur.TabIndex = 2;
            this.cm_tur.SelectedIndexChanged += new System.EventHandler(this.cm_tur_SelectedIndexChanged);
            // 
            // tb_deger
            // 
            this.tb_deger.Enabled = false;
            this.tb_deger.Location = new System.Drawing.Point(165, 97);
            this.tb_deger.Margin = new System.Windows.Forms.Padding(2);
            this.tb_deger.Multiline = true;
            this.tb_deger.Name = "tb_deger";
            this.tb_deger.Size = new System.Drawing.Size(151, 23);
            this.tb_deger.TabIndex = 4;
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
            this.gb_arama.Location = new System.Drawing.Point(15, 0);
            this.gb_arama.Margin = new System.Windows.Forms.Padding(2);
            this.gb_arama.Name = "gb_arama";
            this.gb_arama.Padding = new System.Windows.Forms.Padding(2);
            this.gb_arama.Size = new System.Drawing.Size(376, 132);
            this.gb_arama.TabIndex = 17;
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
            this.rb_satilan.CheckedChanged += new System.EventHandler(this.rb_satilan_CheckedChanged);
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
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.Aqua;
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mainmenu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainmenu.Location = new System.Drawing.Point(661, 42);
            this.btn_mainmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(124, 63);
            this.btn_mainmenu.TabIndex = 16;
            this.btn_mainmenu.Text = "ANA MENÜYE DÖN";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_mainmenu_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Orange;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(533, 42);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(124, 63);
            this.btn_temizle.TabIndex = 15;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackColor = System.Drawing.Color.Blue;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_list.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list.Location = new System.Drawing.Point(404, 42);
            this.btn_list.Margin = new System.Windows.Forms.Padding(2);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(124, 63);
            this.btn_list.TabIndex = 14;
            this.btn_list.Text = "LİSTELE";
            this.btn_list.UseVisualStyleBackColor = false;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(792, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Personel No:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(866, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseMove);
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
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // form_Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 537);
            this.Controls.Add(this.lv_liste);
            this.Controls.Add(this.gb_arama);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Faturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.form_Faturalar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_Faturalar_MouseMove);
            this.gb_arama.ResumeLayout(false);
            this.gb_arama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_liste;
        private System.Windows.Forms.Label lbl_deger;
        private System.Windows.Forms.Label lbl_tur;
        private System.Windows.Forms.ComboBox cm_tur;
        private System.Windows.Forms.TextBox tb_deger;
        private System.Windows.Forms.GroupBox gb_arama;
        private System.Windows.Forms.RadioButton rb_satilan;
        private System.Windows.Forms.RadioButton rb_alınan;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
    }
}