using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Tesoreria
{
    public class entTipoServicio : entBase
    {
        private String c_TipoServicio, c_Descripcion, c_RegFiscal, c_Estado = "A", c_UltimoUsuarioMod, c_FlagNoDomic = "N";
        private String c_Flag4ta = "N", c_Flag4taPension = "N", c_Flag4taPensionAFE = "N", c_FlagValida4ta = "N", c_Flag2daCategoria = "N";
        private DateTime d_UltimaFechaMod;
        private String c_UserNombreForm; 

        public String TipoServicio
        {
            get { return c_TipoServicio; }
            set { c_TipoServicio = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String RegFiscal
        {
            get { return c_RegFiscal; }
            set { c_RegFiscal = value; }
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

        public String FlagNoDomic
        {
            get { return c_FlagNoDomic; }
            set { c_FlagNoDomic = value; }
        }

        public String Flag4ta
        {
            get { return c_Flag4ta; }
            set { c_Flag4ta = value; }
        }

        public String Flag4taPension
        {
            get { return c_Flag4taPension; }
            set { c_Flag4taPension = value; }
        }

        public String Flag4taPensionAFE
        {
            get { return c_Flag4taPensionAFE; }
            set { c_Flag4taPensionAFE = value; }
        }

        public String FlagValida4ta
        {
            get { return c_FlagValida4ta; }
            set { c_FlagValida4ta = value; }
        }

        public String Flag2daCategoria
        {
            get { return c_Flag2daCategoria; }
            set { c_Flag2daCategoria = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}