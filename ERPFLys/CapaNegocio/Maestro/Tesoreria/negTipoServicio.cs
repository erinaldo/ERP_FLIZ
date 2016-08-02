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
    public class negTipoServicio
    {
        public static List<entTipoServicio> ListaFormID()
        {
            List<entTipoServicio> ListObj = new List<entTipoServicio>();
            ListObj = datTipoServicio.ListaFormID().ToList<entTipoServicio>();
            return ListObj;
        }

        public static entTipoServicio GetFormID(String TipoServicio)
        {
            entTipoServicio EObj = new entTipoServicio();
            List<entTipoServicio> ListObj = new List<entTipoServicio>();
            ListObj = datTipoServicio.GetFormID(TipoServicio).ToList<entTipoServicio>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoServicio> ListaCombo(String RegFiscal,String Estado,String[] Def = null)
        {
            List<entTipoServicio> ListObj = new List<entTipoServicio>();
            ListObj = datTipoServicio.ListaCombo(RegFiscal, Estado).ToList<entTipoServicio>();
            if (Def != null){
                ListObj.Insert(0, new entTipoServicio() { TipoServicio = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entTipoServicio> ListaSearch(String TipoServicio, String Descripcion, String RegFiscal, String Estado)
        {
            List<entTipoServicio> ListObj = new List<entTipoServicio>();
            ListObj = datTipoServicio.ListaSearch(TipoServicio, Descripcion, RegFiscal, Estado).ToList<entTipoServicio>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoServicio Data)
        {
            return datTipoServicio.MantFormID(Data);
        }

    }
}
