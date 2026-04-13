using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ERRONKA3
{
    public partial class GailuakForm : Form
    {
        public GailuakForm()
        {
            InitializeComponent();
        }

        private void GailuakForm_Load(object sender, EventArgs e)
        {
            KargatuGailuak();
        }

        private void KargatuGailuak()
        {
            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string query = "SELECT * FROM gailua";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvGailuak.DataSource = table;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnKargatu_Click(object sender, EventArgs e)
        {
            KargatuGailuak();
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hautatu gailu bat!");
                return;
            }

            int id = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["id_gailu"].Value);

            DialogResult result = MessageBox.Show(
                "Ziur zaude gailua ezabatu nahi duzula?",
                "Ezabatu",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No) return;

            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                // 1. Guardar en ezabatutako_gailua
                string insert = @"
            INSERT INTO ezabatutako_gailua
    (id_gailu_originala, marka, modelo, erosketa_data, egoera, mota, id_mintegia, ezabatze_data)
    SELECT id_gailu, marka, modelo, erosketa_data, egoera, mota, id_mintegia, NOW()
    FROM gailua
    WHERE id_gailu = @id";

                var cmd1 = new MySql.Data.MySqlClient.MySqlCommand(insert, conn);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.ExecuteNonQuery();

                // 2. Borrar de gailua
                string delete = "DELETE FROM gailua WHERE id_gailu = @id";

                var cmd2 = new MySql.Data.MySqlClient.MySqlCommand(delete, conn);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Gailua ezabatuta!");

                conn.Close();

                // 3. Recargar tabla
                btnKargatu_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void dgvGailuak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditatu_Click(object sender, EventArgs e)
        {
            if (dgvGailuak.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hautatu gailu bat!");
                return;
            }

            int id = Convert.ToInt32(dgvGailuak.SelectedRows[0].Cells["id_gailu"].Value);

            GailuaEditatuForm form = new GailuaEditatuForm(id);
            form.ShowDialog();

            KargatuGailuak();
        }
    }
}
