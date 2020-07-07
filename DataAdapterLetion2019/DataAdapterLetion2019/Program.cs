using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterLetion2019
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=AdventureWorks2017;Trusted_Connection=True;";

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connection;
            selectCommand.CommandText = "SELECT CurrencyCode, Name, ModifiedDate FROM [Sales].[Currency]";

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;
            insertCommand.CommandText = "INSERT INTO [Sales].[Currency] (CurrencyCode, Name) VALUES (@CurrencyCode, @Name)";
            insertCommand.Parameters.Add(new SqlParameter("@CurrencyCode", SqlDbType.NChar, 3, "CurrencyCode"));
            insertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name"));

            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = connection;
            updateCommand.CommandText = "UPDATE [Sales].[Currency] SET Name = @Name WHERE CurrencyCode = @CurrencyCode";
            updateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name"));

            SqlParameter originalParam = new SqlParameter("@CurrencyCode", SqlDbType.NChar, 3, "CurrencyCode");
            originalParam.SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters.Add(originalParam);

            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = connection;
            deleteCommand.CommandText = "DELETE FROM [Sales].[Currency] WHERE CurrencyCode = @CurrencyCode";
            deleteCommand.Parameters.Add(new SqlParameter("@CurrencyCode", SqlDbType.NChar, 3, "CurrencyCode"));


            adapter.SelectCommand = selectCommand;
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;


            DataSet ds = new DataSet();

            //SELECT
            adapter.Fill(ds, "Currencies");

            //INSERT
            DataRow row = ds.Tables["Currencies"].NewRow();
            row["CurrencyCode"] = "WLO";
            row["Name"] = "Welol Currency";
            ds.Tables["Currencies"].Rows.Add(row);

            //UPDATE
            DataRow[] foundRows = ds.Tables["Currencies"].Select("CurrencyCode = 'EUR'");
            if (foundRows.Length > 0)
                foundRows[0]["Name"] = "European Currency";

            //DELETE
            DataRow[] rowsToDelete = ds.Tables["Currencies"].Select("CurrencyCode = 'WLO'");
            foreach (DataRow rowToDelete in rowsToDelete)
                rowToDelete.Delete();


            //PERSIST CHANGES
            adapter.Update(ds, "Currencies");

            Console.WriteLine("Premere invio per continuare...");
            Console.ReadLine();
        }
    }
}
