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
    public partial class form_alis : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_alis()
        {
            InitializeComponent();
        }

        private void sayac_Tick_1(object sender, EventArgs e)
        {
            lbl_tarih.Text = DateTime.Now.ToString();
        }

        private void form_fatura_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
        }

        private void gb_fatura_Enter(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_ubarkod.Text = "";
            tb_fvergiNo.Text = "";
            tb_adet.Text = "";
            tb_alısfiyat.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_ubarkod_TextChanged(object sender, EventArgs e)
        {
            urun urun = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).FirstOrDefault();

            if (urun != null) tb_auad.Text = urun.urunAd;
            else tb_auad.Text = "";
        }

        private void tb_fvergiNo_TextChanged(object sender, EventArgs e)
        {
            firma firma = db.firma.Where(s => s.vergiNo == tb_fvergiNo.Text).FirstOrDefault();

            if (firma != null) tb_afad.Text = firma.firmaAd;
            else tb_afad.Text = "";
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if ("Kasiyer" == Properties.Settings.Default.kullaniciGorev) System.Windows.Forms.Application.Exit();
            else { this.Close(); form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems) item.Remove();

            lbl_toplam1.Text = "0";
            foreach (ListViewItem item2 in listView1.Items) lbl_toplam1.Text = (Decimal.Parse(lbl_toplam1.Text) + Decimal.Parse(item2.SubItems[8].Text)).ToString();

            tb_fvergiNo.Enabled = !listview_urunVarmi(listView1);
        }

        public bool listview_urunVarmi(ListView list) => listView1.Items.Count >= 1 ? true : false;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            var items = db.urun.Where(s => s.urunBarkod == tb_ubarkod.Text).ToList();
            var items1 = db.firma.Where(a => a.vergiNo == tb_fvergiNo.Text).ToList();
            int islemNo = db.urunAlis.FirstOrDefault() != null ? db.urunAlis.OrderByDescending(s => s.alis_islemNo).FirstOrDefault().alis_islemNo : 0;

            try
            {
                
                if (items.Count() != 0 && items1.Count() !=0 && Convert.ToInt16(tb_adet.Text) >= 1)
                {
                    if (Convert.ToInt16(tb_adet.Text) >= 256)
                    {
                        MessageBox.Show("Adet sayısı en fazla 255 olabilir");
                    }

                    else
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = (islemNo + 1).ToString();
                        item.SubItems.Add(items1.FirstOrDefault().vergiNo.ToString());
                        item.SubItems.Add(items1.FirstOrDefault().firmaAd.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunBarkod.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunKod.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunAd.ToString());
                        item.SubItems.Add(items.FirstOrDefault().urunBirim.ToString());
                        item.SubItems.Add(tb_adet.Text);
                        item.SubItems.Add(tb_alısfiyat.Text);
                        item.SubItems.Add((Decimal.Parse(tb_adet.Text) * Decimal.Parse(tb_alısfiyat.Text)).ToString());
                        item.SubItems.Add(DateTime.Now.ToString());

                        listView1.Items.Add(item);


                        lbl_toplam1.Text = "0";
                        foreach (ListViewItem item2 in listView1.Items) lbl_toplam1.Text = (Decimal.Parse(lbl_toplam1.Text) + Decimal.Parse(item2.SubItems[9].Text)).ToString();

                        tb_fvergiNo.Enabled = !listview_urunVarmi(listView1);
                    }                
                }
                else MessageBox.Show("Bilgileri Doğru Girin!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorun oluştu");
            }
        }
        public static int alis_alisFaturaNo = 0;
        private void btn_alisTamamla_Click(object sender, EventArgs e)
        {
            covidmarkEntities db = vt.alisEkle(listView1, label1);

            if (db != null && db.SaveChanges() != 0) 
            { 
                MessageBox.Show("Alış Tamamlandı"); 
                foreach (ListViewItem item in listView1.Items) item.Remove(); 
                lbl_toplam1.Text = "0";
                tb_fvergiNo.Enabled = !listview_urunVarmi(listView1);

                if (db.urunAlis.OrderByDescending(s => s.alis_islemNo).FirstOrDefault().faturaId != null)
                {
                    alis_alisFaturaNo = (int)db.urunAlis.OrderByDescending(s => s.alis_islemNo).FirstOrDefault().faturaId;
                    printPreviewDialog1.ShowDialog();
                }
                btn_temizle_Click(sender, e);
            }
            else MessageBox.Show("Aşağıdaki Nedenlerden Ötürü Satış Tamamlanamadı \n \r Alış İptal Edildi \n \r Ürün Girilmemiş");
        }

        Font baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        int itemId = 0;
        public void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string firmaAd = db.fatura.Where(s => s.faturaID == alis_alisFaturaNo).FirstOrDefault().urunAlis.FirstOrDefault().firma.firmaAd;
            int bosluk = 0;
            decimal kdvTutar = 0;
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("CovidMark Otomasyon", baslik, sb, 280, 80, st);
            e.Graphics.DrawImage(Properties.Resources.CovidMarkLogo, 25, 125, 362 * 75 / 100, 170 * 75 / 100);
            e.Graphics.DrawString("Fatura Kesim: " + db.fatura.Where(s => s.faturaID == alis_alisFaturaNo).FirstOrDefault().fatura_kesimTarih.ToString(), altBaslik, sb, 500, 160, st);
            e.Graphics.DrawString("Fatura No: " + db.fatura.Where(s => s.faturaID == alis_alisFaturaNo).FirstOrDefault().faturaID.ToString(), altBaslik, sb, 500, 180, st);
            e.Graphics.DrawString("Firma Vergi No :" + db.fatura.Where(s => s.faturaID == alis_alisFaturaNo).FirstOrDefault().urunAlis.FirstOrDefault().firma.vergiNo, altBaslik, sb, 500, 200, st);
            e.Graphics.DrawString("Firma Adı: " + (firmaAd.Length >= 21 ? firmaAd.Substring(0, 21) + "..." : firmaAd), altBaslik, sb, 500, 220, st);
            e.Graphics.DrawString("Ödeme Türü: Nakit", altBaslik, sb, 500, 240, st);

            e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 300, st);
            e.Graphics.DrawString("Ürün Adı             |   Miktar   |   Birim Fiyat   |    KDV Tutar    |    Toplam", altBaslik, sb, 80, 325, st);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 350, st);

            var donguIfadesi = db.urunAlis.Where(s => s.faturaId == alis_alisFaturaNo);

            foreach (var item in itemId == 0 ? donguIfadesi : donguIfadesi.Where(s => s.alisID > itemId))
            {
                kdvTutar = item.alisTopTutar - (item.alisAdet * item.alisBirimFiyat);

                string urunAdi = item.urun.urunAd;
                e.Graphics.DrawString(urunAdi.Length >= 16 ? urunAdi.Substring(0, 16) + "..." : urunAdi, icerik, sb, 70, 375 + (bosluk * 35), st);
                e.Graphics.DrawString("|", icerik, sb, 235, 375 + (bosluk * 35), st);
                e.Graphics.DrawString(item.alisAdet.ToString(), icerik, sb, 275, 375 + (bosluk * 35), st);
                e.Graphics.DrawString("|", icerik, sb, 330, 375 + (bosluk * 35), st);
                e.Graphics.DrawString(item.alisBirimFiyat.ToString(), icerik, sb, 370, 375 + (bosluk * 35), st);
                e.Graphics.DrawString("|", icerik, sb, 468, 375 + (bosluk * 35), st);
                e.Graphics.DrawString(kdvTutar.ToString(), icerik, sb, 520, 375 + (bosluk * 35), st);
                e.Graphics.DrawString("|", icerik, sb, 613, 375 + (bosluk * 35), st);
                e.Graphics.DrawString(item.alisTopTutar.ToString(), icerik, sb, 650, 375 + (bosluk * 35), st);

                bosluk = bosluk + 1;

                if (bosluk < 14)
                {
                    e.HasMorePages = false;
                }
                else
                {
                    itemId = item.alisID;
                    e.HasMorePages = /*donguIfadesi.ToList().LastOrDefault().satisID == itemId ? false :*/ true;

                    return;
                }
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------", altBaslik, sb, 70, 375 + (bosluk * 35), st);
            e.Graphics.DrawString("Toplam Tutar: " + donguIfadesi.Sum(s => s.alisTopTutar) + " TL", altBaslik, sb, 500, 385 + ((bosluk + 1) * 35), st);
        }

        Point lastPoint;
        private void form_alis_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_alis_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
