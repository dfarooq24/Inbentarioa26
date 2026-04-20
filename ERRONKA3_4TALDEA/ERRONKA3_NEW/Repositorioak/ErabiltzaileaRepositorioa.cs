using MySql.Data.MySqlClient;
using System.Data;
using ERRONKA3.Modeloak;

namespace ERRONKA3.Repositorioak
{
    public class ErabiltzaileaRepositorioa
    {
        private readonly DBKonexioa _db = DBKonexioa.Instancia;

        public string? Autentifikatu(string izena, string pasahitza)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand("SELECT rola FROM erabiltzailea WHERE izena=@u AND pasahitza=@p", conn);
            cmd.Parameters.AddWithValue("@u", izena);
            cmd.Parameters.AddWithValue("@p", pasahitza);
            return cmd.ExecuteScalar()?.ToString();
        }

        public DataTable GetAll()
        {
            using var conn = _db.GetConnection(); conn.Open();
            var dt = new DataTable();
            new MySqlDataAdapter("SELECT id_erab, izena, rola, id_mintegia FROM erabiltzailea", conn).Fill(dt);
            return dt;
        }

        public void Gehitu(Erabiltzailea e)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand("INSERT INTO erabiltzailea(izena,pasahitza,rola,id_mintegia) VALUES(@i,@p,@r,@m)", conn);
            cmd.Parameters.AddWithValue("@i", e.Izena);
            cmd.Parameters.AddWithValue("@p", e.Pasahitza);
            cmd.Parameters.AddWithValue("@r", e.Rola);
            cmd.Parameters.AddWithValue("@m", e.IdMintegia);
            cmd.ExecuteNonQuery();
        }

        public void Ezabatu(int id)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand("DELETE FROM erabiltzailea WHERE id_erab=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
