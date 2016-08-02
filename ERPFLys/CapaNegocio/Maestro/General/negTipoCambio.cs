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
    public class negTipoCambio
    {
        public static List<entTipoCambio> ListaFormID()
        {
            List<entTipoCambio> ListObj = new List<entTipoCambio>();
            ListObj = datTipoCambio.ListaFormID().ToList<entTipoCambio>();
            return ListObj;
        }

        public static entTipoCambio GetFormID(DateTime FechaCambio)
        {
            entTipoCambio EObj = new entTipoCambio();
            List<entTipoCambio> ListObj = new List<entTipoCambio>();
            ListObj = datTipoCambio.GetFormID(FechaCambio).ToList<entTipoCambio>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static List<entTipoCambio> ListaCombo(String Estado, String[] Def = null)
        {
            List<entTipoCambio> ListObj = new List<entTipoCambio>();
            ListObj = datTipoCambio.ListaCombo(Estado).ToList<entTipoCambio>();
            if (Def != null){
                ListObj.Insert(0, new entTipoCambio() { FechaCambio = DateTime.MinValue });
            }
            return ListObj;
        }

        public static List<entTipoCambio> ListaSearch(DateTime FechaCambio, String Estado)
        {
            List<entTipoCambio> ListObj = new List<entTipoCambio>();
            ListObj = datTipoCambio.ListaSearch(FechaCambio, Estado).ToList<entTipoCambio>();
            return ListObj;
        }

        public static entErrores MantFormID(entTipoCambio Data)
        {
            return datTipoCambio.MantFormID(Data);
        }

        public static Decimal GetTipoCambioXTipo(DateTime Fecha, String Tipo) {
            Decimal nTipoCambio = 0;
            entTipoCambio oEnt = GetFormID(Fecha);
            if(oEnt.Estado.Equals("A")){
                switch (Tipo) { 
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
