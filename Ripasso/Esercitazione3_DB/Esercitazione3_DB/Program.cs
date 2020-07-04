using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione3_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;" +
                                                  "Database=AdventureWorks2017;" +
                                                  "User Id=sa; Password=Its2020!;";
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM [HumanResources].[Department] ";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ris = reader["Name"].ToString() + " - " + reader["GroupName"].ToString();
                        Console.WriteLine(ris);
                    }
                }

                Console.ReadKey();
            }
            catch (SqlException sqex)
            {
                Console.WriteLine("error");
            }
            catch (Exception ex)
            {

                Console.WriteLine("error");
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
