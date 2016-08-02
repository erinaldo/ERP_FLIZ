using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltroLys.ZLys.Funciones
{
    public static class fnAddTab
    {
        public static void FormOpen(Form xFrm, String xEvento="",Boolean AbrirSi = false)
        {
            if(!AbrirSi){
                foreach (Form frm in GlobalVar.formMDI.MdiChildren)
                {
                    if (frm.GetType() == xFrm.GetType() && xEvento.Equals(frm.Tag)){
                        frm.Focus();
                        return;
                    }
                }
            }

            xFrm.MdiParent = GlobalVar.formMDI;
            xFrm.Tag = xEvento;
            xFrm.Show();            
        }

    }
}
