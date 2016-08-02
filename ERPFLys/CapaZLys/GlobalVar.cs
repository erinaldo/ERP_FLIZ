using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.ZLys.Inicio;

namespace FiltroLys.ZLys
{
    public static class GlobalVar
    {
        private static String sUsu, sCia, sPc, SServ;
        private static DateTime dFechaIng;
        private static frmMdi frmMDI;
        private static String sDirReporte,sDirRegSunat,sDirDAOT;
        private static int CrZoomPaperLand = 1;
        private static int CrZoomPaperPort = 125;

        public static String UsuarioLogeo
        {
            get { return sUsu; }
            set { sUsu = value; }
        }

        public static String Compania
        {
            get { return sCia; }
            set { sCia = value; }
        }

        public static String Estacion
        {
            get { return sPc; }
            set { sPc = value; }
        }

        public static DateTime FechaIng
        {
            get { return dFechaIng; }
            set { dFechaIng = value; }
        }

        public static frmMdi formMDI
        {
            get { return frmMDI; }
            set { frmMDI = value; }
        }

        public static String DirReporte
        {
            get { return sDirReporte; }
            set { sDirReporte = value; }
        }

        public static String DirRegSunat
        {
            get { return sDirRegSunat; }
            set { sDirRegSunat = value; }
        }

        public static String DirDAOT
        {
            get { return sDirDAOT; }
            set { sDirDAOT = value; }
        }

        public static Int32 CrystalZoomLand {
            get { return CrZoomPaperLand; }
            set { CrZoomPaperLand = value; }
        }

        public static Int32 CrystalZoomPort
        {
            get { return CrZoomPaperPort; }
            set { CrZoomPaperPort = value; }
        }

        public static String Servidor
        {
            get { return SServ; }
            set { SServ = value; }
        }

    }
}
