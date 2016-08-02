using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using FiltroLys.Type;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.ZLys.Busqueda.General;
using FiltroLys.ZLys.Busqueda.Contabilidad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmAsientoModelo : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {

        #region "==Propiedades=="

        private entAsientoModelo entMain = new entAsientoModelo();
        private List<entAsientoModeloDet> LstDet = new List<entAsientoModeloDet>();
        private String xOperacion = "";
        private String xCompania = "", xModelo = "";
        private entEstructForm xestruct = new entEstructForm();
        private Decimal nTotalPorc = 0;

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmAsientoModelo()
        {
            InitializeComponent();
        }

        private void frmAsientoModelo_Load(object sender, EventArgs e)
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
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmAsientoModelo_Shown(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxFocusInicial();
            }
        }

        private void frmAsientoModelo_FormClosing(object sender, FormClosingEventArgs e)
        {
            entMain = null;
            LstDet = null;
            GC.SuppressFinalize(this);
        }

        #endregion

        #region "==Funciones List=="

        private void fxCargarLista()
        {
            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)) { return; }
            List<entAsientoModelo> Lst = negAsientoModelo.ListAsientoModeloForm();
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

        #region "==Funciones Mant=="

        private void fxQuitEvent() { }

        private void fxAddEvent() { }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXEstado(fnConst.EstadoActivoCod, fnConst.TextRaya3, fnConst.TextSeleccioneNom);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xCompania = this.EstructuraForm.StrX[0];
                xModelo = this.EstructuraForm.StrX[1];
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
            this.lblTitulo.Text = "ASIENTO MODELO";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbCompania.EditValue = fnConst.TextRaya3;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtModelo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negAsientoModelo.GetAsientoModeloFormID(xCompania,xModelo);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                cmbCompania.EditValue = entMain.Compania;
                txtModelo.Text = entMain.Modelo.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbEstado.EditValue = entMain.Estado;
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtDescripcion.Focus();
                fxCargarDet();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtModelo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            txtDesde.ReadOnly = !sHabilitado;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            btnGuardar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCuenta.Enabled = true;
            btnCCosto.Enabled = true;

            if (xOperacion.Equals("M")){
                cmbCompania.ReadOnly = true;
                txtModelo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { 
                btnGuardar.Enabled = false;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCuenta.Enabled = false;
                btnCCosto.Enabled = false;
                grDetalle.Enabled = false;
            }
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
            String sMod = txtModelo.Text.ToString().Trim();
            String sDes = txtDescripcion.Text.ToString().Trim();
            String sEstado = cmbEstado.EditValue.ToString();
            String sAnual = txtDesde.Text.ToString();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Debe Seleccionar Compañía por favor.");
                cmbCompania.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sMod)){
                fnMensaje.MensajeInfo("Debe ingresar el Código de Módelo.");
                txtModelo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDes)){
                fnMensaje.MensajeInfo("Debe ingresar el Nombre de Area.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (LstDet.Count == 0) {
                fnMensaje.MensajeInfo("Debe ingresar el detalle del Asiento Módelo.");
                return bOk;
            }

            DateTime dFechaServ = negGeneral.GetFechaServidor();

            //Actualizando Datos Entidad
            entMain.Compania = sCia;
            entMain.Modelo = sMod;
            entMain.Descripcion = sDes;
            entMain.Estado = sEstado;
            entMain.Anual = sAnual;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;
            entMain.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
            entMain.UltimaFechaMod = dFechaServ;
            entMain.DetalleAsientoModelo = LstDet;

            xCompania = sCia;
            xModelo = sMod;

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

            oErr = negAsientoModelo.MantAsientoModelo(entMain);
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

        #region "==FuncionesDet=="

        private void fxCargarDet()
        {
            LstDet = negAsientoModelo.GetAsientoModeloDetFormID(xCompania, xModelo);
            fxLinkDet();
        }

        private void fxLinkDet()
        {
            grDetalle.DataSource = null;
            if (LstDet.Count > 0) {
                grDetalle.DataSource = LstDet.FindAll(p => p.RegVer == fnEnum.RegVer.Si);
            }            
            gvDetalle.Focus();                
        }

        private Boolean fxValidarDetalle()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString();
            String sMod = txtModelo.Text.Trim();

            if (LstDet.Count == 0){
                fnMensaje.MensajeInfo("Debe ingresar al menos un registro en el detalle.");
                return bOk;
            }

            DateTime dFechaServ = negGeneral.GetFechaServidor();
            foreach (entAsientoModeloDet oEnt in LstDet){
                if (String.IsNullOrEmpty(oEnt.Cuenta)){
                    fnMensaje.MensajeInfo("Ingresar cuenta contable en Detalle por favor. Linea " + oEnt.Linea.ToString());
                    return bOk;
                }

                entCuentaContable oCta = negCuentaContable.GetFormID(oEnt.Cuenta);
                if (!(oCta.ResultadoBusqueda && oCta.Estado.Equals("A"))){
                    fnMensaje.MensajeInfo("Cuenta contable es inválido. Linea " + oEnt.Linea.ToString());
                    oCta = null;
                    return bOk;
                }
                oCta = null;

                if (!(String.IsNullOrEmpty(oEnt.CentroCosto))){
                    entCentroCosto oCC = negCentroCosto.GetCentroCostoFormID(sCia, oEnt.CentroCosto);
                    if (!(oCC.ResultadoBusqueda && oCC.Estado.Equals("A"))){
                        fnMensaje.MensajeInfo("Centro de costo es inválido. Linea " + oEnt.Linea.ToString());
                        oCC = null;
                        return bOk;
                    }
                    oCC = null;
                }

                if (oEnt.Porcentaje < 0 || oEnt.Porcentaje > 100){
                    fnMensaje.MensajeInfo("Porcentaje de distribución debe ser mayor igual a cero y menor igual a 100. Linea " + oEnt.Linea.ToString());
                    return bOk;
                }

                if (oEnt.RegExistente == fnEnum.RegExistente.Si && oEnt.RegEditado == fnEnum.RegEditado.Si) {
                    oEnt.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                }

                oEnt.Compania = sCia;
                oEnt.Modelo = sMod;
                if (oEnt.OperMantenimiento == fnEnum.OperacionMant.Insertar || oEnt.OperMantenimiento == fnEnum.OperacionMant.Modificar){
                    oEnt.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
                    oEnt.UsuarioSys = GlobalVar.UsuarioLogeo;
                    oEnt.UltimaFechaMod = dFechaServ;
                }
            }

            bOk = true;
            return bOk;
        }

        #endregion

        #region "==EventInherit=="

        public override void ue_nuevo()
        {
            Contabilidad.frmAsientoModelo frm = new Contabilidad.frmAsientoModelo();
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
            entAsientoModelo oEnt = (entAsientoModelo)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmAsientoModelo frm = new Contabilidad.frmAsientoModelo();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Modelo);
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
            entAsientoModelo oEnt = (entAsientoModelo)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negAsientoModelo.MantAsientoModelo(oEnt);
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
            entAsientoModelo oEnt = (entAsientoModelo)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmAsientoModelo frm = new Contabilidad.frmAsientoModelo();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.Compania);
            frm.EstructuraForm.StrX.Insert(1, oEnt.Modelo);
            frm.ShowDialog();
            oEnt = null;
            frm = null;
        }

        public override void ue_guardar()
        {
            if (!fxValidar()) { return; };
            if (!fxValidarDetalle()) { return; };
            if (!fxPreUpdate()) { return; };
            fxPostUpdate();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public override void ue_cancelar()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion

        #region "==EventObjectDet=="

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nLinea = 0;
            if (LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Count() > 0){
                nLinea = LstDet.Where(x => x.RegVer == fnEnum.RegVer.Si).Max(p => p.Linea);
            }
            nLinea++;
            entAsientoModeloDet objE = new entAsientoModeloDet();
            objE.Compania = xCompania;
            objE.Modelo = xModelo;
            objE.Linea = nLinea;
            objE.Porcentaje = 0;
            objE.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            objE.RegExistente = fnEnum.RegExistente.No;
            objE.UsuarioSys = GlobalVar.UsuarioLogeo;
            objE.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
            objE.UltimaFechaMod = DateTime.Now;
            LstDet.Add(objE);
            objE = null;
            fxLinkDet();
            gvDetalle.Focus();
            gvDetalle.FocusedRowHandle = gvDetalle.RowCount - 1;
            gvDetalle.FocusedColumn = gvDetalle.Columns["CuentaDet"];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0) { return; }
            entAsientoModeloDet oEnt = (entAsientoModeloDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            oEnt.RegVer = fnEnum.RegVer.No;
            oEnt.OperMantenimiento = (oEnt.OperMantenimiento == fnEnum.OperacionMant.Insertar) ? fnEnum.OperacionMant.Ninguno : fnEnum.OperacionMant.Eliminar;
            fxLinkDet();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0) { return; }
            entAsientoModeloDet objE = (entAsientoModeloDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                objE.Cuenta = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0].Cuenta;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["CuentaDet"];
            }
            objE = null;
            frm = null;
        }

        private void btnCCosto_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0) { return; }
            String sCia = cmbCompania.EditValue.ToString();
            if (sCia.Equals(fnConst.TextSeleccioneCod)){
                fnMensaje.MensajeInfo("Seleccionar Compañía por favor.");
                return;
            }

            entAsientoModeloDet objE = (entAsientoModeloDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqCentroCosto frm = new frmBusqCentroCosto();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.EstructuraForm.StrX.Insert(0, sCia);
            if (frm.ShowDialog() == DialogResult.OK){
                objE.CentroCosto = fnConvert.ObjectToEntity<entCentroCosto>(frm.EstructuraForm.ObjX)[0].CentroCosto;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["CentroCostoDet"];
            }
            objE = null;
            frm = null;
        }
                
        private void gvDetalle_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridSummaryItem xColumn = (GridSummaryItem)e.Item;
            GridView view = (GridView)sender;

            //Inicio Variables
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start){
                nTotalPorc = 0;
            }

            //Calculado
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate){
                Decimal xMonLoc = (Decimal)view.GetRowCellValue(e.RowHandle, "Porcentaje");
                nTotalPorc = nTotalPorc + xMonLoc;
            }

            //Finalizacion
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize){
                switch (xColumn.FieldName){
                    case "Porcentaje":
                        e.TotalValue = nTotalPorc.ToString("N2");
                        break;
                }
            }
        }

        private void gvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            entAsientoModeloDet objE = (entAsientoModeloDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            objE.RegEditado = fnEnum.RegEditado.Si;
            gvDetalle.UpdateCurrentRow();
            objE = null;
        }

        private void gvDetalle_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colCuenta = view.Columns["Cuenta"];
            GridColumn colCCosto = view.Columns["CentroCosto"];
            
            String sCuenta = (String)view.GetRowCellValue(e.RowHandle, colCuenta);
            String sCCosto = (String)view.GetRowCellValue(e.RowHandle, colCCosto);
            
            view.SetColumnError(colCuenta, String.Empty);
            view.SetColumnError(colCCosto, String.Empty);
            
            //Cuenta
            if (!String.IsNullOrEmpty(sCuenta)){
                entCuentaContable objCta = negCuentaContable.GetFormID(sCuenta);
                if (!objCta.ResultadoBusqueda || !objCta.Estado.Equals("A")){
                    e.Valid = false;
                    view.SetColumnError(colCuenta, "Cuenta contable ingresada es inválida.");
                }
                objCta = null;
            }

            //Centro Costo
            if (!String.IsNullOrEmpty(sCCosto)){
                String sCia = cmbCompania.EditValue.ToString();
                entCentroCosto objCos = negCentroCosto.GetCentroCostoFormID(sCia, sCCosto);
                if (!objCos.ResultadoBusqueda || !objCos.Estado.Equals("A")){
                    e.Valid = false;
                    view.SetColumnError(colCCosto, "Centro de costo ingresado es inválido.");
                }
                objCos = null;
            }
        }

        private void gvDetalle_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            String sNameCol = "";
            if (e.KeyCode == Keys.F1){
                if (!(xOperacion.Equals("M") || xOperacion.Equals("A"))) { return; }
                if (gvDetalle.FocusedRowHandle >= 0){
                    sNameCol = gvDetalle.FocusedColumn.Name;
                    EventArgs EventClick = new EventArgs();
                    switch (sNameCol){
                        case "Cuenta":
                            btnCuenta_Click(sender, EventClick);
                            break;
                        case "CentroCosto":
                            btnCCosto_Click(sender, EventClick);
                            break;                        
                    }
                    EventClick = null;
                }
            }
        }

        #endregion

    }
}
