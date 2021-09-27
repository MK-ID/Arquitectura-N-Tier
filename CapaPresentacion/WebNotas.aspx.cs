using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class WebNotas : System.Web.UI.Page
    {
        private CNotas notas = new CNotas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvNotas.DataSource = notas.Listar();
                gvNotas.DataBind();
            }
        }

        protected void btnIrMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            gvNotas.DataSource = notas.Listar();
            gvNotas.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string _CodAlumno = txtCodAlumno.Text.Trim();
            string _CodCurso = txtcodCurso.Text.Trim();
            string _Semestre = txtsemestre.Text.Trim();
            string _Parcial1 = txtParcial1.Text.Trim();
            string _Parcial2 = txtParcial2.Text.Trim();
            string _NotaFinal = txtNotaFinal.Text.Trim();
            notas._CodAlumno = _CodAlumno;
            notas._CodCurso = _CodCurso;
            notas._Semestre = _Semestre;
            notas._Parcial1 = _Parcial1;
            notas._Parcial2 = _Parcial2;
            notas._NotaFinal = _NotaFinal;
            if (notas.Agregar())
            {
                gvNotas.DataSource = notas.Listar();
                gvNotas.DataBind();
                // limpiar las cajas de texto
                txtCodAlumno.Text = string.Empty;
                txtcodCurso.Text = string.Empty;
                txtsemestre.Text = string.Empty;
                txtParcial1.Text = string.Empty;
                txtParcial2.Text = string.Empty;
                txtNotaFinal.Text = string.Empty;
                txtCodAlumno.Focus();
                txtcodCurso.Focus();
            }
            //traer el mensaje del PA (JavaScript)
            Response.Write("<script>alert('" + notas.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string _CodAlumno = txtCodAlumno.Text.Trim();
            string _CodCurso = txtcodCurso.Text.Trim();
            string _Semestre = txtsemestre.Text.Trim();
            string _Parcial1 = txtParcial1.Text.Trim();
            string _Parcial2 = txtParcial2.Text.Trim();
            string _NotaFinal = txtNotaFinal.Text.Trim();
            notas._CodAlumno = _CodAlumno;
            notas._CodCurso = _CodCurso;
            notas._Semestre = _Semestre;
            notas._Parcial1 = _Parcial1;
            notas._Parcial2 = _Parcial2;
            notas._NotaFinal = _NotaFinal;
            if (notas.Actualizar())
            {
                gvNotas.DataSource = notas.Listar();
                gvNotas.DataBind();
                // limpiar las cajas de texto
                txtCodAlumno.Text = string.Empty;
                txtcodCurso.Text = string.Empty;
                txtsemestre.Text = string.Empty;
                txtParcial1.Text = string.Empty;
                txtParcial2.Text = string.Empty;
                txtNotaFinal.Text = string.Empty;
                txtCodAlumno.Focus();
                txtcodCurso.Focus();
            }
            // traer el mensaje ael PA
            Response.Write("<script>alert('" + notas.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            notas._CodAlumno = txtCodAlumno.Text.Trim();
            notas._CodCurso = txtcodCurso.Text.Trim();
            notas._Semestre = txtsemestre.Text.Trim();
            notas._Parcial1 = txtParcial1.Text.Trim();
            notas._Parcial2 = txtParcial2.Text.Trim();
            notas._NotaFinal = txtNotaFinal.Text.Trim();
            if (notas.Elimnar())
            {
                gvNotas.DataSource = notas.Listar();
                gvNotas.DataBind();
                txtCodAlumno.Text = string.Empty;
                txtcodCurso.Text = string.Empty;
                txtsemestre.Text = string.Empty;
                txtParcial1.Text = string.Empty;
                txtParcial2.Text = string.Empty;
                txtNotaFinal.Text = string.Empty;
                txtCodAlumno.Focus();
                txtcodCurso.Focus();
                txtsemestre.Focus();

            }
            //traer el mensaje ael PA
            Response.Write("<script>alert('" + notas.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvNotas.DataSource = notas.Buscar(texto, "CodAlumno");
                gvNotas.DataBind();
            }
            else if (criterio == 1)
            {
                gvNotas.DataSource = notas.Buscar(texto, "CodCurso");
                gvNotas.DataBind();
            }
            else if (criterio == 1)
            {
                gvNotas.DataSource = notas.Buscar(texto, "Semestre");
                gvNotas.DataBind();
            }
        }
    }
}