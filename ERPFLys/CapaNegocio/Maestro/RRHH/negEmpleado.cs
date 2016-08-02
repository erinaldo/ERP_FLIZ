using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Repository.Maestro.RRHH;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.RRHH
{
    public class negEmpleado
    {
        public static List<entEmpleado> ListaFormID()
        {
            List<entEmpleado> ListObj = new List<entEmpleado>();
            ListObj = datEmpleado.ListaFormID().ToList<entEmpleado>();
            return ListObj;
        }

        public static entEmpleado GetFormID(String Compania, Int32 Empleado)
        {
            entEmpleado EObj = new entEmpleado();
            List<entEmpleado> ListObj = new List<entEmpleado>();
            ListObj = datEmpleado.GetFormID(Compania, Empleado).ToList<entEmpleado>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entEmpleado> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entEmpleado> ListObj = new List<entEmpleado>();
            ListObj = datEmpleado.ListaCombo(Compania, Estado).ToList<entEmpleado>();
            if (Def != null){
                ListObj.Insert(0, new entEmpleado() { Empleado = Int32.Parse(Def[0]), NombreCompleto = Def[1] });
            }
            return ListObj;
        }

        public static List<entEmpleado> ListaSearch(String Compania, Int32 Empleado, String Nombre, String Documento, String DocumentoFiscal, String Estado)
        {
            List<entEmpleado> ListObj = new List<entEmpleado>();
            ListObj = datEmpleado.ListaSearch(Compania, Empleado, Nombre, Documento, DocumentoFiscal,Estado).ToList<entEmpleado>();
            return ListObj;
        }

        public static entErrores MantFormID(entEmpleado Data)
        {
            return datEmpleado.MantFormID(Data);
        }

        public static Boolean GetExisteEmpleado(String Compania, Int32 Empleado) {
            entEmpleado oEnt = GetFormID(Compania, Empleado);
            Boolean Existe = oEnt.ResultadoBusqueda;
            oEnt = null;
            return Existe;
        }

    }
}
