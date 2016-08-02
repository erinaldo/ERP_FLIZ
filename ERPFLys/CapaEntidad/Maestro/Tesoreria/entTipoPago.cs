using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Tesoreria
{
    public class entTipoPago : entBase
    {
        private String c_TipoPago, c_Descripcion, c_FlagGenCorrel = "S", c_FlagSistema = "N", c_FlagGenAutPago = "N";
        private String c_Estado = "A", c_UltimoUsuarioMod, c_CodigoSunat, c_CodigoSunatFP;
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm;

        public String TipoPago
        {
            get { return c_TipoPago; }
            set { c_TipoPago = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String FlagGenCorrel
        {
            get { return c_FlagGenCorrel; }
            set { c_FlagGenCorrel = value; }
        }

        public String FlagSistema
        {
            get { return c_FlagSistema; }
            set { c_FlagSistema = value; }
        }

        public String FlagGenAutPago
        {
            get { return c_FlagGenAutPago; }
            set { c_FlagGenAutPago = value; }
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

        public String CodigoSunat
        {
            get { return c_CodigoSunat; }
            set { c_CodigoSunat = value; }
        }

        public String CodigoSunatFP
        {
            get { return c_CodigoSunatFP; }
            set { c_CodigoSunatFP = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}