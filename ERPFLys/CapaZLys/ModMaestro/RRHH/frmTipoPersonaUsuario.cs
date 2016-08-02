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
using FiltroLys.Model.Maestro.RRHH;
using FiltroLys.Domain.Maestro.RRHH;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.RRHH
{
    public partial class frmTipoPersonaUsuario : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {

        #region "==Propiedades=="
        
        private entTipoPersonaUsuario entMain = new entTipoPersonaUsuario();
        private String xOperacion = "";
        private String xTipoPersona = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmTipoPersonaUsuario()
        {
            InitializeComponent();
        }

        private void frmTipoPersonaUsuario_Load(object sender, EventArgs e)
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

        private void frmTipoPersonaUsuario_Shown(object sender, EventArgs e)
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
            List<entTipoPersonaUsuario> Lst = negTipoPersonaUsuario.ListaFormID();
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
            //Estado
            cmbFlagCliente.Properties.DataSource = fnListasDat.ListEstadoSiNoRaya();
            cmbFlagCliente.Properties.DisplayMember = "Nombre";
            cmbFlagCliente.Properties.ValueMember = "Codigo";

            //Empleado
            cmbFlagEmpleado.Properties.DataSource = fnListasDat.ListEstadoSiNoRaya();
            cmbFlagEmpleado.Properties.DisplayMember = "Nombre";
            cmbFlagEmpleado.Properties.ValueMember = "Codigo";

            //Proveedor
            cmbFlagProveedor.Properties.DataSource = fnListasDat.ListEstadoSiNoRaya();
            cmbFlagProveedor.Properties.DisplayMember = "Nombre";
            cmbFlagProveedor.Properties.ValueMember = "Codigo";

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
                xTipoPersona = this.EstructuraForm.StrX[0];                
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
            this.lblTitulo.Text = "PERSONA - CTA ESPECIFICA";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbFlagCliente.EditValue = fnConst.TextNingunoCod;
            cmbFlagEmpleado.EditValue = fnConst.TextNingunoCod;
            cmbFlagProveedor.EditValue = fnConst.TextNingunoCod;
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtTipo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negTipoPersonaUsuario.GetFormID(xTipoPersona);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtTipo.Text = entMain.TipoPersonaUsuario.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbFlagCliente.EditValue = entMain.FlagCliente;
                cmbFlagEmpleado.EditValue = entMain.FlagEmpleado;
                cmbFlagProveedor.EditValue = entMain.FlagProveedor;
                cmbEstado.EditValue = entMain.Estado;
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

            txtTipo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbFlagCliente.ReadOnly = !sHabilitado;
            cmbFlagEmpleado.ReadOnly = !sHabilitado;
            cmbFlagProveedor.ReadOnly = !sHabilitado;
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtTipo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtTipo.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sTipo = txtTipo.Text.ToString().Trim();
            String sDescripcion = txtDescripcion.Text.ToString().Trim();
            String sFlagClie = cmbFlagCliente.EditValue.ToString();
            String sFlagEmpl = cmbFlagEmpleado.EditValue.ToString();
            String sFlagProv = cmbFlagProveedor.EditValue.ToString();
            String sEstado = cmbEstado.EditValue.ToString();

            if (String.IsNullOrEmpty(sTipo)){
                fnMensaje.MensajeInfo("Debe ingresar Código por favor.");
                txtTipo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sFlagClie) || sFlagClie.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Flag Cliente(SI/NO).");
                cmbFlagCliente.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sFlagEmpl) || sFlagEmpl.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Flag Empleado(SI/NO).");
                cmbFlagEmpleado.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sFlagProv) || sFlagProv.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Flag Proveedor(SI/NO).");
                cmbFlagProveedor.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.TipoPersonaUsuario = sTipo;
            entMain.Descripcion = sDescripcion;
            entMain.FlagCliente = sFlagClie;
            entMain.FlagEmpleado = sFlagEmpl;
            entMain.FlagProveedor = sFlagProv;
            entMain.Estado = sEstado;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;

            xTipoPersona = sTipo;
            
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

            oErr = negTipoPersonaUsuario.MantFormID(entMain);
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
            RRHH.frmTipoPersonaUsuario frm = new RRHH.frmTipoPersonaUsuario();
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
            entTipoPersonaUsuario oEnt = (entTipoPersonaUsuario)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            RRHH.frmTipoPersonaUsuario frm = new RRHH.frmTipoPersonaUsuario();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoPersonaUsuario);
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
            entTipoPersonaUsuario oEnt = (entTipoPersonaUsuario)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negTipoPersonaUsuario.MantFormID(oEnt);
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
            entTipoPersonaUsuario oEnt = (entTipoPersonaUsuario)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            RRHH.frmTipoPersonaUsuario frm = new RRHH.frmTipoPersonaUsuario();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoPersonaUsuario);
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
