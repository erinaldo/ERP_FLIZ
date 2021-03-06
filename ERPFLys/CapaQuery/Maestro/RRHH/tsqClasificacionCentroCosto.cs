﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.Query.Maestro.RRHH
{
    public class tsqClasificacionCentroCosto
    {
        static String xsql = "";

        public static String QR_ListaFormID()
        {
            xsql = "UP_MANT_CLASIFICACION_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_GetFormID()
        {
            xsql = "UP_MANT_CLASIFICACION_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_ListaCombo()
        {
            xsql = "UP_MANT_CLASIFICACION_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_ListaSearch()
        {
            xsql = "UP_MANT_CLASIFICACION_CENTRO_COSTO";
            return xsql;
        }

        public static String QR_MantFormID(fnEnum.OperacionMant Operacion)
        {
            switch (Operacion)
            {
                case fnEnum.OperacionMant.Insertar:    
                case fnEnum.OperacionMant.Modificar:                
                case fnEnum.OperacionMant.Eliminar:
                    xsql = "UP_MANT_CLASIFICACION_CENTRO_COSTO";
                    break;
            }
            return xsql;
        }
    }
}