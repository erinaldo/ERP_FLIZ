using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Repository.Seguridad;
using FiltroLys.Domain.Funciones;

namespace FiltroLys.Domain.Seguridad
{
    public class negSeguridad
    {
        public static int GetValidarAcceso(String Usuario,String Clave){
            return datSeguridad.GetValidarAcceso(Usuario, Clave);
        }

        public static List<entAcceso> ListAccesoUsuApp(String Usuario, String Aplicacion)
        {
            List<entAcceso> ListObj = datSeguridad.ListAccesoUsuApp(Usuario, Aplicacion).ToList<entAcceso>();
            return ListObj;
        }

        public static List<entAcceso> ListMenuMaestros(String Usuario)
        {
            List<entAcceso> ListObj = datSeguridad.ListMenuMaestros(Usuario).ToList<entAcceso>();
            return ListObj;
        }

        public static List<entMenReporte> ListMenuReportes(String Usuario)
        {
            List<entMenReporte> ListObj = datSeguridad.ListMenuReportes(Usuario).ToList<entMenReporte>();
            return ListObj;
        }

    }
}
