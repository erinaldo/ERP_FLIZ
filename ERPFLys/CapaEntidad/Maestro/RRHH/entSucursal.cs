using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.RRHH
{
    public class entSucursal : entBase
    {
        private String c_Compania, c_Sucursal, c_Descripcion, c_Direccion, c_Estado = "A", c_UltimoUsuario, c_Pais;
        private String c_DepartamentoCodigo, c_ProvinciaCodigo, c_DistritoCodigo;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_DepartamentoNombre, c_ProvinciaNombre, c_DistritoNombre, c_UserNombreForm;
        
        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Sucursal
        {
            get { return c_Sucursal; }
            set { c_Sucursal = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String Direccion
        {
            get { return c_Direccion; }
            set { c_Direccion = value; }
        }

        public String Estado
        {
            get { return c_Estado; }
            set { c_Estado = value; }
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

        public String Pais
        {
            get { return c_Pais; }
            set { c_Pais = value; }
        }

        public String DepartamentoCodigo
        {
            get { return c_DepartamentoCodigo; }
            set { c_DepartamentoCodigo = value; }
        }

        public String ProvinciaCodigo
        {
            get { return c_ProvinciaCodigo; }
            set { c_ProvinciaCodigo = value; }
        }

        public String DistritoCodigo
        {
            get { return c_DistritoCodigo; }
            set { c_DistritoCodigo = value; }
        }

        public String DepartamentoNombre
        {
            get { return c_DepartamentoNombre; }
            set { c_DepartamentoNombre = value; }
        }

        public String ProvinciaNombre
        {
            get { return c_ProvinciaNombre; }
            set { c_ProvinciaNombre = value; }
        }

        public String DistritoNombre
        {
            get { return c_DistritoNombre; }
            set { c_DistritoNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}