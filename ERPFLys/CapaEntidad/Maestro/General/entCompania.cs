using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entCompania : entBase
    {
        private String c_Compania, c_Nombres, c_NombreTelecredito, c_Estado = "A", c_UltimoUsuario, c_Telefono, c_Direccion;
        private String c_DocumentoFiscal, c_Pais, c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo, c_Fax;
        private String c_ActividadEconomica, c_CodigoSunat_Condicion, c_CodigoSunat_Via, c_CodigoSunat_Zona, c_CodigoSunat_TipoEstab;
        private String c_FlagEndoso = "N", c_CompaniaEndoso, c_SerieLetra, c_SectorCompania, c_Aplica_Ret = "N", c_MonedaMnt_Ret = "L";
        private String c_Serie_Ret, c_FlagReplica = "N", c_CompReplica, c_NameBd_o, c_NameBd_d, c_FlagCofilsa = "N";
        private String c_CompBaseComision, c_ValidaNoHabNoHall = "N";
        private int n_Codigo = 0, n_Limite_Ret = 0, n_Org_Hoshin;
        private Decimal n_MntLimite_Ret = 0, n_Porcent_Ret = 0, n_MontoMinSolesBack = 0;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_UltimoUsuarioModNombre = "";

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Nombres
        {
            get { return c_Nombres; }
            set { c_Nombres = value; }
        }

        public String NombreTelecredito
        {
            get { return c_NombreTelecredito; }
            set { c_NombreTelecredito = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
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

        public String Telefono
        {
            get { return c_Telefono; }
            set { c_Telefono = value; }
        }

        public String Direccion
        {
            get { return c_Direccion; }
            set { c_Direccion = value; }
        }

        public String DocumentoFiscal
        {
            get { return c_DocumentoFiscal; }
            set { c_DocumentoFiscal = value; }
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

        public String Fax
        {
            get { return c_Fax; }
            set { c_Fax = value; }
        }

        public String ActividadEconomica
        {
            get { return c_ActividadEconomica; }
            set { c_ActividadEconomica = value; }
        }

        public String CodigoSunat_Condicion
        {
            get { return c_CodigoSunat_Condicion; }
            set { c_CodigoSunat_Condicion = value; }
        }

        public String CodigoSunat_Via
        {
            get { return c_CodigoSunat_Via; }
            set { c_CodigoSunat_Via = value; }
        }

        public String CodigoSunat_Zona
        {
            get { return c_CodigoSunat_Zona; }
            set { c_CodigoSunat_Zona = value; }
        }

        public String CodigoSunat_TipoEstab
        {
            get { return c_CodigoSunat_TipoEstab; }
            set { c_CodigoSunat_TipoEstab = value; }
        }

        public String FlagEndoso
        {
            get { return c_FlagEndoso; }
            set { c_FlagEndoso = value; }
        }

        public String CompaniaEndoso
        {
            get { return c_CompaniaEndoso; }
            set { c_CompaniaEndoso = value; }
        }

        public String SerieLetra
        {
            get { return c_SerieLetra; }
            set { c_SerieLetra = value; }
        }

        public Int32 Codigo
        {
            get { return n_Codigo; }
            set { n_Codigo = value; }
        }

        public String SectorCompania
        {
            get { return c_SectorCompania; }
            set { c_SectorCompania = value; }
        }

        public String Aplica_Ret
        {
            get { return c_Aplica_Ret; }
            set { c_Aplica_Ret = value; }
        }

        public String MonedaMnt_Ret
        {
            get { return c_MonedaMnt_Ret; }
            set { c_MonedaMnt_Ret = value; }
        }

        public Decimal MntLimite_Ret
        {
            get { return n_MntLimite_Ret; }
            set { n_MntLimite_Ret = value; }
        }

        public Decimal Porcent_Ret
        {
            get { return n_Porcent_Ret; }
            set { n_Porcent_Ret = value; }
        }

        public String Serie_Ret
        {
            get { return c_Serie_Ret; }
            set { c_Serie_Ret = value; }
        }

        public Int32 Limite_Ret
        {
            get { return n_Limite_Ret; }
            set { n_Limite_Ret = value; }
        }

        public String FlagReplica
        {
            get { return c_FlagReplica; }
            set { c_FlagReplica = value; }
        }

        public String CompReplica
        {
            get { return c_CompReplica; }
            set { c_CompReplica = value; }
        }

        public String NameBd_o
        {
            get { return c_NameBd_o; }
            set { c_NameBd_o = value; }
        }

        public String NameBd_d
        {
            get { return c_NameBd_d; }
            set { c_NameBd_d = value; }
        }

        public String FlagCofilsa
        {
            get { return c_FlagCofilsa; }
            set { c_FlagCofilsa = value; }
        }

        public Int32 Org_Hoshin
        {
            get { return n_Org_Hoshin; }
            set { n_Org_Hoshin = value; }
        }

        public Decimal MontoMinSolesBack
        {
            get { return n_MontoMinSolesBack; }
            set { n_MontoMinSolesBack = value; }
        }

        public String CompBaseComision
        {
            get { return c_CompBaseComision; }
            set { c_CompBaseComision = value; }
        }

        public String ValidaNoHabNoHall
        {
            get { return c_ValidaNoHabNoHall; }
            set { c_ValidaNoHabNoHall = value; }
        }
        
        public String UltimoUsuarioModNombre
        {
            get { return c_UltimoUsuarioModNombre; }
            set { c_UltimoUsuarioModNombre = value; }
        }

    }
}