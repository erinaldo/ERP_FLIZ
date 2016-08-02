using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Contabilidad
{
    public class tsqVoucher
    {
        static String xsql = "";

        public static String QR_ListVoucherForm(String Cia, String FlagDepartCia, String DepartCia, String FlagPeriodo,
        String Periodo,String FlagEstado,String Estado,String FlagVoucher,String TipoVoucher,String VoucherIni,String VoucherFin)
        {
            xsql = "select a.c_compania,a.c_periodo,a.c_tipovoucher,a.c_numerovoucher,a.c_departamento,a.d_fecha,a.c_descripcion, " +
                   "a.c_usuarioregistro,a.d_fecharegistro,a.c_usuarioaprobacion,a.d_fechaaprobacion,a.c_origen, " +
                   "a.c_flagmodmanual,a.c_flagmodrestringida,a.c_estado,a.c_ultimousuariomod,a.d_ultimafechamod, " +
                   "c_departNombre=rtrim(b.c_descripcion) " +
                   "from cb_voucher a " +
                   "inner join ma_departamentocia b on (a.c_compania = b.c_compania and a.c_departamento = b.c_departamentoCiacodigo) " +
                   "where a.c_compania ='" + Cia + "' " +
                   "and ('" + FlagDepartCia + "'= 'S' or a.c_departamento ='" + DepartCia + "') " +
                   "and ('" + FlagPeriodo + "'= 'S' or a.c_periodo ='" + Periodo + "') " +
                   "and ('" + FlagEstado + "'= 'S' or a.c_estado ='" + Estado + "') " +
                   "and ('" + FlagVoucher + "'= 'S' or (a.c_tipovoucher = '" + TipoVoucher + "' and a.c_numerovoucher between '" + VoucherIni +"' and '" + VoucherFin +"'))";
            return xsql;
        }

        public static String QR_GetVoucherFormID(String Cia, String Periodo, String TipoVoucher, String NroVoucher)
        {
            xsql = "select c_compania,c_periodo,c_tipovoucher,c_numerovoucher,c_departamento,c_moneda,d_fecha," +
                   "n_tipocambio,c_descripcion,c_usuarioregistro,d_fecharegistro,c_usuarioaprobacion,d_fechaaprobacion," +
                   "c_origen,c_flagmodmanual,c_flagmodrestringida,c_estado,c_ultimousuariomod,d_ultimafechamod " +
                   "from cb_voucher " +
                   "where c_compania = '" + Cia + "' " +
                   "and c_periodo = '" + Periodo + "' " +
                   "and c_tipovoucher ='" + TipoVoucher + "' " +
                   "and c_numerovoucher ='" + NroVoucher + "'";
            return xsql;
        }

        public static String QR_ListVoucherFormIDDet(String Cia, String Periodo, String TipoVoucher, String NroVoucher) { 
            xsql = "select c_compania,c_periodo,c_tipovoucher,c_numerovoucher,n_linea,c_cuenta,n_persona,c_centrocosto, " + 
                   "c_flujocaja,c_origendoc,n_codigodoc,c_documento,d_fecha,c_proyecto,c_ordencompra,n_secuencia_oc, " +
                   "n_montolocal,n_montoext,c_descripcion,c_flagautomatico,c_ultimousuariomod,d_ultimafechamod,c_codmaquina, " +
                   "c_OCompraID = c_ordencompra + '-' + convert(varchar,n_secuencia_oc)  " +
                   "from cb_voucherdetalle " +
                   "where c_compania = '" + Cia + "' " +
                   "and c_periodo = '" + Periodo + "' " +
                   "and c_tipovoucher ='" + TipoVoucher + "' " +
                   "and c_numerovoucher ='" + NroVoucher + "'";
            return xsql;
        }

        public static String QR_ListVoucherToMayor() {
            xsql = "select a.c_compania,a.c_periodo,a.c_tipovoucher,a.c_numerovoucher, " +
                   "a.c_descripcion,a.c_moneda,a.c_origen, " +
                   "n_montolocal = sum(b.n_montolocal), n_montoext = sum(b.n_montoext) " +
                   "from cb_voucher a, cb_voucherdetalle b " +
                   "where a.c_compania = b.c_compania " +
                   "and a.c_periodo = b.c_periodo " +
                   "and a.c_tipovoucher = b.c_tipovoucher " +
                   "and a.c_numerovoucher = b.c_numerovoucher " +
                   "and a.c_compania = @compania " +
                   "and a.c_periodo = @periodo " +
                   "and a.c_estado = @estado " +
                   "and b.n_montolocal > 0 " +
                   "group by a.c_compania,a.c_periodo,a.c_tipovoucher,a.c_numerovoucher,a.c_descripcion,a.c_moneda,a.c_origen ";
            return xsql;
        }

        public static String QR_ListVoucherDetCiaPerCuenta()
        {
            xsql = "select b.c_compania, b.c_periodo, b.c_tipovoucher, b.c_numerovoucher, b.n_linea, " +
                   "c_descripcioncab = a.c_descripcion, b.n_montolocal, b.n_montoext, a.d_fechaaprobacion, b.c_cuenta, " +
                   "b.n_persona, b.c_documento, b.c_centrocosto, b.c_descripcion " +
                   "from cb_voucher a, cb_voucherdetalle b " +
                   "where a.c_compania = b.c_compania " +
                   "and a.c_periodo = b.c_periodo " +
                   "and a.c_tipovoucher = b.c_tipovoucher " +
                   "and a.c_numerovoucher = b.c_numerovoucher " +
                   "and a.c_compania = @compania " +
                   "and a.c_periodo = @periodo " +
                   "and b.c_cuenta = @cuenta";
            return xsql;
        }

        public static String QR_MantVoucherCabecera(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into cb_voucher(c_compania,c_periodo,c_tipovoucher,c_numerovoucher,c_departamento,c_moneda,d_fecha, " +
                           "n_tipocambio,c_descripcion,c_usuarioregistro,d_fecharegistro,c_usuarioaprobacion,d_fechaaprobacion,c_origen, " +
                           "c_flagmodmanual,c_flagmodrestringida,c_estado,c_ultimousuariomod,d_ultimafechamod) " +
                           "values(@Compania,@Periodo,@TipoVoucher,@NumeroVoucher,@Departamento,@Moneda,@Fecha, " +
                           "@TipoCambio,@Descripcion,@UsuarioRegistro,@FechaRegistro,@UsuarioAprobacion,@FechaAprobacion,@Origen, " +
                           "@FlagModManual,@FlagModRestringida,@Estado,@UltimoUsuarioMod,@UltimaFechaMod)";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update cb_voucher set " +
                           "c_departamento = @Departamento, " +
                           "c_moneda = @Moneda, " +
                           "d_fecha = @Fecha, " +
                           "n_tipocambio = @TipoCambio, " +
                           "c_descripcion = @Descripcion, " +
                           "c_usuarioregistro = @UsuarioRegistro, " +
                           "d_fecharegistro = @FechaRegistro, " +
                           "c_usuarioaprobacion = @UsuarioAprobacion, " +
                           "d_fechaaprobacion = @FechaAprobacion, " +
                           "c_origen = @Origen, " +
                           "c_flagmodmanual = @FlagModManual, " +
                           "c_flagmodrestringida = @FlagModRestringida, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuariomod = @UltimoUsuarioMod, " +
                           "d_ultimafechamod = @UltimaFechaMod " +
                           "where c_compania = @Compania " +
                           "and c_periodo = @Periodo " +
                           "and c_tipovoucher = @TipoVoucher " +
                           "and c_numerovoucher = @NumeroVoucher ";
                    break;
            }
            return xsql;
        }

        public static String QR_MantVoucherDetalle(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into cb_voucherdetalle(c_compania,c_periodo,c_tipovoucher,c_numerovoucher,n_linea,c_cuenta,n_persona,c_centrocosto, " +
                           "c_flujocaja,c_origendoc,n_codigodoc,c_documento,d_fecha,c_proyecto,c_ordencompra,n_secuencia_oc,n_montolocal,n_montoext, " +
                           "c_descripcion,c_flagautomatico,c_ultimousuariomod,d_ultimafechamod,c_codmaquina) " +
                           "values(@Compania,@Periodo,@TipoVoucher,@NumeroVoucher,@Linea,@Cuenta,@Persona,@CentroCosto, " +
                           "@FlujoCaja,@OrigenDoc,@CodigoDoc,@Documento,@Fecha,@Proyecto,@OrdenCompra,@Secuencia_OC,@MontoLocal,@MontoExt, " +
                           "@Descripcion,@FlagAutomatico,@UltimoUsuarioMod,@UltimaFechaMod,@CodMaquina)";
                    break;
                case fnEnum.OperacionMant.EliminarTodos:
                    xsql = "delete cb_voucherdetalle " +
                           "where c_compania = @Compania " +
                           "and c_periodo = @Periodo " +
                           "and c_tipovoucher = @TipoVoucher " +
                           "and c_numerovoucher = @NumeroVoucher ";
                    break;
            }
            return xsql;
        }
        
        public static String UP_AprobarVoucher() {
            xsql = "SP_CB_VOUCHER_APROBACION";
            return xsql;
        }

        public static String UP_PasarPendienteVoucher()
        {
            xsql = "SP_CB_VOUCHER_PENDIENTE";
            return xsql;
        }

    }
}
