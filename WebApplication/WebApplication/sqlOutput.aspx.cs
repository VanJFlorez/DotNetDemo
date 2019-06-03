using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication
{
    public partial class sqlOuput : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-PC\\SQLSERVER;Initial Catalog=DemoDatabase;Persist Security Info=True;User ID=DemoLogin;Password=DemoLogin");
            cnn.Open();

            SqlCommand cmd = new SqlCommand("select * from Library", cnn);
            SqlDataReader dataReader = cmd.ExecuteReader();
            String data = "";
            while (dataReader.Read())
                data += dataReader.GetValue(0) + ") " + dataReader.GetValue(1) + " ~ " + dataReader.GetValue(2) + "</br>";
            Response.Write(data);

            dataReader.Close();
            cmd.Dispose();
            cnn.Close();
        }
    }
}