using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Model.Sistema
{
    public class entReporte
    {
        private String sParametro, sSubRpt;
        private Object sValue;
        private fnEnum.ParameterCRTipo sTipoParm = fnEnum.ParameterCRTipo.Campo;

        public String Parametro
        {
            get { return sParametro; }
            set { sParametro = value; }
        }

        public Object Value
        {
            get { return sValue; }
            set { sValue = value; }
        }

        public String SubReport
        {
            get { return sSubRpt; }
            set { sSubRpt = value; }
        }

        public fnEnum.ParameterCRTipo ParmTipo{
            get { return sTipoParm; }
            set { sTipoParm = value; }
        }

    }

}
