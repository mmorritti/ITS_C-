using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WATest
{
    public partial class Prodotti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Server=localhost\sqlexpress;Database=AdventureWorks2017;User Id=sa;Password=welol2020!";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select Name from Production.Product order by Name", cn);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string pname = rdr["Name"].ToString();
                            if (!String.IsNullOrEmpty(pname))
                                ddlProdotti.Items.Add(pname);
                        }
                    }
                }
            }
        }

        protected void bExecute_Click(object sender, EventArgs e)
        {
            if(ddlProdotti.SelectedItem != null)
            {
                string pname = ddlProdotti.SelectedItem.Text;
                lProductName.Text = pname;
            }
        }
    }
}