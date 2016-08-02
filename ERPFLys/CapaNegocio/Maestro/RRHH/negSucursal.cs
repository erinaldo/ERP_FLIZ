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
    public class negSucursal
    {
        public static List<entSucursal> ListaFormID()
        {
            List<entSucursal> ListObj = new List<entSucursal>();
            ListObj = datSucursal.ListaFormID().ToList<entSucursal>();
            return ListObj;
        }

        public static entSucursal GetFormID(String Compania, String Sucursal)
        {
            entSucursal EObj = new entSucursal();
            List<entSucursal> ListObj = new List<entSucursal>();
            ListObj = datSucursal.GetFormID(Compania, Sucursal).ToList<entSucursal>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entSucursal> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entSucursal> ListObj = new List<entSucursal>();
            ListObj = datSucursal.ListaCombo(Compania, Estado).ToList<entSucursal>();
            if (Def != null){
                ListObj.Insert(0, new entSucursal() { Sucursal = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entSucursal> ListaSearch(String Compania, String Sucursal, String Descripcion, String Estado)
        {
            List<entSucursal> ListObj = new List<entSucursal>();
            ListObj = datSucursal.ListaSearch(Compania, Sucursal, Descripcion, Estado).ToList<entSucursal>();
            return ListObj;
        }

        public static entErrores MantFormID(entSucursal Data)
        {
            return datSucursal.MantFormID(Data);
        }

    }
}
