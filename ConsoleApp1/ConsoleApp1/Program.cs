using System;
using System.Collections.Generic;
using System.Data;
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
            SqlConnection connection = new SqlConnection();//connessione
            connection.ConnectionString = @"Server=DESKTOP-45672OV\SQLEXPRESS;
                                            Database=AdventureWorks2017;
                                            Trusted_Connection=True;"; //stringa di connessione
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection; //oggetto connessione
            command.CommandText = "SELECT * FROM [Sales].[Customer]"; //commando da eseguire

            //command.ExecuteNonQuery();
            //command.ExecuteScalar();
         
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string c1 = reader["AccountNumber"].ToString() + "-" + reader["rowguid"];//cast
                Console.WriteLine(c1);
            }

            reader.Close();
            connection.Close();


        }
    }
}
