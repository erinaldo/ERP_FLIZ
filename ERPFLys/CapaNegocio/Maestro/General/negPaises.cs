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
    public class negPaises
    {
        public static List<entPaises> ListaFormID()
        {
            List<entPaises> ListObj = new List<entPaises>();
            ListObj = datPaises.ListaFormID().ToList<entPaises>();
            return ListObj;
        }

        public static entPaises GetFormID(String Pais)
        {
            entPaises EObj = new entPaises();
            List<entPaises> ListObj = new List<entPaises>();
            ListObj = datPaises.GetFormID(Pais).ToList<entPaises>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entPaises> ListaCombo(String Estado, String[] Def = null)
        {
            List<entPaises> ListObj = new List<entPaises>();
            ListObj = datPaises.ListaCombo(Estado).ToList<entPaises>();
            if (Def != null){
                ListObj.Insert(0, new entPaises() { Pais = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entPaises> ListaSearch(String Pais, String Descripcion, String Estado)
        {
            List<entPaises> ListObj = new List<entPaises>();
            ListObj = datPaises.ListaSearch(Pais, Descripcion, Estado).ToList<entPaises>();
            return ListObj;
        }

        public static entErrores MantFormID(entPaises Data)
        {
            return datPaises.MantFormID(Data);
        }
        
    }
}
