using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Contabilidad
{
    public class tsqReporteCB
    {
        static String xsql = "";

        public static String UP_RptLibroDiario()
        {
            xsql = "SP_CB_REP_LIBRODIARIO";
            return xsql;
        }

        public static String UP_RptLibroMayor()
        {
            xsql = "SP_CB_REP_LIBROMAYOR";
            return xsql;
        }

        public static String UP_RptRegistroCompra()
        {
            xsql = "SP_CB_REP_REGISTROCOMPRA_SUNAT";
            return xsql;
        }

        public static String UP_RptRegistroRetencion(){
            xsql = "SP_CB_REP_LIBRORETENCION";
            return xsql;
        }

        public static String UP_RptRegistroDaotVenta()
        {
            xsql = "SP_CB_REP_REGVENTAS_DAOT";
            return xsql;
        }

        public static String UP_RptRegistroDaotCompra()
        {
            xsql = "SP_CB_REP_REGCOMPRAS_DAOT";
            return xsql;
        }

        public static String UP_RptPlanCuenta()
        {
            xsql = "SP_CB_REP_PLAN_CUENTAS";
            return xsql;
        }

    }
}
