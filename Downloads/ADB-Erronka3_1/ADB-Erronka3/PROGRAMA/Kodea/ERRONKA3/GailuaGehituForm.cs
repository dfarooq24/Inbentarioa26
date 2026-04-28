using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERRONKA3
{
    public partial class GailuaGehituForm : Form
    {
        public GailuaGehituForm()
        {
            InitializeComponent();
            CentrarPanel();
            this.Resize += (s, e) => CentrarPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mota = cmbMota.Text.ToLower();

            if (mota == "inprimagailua")
            {
                txtRAM.Enabled = false;
                txtROM.Enabled = false;
                txtCPU.Enabled = false;

                txtRAM.Text = "";
                txtROM.Text = "";
                txtCPU.Text = "";

                chkKolorea.Enabled = true;
            }
            else if (mota == "ordenagailua")
            {
                txtRAM.Enabled = true;
                txtROM.Enabled = true;
                txtCPU.Enabled = true;

                chkKolorea.Enabled = false;
                chkKolorea.Checked = false;
            }
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string marka = txtMarka.Text;
                string modelo = txtModelo.Text;
                DateTime data = dtpErosketaData.Value;
                string mota = cmbMota.Text;
                string egoera = cmbEgoera.Text;
                int id_mintegia = Convert.ToInt32(cmbMintegia.Text);

                string query1 = "INSERT INTO gailua (marka, modelo, erosketa_data, egoera, mota, id_mintegia) " +
                                "VALUES (@marka, @modelo, @data, @egoera, @mota, @mintegia)";

                MySql.Data.MySqlClient.MySqlCommand cmd1 =
                    new MySql.Data.MySqlClient.MySqlCommand(query1, conn);

                cmd1.Parameters.AddWithValue("@marka", marka);
                cmd1.Parameters.AddWithValue("@modelo", modelo);
                cmd1.Parameters.AddWithValue("@data", data);
                cmd1.Parameters.AddWithValue("@egoera", egoera);
                cmd1.Parameters.AddWithValue("@mota", mota);
                cmd1.Parameters.AddWithValue("@mintegia", id_mintegia);

                cmd1.ExecuteNonQuery();

                int id_gailu = (int)cmd1.LastInsertedId;

                if (mota == "ordenagailua")
                {
                    string query2 = "INSERT INTO ordenagailua (id_gailu, ram, rom, cpu) VALUES (@id, @ram, @rom, @cpu)";

                    MySql.Data.MySqlClient.MySqlCommand cmd2 =
                        new MySql.Data.MySqlClient.MySqlCommand(query2, conn);

                    cmd2.Parameters.AddWithValue("@id", id_gailu);
                    cmd2.Parameters.AddWithValue("@ram", txtRAM.Text);
                    cmd2.Parameters.AddWithValue("@rom", txtROM.Text);
                    cmd2.Parameters.AddWithValue("@cpu", txtCPU.Text);

                    cmd2.ExecuteNonQuery();
                }
                else if (mota == "inprimagailua")
                {
                    string query3 = "INSERT INTO inprimagailua (id_gailu, kolorea) VALUES (@id, @kolorea)";

                    MySql.Data.MySqlClient.MySqlCommand cmd3 =
                        new MySql.Data.MySqlClient.MySqlCommand(query3, conn);

                    cmd3.Parameters.AddWithValue("@id", id_gailu);
                    cmd3.Parameters.AddWithValue("@kolorea", chkKolorea.Checked);

                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show("Gailua ondo gorde da!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CentrarPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2 - 20;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
