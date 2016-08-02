using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Contabilidad
{
    public class tsqCierreMesCuenta
    {
        static String xsql = "";

        public static String UP_ListSaldoCtaMayor() {
            xsql = "SP_SALDO_CONTABLE_MAYOR";
            return xsql;
        }

        public static String UP_ListSaldoCtaMayorDet()
        {
            xsql = "SP_SALDO_CONTABLE_MAYOR1";
            return xsql;
        }

        public static String UP_GetCierreMensualRev() {
            xsql = "SP_CB_CIERREMENSUAL_REVISION";
            return xsql;
        }

        public static String UP_SetCierreMensualGen()
        {
            xsql = "SP_CB_CIERREMENSUAL_CUENTA";
            return xsql;
        }

        public static String QR_SetModificaPeriodo(String Operacion) {
            if (Operacion.Equals("A")){
                xsql = "update ma_periodocierrecompania " +
                       "set c_estado = 'A', " +
                       "c_ultimousuario = @usuario, " +
                       "d_ultimafechamodificacion = getdate() " +
                       "where c_compania = @compania " +
                       "and c_periodo = @periodo " +
                       "and c_sistema = 'CB'";
            }
            else {
                xsql = "update ma_periodocierrecompania " +
                       "set c_estado = 'C', " +
                       "c_flagbloqueo = 'N', " +
                       "c_ultimousuario = @usuario, " +
                       "d_ultimafechamodificacion = getdate() " +
                       "where c_compania = @compania " +
                       "and c_periodo = @periodo " +
                       "and c_sistema = 'CB'";
            }
            return xsql;
        }

        public static String UP_GetPeriodoSig()
        {
            xsql = "SP_CB_PERIODOSIGUIENTE";
            return xsql;
        }

        public static String QR_SetPeriodoTrabajo(String OpcionQuery) {
            if (OpcionQuery.Equals("A")) {
                xsql = "update ma_periodocierrecompania " +
                       "set c_flagtrabajo = 'N' " +
                       "where c_compania = @compania " +
                       "and c_periodo <> @periodo " +
                       "and c_sistema = 'CB' " +
                       "and c_flagtrabajo = 'S'";
            }

            if (OpcionQuery.Equals("B")){
                xsql = "update ma_periodocierrecompania " +
                       "set c_flagtrabajo = 'S' " +
                       "where c_compania = @compania " +
                       "and c_periodo = @periodo " +
                       "and c_sistema = 'CB' ";
            }

            return xsql;
        }

    }
}
