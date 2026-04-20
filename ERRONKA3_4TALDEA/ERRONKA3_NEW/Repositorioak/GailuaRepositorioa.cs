using MySql.Data.MySqlClient;
using System.Data;
using ERRONKA3.Modeloak;

namespace ERRONKA3.Repositorioak
{
    public class GailuaRepositorioa
    {
        private readonly DBKonexioa _db = DBKonexioa.Instancia;

        public DataTable GetAll()
        {
            using var conn = _db.GetConnection(); conn.Open();
            var dt = new DataTable();
            new MySqlDataAdapter("SELECT * FROM gailua", conn).Fill(dt);
            return dt;
        }

        public Gailua? GetById(int id)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM gailua WHERE id_gailu=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var r = cmd.ExecuteReader();
            if (!r.Read()) return null;
            string mota = r["mota"].ToString()!.ToLower().Trim();
            if (mota == "ordenagailua")
            {
                var g = MapBase<Ordenagailua>(r); r.Close();
                LoadOrdenagailua(conn, g); return g;
            }
            if (mota == "inprimagailua")
            {
                var g = MapBase<Inprimagailua>(r); r.Close();
                LoadInprimagailua(conn, g); return g;
            }
            return null;
        }

        private static T MapBase<T>(MySqlDataReader r) where T : Gailua, new() => new T
        {
            IdGailu = Convert.ToInt32(r["id_gailu"]), Marka = r["marka"].ToString()!,
            Modelo = r["modelo"].ToString()!, ErosketaData = Convert.ToDateTime(r["erosketa_data"]),
            Egoera = r["egoera"].ToString()!, IdMintegia = Convert.ToInt32(r["id_mintegia"])
        };

        private static void LoadOrdenagailua(MySqlConnection conn, Ordenagailua g)
        {
            var cmd = new MySqlCommand("SELECT * FROM ordenagailua WHERE id_gailu=@id", conn);
            cmd.Parameters.AddWithValue("@id", g.IdGailu);
            using var r = cmd.ExecuteReader();
            if (r.Read()) { g.RAM = r["ram"].ToString()!; g.ROM = r["rom"].ToString()!; g.CPU = r["cpu"].ToString()!; }
        }

        private static void LoadInprimagailua(MySqlConnection conn, Inprimagailua g)
        {
            var cmd = new MySqlCommand("SELECT * FROM inprimagailua WHERE id_gailu=@id", conn);
            cmd.Parameters.AddWithValue("@id", g.IdGailu);
            using var r = cmd.ExecuteReader();
            if (r.Read()) g.Kolorea = Convert.ToBoolean(r["kolorea"]);
        }

        public void Gehitu(Gailua g)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand(
                "INSERT INTO gailua(marka,modelo,erosketa_data,egoera,mota,id_mintegia) VALUES(@m,@mo,@d,@e,@mt,@mi)", conn);
            cmd.Parameters.AddWithValue("@m", g.Marka); cmd.Parameters.AddWithValue("@mo", g.Modelo);
            cmd.Parameters.AddWithValue("@d", g.ErosketaData); cmd.Parameters.AddWithValue("@e", g.Egoera);
            cmd.Parameters.AddWithValue("@mt", g.Mota); cmd.Parameters.AddWithValue("@mi", g.IdMintegia);
            cmd.ExecuteNonQuery(); g.IdGailu = (int)cmd.LastInsertedId;
            if (g is Ordenagailua o) InsertOrdenagailua(conn, o);
            else if (g is Inprimagailua i) InsertInprimagailua(conn, i);
        }

        private static void InsertOrdenagailua(MySqlConnection conn, Ordenagailua g)
        {
            var c = new MySqlCommand("INSERT INTO ordenagailua(id_gailu,ram,rom,cpu) VALUES(@id,@r,@ro,@c)", conn);
            c.Parameters.AddWithValue("@id", g.IdGailu); c.Parameters.AddWithValue("@r", g.RAM);
            c.Parameters.AddWithValue("@ro", g.ROM); c.Parameters.AddWithValue("@c", g.CPU);
            c.ExecuteNonQuery();
        }

        private static void InsertInprimagailua(MySqlConnection conn, Inprimagailua g)
        {
            var c = new MySqlCommand("INSERT INTO inprimagailua(id_gailu,kolorea) VALUES(@id,@k)", conn);
            c.Parameters.AddWithValue("@id", g.IdGailu); c.Parameters.AddWithValue("@k", g.Kolorea);
            c.ExecuteNonQuery();
        }

        public void Eguneratu(Gailua g)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var cmd = new MySqlCommand(
                "UPDATE gailua SET marka=@m,modelo=@mo,erosketa_data=@d,egoera=@e,mota=@mt,id_mintegia=@mi WHERE id_gailu=@id", conn);
            cmd.Parameters.AddWithValue("@m", g.Marka); cmd.Parameters.AddWithValue("@mo", g.Modelo);
            cmd.Parameters.AddWithValue("@d", g.ErosketaData); cmd.Parameters.AddWithValue("@e", g.Egoera);
            cmd.Parameters.AddWithValue("@mt", g.Mota); cmd.Parameters.AddWithValue("@mi", g.IdMintegia);
            cmd.Parameters.AddWithValue("@id", g.IdGailu); cmd.ExecuteNonQuery();
            if (g is Ordenagailua o) UpdateOrdenagailua(conn, o);
            else if (g is Inprimagailua i) UpdateInprimagailua(conn, i);
        }

        private static void UpdateOrdenagailua(MySqlConnection conn, Ordenagailua g)
        {
            var c = new MySqlCommand("UPDATE ordenagailua SET ram=@r,rom=@ro,cpu=@c WHERE id_gailu=@id", conn);
            c.Parameters.AddWithValue("@r", g.RAM); c.Parameters.AddWithValue("@ro", g.ROM);
            c.Parameters.AddWithValue("@c", g.CPU); c.Parameters.AddWithValue("@id", g.IdGailu);
            c.ExecuteNonQuery();
        }

        private static void UpdateInprimagailua(MySqlConnection conn, Inprimagailua g)
        {
            var c = new MySqlCommand("UPDATE inprimagailua SET kolorea=@k WHERE id_gailu=@id", conn);
            c.Parameters.AddWithValue("@k", g.Kolorea); c.Parameters.AddWithValue("@id", g.IdGailu);
            c.ExecuteNonQuery();
        }

        public void Ezabatu(int id)
        {
            using var conn = _db.GetConnection(); conn.Open();
            var ins = new MySqlCommand(
                @"INSERT INTO ezabatutako_gailua(id_gailu_originala,marka,modelo,erosketa_data,egoera,mota,id_mintegia,ezabatze_data)
                  SELECT id_gailu,marka,modelo,erosketa_data,egoera,mota,id_mintegia,NOW() FROM gailua WHERE id_gailu=@id", conn);
            ins.Parameters.AddWithValue("@id", id); ins.ExecuteNonQuery();
            var del = new MySqlCommand("DELETE FROM gailua WHERE id_gailu=@id", conn);
            del.Parameters.AddWithValue("@id", id); del.ExecuteNonQuery();
        }
    }
}
