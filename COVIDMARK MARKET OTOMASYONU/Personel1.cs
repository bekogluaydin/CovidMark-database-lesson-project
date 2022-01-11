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
    public partial class form_personel : Form
    {
        public string plakaNo = "";
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_personel()
        {
            InitializeComponent();
        }

        private void Personel1_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            veritabani vt = new veritabani();
            vt.personelListele(lv_liste);


            foreach (var item in db.sehir.ToList()) cb_pil.Items.Add(item.sehirAd);

        }
        private void cb_pil_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelBoxesTemizle("ilSecim");
            foreach (var item in db.ilce.Where(s => s.sehirID == cb_pil.SelectedIndex + 1).ToList())
                cb_pilce.Items.Add(item.ilceAd);
            cb_pilce.Enabled = true;

            string pk = db.sehir.Where(s => s.sehirAd == cb_pil.SelectedItem.ToString()).FirstOrDefault().plakaNo;
            lb_plakaNo.Text = pk.Length < 2 ? "0" + pk : pk;
            plakaNo = pk;
        }

        private void cb_pilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelBoxesTemizle("ilceSecim");
            foreach (var item in db.ilce.Where(s => s.sehir.plakaNo == plakaNo && s.ilceAd == cb_pilce.SelectedItem.ToString()).FirstOrDefault().bolge)
                cb_pbolge.Items.Add(item.bolgeAd);
            cb_pbolge.Enabled = true;
        }

        private void cb_pbolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            personelBoxesTemizle("bolgeSecim");
            foreach (var item in db.bolge.Where(s => s.ilce.sehir.plakaNo == plakaNo && s.ilce.ilceAd == cb_pilce.SelectedItem.ToString() 
                                                                                     && s.bolgeAd == cb_pbolge.SelectedItem.ToString()).FirstOrDefault().mahalle)
                cb_pmah.Items.Add(item.mahalleAd);
            cb_pmah.Enabled = true;
        }

        

        private void cb_pmah_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_padres.Enabled = true;
            mahalle mahalle = db.mahalle.Where(s => s.bolge.ilce.sehir.plakaNo == plakaNo && s.bolge.ilce.ilceAd == cb_pilce.SelectedItem.ToString()
                                                                                          && s.bolge.bolgeAd == cb_pbolge.SelectedItem.ToString()
                                                                                          && s.mahalleAd == cb_pmah.SelectedItem.ToString()).FirstOrDefault();
            tb_padres.Text = "Posta Kodunuz: " + mahalle.postaKod;
            lb_pk.Text = mahalle.postaKod;
        }

        private void btn_pmainmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); //adminMainMenu göster diyoruz
        }

        private void lv_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_liste.SelectedItems)
            {
                tb_pno.Text = item.SubItems[0].Text;
                tb_pad.Text = item.SubItems[1].Text;
                tb_psoyad.Text = item.SubItems[2].Text;
                tb_ptc.Text = item.SubItems[3].Text;
                tb_psifre.Text = item.SubItems[4].Text;
                cb_pcinsiyet.SelectedItem = item.SubItems[5].Text;
                tb_ptelefon.Text = item.SubItems[6].Text;
                cb_pgorev.SelectedItem = item.SubItems[7].Text;
                lb_pk.Text = item.SubItems[8].Text;
                cb_pil.SelectedItem = item.SubItems[9].Text;
                cb_pilce.SelectedItem = item.SubItems[10].Text;
                cb_pbolge.SelectedItem = item.SubItems[11].Text;
                cb_pmah.SelectedItem = item.SubItems[12].Text;
                tb_padres.Text = item.SubItems[13].Text;
            }
            tb_pno.Enabled = false;
        }

        private void btn_pkayit_Click(object sender, EventArgs e)
        {
            string sifreEsit = "", tcEsit = "", perNoEsit = "";
            var sifre = db.personel.OrderBy(m => m.personelNo).Select(x => x.personelSifre).ToList();
            var tc = db.personel.OrderBy(m => m.personelNo).Select(x => x.personelTC).ToList();
            var perNo = db.personel.OrderBy(m => m.personelNo).Select(x => x.personelNo).ToList();


            foreach (var item2 in sifre)
            {
                if (tb_psifre.Text == item2)
                {
                    sifreEsit = item2;
                }
            }

            foreach (var item3 in tc)
            {
                if (tb_ptc.Text == item3)
                {
                    tcEsit = item3;
                }
            }

            foreach (var personelNo in perNo)
            {
                if (tb_pno.Text == personelNo)
                {
                    perNoEsit = personelNo;
                }
            }

            if (tb_pno.Text != "" && tb_pad.Text != "" && tb_psoyad.Text != "" && tb_psifre.Text != "" && tcEsit != tb_ptc.Text && sifreEsit != tb_psifre.Text && perNoEsit != tb_pno.Text && cb_pmah.SelectedItem != null && cb_pgorev.SelectedItem != null && cb_pcinsiyet.SelectedItem != null && tb_ptelefon.Text != "")
            {
                int mahalleID = db.mahalle.Where(s => s.postaKod == lb_pk.Text && s.mahalleAd == cb_pmah.SelectedItem.ToString()).FirstOrDefault().mahalleID;
                int mahalleAdet = db.adres.Where(s => s.mahalleID == mahalleID).Count();

                personel personel = db.personel.Add(new personel
                {
                    personelNo = tb_pno.Text,
                    personelAd = tb_pad.Text,
                    personelSoyAd = tb_psoyad.Text,
                    personelTC = tb_ptc.Text,
                    personelSifre = tb_psifre.Text,
                    personelCinsiyet = cb_pcinsiyet.SelectedItem.ToString(),
                    personel_telefon = tb_ptelefon.Text,
                    personelGorev = cb_pgorev.SelectedItem.ToString(),
                    personel_adresBilgi = tb_padres.Text
                });

                if (mahalleAdet == 0) { db.adres.Add(new adres { mahalleID = db.mahalle.Where(s => s.mahalleID == mahalleID).FirstOrDefault().mahalleID }); }
                else { personel.personel_adresID = db.adres.Where(s => s.mahalleID == mahalleID).FirstOrDefault().adresID; }
                int kayit = db.SaveChanges();
                if (kayit == 1 || kayit == 2) MessageBox.Show("Personel Başarıyla Kayıt Edildi");
                personelBoxesTemizle("");
            }
            else MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Personel Kaydedilemedi! \n \r" + "Boş Alan Olmamalı\n \r" + "Şifre, Personel No veya Tc Sistemde Mevcut;\n \r" + "Şifre: "+ sifreEsit + "\n \r" + "TC: " + tcEsit + "\n \r" + "Personel No: " + perNoEsit);
            vt.personelListele(lv_liste);                   
        }

        private void btn_pGuncelle_Click(object sender, EventArgs e)
        {
            personel personel = db.personel.Where(s => s.personelNo == tb_pno.Text).FirstOrDefault();

            try
            {
                if (personel != null && cb_pmah.SelectedItem != null && cb_pgorev.SelectedItem != null && tb_pad.Text != "" && tb_psoyad.Text != "" && tb_psifre.Text != "" && tb_ptc.Text != "")
                {
                    int eskiMahalleID = personel.adres.mahalleID;
                    int eskiAdresID = db.adres.Where(s => s.adresID == personel.personel_adresID).FirstOrDefault().adresID;

                    int mahalleID = db.mahalle.Where(s => s.postaKod == lb_pk.Text && s.mahalleAd == cb_pmah.SelectedItem.ToString()).FirstOrDefault().mahalleID;
                    int mahalleAdet = db.adres.Where(s => s.mahalleID == mahalleID).Count();

                    if (mahalleAdet == 0) { db.adres.Add(new adres { mahalleID = mahalleID }); db.SaveChanges(); }

                    personel.personelAd = tb_pad.Text;
                    personel.personelSoyAd = tb_psoyad.Text;
                    personel.personelTC = tb_ptc.Text;
                    personel.personelSifre = tb_psifre.Text;
                    personel.personelCinsiyet = cb_pcinsiyet.SelectedItem.ToString();
                    personel.personel_telefon = tb_ptelefon.Text;
                    personel.personelGorev = cb_pgorev.SelectedItem.ToString();
                    personel.personel_adresBilgi = tb_padres.Text;
                    personel.personel_adresID = db.adres.Where(s => s.mahalleID == mahalleID).FirstOrDefault().adresID;

                    if (db.SaveChanges() == 1 && eskiMahalleID != mahalleID)
                    {
                        int personelAdet = db.personel.Where(s => s.personel_adresID == eskiAdresID).Count(), firmaAdet = db.firma.Where(s => s.firma_adresID == eskiAdresID).Count();

                        if (personelAdet == 0 && firmaAdet == 0) { db.adres.Remove(db.adres.Where(s => s.adresID == eskiAdresID).FirstOrDefault()); db.SaveChanges(); }
                        else MessageBox.Show(personelAdet + " kişi ve " + firmaAdet + " kadar firma bu adresi kullandığından adres tablosundaki veri silinemedi!");
                        MessageBox.Show("Personel Başarıyla Güncellendi");
                    }
                    vt.personelListele(lv_liste);
                    personelBoxesTemizle("");
                }
                else MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Personel Güncellenemedi! \n \r Personel No Bulanamadı \n \r Bütün Alanlar Doldurulmalı");
            }
            catch (Exception)
            {
                MessageBox.Show("Sorun Oluştu");
            }
        }

        private void btn_psil_Click(object sender, EventArgs e)
        {
            personel personel = db.personel.Where(s => s.personelNo == tb_pno.Text).FirstOrDefault();

            if (personel != null)
            {
                int adresID = personel.personel_adresID;
                int personelAdet = db.personel.Where(s => s.personel_adresID == adresID).Count();
                int firmaAdet = db.firma.Where(s => s.firma_adresID == adresID).Count();
                if (personelAdet == 1 && firmaAdet == 0) { db.adres.Remove(db.adres.Where(s => s.adresID == adresID).FirstOrDefault()); }
                else MessageBox.Show(personelAdet + " kişi ve " + firmaAdet + " kadar firma bu adresi kullandığından adres tablosundaki veri silinemedi!");

                db.personel.Remove(personel);
                int kayit = db.SaveChanges();
                if (kayit == 1 || kayit == 2) MessageBox.Show("Personel Başarıyla Silindi!");
                else MessageBox.Show("Personel silinemedi!");
                
                vt.personelListele(lv_liste);
                personelBoxesTemizle("");
            } else MessageBox.Show("Personel bulunamadı!");
            
        }

        private void btn_pclear_Click(object sender, EventArgs e)
        {
            personelBoxesTemizle("");
        }

        private void personelBoxesTemizle(string secim)
        {
            if (secim == "ilSecim")
            {
                cb_pilce.Items.Clear();
                cb_pbolge.Items.Clear();
                cb_pmah.Items.Clear();
                cb_pilce.Text = "";
                cb_pbolge.Text = "";
                cb_pmah.Text = "";
                tb_padres.Text = "";
                cb_pbolge.Enabled = false;
                cb_pmah.Enabled = false;
                tb_padres.Enabled = false;
                lb_pk.Text = "00000";
            }
            else if (secim == "ilceSecim")
            {
                cb_pbolge.Items.Clear();
                cb_pmah.Items.Clear();
                cb_pbolge.Text = "";
                cb_pmah.Text = "";
                tb_padres.Text = "";
                cb_pmah.Enabled = false;
                tb_padres.Enabled = false;
                lb_pk.Text = "00000";
            }
            else if (secim == "bolgeSecim")
            {
                cb_pmah.Text = "";
                tb_padres.Text = "";
                cb_pmah.Items.Clear();
                tb_padres.Enabled = false;
                lb_pk.Text = "00000";
            }
            else
            {
                tb_pno.Clear();
                tb_pad.Clear();
                tb_psoyad.Clear();
                tb_ptc.Clear();
                tb_psifre.Clear();
                tb_padres.Clear();
                tb_ptelefon.Clear();
                cb_pcinsiyet.Text = "";
                cb_pgorev.Text = "";
                cb_pil.Text = "";
                cb_pilce.Items.Clear();
                cb_pilce.Text = "";
                cb_pilce.Enabled = false;
                cb_pbolge.Items.Clear();
                cb_pbolge.Text = "";
                cb_pbolge.Enabled = false;
                cb_pmah.Items.Clear();
                cb_pmah.Text = "";
                cb_pmah.Enabled = false;
                tb_padres.Enabled = false;
                tb_pno.Enabled = true;
                lb_pk.Text = "00000";
                lb_plakaNo.Text = "00";

            }
        }

        Point lastPoint;
        private void form_personel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_personel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
