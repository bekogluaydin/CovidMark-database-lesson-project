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
    public partial class form_Faturalar : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        int sorgu;
        string deger;
        public form_Faturalar()
        {
            InitializeComponent();
        }
        private void cm_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_tur.SelectedIndex != 0) { tb_deger.Enabled = true; cm_tur.Enabled = true; }
            else { tb_deger.Enabled = false; tb_deger.Text = ""; }
        }
        private void form_Faturalar_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.acikKullanici;
            cm_tur.Items.Add("Arama Türünü Seçin....");
            cm_tur.SelectedIndex = 0;
        }

        private void rb_alınan_CheckedChanged(object sender, EventArgs e)
        {
            cm_tur.Enabled = true;
            cm_tur.Items.Clear();
            cm_tur.Items.Add("Arama Türünü Seçin....");
            cm_tur.Items.Add("Vergi No");
            cm_tur.Items.Add("Firma Ad");
            cm_tur.SelectedIndex = 0;

            lv_liste.Clear();
            lv_liste.View = View.Details;
            lv_liste.GridLines = true;
            lv_liste.FullRowSelect = true;

            lv_liste.Columns.Add("Fatura ID", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Firma Vergi No", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Firma Adı", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Tür", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Tutar", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Kesim Tarihi", 100, HorizontalAlignment.Left);

            vt.faturaAlisListele(lv_liste);
        }

        private void rb_satilan_CheckedChanged(object sender, EventArgs e)
        {
            cm_tur.Enabled = true;
            cm_tur.Items.Clear();
            cm_tur.Items.Add("Arama Türünü Seçin....");
            cm_tur.Items.Add("Satış Türü");

            lv_liste.Clear();
            lv_liste.View = View.Details;
            lv_liste.GridLines = true;
            lv_liste.FullRowSelect = true;

            lv_liste.Columns.Add("Fatura ID", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Tür", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Ödeme Tür", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Tutar", 100, HorizontalAlignment.Left);
            lv_liste.Columns.Add("Fatura Kesim Tarihi", 100, HorizontalAlignment.Left);

            vt.faturaSatisListele(lv_liste);
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            deger = tb_deger.Text;

            if (rb_alınan.Checked == true)
            {
                vt.faturaAlisListele(lv_liste);
                if (tb_deger.Text != "")
                {
                    if (cm_tur.SelectedItem.ToString() == "Vergi No") { sorgu = 1; }
                    else if (cm_tur.SelectedItem.ToString() == "Firma Ad") { sorgu = 2; }

                    vt.stokAlısSorguListele(lv_liste, sorgu, deger);
                }
                else MessageBox.Show("Değer Boş Olamaz!");
            }

            else if (rb_satilan.Checked == true)
            {
                vt.faturaSatisListele(lv_liste);

                if (tb_deger.Text != "")
                {
                    if (cm_tur.SelectedItem.ToString() == "Satış Türü") { sorgu = 2; }

                    vt.stokAlısSorguListele(lv_liste, sorgu, deger);
                }
                else MessageBox.Show("Değer Boş Olamaz!");
            }

            else
            {
                MessageBox.Show("Lütfen Bir Şeçim Yapın!");
            }
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
        private void form_Faturalar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void form_Faturalar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lv_liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rb_alınan.Checked == true && rb_satilan.Checked == false)
            {
                foreach (ListViewItem item in lv_liste.SelectedItems)
                {
                    form_alis.alis_alisFaturaNo = Convert.ToInt32(item.SubItems[0].Text);
                    
                    this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(new form_alis().printDocument1_PrintPage);
                    printPreviewDialog1.ShowDialog();
                }
            }

            else if (rb_satilan.Checked == true && rb_alınan.Checked == false)
            {
                foreach (ListViewItem item in lv_liste.SelectedItems)
                {
                    form_satis.satis_satisFaturaNo = Convert.ToInt32(item.SubItems[0].Text);
                    this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(new form_satis().printDocument1_PrintPage);
                    printPreviewDialog2.ShowDialog();
                }
            }
        }
    }
}
