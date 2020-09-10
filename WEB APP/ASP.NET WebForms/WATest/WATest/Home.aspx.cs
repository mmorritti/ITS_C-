using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WATest
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //pageTitle.Text = "Pagina di Test";
            pageTitle.Text = Properties.Settings.Default.AppName;
            label2.InnerText = "Label HTML";
            Label1.Text = "Label ASP.NET";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "pippo";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length >= 3)
            {
                string s = "pippo";
            }
        }
    }
}