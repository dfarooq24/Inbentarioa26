using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class GailuakForm : Form
    {
        private readonly GailuaRepositorioa _repo = new();

        public GailuakForm() { InitializeComponent(); }

        private void GailuakForm_Load(object sender, EventArgs e) => Kargatu();

        private void Kargatu()
        {
            try { dgv.DataSource = _repo.GetAll(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnKargatu_Click(object sender, EventArgs e) => Kargatu();
        private void btnAtzera_Click(object sender, EventArgs e) => this.Close();

        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu gailu bat!", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_gailu"].Value);
            if (MessageBox.Show("Ziur zaude gailua ezabatu nahi duzula?\n\nGailua 'ezabatutako_gailua' taulan gordeko da.", "Ezabatu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try { _repo.Ezabatu(id); MessageBox.Show("Gailua ezabatuta eta artxibatua.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information); Kargatu(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnEditatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu gailu bat!", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_gailu"].Value);
            new GailuaEditatuForm(id).ShowDialog();
            Kargatu();
        }
    }
}
