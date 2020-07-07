using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_DB_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Server=DESKTOP-45672OV\SQLEXPRESS;Database=AdventureWorks2020;Trusted_Connection=True;";
                connection.Open();

                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = connection;
                selectCommand.CommandText = "SELECT * FROM [Production].[Culture] ";

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ris = reader["CultureId"].ToString() + reader["Name"].ToString();
                        Console.WriteLine(ris);
                    }
                }
            }
            catch(SqlException sqex)
            {
                Console.WriteLine("SQL" + "\n" + sqex);
            }
            catch (Exception ex)
            {

                Console.WriteLine();
            }
            finally
            {
                connection.Close();
            }

            Console.WriteLine("Fine..");
            Console.ReadKey();


        }
    }
}
