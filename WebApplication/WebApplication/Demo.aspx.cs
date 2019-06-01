using System;

namespace WebApplication
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Session["name"] = txtName.Text;
            Session["name"] = "dummy_text";
            Response.Write(Session["Name"]);

            // lblName.Visible = false;
            // txtName.Visible = false;
            // lstLocation.Visible = false;
            // chkC.Visible = false;
            // chkJava.Visible = false;
            // chkPython.Visible = false;
            // rdMale.Visible = false;
            // rdFemale.Visible = false;
            // btnSubmit.Visible = false;
        }
    }
}