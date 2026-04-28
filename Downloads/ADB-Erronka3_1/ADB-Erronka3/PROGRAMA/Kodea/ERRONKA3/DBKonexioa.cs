using MySql.Data.MySqlClient;

namespace ERRONKA3
{
    public class DBKonexioa
    {
        private string connectionString = "server=localhost;database=inbentarioa26;uid=root;pwd=root;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}