using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIrCargaAcademica_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCargaAcademica.aspx");
        }

        protected void btnIrAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebAlumno.aspx");
        }

        protected void btnIrCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebCurso.aspx");
        }

        protected void btnIrDocente_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebDocente.aspx");
        }

        protected void btnIrEscuela_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnIrNotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebNotas.aspx");
        }

        protected void btnIrUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebUsuario.aspx");
        }

        protected void btnIrCargaAcademica_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebCargaAcademica.aspx");
        }
    }
}