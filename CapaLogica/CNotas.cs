using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CNotas
    {
        Datos datos = new DatosSQL();
        public string _CodAlumno
        { get; set; }
        public string _CodCurso
        { get; set; }
        public string _Semestre
        { get; set; }
        public string _Parcial1
        { get; set; }
        public string _Parcial2
        { get; set; }
        public string _NotaFinal
        { get; set; }
        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarNotas");
        }
        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarNotas", _CodAlumno, _CodCurso, _Semestre, _Parcial1, _Parcial2, _NotaFinal);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarNota", _CodAlumno, _CodCurso, _Semestre, _Parcial1, _Parcial2, _NotaFinal);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarNotas", _CodAlumno, _CodCurso, _Semestre, _Parcial1, _Parcial2, _NotaFinal);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarNotas", texto, criterio);
        }
    }
}
