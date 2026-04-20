using ERRONKA3.Modeloak;
using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class ErabiltzaileaGehituForm : Form
    {
        private readonly ErabiltzaileaRepositorioa _repo = new();
        public ErabiltzaileaGehituForm() { InitializeComponent(); }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) || string.IsNullOrWhiteSpace(txtPasahitza.Text) || cmbRola.SelectedIndex < 0)
            { MessageBox.Show("Bete beharrezko eremuak.", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                _repo.Gehitu(new Erabiltzailea { Izena=txtIzena.Text.Trim(), Pasahitza=txtPasahitza.Text,
                    Rola=cmbRola.Text, IdMintegia=Convert.ToInt32(cmbMintegia.Text) });
                MessageBox.Show("✔  Erabiltzailea gehituta!", "Arrakasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAtzera_Click(object sender, EventArgs e) => Close();
    }
}
