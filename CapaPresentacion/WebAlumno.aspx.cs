using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebAlumno : System.Web.UI.Page
    {
        private CAlumno alumno = new CAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvAlumno.DataSource = alumno.Listar();
                gvAlumno.DataBind();

            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvAlumno.DataSource = alumno.Buscar(texto, "CodAlumno");
                gvAlumno.DataBind();
                txtBuscar.Text = string.Empty;

            }
            else if (criterio == 1)
            {
                gvAlumno.DataSource = alumno.Buscar(texto, "APaterno");
                gvAlumno.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 1)
            {
                gvAlumno.DataSource = alumno.Buscar(texto, "Usuario");
                gvAlumno.DataBind();
                txtBuscar.Text = string.Empty;
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvAlumno.DataSource = alumno.Listar();
            gvAlumno.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _CodAlumno = txtCodAlumno.Text.Trim();
            string _APaterno = txtAPaterno.Text.Trim();
            string _AMaterno = txtAMaterno.Text.Trim();
            string _Nombres = txtNombres.Text.Trim();
            string _Usuarios = txtUsuario.Text.Trim();
            string _Contrasenas = txtContrasena.Text.Trim();
            string _CodEscuela = txtCodEscuela.Text.Trim();
            alumno._CodAlumno = _CodAlumno;
            alumno._APaterno = _APaterno;
            alumno._AMaterno = _AMaterno;
            alumno._Nombres = _Nombres;
            alumno._Usuario = _Usuarios;
            alumno._Contrasena = _Contrasenas;
            alumno._CodEscuela = _CodEscuela;
            if (alumno.Agregar())
            {
                gvAlumno.DataSource = alumno.Listar();
                gvAlumno.DataBind();
                // limpiar las cajas de texto
                txtCodAlumno.Text = string.Empty;
                txtAPaterno.Text = string.Empty;
                txtAMaterno.Text = string.Empty;
                txtNombres.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                txtCodEscuela.Text = string.Empty;
                txtCodAlumno.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + alumno.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _CodAlumno = txtCodAlumno.Text.Trim();
            string _APaterno = txtAPaterno.Text.Trim();
            string _AMaterno = txtAMaterno.Text.Trim();
            string _Nombres = txtNombres.Text.Trim();
            string _CodEscuela = txtCodEscuela.Text.Trim();
            alumno._CodAlumno = _CodAlumno;
            alumno._APaterno = _APaterno;
            alumno._AMaterno = _AMaterno;
            alumno._Nombres = _Nombres;
            alumno._CodEscuela = _CodEscuela;
            if (alumno.Actualizar())
            {
                gvAlumno.DataSource = alumno.Listar();
                gvAlumno.DataBind();
                // limpiar las cajas de texto
                txtCodAlumno.Text = string.Empty;
                txtAPaterno.Text = string.Empty;
                txtAMaterno.Text = string.Empty;
                txtNombres.Text = string.Empty;
                txtCodEscuela.Text = string.Empty;

                txtCodAlumno.Focus();
                txtCodEscuela.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + alumno.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            alumno._CodAlumno = txtCodAlumno.Text.Trim();
            if (alumno.Elimnar())
            {
                gvAlumno.DataSource = alumno.Listar();
                gvAlumno.DataBind();
                txtCodAlumno.Text = string.Empty;
                txtCodAlumno.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + alumno.Mensaje + "');</script>");
        }
    }
}