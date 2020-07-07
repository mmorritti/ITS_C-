using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2_MySql_giusta_
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = @"Server=192.168.1.64/phpmyadmin;Database=vivaio;Uid=lavatricelove;Pwd=M4815162342a.;";
            connection.Open();

            MySqlCommand readerCommand = new MySqlCommand();
            readerCommand.Connection = connection;
            readerCommand.CommandText = "";

            MySqlDataReader reader = readerCommand.ExecuteReader();
            while (reader.Read())
            {
                string ris = reader[""].ToString();
            }
        }
    }
}
