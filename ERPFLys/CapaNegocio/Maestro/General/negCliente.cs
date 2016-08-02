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
    public class negCliente
    {
        public static Boolean GetExisteCliente(String Compania, Int32 Cliente)
        {
            return datCliente.GetExisteCliente(Compania, Cliente);
        }

    }
}
