using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebCurso : System.Web.UI.Page
    {
        private CCurso cursito = new CCurso();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCurso.DataSource = cursito.Listar();
                gvCurso.DataBind();
            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvCurso.DataSource = cursito.Listar();
            gvCurso.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _CodCurso = txtCodCurso.Text.Trim();
            string _Curso = txtCurso.Text.Trim();
            string _CodRequisito = txtCodRequisito.Text.Trim();
            cursito._CodCurso = _CodCurso;
            cursito._Curso = _Curso;
            cursito._CodRequisito = _CodRequisito;
            if (cursito.Agregar())
            {
                gvCurso.DataSource = cursito.Listar();
                gvCurso.DataBind();
                // limpiar las cajas de texto
                txtCodCurso.Text = string.Empty;
                txtCurso.Text = string.Empty;
                txtCodRequisito.Text = string.Empty;
                txtCodCurso.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + cursito.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _CodCurso = txtCodCurso.Text.Trim();
            string _Curso = txtCurso.Text.Trim();
            string _CodRequisito = txtCodRequisito.Text.Trim();
            cursito._CodCurso = _CodCurso;
            cursito._Curso = _Curso;
            cursito._CodRequisito = _CodRequisito;
            if (cursito.Actualizar())
            {
                gvCurso.DataSource = cursito.Listar();
                gvCurso.DataBind();
                // limpiar las cajas de texto
                txtCodCurso.Text = string.Empty;
                txtCurso.Text = string.Empty;
                txtCodRequisito.Text = string.Empty;
                txtCodCurso.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + cursito.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            cursito._CodCurso = txtCodCurso.Text.Trim();
            if (cursito.Elimnar())
            {
                gvCurso.DataSource = cursito.Listar();
                gvCurso.DataBind();
                txtCodCurso.Text = string.Empty;
                txtCodCurso.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + cursito.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvCurso.DataSource = cursito.Buscar(texto, "CodCurso");
                gvCurso.DataBind();
                txtBuscar.Text = string.Empty;
            }
            else if (criterio == 1)
            {
                gvCurso.DataSource = cursito.Buscar(texto, "Curso");
                gvCurso.DataBind();
                txtBuscar.Text = string.Empty;
            }
        }
    }
}