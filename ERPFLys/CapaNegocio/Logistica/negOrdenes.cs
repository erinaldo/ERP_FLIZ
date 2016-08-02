using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Model.Logistica;
using FiltroLys.Repository.Logistica;
using FiltroLys.Domain.Funciones;
using System.Data;

namespace FiltroLys.Domain.Logistica
{
    public class negOrdenes
    {
        public static List<entOrdenes> ListOrdenesToMantVoucherSearch(String compania)
        {
            List<entOrdenes> ListObj = new List<entOrdenes>();
            ListObj = datOrdenes.ListOrdenesToMantVoucherSearch(compania).ToList<entOrdenes>();
            return ListObj;
        }

        public static List<entOrdenesDet> ListOrdenesDetToMantVoucherSearch(String compania, String Ordenes, int Ampliacion)
        {
            List<entOrdenesDet> ListObj = new List<entOrdenesDet>();
            ListObj = datOrdenes.ListOrdenesDetToMantVoucherSearch(compania, Ordenes, Ampliacion).ToList<entOrdenesDet>();
            return ListObj;
        }

    }
}
