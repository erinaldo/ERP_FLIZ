using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqCliente
    {
        static String xsql = "";

        public static String QR_GetExisteCliente()
        {
            xsql = "select count(1) " +
                   "from ma_clientes " +
                   "where c_compania = @compania " +
                   "and n_cliente = @cliente";
            return xsql;
        }

    }
}
