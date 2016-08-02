using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.Controles.Formulario
{
    public partial class frmResponse : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==Propiedades=="

        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmResponse()
        {
            InitializeComponent();
        }
        #endregion

    }
}
