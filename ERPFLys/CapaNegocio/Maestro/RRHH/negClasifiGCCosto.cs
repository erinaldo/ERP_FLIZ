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
    public class negClasifiGCCosto
    {
        public static List<entClasifiGCCosto> ListaFormID()
        {
            List<entClasifiGCCosto> ListObj = new List<entClasifiGCCosto>();
            ListObj = datClasifiGCCosto.ListaFormID().ToList<entClasifiGCCosto>();
            return ListObj;
        }

        public static entClasifiGCCosto GetFormID(String Compania, String Clasificacion)
        {
            entClasifiGCCosto EObj = new entClasifiGCCosto();
            List<entClasifiGCCosto> ListObj = new List<entClasifiGCCosto>();
            ListObj = datClasifiGCCosto.GetFormID(Compania, Clasificacion).ToList<entClasifiGCCosto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entClasifiGCCosto> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entClasifiGCCosto> ListObj = new List<entClasifiGCCosto>();
            ListObj = datClasifiGCCosto.ListaCombo(Compania, Estado).ToList<entClasifiGCCosto>();
            if (Def != null){
                ListObj.Insert(0, new entClasifiGCCosto() { ClasificacionGCC = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entClasifiGCCosto> ListaSearch(String Compania, String Clasificacion, String Descripcion, String Estado)
        {
            List<entClasifiGCCosto> ListObj = new List<entClasifiGCCosto>();
            ListObj = datClasifiGCCosto.ListaSearch(Compania, Clasificacion, Descripcion, Estado).ToList<entClasifiGCCosto>();
            return ListObj;
        }

        public static entErrores MantFormID(entClasifiGCCosto Data)
        {
            return datClasifiGCCosto.MantFormID(Data);
        }

    }
}
