using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.General
{
    public class entTipoCambio : entBase
    {
        private String c_Estado = "A", c_UltimoUsuario;
        private Decimal n_ValorCompra, n_ValorVenta;
        private DateTime d_FechaCambio, d_UltimaFechaModificacion = DateTime.Now;
        private String c_UserNombreForm;

        public DateTime FechaCambio
        {
            get { return d_FechaCambio; }
            set { d_FechaCambio = value; }
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

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}