using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Escuela
    {

        //declarar un objeto que acceda a la capa datos
        Datos datos = new DatosSQL();


        //declarar propiedades de la clase
        public string _CodEscuela
        { get; set; }

        public string _Escuela
        { get; set; }

        //propiedad para mensaje(de lectura)

        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        //listar las escuelas profesionales
        public  DataTable Listar()
        {
            return datos.TraerDataTable("spListarEscuela");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", _CodEscuela, _Escuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", _CodEscuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", _CodEscuela, _Escuela);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarEscuela", texto, criterio);
        }
    }
}
