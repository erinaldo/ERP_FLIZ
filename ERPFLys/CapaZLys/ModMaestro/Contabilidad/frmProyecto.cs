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
    public partial class frmProyecto : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entProyecto entMain = new entProyecto();
        private String xOperacion = "";
        private String xCompania = "",xProyecto = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmProyecto()
        {
            InitializeComponent();
        }

        private void frmProyecto_Load(object sender, EventArgs e)
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

        private void frmProyecto_Shown(object sender, EventArgs e)
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
            List<entProyecto> Lst = negProyecto.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Moneda
            rilueMoneda.DataSource = fnListasDat.ListMonedaNinguno();
            rilueMoneda.DisplayMember = "Nombre";
            rilueMoneda.ValueMember = "Codigo";

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
            //Compania
            List<entCompania> LstA = negCompania.ListCiaComboXEstado(fnConst.StringT, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //Moneda Proyecto
            cmbMonedaProyecto.Properties.DataSource = fnListasDat.ListMonedaNinguno();
            cmbMonedaProyecto.Properties.DisplayMember = "Nombre";
            cmbMonedaProyecto.Properties.ValueMember = "Codigo";

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
                xCompania = this.EstructuraForm.StrX[0];
                xProyecto = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "PROYECTOS";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbMonedaProyecto.EditValue = fnConst.TextNingunoCod;
            txtPresupuestado.Text = "0";
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtEstadoAvance.Text = "PR";
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            cmbCompania.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negProyecto.GetFormID(xCompania,xProyecto);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania;
                txtProyectoCodigo.Text = entMain.ProyectoCodigo.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                txtPresupuestado.Text = entMain.Presupuestado.ToString();
                cmbMonedaProyecto.EditValue = (!String.IsNullOrEmpty(entMain.MonedaProyecto)) ? entMain.MonedaProyecto : fnConst.TextNingunoCod;
                txtFechaAprobacion.Text = (!(entMain.FechaAprobacionProy==DateTime.MinValue))?entMain.FechaAprobacionProy.ToShortDateString():String.Empty;
                txtFechaValidaDesde.Text = (!(entMain.FechaValidaDesde == DateTime.MinValue)) ? entMain.FechaValidaDesde.ToShortDateString() : String.Empty;
                txtFechaValidaHasta.Text = (!(entMain.FechaValidaHasta == DateTime.MinValue)) ? entMain.FechaValidaHasta.ToShortDateString() : String.Empty;
                cmbEstado.EditValue = entMain.Estado;
                txtEstadoAvance.Text = entMain.EstadoAvance;
                txtUltimoUsuario.Text = entMain.UltimoUsuario;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaModificacion);
                txtDescripcion.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            cmbCompania.ReadOnly = !sHabilitado;
            txtProyectoCodigo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            txtPresupuestado.ReadOnly = !sHabilitado;
            cmbMonedaProyecto.ReadOnly = !sHabilitado;
            txtFechaAprobacion.ReadOnly = !sHabilitado;
            txtFechaValidaDesde.ReadOnly = !sHabilitado;
            txtFechaValidaHasta.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            txtEstadoAvance.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = !sHabilitado;
                txtProyectoCodigo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { cmbCompania.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString();
            String sProy = txtProyectoCodigo.Text.Trim();
            String sDescripcion = txtDescripcion.Text.Trim();
            String sPres = txtPresupuestado.Text.Trim();
            String sMoned = cmbMonedaProyecto.EditValue.ToString();
            String sFecAprob = txtFechaAprobacion.Text;
            String sFecValDesde = txtFechaValidaDesde.Text;
            String sFecValHasta = txtFechaValidaHasta.Text;
            DateTime dFecAprob = DateTime.MinValue; DateTime.TryParse(sFecAprob, out dFecAprob);
            DateTime dFecValDesde = DateTime.MinValue; DateTime.TryParse(sFecValDesde, out dFecValDesde);
            DateTime dFecValHasta = DateTime.MinValue; DateTime.TryParse(sFecValHasta, out dFecValHasta);
            String sEstAvance = txtEstadoAvance.Text.Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            Decimal nPres = 0;Decimal.TryParse(sPres,out nPres);

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Debe ingresar Compañia por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sProy)){
                fnMensaje.MensajeInfo("Debe ingresar Código por favor.");
                txtProyectoCodigo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sEstAvance)){
                fnMensaje.MensajeInfo("Ingresar Estado avance por favor.");
                cmbEstado.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.ProyectoCodigo = sProy;
            entMain.Descripcion = sDescripcion;
            entMain.Presupuestado = nPres;
            entMain.MonedaProyecto = sMoned;
            entMain.FechaAprobacionProy = dFecAprob;
            entMain.FechaValidaDesde = dFecValDesde;
            entMain.FechaValidaHasta = dFecValHasta;
            entMain.Estado = sEstado;
            entMain.EstadoAvance = sEstAvance;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xCompania = sCia;
            xProyecto = sProy;
            
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

            oErr = negProyecto.MantFormID(entMain);
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
            Contabilidad.frmProyecto frm = new Contabilidad.frmProyecto();
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
            entProyecto oEnt = (entProyecto)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmProyecto frm = new Contabilidad.frmProyecto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.ProyectoCodigo);
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
            entProyecto oEnt = (entProyecto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negProyecto.MantFormID(oEnt);
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
            entProyecto oEnt = (entProyecto)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmProyecto frm = new Contabilidad.frmProyecto();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.ProyectoCodigo);
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
