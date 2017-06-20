using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secret : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Session["userName"].ToString())) {
            Session["url"] = "Secret.aspx";
            Response.Redirect("Login.aspx");
            
        }
        
        Literal1.Text = "Hello" + " " + Session["userName"];

    }
}