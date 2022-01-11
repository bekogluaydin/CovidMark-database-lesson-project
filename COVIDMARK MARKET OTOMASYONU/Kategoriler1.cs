using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDMARK_MARKET_OTOMASYONU
{
    public partial class form_kategori : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_kategori()
        {
            InitializeComponent();
        }

        private void lbl_altkkod_Click(object sender, EventArgs e)
        {
         
        }

        private void form_kategori_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            vt.kategoriListele(lv_kategori);
            vt.altkategoriListele(lv_altKategori);
            cb_altkadkod.Items.Insert(0, "Kat Kod Seç");
            cb_altkadkod.SelectedIndex = 0;
            cb_vergi.SelectedIndex = 0;
            foreach (var item in db.kategori.ToList()) cb_altkadkod.Items.Add(item.katKod);
        }

        private void btn_altkolustur_Click(object sender, EventArgs e)
        {
            if (cb_altkadkod.SelectedIndex != 0 && tb_altkad.Text != "" && db.altKategori.Where(s => s.katAltAd == tb_altkad.Text).Count() == 0)
            {
                db.altKategori.Add(new altKategori
                {
                    katAltAd = tb_altkad.Text,
                    alt_katKod = cb_altkadkod.SelectedItem.ToString()            
                }); db.SaveChanges(); MessageBox.Show("Alt Kategori Başarıyla Kayıt Edildi");
                kategorilerBoxesTemizle();
                tb_altkad.Enabled = false;
            }
            else MessageBox.Show("Alt Kategori Kaydedilemedi!");
            vt.altkategoriListele(lv_altKategori);
            
        }

        private void btn_altsil_Click(object sender, EventArgs e)
        {
            altKategori altKategori = db.altKategori.Where(s => s.katAltAd == tb_altkad.Text).FirstOrDefault();

            if (altKategori != null)
            {
                
                int a = db.altKategori.Where(s => s.katAltAd == tb_altkad.Text).FirstOrDefault().altkatID;
                db.urun.RemoveRange(db.urun.Where(s => s.urun_altkatID == a));
 
                db.SaveChanges();

                db.altKategori.Remove(altKategori);

                if (db.SaveChanges() == 1)
                {
                    vt.altkategoriListele(lv_altKategori); kategorilerBoxesTemizle();
                    MessageBox.Show(tb_altkad.Text + " alt kategorisi başarılı bir şekilde silindi!");
                    tb_altkad.Enabled = false;
                }
            }
            else MessageBox.Show("Bu alt kategori zaten yok!");               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form_adminMainmenu gitadminMenu = new form_adminMainmenu(); gitadminMenu.Show(); //adminMainMenu göster diyoruz
        }

        private void btn_ksil_Click(object sender, EventArgs e)
        {
            kategori kategori = db.kategori.Where(s => s.katKod == tb_katkod.Text).FirstOrDefault();
            
            if(kategori != null)
            {
                    var icecekler = db.altKategori.Where(s => s.alt_katKod == tb_katkod.Text).Select(x => x.altkatID).ToList();                   
  
                    foreach (var item2 in icecekler)
                    {
                        db.urun.RemoveRange(db.urun.Where(s => s.urun_altkatID == item2));
                    }     
                    db.SaveChanges();

                db.altKategori.RemoveRange(db.altKategori.Where(s => s.alt_katKod == tb_katkod.Text)); db.SaveChanges();
                db.kategori.Remove(kategori);

                if (db.SaveChanges() == 1)
                {
                    vt.kategoriListele(lv_kategori); vt.altkategoriListele(lv_altKategori); kategorilerBoxesTemizle();
                    MessageBox.Show(kategori.katAd + " kategorisi başarılı bir şekilde silindi!");
                }
            } else MessageBox.Show("Bu kategori zaten yok!");
        }

        private void btn_kekle_Click(object sender, EventArgs e)
        {
            if (tb_katkod.Text != "" && tb_kad.Text != "" && cb_vergi.SelectedIndex != 0 && db.kategori.Where(s => s.katAd == tb_kad.Text || s.katKod == tb_katkod.Text).Count() == 0)
            {
                db.kategori.Add(new kategori
                {
                    katAd = tb_kad.Text,
                    katKod = tb_katkod.Text,
                    katVergi = Byte.Parse(cb_vergi.SelectedItem.ToString())
                }); db.SaveChanges(); MessageBox.Show("Kategori Başarıyla Kayıt Edildi");
                kategorilerBoxesTemizle();                
            }
            else MessageBox.Show("Kategori Kaydedilemedi!");
            vt.kategoriListele(lv_kategori);
        }

        private void kategorilerBoxesTemizle()
        {
            cb_altkadkod.Items.Clear();
            cb_altkadkod.Items.Insert(0, "Kat Kod Seç");
            foreach (var item in db.kategori.ToList()) cb_altkadkod.Items.Add(item.katKod);
            cb_altkadkod.SelectedIndex = 0;
            cb_vergi.SelectedIndex = 0;
            tb_altkad.Text = "";
            tb_kad.Text = "";  
            tb_katkod.Text = "";

            cb_altkadkod.Enabled = true;
            cb_vergi.Enabled = true;
            tb_altkad.Enabled = true;
            tb_kad.Enabled = true;
            tb_katkod.Enabled = true;
        }

        private void btn_ktemizle_Click(object sender, EventArgs e)
        {
            kategorilerBoxesTemizle();
            tb_altkad.Enabled = false;
        }

        private void lv_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_kategori.SelectedItems)
            {
                tb_katkod.Text = item.SubItems[1].Text;
                tb_kad.Text = item.SubItems[2].Text;
                cb_vergi.SelectedItem = item.SubItems[3].Text;
            }
            tb_katkod.Enabled = false;
            tb_kad.Enabled = false;
            cb_vergi.Enabled = false;
        }

        private void lv_altKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_altKategori.SelectedItems)
            {
                tb_altkad.Text = item.SubItems[1].Text;
                cb_altkadkod.SelectedItem = item.SubItems[2].Text;
            }
            tb_altkad.Enabled = false;
            cb_altkadkod.Enabled = false;
        }

        private void cb_altkadkod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_altkadkod.SelectedIndex != 0)
            {
                tb_altkad.Enabled = true;
            }
        }

        Point lastPoint;
        private void form_kategori_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_kategori_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
