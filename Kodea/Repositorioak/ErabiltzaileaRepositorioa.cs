using MySql.Data.MySqlClient;
using System.Data;
using ERRONKA3.Modeloak;

namespace ERRONKA3.Repositorioak
{
    /// <summary>
    /// Erabiltzaileen datu-base eragiketak kudeatzen dituen errepositorio klasea.
    /// SQL guztia hemen dago zentralizatua — formularioek ez dute SQL koderik.
    /// </summary>
    public class ErabiltzaileaRepositorioa
    {
        /// <summary>Datu-basearen konexio Singleton-a.</summary>
        private readonly DBKonexioa _db = DBKonexioa.Instancia;

        /// <summary>
        /// Erabiltzaile bat autentifikatzen du izena eta pasahitza konparatuz.
        /// </summary>
        /// <param name="izena">Saioa hasteko erabiltzaile izena.</param>
        /// <param name="pasahitza">Erabiltzailearen pasahitza.</param>
        /// <returns>Erabiltzailearen rola arrakasta bada; <c>null</c> bestela.</returns>
        public string? Autentifikatu(string izena, string pasahitza)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand(
                "SELECT rola FROM erabiltzailea WHERE izena=@u AND pasahitza=@p", conn);
            cmd.Parameters.AddWithValue("@u", izena);
            cmd.Parameters.AddWithValue("@p", pasahitza);
            return cmd.ExecuteScalar()?.ToString();
        }

        /// <summary>
        /// Datu-baseko erabiltzaile guztiak itzultzen ditu DataGridView-erako.
        /// </summary>
        /// <returns>Erabiltzaileen datuak dituen <see cref="DataTable"/>.</returns>
        public DataTable GetAll()
        {
            using var conn = _db.GetConnection(); conn.Open();
            var dt = new DataTable();
            new MySqlDataAdapter(
                "SELECT id_erab, izena, rola, id_mintegia FROM erabiltzailea", conn).Fill(dt);
            return dt;
        }

        /// <summary>
        /// Erabiltzaile berri bat datu-basean gordetzen du.
        /// </summary>
        /// <param name="e">Gordetzeko <see cref="Erabiltzailea"/> objektua.</param>
        public void Gehitu(Erabiltzailea e)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand(
                "INSERT INTO erabiltzailea(izena,pasahitza,rola,id_mintegia) VALUES(@i,@p,@r,@m)", conn);
            cmd.Parameters.AddWithValue("@i", e.Izena);
            cmd.Parameters.AddWithValue("@p", e.Pasahitza);
            cmd.Parameters.AddWithValue("@r", e.Rola);
            cmd.Parameters.AddWithValue("@m", e.IdMintegia);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Erabiltzaile bat ID bidez ezabatzen du datu-basetik.
        /// </summary>
        /// <param name="id">Ezabatu beharreko erabiltzailearen ID zenbakia.</param>
        public void Ezabatu(int id)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand(
                "DELETE FROM erabiltzailea WHERE id_erab=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
