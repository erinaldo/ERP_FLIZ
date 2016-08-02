using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Maestro.Contabilidad
{
    public class tsqAsientoModelo
    {
        static String xsql = "";

        public static String QR_ListAsientoModelo()
        {

            xsql = "UP_MANT_ASIENTO_MODELO";

            return xsql;
        }

        public static String QR_ListAsientoModeloDet()
        {
            xsql = "UP_MANT_ASIENTO_MODELO";
            return xsql;
        }

        public static String QR_ListAsientoModeloSearch()
        {
            xsql = "select c_compania,c_modelo,c_descripcion=rtrim(c_descripcion) " +
                   "from ma_asientomodelo " +
                   "where c_compania = @compania " +
                   "and c_estado = 'A' " +
                   "order by c_compania,c_descripcion";
            return xsql;
        }

        public static String QR_ListAsientoModeloDetSearch()
        {
            xsql = "select c_compania,c_modelo,n_linea,c_cuenta,c_centrocosto,n_persona,c_documento, " +
                   "c_descripcion=ltrim(rtrim(c_descripcion)),n_porcentaje,n_monto=convert(decimal(20,6),0)" +
                   "from ma_asientomodelodet " +
                   "where c_compania = @compania " +
                   "and c_modelo = @modelo " +
                   "order by c_compania,c_modelo,n_linea ";
            return xsql;
        }

        public static String QR_MantAsientoModelo(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
            }
            return xsql;
        }

        public static String QR_MantAsientoModeloDetalle(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
                case fnEnum.OperacionMant.EliminarTodos:
                    xsql = "UP_MANT_ASIENTO_MODELO";
                    break;
            }
            return xsql;
        }

    }
}
