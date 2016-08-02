using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entTipoCambioPeriodo : entBase
    {
        private String c_Sistema,c_Periodo,c_Estado = "A", c_UltimoUsuarioMod;
        private Decimal n_ValorCierre,n_ValorCompra, n_ValorVenta;
        private DateTime d_FechaCambio, d_UltimaFechaMod = DateTime.Now;
        private String c_UserNombreForm;

        public String Sistema
        {
            get { return c_Sistema; }
            set { c_Sistema = value; }
        }

        public String Periodo
        {
            get { return c_Periodo; }
            set { c_Periodo = value; }
        }

        public Decimal ValorCierre
        {
            get { return n_ValorCierre; }
            set { n_ValorCierre = value; }
        }

        public Decimal ValorCompra
        {
            get { return n_ValorCompra; }
            set { n_ValorCompra = value; }
        }

        public Decimal ValorVenta
        {
            get { return n_ValorVenta; }
            set { n_ValorVenta = value; }
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

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}