using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione5_dataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=AdventureWorks2017;User Id=sa;Password=Its2020!;";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "SELECT [name],[rowguid] FROM [Sales].[Store]";

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;
            insertCommand.CommandText = "INSERT INTO [Sales].[Store] (BusinessID,Name,rowguid) VALUES(@businessID@name,@rowguid) ";
            insertCommand.Parameters.Add(new SqlParameter("@businessID", SqlDbType.Int, 5, "name"));
            insertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "name"));
            insertCommand.Parameters.Add(new SqlParameter("@rowguid", SqlDbType.UniqueIdentifier,1,"rowguid"));

            adapter.SelectCommand = selectCommand;
            adapter.InsertCommand = insertCommand;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Stores");

            DataRow row = ds.Tables["Stores"].NewRow();
            row["businessID"] = 2052;
            row["name"] = "pippo";
            row["rowguid"] = "A22517E3-848D-4EBE-B9D9-7437F3432378";
            ds.Tables["Stores"].Rows.Add(row);

            adapter.Update(ds, "Stores");

            Console.WriteLine("fine...");
            Console.ReadKey();

        }
    }
}
