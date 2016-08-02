using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Tesoreria;
using FiltroLys.Repository.Maestro.Tesoreria;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Tesoreria
{
    public class negRegimenFiscal
    {
        public static List<entRegimenFiscal> ListaFormID()
        {
            List<entRegimenFiscal> ListObj = new List<entRegimenFiscal>();
            ListObj = datRegimenFiscal.ListaFormID().ToList<entRegimenFiscal>();
            return ListObj;
        }

        public static entRegimenFiscal GetFormID(String RegFiscal)
        {
            entRegimenFiscal EObj = new entRegimenFiscal();
            List<entRegimenFiscal> ListObj = new List<entRegimenFiscal>();
            ListObj = datRegimenFiscal.GetFormID(RegFiscal).ToList<entRegimenFiscal>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entRegimenFiscal> ListaCombo(String Estado,String[] Def = null)
        {
            List<entRegimenFiscal> ListObj = new List<entRegimenFiscal>();
            ListObj = datRegimenFiscal.ListaCombo(Estado).ToList<entRegimenFiscal>();
            if (Def != null){
                ListObj.Insert(0, new entRegimenFiscal() { RegFiscal = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entRegimenFiscal> ListaSearch(String RegFiscal, String Descripcion, String Estado)
        {
            List<entRegimenFiscal> ListObj = new List<entRegimenFiscal>();
            ListObj = datRegimenFiscal.ListaSearch(RegFiscal, Descripcion, Estado).ToList<entRegimenFiscal>();
            return ListObj;
        }

        public static entErrores MantFormID(entRegimenFiscal Data)
        {
            return datRegimenFiscal.MantFormID(Data);
        }

    }
}
