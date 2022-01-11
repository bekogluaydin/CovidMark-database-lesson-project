using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace COVIDMARK_MARKET_OTOMASYONU
{
    public partial class form_satis : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        decimal komisyon;
        public form_satis()
        {
            InitializeComponent();
        }

        private void form_satis_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToString();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if ("Kasiyer" == Properties.Settings.Default.kullaniciGorev) { this.Close(); CovidMark_Login gitLogin = new CovidMark_Login(); gitLogin.Show(); }
            else { this.Close(); form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); }
        }

        private void tb_ukod_TextChanged(object sender, EventArgs e)
        {
            urun urun = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).FirstOrDefault();

            if (urun != null) tb_uad.Text = urun.urunAd;
            else tb_uad.Text = "";
        }

        private void hizliIslemler(string barkodNo)
        {
            var items = db.urun.Where(s => s.urunBarkod == barkodNo).ToList();
            int islemNo = db.urunSatis.FirstOrDefault() != null ? db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().satis_islemNo : 0;

            int urunAdet = 1;
            try
            {
                if (items.Count() != 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Name = items.FirstOrDefault().urunBarkod.ToString();
                    item.Text = (islemNo + 1).ToString();
                    item.SubItems.Add(items.FirstOrDefault().urunBarkod.ToString());
                    item.SubItems.Add(items.FirstOrDefault().urunKod.ToString());
                    item.SubItems.Add(items.FirstOrDefault().urunAd.ToString());
                    item.SubItems.Add(items.FirstOrDefault().urunBirim.ToString());
                    item.SubItems.Add(urunAdet.ToString());
                    item.SubItems.Add(items.FirstOrDefault().urunFiyat.ToString());
                    item.SubItems.Add((Decimal.Parse(urunAdet.ToString()) * items.FirstOrDefault().urunFiyat).ToString());
                    item.SubItems.Add(DateTime.Now.ToString());

                    if (lv_liste.Items.ContainsKey(item.Name) == false) lv_liste.Items.Add(item);
                    else
                    {
                        MessageBox.Show("Ürün Daha önce eklendiğinden sadece adet arttı");
                        ListViewItem Item = lv_liste.Items.Find(item.Name, true).ToArray()[0];
                        ListViewItem.ListViewSubItem subItem5 = Item.SubItems[5];
                        subItem5.Text = (Int32.Parse(subItem5.Text) + Int32.Parse(urunAdet.ToString())).ToString();
                        Item.SubItems.RemoveAt(5);
                        Item.SubItems.Insert(5, subItem5);
                        ListViewItem.ListViewSubItem subItem6 = Item.SubItems[6];
                        ListViewItem.ListViewSubItem subItem7 = Item.SubItems[7];
                        subItem7.Text = (Decimal.Parse(subItem5.Text) * Decimal.Parse(subItem6.Text)).ToString();
                        Item.SubItems.RemoveAt(7);
                        Item.SubItems.Insert(7, subItem7);
                    }
                    lbl_atoplam1.Text = "0.00";

                    foreach (ListViewItem item2 in lv_liste.Items)
                    { 
                        lbl_atoplam1.Text = (Decimal.Parse(lbl_atoplam1.Text) + Decimal.Parse(item2.SubItems[7].Text)).ToString();
                        lbl_toplam1.Text = (Decimal.Parse(lbl_atoplam1.Text) + Decimal.Parse(lbl_bindirim1.Text)).ToString();
                    }
                }
                else MessageBox.Show("Ürün Yok!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorun oluştu");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            var items = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).ToList();
            int islemNo = db.urunSatis.FirstOrDefault() != null ? db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().satis_islemNo : 0;
            try
            {
                if (items.Count() != 0 && Convert.ToInt16(tb_adet.Text) >= 1)
                {
                    if (Convert.ToInt16(tb_adet.Text) >= 256)
                    {
                        MessageBox.Show("Adet sayısı en fazla 255 olabilir");
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem();
                        item.Name = items.FirstOrDefault().urunBarkod.ToString();
                        item.Text = (islemNo + 1).ToString();
                        item.SubItems.Add(items.FirstOrDefault().urunBarkod.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunKod.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunAd.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunBirim.ToString());
                        item.SubItems.Add(tb_adet.Text);
                        item.SubItems.Add(items.FirstOrDefault().urunFiyat.ToString());
                        item.SubItems.Add((Decimal.Parse(tb_adet.Text) * items.FirstOrDefault().urunFiyat).ToString());
                        item.SubItems.Add(DateTime.Now.ToString());

                        if (lv_liste.Items.ContainsKey(item.Name) == false) lv_liste.Items.Add(item);
                        else
                        {
                            MessageBox.Show("Ürün Daha önce eklendiğinden sadece adet arttı");
                            ListViewItem Item = lv_liste.Items.Find(item.Name, true).ToArray()[0];
                            ListViewItem.ListViewSubItem subItem5 = Item.SubItems[5];
                            subItem5.Text = (Int32.Parse(subItem5.Text) + Int32.Parse(tb_adet.Text)).ToString();
                            Item.SubItems.RemoveAt(5);
                            Item.SubItems.Insert(5, subItem5);
                            ListViewItem.ListViewSubItem subItem6 = Item.SubItems[6];
                            ListViewItem.ListViewSubItem subItem7 = Item.SubItems[7];
                            subItem7.Text = (Decimal.Parse(subItem5.Text) * Decimal.Parse(subItem6.Text)).ToString();
                            Item.SubItems.RemoveAt(7);
                            Item.SubItems.Insert(7, subItem7);
                        }
                        lbl_atoplam1.Text = "0.00";
                        foreach (ListViewItem item2 in lv_liste.Items)
                        {
                            lbl_atoplam1.Text = (Decimal.Parse(lbl_atoplam1.Text) + Decimal.Parse(item2.SubItems[7].Text)).ToString();
                            lbl_toplam1.Text = (Decimal.Parse(lbl_atoplam1.Text) + Decimal.Parse(lbl_bindirim1.Text)).ToString();
                        }
                    }                          
                }
                else MessageBox.Show("Ürün Yok ve Adeti Doğru Girin!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorun oluştu");
            }
        }
        public static int satis_satisFaturaNo = 0;
        string odemeTur = "";
        decimal araToplam = 0, kdv_topTutar = 0;
        private void btn_nakit_Click(object sender, EventArgs e)
        {
            ListViewItem.ListViewSubItem eskiTutar;
            foreach (ListViewItem item in lv_liste.Items)
            {
                eskiTutar = item.SubItems[7];
                eskiTutar.Text = Convert.ToString(Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(item.SubItems[6].Text));
                item.SubItems.RemoveAt(7);
                item.SubItems.Insert(7, eskiTutar);
            }

            araToplam = Decimal.Parse(lbl_atoplam1.Text);
            kdv_topTutar = Decimal.Parse(lbl_bindirim1.Text);
            lbl_toplam1.Text = (araToplam + kdv_topTutar).ToString();

            odemeTur = "Nakit";
            lbl_bindirim1.Text = "0.00";
            covidmarkEntities db = vt.satisEkle(lv_liste, label1, odemeTur);
            lbl_toplam1.Text = "0.00";
            lbl_toplam1.Text = lbl_atoplam1.Text;

            if (db != null && db.SaveChanges() != 0) 
            {   MessageBox.Show("Satış Tamamlandı"); 
                foreach (ListViewItem item in lv_liste.Items) item.Remove();
                lbl_atoplam1.Text = "0.00"; lbl_toplam1.Text = "0.00";

                if (db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().faturaId != null)
                {
                    satis_satisFaturaNo = (int)db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().faturaId;
                    printPreviewDialog1.ShowDialog();
                }                             
            }
            else
            {
                MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Satış Tamamlanamadı \n \r Satış İptal Edildi \n \r Ürün Girilmemiş \n \r Bazı Ürünlerin Stoğu '-' 'ye Düşüyor!");
                lbl_toplam1.Text = "0.00";
            }
        }

        private void btn_kk_Click(object sender, EventArgs e)
        {
            lbl_bindirim1.Text = "0.00";
            ListViewItem.ListViewSubItem eskiTutar;

            foreach (ListViewItem item in lv_liste.Items)
            {
                eskiTutar = item.SubItems[7];
                komisyon = (Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(item.SubItems[6].Text)) * Convert.ToDecimal(0.1);
                eskiTutar.Text = Convert.ToString(((Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(item.SubItems[6].Text)) * Convert.ToDecimal(0.1)) + (Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(item.SubItems[6].Text)));
                item.SubItems.RemoveAt(7);
                item.SubItems.Insert(7, eskiTutar);
                lbl_bindirim1.Text = (komisyon + Decimal.Parse(lbl_bindirim1.Text)).ToString();
            }

            araToplam = Decimal.Parse(lbl_atoplam1.Text);
            kdv_topTutar = Decimal.Parse(lbl_bindirim1.Text);
            lbl_toplam1.Text = (araToplam + kdv_topTutar).ToString();

            odemeTur = "Kredi Kart";
            covidmarkEntities db = vt.satisEkle(lv_liste, label1, odemeTur);
            lbl_toplam1.Text = "0.00";
            foreach (ListViewItem item2 in lv_liste.Items) lbl_toplam1.Text = (Decimal.Parse(lbl_toplam1.Text) + Decimal.Parse(item2.SubItems[7].Text)).ToString();
            if (db != null && db.SaveChanges() != 0)
            {
                MessageBox.Show("Satış Tamamlandı");
                foreach (ListViewItem item in lv_liste.Items) item.Remove(); 
                lbl_atoplam1.Text = "0.00"; lbl_toplam1.Text = "0.00"; lbl_bindirim1.Text = "0.00";

                if (db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().faturaId != null)
                {
                    satis_satisFaturaNo = (int)db.urunSatis.OrderByDescending(s => s.satis_islemNo).FirstOrDefault().faturaId;
                    printPreviewDialog1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Satış Tamamlanamadı \n \r Satış İptal Edildi \n \r Ürün Girilmemiş \n \r Bazı Ürünlerin Stoğu '-' 'ye Düşüyor!");
                lbl_toplam1.Text = "0.00";
                lbl_bindirim1.Text = "0.00";                
                foreach (ListViewItem item in lv_liste.Items)
                {
                    eskiTutar = item.SubItems[7];
                    eskiTutar.Text = Convert.ToString(Convert.ToDecimal(item.SubItems[5].Text) * Convert.ToDecimal(item.SubItems[6].Text));
                    item.SubItems.RemoveAt(7);
                    item.SubItems.Insert(7, eskiTutar);
                }
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_adet.Text = "";
            tb_ubarkod.Text = "";
            tb_adet.Text = "";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_liste.SelectedItems) item.Remove();

            lbl_atoplam1.Text = "0";
            foreach (ListViewItem item2 in lv_liste.Items) lbl_atoplam1.Text = (Decimal.Parse(lbl_atoplam1.Text) + Decimal.Parse(item2.SubItems[6].Text)).ToString();
        }

        private void btn_ekmek_Click(object sender, EventArgs e)
        {
            string barkod = "8681188653";
            hizliIslemler(barkod);
        }

        private void btn_ekmek250_Click(object sender, EventArgs e)
        {
            string barkod = "8681188654";
            hizliIslemler(barkod);
        }

        private void btn_su05_Click(object sender, EventArgs e)
        {
            string barkod = "8654373083";
            hizliIslemler(barkod);
        }

        private void btn_su1_Click(object sender, EventArgs e)
        {
            string barkod = "8654373084";
            hizliIslemler(barkod);
        }

        private void btn_su5_Click(object sender, EventArgs e)
        {
            string barkod = "8654373085";
            hizliIslemler(barkod);
        }

        private void btn_bazlama_Click(object sender, EventArgs e)
        {
            string barkod = "8664271368";
            hizliIslemler(barkod);
        }

        Point lastPoint;
        private void form_satis_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_satis_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        Font baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        int itemId = 0;

        private void tumUrunler_Click(object sender, EventArgs e)
        {
            foreach (var item in db.urun.OrderBy(m => m.urunBarkod)) { hizliIslemler(item.urunBarkod.ToString()); }          
        }

        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int bosluk = 0;
            decimal kdvTutar = 0, kdvTopTutar = 0, araToplam = 0;
            var donguIfadesi = db.urunSatis.Where(s => s.faturaId == satis_satisFaturaNo);

            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("CovidMark Otomasyon", baslik, sb, 280, 80, st);
            e.Graphics.DrawImage(Properties.Resources.CovidMarkLogo, 25, 125, 362 * 75/100, 170 * 75/100);
            e.Graphics.DrawString("Fatura Kesim: " + db.fatura.Where(s => s.faturaID == satis_satisFaturaNo).FirstOrDefault().fatura_kesimTarih.ToString(), altBaslik, sb, 500, 160, st);
            e.Graphics.DrawString("Fatura No: " + db.fatura.Where(s => s.faturaID == satis_satisFaturaNo).FirstOrDefault().faturaID.ToString(), altBaslik, sb, 500, 180, st);
            e.Graphics.DrawString("Ödeme Türü:" + donguIfadesi.FirstOrDefault().satisTuru, altBaslik, sb, 500, 200, st);

            e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 300, st);
            e.Graphics.DrawString("Ürün Adı             |   Miktar   |   Birim Fiyat   |    KDV Tutar    |    Toplam", altBaslik, sb, 80, 325, st);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 350, st);


            foreach (var item in itemId == 0 ? donguIfadesi : donguIfadesi.Where(s => s.satisID > itemId))
            {
                kdvTutar = item.satisTopTutar - (item.satisAdet * item.satisBirimFiyat);

                string urunAdi = item.urun.urunAd;
                e.Graphics.DrawString(urunAdi.Length >= 16 ? urunAdi.Substring(0, 16) + "..." : urunAdi, icerik, sb, 70, 375 + (bosluk * 40), st);
                e.Graphics.DrawString("|", icerik, sb, 235, 375 + (bosluk * 40), st);
                e.Graphics.DrawString(item.satisAdet.ToString() , icerik, sb, 275, 375 + (bosluk * 40), st);
                e.Graphics.DrawString("|", icerik, sb, 330, 375 + (bosluk * 40), st);
                e.Graphics.DrawString(item.satisBirimFiyat.ToString(), icerik, sb, 370, 375 + (bosluk * 40), st);
                e.Graphics.DrawString("|", icerik, sb, 468, 375 + (bosluk * 40), st);
                e.Graphics.DrawString(kdvTutar.ToString(), icerik, sb, 520, 375 + (bosluk * 40), st);
                e.Graphics.DrawString("|", icerik, sb, 613, 375 + (bosluk * 40), st);
                e.Graphics.DrawString(item.satisTopTutar.ToString(), icerik, sb, 650, 375 + (bosluk * 40), st);

                kdvTopTutar += kdvTutar;

                araToplam += item.satisTopTutar - kdvTutar; 

                bosluk = bosluk + 1;

                if (bosluk < 14)
                {
                    e.HasMorePages = false;
                }
                else
                {
                    itemId = item.satisID;
                    e.HasMorePages = /*donguIfadesi.ToList().LastOrDefault().satisID == itemId ? false :*/ true;

                    return;
                }
            }
            //yemekten sonra decimal araToplam = topTutar - (donguIfadesi.Sum(s => s.satisAdet) * donguIfadesi.Sum(s => s.satisBirimFiyat));

                e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 375 + (bosluk * 40), st);
                e.Graphics.DrawString("Ara Toplam: " + araToplam + " TL", altBaslik, sb, 500, 375 + ((bosluk + 1) * 40), st);
                e.Graphics.DrawString("KDV: " + kdvTopTutar + " TL", altBaslik, sb, 500, 375 + ((bosluk + 2) * 40), st);
                e.Graphics.DrawString("Toplam Tutar: " + donguIfadesi.Sum(s => s.satisTopTutar) + " TL", altBaslik, sb, 500, 375 + ((bosluk + 3) * 40), st);
        }
    }
}