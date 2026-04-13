using System;
using System.Windows.Forms;

namespace ERRONKA3
{
    public partial class MenuNagusia : Form
    {
        private string rola;

        public MenuNagusia(string rola)
        {
            InitializeComponent();
            this.rola = rola;
        }

        private void MenuNagusia_Load(object sender, EventArgs e)
        {
            rola = rola.Trim().ToLower();

            if (rola == "irakaslea")
            {
                btnGailuaGehitu.Visible = false;
                btnErabiltzaileakKudeatu.Visible = false;
            }
            else if (rola == "mintegi_burua")
            {
                btnErabiltzaileakKudeatu.Visible = false;
            }
            else if (rola == "admin")
            {
                // ve todo
            }
        }

        private void btnGailuakIkusi_Click(object sender, EventArgs e)
        {
            GailuakForm form = new GailuakForm();
            form.Show();
        }

        private void btnIrten_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNagusia_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGailuakIkusi_Click_1(object sender, EventArgs e)
        {
            GailuakForm form = new GailuakForm();
            form.Show();
        }

        private void btnGailuaGehitu_Click(object sender, EventArgs e)
        {
            GailuaGehituForm form = new GailuaGehituForm();
            form.Show();
        }

        private void btnErabiltzaileakKudeatu_Click(object sender, EventArgs e)
        {
            ErabiltzaileakForm form = new ErabiltzaileakForm();
            form.Show();
        }
    }
}