using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entLineaProducto : entBase
    {
        private String c_Compania, c_LineaProducto, c_Descripcion, c_CuentaContable, c_TipoActivo, c_TipoBien;
        private String c_CtaDepreciacion, c_CtaDestinoDep, c_FlagModeloDep = "N", c_ModeloDep, c_UltimoUsuario;
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_TipoActivoNombre,c_CompaniaNombre,c_UserNombreForm;

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String LineaProducto
        {
            get { return c_LineaProducto; }
            set { c_LineaProducto = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public String CuentaContable
        {
            get { return c_CuentaContable; }
            set { c_CuentaContable = value; }
        }

        public String TipoActivo
        {
            get { return c_TipoActivo; }
            set { c_TipoActivo = value; }
        }

        public String TipoBien
        {
            get { return c_TipoBien; }
            set { c_TipoBien = value; }
        }

        public String CtaDepreciacion
        {
            get { return c_CtaDepreciacion; }
            set { c_CtaDepreciacion = value; }
        }

        public String CtaDestinoDep
        {
            get { return c_CtaDestinoDep; }
            set { c_CtaDestinoDep = value; }
        }

        public String FlagModeloDep
        {
            get { return c_FlagModeloDep; }
            set { c_FlagModeloDep = value; }
        }

        public String ModeloDep
        {
            get { return c_ModeloDep; }
            set { c_ModeloDep = value; }
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

        public String TipoActivoNombre
        {
            get { return c_TipoActivoNombre; }
            set { c_TipoActivoNombre = value; }
        }

        public String CompaniaNombre
        {
            get { return c_CompaniaNombre; }
            set { c_CompaniaNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }

    }
}