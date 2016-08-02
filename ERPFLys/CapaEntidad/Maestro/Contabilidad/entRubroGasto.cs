using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entRubroGasto : entBase
    {
        private String c_RubroGasto, c_Descripcion, C_UltimoUsuarioMod;
        private DateTime D_UltimaFechaMod;
        private String c_UserNombreForm;

        public String RubroGasto
        {
            get { return c_RubroGasto; }
            set { c_RubroGasto = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return C_UltimoUsuarioMod; }
            set { C_UltimoUsuarioMod = value; }
        }

        public DateTime UltimaFechaMod
        {
            get { return D_UltimaFechaMod; }
            set { D_UltimaFechaMod = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}