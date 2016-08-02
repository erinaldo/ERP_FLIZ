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
    public class negUsuario
    {
        public static List<entUsuario> ListUsuarioXEstCombo(String Estado, String opcCod = "", String opcNom = "")
        {
            List<entUsuario> ListObj = new List<entUsuario>();
            ListObj = datUsuario.ListUsuarioXEstCombo(Estado).ToList<entUsuario>();
            if (opcCod.Length > 0 || opcNom.Length > 0){
                ListObj.Insert(0, new entUsuario() { CodigoUsuario = opcCod, Nombre = opcNom });
            }
            return ListObj;
        }

    }
}
