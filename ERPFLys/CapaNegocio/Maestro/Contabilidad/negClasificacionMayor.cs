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
    public class negClasificacionMayor
    {
        public static List<entClasificacionMayor> ListaFormID()
        {
            List<entClasificacionMayor> ListObj = new List<entClasificacionMayor>();
            ListObj = datClasificacionMayor.ListaFormID().ToList<entClasificacionMayor>();
            return ListObj;
        }

        public static entClasificacionMayor GetFormID(String Clasificacion)
        {
            entClasificacionMayor EObj = new entClasificacionMayor();
            List<entClasificacionMayor> ListObj = new List<entClasificacionMayor>();
            ListObj = datClasificacionMayor.GetFormID(Clasificacion).ToList<entClasificacionMayor>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entClasificacionMayor> ListaCombo(String Estado, String[] Def = null)
        {
            List<entClasificacionMayor> ListObj = new List<entClasificacionMayor>();
            ListObj = datClasificacionMayor.ListaCombo(Estado).ToList<entClasificacionMayor>();
            if (Def != null){
                ListObj.Insert(0, new entClasificacionMayor() { Clasificacion = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entClasificacionMayor> ListaSearch(String Clasificacion, String Descripcion, String Estado)
        {
            List<entClasificacionMayor> ListObj = new List<entClasificacionMayor>();
            ListObj = datClasificacionMayor.ListaSearch(Clasificacion, Descripcion, Estado).ToList<entClasificacionMayor>();
            return ListObj;
        }

        public static entErrores MantFormID(entClasificacionMayor Data)
        {
            return datClasificacionMayor.MantFormID(Data);
        }

    }
}
