using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using System.Linq;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmSelPeriodoTrabajo : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {

        #region "==EventForm=="

        public frmSelPeriodoTrabajo()
        {
            InitializeComponent();
        }

        private void frmSelPeriodoTrabajo_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
        }

        private void frmSelPeriodoTrabajo_Shown(object sender, EventArgs e)
        {
            fxSetearDatos();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXAppXUsu(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringN, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxSetearDatos()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : "";
            txtPeriodo.Text = negPeriodoCia.GetPerTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
            txtPeriodo.Focus();
        } 

        #endregion

        #region "==EventObject=="

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Replace("-", "");
            Int32 nResult = 0;

            //Validación Basica
            if (String.IsNullOrEmpty(sCia)){
                fnMensaje.MensajeInfo("Debe seleccionar una compañía.");
                return;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return;
            }

            nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, sCia, sPer);
            if (nResult <= 0){
                fnMensaje.MensajeInfo("Periodo no existe o se encuentra cerrado. No se puede asignar periodo de trabajo.");
                return;
            }

            nResult = negCierreMesCuenta.SetPeriodoTrabajo(sCia, sPer);
            switch (nResult){
                case 1:
                    fnMensaje.MensajeInfo("Asignación de periodo de trabajo fue exitoso.");
                    this.Close();
                    break;
                case 0:
                    fnMensaje.MensajeInfo("Periodo de trabajo no existe o se encuentra cerrado.");
                    break;
                case -1:
                    fnMensaje.MensajeInfo("Ocurrio un error actualizando periodo de trabajo.");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
