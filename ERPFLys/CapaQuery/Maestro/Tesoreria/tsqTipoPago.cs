using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.Tesoreria
{
    public class tsqTipoPago
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select c_tipopago,c_descripcion,c_flaggencorrel,c_flagsistema,c_flaggenautpago,c_estado, " +
                   "c_codigosunat,c_codigosunatfp,c_ultimousuariomod,d_ultimafechamod " +
                   "from ma_tipopago";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_tipopago,a.c_descripcion,a.c_flaggencorrel,a.c_flagsistema,a.c_flaggenautpago,a.c_estado, " +
                   "a.c_codigosunat,a.c_codigosunatfp,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "c_usernombreform = b.c_nombre " +
                   "from ma_tipopago a, ma_usuario b " +
                   "where a.c_ultimousuariomod *= b.c_codigousuario " +
                   "and a.c_tipopago = @TipoPago";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_tipopago,c_descripcion,c_estado " +
                   "from ma_tipopago " +
                   "where c_flagsistema like @FlagSistema " +                   
                   "and c_estado like @Estado";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select c_tipopago,c_descripcion,c_estado " +
                   "from ma_tipopago " +
                   "where c_tipopago like @TipoPago " +
                   "and c_descripcion like @Descripcion " +
                   "and c_flagsistema like @FlagSistema " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_tipopago(" +
                           "c_tipopago,c_descripcion,c_flaggencorrel,c_flagsistema,c_flaggenautpago,c_estado, " +
                           "c_codigosunat,c_codigosunatfp,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@TipoPago,@Descripcion,@FlagGenCorrel,@FlagSistema,@FlagGenAutPago,@Estado, " + 
                           "@CodigoSunat,@CodigoSunatFP,@UltimoUsuario,getdate()) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_tipopago set " +
                           "c_descripcion = @Descripcion, " +
                           "c_flaggencorrel = @FlagGenCorrel, " +
                           "c_flagsistema = @FlagSistema, " +
                           "c_flaggenautpago = @FlagGenAutPago, " +
                           "c_codigosunat = @CodigoSunat, " +
                           "c_codigosunatfp = @CodigoSunatFP, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuario, " +
                           "d_ultimafechamod = getdate() " +
                           "where c_tipopago = @TipoPago ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_tipopago " +
                           "where c_tipopago = @TipoPago ";
                    break;
            }
            return xsql;
        }

    }
}
