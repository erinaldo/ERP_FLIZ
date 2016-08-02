using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Model
{
    public class entBase
    {
        private String c_usuarioSys;
        private DateTime d_fechaSys;
        private String c_accionSys;
        private fnEnum.RegExistente c_regexiste = fnEnum.RegExistente.Si;
        private fnEnum.OperacionMant c_opermant = fnEnum.OperacionMant.Ninguno;
        private fnEnum.RegVer c_ver = fnEnum.RegVer.Si;
        private fnEnum.RegEditado c_editado = fnEnum.RegEditado.No;
        private Boolean c_resultadoBusq = false;
        private Boolean bFooterList = false;
        private String c_opcion;

        public String UsuarioSys
        {
            get { return c_usuarioSys; }
            set { c_usuarioSys = value; }
        }

        public DateTime FechaSys
        {
            get { return d_fechaSys; }
            set { d_fechaSys = value; }
        }

        public String AccionSys
        {
            get { return c_accionSys; }
            set { c_accionSys = value; }
        }

        public fnEnum.RegExistente RegExistente
        {
            get { return c_regexiste; }
            set { c_regexiste = value; }
        }

        public fnEnum.OperacionMant OperMantenimiento {
            get { return c_opermant; }
            set { c_opermant = value; }
        }

        public fnEnum.RegVer RegVer {
            get { return c_ver; }
            set { c_ver = value; }
        }

        public fnEnum.RegEditado RegEditado
        {
            get { return c_editado; }
            set { c_editado = value; }
        }

        public Boolean ResultadoBusqueda {
            get { return c_resultadoBusq; }
            set { c_resultadoBusq = value; }
        }

        public Boolean FooterList
        {
            get { return bFooterList; }
            set { bFooterList = value; }
        }

        public String Opcion
        {
            get { return c_opcion; }
            set { c_opcion = value; }
        }
        
    }
}
