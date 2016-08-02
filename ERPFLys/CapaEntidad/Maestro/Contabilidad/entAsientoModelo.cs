using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entAsientoModelo : entBase
    {
        private String c_Compania, c_Modelo, c_Descripcion, c_Estado, c_UltimoUsuarioMod, c_Anual;
        private DateTime d_UltimaFechaMod;
        private String c_CiaNombre;
        private List<entAsientoModeloDet> xDetAsientoMod = new List<entAsientoModeloDet>();
        private String c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Modelo
        {
            get { return c_Modelo; }
            set { c_Modelo = value; }
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

        public String Anual
        {
            get { return c_Anual; }
            set { c_Anual = value; }
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

        public String CiaNombre
        {
            get { return c_CiaNombre; }
            set { c_CiaNombre = value; }
        }

        public List<entAsientoModeloDet> DetalleAsientoModelo
        {
            get { return xDetAsientoMod; }
            set { xDetAsientoMod = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}