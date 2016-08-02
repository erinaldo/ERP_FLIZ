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
    public class negDistrito
    {
        public static List<entDistrito> ListaFormID()
        {
            List<entDistrito> ListObj = new List<entDistrito>();
            ListObj = datDistrito.ListaFormID().ToList<entDistrito>();
            return ListObj;
        }

        public static entDistrito GetFormID(String Pais, String Departamento, String Provincia, String Distrito)
        {
            entDistrito EObj = new entDistrito();
            List<entDistrito> ListObj = new List<entDistrito>();
            ListObj = datDistrito.GetFormID(Pais, Departamento, Provincia, Distrito).ToList<entDistrito>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entDistrito> ListaCombo(String Pais, String Departamento,String Provincia,String Estado, String[] Def = null)
        {
            List<entDistrito> ListObj = new List<entDistrito>();
            ListObj = datDistrito.ListaCombo(Pais,Departamento, Provincia, Estado).ToList<entDistrito>();
            if (Def != null){
                ListObj.Insert(0, new entDistrito() { DistritoCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entDistrito> ListaSearch(String Pais, String Departamento, String Provincia,String Distrito,String Descripcion, String Estado)
        {
            List<entDistrito> ListObj = new List<entDistrito>();
            ListObj = datDistrito.ListaSearch(Pais,Departamento,Provincia,Distrito, Descripcion, Estado).ToList<entDistrito>();
            return ListObj;
        }

        public static entErrores MantFormID(entDistrito Data)
        {
            return datDistrito.MantFormID(Data);
        }
        
    }
}
