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
    public class negCentroCosto
    {
        public static List<entCentroCosto> ListCentroCostoForm()
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListCentroCostoForm().ToList<entCentroCosto>();
            return ListObj;
        }
        
        public static entCentroCosto GetCentroCostoFormID(String Compania,String CentroCosto)
        {
            entCentroCosto EObj = new entCentroCosto();
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.GetCentroCostoFormID(Compania,CentroCosto).ToList<entCentroCosto>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCentroCosto> ListaCentroCostoCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListaCentroCostoCombo(Compania, Estado).ToList<entCentroCosto>();
            if (Def != null){
                ListObj.Insert(0, new entCentroCosto() { CentroCosto = Def[0], Nombres = Def[1] });
            }
            return ListObj;
        }

        public static List<entCentroCosto> ListCentroCostoSearch(entCentroCosto oEnt)
        {
            List<entCentroCosto> ListObj = new List<entCentroCosto>();
            ListObj = datCentroCosto.ListCentroCostoSearch(oEnt).ToList<entCentroCosto>();
            return ListObj;
        }

        public static entErrores MantCentroCostoForm(entCentroCosto Data)
        {
            return datCentroCosto.MantCentroCostoForm(Data);
        }

    }
}
