using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Query.Tesoreria
{
    public class tsqObligacion
    {
        static String xsql = "";

        public static String QR_ListObligacionToMantVoucherSearch()
        {
            xsql = "select c_compania,n_obligacion,c_tipodocumento,c_numerodocumento,d_fechaemision,d_fechavencimiento," +
                   "c_voucher, c_estadodoc,c_documentocompleto = c_tipodocumento + '-' + c_numerodocumento " +
                   "from tr_obligacion " +
                   "where c_compania = @compania " +
                   "and n_codproveedor = @proveedor " +
                   "and c_tipodocumento like @tipodoc " +
                   "and c_numerodocumento like @numroc " +
                   "and c_estadodoc like @estadodoc " +
                   "order by d_fechaemision desc ";
            return xsql;
        }

        public static String QR_GetObligacionXProvYDoc()
        {
            xsql = "select n_obligacion " +
                   "from tr_obligacion " +
                   "where c_compania = @compania " +
                   "and n_codproveedor = @proveedor " +
                   "and c_tipodocumento = @tipodoc " +
                   "and c_numerodocumento = @numroc ";
            return xsql;
        }

    }
}
