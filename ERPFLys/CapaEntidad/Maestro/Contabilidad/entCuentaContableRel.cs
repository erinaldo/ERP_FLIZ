using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Maestro.Contabilidad
{
    public class entCuentaContableRel : entBase
    {
        private String c_CuentaAnt, c_CuentaNvo, c_CuentaDestinoDebe, c_CuentaDestinoHaber, c_UltimoUsuario, c_TieneDestino = "N";
        private DateTime d_UltimaFechaModificacion = DateTime.Now;
        private String c_CuentaAntNombre, c_CuentaNvoNombre, c_UserNombreForm;

        public String CuentaAnt
        {
            get { return c_CuentaAnt; }
            set { c_CuentaAnt = value; }
        }

        public String CuentaNvo
        {
            get { return c_CuentaNvo; }
            set { c_CuentaNvo = value; }
        }

        public String CuentaDestinoDebe
        {
            get { return c_CuentaDestinoDebe; }
            set { c_CuentaDestinoDebe = value; }
        }

        public String CuentaDestinoHaber
        {
            get { return c_CuentaDestinoHaber; }
            set { c_CuentaDestinoHaber = value; }
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

        public String TieneDestino
        {
            get { return c_TieneDestino; }
            set { c_TieneDestino = value; }
        }

        public String CuentaAntNombre
        {
            get { return c_CuentaAntNombre; }
            set { c_CuentaAntNombre = value; }
        }

        public String CuentaNvoNombre
        {
            get { return c_CuentaNvoNombre; }
            set { c_CuentaNvoNombre = value; }
        }

        public String UserNombreForm
        {
            get { return c_UserNombreForm; }
            set { c_UserNombreForm = value; }
        }
    }
}