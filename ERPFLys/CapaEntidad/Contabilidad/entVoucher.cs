using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Contabilidad
{
    public class entVoucher : entBase
    {
        private String c_Compania, c_Periodo, c_TipoVoucher, c_NumeroVoucher, c_Departamento, c_Moneda;
        private String c_Descripcion,c_UsuarioRegistro,c_UsuarioAprobacion,c_Origen,c_FlagModManual="N";
        private String c_FlagModRestringida="N",c_Estado,c_UltimoUsuarioMod;
        private String c_DepartNombre;
        private DateTime d_Fecha,d_FechaRegistro,d_FechaAprobacion,d_UltimaFechaMod;
        private Decimal n_TipoCambio=0;
        private String c_NumeroManual="N",c_converAut="N";
        private Decimal n_MontoLocal = 0, n_MontoExt = 0;
        private List<entVoucherDet> x_DetVoucher = new List<entVoucherDet>();
        
        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Periodo
        {
            get { return c_Periodo; }
            set { c_Periodo = value; }
        }

        public String TipoVoucher
        {
            get { return c_TipoVoucher; }
            set { c_TipoVoucher = value; }
        }

        public String NumeroVoucher
        {
            get { return c_NumeroVoucher; }
            set { c_NumeroVoucher = value; }
        }

        public String Departamento
        {
            get { return c_Departamento; }
            set { c_Departamento = value; }
        }

        public String Moneda
        {
            get { return c_Moneda; }
            set { c_Moneda = value; }
        }

        public DateTime Fecha
        {
            get { return d_Fecha; }
            set { d_Fecha = value; }
        }

        public Decimal TipoCambio
        {
            get { return n_TipoCambio; }
            set { n_TipoCambio = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String UsuarioRegistro
        {
            get { return c_UsuarioRegistro; }
            set { c_UsuarioRegistro = value; }
        }

        public DateTime FechaRegistro
        {
            get { return d_FechaRegistro; }
            set { d_FechaRegistro = value; }
        }

        public String UsuarioAprobacion
        {
            get { return c_UsuarioAprobacion; }
            set { c_UsuarioAprobacion = value; }
        }

        public DateTime FechaAprobacion
        {
            get { return d_FechaAprobacion; }
            set { d_FechaAprobacion = value; }
        }

        public String Origen
        {
            get { return c_Origen; }
            set { c_Origen = value; }
        }

        public String FlagModManual
        {
            get { return c_FlagModManual; }
            set { c_FlagModManual = value; }
        }

        public String FlagModRestringida
        {
            get { return c_FlagModRestringida; }
            set { c_FlagModRestringida = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public String IdVoucher
        {
            get { return c_TipoVoucher + "-" + c_NumeroVoucher; }            
        }

        public String DepartNombre
        {
            get { return c_DepartNombre; }
            set { c_DepartNombre = value; }
        }

        public String NumeroManual
        {
            get { return c_NumeroManual; }
            set { c_NumeroManual = value; }
        }

        public String ConverAut
        {
            get { return c_converAut; }
            set { c_converAut = value; }
        }

        public Decimal MontoLocal
        {
            get { return n_MontoLocal; }
            set { n_MontoLocal = value; }
        }

        public Decimal MontoExt
        {
            get { return n_MontoExt; }
            set { n_MontoExt = value; }
        }

        public List<entVoucherDet> DetalleVoucher {
            get { return x_DetVoucher; }
            set { x_DetVoucher = value; }
        }

    }
}
