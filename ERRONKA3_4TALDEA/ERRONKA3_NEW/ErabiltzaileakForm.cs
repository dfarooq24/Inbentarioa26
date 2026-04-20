using ERRONKA3.Repositorioak;

namespace ERRONKA3
{
    public partial class ErabiltzaileakForm : Form
    {
        private readonly ErabiltzaileaRepositorioa _repo = new();
        public ErabiltzaileakForm() { InitializeComponent(); }
        private void ErabiltzaileakForm_Load(object sender, EventArgs e) => Kargatu();
        private void Kargatu() { try { dgv.DataSource = _repo.GetAll(); } catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message); } }
        private void btnKargatu_Click(object sender, EventArgs e) => Kargatu();
        private void btnAtzera_Click(object sender, EventArgs e) => Close();
        private void btnGehitu_Click(object sender, EventArgs e) { new ErabiltzaileaGehituForm().ShowDialog(); Kargatu(); }
        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0) { MessageBox.Show("Hautatu erabiltzaile bat!"); return; }
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_erab"].Value);
            if (MessageBox.Show("Ziur zaude erabiltzailea ezabatu nahi duzula?", "Ezabatu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try { _repo.Ezabatu(id); Kargatu(); } catch (Exception ex) { MessageBox.Show("Errorea: " + ex.Message); }
        }
    }
}
