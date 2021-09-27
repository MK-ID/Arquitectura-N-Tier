using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebDocente : System.Web.UI.Page
    {
        private CDocente docente = new CDocente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvDocente.DataSource = docente.Listar();
                gvDocente.DataBind();
            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvDocente.DataSource = docente.Listar();
            gvDocente.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _CodDocente = txtCodDocente.Text.Trim();
            string _APaterno = txtaPaterno.Text.Trim();
            string _AMaterno = txtApeMaterno.Text.Trim();
            string _Nombres = txtNombres.Text.Trim();
            string _Usuario = txtUsuario.Text.Trim();
            string _Contrasena = txtContrasena.Text.Trim();
            docente._CodDocente = _CodDocente;
            docente._APaterno = _APaterno;
            docente._AMaterno = _AMaterno;
            docente._Nombres = _Nombres;
            docente._Usuario = _Usuario;
            docente._Contrasena = _Contrasena;
            if (docente.Agregar())
            {
                gvDocente.DataSource = docente.Listar();
                gvDocente.DataBind();
                // limpiar las cajas de texto
                txtCodDocente.Text = string.Empty;
                txtaPaterno.Text = string.Empty;
                txtApeMaterno.Text = string.Empty;
                txtNombres.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                txtCodDocente.Focus();
                txtUsuario.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _CodDocente = txtCodDocente.Text.Trim();
            string _APaterno = txtaPaterno.Text.Trim();
            string _AMaterno = txtApeMaterno.Text.Trim();
            string _Nombres = txtNombres.Text.Trim();
            string _Usuario = txtUsuario.Text.Trim();
            string _Contrasena = txtContrasena.Text.Trim();
            docente._CodDocente = _CodDocente;
            docente._APaterno = _APaterno;
            docente._AMaterno = _AMaterno;
            docente._Nombres = _Nombres;
            docente._Usuario = _Usuario;
            docente._Contrasena = _Contrasena;

            if (docente.Actualizar())
            {
                gvDocente.DataSource = docente.Actualizar();
                gvDocente.DataBind();
                //Limpiar las cajas de texto
                txtCodDocente.Text = string.Empty;
                txtaPaterno.Text = string.Empty;
                txtApeMaterno.Text = string.Empty;
                txtNombres.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                txtCodDocente.Focus();
                txtUsuario.Focus();

            }
            //Traer el mensaje del PA(JavaSceipt)
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            docente._CodDocente = txtCodDocente.Text.Trim();
           
            if (docente.Eliminar())
            {
                gvDocente.DataSource = docente.Listar();
                gvDocente.DataBind();
                txtCodDocente.Text = string.Empty;
                txtCodDocente.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + docente.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string text = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;

            if (criterio == 0)
            {
                gvDocente.DataSource = docente.Buscar(text, "CodDocente");
                gvDocente.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 1)
            {
                gvDocente.DataSource = docente.Buscar(text, "APaterno");
                gvDocente.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 2)
            {
                gvDocente.DataSource = docente.Buscar(text, "AMaterno");
                gvDocente.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 3)
            {
                gvDocente.DataSource = docente.Buscar(text, "Nombres");
                gvDocente.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 4)
            {
                gvDocente.DataSource = docente.Buscar(text, "Usuario");
                gvDocente.DataBind();
                txtBuscar.Text = string.Empty;
            }
        }
    }
}