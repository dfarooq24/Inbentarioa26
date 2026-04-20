using ERRONKA3.Modeloak;
using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class GailuaEditatuForm : Form
    {
        private readonly GailuaRepositorioa _repo = new();
        private readonly int _id;

        public GailuaEditatuForm(int id) { InitializeComponent(); _id = id; KargatuDatuak(); }

        private void KargatuDatuak()
        {
            try
            {
                Gailua? g = _repo.GetById(_id);
                if (g == null) { MessageBox.Show("Gailua ez da aurkitu!"); Close(); return; }
                txtMarka.Text = g.Marka; txtModelo.Text = g.Modelo;
                dtpData.Value = g.ErosketaData; cmbMota.Text = g.Mota;
                cmbMintegia.Text = g.IdMintegia.ToString(); cmbEgoera.Text = g.Egoera;

                if (g is Ordenagailua o)
                {
                    txtRAM.Text = o.RAM; txtROM.Text = o.ROM; txtCPU.Text = o.CPU;
                    txtRAM.Enabled = txtROM.Enabled = txtCPU.Enabled = true;
                    chkKolorea.Enabled = false; chkKolorea.Checked = false;
                    pnlOrd.Visible = true; pnlPrint.Visible = false;
                }
                else if (g is Inprimagailua i)
                {
                    chkKolorea.Checked = i.Kolorea; chkKolorea.Enabled = true;
                    txtRAM.Enabled = txtROM.Enabled = txtCPU.Enabled = false;
                    pnlOrd.Visible = false; pnlPrint.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ord = cmbMota.Text.ToLower().Trim() == "ordenagailua";
            txtRAM.Enabled = txtROM.Enabled = txtCPU.Enabled = ord;
            chkKolorea.Enabled = !ord;
            pnlOrd.Visible = ord; pnlPrint.Visible = !ord;
            if (!ord) { txtRAM.Text = txtROM.Text = txtCPU.Text = ""; }
            else chkKolorea.Checked = false;
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            try
            {
                string mota = cmbMota.Text.ToLower().Trim();
                Gailua g = mota == "ordenagailua"
                    ? new Ordenagailua { RAM = txtRAM.Text, ROM = txtROM.Text, CPU = txtCPU.Text }
                    : (Gailua)new Inprimagailua { Kolorea = chkKolorea.Checked };
                g.IdGailu = _id; g.Marka = txtMarka.Text; g.Modelo = txtModelo.Text;
                g.ErosketaData = dtpData.Value; g.Egoera = cmbEgoera.Text;
                g.IdMintegia = Convert.ToInt32(cmbMintegia.Text);
                _repo.Eguneratu(g);
                MessageBox.Show("✔  Gailua eguneratuta!", "Arrakasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnAtzera_Click(object sender, EventArgs e) => Close();
        private void GailuaEditatuForm_Load(object sender, EventArgs e) { }
    }
}
