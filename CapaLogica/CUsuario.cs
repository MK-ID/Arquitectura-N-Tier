using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaLogica
{
    public class CUsuario
    {
        //declarar un objeto que acceda a la capa datos
        Datos datos = new DatosSQL();


        //declarar propiedades de la clase
        public string _Usuario
        { get; set; }

        public string _Contrasena
        { get; set; }
        //propiedad para mensaje(de lectura)

        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        //listar las escuelas profesionales
        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarUsuario");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarUsuario", _Usuario, _Contrasena);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Elimnar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarUsuario", _Usuario);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarUsuario", _Usuario, _Contrasena);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarUsuario", texto, criterio);
        }
    }
}
