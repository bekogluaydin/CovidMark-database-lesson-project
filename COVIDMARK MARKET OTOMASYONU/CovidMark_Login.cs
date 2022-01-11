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
    public partial class CovidMark_Login : Form
    {
       
        public CovidMark_Login()
        {
            InitializeComponent();
        }

        private void lbl_pasicon_Click(object sender, EventArgs e)
        {

        }

        private void CovidMark_Login_Load(object sender, EventArgs e)
        {
            label4.Text = "v" + AssemblyName.GetAssemblyName("COVIDMARK MARKET OTOMASYONU.exe").Version.ToString();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_kadi.Clear();
            tb_parola.Clear();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            covidmarkEntities db = new covidmarkEntities();         

            personel personelBilgi = db.personel.Where(s => s.personelNo == tb_kadi.Text && s.personelSifre == tb_parola.Text).FirstOrDefault();

            if (personelBilgi != null)
            {
                Properties.Settings.Default.acikKullanici = personelBilgi.personelNo;
                Properties.Settings.Default.kullaniciGorev = personelBilgi.personelGorev;
                Properties.Settings.Default.Save();

                form_adminMainmenu gitadminMenu = new form_adminMainmenu(); //adminMainMenu göster diyoruz
                gitadminMenu.Show();
                this.Hide(); 
            }

            else
            {
                MessageBox.Show("böyle bir kullanıcı yok");
            }
           
        }

        private void tb_Enter(object sender, EventArgs e)
        {
            if (tb_kadi.Text == "Kullanıcı Adı")
            {
                tb_kadi.Clear();
                tb_kadi.ForeColor = Color.Black;
                tb_parola.Clear();
                tb_parola.ForeColor = Color.Black;
            }
        }
        Point lastPoint;
        private void CovidMark_Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CovidMark_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
    }
}
