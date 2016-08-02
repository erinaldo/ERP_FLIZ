using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FiltroLys.ZLys.Busqueda.General
{
    public partial class frmBusqMain : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {

        #region "==Propiedades=="

        private Boolean bSoloActivo = true;
        private Boolean bMultipleSelect = false;        

        public Boolean SoloActivo
        {
            get { return bSoloActivo; }
            set { bSoloActivo = value; }
        }

        public Boolean MultipleSelect
        {
            get { return bMultipleSelect; }
            set { bMultipleSelect = value; }
        }
               
        #endregion

        #region "==EventForm=="

        public frmBusqMain()
        {
            InitializeComponent();
        }

        #endregion

        #region "==EventObject=="

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gvDatos_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void gvDatos_LostFocus(object sender, EventArgs e)
        {
            this.AcceptButton = btnBuscar;
        }

        #endregion

    }
}
