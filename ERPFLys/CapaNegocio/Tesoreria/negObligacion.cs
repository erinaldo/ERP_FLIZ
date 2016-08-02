using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Repository.Tesoreria;
using FiltroLys.Domain.Funciones;
using System.Data;

namespace FiltroLys.Domain.Tesoreria
{
    public class negObligacion
    {
        public static List<entObligacion> ListObligacionToMantVoucherSearch(entObligacion oEnt)
        {
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.ListObligacionToMantVoucherSearch(oEnt).ToList<entObligacion>();
            return ListObj;
        }

        public static entObligacion GetObligacionXProvYDoc(entObligacion oEnt)
        {
            entObligacion EObj = new entObligacion();
            List<entObligacion> ListObj = new List<entObligacion>();
            ListObj = datObligacion.GetObligacionXProvYDoc(oEnt).ToList<entObligacion>();
            if (ListObj.Count > 0){
                EObj = ListObj[0]; EObj.ResultadoBusqueda = true;
            }
            ListObj = null;
            return EObj;
        }

        public static Decimal GetCodigoObligacion(entObligacion oEnt)
        {
            Decimal nCod = 0;
            entObligacion EObj = GetObligacionXProvYDoc(oEnt);
            if (EObj.ResultadoBusqueda) {
                nCod = EObj.Obligacion;
            }
            EObj = null;
            return nCod;
        }

    }
}
