using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negCuentaMayor05
    {
        public static List<entCuentaMayor05> ListaFormID()
        {
            List<entCuentaMayor05> ListObj = new List<entCuentaMayor05>();
            ListObj = datCuentaMayor05.ListaFormID().ToList<entCuentaMayor05>();
            return ListObj;
        }

        public static entCuentaMayor05 GetFormID(String CuentaMayor05)
        {
            entCuentaMayor05 EObj = new entCuentaMayor05();
            List<entCuentaMayor05> ListObj = new List<entCuentaMayor05>();
            ListObj = datCuentaMayor05.GetFormID(CuentaMayor05).ToList<entCuentaMayor05>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaMayor05> ListaCombo(String CuentaMayor04, String Estado, String[] Def = null)
        {
            List<entCuentaMayor05> ListObj = new List<entCuentaMayor05>();
            ListObj = datCuentaMayor05.ListaCombo(CuentaMayor04, Estado).ToList<entCuentaMayor05>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaMayor05() { CuentaMayor05 = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaMayor05> ListaSearch(String CuentaMayor05, String CuentaMayor04, String Descripcion, String Estado)
        {
            List<entCuentaMayor05> ListObj = new List<entCuentaMayor05>();
            ListObj = datCuentaMayor05.ListaSearch(CuentaMayor05, CuentaMayor04, Descripcion, Estado).ToList<entCuentaMayor05>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaMayor05 Data)
        {
            return datCuentaMayor05.MantFormID(Data);
        }

    }
}
