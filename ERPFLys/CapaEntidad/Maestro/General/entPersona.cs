using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entPersona : entBase
    {
        private String c_Compania, c_TipoPersona, c_ApellidosPaterno, c_ApellidosMaterno, c_Nombres, c_NombreCompleto, c_NombreBusqueda;
        private String c_TipoDocumentoPersona, c_Documento, c_DocumentoFiscal, c_DocumentoIdentidad, c_CarnetExtranjeria, c_Pasaporte;
        private String c_Procedencia, c_Direccion, c_Pais, c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_Mail, c_Nacionalidad;
        private String c_Educacion, c_Sexo, c_Telefono, c_Fax, c_EstadoCivil, c_NombreEmergencia, c_TelefonoEmergencia, c_DireccionEmergencia;
        private String c_TipoCuenta, c_MonedaCuenta, c_BancoCuenta, c_NumeroCuenta, c_EsEmpleado = "N", c_EsProveedor = "N", c_EsCliente = "N";
        private String c_EsOtro = "N", c_CodigoUsuario, c_TipoPersonaUsuario, c_Estado = "A", c_UsuarioRegistro, c_UltimoUsuario;
        private String c_DocumentoMilitarFA, c_CodigoVia, c_CodigoZona, c_FlagAgenteRet = "N", c_FlagBuenContrib = "N", c_FlagAgentePer = "N";
        private String c_FlagValidoRet = "N", c_UsuarioValidoRet, c_FlagTipoAmpRet = "A", c_FlagNoHabido = "N", c_FlagNoHallado = "N";
        private String c_UsuarioActNoHabido, c_UsuarioActNoHallado;
        private int n_Persona, n_PersonaAnterior;
        private DateTime d_FechaNacimiento, d_FechaRegistro = DateTime.Now, d_UltimaFechaModificacion = DateTime.Now, d_FechaValidoRet;
        private DateTime d_FechaNoHabido, d_FechaActNoHabido, d_FechaActNoHallado;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Int32 Persona
        {
            get { return n_Persona; }
            set { n_Persona = value; }
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

        public String EsEmpleado
        {
            get { return c_EsEmpleado; }
            set { c_EsEmpleado = value; }
        }

        public String EsProveedor
        {
            get { return c_EsProveedor; }
            set { c_EsProveedor = value; }
        }

        public String EsCliente
        {
            get { return c_EsCliente; }
            set { c_EsCliente = value; }
        }

        public String EsOtro
        {
            get { return c_EsOtro; }
            set { c_EsOtro = value; }
        }

        public Int32 PersonaAnterior
        {
            get { return n_PersonaAnterior; }
            set { n_PersonaAnterior = value; }
        }

        public String CodigoUsuario
        {
            get { return c_CodigoUsuario; }
            set { c_CodigoUsuario = value; }
        }

        public String TipoPersonaUsuario
        {
            get { return c_TipoPersonaUsuario; }
            set { c_TipoPersonaUsuario = value; }
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

        public String FlagAgenteRet
        {
            get { return c_FlagAgenteRet; }
            set { c_FlagAgenteRet = value; }
        }

        public String FlagBuenContrib
        {
            get { return c_FlagBuenContrib; }
            set { c_FlagBuenContrib = value; }
        }

        public String FlagAgentePer
        {
            get { return c_FlagAgentePer; }
            set { c_FlagAgentePer = value; }
        }

        public String FlagValidoRet
        {
            get { return c_FlagValidoRet; }
            set { c_FlagValidoRet = value; }
        }

        public String UsuarioValidoRet
        {
            get { return c_UsuarioValidoRet; }
            set { c_UsuarioValidoRet = value; }
        }

        public DateTime FechaValidoRet
        {
            get { return d_FechaValidoRet; }
            set { d_FechaValidoRet = value; }
        }

        public String FlagTipoAmpRet
        {
            get { return c_FlagTipoAmpRet; }
            set { c_FlagTipoAmpRet = value; }
        }

        public String FlagNoHabido
        {
            get { return c_FlagNoHabido; }
            set { c_FlagNoHabido = value; }
        }

        public String FlagNoHallado
        {
            get { return c_FlagNoHallado; }
            set { c_FlagNoHallado = value; }
        }

        public DateTime FechaNoHabido
        {
            get { return d_FechaNoHabido; }
            set { d_FechaNoHabido = value; }
        }

        public String UsuarioActNoHabido
        {
            get { return c_UsuarioActNoHabido; }
            set { c_UsuarioActNoHabido = value; }
        }

        public DateTime FechaActNoHabido
        {
            get { return d_FechaActNoHabido; }
            set { d_FechaActNoHabido = value; }
        }

        public String UsuarioActNoHallado
        {
            get { return c_UsuarioActNoHallado; }
            set { c_UsuarioActNoHallado = value; }
        }

        public DateTime FechaActNoHallado
        {
            get { return d_FechaActNoHallado; }
            set { d_FechaActNoHallado = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}