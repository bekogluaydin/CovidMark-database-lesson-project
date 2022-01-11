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
    public partial class form_urunler : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_urunler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_urunBirim.SelectedIndex != 0 && cb_ukat.SelectedIndex !=0 && cb_altukat.SelectedIndex != 0 && tb_uozellik.Text != "" && db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).Count() == 0 && db.urun.Where(s => s.urunKod == tb_ukod.Text).Count() == 0 && tb_ubarkod.Text != "" && tb_uad.Text != "" && tb_ukod.Text != "")
                {
                    db.urun.Add(new urun
                    {
                        urunBarkod = tb_ubarkod.Text,
                        urunKod = tb_ukod.Text,
                        urunAd = tb_uad.Text,
                        urunBirim = cb_urunBirim.SelectedItem.ToString(),
                        urunFiyat = Decimal.Parse(tb_ufiyat.Text),
                        urun_altkatID = db.altKategori.Where(s => s.katAltAd == cb_altukat.SelectedItem.ToString()).FirstOrDefault().altkatID,
                        urunOzellik = tb_uozellik.Text
                    });
                    db.SaveChanges(); MessageBox.Show("Ürün Başarıyla Kayıt Edildi");
                    urunBoxesTemizle("");
                }
                else MessageBox.Show("Aşağıda Oluşabilecek Sorunlardan Ötürü Ürün Kaydedilemedi! \n \r * Ürün Barkod Tekrar ediyor \n \r * Ürün Kod Tekrar ediyor \n \r * ComboBoxların Hepsinde Seçim Yapılmalı");
                vt.urunListele(lv_liste);           
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }            
        }

        private void form_urunler_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            urunBoxesTemizle("");

            foreach (var item in db.kategori.ToList()) cb_ukat.Items.Add(item.katAd);
            vt.urunListele(lv_liste);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_ukat_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunBoxesTemizle("katSecim");

            if (cb_ukat.Text != "Kategoriyi Seç...")
                foreach (var item in db.kategori.Where(s => s.katAd == cb_ukat.SelectedItem.ToString()).FirstOrDefault().altKategori)
                    cb_altukat.Items.Add(item.katAltAd);          
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            urunBoxesTemizle("");
        }

        private void btn_mainmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            
            form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); //adminMainMenu göster diyoruz
        }

        private void urunBoxesTemizle(string secim)
        {
            if (secim == "katSecim")
            {
                cb_altukat.Items.Clear();
                cb_altukat.Items.Add("Alt Kategoriyi Seç...");
                cb_altukat.SelectedIndex = 0;
            }
            else
            {
                tb_uad.Clear();
                tb_ubarkod.Clear();
                tb_ufiyat.Clear();
                tb_ukod.Clear();
                tb_uozellik.Clear();
                cb_altukat.Items.Clear();

                cb_altukat.Items.Add("Alt Kategoriyi Seç...");

                cb_ukat.SelectedIndex = 0;
                cb_urunBirim.SelectedIndex = 0;
                cb_altukat.SelectedIndex = 0;
                tb_ubarkod.Enabled = true;
            }
        }

        private void lv_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_liste.SelectedItems)
            {
                tb_ubarkod.Text = item.SubItems[1].Text;
                tb_ukod.Text = item.SubItems[2].Text;
                tb_uad.Text = item.SubItems[3].Text;
                string[] kategori = item.SubItems[4].Text.Split(' ');
                cb_ukat.SelectedIndex = cb_ukat.Items.IndexOf(kategori[1]);
                cb_altukat.SelectedIndex = cb_altukat.Items.IndexOf(kategori[0]);
                cb_urunBirim.SelectedIndex = cb_urunBirim.Items.IndexOf(item.SubItems[5].Text);
                tb_ufiyat.Text = item.SubItems[7].Text;
                tb_uozellik.Text = item.SubItems[8].Text;
            }
            tb_ubarkod.Enabled = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            urun urun = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).FirstOrDefault();

            if (urun != null)
            {
                db.urun.Remove(urun);
                db.SaveChanges();
                vt.urunListele(lv_liste);
                urunBoxesTemizle("");
            }
            else MessageBox.Show("Ürün Barkod Bulunamadı");
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            urun urun = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).FirstOrDefault();

            try
            {
                if (urun != null && cb_ukat.SelectedIndex != 0 && cb_altukat.SelectedIndex != 0 && cb_urunBirim.SelectedIndex !=0 && tb_uad.Text != "" && tb_ubarkod.Text != "" && tb_ukod.Text != "" && tb_uozellik.Text != "")
                {
                    urun.urunKod = tb_ukod.Text;
                    urun.urunAd = tb_uad.Text;
                    urun.urunBirim = cb_urunBirim.SelectedItem.ToString();
                    urun.urunFiyat = Decimal.Parse(tb_ufiyat.Text);
                    urun.urun_altkatID = db.altKategori.Where(s => s.katAltAd == cb_altukat.SelectedItem.ToString()).FirstOrDefault().altkatID;
                    urun.urunOzellik = tb_uozellik.Text;

                    db.SaveChanges();
                    veritabani vtGuncelle = new veritabani();
                    vtGuncelle.urunListele(lv_liste);
                    urunBoxesTemizle("");
                }
                else MessageBox.Show("Aşağıda Oluşabilecek Sorunlardan Ötürü Ürün Kaydedilemedi! \n \r * Ürün Barkod Bulunamadı \n \r * ComboBoxların Hepsinde Seçim Yapılmalı");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Sorun Oluştu!");
            }       
        }

        Point lastPoint;
        private void form_urunler_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_urunler_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
