﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Somma
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TextBox1.Text);
            int j = Convert.ToInt32(TextBox2.Text);

            int ris = i + j;

            TextBox3.Text = ris.ToString();
           

        }
    }
}