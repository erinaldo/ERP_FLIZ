using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.RRHH
{
    public class entEmpleado : entBase
    {
        private String c_Compania, c_TipoPersona, c_ApellidosPaterno, c_ApellidosMaterno, c_Nombres, c_NombreCompleto, c_NombreBusqueda;
        private String c_TipoDocumentoPersona, c_Documento, c_DocumentoFiscal, c_DocumentoIdentidad, c_CarnetExtranjeria, c_Pasaporte;
        private String c_Procedencia, c_Direccion, c_Pais, c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_Mail;
        private String c_Nacionalidad, c_Educacion, c_Sexo, c_Telefono, c_Fax, c_EstadoCivil, c_NombreEmergencia, c_TelefonoEmergencia;
        private String c_DireccionEmergencia, c_TipoCuenta, c_MonedaCuenta, c_BancoCuenta, c_NumeroCuenta, c_CodigoUsuario, c_Raza;
        private String c_Religion, c_TipoTrabajador, c_TipoPension, c_CodigoAfp, c_NumeroAfp, c_BancoCTS, c_MonedaCTS, c_CuentaCTS;
        private String c_DepartamentoCiaCodigo, c_Cargo, c_CentroCosto, c_TipoContrato, c_TipoPlanilla, c_TipoHorario, c_Celular;
        private String c_RutaFoto, c_SituacionEmpleado, c_Estado = "A", c_UsuarioRegistro, c_UltimoUsuario, c_DocumentoMilitarFA;
        private String c_TipoCarnetAsistencia, c_CarnetAsistencia, c_ReferenciaDireccion, c_Grupo, c_NivelEducativo, c_Seguro;
        private String c_CentroFormacion, c_FlagMadreRF = "N", c_FlagBeneficiarioCD = "N", c_FotoCheck, c_UsuarioEvaluacion;
        private String c_FlagEssaludVida = "N", c_CodigoVia, c_CodigoZona, c_FlagPensionista = "N", c_Ocupacion, c_RegimenPensionario;
        private String c_SctrSalud, c_TipoModalidadFormativa, c_CodEstablecimiento, c_CategoriaEsp, c_ObsCts, c_ComisionVarMixta = "N";
        private int n_Empleado, n_CodigoAnterior, n_Postulante, n_Perfil;
        private DateTime d_FechaNacimiento, d_FechaUltimoIngreso, d_FechaInicioPension, d_FechaFinPension, d_FechaUltimoCese;
        private DateTime d_FechaRegistro = DateTime.Now, d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Int32 Empleado
        {
            get { return n_Empleado; }
            set { n_Empleado = value; }
        }

        public String TipoPersona
        {
            get { return c_TipoPersona; }
            set { c_TipoPersona = value; }
        }

        public String ApellidosPaterno
        {
            get { return c_ApellidosPaterno; }
            set { c_ApellidosPaterno = value; }
        }

        public String ApellidosMaterno
        {
            get { return c_ApellidosMaterno; }
            set { c_ApellidosMaterno = value; }
        }

        public String Nombres
        {
            get { return c_Nombres; }
            set { c_Nombres = value; }
        }

        public String NombreCompleto
        {
            get { return c_NombreCompleto; }
            set { c_NombreCompleto = value; }
        }

        public String NombreBusqueda
        {
            get { return c_NombreBusqueda; }
            set { c_NombreBusqueda = value; }
        }

        public String TipoDocumentoPersona
        {
            get { return c_TipoDocumentoPersona; }
            set { c_TipoDocumentoPersona = value; }
        }

        public String Documento
        {
            get { return c_Documento; }
            set { c_Documento = value; }
        }

        public String DocumentoFiscal
        {
            get { return c_DocumentoFiscal; }
            set { c_DocumentoFiscal = value; }
        }

        public String DocumentoIdentidad
        {
            get { return c_DocumentoIdentidad; }
            set { c_DocumentoIdentidad = value; }
        }

        public String CarnetExtranjeria
        {
            get { return c_CarnetExtranjeria; }
            set { c_CarnetExtranjeria = value; }
        }

        public String Pasaporte
        {
            get { return c_Pasaporte; }
            set { c_Pasaporte = value; }
        }

        public String Procedencia
        {
            get { return c_Procedencia; }
            set { c_Procedencia = value; }
        }

        public String Direccion
        {
            get { return c_Direccion; }
            set { c_Direccion = value; }
        }

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
        }

        public String DepartamentoCodigo
        {
            get { return c_DepartamentoCodigo; }
            set { c_DepartamentoCodigo = value; }
        }

        public String ProvinciaCodigo
        {
            get { return c_ProvinciaCodigo; }
            set { c_ProvinciaCodigo = value; }
        }

        public String DistritoCodigo
        {
            get { return c_DistritoCodigo; }
            set { c_DistritoCodigo = value; }
        }

        public String Mail
        {
            get { return c_Mail; }
            set { c_Mail = value; }
        }

        public String Nacionalidad
        {
            get { return c_Nacionalidad; }
            set { c_Nacionalidad = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return d_FechaNacimiento; }
            set { d_FechaNacimiento = value; }
        }

        public String Educacion
        {
            get { return c_Educacion; }
            set { c_Educacion = value; }
        }

        public String Sexo
        {
            get { return c_Sexo; }
            set { c_Sexo = value; }
        }

        public String Telefono
        {
            get { return c_Telefono; }
            set { c_Telefono = value; }
        }

        public String Fax
        {
            get { return c_Fax; }
            set { c_Fax = value; }
        }

        public String EstadoCivil
        {
            get { return c_EstadoCivil; }
            set { c_EstadoCivil = value; }
        }

        public String NombreEmergencia
        {
            get { return c_NombreEmergencia; }
            set { c_NombreEmergencia = value; }
        }

        public String TelefonoEmergencia
        {
            get { return c_TelefonoEmergencia; }
            set { c_TelefonoEmergencia = value; }
        }

        public String DireccionEmergencia
        {
            get { return c_DireccionEmergencia; }
            set { c_DireccionEmergencia = value; }
        }

        public String TipoCuenta
        {
            get { return c_TipoCuenta; }
            set { c_TipoCuenta = value; }
        }

        public String MonedaCuenta
        {
            get { return c_MonedaCuenta; }
            set { c_MonedaCuenta = value; }
        }

        public String BancoCuenta
        {
            get { return c_BancoCuenta; }
            set { c_BancoCuenta = value; }
        }

        public String NumeroCuenta
        {
            get { return c_NumeroCuenta; }
            set { c_NumeroCuenta = value; }
        }

        public Int32 CodigoAnterior
        {
            get { return n_CodigoAnterior; }
            set { n_CodigoAnterior = value; }
        }

        public String CodigoUsuario
        {
            get { return c_CodigoUsuario; }
            set { c_CodigoUsuario = value; }
        }

        public DateTime FechaUltimoIngreso
        {
            get { return d_FechaUltimoIngreso; }
            set { d_FechaUltimoIngreso = value; }
        }

        public String Raza
        {
            get { return c_Raza; }
            set { c_Raza = value; }
        }

        public String Religion
        {
            get { return c_Religion; }
            set { c_Religion = value; }
        }

        public String TipoTrabajador
        {
            get { return c_TipoTrabajador; }
            set { c_TipoTrabajador = value; }
        }

        public String TipoPension
        {
            get { return c_TipoPension; }
            set { c_TipoPension = value; }
        }

        public DateTime FechaInicioPension
        {
            get { return d_FechaInicioPension; }
            set { d_FechaInicioPension = value; }
        }

        public DateTime FechaFinPension
        {
            get { return d_FechaFinPension; }
            set { d_FechaFinPension = value; }
        }

        public String CodigoAfp
        {
            get { return c_CodigoAfp; }
            set { c_CodigoAfp = value; }
        }

        public String NumeroAfp
        {
            get { return c_NumeroAfp; }
            set { c_NumeroAfp = value; }
        }

        public String BancoCTS
        {
            get { return c_BancoCTS; }
            set { c_BancoCTS = value; }
        }

        public String MonedaCTS
        {
            get { return c_MonedaCTS; }
            set { c_MonedaCTS = value; }
        }

        public String CuentaCTS
        {
            get { return c_CuentaCTS; }
            set { c_CuentaCTS = value; }
        }

        public String DepartamentoCiaCodigo
        {
            get { return c_DepartamentoCiaCodigo; }
            set { c_DepartamentoCiaCodigo = value; }
        }

        public String Cargo
        {
            get { return c_Cargo; }
            set { c_Cargo = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public String TipoContrato
        {
            get { return c_TipoContrato; }
            set { c_TipoContrato = value; }
        }

        public String TipoPlanilla
        {
            get { return c_TipoPlanilla; }
            set { c_TipoPlanilla = value; }
        }

        public String TipoHorario
        {
            get { return c_TipoHorario; }
            set { c_TipoHorario = value; }
        }

        public String Celular
        {
            get { return c_Celular; }
            set { c_Celular = value; }
        }

        public String RutaFoto
        {
            get { return c_RutaFoto; }
            set { c_RutaFoto = value; }
        }

        public String SituacionEmpleado
        {
            get { return c_SituacionEmpleado; }
            set { c_SituacionEmpleado = value; }
        }

        public DateTime FechaUltimoCese
        {
            get { return d_FechaUltimoCese; }
            set { d_FechaUltimoCese = value; }
        }

        public Int32 Postulante
        {
            get { return n_Postulante; }
            set { n_Postulante = value; }
        }

        public Int32 Perfil
        {
            get { return n_Perfil; }
            set { n_Perfil = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public DateTime FechaRegistro
        {
            get { return d_FechaRegistro; }
            set { d_FechaRegistro = value; }
        }

        public String UsuarioRegistro
        {
            get { return c_UsuarioRegistro; }
            set { c_UsuarioRegistro = value; }
        }

        public String UltimoUsuario
        {
            get { return c_UltimoUsuario; }
            set { c_UltimoUsuario = value; }
        }

        public DateTime UltimaFechaModificacion
        {
            get { return d_UltimaFechaModificacion; }
            set { d_UltimaFechaModificacion = value; }
        }

        public String DocumentoMilitarFA
        {
            get { return c_DocumentoMilitarFA; }
            set { c_DocumentoMilitarFA = value; }
        }

        public String TipoCarnetAsistencia
        {
            get { return c_TipoCarnetAsistencia; }
            set { c_TipoCarnetAsistencia = value; }
        }

        public String CarnetAsistencia
        {
            get { return c_CarnetAsistencia; }
            set { c_CarnetAsistencia = value; }
        }

        public String ReferenciaDireccion
        {
            get { return c_ReferenciaDireccion; }
            set { c_ReferenciaDireccion = value; }
        }

        public String Grupo
        {
            get { return c_Grupo; }
            set { c_Grupo = value; }
        }

        public String NivelEducativo
        {
            get { return c_NivelEducativo; }
            set { c_NivelEducativo = value; }
        }

        public String Seguro
        {
            get { return c_Seguro; }
            set { c_Seguro = value; }
        }

        public String CentroFormacion
        {
            get { return c_CentroFormacion; }
            set { c_CentroFormacion = value; }
        }

        public String FlagMadreRF
        {
            get { return c_FlagMadreRF; }
            set { c_FlagMadreRF = value; }
        }

        public String FlagBeneficiarioCD
        {
            get { return c_FlagBeneficiarioCD; }
            set { c_FlagBeneficiarioCD = value; }
        }

        public String FotoCheck
        {
            get { return c_FotoCheck; }
            set { c_FotoCheck = value; }
        }

        public String UsuarioEvaluacion
        {
            get { return c_UsuarioEvaluacion; }
            set { c_UsuarioEvaluacion = value; }
        }

        public String FlagEssaludVida
        {
            get { return c_FlagEssaludVida; }
            set { c_FlagEssaludVida = value; }
        }

        public String CodigoVia
        {
            get { return c_CodigoVia; }
            set { c_CodigoVia = value; }
        }

        public String CodigoZona
        {
            get { return c_CodigoZona; }
            set { c_CodigoZona = value; }
        }

        public String FlagPensionista
        {
            get { return c_FlagPensionista; }
            set { c_FlagPensionista = value; }
        }

        public String Ocupacion
        {
            get { return c_Ocupacion; }
            set { c_Ocupacion = value; }
        }

        public String RegimenPensionario
        {
            get { return c_RegimenPensionario; }
            set { c_RegimenPensionario = value; }
        }

        public String SctrSalud
        {
            get { return c_SctrSalud; }
            set { c_SctrSalud = value; }
        }

        public String TipoModalidadFormativa
        {
            get { return c_TipoModalidadFormativa; }
            set { c_TipoModalidadFormativa = value; }
        }

        public String CodEstablecimiento
        {
            get { return c_CodEstablecimiento; }
            set { c_CodEstablecimiento = value; }
        }

        public String CategoriaEsp
        {
            get { return c_CategoriaEsp; }
            set { c_CategoriaEsp = value; }
        }

        public String ObsCts
        {
            get { return c_ObsCts; }
            set { c_ObsCts = value; }
        }

        public String ComisionVarMixta
        {
            get { return c_ComisionVarMixta; }
            set { c_ComisionVarMixta = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}