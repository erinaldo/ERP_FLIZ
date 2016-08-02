using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Logistica;
using FiltroLys.Model.Logistica;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    public partial class frmBusqImportacion : FiltroLys.ZLys.Busqueda.General.frmBusqMain
    {
        #region "==Propiedades=="

        private String sCompania = "";
        
        public String Compania
        {
            get { return sCompania; }
            set { sCompania = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmBusqImportacion()
        {
            InitializeComponent();
        }

        private void frmBusqImportacion_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxValoresDefault();
            fxCargarLista();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxValoresDefault()
        {
            gvDatos.OptionsSelection.MultiSelect = MultipleSelect;
        }

        private void fxCargarCombos()
        {
        }

        private void fxCargarCombosDetalle()
        {
            //Estado
            List<entComboList> LstA = fnListasDat.ListMoneda();
            rilueMoneda.DataSource = LstA;
            rilueMoneda.DisplayMember = "Nombre";
            rilueMoneda.ValueMember = "Codigo";
            LstA = null;
        }

        private Boolean fxValidarCriterio()
        {            
            return true;
        }

        private void fxCargarLista()
        {
            if (fxValidarCriterio() == false) { return; }
            grControl.DataSource = negOrdenes.ListOrdenesToMantVoucherSearch(Compania);            
        }

        private void fxCargarListaDet()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            entOrdenes objE = (entOrdenes)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            grControlDet.DataSource = negOrdenes.ListOrdenesDetToMantVoucherSearch(Compania, objE.NumeroOrden, objE.Ampliacion);
            objE = null;
        }

        private void fxRecuperarData(){
            if (gvDatos.SelectedRowsCount == 0) { return; }
            List<entOrdenes> Lst = new List<entOrdenes>();
            int[] rowSel = gvDatos.GetSelectedRows();
            for (int i = 0; i < rowSel.Length; i++){
                Lst.Add((entOrdenes)gvDatos.GetRow(rowSel[i]));
            }
            EstructuraForm.ObjX = Funciones.fnConvert.EntityToObject<entOrdenes, Object>(Lst);
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

        private void gvDatos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            fxCargarListaDet();
        }

        #endregion

    }
}
