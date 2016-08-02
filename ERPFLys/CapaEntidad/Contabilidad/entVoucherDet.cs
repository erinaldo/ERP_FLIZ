using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Contabilidad
{
    public class entVoucherDet : entBase
    {
        private String c_Compania, c_Periodo, c_TipoVoucher, c_NumeroVoucher, c_Cuenta, c_CentroCosto, c_FlujoCaja, c_OrigenDoc = "MN";
        private String c_Documento, c_Proyecto, c_OrdenCompra, c_Descripcion, c_FlagAutomatico = "N", c_UltimoUsuarioMod, c_CodMaquina;
        private int n_Linea, n_Persona, n_Secuencia_OC;
        private Decimal n_CodigoDoc, n_MontoLocal = 0, n_MontoExt = 0;
        private DateTime d_Fecha, d_UltimaFechaMod;
        private String c_OCompraID, c_DescripcionCab;
        private DateTime d_FechaAprobacion;

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

        public Int32 Linea
        {
            get { return n_Linea; }
            set { n_Linea = value; }
        }

        public String Cuenta
        {
            get { return c_Cuenta; }
            set { c_Cuenta = value; }
        }

        public Int32 Persona
        {
            get { return n_Persona; }
            set { n_Persona = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public String FlujoCaja
        {
            get { return c_FlujoCaja; }
            set { c_FlujoCaja = value; }
        }

        public String OrigenDoc
        {
            get { return c_OrigenDoc; }
            set { c_OrigenDoc = value; }
        }

        public Decimal CodigoDoc
        {
            get { return n_CodigoDoc; }
            set { n_CodigoDoc = value; }
        }

        public String Documento
        {
            get { return c_Documento; }
            set { c_Documento = value; }
        }

        public DateTime Fecha
        {
            get { return d_Fecha; }
            set { d_Fecha = value; }
        }

        public String Proyecto
        {
            get { return c_Proyecto; }
            set { c_Proyecto = value; }
        }

        public String OrdenCompra
        {
            get { return c_OrdenCompra; }
            set { c_OrdenCompra = value; }
        }

        public Int32 Secuencia_OC
        {
            get { return n_Secuencia_OC; }
            set { n_Secuencia_OC = value; }
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

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String FlagAutomatico
        {
            get { return c_FlagAutomatico; }
            set { c_FlagAutomatico = value; }
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

        public String CodMaquina
        {
            get { return c_CodMaquina; }
            set { c_CodMaquina = value; }
        }

        public String OCompraID
        {
            get { return c_OCompraID; }
            set { c_OCompraID = value; }
        }

        public String DescripcionCab
        {
            get { return c_DescripcionCab; }
            set { c_DescripcionCab = value; }
        }

        public DateTime FechaAprobacion
        {
            get { return d_FechaAprobacion; }
            set { d_FechaAprobacion = value; }
        }

        public String IdVoucher
        {
            get { return c_TipoVoucher + "-" + c_NumeroVoucher; }
        }

    }
}