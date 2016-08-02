using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Repository.Maestro.General;
using FiltroLys.Domain.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Domain.Maestro.General
{
    public class negTipoCambioPeriodo
    {
        public static List<entTipoCambioPeriodo> ListaFormID(String Sistema)
        {
            List<entTipoCambioPeriodo> ListObj = new List<entTipoCambioPeriodo>();
            ListObj = datTipoCambioPeriodo.ListaFormID(Sistema).ToList<entTipoCambioPeriodo>();
            return ListObj;
        }

        public static entTipoCambioPeriodo GetFormID(String Sistema, String Periodo)
        {
            entTipoCambioPeriodo EObj = new entTipoCambioPeriodo();
            List<entTipoCambioPeriodo> ListObj = new List<entTipoCambioPeriodo>();
            ListObj = datTipoCambioPeriodo.GetFormID(Sistema, Periodo).ToList<entTipoCambioPeriodo>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoCambioPeriodo> ListaCombo(String Sistema, String Estado, String[] Def = null)
        {
            List<entTipoCambioPeriodo> ListObj = new List<entTipoCambioPeriodo>();
            ListObj = datTipoCambioPeriodo.ListaCombo(Sistema,Estado).ToList<entTipoCambioPeriodo>();
            if (Def != null){
                ListObj.Insert(0, new entTipoCambioPeriodo() { Periodo = Def[0] });
            }
            return ListObj;
        }

        public static List<entTipoCambioPeriodo> ListaSearch(String Sistema, String Periodo, String Estado)
        {
            List<entTipoCambioPeriodo> ListObj = new List<entTipoCambioPeriodo>();
            ListObj = datTipoCambioPeriodo.ListaSearch(Sistema,Periodo, Estado).ToList<entTipoCambioPeriodo>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoCambioPeriodo Data)
        {
            return datTipoCambioPeriodo.MantFormID(Data);
        }

        public static Decimal GetTipoCambioXTipo(String Sistema, String Periodo, String Tipo){
            Decimal nTipoCambio = 0;
            entTipoCambioPeriodo oEnt = GetFormID(Sistema, Periodo);
            if(oEnt.Estado.Equals("A")){
                switch (Tipo) {
                    case "X":
                        nTipoCambio = oEnt.ValorCierre;
                        break;
                    case "V":
                        nTipoCambio = oEnt.ValorVenta;
                        break;
                    case "C":
                        nTipoCambio = oEnt.ValorCompra;
                        break;
                }
            }
            oEnt = null;
            return nTipoCambio;
        }

    }
}
