using System;
using System.Web.UI;

namespace ProyectoPrueba
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                NombreUsuario.Text = Session["NombreUsuario"].ToString();
                Mail.Text = Session["Mail"].ToString();
                Telefono.Text = Session["Telefono"].ToString();
                Direccion.Text = Session["Direccion"].ToString();
            }
            else {
                Response.Redirect("~/Login.aspx");
            }
        }
        protected void botonCerrar_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}