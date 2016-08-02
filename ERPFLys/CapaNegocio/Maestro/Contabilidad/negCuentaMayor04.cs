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
    public class negCuentaMayor04
    {
        public static List<entCuentaMayor04> ListaFormID()
        {
            List<entCuentaMayor04> ListObj = new List<entCuentaMayor04>();
            ListObj = datCuentaMayor04.ListaFormID().ToList<entCuentaMayor04>();
            return ListObj;
        }

        public static entCuentaMayor04 GetFormID(String CuentaMayor04)
        {
            entCuentaMayor04 EObj = new entCuentaMayor04();
            List<entCuentaMayor04> ListObj = new List<entCuentaMayor04>();
            ListObj = datCuentaMayor04.GetFormID(CuentaMayor04).ToList<entCuentaMayor04>();
            if (ListObj.Count > 0)
            {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaMayor04> ListaCombo(String CuentaMayor, String Estado, String[] Def = null)
        {
            List<entCuentaMayor04> ListObj = new List<entCuentaMayor04>();
            ListObj = datCuentaMayor04.ListaCombo(CuentaMayor, Estado).ToList<entCuentaMayor04>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaMayor04() { CuentaMayor04 = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaMayor04> ListaSearch(String CuentaMayor04, String CuentaMayor, String Descripcion, String Estado)
        {
            List<entCuentaMayor04> ListObj = new List<entCuentaMayor04>();
            ListObj = datCuentaMayor04.ListaSearch(CuentaMayor, CuentaMayor, Descripcion, Estado).ToList<entCuentaMayor04>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaMayor04 Data)
        {
            return datCuentaMayor04.MantFormID(Data);
        }
    }
}
