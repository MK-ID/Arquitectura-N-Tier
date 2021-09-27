using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebCargaAcademica : System.Web.UI.Page
    {
        private CCargaAcademica carguita = new CCargaAcademica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCargaAcademica.DataSource = carguita.Listar();
                gvCargaAcademica.DataBind();
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
                gvCargaAcademica.DataSource = carguita.Buscar(texto, "CodDocente");
                gvCargaAcademica.DataBind();
            }
            
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvCargaAcademica.DataSource = carguita.Listar();
            gvCargaAcademica.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _IdCargaAcademica = txtIdCargaAcademica.Text.Trim();
            string _Coddocente = txtCodDocente.Text.Trim();
            string _CodCurso = txtCodCurso.Text.Trim();
            string _Semestre = txtSemestre.Text.Trim();
            carguita._IdCargaAcademica = _IdCargaAcademica;
            carguita._CodDocente = _Coddocente;
            carguita._CodCurso = _CodCurso;
            carguita._Semestre = _Semestre;

            if (carguita.Agregar())
            {
                gvCargaAcademica.DataSource = carguita.Listar();
                gvCargaAcademica.DataBind();
                // limpiar las cajas de texto
                txtIdCargaAcademica.Text = string.Empty;
                txtCodDocente.Text = string.Empty;
                txtCodCurso.Text = string.Empty;
                txtSemestre.Text = string.Empty;
                txtIdCargaAcademica.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + carguita.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _IdCargaAcademica = txtIdCargaAcademica.Text.Trim();
            string _Coddocente = txtCodDocente.Text.Trim();
            string _CodCurso = txtCodCurso.Text.Trim();
            string _Semestre = txtSemestre.Text.Trim();
            carguita._IdCargaAcademica = _IdCargaAcademica;
            carguita._CodDocente = _Coddocente;
            carguita._CodCurso = _CodCurso;
            carguita._Semestre = _Semestre;
            if (carguita.Actualizar())
            {
                gvCargaAcademica.DataSource = carguita.Listar();
                gvCargaAcademica.DataBind();
                // limpiar las cajas de texto
                txtIdCargaAcademica.Text = string.Empty;
                txtCodDocente.Text = string.Empty;
                txtCodCurso.Text = string.Empty;
                txtSemestre.Text = string.Empty;
                txtIdCargaAcademica.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + carguita.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            carguita._IdCargaAcademica = txtIdCargaAcademica.Text.Trim();
            carguita._CodDocente = txtCodDocente.Text.Trim();
            carguita._CodCurso = txtCodCurso.Text.Trim();
            if (carguita.Elimnar())
            {
                gvCargaAcademica.DataSource = carguita.Listar();
                gvCargaAcademica.DataBind();
                txtIdCargaAcademica.Text = string.Empty;
                txtCodDocente.Text = string.Empty;
                txtCodCurso.Text = string.Empty;
                txtIdCargaAcademica.Focus();
            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + carguita.Mensaje + "');</script>");
        }
    }
}