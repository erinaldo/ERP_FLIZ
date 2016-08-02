using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Busqueda.General;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmRelCtaGenEmp : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {

        #region "==Propiedades=="
        
        private entCuentaContableRel entMain = new entCuentaContableRel();
        private String xOperacion = "";
        private String xCuentaAnt = "", xCuentaNvo = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmRelCtaGenEmp()
        {
            InitializeComponent();
        }

        private void frmRelCtaGenEmp_Load(object sender, EventArgs e)
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

        private void frmRelCtaGenEmp_Shown(object sender, EventArgs e)
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
            List<entCuentaContableRel> Lst = negCuentaContableRel.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {   
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            
        }

        private void fxAddEvent() {
            
        }

        private void fxCargarCombos()
        {            
            //Estado
            cmbTieneDestino.Properties.DataSource = fnListasDat.ListEstadoSiNoNinguno();
            cmbTieneDestino.Properties.DisplayMember = "Nombre";
            cmbTieneDestino.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCuentaAnt = this.EstructuraForm.StrX[0];
                xCuentaNvo = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "REL. CUENTA GENERAL-EMPRESARIAL";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbTieneDestino.EditValue = fnConst.TextNingunoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCuentaAnt.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCuentaContableRel.GetFormID(xCuentaAnt,xCuentaNvo);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCuentaAnt.Text = entMain.CuentaAnt.Trim();
                txtCuentaNvo.Text = entMain.CuentaNvo.Trim();
                cmbTieneDestino.EditValue = entMain.TieneDestino;
                txtDestinoDebe.Text = (!String.IsNullOrEmpty(entMain.CuentaDestinoDebe)) ? entMain.CuentaDestinoDebe.Trim() : String.Empty;
                txtDestinoHaber.Text = (!String.IsNullOrEmpty(entMain.CuentaDestinoHaber)) ? entMain.CuentaDestinoHaber.Trim() : String.Empty;
                txtUltimoUsuario.Text = entMain.UltimoUsuario;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaModificacion);

                entCuentaContable oEnt = new entCuentaContable();
                oEnt = negCuentaContable.GetFormID(entMain.CuentaAnt.Trim());
                if (oEnt.ResultadoBusqueda) {
                    txtCuentaAntNombre.Text = oEnt.Nombres.Trim();                
                }
                
                oEnt = negCuentaContable.GetFormID(entMain.CuentaNvo.Trim());
                if (oEnt.ResultadoBusqueda){
                    txtCuentaNvoNombre.Text = oEnt.Nombres.Trim();
                }

                oEnt = null;
                txtCuentaNvo.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCuentaAnt.ReadOnly = !sHabilitado;
            txtCuentaNvo.ReadOnly = !sHabilitado;
            cmbTieneDestino.ReadOnly = !sHabilitado;
            txtDestinoDebe.ReadOnly = !sHabilitado;
            txtDestinoHaber.ReadOnly = !sHabilitado;

            btnCuentaAnt.Enabled = true;
            btnCuentaNvo.Enabled = true;
            btnDestinoDebe.Enabled = true;
            btnDestinoHaber.Enabled = true;
            btnGuardar.Enabled = true;
            txtCuentaAntNombre.ReadOnly = true;
            txtCuentaNvoNombre.ReadOnly = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtCuentaAnt.ReadOnly = true;
                txtCuentaNvo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) {
                btnCuentaAnt.Enabled = false;
                btnCuentaNvo.Enabled = false;
                btnDestinoDebe.Enabled = false;
                btnDestinoHaber.Enabled = false;
                btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCuentaAnt.Focus(); }
            if (xOperacion.Equals("M")) { cmbTieneDestino.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCtaAnt = txtCuentaAnt.Text.ToString().Trim();
            String sCtaNvo = txtCuentaNvo.Text.ToString().Trim();
            String sTieneDest = cmbTieneDestino.EditValue.ToString();
            String sDestDebe = txtDestinoDebe.Text.ToString().Trim();
            String sDestHabe = txtDestinoHaber.Text.ToString().Trim();

            if (String.IsNullOrEmpty(sCtaAnt)){
                fnMensaje.MensajeInfo("Por favor registrar el código de la cuenta contable anterior.");
                txtCuentaAnt.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sCtaNvo)){
                fnMensaje.MensajeInfo("Por favor registrar el código de la cuenta contable nueva.");
                txtCuentaNvo.Focus();
                return bOk;
            }

            if (sTieneDest.Equals(fnConst.TextNingunoCod)) {
                fnMensaje.MensajeInfo("Por favor seleccionar si tiene destino.");
                cmbTieneDestino.Focus();
                return bOk;
            }

            if (sCtaAnt.Equals(sCtaNvo)) {
                fnMensaje.MensajeInfo("Cuenta anterior y nuevo deben ser distintos.");
                txtCuentaNvo.Focus();
                return bOk;
            }

            //Revisando Opcion de Cuenta
            entCuentaContable oEnt = new entCuentaContable();
            oEnt = negCuentaContable.GetFormID(sCtaAnt);
            if (oEnt.ResultadoBusqueda) {
                if (oEnt.TipoCuenta.Equals("E")) {
                    fnMensaje.MensajeInfo("Cuenta anterior debe ser tipo General.");
                    txtCuentaAnt.Focus();
                    oEnt = null;
                    return bOk;
                }
            }

            oEnt = negCuentaContable.GetFormID(sCtaNvo);
            if (oEnt.ResultadoBusqueda){
                if (oEnt.TipoCuenta.Equals("G")){
                    fnMensaje.MensajeInfo("Cuenta nueva debe ser tipo Empresarial.");
                    txtCuentaAnt.Focus();
                    oEnt = null;
                    return bOk;
                }
            }            
            //=========================//

            if (sTieneDest.Equals("S")) {
                if (String.IsNullOrEmpty(sDestDebe)) {
                    fnMensaje.MensajeInfo("Falta definir cuenta destino Debe.");
                    txtDestinoDebe.Focus();
                    return bOk;
                }

                if (String.IsNullOrEmpty(sDestHabe)){
                    fnMensaje.MensajeInfo("Falta definir cuenta destino Haber.");
                    txtDestinoHaber.Focus();
                    return bOk;
                }

                oEnt = negCuentaContable.GetFormID(sDestDebe);
                if (!oEnt.ResultadoBusqueda) {
                    fnMensaje.MensajeInfo("Cuenta registrada en el debe destino no existe.");
                    txtDestinoDebe.Focus();
                    return bOk;
                }

                if (oEnt.TipoCuenta.Equals("G")){
                    fnMensaje.MensajeInfo("Cuenta registrada en el debe destino tiene que ser cuenta tipo empresarial.");
                    txtDestinoDebe.Focus();
                    oEnt = null;
                    return bOk;
                }

                oEnt = negCuentaContable.GetFormID(sDestHabe);
                if (!oEnt.ResultadoBusqueda){
                    fnMensaje.MensajeInfo("Cuenta registrada en el haber destino no existe.");
                    txtDestinoHaber.Focus();
                    return bOk;
                }

                if (oEnt.TipoCuenta.Equals("G")){
                    fnMensaje.MensajeInfo("Cuenta registrada en el haber destino tiene que ser cuenta tipo empresarial.");
                    txtDestinoHaber.Focus();
                    oEnt = null;
                    return bOk;
                }
            }

            //Actualizando Datos Entidad
            entMain.CuentaAnt = sCtaAnt;
            entMain.CuentaNvo = sCtaNvo;
            entMain.TieneDestino = sTieneDest;
            entMain.CuentaDestinoDebe = sDestDebe;
            entMain.CuentaDestinoHaber = sDestHabe;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCuentaAnt = sCtaAnt;
            xCuentaNvo = sCtaNvo;

            oEnt = null;
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

            oErr = negCuentaContableRel.MantFormID(entMain);
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
            Contabilidad.frmRelCtaGenEmp frm = new Contabilidad.frmRelCtaGenEmp();
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
            entCuentaContableRel oEnt = (entCuentaContableRel)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmRelCtaGenEmp frm = new Contabilidad.frmRelCtaGenEmp();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaAnt);
            frm.EstructuraForm.StrX.Insert(1, oEnt.CuentaNvo);
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
            entCuentaContableRel oEnt = (entCuentaContableRel)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCuentaContableRel.MantFormID(oEnt);
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
            entCuentaContableRel oEnt = (entCuentaContableRel)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmRelCtaGenEmp frm = new Contabilidad.frmRelCtaGenEmp();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.CuentaAnt);
            frm.EstructuraForm.StrX.Insert(1, oEnt.CuentaNvo); 
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

        #region "==EventObjectMant"

        private void txtCuentaAnt_Leave(object sender, EventArgs e)
        {
            txtCuentaAntNombre.Text = String.Empty;
            if (!String.IsNullOrEmpty(txtCuentaAnt.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtCuentaAnt.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtCuentaAnt.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
                txtCuentaAntNombre.Text = oEnt.Nombres.Trim();
            }
        }

        private void txtCuentaNvo_Leave(object sender, EventArgs e)
        {
            txtCuentaNvoNombre.Text = String.Empty;
            if (!String.IsNullOrEmpty(txtCuentaAnt.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtCuentaNvo.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtCuentaNvo.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
                txtCuentaNvoNombre.Text = oEnt.Nombres.Trim();
            }
        }

        private void txtDestinoDebe_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDestinoDebe.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtDestinoDebe.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtDestinoDebe.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
            }
        }

        private void txtDestinoHaber_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDestinoHaber.Text)){
                entCuentaContable oEnt = negCuentaContable.GetFormID(txtDestinoHaber.Text);
                if (!oEnt.ResultadoBusqueda){
                    txtDestinoHaber.Text = String.Empty;
                    fnMensaje.MensajeInfo("Cuenta no se encuentra registrada");
                    return;
                }
            }
        }

        private void btnCuentaAnt_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtCuentaAnt.Text = oEnt.Cuenta.Trim();
                txtCuentaAntNombre.Text = oEnt.Nombres.Trim();
                oEnt = null;
            }
            frm = null;
        }

        private void btnCuentaNvo_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtCuentaNvo.Text = oEnt.Cuenta.Trim();
                txtCuentaNvoNombre.Text = oEnt.Nombres.Trim();
                oEnt = null;
            }
            frm = null;
        }

        private void btnDestinoDebe_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtDestinoDebe.Text = oEnt.Cuenta.Trim();
                oEnt = null;
            }
            frm = null;
        }

        private void btnDestinoHaber_Click(object sender, EventArgs e)
        {
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = false;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtDestinoHaber.Text = oEnt.Cuenta.Trim();
                oEnt = null;
            }
            frm = null;
        }

        #endregion


    }
}
