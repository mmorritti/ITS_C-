using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=AdventureWorks2017;User Id=sa;Password=welol2020!;MultipleActiveResultSets=true;"; //Stringa di connessione al DB SQL Server
                    connection.Open();

                    SqlCommand scalarCommand = new SqlCommand();
                    scalarCommand.Connection = connection; // Oggetto connessione
                    scalarCommand.CommandText = "SELECT MAX(AccountNumber) FROM [Sales].[Customer]"; //Comando da eseguire
                    Console.WriteLine("Max Account Number: " + (string)scalarCommand.ExecuteScalar());

                    SqlCommand nonQueryCommand = new SqlCommand();
                    nonQueryCommand.Connection = connection; // Oggetto connessione
                    nonQueryCommand.CommandText = "INSERT INTO[Sales].[Currency] (CurrencyCode, Name) VALUES('WLO', 'Welol Currency')"; //Comando da eseguire
                    //nonQueryCommand.CommandText = "DELETE FROM [Sales].[Currency] WHERE CurrencyCode = 'WLO'"; //Comando da eseguire
                    int rowsAffected = nonQueryCommand.ExecuteNonQuery();
                    Console.WriteLine("Rows affected: " + rowsAffected);

                    using (SqlCommand readerCommand = new SqlCommand())
                    {
                        readerCommand.Connection = connection; // Oggetto connessione
                        readerCommand.CommandText = "SELECT TOP(10) * FROM [Sales].[Customer]"; //Comando da eseguire
                        SqlDataReader reader = readerCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["AccountNumber"].ToString() + " - " + reader["rowguid"].ToString());
                        }
                    }

                    using (SqlCommand readerCommand2 = new SqlCommand())
                    {
                        readerCommand2.Connection = connection; // Oggetto connessione
                        readerCommand2.CommandText = "SELECT * FROM [Sales].[CreditCard]"; //Comando da eseguire
                        SqlDataReader reader2 = readerCommand2.ExecuteReader();
                        while (reader2.Read())
                        {
                            Console.WriteLine(reader2["CardType"].ToString() + " - " + reader2["CardNumber"].ToString());
                        }
                    }
                }
                catch (SqlException sqex)
                {
                    Console.WriteLine(sqex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Premere invio per continuare...");
            Console.ReadLine();
        }
    }
}
