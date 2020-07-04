using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione2_DB
{
    class Program
    {
        static void Main(string[] args)
        {

            //Apertura connessione
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-45672OV\SQLEXPRESS;" +
                "Database=antiquario;" +
                "Trusted_Connection=True;" +
                "MultipleActiveResultSets=true;";
            connection.Open();

            //READER COMMAND
            SqlCommand readerCommand = new SqlCommand();
            readerCommand.Connection = connection;
            readerCommand.CommandText = "SELECT * FROM [Inventory]";
            SqlDataReader reader = readerCommand.ExecuteReader();
           
            
            while (reader.Read())
            {
                String ris = reader["Id"].ToString() + " - " + reader["Price"].ToString() + " Euro";
                Console.WriteLine(ris);
            }

            reader.Close();

            Console.WriteLine();

            //Secondo comando reader
            SqlCommand readerCommand2 = new SqlCommand();
            readerCommand2.Connection = connection;
            readerCommand2.CommandText = "SELECT * FROM [Offer]";
            SqlDataReader reader2 = readerCommand2.ExecuteReader();

            while (reader2.Read())
            {
                string ris = reader2["Id"].ToString() + " - " + reader2["ValidFrom"].ToString() + " " +
                    reader2["ValidTo"].ToString();

                Console.WriteLine(ris);
            }

            reader2.Close();

            Console.WriteLine();

            //SCALAR COMMAND
            SqlCommand scalarCommand = new SqlCommand();
            scalarCommand.Connection = connection;
            scalarCommand.CommandText = "SELECT * FROM [Offer] where id = 344 ";
            Console.WriteLine("risultato: " + scalarCommand.ExecuteScalar());

            Console.WriteLine();

            //NONQUERY COMMAND
            SqlCommand nonQueryCommand = new SqlCommand();
            nonQueryCommand.Connection = connection;
            nonQueryCommand.CommandText = "INSERT INTO [CountryOrigin] (Name) values('Germany')";
            int rowsAffected = nonQueryCommand.ExecuteNonQuery();
            Console.WriteLine("Rows Affected= " + rowsAffected);

            
            connection.Close();

            Console.WriteLine();
            Console.WriteLine("Premi invio...");
            Console.ReadKey();
        }
    }
}
