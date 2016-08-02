using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entMenReporte : entBase
    {
        private String c_Aplicacion, c_Ventana, c_Descripcion, c_UltimoUsuario, c_NombreMenu, c_FormNet, c_Modulo = "--";
        private int n_Menu, n_Reporte;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_NombreModulo, c_NombreReporte, c_CodReporte;
        private String c_Nivel, c_CodReg, c_Padre;

        public String Aplicacion
        {
            get { return c_Aplicacion; }
            set { c_Aplicacion = value; }
        }

        public Int32 Menu
        {
            get { return n_Menu; }
            set { n_Menu = value; }
        }

        public Int32 Reporte
        {
            get { return n_Reporte; }
            set { n_Reporte = value; }
        }

        public String Ventana
        {
            get { return c_Ventana; }
            set { c_Ventana = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
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

        public String NombreMenu
        {
            get { return c_NombreMenu; }
            set { c_NombreMenu = value; }
        }

        public String FormNet
        {
            get { return c_FormNet; }
            set { c_FormNet = value; }
        }

        public String Modulo
        {
            get { return c_Modulo; }
            set { c_Modulo = value; }
        }

        public String NombreModulo
        {
            get { return c_NombreModulo; }
            set { c_NombreModulo = value; }
        }

        public String NombreReporte
        {
            get { return c_NombreReporte; }
            set { c_NombreReporte = value; }
        }

        public String CodReporte
        {
            get { return c_CodReporte; }
            set { c_CodReporte = value; }
        }

        public String Nivel
        {
            get { return c_Nivel; }
            set { c_Nivel = value; }
        }

        public String CodReg
        {
            get { return c_CodReg; }
            set { c_CodReg = value; }
        }

        public String Padre
        {
            get { return c_Padre; }
            set { c_Padre = value; }
        }

    }
}