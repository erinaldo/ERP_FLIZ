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
    public class negRubroCtaContable
    {
        public static List<entRubroCtaContable> ListaFormID()
        {
            List<entRubroCtaContable> ListObj = new List<entRubroCtaContable>();
            ListObj = datRubroCtaContable.ListaFormID().ToList<entRubroCtaContable>();
            return ListObj;
        }

        public static entRubroCtaContable GetFormID(String CodRubro)
        {
            entRubroCtaContable EObj = new entRubroCtaContable();
            List<entRubroCtaContable> ListObj = new List<entRubroCtaContable>();
            ListObj = datRubroCtaContable.GetFormID(CodRubro).ToList<entRubroCtaContable>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entRubroCtaContable> ListaCombo(String Estado, String[] Def = null)
        {
            List<entRubroCtaContable> ListObj = new List<entRubroCtaContable>();
            ListObj = datRubroCtaContable.ListaCombo(Estado).ToList<entRubroCtaContable>();
            if (Def != null){
                ListObj.Insert(0, new entRubroCtaContable() { CodRubro = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entRubroCtaContable> ListaSearch(String CodRubro, String Clasificacion, String Descripcion, String Estado)
        {
            List<entRubroCtaContable> ListObj = new List<entRubroCtaContable>();
            ListObj = datRubroCtaContable.ListaSearch(CodRubro, Clasificacion, Descripcion, Estado).ToList<entRubroCtaContable>();
            return ListObj;
        }

        public static entErrores MantFormID(entRubroCtaContable Data)
        {
            return datRubroCtaContable.MantFormID(Data);
        }

    }
}
