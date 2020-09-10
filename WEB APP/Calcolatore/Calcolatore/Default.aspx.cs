using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calcolatore
{
    public partial class _Default : Page
    {
       

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            string i = TextBox1.Text;
            int numI = Convert.ToInt32(i);
            string j = TextBox2.Text;
            int numJ = Convert.ToInt32(j);

            int ris = numI + numJ;

            TextBox3.Text = ris.ToString();
        }
    }
}