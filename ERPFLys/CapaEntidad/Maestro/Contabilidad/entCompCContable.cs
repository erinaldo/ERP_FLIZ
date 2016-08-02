using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entCompCContable : entBase
    {
        private Int64 n_Linea = 0;
        private String c_Compania, c_Cuenta, c_Estado, c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Cuenta
        {
            get { return c_Cuenta; }
            set { c_Cuenta = value; }
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

        public Int64 Linea
        {
            get { return n_Linea; }
            set { n_Linea = value; }
        }

    }
}