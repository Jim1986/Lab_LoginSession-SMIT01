using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        
        if (string.IsNullOrEmpty(txtUserName.Text)||string.IsNullOrEmpty(txtPassword.Text)) {
            lblPrompt.Text = "Please Keyin Your Info";
            return;
        }
        else {
            Session["userName"] = txtUserName.Text;
            Response.Redirect(Session["url"].ToString());
            Session["log"] = "Log Out";
            
        }
    }
}