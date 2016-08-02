using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Logistica
{
    public class entOrdenesDet : entBase
    {
        private String c_Compania, c_NumeroOrden, c_Item, c_CommodityCodigo, c_UnidadCodigo, c_Descripcion, c_OtrosDatos, c_Terminado = "N";
        private String c_Estado, c_CentroCosto, c_UltimoUsuario, c_PartidaCodigo, c_UsuarioAprobacionDesv, c_PermisoDesviacion = "N";
        private String c_PermisoAprobado = "N", c_ObservacionesPermiso, c_ObservacionesAprobacionP, c_UsuarioPermiso, c_FlagCambioPrecio = "N";
        private String c_MotivoCambio, c_UsuarioCambio, c_FlagSaldoNoPendiente = "N", c_ObsSaldoNoPendiente, c_UsuarioSaldoNoPendiente;
        private String c_Procedencia, c_Garantias, c_UsuarioCierre, c_TipoCierre, c_MotivoCierre, c_Muestra = "N", c_LoteMuestra;
        private String c_UsuarioSaldoNp_Rev, c_ObsSaldoNp_Rev;
        private int n_Ampliacion, n_Secuencia, n_Embarque;
        private Decimal n_CantidadPedida = 0, n_CantidadRecibida = 0, n_PrecioUnitario = 0, n_PrecioAnterior, n_PrecioImp_Ant = 0;
        private DateTime d_FechaEntrega, d_FechaEntregaReal, d_UltimaFechaModificacion = DateTime.Now, d_FechaAprobacionDesv;
        private DateTime d_FechaModificacion, d_FechaSaldoNoPendiente, d_FechaCierre, d_FechaSaldoNp_Rev;
        private Decimal n_MontoTotal;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String NumeroOrden
        {
            get { return c_NumeroOrden; }
            set { c_NumeroOrden = value; }
        }

        public Int32 Ampliacion
        {
            get { return n_Ampliacion; }
            set { n_Ampliacion = value; }
        }

        public Int32 Secuencia
        {
            get { return n_Secuencia; }
            set { n_Secuencia = value; }
        }

        public String Item
        {
            get { return c_Item; }
            set { c_Item = value; }
        }

        public String CommodityCodigo
        {
            get { return c_CommodityCodigo; }
            set { c_CommodityCodigo = value; }
        }

        public String UnidadCodigo
        {
            get { return c_UnidadCodigo; }
            set { c_UnidadCodigo = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String OtrosDatos
        {
            get { return c_OtrosDatos; }
            set { c_OtrosDatos = value; }
        }

        public Decimal CantidadPedida
        {
            get { return n_CantidadPedida; }
            set { n_CantidadPedida = value; }
        }

        public Decimal CantidadRecibida
        {
            get { return n_CantidadRecibida; }
            set { n_CantidadRecibida = value; }
        }

        public Decimal PrecioUnitario
        {
            get { return n_PrecioUnitario; }
            set { n_PrecioUnitario = value; }
        }

        public DateTime FechaEntrega
        {
            get { return d_FechaEntrega; }
            set { d_FechaEntrega = value; }
        }

        public DateTime FechaEntregaReal
        {
            get { return d_FechaEntregaReal; }
            set { d_FechaEntregaReal = value; }
        }

        public String Terminado
        {
            get { return c_Terminado; }
            set { c_Terminado = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
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

        public String PartidaCodigo
        {
            get { return c_PartidaCodigo; }
            set { c_PartidaCodigo = value; }
        }

        public String UsuarioAprobacionDesv
        {
            get { return c_UsuarioAprobacionDesv; }
            set { c_UsuarioAprobacionDesv = value; }
        }

        public DateTime FechaAprobacionDesv
        {
            get { return d_FechaAprobacionDesv; }
            set { d_FechaAprobacionDesv = value; }
        }

        public String PermisoDesviacion
        {
            get { return c_PermisoDesviacion; }
            set { c_PermisoDesviacion = value; }
        }

        public String PermisoAprobado
        {
            get { return c_PermisoAprobado; }
            set { c_PermisoAprobado = value; }
        }

        public String ObservacionesPermiso
        {
            get { return c_ObservacionesPermiso; }
            set { c_ObservacionesPermiso = value; }
        }

        public String ObservacionesAprobacionP
        {
            get { return c_ObservacionesAprobacionP; }
            set { c_ObservacionesAprobacionP = value; }
        }

        public String UsuarioPermiso
        {
            get { return c_UsuarioPermiso; }
            set { c_UsuarioPermiso = value; }
        }

        public String FlagCambioPrecio
        {
            get { return c_FlagCambioPrecio; }
            set { c_FlagCambioPrecio = value; }
        }

        public Decimal PrecioAnterior
        {
            get { return n_PrecioAnterior; }
            set { n_PrecioAnterior = value; }
        }

        public String MotivoCambio
        {
            get { return c_MotivoCambio; }
            set { c_MotivoCambio = value; }
        }

        public String UsuarioCambio
        {
            get { return c_UsuarioCambio; }
            set { c_UsuarioCambio = value; }
        }

        public DateTime FechaModificacion
        {
            get { return d_FechaModificacion; }
            set { d_FechaModificacion = value; }
        }

        public Int32 Embarque
        {
            get { return n_Embarque; }
            set { n_Embarque = value; }
        }

        public String FlagSaldoNoPendiente
        {
            get { return c_FlagSaldoNoPendiente; }
            set { c_FlagSaldoNoPendiente = value; }
        }

        public String ObsSaldoNoPendiente
        {
            get { return c_ObsSaldoNoPendiente; }
            set { c_ObsSaldoNoPendiente = value; }
        }

        public String UsuarioSaldoNoPendiente
        {
            get { return c_UsuarioSaldoNoPendiente; }
            set { c_UsuarioSaldoNoPendiente = value; }
        }

        public DateTime FechaSaldoNoPendiente
        {
            get { return d_FechaSaldoNoPendiente; }
            set { d_FechaSaldoNoPendiente = value; }
        }

        public Decimal PrecioImp_Ant
        {
            get { return n_PrecioImp_Ant; }
            set { n_PrecioImp_Ant = value; }
        }

        public String Procedencia
        {
            get { return c_Procedencia; }
            set { c_Procedencia = value; }
        }

        public String Garantias
        {
            get { return c_Garantias; }
            set { c_Garantias = value; }
        }

        public String UsuarioCierre
        {
            get { return c_UsuarioCierre; }
            set { c_UsuarioCierre = value; }
        }

        public String TipoCierre
        {
            get { return c_TipoCierre; }
            set { c_TipoCierre = value; }
        }

        public String MotivoCierre
        {
            get { return c_MotivoCierre; }
            set { c_MotivoCierre = value; }
        }

        public DateTime FechaCierre
        {
            get { return d_FechaCierre; }
            set { d_FechaCierre = value; }
        }

        public String Muestra
        {
            get { return c_Muestra; }
            set { c_Muestra = value; }
        }

        public String LoteMuestra
        {
            get { return c_LoteMuestra; }
            set { c_LoteMuestra = value; }
        }

        public String UsuarioSaldoNp_Rev
        {
            get { return c_UsuarioSaldoNp_Rev; }
            set { c_UsuarioSaldoNp_Rev = value; }
        }

        public DateTime FechaSaldoNp_Rev
        {
            get { return d_FechaSaldoNp_Rev; }
            set { d_FechaSaldoNp_Rev = value; }
        }

        public String ObsSaldoNp_Rev
        {
            get { return c_ObsSaldoNp_Rev; }
            set { c_ObsSaldoNp_Rev = value; }
        }

        public Decimal MontoTotal
        {
            get { return n_MontoTotal; }
            set { n_MontoTotal = value; }
        }

    }
}