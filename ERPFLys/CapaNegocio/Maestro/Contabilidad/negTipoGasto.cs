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
    public class negTipoGasto
    {
        public static List<entTipoGasto> ListaFormID()
        {
            List<entTipoGasto> ListObj = new List<entTipoGasto>();
            ListObj = datTipoGasto.ListaFormID().ToList<entTipoGasto>();
            return ListObj;
        }

        public static entTipoGasto GetFormID(String TipoGasto)
        {
            entTipoGasto EObj = new entTipoGasto();
            List<entTipoGasto> ListObj = new List<entTipoGasto>();
            ListObj = datTipoGasto.GetFormID(TipoGasto).ToList<entTipoGasto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoGasto> ListaCombo(String Estado,String[] Def = null)
        {
            List<entTipoGasto> ListObj = new List<entTipoGasto>();
            ListObj = datTipoGasto.ListaCombo(Estado).ToList<entTipoGasto>();
            if (Def != null){
                ListObj.Insert(0, new entTipoGasto() { TipoGasto = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoGasto> ListaSearch(String TipoGasto, String Descripcion, String Estado)
        {
            List<entTipoGasto> ListObj = new List<entTipoGasto>();
            ListObj = datTipoGasto.ListaSearch(TipoGasto, Descripcion, Estado).ToList<entTipoGasto>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoGasto Data)
        {
            return datTipoGasto.MantFormID(Data);
        }

    }
}
