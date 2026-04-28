using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    /// <summary>
    /// Erabiltzaileen zerrenda formularioa.
    /// Sistemako erabiltzaile guztiak erakusten ditu eta kudeatzeko aukera ematen du.
    /// SQL koderik ez dago hemen — <see cref="ErabiltzaileaRepositorioa"/> erabiltzen du.
    /// </summary>
    public partial class ErabiltzaileakForm : Form
    {
        /// <summary>Erabiltzaile eragiketarako errepositorio instantzia.</summary>
        private readonly ErabiltzaileaRepositorioa _repo = new();

        /// <summary>ErabiltzaileakForm berri bat hasieratzen du.</summary>
        public ErabiltzaileakForm() { InitializeComponent(); }

        /// <summary>Formularioa kargatzean erabiltzaileak automatikoki kargatzen ditu.</summary>
        private void ErabiltzaileakForm_Load(object sender, EventArgs e) => Kargatu();

        /// <summary>Datu-basetik erabiltzaile guztiak kargatu eta DataGridView-ean erakusten ditu.</summary>
        private void Kargatu()
        {
            try { dgv.DataSource = _repo.GetAll(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>Kargatu botoiaren klik gertaera — zerrenda freskatu.</summary>
        private void btnKargatu_Click(object sender, EventArgs e) => Kargatu();

        /// <summary>Atzera botoiaren klik gertaera — formularioa itxi.</summary>
        private void btnAtzera_Click(object sender, EventArgs e) => Close();

        /// <summary>Gehitu botoiaren klik gertaera — ErabiltzaileaGehituForm ireki.</summary>
        private void btnGehitu_Click(object sender, EventArgs e) { new ErabiltzaileaGehituForm().ShowDialog(); Kargatu(); }

        /// <summary>
        /// Ezabatu botoiaren klik gertaera.
        /// Hautatutako erabiltzailea ezabatu aurretik berrespena eskatzen du.
        /// </summary>
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu erabiltzaile bat!", "Oharra", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_erab"].Value);
            if (MessageBox.Show("Ziur zaude erabiltzailea ezabatu nahi duzula?", "Ezabatu",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try { _repo.Ezabatu(id); Kargatu(); }
            catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message, "DB Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
