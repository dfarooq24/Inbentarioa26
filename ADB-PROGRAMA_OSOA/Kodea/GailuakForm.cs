using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    /// <summary>
    /// Gailuen zerrenda formularioa.
    /// Inbentarioko gailu guztiak DataGridView-ean erakusten ditu.
    /// SQL koderik ez dago hemen — <see cref="GailuaRepositorioa"/> erabiltzen du.
    /// </summary>
    public partial class GailuakForm : Form
    {
        /// <summary>Gailu eragiketarako errepositorio instantzia.</summary>
        private readonly GailuaRepositorioa _repo = new();

        /// <summary>GailuakForm berri bat hasieratzen du.</summary>
        public GailuakForm() { InitializeComponent(); }

        /// <summary>Formularioa kargatzean gailuak automatikoki kargatzen ditu.</summary>
        private void GailuakForm_Load(object sender, EventArgs e) => Kargatu();

        /// <summary>Datu-basetik gailu guztiak kargatu eta DataGridView-ean erakusten ditu.</summary>
        private void Kargatu()
        {
            try { dgv.DataSource = _repo.GetAll(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Kargatu botoiaren klik gertaera — zerrenda freskatu.</summary>
        private void btnKargatu_Click(object sender, EventArgs e) => Kargatu();

        /// <summary>Atzera botoiaren klik gertaera — formularioa itxi.</summary>
        private void btnAtzera_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Ezabatu botoiaren klik gertaera.
        /// Hautatutako gailua ezabatu aurretik berrespena eskatzen du.
        /// Gailua ezabatutako_gailua taulan gordetzen da auditoria-erregistro gisa.
        /// </summary>
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu gailu bat!", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_gailu"].Value);
            if (MessageBox.Show("Ziur zaude gailua ezabatu nahi duzula?\n\nGailua artxibatuko da.",
                    "Ezabatu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try { _repo.Ezabatu(id); Kargatu(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Editatu botoiaren klik gertaera.
        /// Hautatutako gailu ID-arekin GailuaEditatuForm irekitzen du.
        /// </summary>
        private void btnEditatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu gailu bat!", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_gailu"].Value);
            new GailuaEditatuForm(id).ShowDialog();
            Kargatu();
        }
    }
}
