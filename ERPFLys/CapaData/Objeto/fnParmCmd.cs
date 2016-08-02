using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Repository.Objeto
{
    public class fnParmCmd
    {
        public static Object intDBNull(Int32 val, Int32 opc=System.Int32.MinValue) {
            return (val == Int32.MinValue || val == opc) ? (Object)DBNull.Value : val;
        }

        public static Object DecDBNull(Decimal val, Decimal opc = System.Decimal.MinValue)
        {
            return (val == Decimal.MinValue || val == opc) ? (Object)DBNull.Value : val;
        }

        public static Object StrDBNull(String val, String opc = fnConst.StrNull)
        {
            return (val == null || val.Equals(opc)) ? (Object)DBNull.Value : val;
        }

        public static Object DatDBNull(DateTime val)
        {
            return (val == DateTime.MinValue || val == null) ? (Object)DBNull.Value : val;
        }

    }
}
