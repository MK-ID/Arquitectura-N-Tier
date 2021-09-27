using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaLogica;

namespace CapaPresentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //declaracion de un objeto global para escuela
        private Escuela escuela = new Escuela();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                gvEscuela.DataSource = escuela.Listar();
                gvEscuela.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _codEscuela = txtCodEscuela.Text.Trim();
            string _escuela = txtEscuela.Text.Trim();
            escuela._CodEscuela = _codEscuela;
            escuela._Escuela = _escuela;
            if(escuela.Agregar())
            {
                gvEscuela.DataSource = escuela.Listar();
                gvEscuela.DataBind();
                // limpiar las cajas de texto
                txtCodEscuela.Text = string.Empty;
                txtEscuela.Text = string.Empty;
                txtCodEscuela.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + escuela.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            escuela._CodEscuela = txtCodEscuela.Text.Trim();
            if (escuela.Elimnar())
            {
                gvEscuela.DataSource = escuela.Listar();
                gvEscuela.DataBind();
                txtCodEscuela.Text = string.Empty;
                txtCodEscuela.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + escuela.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _codEscuela = txtCodEscuela.Text.Trim();
            string _escuela = txtEscuela.Text.Trim();
            escuela._CodEscuela = _codEscuela;
            escuela._Escuela = _escuela;
            if (escuela.Actualizar())      
            {
                gvEscuela.DataSource = escuela.Listar();
                gvEscuela.DataBind();
                // limpiar las cajas de texto
                txtCodEscuela.Text = string.Empty;
                txtEscuela.Text = string.Empty;
                txtCodEscuela.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + escuela.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1.- traer texto buscar 

            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvEscuela.DataSource = escuela.Buscar(texto,"CodEscuela");
                gvEscuela.DataBind();
            }
            else if (criterio == 1)
            {
                gvEscuela.DataSource = escuela.Buscar(texto, "Escuela");
                gvEscuela.DataBind();
            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvEscuela.DataSource = escuela.Listar();
            gvEscuela.DataBind();

        }
    }
}