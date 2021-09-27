using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CDocente
    {
        Datos datos = new DatosSQL();
        public string _CodDocente
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
        private string mensaje;
        public string Mensaje
        { get { return mensaje; } }

        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarDocente");
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarDocente", _CodDocente, _APaterno, _AMaterno,_Nombres,_Usuario,_Contrasena);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarDocente", _CodDocente);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarDocente", _CodDocente, _APaterno, _AMaterno, _Nombres, _Usuario, _Contrasena);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;

        }
        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarDocente", texto, criterio);
        }
    }
}
