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
    class veritabani
    {
        public void urunListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();
        
            foreach (var items in db.urun.OrderBy(m => m.urunID).ToList())
            {
                ListViewItem item = new ListViewItem(items.urunID.ToString());
                item.SubItems.Add(items.urunBarkod);
                item.SubItems.Add(items.urunKod);
                item.SubItems.Add(items.urunAd);
                item.SubItems.Add(items.altKategori.katAltAd + " " + items.altKategori.kategori.katAd);
                item.SubItems.Add(items.urunBirim);
                item.SubItems.Add(items.urunStok.ToString());
                item.SubItems.Add(items.urunFiyat.ToString());
                item.SubItems.Add(items.urunOzellik);
                list.Items.Add(item);
            }
        }

        public void firmaListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.firma.OrderBy(m => m.firmaID).ToList())
            {

                ListViewItem item = new ListViewItem(items.firmaID.ToString());
                item.SubItems.Add(items.vergiNo);
                item.SubItems.Add(items.firmaAd);
                item.SubItems.Add(items.firmaTel);
                item.SubItems.Add(items.adres.mahalle.postaKod);
                item.SubItems.Add(items.adres.mahalle.bolge.ilce.sehir.sehirAd);
                item.SubItems.Add(items.adres.mahalle.bolge.ilce.ilceAd);
                item.SubItems.Add(items.adres.mahalle.bolge.bolgeAd);
                item.SubItems.Add(items.adres.mahalle.mahalleAd);
                item.SubItems.Add(items.firma_adresBilgi);
                list.Items.Add(item);
            }
        }

        public void personelListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.personel.OrderBy(m => m.personelNo).ToList())
            {

                ListViewItem item = new ListViewItem(items.personelNo.ToString());
                item.SubItems.Add(items.personelAd);
                item.SubItems.Add(items.personelSoyAd);
                item.SubItems.Add(items.personelTC);
                item.SubItems.Add(items.personelSifre);
                item.SubItems.Add(items.personelCinsiyet);
                item.SubItems.Add(items.personel_telefon);
                item.SubItems.Add(items.personelGorev);
                item.SubItems.Add(items.adres.mahalle.postaKod);
                item.SubItems.Add(items.adres.mahalle.bolge.ilce.sehir.sehirAd);
                item.SubItems.Add(items.adres.mahalle.bolge.ilce.ilceAd);
                item.SubItems.Add(items.adres.mahalle.bolge.bolgeAd);
                item.SubItems.Add(items.adres.mahalle.mahalleAd);
                item.SubItems.Add(items.personel_adresBilgi);
                list.Items.Add(item);
            }
        }

        public void kategoriListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.kategori.OrderBy(m => m.katAd).ToList())
            {

                ListViewItem item = new ListViewItem(items.katID.ToString());
                item.SubItems.Add(items.katKod);
                item.SubItems.Add(items.katAd);
                item.SubItems.Add(items.katVergi.ToString());
                list.Items.Add(item);
            }
        }

        public void altkategoriListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.altKategori.OrderBy(m => m.alt_katKod).ToList())
            {

                ListViewItem item = new ListViewItem(items.altkatID.ToString());
                item.SubItems.Add(items.katAltAd);
                item.SubItems.Add(items.alt_katKod);
                list.Items.Add(item);
            }
        }

        public void faturaAlisListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            // urunAlis urunAlis = db.urunAlis.Where(s => s.fatura.faturaTur == "Alış").FirstOrDefault().faturaId.ToString();
            //string deneme = db.urunAlis.Where(s => s.fatura.faturaTur == "Alış").ToList().FirstOrDefault().faturaId.ToString();
            
            foreach (var items in db.fatura.Where(s => s.faturaTur == "Alış").ToList())
             {
                decimal toplam = 0;
                int faturaid = items.faturaID;
                foreach (var topTutar in db.urunAlis.Where(s => s.faturaId == faturaid).ToList())
                    toplam = topTutar.alisTopTutar + toplam;
                
                ListViewItem item = new ListViewItem(items.faturaID.ToString());
                item.SubItems.Add(items.urunAlis.FirstOrDefault().alis_firmaVergiNo);
                item.SubItems.Add(items.urunAlis.FirstOrDefault().firma.firmaAd);
                item.SubItems.Add(items.faturaTur);
                item.SubItems.Add(toplam.ToString());
                item.SubItems.Add(items.fatura_kesimTarih.ToString());
                list.Items.Add(item);
             }
        }

        public void faturaSatisListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            // urunAlis urunAlis = db.urunAlis.Where(s => s.fatura.faturaTur == "Alış").FirstOrDefault().faturaId.ToString();
            //string deneme = db.urunAlis.Where(s => s.fatura.faturaTur == "Alış").ToList().FirstOrDefault().faturaId.ToString();

            foreach (var items in db.fatura.Where(s => s.faturaTur == "Satış").ToList())
            {
                decimal toplam = 0;
                int faturaid = items.faturaID;
                foreach (var topTutar in db.urunSatis.Where(s => s.faturaId == faturaid).ToList())
                    toplam = topTutar.satisTopTutar + toplam;

                ListViewItem item = new ListViewItem(items.faturaID.ToString());
                item.SubItems.Add(items.faturaTur);
                item.SubItems.Add(items.urunSatis.FirstOrDefault().satisTuru);
                item.SubItems.Add(toplam.ToString());
                item.SubItems.Add(items.fatura_kesimTarih.ToString());
                list.Items.Add(item);
            }
        }
        public void stokAlısListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.urunAlis.OrderBy(m => m.alisID).ToList())
            {
                ListViewItem item = new ListViewItem(items.alisID.ToString());
                item.SubItems.Add(items.alis_islemNo.ToString());
                item.SubItems.Add(items.alis_firmaVergiNo);
                item.SubItems.Add(items.alis_personelNo);
                item.SubItems.Add(items.alis_urunBarkod);
                item.SubItems.Add(items.alisBirim.ToString());
                item.SubItems.Add(items.alisAdet.ToString());
                item.SubItems.Add(items.alisBirimFiyat.ToString());
                item.SubItems.Add(items.alisTopTutar.ToString());
                item.SubItems.Add(items.alisTarih.ToString());
                list.Items.Add(item);
            }
        }

        public void stokAlısSorguListele(ListView list, int sorgu, string girilenDeger)
        {           
            for (int i = list.Items.Count - 1; i >= 0; i--)
            {
                var item = list.Items[i].SubItems[sorgu];
               // if (item.Text.ToLower().Contains(girilenDeger.ToLower()))
                 if (item.Text.ToLower()==girilenDeger.ToLower())
                {
                    item.BackColor = SystemColors.Highlight;
                    item.ForeColor = SystemColors.HighlightText;
                }
                else
                {
                    var sil = list.Items[i];
                    list.Items.Remove(sil);
                }
            }
            if (list.SelectedItems.Count == 1)
            {
                list.Focus();
            }
        }

        public void stokSatısListele(ListView list)
        {
            covidmarkEntities db = new covidmarkEntities();
            list.Items.Clear();

            foreach (var items in db.urunSatis.OrderBy(m => m.satisID).ToList())
            {
                ListViewItem item = new ListViewItem(items.satisID.ToString());
                item.SubItems.Add(items.satis_islemNo.ToString());
                item.SubItems.Add(items.satis_personelNo);
                item.SubItems.Add(items.satis_urunBarkod);
                item.SubItems.Add(items.satisBirim.ToString());
                item.SubItems.Add(items.satisAdet.ToString());
                item.SubItems.Add(items.satisBirimFiyat.ToString());
                item.SubItems.Add(items.satisTuru);
                item.SubItems.Add(items.satisTopTutar.ToString());
                item.SubItems.Add(items.satisTarih.ToString());
                list.Items.Add(item);
            }
        }

        int? faturaId = null;

        public covidmarkEntities satisEkle(ListView list, Label label, String odemeTur)
        {
           bool faturaSor = true;
           int? anlikFaturaId = 0;
           List<urunSatis> satislar = new List<urunSatis>();
           covidmarkEntities db = new covidmarkEntities();
           int alisVeris = 1;
           int urunAdet = list.Items.Count; int stokDurum = 0;

            foreach (ListViewItem item in list.Items)
            {
                int adet = Convert.ToInt16(item.SubItems[5].Text);

                string degisken = item.SubItems[1].Text;
                urun urun = db.urun.Where(s => s.urunBarkod == degisken).FirstOrDefault();
                int stok = Convert.ToInt16(urun.urunStok);

                if ((stok - adet) >= 0)
                {
                    stokDurum++;

                    if (faturaSor && faturaId == null && faturaId != anlikFaturaId && MessageBox.Show("Fatura istiyor musunuz ?", "Fatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var fatura = db.fatura.Add(
                            new fatura
                            {
                                faturaTur = "Satış",
                                fatura_kesimTarih = DateTime.Now
                            }
                        );

                        db.SaveChanges();

                        faturaId = fatura.faturaID;
                        anlikFaturaId = faturaId;
                        faturaSor = false;
                    }
                    else
                        faturaSor = false;

                    //MessageBox.Show(stokDurum.ToString());
                    if (urunAdet == stokDurum)
                    {
                        foreach (ListViewItem item2 in list.Items)
                        {
                            int adet1 = Convert.ToInt16(item2.SubItems[5].Text);

                            string degisken1 = item2.SubItems[1].Text;
                            urun urun1 = db.urun.Where(s => s.urunBarkod == degisken1).FirstOrDefault();
                            int stok1 = Convert.ToInt16(urun1.urunStok);

                            //MessageBox.Show("Ürün Stok durumu '-' 'ye düşmeyeceğinden satış tamamlanabilir"); 

                            var satis = db.urunSatis.Add(
                            new urunSatis
                            {
                                satis_personelNo = label.Text,
                                satis_islemNo = Convert.ToInt32(item2.Text),
                                satis_urunBarkod = item2.SubItems[1].Text,
                                satis_urunKod = item2.SubItems[2].Text,
                                satisBirim = item2.SubItems[4].Text,
                                satisAdet = Byte.Parse(item2.SubItems[5].Text),
                                satisBirimFiyat = Decimal.Parse(item2.SubItems[6].Text),
                                satisTuru = odemeTur,
                                satisTopTutar = Decimal.Parse(item2.SubItems[7].Text),
                                satisTarih = DateTime.Parse(item2.SubItems[8].Text),
                                faturaId = faturaId
                            });
                            satislar.Add(satis);
                            urun1.urunStok = Convert.ToInt16(stok1 - adet1);
                        }
                        
                    }
                }
                else { MessageBox.Show("Bazı ürünlerin stoğu '-' 'ye düşeceğinden satış işlemi tamamlanamadı!"); alisVeris = 0; }
            }

            if (alisVeris == 1 && MessageBox.Show("Alışveriş Tamamlansın mı?", "Emin misiniz?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                faturaId = null;
                return db;
            }
            else
            {
                try
                {
                    db.fatura.Remove(db.fatura.Where(s => s.faturaID == faturaId).FirstOrDefault());
                }
                catch
                {

                }
                db.SaveChanges();
                db.urunSatis.RemoveRange(satislar);
                db.SaveChanges();
                faturaId = null;
                return null;
            }
        }

        public covidmarkEntities alisEkle(ListView list, Label label)
        {
            covidmarkEntities db = new covidmarkEntities();
            bool faturaSor = true;
            int? anlikFaturaId = 0;

            foreach (ListViewItem item in list.Items)
            {
                int adet = Convert.ToInt16(item.SubItems[7].Text);

                string degisken = item.SubItems[3].Text;
                urun urun = db.urun.Where(s => s.urunBarkod == degisken).FirstOrDefault();
                int stok = Convert.ToInt16(urun.urunStok);

                if (faturaSor && faturaId == null && faturaId != anlikFaturaId && MessageBox.Show("Fatura istiyor musunuz ?", "Fatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var fatura = db.fatura.Add(
                        new fatura
                        {
                            faturaTur = "Alış",
                            fatura_kesimTarih = DateTime.Now
                        });

                    db.SaveChanges();

                    faturaId = fatura.faturaID;
                    anlikFaturaId = faturaId;
                    faturaSor = false;
                }
                else
                    faturaSor = false;

                db.urunAlis.Add(
                    new urunAlis
                    {
                        alis_islemNo = Convert.ToInt32(item.Text),
                        alis_firmaVergiNo = item.SubItems[1].Text,
                        alis_personelNo = label.Text,
                        alis_urunBarkod = item.SubItems[3].Text,
                        alis_urunKod = item.SubItems[4].Text,
                        alisBirim = item.SubItems[6].Text,
                        alisAdet = Byte.Parse(item.SubItems[7].Text),
                        alisBirimFiyat = Decimal.Parse(item.SubItems[8].Text),
                        alisTopTutar = Decimal.Parse(item.SubItems[9].Text),
                        alisTarih = DateTime.Parse(item.SubItems[10].Text),
                        faturaId = faturaId
                    });
                    urun.urunStok = Convert.ToInt16(stok + adet);
            }

            if (MessageBox.Show("Alışveriş Tamamlansın mı?", "Emin misiniz?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                faturaId = null;
                return db;
            }
            return null;
        }
    }
}
