using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqCentroCosto
    {
        static String xsql = "";

        public static String QR_ListCentroCostoForm()
        {
            xsql = "UP_MANT_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_GetCentroCostoFormID()
        {
            xsql = "UP_MANT_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_ListaCentroCostoCombo()
        {
            xsql = "UP_MANT_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_ListCentroCostoSearch()
        {
            xsql = "UP_MANT_CENTRO_COSTO";
                   
            return xsql;
        }

        public static String QR_MantCentroCostoForm(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                    xsql = "UP_MANT_CENTRO_COSTO";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    xsql = "UP_MANT_CENTRO_COSTO";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "UP_MANT_CENTRO_COSTO";
                    break;
            }
            return xsql;
        }

    }
}
