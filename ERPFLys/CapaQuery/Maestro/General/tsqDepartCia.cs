using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.General
{
    public class tsqDepartCia
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "UP_MANT_DEPARTAMENTO_CIA";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "UTP_MANT_DEPARTAMENTO_CIA";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "UTP_MANT_DEPARTAMENTO_CIA";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "UTP_MANT_DEPARTAMENTO_CIA";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:
                case fnEnum.OperacionMant.Modificar:
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "UTP_MANT_DEPARTAMENTO_CIA";
                    break;
            }
            return xsql;
        }
        
    }
}
