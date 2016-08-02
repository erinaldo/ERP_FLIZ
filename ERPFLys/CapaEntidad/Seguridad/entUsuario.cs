using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entUsuario : entBase
    {
        private String c_CodigoUsuario, c_Perfil, c_Nombre, c_Clave, c_Centrocosto, c_Supervisor = "N", c_EsCobranza = "N", c_EsVenta = "N", c_Consultor = "N", c_Sac = "N";
        private String c_ClaveCat = "N", c_Firma = "N", c_Serie, c_Correo, c_Estado = "A", c_UltimoUsuario, c_PedidoExterior = "N", c_PedidoNacional = "S";
        private String c_ImprimeTransaccion = "N", c_Logistica = "N", c_Cargo, c_FlagEvaluacion = "N", c_CompEvaluacion, c_FlagEvaluar = "N", c_FlagIngenieria = "N";
        private String c_FlagFirmaCarta = "N", c_NombreFirmaCarta, c_FlagVend_Rep = "N", c_TipoAccesoRepG = "N", c_FlagTodo_ReqP = "N", c_FlagTodo_CapP = "N";
        private String c_FlagModif_Eval = "N", c_Flag_TodasMarcaciones = "N", c_Flag_TodaProgVacacion = "N", c_Flag_DerivacionMC = "N", c_Flag_TodasSolicitudMtto = "N";
        private String c_Flag_Emp_Mtto = "N", c_FlagTranslado_Prod = "N", c_DocumentoIdentidad, c_Flag_AccesoProv = "T", c_Supervisor_Iso = "N", c_Conformidad_Doc = "N";
        private String c_Rd_Iso = "N", c_Ver_Todas_Area = "N", c_Flag_TodaAgenda = "N", c_AccesoRepComision = "NI", c_Flag_TodoMemo = "N", c_Anexo, c_Movil, c_Movil2;
        private String c_Flag_TodoVisita = "N", c_CompComision, c_Flag_TodoIndicador = "N", c_AccesoRepVenta = "NI";
        private int n_Persona, n_ParametroFormatoOrden, n_PersonaEntregaRendir, n_EmpComision;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;

        public String CodigoUsuario
        {
            get { return c_CodigoUsuario; }
            set { c_CodigoUsuario = value; }
        }

        public String Perfil
        {
            get { return c_Perfil; }
            set { c_Perfil = value; }
        }

        public Int32 Persona
        {
            get { return n_Persona; }
            set { n_Persona = value; }
        }

        public String Nombre
        {
            get { return c_Nombre; }
            set { c_Nombre = value; }
        }

        public String Clave
        {
            get { return c_Clave; }
            set { c_Clave = value; }
        }

        public String Centrocosto
        {
            get { return c_Centrocosto; }
            set { c_Centrocosto = value; }
        }

        public String Supervisor
        {
            get { return c_Supervisor; }
            set { c_Supervisor = value; }
        }

        public String EsCobranza
        {
            get { return c_EsCobranza; }
            set { c_EsCobranza = value; }
        }

        public String EsVenta
        {
            get { return c_EsVenta; }
            set { c_EsVenta = value; }
        }

        public String Consultor
        {
            get { return c_Consultor; }
            set { c_Consultor = value; }
        }

        public String Sac
        {
            get { return c_Sac; }
            set { c_Sac = value; }
        }

        public String ClaveCat
        {
            get { return c_ClaveCat; }
            set { c_ClaveCat = value; }
        }

        public String Firma
        {
            get { return c_Firma; }
            set { c_Firma = value; }
        }

        public String Serie
        {
            get { return c_Serie; }
            set { c_Serie = value; }
        }

        public String Correo
        {
            get { return c_Correo; }
            set { c_Correo = value; }
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

        public String PedidoExterior
        {
            get { return c_PedidoExterior; }
            set { c_PedidoExterior = value; }
        }

        public String PedidoNacional
        {
            get { return c_PedidoNacional; }
            set { c_PedidoNacional = value; }
        }

        public String ImprimeTransaccion
        {
            get { return c_ImprimeTransaccion; }
            set { c_ImprimeTransaccion = value; }
        }

        public String Logistica
        {
            get { return c_Logistica; }
            set { c_Logistica = value; }
        }

        public String Cargo
        {
            get { return c_Cargo; }
            set { c_Cargo = value; }
        }

        public Int32 ParametroFormatoOrden
        {
            get { return n_ParametroFormatoOrden; }
            set { n_ParametroFormatoOrden = value; }
        }

        public String FlagEvaluacion
        {
            get { return c_FlagEvaluacion; }
            set { c_FlagEvaluacion = value; }
        }

        public String CompEvaluacion
        {
            get { return c_CompEvaluacion; }
            set { c_CompEvaluacion = value; }
        }

        public String FlagEvaluar
        {
            get { return c_FlagEvaluar; }
            set { c_FlagEvaluar = value; }
        }

        public String FlagIngenieria
        {
            get { return c_FlagIngenieria; }
            set { c_FlagIngenieria = value; }
        }

        public String FlagFirmaCarta
        {
            get { return c_FlagFirmaCarta; }
            set { c_FlagFirmaCarta = value; }
        }

        public String NombreFirmaCarta
        {
            get { return c_NombreFirmaCarta; }
            set { c_NombreFirmaCarta = value; }
        }

        public Int32 PersonaEntregaRendir
        {
            get { return n_PersonaEntregaRendir; }
            set { n_PersonaEntregaRendir = value; }
        }

        public String FlagVend_Rep
        {
            get { return c_FlagVend_Rep; }
            set { c_FlagVend_Rep = value; }
        }

        public String TipoAccesoRepG
        {
            get { return c_TipoAccesoRepG; }
            set { c_TipoAccesoRepG = value; }
        }

        public String FlagTodo_ReqP
        {
            get { return c_FlagTodo_ReqP; }
            set { c_FlagTodo_ReqP = value; }
        }

        public String FlagTodo_CapP
        {
            get { return c_FlagTodo_CapP; }
            set { c_FlagTodo_CapP = value; }
        }

        public String FlagModif_Eval
        {
            get { return c_FlagModif_Eval; }
            set { c_FlagModif_Eval = value; }
        }

        public String Flag_TodasMarcaciones
        {
            get { return c_Flag_TodasMarcaciones; }
            set { c_Flag_TodasMarcaciones = value; }
        }

        public String Flag_TodaProgVacacion
        {
            get { return c_Flag_TodaProgVacacion; }
            set { c_Flag_TodaProgVacacion = value; }
        }

        public String Flag_DerivacionMC
        {
            get { return c_Flag_DerivacionMC; }
            set { c_Flag_DerivacionMC = value; }
        }

        public String Flag_TodasSolicitudMtto
        {
            get { return c_Flag_TodasSolicitudMtto; }
            set { c_Flag_TodasSolicitudMtto = value; }
        }

        public String Flag_Emp_Mtto
        {
            get { return c_Flag_Emp_Mtto; }
            set { c_Flag_Emp_Mtto = value; }
        }

        public String FlagTranslado_Prod
        {
            get { return c_FlagTranslado_Prod; }
            set { c_FlagTranslado_Prod = value; }
        }

        public String DocumentoIdentidad
        {
            get { return c_DocumentoIdentidad; }
            set { c_DocumentoIdentidad = value; }
        }

        public String Flag_AccesoProv
        {
            get { return c_Flag_AccesoProv; }
            set { c_Flag_AccesoProv = value; }
        }

        public String Supervisor_Iso
        {
            get { return c_Supervisor_Iso; }
            set { c_Supervisor_Iso = value; }
        }

        public String Conformidad_Doc
        {
            get { return c_Conformidad_Doc; }
            set { c_Conformidad_Doc = value; }
        }

        public String Rd_Iso
        {
            get { return c_Rd_Iso; }
            set { c_Rd_Iso = value; }
        }

        public String Ver_Todas_Area
        {
            get { return c_Ver_Todas_Area; }
            set { c_Ver_Todas_Area = value; }
        }

        public String Flag_TodaAgenda
        {
            get { return c_Flag_TodaAgenda; }
            set { c_Flag_TodaAgenda = value; }
        }

        public String AccesoRepComision
        {
            get { return c_AccesoRepComision; }
            set { c_AccesoRepComision = value; }
        }

        public String Flag_TodoMemo
        {
            get { return c_Flag_TodoMemo; }
            set { c_Flag_TodoMemo = value; }
        }

        public String Anexo
        {
            get { return c_Anexo; }
            set { c_Anexo = value; }
        }

        public String Movil
        {
            get { return c_Movil; }
            set { c_Movil = value; }
        }

        public String Movil2
        {
            get { return c_Movil2; }
            set { c_Movil2 = value; }
        }

        public String Flag_TodoVisita
        {
            get { return c_Flag_TodoVisita; }
            set { c_Flag_TodoVisita = value; }
        }

        public String CompComision
        {
            get { return c_CompComision; }
            set { c_CompComision = value; }
        }

        public Int32 EmpComision
        {
            get { return n_EmpComision; }
            set { n_EmpComision = value; }
        }

        public String Flag_TodoIndicador
        {
            get { return c_Flag_TodoIndicador; }
            set { c_Flag_TodoIndicador = value; }
        }

        public String AccesoRepVenta
        {
            get { return c_AccesoRepVenta; }
            set { c_AccesoRepVenta = value; }
        }

    }
}