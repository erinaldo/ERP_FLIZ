using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Maestro.General
{
    public class negPersona
    {
        public static entPersona GetPersonaFormID(String Compania,Int32 Persona)
        {
            entPersona EObj = new entPersona();
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.GetPersonaFormID(Compania,Persona).ToList<entPersona>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entPersona> ListPersonaSearch(entPersona oEnt)
        {
            List<entPersona> ListObj = new List<entPersona>();
            ListObj = datPersona.ListPersonaSearch(oEnt).ToList<entPersona>();
            return ListObj;
        }

    }
}
