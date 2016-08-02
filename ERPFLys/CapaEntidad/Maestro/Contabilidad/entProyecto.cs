using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entProyecto : entBase
    {
        private String c_ProyectoCodigo, c_Compania, c_Descripcion, c_MonedaProyecto, c_EstadoAvance = "PR", c_Estado = "A", c_UltimoUsuario;
        private Decimal n_Presupuestado = 0;
        private DateTime d_FechaAprobacionProy, d_FechaValidaDesde, d_FechaValidaHasta, d_UltimaFechaModificacion = DateTime.Now;
        private String c_CompaniaNombre,c_UserNombreForm;

        public String ProyectoCodigo
        {
            get { return c_ProyectoCodigo; }
            set { c_ProyectoCodigo = value; }
        }

        public String Compania
        {
            get { return c_Compania; }
            set { c_Compania = value; }
        }

        public String Descripcion
        {
            get { return c_Descripcion; }
            set { c_Descripcion = value; }
        }

        public Decimal Presupuestado
        {
            get { return n_Presupuestado; }
            set { n_Presupuestado = value; }
        }

        public String MonedaProyecto
        {
            get { return c_MonedaProyecto; }
            set { c_MonedaProyecto = value; }
        }

        public DateTime FechaAprobacionProy
        {
            get { return d_FechaAprobacionProy; }
            set { d_FechaAprobacionProy = value; }
        }

        public DateTime FechaValidaDesde
        {
            get { return d_FechaValidaDesde; }
            set { d_FechaValidaDesde = value; }
        }

        public DateTime FechaValidaHasta
        {
            get { return d_FechaValidaHasta; }
            set { d_FechaValidaHasta = value; }
        }

        public String EstadoAvance
        {
            get { return c_EstadoAvance; }
            set { c_EstadoAvance = value; }
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