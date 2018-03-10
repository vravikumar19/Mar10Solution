using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevOps_Reg117209
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                Response.Write("<script>alert('User Id cannot be empty');</script>");
            }

            if (txtPwd.Text == "")
            {
                Response.Write("<script>alert('Pasword cannot be empty');</script>");
            }

            if ((txtUserId.Text == "DEVOPS") && (txtPwd.Text == "Wipro@123"))
            {
                // Response.Redirect("MainPage.aspx");
                Response.Write("<script>alert('SUCCESS');window.location.href='MainPage.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('Login/Password Incorrect');</script>");
                //Response.Redirect("MainPage.aspx");
            }
        }

        protected void cmdReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reset.aspx");
        }
    }
}