using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Repository.Maestro.General;

namespace FiltroLys.Domain.Maestro.General
{
    public class negGeneral
    {
        public static DateTime GetFechaServidor()
        {
            DateTime dFecha = datGeneral.GetFechaServidor();
            return dFecha;
        }

    }
}
