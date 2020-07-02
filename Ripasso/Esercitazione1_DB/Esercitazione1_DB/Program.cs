using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione1_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-45672OV\SQLEXPRESS;
                                            Database=antiquario;
                                            Trusted_Connection=True;";
            connection.Open();//apertura conessione

            SqlCommand readerCommand = new SqlCommand();//reader
            readerCommand.Connection = connection;//connessione
            readerCommand.CommandText = "SELECT TOP (1000) [id],[description] FROM[antiquario].[dbo].[Category]"; //query

            SqlDataReader reader = readerCommand.ExecuteReader();


            while (reader.Read())
            {
                string ris = reader["Id"].ToString() + " - " + reader["Description"].ToString();
                Console.WriteLine(ris);
            }

            reader.Close();





            connection.Close();





            Console.ReadKey();
        }
    }
}
