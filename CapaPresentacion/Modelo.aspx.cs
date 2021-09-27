using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Modelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOpcion1_Click(object sender, EventArgs e)
        {
            //aperturamos el view 1
            mvEjemplo.ActiveViewIndex = 0;
        }

        protected void btnOpcion2_Click(object sender, EventArgs e)
        {
            mvEjemplo.ActiveViewIndex = 1;
        }

        protected void btnOpcion3_Click(object sender, EventArgs e)
        {
            mvEjemplo.ActiveViewIndex = 2;
        }

        protected void btnOpcion4_Click(object sender, EventArgs e)
        {
            mvEjemplo.ActiveViewIndex = 3;
        }
    }
}