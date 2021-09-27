using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CCurso
    {
        Datos datos = new DatosSQL();

        //declarar propiedades de la clase
        public string _CodCurso
        { get; set; }
        public string _Curso
        { get; set; }
        public string _CodRequisito
        { get; set; }
        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        //listar las escuelas profesionales
        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarCurso");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarCurso", _CodCurso, _Curso, _CodRequisito);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarCurso", _CodCurso);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarCurso", _CodCurso, _Curso, _CodRequisito);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarCurso", texto, criterio);
        }
    }
}
