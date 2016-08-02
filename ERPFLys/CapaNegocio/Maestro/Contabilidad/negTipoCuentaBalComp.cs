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
    public class negTipoCuentaBalComp
    {
        public static List<entTipoCuentaBalComp> ListaFormID()
        {
            List<entTipoCuentaBalComp> ListObj = new List<entTipoCuentaBalComp>();
            ListObj = datTipoCuentaBalComp.ListaFormID().ToList<entTipoCuentaBalComp>();
            return ListObj;
        }

        public static entTipoCuentaBalComp GetFormID(String TipoCuenta)
        {
            entTipoCuentaBalComp EObj = new entTipoCuentaBalComp();
            List<entTipoCuentaBalComp> ListObj = new List<entTipoCuentaBalComp>();
            ListObj = datTipoCuentaBalComp.GetFormID(TipoCuenta).ToList<entTipoCuentaBalComp>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoCuentaBalComp> ListaCombo(String Estado, String[] Def = null)
        {
            List<entTipoCuentaBalComp> ListObj = new List<entTipoCuentaBalComp>();
            ListObj = datTipoCuentaBalComp.ListaCombo(Estado).ToList<entTipoCuentaBalComp>();
            if (Def != null){
                ListObj.Insert(0, new entTipoCuentaBalComp() { TipoCuenta = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoCuentaBalComp> ListaSearch(String TipoCuenta, String Descripcion, String Estado)
        {
            List<entTipoCuentaBalComp> ListObj = new List<entTipoCuentaBalComp>();
            ListObj = datTipoCuentaBalComp.ListaSearch(TipoCuenta, Descripcion, Estado).ToList<entTipoCuentaBalComp>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoCuentaBalComp Data)
        {
            return datTipoCuentaBalComp.MantFormID(Data);
        }

    }
}
