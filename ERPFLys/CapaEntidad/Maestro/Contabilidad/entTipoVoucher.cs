using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entTipoVoucher:entBase
    {
        private String c_TipoVoucher,c_Descripcion,c_CorrelativoManual="N",c_FlagSistema="N";
        private String c_Estado="A",c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm;

        public String TipoVoucher{
            get { return c_TipoVoucher; }
            set { c_TipoVoucher = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String CorrelativoManual
        {
            get { return c_CorrelativoManual; }
            set { c_CorrelativoManual = value; }
        }

        public String FlagSistema
        {
            get { return c_FlagSistema; }
            set { c_FlagSistema = value; }
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
