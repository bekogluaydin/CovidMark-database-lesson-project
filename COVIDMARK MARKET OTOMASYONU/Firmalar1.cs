using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace COVIDMARK_MARKET_OTOMASYONU
{
    public partial class form_firma : Form
    {
        public string plakaNo = "";
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_firma()
        {
            InitializeComponent();
        }

        private void form_firma_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            vt.firmaListele(lv_liste);


            foreach (var item in db.sehir.ToList()) cb_fil.Items.Add(item.sehirAd);

        }

        private void btn_fmainmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); //adminMainMenu göster diyoruz
        }

        private void cb_fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaBoxesTemizle("ilSecim");
            bool kontrol = true;
            foreach (var item in db.ilce.Where(s => s.sehirID == cb_fil.SelectedIndex + 1).ToList())
            {
                cb_filce.Items.Add(item.ilceAd);
                if (item.sehir.sehirAd == "İSTANBUL") cb_fdahili.Enabled = true;
                else cb_fdahili.Enabled = false;
                if (kontrol)  foreach (string telKod in item.sehir.sehirTelKod.Split('-')) cb_fdahili.Items.Add(telKod); kontrol = false;
            }
            cb_fdahili.SelectedIndex = 0;
            cb_filce.Enabled = true;
            tb_ftel.Enabled = true;
            string pk = db.sehir.Where(s => s.sehirAd == cb_fil.SelectedItem.ToString()).FirstOrDefault().plakaNo;
            lb_plakaNo.Text = pk.Length < 2 ? "0" + pk : pk;
            plakaNo = pk;
        }

        private void cb_filce_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaBoxesTemizle("ilceSecim");
            foreach (var item in db.ilce.Where(s => s.sehir.plakaNo == plakaNo && s.ilceAd == cb_filce.SelectedItem.ToString()).FirstOrDefault().bolge)
                cb_fbolge.Items.Add(item.bolgeAd);
            cb_fbolge.Enabled = true;
        }

        private void cb_fbolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            firmaBoxesTemizle("bolgeSecim");
            foreach (var item in db.bolge.Where(s => s.ilce.sehir.plakaNo == plakaNo && s.ilce.ilceAd == cb_filce.SelectedItem.ToString() 
                                                                                     && s.bolgeAd == cb_fbolge.SelectedItem.ToString()).FirstOrDefault().mahalle)
                cb_fmah.Items.Add(item.mahalleAd);
            cb_fmah.Enabled = true;
        }

        private void cb_fmah_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_fadres.Enabled = true;
            mahalle mahalle = db.mahalle.Where(s => s.bolge.ilce.sehir.plakaNo == plakaNo && s.bolge.ilce.ilceAd == cb_filce.SelectedItem.ToString()
                                                                                     && s.bolge.bolgeAd == cb_fbolge.SelectedItem.ToString()
                                                                                     && s.mahalleAd == cb_fmah.SelectedItem.ToString()).FirstOrDefault();
            tb_fadres.Text = "Posta Kodunuz: " + mahalle.postaKod;
            lb_pk.Text = mahalle.postaKod;
        }

        private void lv_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_liste.SelectedItems)
            {
                tb_fvno.Text = item.SubItems[1].Text;
                tb_fad.Text = item.SubItems[2].Text;
                string[] telParca = item.SubItems[3].Text.Split(' ');
                cb_fdahili.Items.Add(telParca[0].Split('(')[1].Split(')')[0]);
                cb_fdahili.SelectedIndex = 0;
                tb_ftel.Text = telParca[1];
                lb_pk.Text = item.SubItems[4].Text;
                cb_fil.SelectedItem = item.SubItems[5].Text;
                cb_filce.SelectedItem = item.SubItems[6].Text;
                cb_fbolge.SelectedItem = item.SubItems[7].Text;
                cb_fmah.SelectedItem = item.SubItems[8].Text;
                tb_fadres.Text = item.SubItems[9].Text;
            }
            tb_fvno.Enabled = false;
        }

        private void btn_fKayıt_Click(object sender, EventArgs e)
        {
            string vergiNoEsit = "";
            var fvergiNo = db.firma.OrderBy(m => m.vergiNo).Select(x => x.vergiNo).ToList();

            foreach (var item2 in fvergiNo)
            {
                if (tb_fvno.Text == item2)
                {
                    vergiNoEsit = item2;
                }
            }

            if (tb_fad.Text != "" && tb_ftel.Text != "" && vergiNoEsit != tb_fvno.Text && cb_fmah.SelectedItem != null && db.firma.Where(s => s.vergiNo == tb_fvno.Text).Count() == 0)
            {
                int mahalleID = db.mahalle.Where(s => s.postaKod == lb_pk.Text && s.mahalleAd == cb_fmah.SelectedItem.ToString()).FirstOrDefault().mahalleID;
                int mahalleAdet = db.adres.Where(s => s.mahalleID == mahalleID).Count();

                firma firma = db.firma.Add(new firma {
                    vergiNo = tb_fvno.Text,
                    firmaAd = tb_fad.Text,
                    firmaTel = "(" + cb_fdahili.SelectedItem.ToString() + ") " + tb_ftel.Text,
                    firma_adresBilgi = tb_fadres.Text
                });

                if (mahalleAdet == 0) {
                        db.adres.Add(new adres { mahalleID = db.mahalle.Where(s => s.mahalleID == mahalleID).FirstOrDefault().mahalleID  });
                }
                else {  firma.firma_adresID = db.adres.Where(s => s.mahalleID == mahalleID).FirstOrDefault().adresID; }
                int kayit = db.SaveChanges();
                if (kayit == 1 || kayit == 2) MessageBox.Show("Firma Başarıyla Kayıt Edildi");
                firmaBoxesTemizle("");
            } else MessageBox.Show("Firma Kaydedilemedi!");
            vt.firmaListele(lv_liste);
        }

        private void btn_fSil_Click(object sender, EventArgs e)
        {
            firma firma = db.firma.Where(s => s.vergiNo == tb_fvno.Text).FirstOrDefault();

            if (firma != null) {

                int adresID = firma.firma_adresID, personelAdet = db.personel.Where(s => s.personel_adresID == adresID).Count(), firmaAdet = db.firma.Where(s => s.firma_adresID == adresID).Count();

                if (firmaAdet == 1 && personelAdet == 0) { db.adres.Remove(db.adres.Where(s => s.adresID == adresID).FirstOrDefault()); }
                else MessageBox.Show(personelAdet + " kişi ve " + firmaAdet + " kadar firma bu adresi kullandığından adres tablosundaki veri silinemedi!");

                db.firma.Remove(firma);
                int kayit = db.SaveChanges();
                if (kayit == 1 || kayit == 2) MessageBox.Show("Firma Başarıyla Silindi!");
                else MessageBox.Show("Firma silinemedi!");

                vt.firmaListele(lv_liste);
                firmaBoxesTemizle("");
            }else MessageBox.Show("Bu vergi numarasına ait firma zaten yok!");
        }

        private void btn_fGuncelle_Click(object sender, EventArgs e)
        {
            firma firma = db.firma.Where(s => s.vergiNo == tb_fvno.Text).FirstOrDefault();
            try
            {
                if (firma != null && cb_fmah.SelectedItem != null && tb_fad.Text != "" && tb_ftel.Text != "") 
                {
                    int eskiMahalleID = firma.adres.mahalleID;
                    int eskiAdresID = db.adres.Where(s => s.adresID == firma.firma_adresID).FirstOrDefault().adresID;

                    int mahalleID = db.mahalle.Where(s => s.postaKod == lb_pk.Text && s.mahalleAd == cb_fmah.SelectedItem.ToString()).FirstOrDefault().mahalleID;
                    int mahalleAdet = db.adres.Where(s => s.mahalleID == mahalleID).Count();

                    if (mahalleAdet == 0) { db.adres.Add(new adres { mahalleID = mahalleID }); db.SaveChanges(); }

                    firma.firmaAd = tb_fad.Text;
                    firma.firmaTel = "(" + cb_fdahili.SelectedItem.ToString() + ") " + tb_ftel.Text;
                    firma.firma_adresID = db.adres.Where(s => s.mahalleID == mahalleID).FirstOrDefault().adresID;
                    firma.firma_adresBilgi = tb_fadres.Text;

                    if (db.SaveChanges() == 1 && eskiMahalleID != mahalleID)
                    {
                        int personelAdet = db.personel.Where(s => s.personel_adresID == eskiAdresID).Count(), firmaAdet = db.firma.Where(s => s.firma_adresID == eskiAdresID).Count();

                        if (firmaAdet == 0 && personelAdet == 0) { db.adres.Remove(db.adres.Where(s => s.adresID == eskiAdresID).FirstOrDefault()); db.SaveChanges(); }
                        else MessageBox.Show(personelAdet + " kişi ve " + firmaAdet + " kadar firma bu adresi kullandığından adres tablosundaki veri silinemedi!");
                        MessageBox.Show("Firma başarıyla güncellendi!");
                    }
                    vt.firmaListele(lv_liste);
                    firmaBoxesTemizle("");
                }
               else MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Firma Güncellenemedi! \n \r Firma Vergi No Bulanamadı \n \r Bütün Alanlar Doldurulmalı");
            }
            catch (Exception)
            {
                MessageBox.Show("Sorun Oluştu");
            }           
        }
        private void btn_ftemizle_Click(object sender, EventArgs e)
        {
            firmaBoxesTemizle("");
        }

        private void firmaBoxesTemizle(string secim)
        {
            if (secim == "ilSecim")
            {
                cb_filce.Items.Clear();
                cb_fbolge.Items.Clear();
                cb_fmah.Items.Clear();
                cb_filce.Text = "";
                cb_fbolge.Text = "";
                cb_fmah.Text = "";
                tb_fadres.Text = "";
                cb_fbolge.Enabled = false;
                cb_fmah.Enabled = false;
                tb_fadres.Enabled = false;
                cb_fdahili.Items.Clear();
                cb_fdahili.Text = "";
                lb_pk.Text = "00000";

            }
            else if (secim == "ilceSecim")
            {
                cb_fbolge.Items.Clear();
                cb_fmah.Items.Clear();
                cb_fbolge.Text = "";
                cb_fmah.Text = "";
                tb_fadres.Text = "";
                cb_fmah.Enabled = false;
                tb_fadres.Enabled = false;
                lb_pk.Text = "00000";
            }
            else if (secim == "bolgeSecim")
            {
                cb_fmah.Text = "";
                tb_fadres.Text = "";
                cb_fmah.Items.Clear();
                tb_fadres.Enabled = false;
                lb_pk.Text = "00000";
            }
            else
            {
                tb_fad.Clear();
                tb_fadres.Clear();
                tb_ftel.Clear();
                tb_fvno.Clear();
                cb_fdahili.Items.Clear();
                cb_fdahili.Text = "";
                cb_fdahili.Enabled = false;
                cb_fil.Text = "";
                cb_filce.Items.Clear();
                cb_filce.Text = "";
                cb_filce.Enabled = false;
                cb_fbolge.Items.Clear();
                cb_fbolge.Text = "";
                cb_fbolge.Enabled = false;
                cb_fmah.Items.Clear();
                cb_fmah.Text = "";
                cb_fmah.Enabled = false;
                tb_fadres.Enabled = false;
                tb_ftel.Enabled = false;
                tb_fvno.Enabled = true;
                lb_pk.Text = "00000";
                lb_plakaNo.Text = "00";
            }
        }

        Point lastPoint;
        private void form_firma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void form_firma_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
