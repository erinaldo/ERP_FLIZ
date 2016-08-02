using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.RRHH
{
    public class tsqEmpleado
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "select * from rh_empleados";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "select a.c_compania,a.n_empleado,a.c_tipopersona,a.c_apellidospaterno,a.c_apellidosmaterno,a.c_nombres,a.c_nombrecompleto, " +
                   "a.c_nombrebusqueda,a.c_tipodocumentopersona,a.c_documento,a.c_documentofiscal,a.c_documentoidentidad,a.c_carnetextranjeria, " +
                   "a.c_pasaporte,a.c_procedencia,a.c_direccion,a.c_pais,a.c_departamentocodigo,a.c_provinciacodigo,a.c_distritocodigo,a.c_mail, " +
                   "a.c_nacionalidad,a.d_fechanacimiento,a.c_educacion,a.c_sexo,a.c_telefono,a.c_fax,a.c_estadocivil,a.c_nombreemergencia, " +
                   "a.c_telefonoemergencia,a.c_direccionemergencia,a.c_tipocuenta,a.c_monedacuenta,a.c_bancocuenta,a.c_numerocuenta,a.n_codigoanterior, " +
                   "a.c_codigousuario,a.d_fechaultimoingreso,a.c_raza,a.c_religion,a.c_tipotrabajador,a.c_tipopension,a.d_fechainiciopension, " + 
                   "a.d_fechafinpension,a.c_codigoafp,a.c_numeroafp,a.c_bancoCTS,a.c_monedaCTS,a.c_cuentaCTS,a.c_departamentoCiacodigo,a.c_cargo, " +
                   "a.c_centrocosto,a.c_tipocontrato,a.c_tipoplanilla,a.c_tipohorario,a.c_celular,a.c_rutafoto,a.c_situacionempleado,a.d_fechaultimocese, " +
                   "a.n_postulante,a.n_perfil,a.c_estado,a.d_fecharegistro,a.c_usuarioregistro,a.c_ultimousuario,a.d_ultimafechamodificacion, " +
                   "a.c_documentoMilitarFA,a.c_tipocarnetasistencia,a.c_carnetasistencia,a.c_referenciadireccion,a.c_grupo,a.c_niveleducativo, " + 
                   "a.c_seguro,a.c_centroformacion,a.c_flagmadrerf,a.c_flagbeneficiariocd,a.c_fotocheck,a.c_usuarioevaluacion,a.c_flagessaludvida, " +
                   "a.c_codigovia,a.c_codigozona,a.c_flagpensionista,a.c_ocupacion,a.c_regimenpensionario,a.c_sctrsalud,a.c_tipomodalidadformativa, " +
                   "a.c_codestablecimiento,a.c_categoriaesp,a.c_obscts,a.c_comisionvarmixta, " +
                   "c_usernombreform = b.c_nombre " +
                   "from rh_empleados a, ma_usuario b " +
                   "where a.c_ultimousuario *= b.c_codigousuario " +
                   "and a.c_compania = @Compania " +
                   "and a.n_empleado = @Empleado ";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "select c_compania,n_empleado,c_nombrecompleto,c_estado " +
                   "from rh_empleados " +
                   "where c_compania = @Compania " +
                   "and c_estado like @Estado ";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "select a.c_compania,a.n_empleado,a.c_nombrecompleto,a.c_tipodocumentopersona,a.c_situacionempleado, " + 
                   "a.c_documento,a.c_documentofiscal,a.c_estado " +
                   "from rh_empleados a" +
                   "where a.c_compania = @Compania " +
                   "and (@Empleado = 0 or a.n_empleado = @Empleado) " +
                   "and a.c_nombrecompleto like @Nombre " +
                   "and a.c_documento like @Documento " +
                   "and a.c_documentofiscal like @DocumentoFiscal " +
                   "and a.c_estado like @Estado ";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion){
                case fnEnum.OperacionMant.Insertar:
                    xsql = "insert into rh_empleados(" +
                           "c_compania,n_empleado,c_tipopersona,c_apellidospaterno,c_apellidosmaterno,c_nombres,c_nombrecompleto, " +
                           "c_nombrebusqueda,c_tipodocumentopersona,c_documento,c_documentofiscal,c_documentoidentidad,c_carnetextranjeria, " +
                           "c_pasaporte,c_procedencia,c_direccion,c_pais,c_departamentocodigo,c_provinciacodigo,c_distritocodigo,c_mail, " +
                           "c_nacionalidad,d_fechanacimiento,c_educacion,c_sexo,c_telefono,c_fax,c_estadocivil,c_nombreemergencia, " +
                           "c_telefonoemergencia,c_direccionemergencia,c_tipocuenta,c_monedacuenta,c_bancocuenta,c_numerocuenta,n_codigoanterior, " +
                           "c_codigousuario,d_fechaultimoingreso,c_raza,c_religion,c_tipotrabajador,c_tipopension,d_fechainiciopension, " +
                           "d_fechafinpension,c_codigoafp,c_numeroafp,c_bancoCTS,c_monedaCTS,c_cuentaCTS,c_departamentoCiacodigo,c_cargo, " +
                           "c_centrocosto,c_tipocontrato,c_tipoplanilla,c_tipohorario,c_celular,c_rutafoto,c_situacionempleado,d_fechaultimocese, " +
                           "n_postulante,n_perfil,c_estado,d_fecharegistro,c_usuarioregistro,c_ultimousuario,d_ultimafechamodificacion, " +
                           "c_documentoMilitarFA,c_tipocarnetasistencia,c_carnetasistencia,c_referenciadireccion,c_grupo,c_niveleducativo, " +
                           "c_seguro,c_centroformacion,c_flagmadrerf,c_flagbeneficiariocd,c_fotocheck,c_usuarioevaluacion,c_flagessaludvida, " +
                           "c_codigovia,c_codigozona,c_flagpensionista,c_ocupacion,c_regimenpensionario,c_sctrsalud,c_tipomodalidadformativa, " +
                           "c_codestablecimiento,c_categoriaesp,c_obscts,c_comisionvarmixta) " +
                           "values(@Compania,@Empleado,@TipoPersona,@ApellidosPaterno,@ApellidosMaterno,@Nombres,@NombreCompleto, " +
                           "@NombreBusqueda,@TipoDocumentoPersona,@Documento,@DocumentoFiscal,@DocumentoIdentidad,@CarnetExtranjeria, " +
                           "@Pasaporte,@Procedencia,@Direccion,@Pais,@DepartamentoCodigo,@ProvinciaCodigo,@DistritoCodigo,@Mail, " +
                           "@Nacionalidad,@FechaNacimiento,@Educacion,@Sexo,@Telefono,@Fax,@EstadoCivil,@NombreEmergencia, " +
                           "@TelefonoEmergencia,@DireccionEmergencia,@TipoCuenta,@MonedaCuenta,@BancoCuenta,@NumeroCuenta,@CodigoAnterior, " +
                           "@CodigoUsuario,@FechaUltimoIngreso,@Raza,@Religion,@TipoTrabajador,@TipoPension,@FechaInicioPension, " +
                           "@FechaFinPension,@CodigoAfp,@NumeroAfp,@BancoCTS,@MonedaCTS,@CuentaCTS,@DepartamentoCiaCodigo,@Cargo, " +
                           "@CentroCosto,@TipoContrato,@TipoPlanilla,@TipoHorario,@Celular,@RutaFoto,@SituacionEmpleado,@FechaUltimoCese, " +
                           "@Postulante,@Perfil,@Estado,@FechaRegistro,@UsuarioRegistro,@UltimoUsuario,getdate(), " +
                           "@DocumentoMilitarFA,@TipoCarnetAsistencia,@CarnetAsistencia,@ReferenciaDireccion,@Grupo,@NivelEducativo, " +
                           "@Seguro,@CentroFormacion,@FlagMadreRF,@FlagBeneficiarioCD,@FotoCheck,@UsuarioEvaluacion,@FlagEssaludVida, " +
                           "@Codigovia,@CodigoZona,@FlagPensionista,@Ocupacion,@RegimenPensionario,@SctrSalud,@TipoModalidadFormativa, " +
                           "@CodEstablecimiento,@CategoriaEsp,@Obscts,@ComisionVarMixta) ";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "update rh_empleados set " +
                           "c_tipopersona = @TipoPersona, " +
                           "c_apellidospaterno = @ApellidosPaterno, " +
                           "c_apellidosmaterno = @ApellidosMaterno, " +
                           "c_nombres = @Nombres, " +
                           "c_nombrecompleto = @NombreCompleto, " +
                           "c_nombrebusqueda = @NombreBusqueda, " +
                           "c_tipodocumentopersona = @TipoDocumentoPersona, " +
                           "c_documento = @Documento, " +
                           "c_documentofiscal = @DocumentoFiscal, " +
                           "c_documentoidentidad = @DocumentoIdentidad, " +
                           "c_carnetextranjeria = @CarnetExtranjeria, " +
                           "c_pasaporte = @Pasaporte, " +
                           "c_procedencia = @Procedencia, " +
                           "c_direccion = @Direccion, " +
                           "c_pais = @Pais, " +
                           "c_departamentocodigo = @DepartamentoCodigo, " +
                           "c_provinciacodigo = @ProvinciaCodigo, " +
                           "c_distritocodigo = @DistritoCodigo, " +
                           "c_mail = @Mail, " +
                           "c_nacionalidad = @Nacionalidad, " +
                           "d_fechanacimiento = @FechaNacimiento, " +
                           "c_educacion = @Educacion, " +
                           "c_sexo = @Sexo, " +
                           "c_telefono = @Telefono, " +
                           "c_fax = @Fax, " +
                           "c_estadocivil = @EstadoCivil, " +
                           "c_nombreemergencia = @NombreEmergencia, " +                           
                           "c_telefonoemergencia = @TelefonoEmergencia, " +
                           "c_direccionemergencia = @DireccionEmergencia, " +
                           "c_tipocuenta = @TipoCuenta, " +
                           "c_monedacuenta = @MonedaCuenta, " +
                           "c_bancocuenta = @BancoCuenta, " +
                           "c_numerocuenta = @NumeroCuenta, " +
                           "n_codigoanterior = @CodigoAnterior, " +
                           "c_codigousuario = @CodigoUsuario, " +
                           "d_fechaultimoingreso = @FechaUltimoIngreso, " +
                           "c_raza = @Raza, " +
                           "c_religion = @Religion, " +
                           "c_tipotrabajador = @TipoTrabajador, " +
                           "c_tipopension = @TipoPension, " +
                           "d_fechainiciopension = @FechaInicioPension, " +
                           "d_fechafinpension = @FechaFinPension, " +
                           "c_codigoafp = @CodigoAfp, " +
                           "c_numeroafp = @NumeroAfp, " +
                           "c_bancoCTS = @BancoCTS, " +
                           "c_monedaCTS = @MonedaCTS, " +
                           "c_cuentaCTS = @CuentaCTS, " +
                           "c_departamentoCiacodigo = @DepartamentoCiaCodigo, " +
                           "c_cargo = @Cargo, " +
                           "c_centrocosto = @CentroCosto, " +
                           "c_tipocontrato = @TipoContrato, " +
                           "c_tipoplanilla = @TipoPlanilla, " +
                           "c_tipohorario = @TipoHorario, " +
                           "c_celular = @Celular, " +
                           "c_rutafoto = @RutaFoto, " +
                           "c_situacionempleado = @SituacionEmpleado, " +
                           "d_fechaultimocese = @FechaUltimoCese, " +
                           "n_postulante = @Postulante, " +
                           "n_perfil = @Perfil, " +
                           "c_estado = @Estado, " +
                           "d_fecharegistro = @FechaRegistro, " +
                           "c_usuarioregistro = @UsuarioRegistro, " +
                           "c_ultimousuario = @UltimoUsuario, " + 
                           "d_ultimafechamodificacion = getdate(), " +
                           "c_documentoMilitarFA = @DocumentoMilitarFA, " +
                           "c_tipocarnetasistencia = @TipoCarnetAsistencia, " +
                           "c_carnetasistencia = @CarnetAsistencia, " +
                           "c_referenciadireccion = @ReferenciaDireccion, " +
                           "c_grupo = @Grupo, " +
                           "c_niveleducativo = @NivelEducativo, " +
                           "c_seguro = @Seguro, " +
                           "c_centroformacion = @CentroFormacion, " +
                           "c_flagmadrerf = @FlagMadreRF, " +
                           "c_flagbeneficiariocd = @FlagBeneficiarioCD, " +
                           "c_fotocheck = @FotoCheck, " +
                           "c_usuarioevaluacion = @UsuarioEvaluacion, " +
                           "c_flagessaludvida = @FlagEssaludVida, " +
                           "c_codigovia = @Codigovia, " +
                           "c_codigozona = @CodigoZona, " +
                           "c_flagpensionista = @FlagPensionista, " +
                           "c_ocupacion = @Ocupacion, " +
                           "c_regimenpensionario = @RegimenPensionario, " +
                           "c_sctrsalud = @SctrSalud, " +
                           "c_tipomodalidadformativa = @TipoModalidadFormativa, " +
                           "c_codestablecimiento = @CodEstablecimiento, " +
                           "c_categoriaesp = @CategoriaEsp, " +
                           "c_obscts = @Obscts, " +
                           "c_comisionvarmixta = @ComisionVarMixta " +
                           "where c_compania = @Compania " +
                           "and n_empleado = @Empleado ";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "delete rh_empleados " +
                           "where c_compania = @Compania " +
                           "and n_empleado = @Empleado ";
                    break;
            }
            return xsql;
        }

    }
}
