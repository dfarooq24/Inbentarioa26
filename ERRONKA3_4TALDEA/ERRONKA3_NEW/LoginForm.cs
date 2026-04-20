using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class LoginForm : Form
    {
        private readonly ErabiltzaileaRepositorioa _repo = new();

        public LoginForm() { InitializeComponent(); }

        private void btnSartu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            { MessageBox.Show("Bete eremu guztiak.", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                string? rola = _repo.Autentifikatu(txtUser.Text.Trim(), txtPass.Text);
                if (rola != null) { new MenuNagusia(rola).Show(); this.Hide(); }
                else MessageBox.Show("Erabiltzailea edo pasahitza okerrak.", "Login huts", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show("Konexio errorea:\n" + ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Enter) btnSartu_Click(sender, e); }
    }
}
