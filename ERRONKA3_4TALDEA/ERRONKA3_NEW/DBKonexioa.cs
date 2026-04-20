using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    public class DBKonexioa
    {
        private static DBKonexioa? _inst;
        private static readonly object _lock = new();
        private readonly string _cs = "server=localhost;database=inbentarioa26;uid=root;pwd=root;";
        private DBKonexioa() { }
        public static DBKonexioa Instancia { get { lock (_lock) { return _inst ??= new DBKonexioa(); } } }
        public MySqlConnection GetConnection() => new MySqlConnection(_cs);
    }
}
