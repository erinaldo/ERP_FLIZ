using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negFlujoCaja
    {
        public static entFlujoCaja GetFlujoCajaFormID(String FlujoCaja)
        {
            entFlujoCaja EObj = new entFlujoCaja();
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.GetFlujoCajaFormID(FlujoCaja).ToList<entFlujoCaja>();
            if(ListObj.Count>0){
                EObj = ListObj[0];EObj.ResultadoBusqueda=true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entFlujoCaja> ListFlujoCajaSearch(entFlujoCaja oEnt)
        {
            List<entFlujoCaja> ListObj = new List<entFlujoCaja>();
            ListObj = datFlujoCaja.ListFlujoCajaSearch(oEnt).ToList<entFlujoCaja>();
            return ListObj;
        }

    }
}
