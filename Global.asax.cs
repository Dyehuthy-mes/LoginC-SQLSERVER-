using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.IO;
using System.Web.Configuration;

namespace ProyectoPrueba
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Creacion DB y Tabla con los datos del usuario.
            string connectionString = WebConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            string scriptPath = Server.MapPath("~/Scripts/CrearDB.sql");
            string insertScriptPath = Server.MapPath("~/Scripts/Insert.sql");

            string scriptContent = File.ReadAllText(scriptPath);
            string insertScriptContent = File.ReadAllText(insertScriptPath);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(scriptContent, con);
                command.ExecuteNonQuery();
                SqlCommand insertCommand = new SqlCommand(insertScriptContent, con);
                insertCommand.ExecuteNonQuery();
                con.Close();
            }

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

