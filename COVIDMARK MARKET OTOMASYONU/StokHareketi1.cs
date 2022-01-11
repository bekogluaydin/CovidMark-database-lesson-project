using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDMARK_MARKET_OTOMASYONU
{
    public partial class form_stok : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        int sorgu;
        string deger;

        public form_stok()
        {
            InitializeComponent();
        }

        private void cm_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_tur.SelectedIndex != 0) { tb_deger.Enabled = true; cm_tur.Enabled = true; }
            else { tb_deger.Enabled = false; tb_deger.Text = "";}
        }

        private void form_stok_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            cm_tur.SelectedIndex = 0;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            deger = tb_deger.Text;

            if (rb_alınan.Checked == true)
            {
                vt.stokAlısListele(lv_liste);

                if (tb_deger.Text != "")
                {                  
                    if(cm_tur.SelectedItem.ToString() == "Vergi No") { sorgu = 2; }
                    else if (cm_tur.SelectedItem.ToString() == "Personel No") { sorgu = 3; }
                    else if (cm_tur.SelectedItem.ToString() == "Ürün Barkod") { sorgu = 4; }

                    vt.stokAlısSorguListele(lv_liste, sorgu, deger);
                }
                else MessageBox.Show("Değer Kısmı Boş Olamaz");

            }

            else if (rb_satilan.Checked == true)
            {
                vt.stokSatısListele(lv_liste);

                if (tb_deger.Text != "")
                {
                    if (cm_tur.SelectedItem.ToString() == "Personel No") { sorgu = 2; }
                    else if (cm_tur.SelectedItem.ToString() == "Ürün Barkod") { sorgu = 3; }

                    vt.stokAlısSorguListele(lv_liste, sorgu, deger);
                }
                else MessageBox.Show("Değer Kısmı Boş Olamaz");
            }

            else
            {
                MessageBox.Show("Lütfen Bir Şeçim Yapın!");
            }
        }

        private void rb_alınan_CheckedChanged(object sender, EventArgs e)
        {
            cm_tur.Enabled = true;

            lv_liste.Clear();
            lv_liste.View = View.Details;
            lv_liste.GridLines = true;
            lv_liste.FullRowSelect = true;

            lv_liste.Columns.Add("Alış ID", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("İşlem No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Firma Vergi No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Personel No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Ürün Barkod", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Birim", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Adet", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Birim Fiyat", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Toplam Tutar", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Alış Tarih", 100, HorizontalAlignment.Left);

            vt.stokAlısListele(lv_liste); 
        }

        private void rb_sat_CheckedChanged(object sender, EventArgs e)
        {
            cm_tur.Enabled = true;

            lv_liste.Clear();
            lv_liste.View = View.Details;
            lv_liste.GridLines = true;
            lv_liste.FullRowSelect = true;

            lv_liste.Columns.Add("Satış ID", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("İşlem No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Personel No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Ürün Barkod", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Birim", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Adet", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Birim Fiyat", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Satış Türü", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Toplam Tutar", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Satış Tarih", 100, HorizontalAlignment.Left);

            vt.stokSatısListele(lv_liste);
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            if ("Reyon" == Properties.Settings.Default.kullaniciGorev)
            {
                this.Close();
                CovidMark_Login gitLogin = new CovidMark_Login(); gitLogin.Show();
            }
            else
            {
                this.Close();
                form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); //adminMainMenu göster diyoruz
            }
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            rb_alınan.Checked = false;
            rb_satilan.Checked = false;
            tb_deger.Text = "";
            tb_deger.Enabled = false;
            cm_tur.Enabled = false;
            cm_tur.SelectedIndex = 0;
        }

        Point lastPoint;
        private void form_stok_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_stok_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
