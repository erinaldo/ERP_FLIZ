using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entAcceso:entBase
    {
        private String c_Usuario, c_Aplicacion, c_Niveles;
        private String c_Acceso, c_Nuevo, c_Modificar, c_Eliminar, c_Otros;
        private String c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod;
        private Int32 n_OrdenPk;
        private String c_NombreFin, c_Icono, c_IdenNiv;

        public String Usuario
        {
            get { return c_Usuario; }
            set { c_Usuario = value; }
        }

        public String Aplicacion
        {
            get { return c_Aplicacion; }
            set { c_Aplicacion = value; }
        }

        public String Niveles
        {
            get { return c_Niveles; }
            set { c_Niveles = value; }
        }

        public String Acceso
        {
            get { return c_Acceso; }
            set { c_Acceso = value; }
        }

        public String Nuevo
        {
            get { return c_Nuevo; }
            set { c_Nuevo = value; }
        }

        public String Modificar
        {
            get { return c_Modificar; }
            set { c_Modificar = value; }
        }

        public String Eliminar
        {
            get { return c_Eliminar; }
            set { c_Eliminar = value; }
        }

        public String Otros
        {
            get { return c_Otros; }
            set { c_Otros = value; }
        }

        public String UltimoUsuarioMod
        {
            get { return c_UltimoUsuarioMod; }
            set { c_UltimoUsuarioMod = value; }
        }

        public DateTime UltimoFechaMod
        {
            get { return d_UltimaFechaMod; }
            set { d_UltimaFechaMod = value; }
        }

        public Int32 OrdenPk
        {
            get { return n_OrdenPk; }
            set { n_OrdenPk = value; }
        }

        public String NombreFin
        {
            get { return c_NombreFin; }
            set { c_NombreFin = value; }
        }

        public String Icono
        {
            get { return c_Icono; }
            set { c_Icono = value; }
        }

        public String IdenNiv
        {
            get { return c_IdenNiv; }
            set { c_IdenNiv = value; }
        }

    }
}
