using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmVoucherList : FiltroLys.ZLys.Controles.Formulario.frmList
    {

        #region "==EventForm=="

        public frmVoucherList()
        {
            InitializeComponent();
        }

        private void frmVoucherList_Load(object sender, EventArgs e)
        {
            fxSeguridadBotones();
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxValoresDefault();
        }

        #endregion

        #region "==EventObject=="

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String scia = cmbCompania.EditValue.ToString();
            if (scia == null || scia.Equals(String.Empty)){
                Funciones.fnMensaje.MensajeInfo("Seleccionar Compañia por favor.");
                return;
            }

            String sper = negPeriodoCia.GetPerTrabajo(scia, fnConst.ModContabilidadCod);
            if (sper == null || sper.Equals(String.Empty))
            {
                Funciones.fnMensaje.MensajeInfo("No se pudo obtener periodo de trabajo actual. Asignar uno válido.");
                return;
            }

            ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
            frm.Operacion = "A";
            frm.Compania = scia;
            frm.Periodo = "";
            frm.TipoVoucher = "";
            frm.NumeroVoucher = "";
            fnAddTab.FormOpen(frm, "Nuevo");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            String sCia = "", sPer = "", sTV = "", sNro = "", sEstado = "", sModRes = "";
            cont = gvDatos.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatos.SelectedRowsCount;
            if (row == 0) { return; }

            entVoucher objT = (entVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            sCia = objT.Compania;
            sPer = objT.Periodo;
            sTV = objT.TipoVoucher;
            sNro = objT.NumeroVoucher;
            sModRes = objT.FlagModRestringida;
            objT = null;

            entVoucher objX = negVoucher.GetVoucherFormID(sCia, sPer, sTV, sNro);
            if (objX.ResultadoBusqueda) { sEstado = objX.Estado; }
            objX = null;

            if (sEstado.Equals("PE"))
            {
                if (sModRes.Equals("S"))
                {
                    fnMensaje.MensajeInfo("La modificación de este voucher se encuentra restringida.");
                    return;
                }
                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "M";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "Modificar";                
                fnAddTab.FormOpen(frm, tagFrm);
            }
            else
            {
                fnMensaje.MensajeInfo("Estado de voucher no permite esta operación.");
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            String sCia = "", sPer = "", sTV = "", sNro = "", sEstado = "", sModRes = "";
            cont = gvDatos.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatos.SelectedRowsCount;
            if (row == 0) { return; }

            entVoucher objT = (entVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            sCia = objT.Compania;
            sPer = objT.Periodo;
            sTV = objT.TipoVoucher;
            sNro = objT.NumeroVoucher;
            sModRes = objT.FlagModRestringida;
            objT = null;

            entVoucher objX = negVoucher.GetVoucherFormID(sCia, sPer, sTV, sNro);
            if (objX.ResultadoBusqueda) { sEstado = objX.Estado; }
            objX = null;

            if (sEstado.Equals("PE")){
                if (sModRes.Equals("S")){
                    fnMensaje.MensajeInfo("La modificación de este voucher se encuentra restringida.");
                    return;
                }
                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "AP";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "Aprobar";                
                fnAddTab.FormOpen(frm, tagFrm);
            }
            else
            {
                fnMensaje.MensajeInfo("Estado de voucher no permite esta operación.");
            }
        }

        private void btnPasarPend_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            String sCia = "", sPer = "", sTV = "", sNro = "", sEstado = "", sModRes = "";
            cont = gvDatos.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatos.SelectedRowsCount;
            if (row == 0) { return; }

            entVoucher objT = (entVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            sCia = objT.Compania;
            sPer = objT.Periodo;
            sTV = objT.TipoVoucher;
            sNro = objT.NumeroVoucher;
            sModRes = objT.FlagModRestringida;
            objT = null;

            entVoucher objX = negVoucher.GetVoucherFormID(sCia, sPer, sTV, sNro);
            if (objX.ResultadoBusqueda) { sEstado = objX.Estado; }
            objX = null;

            if (sEstado.Equals("AP")){
                if (sModRes.Equals("S")){
                    fnMensaje.MensajeInfo("La modificación de este voucher se encuentra restringida.");
                    return;
                }
                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "PE";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "PasarPendiente";
                fnAddTab.FormOpen(frm, tagFrm);
            }
            else
            {
                fnMensaje.MensajeInfo("Estado de voucher no permite esta operación.");
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            String sCia = "", sPer = "", sTV = "", sNro = "", sEstado = "", sModRes = "";
            cont = gvDatos.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatos.SelectedRowsCount;
            if (row == 0) { return; }

            entVoucher objT = (entVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            sCia = objT.Compania;
            sPer = objT.Periodo;
            sTV = objT.TipoVoucher;
            sNro = objT.NumeroVoucher;
            sModRes = objT.FlagModRestringida;
            objT = null;

            entVoucher objX = negVoucher.GetVoucherFormID(sCia, sPer, sTV, sNro);
            if (objX.ResultadoBusqueda) { sEstado = objX.Estado; }
            objX = null;

            if (sEstado.Equals("PE")){
                if (sModRes.Equals("S"))
                {
                    fnMensaje.MensajeInfo("La modificación de este voucher se encuentra restringida.");
                    return;
                }
                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "AN";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "Anular";
                fnAddTab.FormOpen(frm, tagFrm);
            }
            else
            {
                fnMensaje.MensajeInfo("Estado de voucher no permite esta operación.");
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            String sCia = "", sPer = "", sTV = "", sNro = "";
            cont = gvDatos.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatos.SelectedRowsCount;
            if (row == 0) { return; }

            entVoucher objT = (entVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            sCia = objT.Compania;
            sPer = objT.Periodo;
            sTV = objT.TipoVoucher;
            sNro = objT.NumeroVoucher;           
            objT = null;
            
            ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
            frm.Operacion = "CP";
            frm.Compania = sCia;
            frm.Periodo = sPer;
            frm.TipoVoucher = sTV;
            frm.NumeroVoucher = sNro;
            tagFrm = "Copiar";
            fnAddTab.FormOpen(frm, tagFrm);           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sCia, sFlagDepartCia, sDepartCia, sFlagPeriodo, sPeriodo, sFlagEstado, sEstado;
            String sFlagVoucher, sTipoVoucher, sVoucherIni, sVoucherFin;

            if (!fxValidarCriterio()) { return; }

            sCia = cmbCompania.EditValue.ToString();
            sDepartCia = cmbDepartamento.EditValue.ToString();
            sEstado = cmbEstado.EditValue.ToString();

            sFlagDepartCia = (chkDepartamento.Checked) ? "S" : "N";
            sFlagPeriodo = (chkPeriodo.Checked) ? "S" : "N";
            sPeriodo = txtPeriodo.Text;
            sFlagEstado = (chkEstado.Checked) ? "S" : "N";
            sFlagVoucher = (chkVoucher.Checked) ? "S" : "N";
            sTipoVoucher = txtTipoVoucher.Text;
            sVoucherIni = txtVoucherIni.Text;
            sVoucherFin = txtVoucherFin.Text;
            sPeriodo = sPeriodo.Replace("-", "").Trim();

            List<entVoucher> Ls = negVoucher.ListVoucherForm(sCia, sFlagDepartCia, sDepartCia, sFlagPeriodo,
                sPeriodo, sFlagEstado, sEstado, sFlagVoucher, sTipoVoucher, sVoucherIni, sVoucherFin);

            grControl.DataSource = Ls;
        }

        private void cmbCompania_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarCombosXCia();
        }

        private void chkDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            cmbDepartamento.Enabled = !chkDepartamento.Checked;
            if (chkDepartamento.Checked) { cmbDepartamento.EditValue = fnConst.TextVacio; }
            if (!chkDepartamento.Checked) { cmbDepartamento.Focus(); }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbEstado.Enabled = !chkEstado.Checked;
            if (chkEstado.Checked) { cmbEstado.EditValue = fnConst.StringT; }
            if (!chkEstado.Checked) { cmbEstado.Focus(); }
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodo.Enabled = !chkPeriodo.Checked;
            txtPeriodo.Text = String.Empty;
            if (!chkPeriodo.Checked) { txtPeriodo.Focus(); }
        }

        private void chkVoucher_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoVoucher.Enabled = !chkVoucher.Checked;
            txtVoucherIni.Enabled = !chkVoucher.Checked;
            txtVoucherFin.Enabled = !chkVoucher.Checked;
            txtTipoVoucher.Text = String.Empty;
            txtVoucherIni.Text = String.Empty;
            txtVoucherFin.Text = String.Empty;
            if (!chkVoucher.Checked)
            {
                txtVoucherIni.Text = fnConst.VoucherDefIni;
                txtVoucherFin.Text = fnConst.VoucherDefFin;
                txtTipoVoucher.Focus();
            }
        }

        private void gvDatos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Clicks == 2){
                int cont = 0; String tagFrm = "";
                String sCia = "", sPer = "", sTV = "", sNro = "";
                cont = gvDatos.DataRowCount;
                if (cont == 0) { return; }

                entVoucher objT = (entVoucher)gvDatos.GetRow(e.RowHandle);
                sCia = objT.Compania;
                sPer = objT.Periodo;
                sTV = objT.TipoVoucher;
                sNro = objT.NumeroVoucher;
                objT = null;

                ModContabilidad.frmVoucherMant frm = new ModContabilidad.frmVoucherMant();
                frm.Operacion = "V";
                frm.Compania = sCia;
                frm.Periodo = sPer;
                frm.TipoVoucher = sTV;
                frm.NumeroVoucher = sNro;
                tagFrm = "Ver";
                fnAddTab.FormOpen(frm, tagFrm);
            }
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxSeguridadBotones()
        {
            fnAcceso objFn = new fnAcceso();
            objFn.addControl(new Funciones.Controles(btnNuevo, "0301010000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnModificar, "0301020000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnAprobar, "0301030000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnPasarPend, "0301040000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnAnular, "0301050000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnCopiar, "0301060000", fnEnum.AccesoOpcion.Acceso));
            objFn.addControl(new Funciones.Controles(btnImprimir, "0301070000", fnEnum.AccesoOpcion.Acceso));
            objFn.HabControl(GlobalVar.UsuarioLogeo, fnConst.ModContabilidadCod);
            objFn = null;
        }

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListCiaComboXAppXUsu(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringN, fnConst.TextSeleccioneNom);
            cmbCompania.EditValueChanged -= new System.EventHandler(this.cmbCompania_EditValueChanged);
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            Lst = null;

            //Estado
            List<entComboList> Lst2 = new List<entComboList>();
            Lst2.Add(new entComboList() { Codigo = fnConst.StringT, Nombre = fnConst.TextSeleccioneNom });
            Lst2.Add(new entComboList() { Codigo = fnConst.EstadoRegAprobadoCod, Nombre = fnConst.EstadoRegAprobadoNom });
            Lst2.Add(new entComboList() { Codigo = fnConst.EstadoRegAnuladoCod, Nombre = fnConst.EstadoRegAnuladoNom });
            Lst2.Add(new entComboList() { Codigo = fnConst.EstadoRegPendienteCod, Nombre = fnConst.EstadoRegPendienteNom });
            cmbEstado.Properties.DataSource = Lst2;
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
            Lst2 = null;
        }

        private void fxCargarCombosXCia()
        {
            String sCia = cmbCompania.EditValue.ToString();
            
            //DepartamentoCia
            List<entDepartCia> Lst = negDepartCia.ListaCombo(sCia, fnConst.StringPorc, new String[] { fnConst.TextNingunoCod, fnConst.TextNingunoNom });
            cmbDepartamento.Properties.DataSource = Lst;
            cmbDepartamento.Properties.DisplayMember = "Descripcion";
            cmbDepartamento.Properties.ValueMember = "DepartamentoCiaCodigo";
            cmbDepartamento.EditValue = fnConst.TextVacio;
            Lst = null;
        }

        private void fxCargarCombosDetalle()
        {
            //Estado
            List<entComboList> LstA = new List<entComboList>();
            LstA.Add(new entComboList() { Codigo = fnConst.EstadoRegAprobadoCod, Nombre = fnConst.EstadoRegAprobadoNom });
            LstA.Add(new entComboList() { Codigo = fnConst.EstadoRegAnuladoCod, Nombre = fnConst.EstadoRegAnuladoNom });
            LstA.Add(new entComboList() { Codigo = fnConst.EstadoRegPendienteCod, Nombre = fnConst.EstadoRegPendienteNom });

            rilueEstado.DataSource = LstA;
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
            LstA = null;

            //Origen
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = fnConst.ManualMNCod, Nombre = fnConst.ManualMNNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModActivoFijoCod, Nombre = fnConst.ModActivoFijoNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModComercialCod, Nombre = fnConst.ModComercialNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModContabilidadCod, Nombre = fnConst.ModContabilidadNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModLogisticaCod, Nombre = fnConst.ModLogisticaNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModProduccionCod, Nombre = fnConst.ModProduccionNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModRRHHCod, Nombre = fnConst.ModRRHHNom });
            LstB.Add(new entComboList() { Codigo = fnConst.ModTesoreriaCod, Nombre = fnConst.ModTesoreriaNom });

            rilueOrigen.DataSource = LstB;
            rilueOrigen.DisplayMember = "Nombre";
            rilueOrigen.ValueMember = "Codigo";
            LstB = null;

        }

        private void fxValoresDefault()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            String sPeriodo = negPeriodoCia.GetPerTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
            txtPeriodo.Text = sPeriodo;
            cmbEstado.EditValue = fnConst.StringT;
        }

        private Boolean fxValidarCriterio()
        {
            String sDep = cmbDepartamento.EditValue.ToString();
            String sEst = cmbEstado.EditValue.ToString();

            if (!chkDepartamento.Checked){
                if (sDep.Equals(String.Empty)){
                    fnMensaje.MensajeInfo("Por favor seleccionar un departamento.");
                    cmbDepartamento.Focus();
                    return false;
                }
            }

            if (!chkEstado.Checked){
                if (sEst.Equals("T")){
                    fnMensaje.MensajeInfo("Por favor seleccionar un estado.");
                    cmbEstado.Focus();
                    return false;
                }
            }

            if (!chkVoucher.Checked){
                if (txtTipoVoucher.Text.Equals(String.Empty)){
                    fnMensaje.MensajeInfo("Por favor ingresar el tipo de voucher.");
                    txtTipoVoucher.Focus();
                    return false;
                }

                if (txtVoucherIni.Text.Equals(String.Empty)){
                    fnMensaje.MensajeInfo("Por favor ingresar el voucher inicial.");
                    txtVoucherIni.Focus();
                    return false;
                }

                if (txtVoucherFin.Text.Equals(String.Empty)){
                    fnMensaje.MensajeInfo("Por favor ingresar el voucher final.");
                    txtVoucherFin.Focus();
                    return false;
                }
            }
            return true;
        }

        #endregion

    }
}
