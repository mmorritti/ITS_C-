using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione4_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;" +
                    " Database=AdventureWorks2017;" +
                    " User Id=sa;" + 
                    " Password=Its2020!;";
                connection.Open();

                SqlCommand readerCommand = new SqlCommand();
                readerCommand.Connection = connection;
                readerCommand.CommandText = "SELECT TOP(10) * FROM [Person].[Address] ";

                using(SqlDataReader reader = readerCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ris = reader["AddressLine1"].ToString() + " - " + reader["City"].ToString();
                        Console.WriteLine(ris);
                    }
                }








            }
            catch(SqlException sqex)
            {
                Console.WriteLine(sqex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            Console.ReadLine();

        }
    }
}
