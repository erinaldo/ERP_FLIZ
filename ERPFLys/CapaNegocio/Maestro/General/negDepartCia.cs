using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.General
{
    public class negDepartCia
    {
        public static List<entDepartCia> ListaFormID()
        {
            List<entDepartCia> ListObj = new List<entDepartCia>();
            ListObj = datDepartCia.ListaFormID().ToList<entDepartCia>();
            return ListObj;
        }

        public static entDepartCia GetFormID(String Compania, String DepartamentoCia)
        {
            entDepartCia EObj = new entDepartCia();
            List<entDepartCia> ListObj = new List<entDepartCia>();
            ListObj = datDepartCia.GetFormID(Compania, DepartamentoCia).ToList<entDepartCia>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entDepartCia> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entDepartCia> ListObj = new List<entDepartCia>();
            ListObj = datDepartCia.ListaCombo(Compania, Estado).ToList<entDepartCia>();
            if (Def != null){
                ListObj.Insert(0, new entDepartCia() { DepartamentoCiaCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entDepartCia> ListaSearch(String Compania, String DepartamentoCia, String Descripcion, String Estado)
        {
            List<entDepartCia> ListObj = new List<entDepartCia>();
            ListObj = datDepartCia.ListaSearch(Compania, DepartamentoCia, Descripcion, Estado).ToList<entDepartCia>();
            return ListObj;
        }

        public static entErrores MantFormID(entDepartCia Data)
        {
            return datDepartCia.MantFormID(Data);
        }

    }
}
