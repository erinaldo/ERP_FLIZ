using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entCorrelativoVoucher : entBase
    {
        private String c_Compania, c_TipoVoucher, c_UltimoUsuarioMod, c_Periodo;
        private int n_Anio, n_Mes00 = 0, n_Mes01 = 0, n_Mes02 = 0, n_Mes03 = 0, n_Mes04 = 0, n_Mes05 = 0, n_Mes06 = 0;
        private int n_Mes07 = 0, n_Mes08 = 0, n_Mes09 = 0, n_Mes10 = 0, n_Mes11 = 0, n_Mes12 = 0, n_Mes13 = 0, n_Mes14 = 0, n_Correlativo = 0;
        private DateTime d_UltimaFechaMod = DateTime.Now;
        private String c_CompaniaNombre,c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public Int32 Anio
        {
            get { return n_Anio; }
            set { n_Anio = value; }
        }

        public String TipoVoucher
        {
            get { return c_TipoVoucher; }
            set { c_TipoVoucher = value; }
        }

        public Int32 Mes00
        {
            get { return n_Mes00; }
            set { n_Mes00 = value; }
        }

        public Int32 Mes01
        {
            get { return n_Mes01; }
            set { n_Mes01 = value; }
        }

        public Int32 Mes02
        {
            get { return n_Mes02; }
            set { n_Mes02 = value; }
        }

        public Int32 Mes03
        {
            get { return n_Mes03; }
            set { n_Mes03 = value; }
        }

        public Int32 Mes04
        {
            get { return n_Mes04; }
            set { n_Mes04 = value; }
        }

        public Int32 Mes05
        {
            get { return n_Mes05; }
            set { n_Mes05 = value; }
        }

        public Int32 Mes06
        {
            get { return n_Mes06; }
            set { n_Mes06 = value; }
        }

        public Int32 Mes07
        {
            get { return n_Mes07; }
            set { n_Mes07 = value; }
        }

        public Int32 Mes08
        {
            get { return n_Mes08; }
            set { n_Mes08 = value; }
        }

        public Int32 Mes09
        {
            get { return n_Mes09; }
            set { n_Mes09 = value; }
        }

        public Int32 Mes10
        {
            get { return n_Mes10; }
            set { n_Mes10 = value; }
        }

        public Int32 Mes11
        {
            get { return n_Mes11; }
            set { n_Mes11 = value; }
        }

        public Int32 Mes12
        {
            get { return n_Mes12; }
            set { n_Mes12 = value; }
        }

        public Int32 Mes13
        {
            get { return n_Mes13; }
            set { n_Mes13 = value; }
        }

        public Int32 Mes14
        {
            get { return n_Mes14; }
            set { n_Mes14 = value; }
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

        public String Periodo
        {
            get { return c_Periodo; }
            set { c_Periodo = value; }
        }

        public Int32 Correlativo
        {
            get { return n_Correlativo; }
            set { n_Correlativo = value; }
        }

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}