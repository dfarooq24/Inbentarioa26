using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    /// <summary>
    /// Saio hasteko formularioa.
    /// Erabiltzaile izena eta pasahitza egiaztatu eta rola arabera MenuNagusia irekitzen du.
    /// SQL koderik ez dago hemen — <see cref="ErabiltzaileaRepositorioa"/> erabiltzen du.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>Autentifikaziorako errepositorio instantzia.</summary>
        private readonly ErabiltzaileaRepositorioa _repo = new();

        /// <summary>LoginForm berri bat hasieratzen du.</summary>
        public LoginForm() { InitializeComponent(); }

        /// <summary>
        /// Sartu botoiaren klik gertaera. Eremuak egiaztatu eta autentifikatu.
        /// Arrakasta bada MenuNagusia irekitzen du rola pasatuz.
        /// </summary>
        private void btnSartu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Bete eremu guztiak.", "Oharra",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string? rola = _repo.Autentifikatu(txtUser.Text.Trim(), txtPass.Text);
                if (rola != null) { new MenuNagusia(rola).Show(); this.Hide(); }
                else MessageBox.Show("Erabiltzailea edo pasahitza okerrak.", "Login huts",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konexio errorea:\n" + ex.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Enter tekla sakatuz gero saioa hastea onartzen du.</summary>
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSartu_Click(sender, e);
        }
    }
}
