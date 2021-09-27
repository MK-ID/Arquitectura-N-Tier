using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaLogica;
namespace CapaPresentacion
{
    public partial class Usuario : System.Web.UI.Page
    {
        private CUsuario usuario = new CUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvUsuario.DataSource = usuario.Listar();
                gvUsuario.DataBind();

            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _Usuario = txtUsuario.Text.Trim();
            string _Contrasena = txtContrasena.Text.Trim();
            usuario._Usuario = _Usuario;
            usuario._Contrasena = _Contrasena;
            if (usuario.Agregar())
            {
                gvUsuario.DataSource = usuario.Listar();
                gvUsuario.DataBind();
                // limpiar las cajas de texto
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                txtUsuario.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario._Usuario = txtUsuario.Text.Trim();
            if (usuario.Elimnar())
            {
                gvUsuario.DataSource = usuario.Listar();
                gvUsuario.DataBind();
                txtUsuario.Text = string.Empty;
                txtContrasena.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _Usuario = txtUsuario.Text.Trim();
            string _Contrasena = txtContrasena.Text.Trim();
            usuario._Usuario = _Usuario;
            usuario._Contrasena = _Contrasena;
            if (usuario.Actualizar())
            {
                gvUsuario.DataSource = usuario.Listar();
                gvUsuario.DataBind();
                // limpiar las cajas de texto
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                txtUsuario.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + usuario.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1.- traer texto buscar 

            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvUsuario.DataSource = usuario.Buscar(texto, "Usuario");
                gvUsuario.DataBind();
            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvUsuario.DataSource = usuario.Listar();
            gvUsuario.DataBind();

        }

    }
}