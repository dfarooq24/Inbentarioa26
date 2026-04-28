using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CentrarPanel();
            this.Resize += (s, e) => CentrarPanel();
        }

        private void btnSaioaHasi_Click(object sender, EventArgs e)
        {
            string erabiltzailea = txtErabiltzailea.Text;
            string pasahitza = txtPasahitza.Text;

            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string query = "SELECT rola FROM erabiltzailea WHERE izena=@user AND pasahitza=@pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", erabiltzailea);
                cmd.Parameters.AddWithValue("@pass", pasahitza);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string rola = result.ToString();

                    MessageBox.Show("Login correcto! Rola: " + rola);

                    MenuNagusia menu = new MenuNagusia(rola);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblErabiltzailea_Click(object sender, EventArgs e)
        {

        }

        private void txtErabiltzailea_TextChanged(object sender, EventArgs e)
        {

        }

        private void CentrarPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void txtPasahitza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}