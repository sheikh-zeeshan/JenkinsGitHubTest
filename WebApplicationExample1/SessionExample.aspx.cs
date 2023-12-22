﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExample1
{
    public partial class SessionExample : System.Web.UI.Page
    {
        protected void login_Click(object sender, EventArgs e)
        {
            if (password.Text == "qwe123")
            {
                // Storing email to Session variable  
                Session["email"] = email.Text;
            }
            // Checking Session variable is not empty  
            if (Session["email"] != null)
            {
                // Displaying stored email  
                Label3.Text = "This email is stored to the session.";
                Label4.Text = Session["email"].ToString();
            }
        }
    }
}