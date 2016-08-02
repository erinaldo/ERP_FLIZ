using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqProveedor
    {
        static String xsql = "";

        public static String QR_GetExisteProveedor()
        {
            xsql = "select count(1) " +
                   "from ma_proveedores " +
                   "where c_compania = @compania " +
                   "and n_proveedor = @proveedor";
            return xsql;
        }

    }
}
