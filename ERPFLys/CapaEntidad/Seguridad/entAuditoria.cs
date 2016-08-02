using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Seguridad
{
    public class entAuditoria:entBase
    {
        private String c_Estacion, c_CodigoUsuario, c_UltimoUsuario, c_NombreUsuario, c_CentroCosto;
        private DateTime d_FechaPcIng, d_FechaPcSal,d_FechaServIng,d_FechaServSal,d_UltimaFechaModificacion;
        private DateTime d_FechaInicio, d_FechaTermino;

        public String Estacion
        {
            get { return c_Estacion; }
            set { c_Estacion = value; }
        }

        public String CodigoUsuario
        {
            get { return c_CodigoUsuario; }
            set { c_CodigoUsuario = value; }
        }

        public DateTime FechaPcIng
        {
            get { return d_FechaPcIng; }
            set { d_FechaPcIng = value; }
        }

        public DateTime FechaPcSal
        {
            get { return d_FechaPcSal; }
            set { d_FechaPcSal = value; }
        }

        public DateTime FechaServIng
        {
            get { return d_FechaServIng; }
            set { d_FechaServIng = value; }
        }

        public DateTime FechaServSal
        {
            get { return d_FechaServSal; }
            set { d_FechaServSal = value; }
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

        public String NombreUsuario
        {
            get { return c_NombreUsuario; }
            set { c_NombreUsuario = value; }
        }

        public String CentroCosto
        {
            get { return c_CentroCosto; }
            set { c_CentroCosto = value; }
        }

        public DateTime FechaInicio
        {
            get { return d_FechaInicio; }
            set { d_FechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return d_FechaTermino; }
            set { d_FechaTermino = value; }
        }

    }
}
