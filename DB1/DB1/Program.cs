using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                //stringa connessione
                connection.ConnectionString = @"Server=DESKTOP-45672OV\SQLEXPRESS;
                                            Database=AdventureWorks2017;
                                            Trusted_Connection=True;
                                            MultipleActiveResultSets = true;";
                connection.Open();

                //SCALAR COMMAND
                // command.ExecuteScalar(); //un solo valore (select max count ecc..)
                SqlCommand scalarCommand = new SqlCommand();
                scalarCommand.Connection = connection; //oggetto connessione
                scalarCommand.CommandText = "SELECT MAX (AccountNumber)  FROM [Sales].[Customer]"; //comando da eseguire
                string max = (string)scalarCommand.ExecuteScalar();
                Console.WriteLine("Account max= " + max);

                //NOQUERY COMMAND
                // command.ExecuteNonQuery(); //insert uptade delete
                SqlCommand nonQueryCommand = new SqlCommand();
                nonQueryCommand.Connection = connection; //oggetto connessione
                                                         //nonQueryCommand.CommandText = "INSERT INTO[Sales].[Currency] (CurrencyCode, Name) values('WLO','Welol Currency' )";
                nonQueryCommand.CommandText = "DELETE FROM[Sales].[Currency] WHERE CurrencyCode='WLO'";
                int rows = nonQueryCommand.ExecuteNonQuery();
                Console.WriteLine("Rows= " + rows);

                //READER COMMAND
                SqlCommand readerCommand = new SqlCommand();
                readerCommand.Connection = connection; //oggetto connessione 
                readerCommand.CommandText = "SELECT TOP(10) * FROM[Sales].[Customer]"; //comando da eseguire

                //altre query
                //reader è un flusso di dati va letto con while (cursore su indice -1)
                using (SqlDataReader reader = readerCommand.ExecuteReader()) //con using non serve più la close
                {
                    while (reader.Read())
                    {
                        //salvataggio nell'array dei dati letti e cast dell'oggetto in stringa
                        string ris = reader["AccountNumber"].ToString() + " - " + reader["rowguid"].ToString();
                        Console.WriteLine(ris);
                    }
                }

                //secondo reader
                SqlCommand readerCommand2 = new SqlCommand();
                readerCommand2.Connection = connection; //oggetto connessione 
                readerCommand2.CommandText = "SELECT TOP(5) * FROM[Sales].[CreditCard]; "; //comando da eseguire

                using (SqlDataReader reader2 = readerCommand2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        //salvataggio nell'array dei dati letti e cast dell'oggetto in stringa
                        string ris = reader2["CardType"].ToString() + " - " + reader2["CardNumber"].ToString();
                        Console.WriteLine(ris);
                    }
                }

                connection.Close();

            }
            catch (Exception ex)
            {

                throw;
            }
           
                
            





            Console.WriteLine("Premere un tasto per continuare...");
            Console.ReadKey();

        }
    }
}
