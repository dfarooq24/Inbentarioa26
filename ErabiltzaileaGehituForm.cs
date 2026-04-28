using ERRONKA3.Modeloak;
using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    /// <summary>
    /// Erabiltzaile berri bat sisteman erregistratzeko formularioa.
    /// <see cref="Erabiltzailea"/> modelo objektua sortzen du eta
    /// <see cref="ErabiltzaileaRepositorioa"/> bidez gordetzen du.
    /// </summary>
    public partial class ErabiltzaileaGehituForm : Form
    {
        /// <summary>Erabiltzaile eragiketarako errepositorio instantzia.</summary>
        private readonly ErabiltzaileaRepositorioa _repo = new();

        /// <summary>ErabiltzaileaGehituForm berri bat hasieratzen du.</summary>
        public ErabiltzaileaGehituForm() { InitializeComponent(); }

        /// <summary>
        /// Gorde botoiaren klik gertaera.
        /// Beharrezko eremuak egiaztatu, Erabiltzailea objektua sortu eta gorde.
        /// </summary>
        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text) || string.IsNullOrWhiteSpace(txtPasahitza.Text) || cmbRola.SelectedIndex < 0)
            { MessageBox.Show("Bete beharrezko eremuak.", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                _repo.Gehitu(new Erabiltzailea
                {
                    Izena = txtIzena.Text.Trim(), Pasahitza = txtPasahitza.Text,
                    Rola = cmbRola.Text, IdMintegia = Convert.ToInt32(cmbMintegia.Text)
                });
                MessageBox.Show("✔  Erabiltzailea gehituta!", "Arrakasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Atzera botoiaren klik gertaera — formularioa itxi.</summary>
        private void btnAtzera_Click(object sender, EventArgs e) => Close();
    }
}
