using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace FiltroLys.ZLys.Controles.Formulario
{
    public partial class frmMant : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==Event Form=="

        public frmMant()
        {
            InitializeComponent();
        }

        private void frmMant_Activated(object sender, EventArgs e)
        {
            GlobalVar.formMDI.setVisibleX(true);
        }

        private void frmMant_Deactivate(object sender, EventArgs e)
        {
            GlobalVar.formMDI.setVisibleX(false);
        }

        #endregion

        public virtual void ue_nuevo() { }
        public virtual void ue_guardar() { }
        public virtual void ue_cancelar() {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
