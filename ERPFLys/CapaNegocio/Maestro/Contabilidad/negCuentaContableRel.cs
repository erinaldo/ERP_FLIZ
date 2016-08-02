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
    public class negCuentaContableRel
    {
        public static List<entCuentaContableRel> ListaFormID()
        {
            List<entCuentaContableRel> ListObj = new List<entCuentaContableRel>();
            ListObj = datCuentaContableRel.ListaFormID().ToList<entCuentaContableRel>();
            return ListObj;
        }

        public static entCuentaContableRel GetFormID(String CuentaAnt, String CuentaNvo)
        {
            entCuentaContableRel EObj = new entCuentaContableRel();
            List<entCuentaContableRel> ListObj = new List<entCuentaContableRel>();
            ListObj = datCuentaContableRel.GetFormID(CuentaAnt,CuentaNvo).ToList<entCuentaContableRel>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCuentaContableRel> ListaCombo(String Estado, String[] Def = null)
        {
            List<entCuentaContableRel> ListObj = new List<entCuentaContableRel>();
            ListObj = datCuentaContableRel.ListaCombo().ToList<entCuentaContableRel>();
            if (Def != null){
                ListObj.Insert(0, new entCuentaContableRel() { CuentaAnt = Def[0], CuentaNvo = Def[1] });
            }
            return ListObj;
        }

        public static List<entCuentaContableRel> ListaSearch(String CuentaAnt, String CuentaNvo)
        {
            List<entCuentaContableRel> ListObj = new List<entCuentaContableRel>();
            ListObj = datCuentaContableRel.ListaSearch(CuentaAnt, CuentaNvo).ToList<entCuentaContableRel>();
            return ListObj;
        }

        public static entErrores MantFormID(entCuentaContableRel Data)
        {
            return datCuentaContableRel.MantFormID(Data);
        }

    }
}
