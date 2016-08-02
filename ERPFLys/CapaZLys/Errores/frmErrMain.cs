using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Errores
{
    public partial class frmErrMain : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {
        #region "==Propiedades=="

        private entErrores LstErr = new entErrores();

        public entErrores ListErrores
        {
            get { return LstErr; }
            set { LstErr = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmErrMain()
        {
            InitializeComponent();
        }

        private void frmErrMain_Shown(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarLista()
        {
            grControl.DataSource = LstErr.Errores;            
        }

        #endregion

    }
}
