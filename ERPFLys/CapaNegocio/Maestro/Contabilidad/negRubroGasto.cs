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
    public class negRubroGasto
    {
        public static List<entRubroGasto> ListaFormID()
        {
            List<entRubroGasto> ListObj = new List<entRubroGasto>();
            ListObj = datRubroGasto.ListaFormID().ToList<entRubroGasto>();
            return ListObj;
        }

        public static entRubroGasto GetFormID(String RubroGasto)
        {
            entRubroGasto EObj = new entRubroGasto();
            List<entRubroGasto> ListObj = new List<entRubroGasto>();
            ListObj = datRubroGasto.GetFormID(RubroGasto).ToList<entRubroGasto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entRubroGasto> ListaCombo(String[] Def = null)
        {
            List<entRubroGasto> ListObj = new List<entRubroGasto>();
            ListObj = datRubroGasto.ListaCombo().ToList<entRubroGasto>();
            if (Def != null){
                ListObj.Insert(0, new entRubroGasto() { RubroGasto = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entRubroGasto> ListaSearch(String RubroGasto, String Descripcion)
        {
            List<entRubroGasto> ListObj = new List<entRubroGasto>();
            ListObj = datRubroGasto.ListaSearch(RubroGasto, Descripcion).ToList<entRubroGasto>();
            return ListObj;
        }

        public static entErrores MantFormID(entRubroGasto Data)
        {
            return datRubroGasto.MantFormID(Data);
        }

    }
}
