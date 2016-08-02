using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqCompania
    {
        static String xsql = "";

        public static String QR_ListCompaniaForm() {
            xsql = "select c_compania,c_nombres,c_telefono,c_direccion,c_documentoFiscal,c_estado,c_ultimousuario, " +
                   "d_ultimaFechaModificacion " +
                   "from ma_compania " +
                   "where (@compania = 'T' or (@compania <> 'T' and c_compania = @compania)) " +
                   "and (@estado = 'T' or (@estado <> 'T' and c_estado = @estado)) " +
                   "and c_nombres like @nombre " +
                   "order by c_compania";
            return xsql;
        }

        public static String QR_GetCompaniaFormID()
        {
            xsql = "select a.c_compania,a.c_nombres,a.c_nombreTelecredito,a.c_estado,a.c_ultimousuario,a.d_ultimafechamodificacion,a.c_telefono, " +
                   "a.c_direccion,a.c_documentofiscal,a.c_pais,a.c_departamentocodigo,a.c_provinciacodigo,a.c_distritocodigo,a.c_fax, " +
                   "a.c_actividadeconomica,a.c_codigosunat_condicion,a.c_codigosunat_via,a.c_codigosunat_zona,a.c_codigosunat_tipoestab, " +
                   "a.c_flagendoso,a.c_companiaendoso,a.c_serieletra,a.n_codigo,a.c_sectorcompania,a.c_aplica_ret,a.c_monedamnt_ret, " +
                   "a.n_mntlimite_ret,a.n_porcent_ret,a.c_serie_ret,a.n_limite_ret,a.c_flagreplica,a.c_compreplica,a.c_namebd_o,a.c_namebd_d, " +
                   "a.c_flagcofilsa,a.n_org_hoshin,a.n_montominsolesback,a.c_compbasecomision,a.c_validanohabnohall, " +
                   "c_ultimousuariomodnombre = isnull(b.c_nombre,'') " +
                   "from ma_compania a,ma_usuario b " +
                   "where c_compania = @compania " +
                   "and a.c_ultimousuario *= b.c_codigousuario" ;
            return xsql;
        }

        public static String UP_ListCiaComboXAppXUsu()
        {
            xsql = "SP_MA_COMPANIA_ACCESO";
            return xsql;
        }
        
        public static String QR_MantCompaniaForm(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into ma_compania(c_compania,c_nombres,c_nombretelecredito,c_telefono,c_direccion,c_documentofiscal, " +
                           "c_pais,c_departamentocodigo,c_provinciacodigo,c_distritocodigo,c_estado,c_ultimousuario,d_ultimafechamodificacion, " +
                           "c_fax,c_actividadeconomica,c_codigosunat_condicion,c_codigosunat_via,c_codigosunat_zona,c_codigosunat_tipoestab,c_sectorcompania) " +
                           "values(@Compania,@Nombre,@NombreTeleCredito,@Telefono,@Direccion,@DocumentoFiscal," +
                           "@Pais,@DepartamentoCodigo,@ProvinciaCodigo,@DistritoCodigo,@Estado,@UltimoUsuario,getdate(), " +
                           "@Fax,@ActividadEconomica,@CodigoSunat_Condicion,@CodigoSunat_Via,@CodigoSunat_Zona,@CodigoSunat_TipoEstab,@SectorCompania)";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update ma_compania set " +
                           "c_nombres = @Nombre, " +
                           "c_nombretelecredito = @NombreTeleCredito, " +
                           "c_telefono = @Telefono, " +
                           "c_direccion = @Direccion, " +
                           "c_documentofiscal = @DocumentoFiscal, " +
                           "c_pais = @Pais, " +
                           "c_departamentocodigo = @DepartamentoCodigo, " +
                           "c_provinciacodigo = @ProvinciaCodigo, " +
                           "c_distritocodigo = @DistritoCodigo, " +
                           "c_estado = @Estado, " +
                           "c_ultimousuario = @UltimoUsuario, " +
                           "d_ultimafechamodificacion = getdate(), " +
                           "c_fax = @Fax, " +
                           "c_actividadeconomica = @ActividadEconomica, " +
                           "c_codigosunat_condicion = @CodigoSunat_Condicion, " +
                           "c_codigosunat_via = @CodigoSunat_Via, " +
                           "c_codigosunat_zona = @CodigoSunat_Zona, " +
                           "c_codigosunat_tipoestab = @CodigoSunat_TipoEstab, " +
                           "c_sectorcompania = @SectorCompania " +
                           "where c_compania = @Compania ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete ma_compania where c_compania = @Compania ";
                    break;
            }
            return xsql;
        }

    }
}
