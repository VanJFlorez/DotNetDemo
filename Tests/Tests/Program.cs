using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            String strConn1 = "Server=LAPTOP-PC\\LAPTOP;Database=DemoDatabase;User Id=DemoLogin; Password = DemoLogin";
            String strConn2 = "Data Source=(local); Initial Catalog=DemoDatabase; User ID=DemoLogin; Password=DemoLogin";
            String strConn3 = "Data Source=LAPTOP-PC\\SQLSERVER;Initial Catalog=DemoDatabase;Persist Security Info=True;User ID=DemoLogin;Password=DemoLogin";

            String connParams = strConn3;

            Console.Write(connParams);
            SqlConnection cnn = new SqlConnection(connParams);

            cnn.Open();
            Console.Write("Conexion establecida con éxito!");
            cnn.Close();
            Console.ReadKey();
        }
    }
}
