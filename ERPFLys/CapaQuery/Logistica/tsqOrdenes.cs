using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Logistica
{
    public class tsqOrdenes
    {
        static String xsql = "";

        public static String QR_ListOrdenesToMantVoucherSearch()
        {
            xsql = "select c_compania,c_numeroorden,n_ampliacion,d_fechapreparacion,n_proveedor,c_razonsocial," +
                   "c_moneda, n_tipodecambio,n_montototal,c_observacion " +
                   "from lo_ordenes " +
                   "where c_compania = @compania " +                   
                   "order by c_compania,d_fechapreparacion desc ";
            return xsql;
        }

        public static String QR_ListOrdenesDetToMantVoucherSearch()
        {
            xsql = "select c_compania,c_numeroorden,n_ampliacion, " +
                   "c_item=(case isnull(c_item,'') when '' then c_commoditycodigo else c_item End), " +
                   "c_descripcion,n_cantidadpedida,n_preciounitario, " +
                   "n_montototal = round(n_cantidadpedida*n_preciounitario,2)" +
                   "from lo_ordenesdetalle " +
                   "where c_compania = @compania " +
                   "and c_numeroorden = @orden " +
                   "and n_ampliacion = @ampliacion ";
            return xsql;
        }

    }
}
