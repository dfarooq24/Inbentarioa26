using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    public partial class ErabiltzaileakForm : Form
    {
        public ErabiltzaileakForm()
        {
            InitializeComponent();
        }

        private void ErabiltzaileakForm_Load(object sender, EventArgs e)
        {
            KargatuErabiltzaileak();
        }

        private void KargatuErabiltzaileak()
        {
            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string query = "SELECT id_erab, izena, rola, id_mintegia FROM erabiltzailea";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvErabiltzaileak.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void btnKargatu_Click_1(object sender, EventArgs e)
        {
            KargatuErabiltzaileak();
        }

        private void btnAtzera_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvErabiltzaileak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            ErabiltzaileaGehituForm form = new ErabiltzaileaGehituForm();
            form.ShowDialog();

            KargatuErabiltzaileak();
        }

        private void btnEzabatu_Click(object sender, EventArgs e)
        {
            if (dgvErabiltzaileak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hautatu erabiltzaile bat!");
                return;
            }

            int id = Convert.ToInt32(dgvErabiltzaileak.SelectedRows[0].Cells["id_erab"].Value);

            DialogResult result = MessageBox.Show(
                "Ziur zaude erabiltzailea ezabatu nahi duzula?",
                "Ezabatu",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No) return;

            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string query = "DELETE FROM erabiltzailea WHERE id_erab = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Erabiltzailea ezabatuta!");

                conn.Close();

                KargatuErabiltzaileak(); // refrescar tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }
    }
}