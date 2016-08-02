using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Repository.Seguridad
{
    public class datEncriptar
    {
        public static String fnEncriptar(String valor) {
            int w_longitud, counter, w_Caracter, w_semilla;
            String w_cifrado = "";
            char c;

            w_longitud = valor.Trim().Length;
            for (counter = 1; counter <= w_longitud; counter++)
            {
                w_Caracter = (int)valor.Substring(counter - 1, 1).ToUpper().ToCharArray()[0];
                w_semilla = counter;
                w_Caracter = w_Caracter + w_semilla;
                c = (char)w_Caracter;
                w_cifrado = w_cifrado + c;
            }
            return w_cifrado.ToUpper();
        }
    }
}
