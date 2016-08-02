using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Tesoreria;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    public partial class frmBusqObligacion : FiltroLys.ZLys.Busqueda.General.frmBusqMain
    {
        #region "==Propiedades=="

        private String sCompania = "";
        private int nProveedor = 0;

        public String Compania
        {
            get { return sCompania; }
            set { sCompania = value; }
        }

        public Int32 Proveedor
        {
            get { return nProveedor; }
            set { nProveedor = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmBusqObligacion()
        {
            InitializeComponent();
        }

        private void frmBusqObligacion_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxValoresDefault();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxValoresDefault()
        {
            gvDatos.OptionsSelection.MultiSelect = false;
        }

        private void fxCargarCombos()
        {
            //Estado Obligacion
            List<entComboList> Lst = new List<entComboList>();
            Lst = fnListasDat.ListEstadoObligacion();
            Lst.Insert(0, new entComboList() { Codigo = fnConst.TextSeleccioneCod, Nombre = fnConst.TextSeleccioneNom });
            cmbEstado.Properties.DataSource = Lst;
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
            cmbEstado.ItemIndex = 0;
            Lst = null;
        }

        private void fxCargarCombosDetalle()
        {
            //Estado
            List<entComboList> LstA = fnListasDat.ListEstadoObligacion();
            rilueEstado.DataSource = LstA;
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
            LstA = null;
        }

        private Boolean fxValidarCriterio()
        {
            String sTipoDoc = txtTipoDoc.Text.Trim();
            String sNroDoc = txtNroDoc.Text.Trim();
            String sEstado = cmbEstado.EditValue.ToString();

            if (!chkTipoDoc.Checked){
                if (sTipoDoc.Equals("")){
                    fnMensaje.MensajeInfo("Por favor ingresar un tipo de documento.");
                    txtTipoDoc.Focus();
                    return false;
                }
            }

            if (!chkNroDoc.Checked){
                if (sNroDoc.Equals("")){
                    fnMensaje.MensajeInfo("Por favor ingresar un número de documento.");
                    txtNroDoc.Focus();
                    return false;
                }
            }

            if (!chkEstado.Checked){
                if (sEstado.Equals("")){
                    fnMensaje.MensajeInfo("Por favor ingresar un estado del documento.");
                    cmbEstado.Focus();
                    return false;
                }
            }

            return true;
        }

        private void fxCargarLista() {

            if (fxValidarCriterio() == false) { return; }
            String sTipoDoc = (chkTipoDoc.Checked) ? "%" : txtTipoDoc.Text.Trim();
            String sNroDoc = (chkNroDoc.Checked) ? "%" : txtNroDoc.Text.Trim();
            String sEstado = (chkEstado.Checked) ? "%" : cmbEstado.EditValue.ToString();

            entObligacion oEntP = new entObligacion();
            oEntP.Compania = Compania;
            oEntP.CodProveedor = Proveedor;
            oEntP.TipoDocumento = sTipoDoc;
            oEntP.NumeroDocumento = sNroDoc;
            oEntP.EstadoDoc = sEstado;

            grControl.DataSource = negObligacion.ListObligacionToMantVoucherSearch(oEntP);
            oEntP = null;
        }

        private void fxRecuperarData(){
            if (gvDatos.SelectedRowsCount == 0) { return; }
            List<entObligacion> Lst = new List<entObligacion>();
            int[] rowSel = gvDatos.GetSelectedRows();
            for (int i = 0; i < rowSel.Length; i++){
                Lst.Add((entObligacion)gvDatos.GetRow(rowSel[i]));
            }
            EstructuraForm.ObjX = Funciones.fnConvert.EntityToObject<entObligacion, Object>(Lst);
            this.DialogResult = DialogResult.OK;
        }
                
        #endregion

        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fxCargarLista();
            if (gvDatos.RowCount > 0){
                gvDatos.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            fxRecuperarData();
        }

        private void gvDatos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2){
                if (MultipleSelect == false){
                    fxRecuperarData();
                }
            }
        }

        private void gvDatos_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter){
                e.SuppressKeyPress = true;
                if (MultipleSelect == false){
                    fxRecuperarData();
                }
            }
        }

        private void chkTipoDoc_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoDoc.Text = String.Empty;
            txtTipoDoc.Enabled = !chkTipoDoc.Checked;
            if (!chkTipoDoc.Checked) txtTipoDoc.Focus();
        }

        private void chkNroDoc_CheckedChanged(object sender, EventArgs e)
        {
            txtNroDoc.Text = String.Empty;
            txtNroDoc.Enabled = !chkNroDoc.Checked;
            if (!chkNroDoc.Checked) txtNroDoc.Focus();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbEstado.Text = String.Empty;
            cmbEstado.Enabled = !chkEstado.Checked;
            if (!chkEstado.Checked) cmbEstado.Focus();
        }

        #endregion

    }
}
