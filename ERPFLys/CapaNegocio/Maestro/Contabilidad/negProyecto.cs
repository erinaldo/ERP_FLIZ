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
    public class negProyecto
    {
        public static List<entProyecto> ListaFormID()
        {
            List<entProyecto> ListObj = new List<entProyecto>();
            ListObj = datProyecto.ListaFormID().ToList<entProyecto>();
            return ListObj;
        }

        public static entProyecto GetFormID(String Compania,String ProyectoCodigo)
        {
            entProyecto EObj = new entProyecto();
            List<entProyecto> ListObj = new List<entProyecto>();
            ListObj = datProyecto.GetFormID(Compania, ProyectoCodigo).ToList<entProyecto>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entProyecto> ListaCombo(String Compania, String Estado,String[] Def = null)
        {
            List<entProyecto> ListObj = new List<entProyecto>();
            ListObj = datProyecto.ListaCombo(Compania, Estado).ToList<entProyecto>();
            if (Def != null){
                ListObj.Insert(0, new entProyecto() { ProyectoCodigo = Def[0], Descripcion = Def[1] });
            }
            return ListObj;
        }

        public static List<entProyecto> ListaSearch(String Compania, String ProyectoCodigo, String Descripcion, String Estado)
        {
            List<entProyecto> ListObj = new List<entProyecto>();
            ListObj = datProyecto.ListaSearch(Compania, ProyectoCodigo, Descripcion, Estado).ToList<entProyecto>();
            return ListObj;
        }

        public static entErrores MantFormID(entProyecto Data)
        {
            return datProyecto.MantFormID(Data);
        }

    }
}
