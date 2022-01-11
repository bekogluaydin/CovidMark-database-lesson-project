using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COVIDMARK_MARKET_OTOMASYONU
{
    public partial class form_adminMainmenu : Form
    {
        covidmarkEntities db = new covidmarkEntities();
        veritabani vt = new veritabani();
        public form_adminMainmenu()
        {
            InitializeComponent();
        }

        private void form_adminMainmenu_Load(object sender, EventArgs e)
        {
            label4.Text = "v" + AssemblyName.GetAssemblyName("COVIDMARK MARKET OTOMASYONU.exe").Version.ToString();
            label1.Text = Properties.Settings.Default.acikKullanici;
            if ("Kasiyer" == Properties.Settings.Default.kullaniciGorev)
            {
                btn_alis.Enabled = false;
                btn_firma.Enabled = false;
                btn_kategori.Enabled = false;
                btn_personel.Enabled = false;
                btn_stok.Enabled = false;
                btn_urun.Enabled = false;
            }
            else if ("Muhasebe" == Properties.Settings.Default.kullaniciGorev)
            {
                btn_alis.Enabled = false;
                btn_satis.Enabled = false;
                btn_firma.Enabled = false;
                btn_kategori.Enabled = false;
                btn_urun.Enabled = false;
            }
            else if ("Reyon" == Properties.Settings.Default.kullaniciGorev)
            {
                btn_alis.Enabled = false;
                btn_satis.Enabled = false;
                btn_firma.Enabled = false;
                btn_kategori.Enabled = false;
                btn_urun.Enabled = false;
                btn_personel.Enabled = false;

            }

        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            this.Close();
            form_urunler gitUrun = new form_urunler(); gitUrun.Show();
        }

        private void btn_firma_Click(object sender, EventArgs e)
        {
            this.Close();
            form_firma gitFirma = new form_firma(); gitFirma.Show();
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            this.Close();
            form_personel gitPersonel = new form_personel(); gitPersonel.Show();
        }

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            this.Close();
            form_kategori gitKategori = new form_kategori(); gitKategori.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            CovidMark_Login gitLogin = new CovidMark_Login(); gitLogin.Show(); //adminMainMenu göster diyoruz
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            this.Close();
            form_stok gitStok = new form_stok(); gitStok.Show();
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_satis gitSatis = new form_satis(); gitSatis.Show();
        }

        private void btn_alis_Click(object sender, EventArgs e)
        {
            this.Close();
            form_alis gitAlis = new form_alis();
            gitAlis.Show();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            this.Close();
            form_Faturalar gitFatura = new form_Faturalar();
            gitFatura.Show();
        }

        Point lastPoint;
        private void form_adminMainmenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void form_adminMainmenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}