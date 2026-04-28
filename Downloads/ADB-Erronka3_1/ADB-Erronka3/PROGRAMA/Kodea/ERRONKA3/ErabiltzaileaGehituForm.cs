using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERRONKA3
{
    public partial class ErabiltzaileaGehituForm : Form
    {
        public ErabiltzaileaGehituForm()
        {
            InitializeComponent();
            CentrarPanel();
            this.Resize += (s, e) => CentrarPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                string izena = txtIzena.Text;
                string pasahitza = txtPasahitza.Text;
                string rola = cmbRola.Text;
                int id_mintegia = Convert.ToInt32(cmbMintegia.Text);

                string query = @"INSERT INTO erabiltzailea 
                         (izena, pasahitza, rola, id_mintegia)
                         VALUES (@izena, @pasahitza, @rola, @mintegia)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@pasahitza", pasahitza);
                cmd.Parameters.AddWithValue("@rola", rola);
                cmd.Parameters.AddWithValue("@mintegia", id_mintegia);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Erabiltzailea gehituta!");

                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea: " + ex.Message);
            }
        }

        private void txtIzena_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CentrarPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

    }
}
