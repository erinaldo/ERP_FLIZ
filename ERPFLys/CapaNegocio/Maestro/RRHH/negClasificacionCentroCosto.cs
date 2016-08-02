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
    public class negClasificacionCentroCosto
    {
        public static List<entClasificacionCentroCosto> ListaFormID()
        {
            List<entClasificacionCentroCosto> ListObj = new List<entClasificacionCentroCosto>();
            ListObj = datClasificacionCentroCosto.ListaFormID().ToList<entClasificacionCentroCosto>();
            return ListObj;
        }

        public static entClasificacionCentroCosto GetFormID(String Compania, String Clasificacion)
        {
            entClasificacionCentroCosto EObj = new entClasificacionCentroCosto();
            List<entClasificacionCentroCosto> ListObj = new List<entClasificacionCentroCosto>();
            ListObj = datClasificacionCentroCosto.GetFormID(Compania,Clasificacion).ToList<entClasificacionCentroCosto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entClasificacionCentroCosto> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entClasificacionCentroCosto> ListObj = new List<entClasificacionCentroCosto>();
            ListObj = datClasificacionCentroCosto.ListaCombo(Compania, Estado).ToList<entClasificacionCentroCosto>();
            if (Def != null){
                ListObj.Insert(0, new entClasificacionCentroCosto() { Clasificacion = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entClasificacionCentroCosto> ListaSearch(String Compania, String Clasificacion, String Descripcion, String Estado)
        {
            List<entClasificacionCentroCosto> ListObj = new List<entClasificacionCentroCosto>();
            ListObj = datClasificacionCentroCosto.ListaSearch(Compania, Clasificacion, Descripcion, Estado).ToList<entClasificacionCentroCosto>();
            return ListObj;
        }

        public static entErrores MantFormID(entClasificacionCentroCosto Data)
        {
            return datClasificacionCentroCosto.MantFormID(Data);
        }

    }
}
