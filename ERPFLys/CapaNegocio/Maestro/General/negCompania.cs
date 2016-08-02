using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;

namespace FiltroLys.Domain.Maestro.General
{
    public class negCompania
    {
        public static List<entCompania> ListCompaniaForm(String Compania, String Estado, String Nombre)
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListCompaniaForm(Compania, Estado, Nombre).ToList<entCompania>();
            return ListObj;
        }

        public static entCompania GetCompaniaFormID(String Compania)
        {
            entCompania EObj = new entCompania();
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.GetCompaniaFormID(Compania).ToList<entCompania>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entCompania> ListCiaComboXAppXUsu(String App, String Usuario, String SoloActivo, String opc = "")
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListCiaComboXAppXUsu(App,Usuario,SoloActivo).ToList<entCompania>();
            if(opc.Length>0){
                ListObj.Insert(0,new entCompania() { Compania = "", Nombres = opc });
            }
            return ListObj;
        }

        public static List<entCompania> ListCiaComboXEstado(String Estado, String OtroCod = fnConst.TextVacio, String OtroNom = fnConst.TextVacio)
        {
            List<entCompania> ListObj = new List<entCompania>();
            ListObj = datCompania.ListCompaniaForm(fnConst.StringT, Estado, fnConst.StringPorc).ToList<entCompania>();
            if (OtroCod.Length > 0){
                ListObj.Insert(0, new entCompania() { Compania = OtroCod, Nombres = OtroNom });
            }
            return ListObj;
        }

        public static String getNombreCia(String Compania){
            String sCiaNombre = "";
            entCompania oEnt = GetCompaniaFormID(Compania);
            if(oEnt.ResultadoBusqueda){
                sCiaNombre = oEnt.Nombres;
            }
            oEnt = null;
            return sCiaNombre;
        }

        public static String getDocFiscalCia(String Compania)
        {
            String sDocFiscal = "";
            entCompania oEnt = GetCompaniaFormID(Compania);
            if (oEnt.ResultadoBusqueda){
                sDocFiscal = oEnt.DocumentoFiscal;
            }
            oEnt = null;
            return sDocFiscal;
        }

        public static entErrores MantCompania(entCompania Data) {
            return datCompania.MantCompania(Data);
        }

    }
}
