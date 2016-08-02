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
    public class negLineaProducto
    {
        public static List<entLineaProducto> ListaFormID()
        {
            List<entLineaProducto> ListObj = new List<entLineaProducto>();
            ListObj = datLineaProducto.ListaFormID().ToList<entLineaProducto>();
            return ListObj;
        }

        public static entLineaProducto GetFormID(String Compania,String LineaProducto)
        {
            entLineaProducto EObj = new entLineaProducto();
            List<entLineaProducto> ListObj = new List<entLineaProducto>();
            ListObj = datLineaProducto.GetFormID(Compania, LineaProducto).ToList<entLineaProducto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entLineaProducto> ListaCombo(String Compania, String[] Def = null)
        {
            List<entLineaProducto> ListObj = new List<entLineaProducto>();
            ListObj = datLineaProducto.ListaCombo(Compania).ToList<entLineaProducto>();
            if (Def != null){
                ListObj.Insert(0, new entLineaProducto() { LineaProducto = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entLineaProducto> ListaSearch(String Compania, String LineaProducto, String Descripcion)
        {
            List<entLineaProducto> ListObj = new List<entLineaProducto>();
            ListObj = datLineaProducto.ListaSearch(Compania, LineaProducto, Descripcion).ToList<entLineaProducto>();
            return ListObj;
        }

        public static entErrores MantFormID(entLineaProducto Data)
        {
            return datLineaProducto.MantFormID(Data);
        }

    }
}
