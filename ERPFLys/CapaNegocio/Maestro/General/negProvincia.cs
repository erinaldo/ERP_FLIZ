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
    public class negProvincia
    {
        public static List<entProvincia> ListaFormID()
        {
            List<entProvincia> ListObj = new List<entProvincia>();
            ListObj = datProvincia.ListaFormID().ToList<entProvincia>();
            return ListObj;
        }

        public static entProvincia GetFormID(String Pais, String Departamento, String Provincia)
        {
            entProvincia EObj = new entProvincia();
            List<entProvincia> ListObj = new List<entProvincia>();
            ListObj = datProvincia.GetFormID(Pais, Departamento, Provincia).ToList<entProvincia>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entProvincia> ListaCombo(String Pais, String Departamento,String Estado, String[] Def = null)
        {
            List<entProvincia> ListObj = new List<entProvincia>();
            ListObj = datProvincia.ListaCombo(Pais,Departamento, Estado).ToList<entProvincia>();
            if (Def != null){
                ListObj.Insert(0, new entProvincia() { ProvinciaCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entProvincia> ListaSearch(String Pais, String Departamento, String Provincia,String Descripcion, String Estado)
        {
            List<entProvincia> ListObj = new List<entProvincia>();
            ListObj = datProvincia.ListaSearch(Pais,Departamento,Provincia, Descripcion, Estado).ToList<entProvincia>();
            return ListObj;
        }

        public static entErrores MantFormID(entProvincia Data)
        {
            return datProvincia.MantFormID(Data);
        }
        
    }
}
