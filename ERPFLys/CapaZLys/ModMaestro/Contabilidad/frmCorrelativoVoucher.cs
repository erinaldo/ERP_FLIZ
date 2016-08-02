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
    public partial class frmCorrelativoVoucher : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {

        #region "==Propiedades=="
        
        private entCorrelativoVoucher entMain = new entCorrelativoVoucher();
        private String xOperacion = "";
        private String xCompania = "", xTipoVoucher = "";
        private Int32 xAnual = 0;
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmCorrelativoVoucher()
        {
            InitializeComponent();
        }

        private void frmCorrelativoVoucher_Load(object sender, EventArgs e)
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

        private void frmCorrelativoVoucher_Shown(object sender, EventArgs e)
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
            List<entCorrelativoVoucher> Lst = negCorrelativoVoucher.ListaFormID();
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
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT,fnConst.TextRaya3,fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //TipoVoucher
            List<entTipoVoucher> LstB = negTipoVoucher.ListaCombo(fnConst.StringPorc, fnConst.StringN, fnConst.StringA, new String[] { fnConst.TextRaya3, fnConst.TextNingunoNom });
            cmbTipoVoucher.Properties.DataSource = LstB;
            cmbTipoVoucher.Properties.DisplayMember = "TipoVoucher";
            cmbTipoVoucher.Properties.ValueMember = "TipoVoucher";
            LstB = null;
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xTipoVoucher = this.EstructuraForm.StrX[1];
                xAnual = this.EstructuraForm.NumX[0];
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
            this.lblTitulo.Text = "CORRELATIVO VOUCHER";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbTipoVoucher.EditValue = fnConst.TextRaya3;
            txtMes00.Text = fnConst.StrEnteroCero;
            txtMes01.Text = fnConst.StrEnteroCero;
            txtMes02.Text = fnConst.StrEnteroCero;
            txtMes03.Text = fnConst.StrEnteroCero;
            txtMes04.Text = fnConst.StrEnteroCero;
            txtMes05.Text = fnConst.StrEnteroCero;
            txtMes06.Text = fnConst.StrEnteroCero;
            txtMes07.Text = fnConst.StrEnteroCero;
            txtMes08.Text = fnConst.StrEnteroCero;
            txtMes09.Text = fnConst.StrEnteroCero;
            txtMes10.Text = fnConst.StrEnteroCero;
            txtMes11.Text = fnConst.StrEnteroCero;
            txtMes12.Text = fnConst.StrEnteroCero;
            txtMes13.Text = fnConst.StrEnteroCero;
            txtMes14.Text = fnConst.StrEnteroCero;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbCompania.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negCorrelativoVoucher.GetFormID(xCompania,xAnual,xTipoVoucher);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania.Trim();
                txtAnual.Text = entMain.Anio.ToString();
                cmbTipoVoucher.EditValue = entMain.TipoVoucher.Trim();
                txtMes00.Text = entMain.Mes00.ToString();
                txtMes01.Text = entMain.Mes01.ToString();
                txtMes02.Text = entMain.Mes02.ToString();
                txtMes03.Text = entMain.Mes03.ToString();
                txtMes04.Text = entMain.Mes04.ToString();
                txtMes05.Text = entMain.Mes05.ToString();
                txtMes06.Text = entMain.Mes06.ToString();
                txtMes07.Text = entMain.Mes07.ToString();
                txtMes08.Text = entMain.Mes08.ToString();
                txtMes09.Text = entMain.Mes09.ToString();
                txtMes10.Text = entMain.Mes10.ToString();
                txtMes11.Text = entMain.Mes11.ToString();
                txtMes12.Text = entMain.Mes12.ToString();
                txtMes13.Text = entMain.Mes13.ToString();
                txtMes14.Text = entMain.Mes14.ToString();
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtMes00.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            cmbCompania.ReadOnly = !sHabilitado;
            txtAnual.ReadOnly = !sHabilitado;
            cmbTipoVoucher.ReadOnly = !sHabilitado;
            txtMes00.ReadOnly = !sHabilitado;
            txtMes01.ReadOnly = !sHabilitado;
            txtMes02.ReadOnly = !sHabilitado;
            txtMes03.ReadOnly = !sHabilitado;
            txtMes04.ReadOnly = !sHabilitado;
            txtMes05.ReadOnly = !sHabilitado;
            txtMes06.ReadOnly = !sHabilitado;
            txtMes07.ReadOnly = !sHabilitado;
            txtMes08.ReadOnly = !sHabilitado;
            txtMes09.ReadOnly = !sHabilitado;
            txtMes10.ReadOnly = !sHabilitado;
            txtMes11.ReadOnly = !sHabilitado;
            txtMes12.ReadOnly = !sHabilitado;
            txtMes13.ReadOnly = !sHabilitado;
            txtMes14.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtAnual.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbCompania.Focus(); }
            if (xOperacion.Equals("M")) { txtMes00.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            Int32 nAnual = 0, nMes00 = 0, nMes01 = 0, nMes02 = 0, nMes03 = 0, nMes04 = 0, nMes05 = 0, nMes06 = 0;
            Int32 nMes07 = 0, nMes08 = 0, nMes09 = 0, nMes10 = 0, nMes11 = 0, nMes12 = 0, nMes13 = 0, nMes14 = 0;

            String sCia = cmbCompania.EditValue.ToString().Trim();
            String sTVou = cmbTipoVoucher.EditValue.ToString().Trim();
            String sAnual = txtAnual.Text.ToString().Trim(); Int32.TryParse(sAnual, out nAnual);
            String sMes00 = txtMes00.Text.ToString().Trim(); Int32.TryParse(sMes00, out nMes00);
            String sMes01 = txtMes01.Text.ToString().Trim(); Int32.TryParse(sMes01, out nMes01);
            String sMes02 = txtMes02.Text.ToString().Trim(); Int32.TryParse(sMes02, out nMes02);
            String sMes03 = txtMes03.Text.ToString().Trim(); Int32.TryParse(sMes03, out nMes03);
            String sMes04 = txtMes04.Text.ToString().Trim(); Int32.TryParse(sMes04, out nMes04);
            String sMes05 = txtMes05.Text.ToString().Trim(); Int32.TryParse(sMes05, out nMes05);
            String sMes06 = txtMes06.Text.ToString().Trim(); Int32.TryParse(sMes06, out nMes06);
            String sMes07 = txtMes07.Text.ToString().Trim(); Int32.TryParse(sMes07, out nMes07);
            String sMes08 = txtMes08.Text.ToString().Trim(); Int32.TryParse(sMes08, out nMes08);
            String sMes09 = txtMes09.Text.ToString().Trim(); Int32.TryParse(sMes09, out nMes09);
            String sMes10 = txtMes10.Text.ToString().Trim(); Int32.TryParse(sMes10, out nMes10);
            String sMes11 = txtMes11.Text.ToString().Trim(); Int32.TryParse(sMes11, out nMes11);
            String sMes12 = txtMes12.Text.ToString().Trim(); Int32.TryParse(sMes12, out nMes12);
            String sMes13 = txtMes13.Text.ToString().Trim(); Int32.TryParse(sMes13, out nMes13);
            String sMes14 = txtMes14.Text.ToString().Trim(); Int32.TryParse(sMes14, out nMes14);            

            if (String.IsNullOrEmpty(sCia)|| sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Por favor, ingresar el código de la empresa.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sAnual) || nAnual <=0){
                fnMensaje.MensajeInfo("Por favor, ingresar el año válido.");
                txtAnual.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sTVou) || sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Por favor, ingresar un tipo de voucher.");
                cmbTipoVoucher.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes00) || nMes00 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 00.");
                txtMes00.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes01) || nMes01 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 01.");
                txtMes01.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes02) || nMes02 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 02.");
                txtMes02.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes03) || nMes03 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 03.");
                txtMes03.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes04) || nMes04 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 04.");
                txtMes04.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes05) || nMes05 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 05.");
                txtMes05.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes06) || nMes06 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 06.");
                txtMes06.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes07) || nMes07 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 07.");
                txtMes07.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes08) || nMes08 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 08.");
                txtMes08.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes09) || nMes09 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 09.");
                txtMes09.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes10) || nMes10 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 10.");
                txtMes10.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes11) || nMes11 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 11.");
                txtMes11.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes12) || nMes12 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 12.");
                txtMes12.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes13) || nMes13 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 13.");
                txtMes13.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMes14) || nMes14 <0){
                fnMensaje.MensajeInfo("Por favor, registrar un correlativo válido para el mes 14.");
                txtMes14.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.Anio = nAnual;
            entMain.TipoVoucher = sTVou;
            entMain.Mes00 = nMes00;
            entMain.Mes01 = nMes01;
            entMain.Mes02 = nMes02;
            entMain.Mes03 = nMes03;
            entMain.Mes04 = nMes04;
            entMain.Mes05 = nMes05;
            entMain.Mes06 = nMes06;
            entMain.Mes07 = nMes07;
            entMain.Mes08 = nMes08;
            entMain.Mes09 = nMes09;
            entMain.Mes10 = nMes10;
            entMain.Mes11 = nMes11;
            entMain.Mes12 = nMes12;
            entMain.Mes13 = nMes13;
            entMain.Mes14 = nMes14;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xAnual = Int32.Parse(sAnual);
            xTipoVoucher = sTVou;

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

            oErr = negCorrelativoVoucher.MantFormID(entMain);
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
            Contabilidad.frmCorrelativoVoucher frm = new Contabilidad.frmCorrelativoVoucher();
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
            entCorrelativoVoucher oEnt = (entCorrelativoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmCorrelativoVoucher frm = new Contabilidad.frmCorrelativoVoucher();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.TipoVoucher);
            frm.EstructuraForm.NumX.Insert(0, oEnt.Anio);
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
            entCorrelativoVoucher oEnt = (entCorrelativoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negCorrelativoVoucher.MantFormID(oEnt);
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
            entCorrelativoVoucher oEnt = (entCorrelativoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmCorrelativoVoucher frm = new Contabilidad.frmCorrelativoVoucher();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.TipoVoucher);
            frm.EstructuraForm.NumX.Insert(0, oEnt.Anio);
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
