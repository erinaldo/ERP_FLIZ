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
    public class negProveedor
    {
        public static Boolean GetExisteProveedor(String Compania, Int32 Proveedor)
        {
            return datProveedor.GetExisteProveedor(Compania, Proveedor);
        }

    }
}
