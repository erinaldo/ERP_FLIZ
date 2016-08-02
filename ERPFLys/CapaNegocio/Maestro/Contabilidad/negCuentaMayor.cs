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
    public class negCuentaMayor
    {
        public static List<entCuentaMayor> ListaFormID()
        {
            List<entCuentaMayor> ListObj = new List<entCuentaMayor>();
            ListObj = datCuentaMayor.ListaFormID().ToList<entCuentaMayor>();
            return ListObj;
        }

        public static entCuentaMayor GetFormID(String CuentaMayor)
        {
            entCuentaMayor EObj = new entCuentaMayor();
            List<entCuentaMayor> ListObj = new List<entCuentaMayor>();
            ListObj = datCuentaMayor.GetFormID(CuentaMayor).ToList<entCuentaMayor>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaMayor> ListaCombo(String Clasificacion,String Estado, String[] Def = null)
        {
            List<entCuentaMayor> ListObj = new List<entCuentaMayor>();
            ListObj = datCuentaMayor.ListaCombo(Clasificacion,Estado).ToList<entCuentaMayor>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaMayor() { CuentaMayor = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaMayor> ListaSearch(String CuentaMayor,String Clasificacion, String Descripcion, String Estado)
        {
            List<entCuentaMayor> ListObj = new List<entCuentaMayor>();
            ListObj = datCuentaMayor.ListaSearch(CuentaMayor,Clasificacion, Descripcion, Estado).ToList<entCuentaMayor>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaMayor Data)
        {
            return datCuentaMayor.MantFormID(Data);
        }

    }
}
