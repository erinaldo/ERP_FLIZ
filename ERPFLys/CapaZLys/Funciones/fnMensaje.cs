using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Funciones
{
    public class fnMensaje
    {
        public static void MensajeInfo(String Mensaje){
            MessageBox.Show(Mensaje, fnConst.MessageTitleAviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
