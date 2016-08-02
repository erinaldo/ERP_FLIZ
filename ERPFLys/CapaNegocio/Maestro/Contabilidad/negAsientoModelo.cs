using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Repository.Maestro.Contabilidad;
using FiltroLys.Domain.Funciones;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.Contabilidad
{
    public class negAsientoModelo
    {
        public static entAsientoModelo GetAsientoModeloFormID(String Compania,String Modelo)
        {
            entAsientoModelo EObj = new entAsientoModelo();
            EObj.Compania = Compania;
          //  EObj.AccionSys = "LST!";
           // eoj. omopcio n= "XID""
            EObj.Modelo = Modelo;
            EObj.Descripcion = fnConst.StringPorc;
            EObj.Estado = fnConst.StringPorc;
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListAsientoModelo(EObj).ToList<entAsientoModelo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static entAsientoModelo LISTCOMBO(String Compania,String Modelo,string ESTOAD)
        {
            entAsientoModelo EObj = new entAsientoModelo();
            EObj.Compania = Compania;
            EObj.AccionSys = "LST!";
            //eoj. omopcio n= "COMBOX""
            EObj.Modelo = Modelo;
            EObj.Descripcion = fnConst.StringPorc;
            EObj.Estado = fnConst.StringPorc;
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListAsientoModelo(EObj).ToList<entAsientoModelo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entAsientoModeloDet> GetAsientoModeloDetFormID(String Compania, String Modelo)
        {
            entAsientoModeloDet oEnt = new entAsientoModeloDet();
            oEnt.Compania = Compania;
            oEnt.Modelo = Modelo;
            oEnt.Descripcion = fnConst.StringPorc;
            List<entAsientoModeloDet> ListObj = new List<entAsientoModeloDet>();
            ListObj = datAsientoModelo.ListAsientoModeloDet(oEnt).ToList<entAsientoModeloDet>();
            oEnt = null;
            return ListObj;
        }

        public static List<entAsientoModelo> ListAsientoModeloForm()
        {
            entAsientoModelo oEnt = new entAsientoModelo();
            oEnt.Compania = fnConst.StringPorc;
            oEnt.Modelo = fnConst.StringPorc;
            oEnt.Descripcion = fnConst.StringPorc;
            oEnt.Estado = fnConst.StringPorc;
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListAsientoModelo(oEnt).ToList<entAsientoModelo>();
            oEnt = null;
            return ListObj;
        }

        public static List<entAsientoModelo> ListAsientoModeloSearch(String compania)
        {
            List<entAsientoModelo> ListObj = new List<entAsientoModelo>();
            ListObj = datAsientoModelo.ListAsientoModeloSearch(compania).ToList<entAsientoModelo>();
            return ListObj;
        }

        public static List<entAsientoModeloDet> ListAsientoModeloDetSearch(String compania, String modelo)
        {
            List<entAsientoModeloDet> ListObj = new List<entAsientoModeloDet>();
            ListObj = datAsientoModelo.ListAsientoModeloDetSearch(compania, modelo).ToList<entAsientoModeloDet>();
            return ListObj;
        }

        public static entErrores MantAsientoModelo(entAsientoModelo Data)
        {
            return datAsientoModelo.MantAsientoModelo(Data);
        }

    }
}
