using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WATestFirst_empty_
{
    public partial class DBSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) //pagina non caricata
            {
                using(SqlConnection cn = new SqlConnection()) //connessione al DB
                {
                    //Stringa di connessione -->
                    cn.ConnectionString = @"Server = DESKTOP-QM5RD66\SQLEXPRESS;
                                        Database = AdventureWorks2019;
                                        User Id=sa; Password=Its2020!";

                    cn.Open(); // apertura connessione

                    //commando da impartire
                    SqlCommand cmd = new SqlCommand("select Name from Production.Product order by Name", cn);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string pname = rdr["Name"].ToString(); //lettura su db
                            if (!String.IsNullOrEmpty(pname))
                                ddlProdotti.Items.Add(pname);
                        }
                    }




                }

            }
        }


        //click su pulsante
        protected void bExecute_Click(object sender, EventArgs e)
        {
            if (ddlProdotti.SelectedItem != null)
            {
                string pname = ddlProdotti.SelectedItem.Text;
                Label1.Text = pname;
            }
        }
        

    }
}