using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Contabilidad
{
    public class entCierreMesCuenta : entBase
    {
        private String c_Compania, c_Periodo, c_Cuenta, c_UltimoUsuarioMod;
        private Decimal n_SaldoInicialLocal = 0, n_SaldoInicialExt = 0, n_MovimientoLocal = 0, n_MovimientoExt = 0;
        private Decimal n_SaldoFinalLocal = 0, n_SaldoFinalExt = 0;   
        private DateTime d_UltimaFechaMod;
        private String c_Descripcion;
        private Decimal n_ImpLocal = 0, n_ImpExt = 0, n_SalLocal = 0, n_SalExt = 0;

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

        public String Cuenta
        {
            get { return c_Cuenta; }
            set { c_Cuenta = value; }
        }

        public Decimal SaldoInicialLocal
        {
            get { return n_SaldoInicialLocal; }
            set { n_SaldoInicialLocal = value; }
        }

        public Decimal SaldoInicialExt
        {
            get { return n_SaldoInicialExt; }
            set { n_SaldoInicialExt = value; }
        }

        public Decimal MovimientoLocal
        {
            get { return n_MovimientoLocal; }
            set { n_MovimientoLocal = value; }
        }

        public Decimal MovimientoExt
        {
            get { return n_MovimientoExt; }
            set { n_MovimientoExt = value; }
        }

        public Decimal SaldoFinalLocal
        {
            get { return n_SaldoFinalLocal; }
            set { n_SaldoFinalLocal = value; }
        }

        public Decimal SaldoFinalExt
        {
            get { return n_SaldoFinalExt; }
            set { n_SaldoFinalExt = value; }
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

        public Decimal ImpLocal
        {
            get { return n_ImpLocal; }
            set { n_ImpLocal = value; }
        }

        public Decimal ImpExt
        {
            get { return n_ImpExt; }
            set { n_ImpExt = value; }
        }

        public Decimal SalLocal
        {
            get { return n_SalLocal; }
            set { n_SalLocal = value; }
        }

        public Decimal SalExt
        {
            get { return n_SalExt; }
            set { n_SalExt = value; }
        }

        public Decimal SalLocalFin
        {
            get { return n_SalLocal + n_ImpLocal; }            
        }

        public Decimal SalExtFin
        {
            get { return n_SalExt + n_ImpExt; }            
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

    }
}