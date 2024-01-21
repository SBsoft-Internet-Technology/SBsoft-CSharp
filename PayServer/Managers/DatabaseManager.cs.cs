using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace PayServer.Managers
{
    public class DatabaseManager
    {
        private string connectionString;

        public DatabaseManager(string databaseFilePath)
        {
            connectionString = $"Data Source={databaseFilePath};Version=3;";
        }

        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SQLiteDataReader ExecuteReader(string query)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, connection);
            return command.ExecuteReader();
        }
    }
}
