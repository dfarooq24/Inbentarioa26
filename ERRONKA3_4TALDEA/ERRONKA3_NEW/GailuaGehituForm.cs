using ERRONKA3.Modeloak;
using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class GailuaGehituForm : Form
    {
        private readonly GailuaRepositorioa _repo = new();

        public GailuaGehituForm() { InitializeComponent(); }

        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ord = cmbMota.Text.ToLower() == "ordenagailua";
            txtRAM.Enabled = txtROM.Enabled = txtCPU.Enabled = ord;
            chkKolorea.Enabled = !ord;
            pnlOrd.Visible = ord; pnlPrint.Visible = !ord;
            if (!ord) { txtRAM.Text = txtROM.Text = txtCPU.Text = ""; }
            else chkKolorea.Checked = false;
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) || cmbMota.SelectedIndex < 0 || cmbEgoera.SelectedIndex < 0)
            { MessageBox.Show("Bete beharrezko eremuak (Marka, Modelo, Mota, Egoera).", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                string mota = cmbMota.Text.ToLower();
                Gailua g = mota == "ordenagailua"
                    ? new Ordenagailua { RAM = txtRAM.Text, ROM = txtROM.Text, CPU = txtCPU.Text }
                    : (Gailua)new Inprimagailua { Kolorea = chkKolorea.Checked };
                g.Marka = txtMarka.Text; g.Modelo = txtModelo.Text;
                g.ErosketaData = dtpData.Value; g.Egoera = cmbEgoera.Text;
                g.IdMintegia = Convert.ToInt32(cmbMintegia.Text);
                _repo.Gehitu(g);
                MessageBox.Show("✔  Gailua ondo gorde da!", "Arrakasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAtzera_Click(object sender, EventArgs e) => this.Close();
    }
}
