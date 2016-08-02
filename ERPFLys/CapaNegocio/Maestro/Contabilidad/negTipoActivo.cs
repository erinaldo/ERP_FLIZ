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
    public class negTipoActivo
    {
        public static List<entTipoActivo> ListaFormID()
        {
            List<entTipoActivo> ListObj = new List<entTipoActivo>();
            ListObj = datTipoActivo.ListaFormID().ToList<entTipoActivo>();
            return ListObj;
        }

        public static entTipoActivo GetFormID(String TipoActivo)
        {
            entTipoActivo EObj = new entTipoActivo();
            List<entTipoActivo> ListObj = new List<entTipoActivo>();
            ListObj = datTipoActivo.GetFormID(TipoActivo).ToList<entTipoActivo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoActivo> ListaCombo(String Estado, String[] Def = null)
        {
            List<entTipoActivo> ListObj = new List<entTipoActivo>();
            ListObj = datTipoActivo.ListaCombo(Estado).ToList<entTipoActivo>();
            if (Def != null){
                ListObj.Insert(0, new entTipoActivo() { TipoActivo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoActivo> ListaSearch(String TipoActivo, String Descripcion, String Estado)
        {
            List<entTipoActivo> ListObj = new List<entTipoActivo>();
            ListObj = datTipoActivo.ListaSearch(TipoActivo, Descripcion, Estado).ToList<entTipoActivo>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoActivo Data)
        {
            return datTipoActivo.MantFormID(Data);
        }

    }
}
