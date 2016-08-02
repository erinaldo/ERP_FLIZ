using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Repository.Objeto
{
    public class fnGetOpera
    {
        public static String getOperacion(fnEnum.OperacionMant oAcc = fnEnum.OperacionMant.Ninguno)
        {
            String sAcc = "";
            switch (oAcc)
            {
                case fnEnum.OperacionMant.Insertar:
                    sAcc = "INS";
                    break;
                case fnEnum.OperacionMant.Modificar:
                    sAcc = "UPD";
                    break;
                case fnEnum.OperacionMant.Eliminar:
                case fnEnum.OperacionMant.EliminarTodos:
                    sAcc = "DEL";
                    break;
            }
            return sAcc;
        }
    }
}
