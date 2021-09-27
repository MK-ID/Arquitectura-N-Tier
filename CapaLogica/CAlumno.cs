using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class CAlumno
    {
        Datos datos = new DatosSQL();

        //declarar propiedades de la clase
        public string _CodAlumno
        { get; set; }

        public string _APaterno
        { get; set; }
        public string _AMaterno
        { get; set; }
        public string _Nombres
        { get; set; }
        public string _Usuario
        { get; set; }
        public string _Contrasena
        { get; set; }
        public string _CodEscuela
        { get; set; }

        //propiedad para mensaje(de lectura)

        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        //listar las escuelas profesionales
        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarAlumno");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarAlumno", _CodAlumno, _APaterno,_AMaterno,_Nombres,_Usuario,_Contrasena,_CodEscuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarAlumno", _CodAlumno);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarAlumno", _CodAlumno, _APaterno, _AMaterno,_Nombres, _CodEscuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarAlumno", texto, criterio);
        }

    }
}
