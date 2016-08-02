using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Seguridad;
using FiltroLys.Repository.Seguridad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Seguridad
{
    public class negAuditoria
    {
        public static List<entAuditoria> ListAuditoria(entAuditoria Data)
        {
            List<entAuditoria> ListObj = datAuditoria.ListAuditoria(Data).ToList<entAuditoria>();
            return ListObj;            
        }

        public static DateTime GetFechaServidor(){
            return datAuditoria.GetFechaServidor();
        }

        public static entErrores MantAuditoria(fnEnum.OperacionMant Operacion, entAuditoria Data) {
            return datAuditoria.MantAuditoria(Operacion, Data);
        }

    }
}
