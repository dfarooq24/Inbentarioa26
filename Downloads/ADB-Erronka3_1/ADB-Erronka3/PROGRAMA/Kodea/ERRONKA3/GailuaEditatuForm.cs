using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    public partial class GailuaEditatuForm : Form
    {
        private int id_gailu;

        public GailuaEditatuForm(int id)
        {
            InitializeComponent();
            id_gailu = id;
            KargatuDatuak();
        }

        private void KargatuDatuak()
        {
            DBKonexioa db = new DBKonexioa();

            try
            {
                var conn = db.GetConnection();
                conn.Open();

                string query = "SELECT * FROM gailua WHERE id_gailu = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_gailu);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMarka.Text = reader["marka"].ToString();
                    txtModelo.Text = reader["modelo"].ToString();
                    dtpErosketaData.Value = Convert.ToDateTime(reader["erosketa_data"]);
                    cmbMota.Text = reader["mota"].ToString();
                    cmbMintegia.Text = reader["id_mintegia"].ToString();
                    cmbEgoera.Text = reader["egoera"].ToString();
                }

                reader.Close();

                string mota = cmbMota.Text.ToLower().Trim();

                if (mota == "ordenagailua")
                {
                    string query2 = "SELECT * FROM ordenagailua WHERE id_gailu = @id";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@id", id_gailu);

                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        txtRAM.Text = reader2["ram"].ToString();
                        txtROM.Text = reader2["rom"].ToString();
                        txtCPU.Text = reader2["cpu"].ToString();
                    }

                    reader2.Close();

                    txtRAM.Enabled = true;
                    txtROM.Enabled = true;
                    txtCPU.Enabled = true;
                    chkKolorea.Enabled = false;
                    chkKolorea.Checked = false;
                }
                else if (mota == "inprimagailua")
                {
                    string query3 = "SELECT * FROM inprimagailua WHERE id_gailu = @id";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@id", id_gailu);

                    MySqlDataReader reader3 = cmd3.ExecuteReader();

                    if (reader3.Read())
                    {
                        chkKolorea.Checked = Convert.ToBoolean(reader3["kolorea"]);
                    }

                    reader3.Close();

                    txtRAM.Enabled = false;
                    txtROM.Enabled = false;
                    txtCPU.Enabled = false;
                    txtRAM.Text = "";
                    txtROM.Text = "";
                    txtCPU.Text = "";
                    chkKolorea.Enabled = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
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

                string update1 = @"UPDATE gailua 
                                   SET marka=@marka, modelo=@modelo, erosketa_data=@data,
                                       egoera=@egoera, mota=@mota, id_mintegia=@mintegia
                                   WHERE id_gailu=@id";

                MySqlCommand cmd1 = new MySqlCommand(update1, conn);
                cmd1.Parameters.AddWithValue("@marka", marka);
                cmd1.Parameters.AddWithValue("@modelo", modelo);
                cmd1.Parameters.AddWithValue("@data", data);
                cmd1.Parameters.AddWithValue("@egoera", egoera);
                cmd1.Parameters.AddWithValue("@mota", mota);
                cmd1.Parameters.AddWithValue("@mintegia", id_mintegia);
                cmd1.Parameters.AddWithValue("@id", id_gailu);

                cmd1.ExecuteNonQuery();

                if (mota == "ordenagailua")
                {
                    string update2 = @"UPDATE ordenagailua 
                                       SET ram=@ram, rom=@rom, cpu=@cpu
                                       WHERE id_gailu=@id";

                    MySqlCommand cmd2 = new MySqlCommand(update2, conn);
                    cmd2.Parameters.AddWithValue("@ram", txtRAM.Text);
                    cmd2.Parameters.AddWithValue("@rom", txtROM.Text);
                    cmd2.Parameters.AddWithValue("@cpu", txtCPU.Text);
                    cmd2.Parameters.AddWithValue("@id", id_gailu);

                    cmd2.ExecuteNonQuery();
                }
                else if (mota == "inprimagailua")
                {
                    string update3 = @"UPDATE inprimagailua 
                                       SET kolorea=@kolorea
                                       WHERE id_gailu=@id";

                    MySqlCommand cmd3 = new MySqlCommand(update3, conn);
                    cmd3.Parameters.AddWithValue("@kolorea", chkKolorea.Checked);
                    cmd3.Parameters.AddWithValue("@id", id_gailu);

                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show("Gailua eguneratuta!");
                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GailuaEditatuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnGorde_Click_1(object sender, EventArgs e)
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

                string update1 = @"UPDATE gailua 
                           SET marka=@marka, modelo=@modelo, erosketa_data=@data,
                               egoera=@egoera, mota=@mota, id_mintegia=@mintegia
                           WHERE id_gailu=@id";

                MySqlCommand cmd1 = new MySqlCommand(update1, conn);
                cmd1.Parameters.AddWithValue("@marka", marka);
                cmd1.Parameters.AddWithValue("@modelo", modelo);
                cmd1.Parameters.AddWithValue("@data", data);
                cmd1.Parameters.AddWithValue("@egoera", egoera);
                cmd1.Parameters.AddWithValue("@mota", mota);
                cmd1.Parameters.AddWithValue("@mintegia", id_mintegia);
                cmd1.Parameters.AddWithValue("@id", id_gailu);

                cmd1.ExecuteNonQuery();

                if (mota == "ordenagailua")
                {
                    string update2 = @"UPDATE ordenagailua 
                               SET ram=@ram, rom=@rom, cpu=@cpu
                               WHERE id_gailu=@id";

                    MySqlCommand cmd2 = new MySqlCommand(update2, conn);
                    cmd2.Parameters.AddWithValue("@ram", txtRAM.Text);
                    cmd2.Parameters.AddWithValue("@rom", txtROM.Text);
                    cmd2.Parameters.AddWithValue("@cpu", txtCPU.Text);
                    cmd2.Parameters.AddWithValue("@id", id_gailu);

                    cmd2.ExecuteNonQuery();
                }
                else if (mota == "inprimagailua")
                {
                    string update3 = @"UPDATE inprimagailua 
                               SET kolorea=@kolorea
                               WHERE id_gailu=@id";

                    MySqlCommand cmd3 = new MySqlCommand(update3, conn);
                    cmd3.Parameters.AddWithValue("@kolorea", chkKolorea.Checked);
                    cmd3.Parameters.AddWithValue("@id", id_gailu);

                    cmd3.ExecuteNonQuery();
                }

                MessageBox.Show("Gailua eguneratuta!");
                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void btnAztera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMota_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mota = cmbMota.Text.ToLower().Trim();

            if (mota == "ordenagailua")
            {
                txtRAM.Enabled = true;
                txtROM.Enabled = true;
                txtCPU.Enabled = true;

                chkKolorea.Enabled = false;
                chkKolorea.Checked = false;
            }
            else if (mota == "inprimagailua")
            {
                txtRAM.Enabled = false;
                txtROM.Enabled = false;
                txtCPU.Enabled = false;

                txtRAM.Text = "";
                txtROM.Text = "";
                txtCPU.Text = "";

                chkKolorea.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public GailuaEditatuForm()
        {
            InitializeComponent();
            CentrarPanel();
            this.Resize += (s, e) => CentrarPanel();
        }

        private void CentrarPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2 - 30;
        }
    }
}