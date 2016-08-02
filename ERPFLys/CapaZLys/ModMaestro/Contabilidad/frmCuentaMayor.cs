using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmCuentaMayor : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entCuentaMayor entMain = new entCuentaMayor();
        private String xOperacion = "";
        private String xCuentaMayor = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmCuentaMayor()
        {
            InitializeComponent();
        }

        private void frmCuentaMayor_Load(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelList){
                fxCargarComboListaDet();
                fxCargarLista();
            }

            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxSetearIni();
                fxQuitEvent();
                fxCargarCombos();
                fxCargarCombosDetalle();
                fxCargarCombosXCia();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmCuentaMayor_Shown(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxFocusInicial();
            }
        }

        #endregion

        #region "==FuncionesList=="

        private void fxCargarLista()
        {
            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)) { return; }
            List<entCuentaMayor> Lst = negCuentaMayor.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF1();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            
        }

        private void fxAddEvent() {
            
        }

        private void fxCargarCombos()
        {
            //Clasificacion
            List<entClasificacionMayor> LstA = negClasificacionMayor.ListaCombo(fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbClasificacion.Properties.DataSource = LstA;
            cmbClasificacion.Properties.DisplayMember = "Descripcion";
            cmbClasificacion.Properties.ValueMember = "Clasificacion";
            LstA = null;

            //TipoCuenta
            List<entTipoCuentaBalComp> LstB = negTipoCuentaBalComp.ListaCombo(fnConst.StringA, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbTipoCuenta.Properties.DataSource = LstB;
            cmbTipoCuenta.Properties.DisplayMember = "Descripcion";
            cmbTipoCuenta.Properties.ValueMember = "TipoCuenta";
            LstB = null;

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCuentaMayor = this.EstructuraForm.StrX[0];
            }
        }

        private void fxPreOpen()
        {
            String sTitle = "Actualizar";
            switch (xOperacion){
                case "A":
                    sTitle = " - Nuevo";
                    fxNuevoReg();
                    fxHabilitarOCX();
                    break;
                case "M":
                    sTitle = " - Modificar";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "V":
                    sTitle = " - Ver";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
            }
            this.Text = this.Text + sTitle;
            this.lblTitulo.Text = "CUENTA MAYOR";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbClasificacion.EditValue = fnConst.TextNingunoCod;
            cmbTipoCuenta.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbClasificacion.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCuentaMayor.GetFormID(xCuentaMayor);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCuentaMayor.Text = entMain.CuentaMayor.Trim();
                cmbClasificacion.EditValue = entMain.Clasificacion.Trim();
                cmbTipoCuenta.EditValue = entMain.TipoCuenta.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtDescripcionAnt.Text = (!String.IsNullOrEmpty(entMain.DescripcionAnt))? entMain.DescripcionAnt.Trim():String.Empty;
                cmbClasificacion.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCuentaMayor.ReadOnly = !sHabilitado;
            cmbClasificacion.ReadOnly = !sHabilitado;
            cmbTipoCuenta.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;
            txtDescripcionAnt.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtCuentaMayor.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCuentaMayor.Focus(); }
            if (xOperacion.Equals("M")) { cmbClasificacion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCtaMay = txtCuentaMayor.Text.ToString().Trim();
            String sClasif = cmbClasificacion.EditValue.ToString().Trim();
            String sTipoCta = cmbTipoCuenta.EditValue.ToString().Trim();
            String sDescripcion = txtDescripcion.Text.ToString().Trim();
            String sDescripcionAnt = txtDescripcionAnt.Text.ToString().Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            String sMay2 = (sCtaMay.Length == 3) ? sCtaMay.Substring(0, 2) : "";

            if (String.IsNullOrEmpty(sCtaMay)){
                fnMensaje.MensajeInfo("Ingresar la Cuenta Mayor. Revisar por favor.");
                txtCuentaMayor.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sClasif) || sClasif.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Seleccione la clasificación. Revisar por favor.");
                cmbClasificacion.Focus();
                return bOk;
            }

            if (!sMay2.Equals(sClasif)) {
                fnMensaje.MensajeInfo("Cta Mayor Ingresado no corresponde a Jerarquia de 2 Digitos. Revisar por favor.");
                cmbClasificacion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTipoCta) || sTipoCta.Equals(fnConst.TextNingunoCod)){
                fnMensaje.MensajeInfo("Seleccione el tipo de cuenta. Revisar por favor.");
                cmbTipoCuenta.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Ingrese la descripción. Revisar por favor.");
                txtDescripcion.Focus();
                return bOk;
            }
            
            //Actualizando Datos Entidad
            entMain.CuentaMayor = sCtaMay;
            entMain.Clasificacion = sClasif;
            entMain.TipoCuenta = sTipoCta;
            entMain.Descripcion = sDescripcion;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCuentaMayor = sCtaMay;

            bOk = true;
            return bOk;
        }

        private Boolean fxPreUpdate()
        {
            entErrores oErr = new entErrores();
            Boolean bOK = true;

            switch (xOperacion){
                case "A":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
                    break;
                case "M":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                    break;
            }

            oErr = negCuentaMayor.MantFormID(entMain);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
                bOK = false;
            }
            oErr = null;
            return bOK;
        }

        private void fxPostUpdate()
        {
            fxCargarLista();
        }

        #endregion

        #region "==EventInherit=="

        public override void ue_nuevo()
        {
            Contabilidad.frmCuentaMayor frm = new Contabilidad.frmCuentaMayor();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "A";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            frm = null;
        }

        public override void ue_modificar()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entCuentaMayor oEnt = (entCuentaMayor)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmCuentaMayor frm = new Contabilidad.frmCuentaMayor();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaMayor);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            oEnt = null;
            frm = null;
        }

        public override void ue_eliminar()
        {
            if (MessageBox.Show(fnConst.MensajeDeleteMaestro, fnConst.MessageTitleAviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entCuentaMayor oEnt = (entCuentaMayor)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCuentaMayor.MantFormID(oEnt);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
            }
            else { fxCargarLista(); }
            oErr = null;
            oEnt = null;
        }

        public override void ue_ver()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entCuentaMayor oEnt = (entCuentaMayor)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmCuentaMayor frm = new Contabilidad.frmCuentaMayor();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaMayor);
            frm.ShowDialog();
            oEnt = null;
            frm = null;
        }

        public override void ue_guardar()
        {
            if (!fxValidar()) { return; };
            if (!fxPreUpdate()) { return; };
            fxPostUpdate();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public override void ue_cancelar()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion
        
    }
}
