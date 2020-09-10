using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2_counter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
           
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                
                TextBox1.Text = i.ToString();
                Thread.Sleep(1000);
                
            }
        }
    }
}