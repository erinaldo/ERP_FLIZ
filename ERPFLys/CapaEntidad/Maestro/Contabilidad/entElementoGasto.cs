using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entElementoGasto : entBase
    {
        private String c_Elemento, c_Grupo, c_Descripcion, c_Estado = "A", c_UsoSubCuenta, c_UltimoUsuarioMod;
        private DateTime d_UltimaFechaMod = DateTime.Now;
        private String c_GrupoNombre, c_UserNombreForm;

        public String Elemento
        {
            get { return c_Elemento; }
            set { c_Elemento = value; }
        }

        public String Grupo
        {
            get { return c_Grupo; }
            set { c_Grupo = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
        }

        public String UsoSubCuenta
        {
            get { return c_UsoSubCuenta; }
            set { c_UsoSubCuenta = value; }
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

        public String GrupoNombre
        {
            get { return c_GrupoNombre; }
            set { c_GrupoNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }
    }
}