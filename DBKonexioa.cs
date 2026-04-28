using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    /// <summary>
    /// Datu-basearen konexioa kudeatzen duen klasea.
    /// Singleton patroiarekin inplementatuta: aplikazio osoan instantzia bakarra existitzen da.
    /// </summary>
    public class DBKonexioa
    {
        /// <summary>Singleton instantzia bakarra gordetzen duen aldagai estatikoa.</summary>
        private static DBKonexioa? _inst;

        /// <summary>Thread-safe exekuziorako giltzarrapo objektua.</summary>
        private static readonly object _lock = new();

        /// <summary>MySQL datu-basearen konexio-katea.</summary>
        private readonly string _cs = "server=192.168.80.21;database=inbentarioa26;uid=root;pwd=root;";

        /// <summary>
        /// Konstruktorea pribatua. Kanpotik new DBKonexioa() deitzea eragozten du.
        /// </summary>
        private DBKonexioa() { }

        /// <summary>
        /// Singleton instantziarako sarbide puntua. Thread-safe inplementazioa.
        /// Lehendabiziko deialdian instantzia sortzen da; ondorengoetan berdina itzultzen da.
        /// </summary>
        public static DBKonexioa Instancia
        {
            get { lock (_lock) { return _inst ??= new DBKonexioa(); } }
        }

        /// <summary>
        /// MySQL datu-basearen konexio berri bat sortzen eta itzultzen du.
        /// Beti using blokean erabili konexioa automatikoki ixteko.
        /// </summary>
        /// <returns>Irekitzeko prest dagoen MySqlConnection objektua.</returns>
        public MySqlConnection GetConnection() => new MySqlConnection(_cs);
    }
}