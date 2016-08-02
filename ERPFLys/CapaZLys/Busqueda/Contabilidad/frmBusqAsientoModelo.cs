using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    public partial class frmBusqAsientoModelo : FiltroLys.ZLys.Busqueda.General.frmBusqMain
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

        public frmBusqAsientoModelo()
        {
            InitializeComponent();
        }

        private void frmBusqAsientoModelo_Load(object sender, EventArgs e)
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
            txtMonto.Text = "0";
        }

        private void fxCargarCombos()
        {
        }

        private void fxCargarCombosDetalle()
        {
        }

        private Boolean fxValidarCriterio()
        {            
            return true;
        }

        private void fxCargarLista()
        {
            if (fxValidarCriterio() == false) { return; }
            grControl.DataSource = negAsientoModelo.ListAsientoModeloSearch(Compania);            
        }

        private void fxCargarListaDet()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            entAsientoModelo objE = (entAsientoModelo)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            grControlDet.DataSource = negAsientoModelo.ListAsientoModeloDetSearch(Compania, objE.Modelo);
            objE = null;
        }

        private void fxRecuperarData(){
            if (gvDatos.SelectedRowsCount == 0) { return; }
            Decimal nMonto = 0;
            if (!Decimal.TryParse(txtMonto.Text, out nMonto)){
                nMonto = 0;
            }

            List<entAsientoModeloDet> Lst = new List<entAsientoModeloDet>();
            int rowSel = gvDatosDet.DataRowCount;
            for (int i = 0; i < rowSel; i++){
                entAsientoModeloDet oEnt = (entAsientoModeloDet)gvDatosDet.GetRow(i);
                oEnt.Monto = nMonto * (oEnt.Porcentaje / 100);
                Lst.Add(oEnt);
                oEnt = null;
            }
            EstructuraForm.ObjX = Funciones.fnConvert.EntityToObject<entAsientoModeloDet, Object>(Lst);
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

        private void gvDatosDet_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            String sColumn = e.Column.Name;
            switch (sColumn)
            {
                case "PersonaDet":
                    if ((Int32)e.Value == 0) { e.DisplayText = ""; }
                    break;
            }
        }

        #endregion

    }
}
