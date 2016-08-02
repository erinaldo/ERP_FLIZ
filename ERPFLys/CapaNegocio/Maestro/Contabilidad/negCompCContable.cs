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
    public class negCompCContable
    {
        public static List<entCompCContable> ListaFormID(String Cuenta)
        {
            List<entCompCContable> ListObj = new List<entCompCContable>();
            ListObj = datCompCContable.ListaFormID(Cuenta).ToList<entCompCContable>();
            return ListObj;
        }

        public static entCompCContable GetFormID(String Compania, String Cuenta)
        {
            entCompCContable EObj = new entCompCContable();
            List<entCompCContable> ListObj = new List<entCompCContable>();
            ListObj = datCompCContable.GetFormID(Compania, Cuenta).ToList<entCompCContable>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCompCContable> ListaCombo(String Compania, String Estado, String[] Def = null)
        {
            List<entCompCContable> ListObj = new List<entCompCContable>();
            ListObj = datCompCContable.ListaCombo(Compania,Estado).ToList<entCompCContable>();
            if (Def != null){
                ListObj.Insert(0, new entCompCContable() { Cuenta = Def[0] });
            }
            return ListObj;
        }

        public static List<entCompCContable> ListaSearch(String Compania, String Cuenta, String Estado)
        {
            List<entCompCContable> ListObj = new List<entCompCContable>();
            ListObj = datCompCContable.ListaSearch(Compania, Cuenta, Estado).ToList<entCompCContable>();
            return ListObj;
        }

        public static entErrores MantFormID(entCompCContable Data)
        {
            return datCompCContable.MantFormID(Data);
        }

    }
}
