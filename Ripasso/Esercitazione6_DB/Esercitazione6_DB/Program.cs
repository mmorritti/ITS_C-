using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione6_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {

                    connection.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=AdventureWorks2017;User id=sa;Password=Its2020!;";
                    connection.Open();

                    SqlCommand readerCommand = new SqlCommand();
                    readerCommand.Connection = connection;
                    readerCommand.CommandText = "SELECT  * FROM [HumanResources].[Department]";

                    using (SqlDataReader reader = readerCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string ris = reader["Name"].ToString() + " - " + reader["GroupName"].ToString();
                            Console.WriteLine(ris);
                        }

                    }

                    SqlCommand scalarCommand = new SqlCommand();
                    scalarCommand.Connection = connection;
                    scalarCommand.CommandText = "SELECT  COUNT (*) FROM [HumanResources].[Department]  ";
                    string riss = scalarCommand.ExecuteScalar().ToString();
                    Console.WriteLine("TOTALE RIGHE: " + riss);

                    //SqlCommand nonQCommand = new SqlCommand();
                    //nonQCommand.Connection = connection;
                    //nonQCommand.CommandText = "INSERT INTO [HumanResources].[Department] (Name,GroupName) VALUES('Mattia','Mattia Morritti')";
                    //int rowsAffected = nonQCommand.ExecuteNonQuery();
                    //Console.WriteLine("\n" + rowsAffected);

                    SqlCommand sqlCommand2 = new SqlCommand();
                    sqlCommand2.Connection = connection;
                    sqlCommand2.CommandText = "DELETE FROM [HumanResources].[Department] WHERE Name = 'Mattia'";
                    int rows = sqlCommand2.ExecuteNonQuery();
                    Console.WriteLine(rows);
                }
            }
            catch(SqlException sqex)
            {
                Console.WriteLine(sqex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }













            Console.WriteLine("\n Premi un tasto per continuare...");
            Console.ReadKey();
        }
    }
}
