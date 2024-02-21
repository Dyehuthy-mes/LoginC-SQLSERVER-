using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ProyectoPrueba
{
    public partial class _Default : Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconn"].ConnectionString + "Initial Catalog=Usuarios";
            con = new SqlConnection(constr);
        }

        protected void botonIniciar_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select UsuarioId, Contraseña from Usuarios where NombreUsuario = @NombreUsuario", con);
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar);
                cmd.Parameters["@NombreUsuario"].Value = txtusuario.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();

                if (dt != null && dt.Rows.Count > 0)
                {
                    if (verificarUsuario(dt))
                    {
                        obtenerUsuario(dt);
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al iniciar sesión: usuario y/o contraseña incorrectos')</script>");
                    }
                }
                else {
                    Response.Write("<script>alert('Error al iniciar sesión: no se encuentra el usuario')</script>");
                }
            } catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        private bool verificarUsuario(DataTable dt) {
            string contraseña = dt.Rows[0][1].ToString();
            return BCrypt.Net.BCrypt.Verify(txtcontraseña.Text, contraseña);
        }

        private void obtenerUsuario(DataTable dt)
        {
            string usuarioId = dt.Rows[0][0].ToString();
            SqlCommand usuarioCmd = new SqlCommand("select NombreUsuario, Mail, Telefono, Direccion from Usuarios where UsuarioId =" + usuarioId, con);
            SqlDataAdapter usuarioSda = new SqlDataAdapter(usuarioCmd);
            DataTable usuarioDt = new DataTable();
            usuarioSda.Fill(usuarioDt);
            usuarioCmd.ExecuteNonQuery();

            if (usuarioDt != null && usuarioDt.Rows.Count > 0)
            {
                string NombreUsuario = usuarioDt.Rows[0][0].ToString();
                string Mail = usuarioDt.Rows[0][1].ToString();
                string Telefono = usuarioDt.Rows[0][2].ToString();
                string Direccion = usuarioDt.Rows[0][3].ToString();
                
                Session["NombreUsuario"] = NombreUsuario;
                Session["Mail"] = Mail;
                Session["Telefono"] = Telefono;
                Session["Direccion"] = Direccion;
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Error al iniciar sesión: usuario eliminado')</script>");
            }
        }
    }
}