using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CCargaAcademica
    {
        Datos datos = new DatosSQL();

        //declarar propiedades de la clase
        public string _IdCargaAcademica
        { get; set; }
        public string _CodDocente
        { get; set; }
        public string _CodCurso
        { get; set; }
        public string _Semestre
        { get; set; }
        //propiedad para mensaje(de lectura)

        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        //listar las escuelas profesionales
        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarCargaAcademica");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarCargaAcademica", _IdCargaAcademica, _CodDocente, _CodCurso, _Semestre);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarCargaAcademica", _IdCargaAcademica, _CodDocente, _CodCurso);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarCargaAcademica", _IdCargaAcademica, _CodDocente, _CodCurso, _Semestre);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarCargaAcademica", texto, criterio);
        }
    }
}
