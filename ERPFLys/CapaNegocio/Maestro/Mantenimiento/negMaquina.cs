using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Mantenimiento;
using FiltroLys.Repository.Maestro.Mantenimiento;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Maestro.Mantenimiento
{
    public class negMaquina
    {
        public static entMaquina GetMaquinaFormID(String Compania,String Maquina)
        {
            entMaquina EObj = new entMaquina();
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.GetMaquinaFormID(Compania, Maquina).ToList<entMaquina>();
            if (ListObj.Count > 0) {
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entMaquina> ListMaquinaSearch(entMaquina oEnt)
        {
            List<entMaquina> ListObj = new List<entMaquina>();
            ListObj = datMaquina.ListMaquinaSearch(oEnt).ToList<entMaquina>();
            return ListObj;
        }

    }
}
