using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.Busqueda.General
{
    public partial class frmBusqPersona : FiltroLys.ZLys.Busqueda.General.frmBusqMain
    {
        #region "==Propiedades=="

        private Boolean bVerEmpleado = false;
        private Boolean bVerProveedor = false;
        private Boolean bVerCliente = false;
        private String sCompania = "";

        public Boolean VerEmpleado
        {
            get { return bVerEmpleado; }
            set { bVerEmpleado = value; }
        }

        public Boolean VerProveedor
        {
            get { return bVerProveedor; }
            set { bVerProveedor = value; }
        }

        public Boolean VerCliente
        {
            get { return bVerCliente; }
            set { bVerCliente = value; }
        }

        public String Compania
        {
            get { return sCompania; }
            set { sCompania = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmBusqPersona()
        {
            InitializeComponent();
        }

        private void frmBusqPersona_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxValoresDefault();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxValoresDefault()
        {
            gvDatos.OptionsSelection.MultiSelect = MultipleSelect;
            chkActivo.Enabled = !SoloActivo;
            cmbBuscarPor.EditValue = "Nombre";
        }

        private void fxCargarCombos()
        {
            //BuscarPor
            List<entComboList> Lst = new List<entComboList>();
            Lst.Add(new entComboList() { Codigo = "Nombre", Nombre = "Nombre" });
            Lst.Add(new entComboList() { Codigo = "Codigo", Nombre = "Código" });
            Lst.Add(new entComboList() { Codigo = "Documento", Nombre = "Documento" });
            Lst.Add(new entComboList() { Codigo = "DocumentoFiscal", Nombre = "Documento Fiscal" });
            cmbBuscarPor.Properties.DataSource = Lst;
            cmbBuscarPor.Properties.DisplayMember = "Nombre";
            cmbBuscarPor.Properties.ValueMember = "Codigo";
            Lst = null;
        }

        private void fxCargarCombosDetalle()
        {
            //Estado
            List<entComboList> LstA = fnListasDat.ListEstadoF1();
            rilueEstado.DataSource = LstA;
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";
            LstA = null;
        }
        
        private void fxCargarLista() {
            int nCodigo = 0;
            String sNombre = "%", sDocIden = "%", sDocFisc = "%";
            String sVerEmpl = (bVerEmpleado) ? "S" : "X";
            String sVerProv = (bVerProveedor) ? "S" : "X";
            String sVerClie = (bVerCliente) ? "S" : "X";
            String sBuscarPor = cmbBuscarPor.EditValue.ToString();
            String sCampo = txtDescripcion.Text.Trim();
            String sEstado = (chkActivo.Checked) ? "A" : "%";

            switch (sBuscarPor){
                case "Codigo":
                    if (int.TryParse(sCampo, out nCodigo) == false) { nCodigo = -1; }
                    break;
                case "Nombre":
                    sNombre = "%" + sCampo + "%";
                    break;
                case "Documento":
                    sDocIden = sCampo;
                    break;
                case "DocumentoFiscal":
                    sDocFisc = sCampo;
                    break;
            }

            entPersona oEntP = new entPersona();
            oEntP.Compania = Compania;
            oEntP.Persona = nCodigo;
            oEntP.NombreCompleto = sNombre;
            oEntP.DocumentoIdentidad = sDocIden;
            oEntP.DocumentoFiscal = sDocFisc;
            oEntP.EsEmpleado = sVerEmpl;
            oEntP.EsProveedor = sVerProv;
            oEntP.EsCliente = sVerClie;
            oEntP.Estado = sEstado;

            grControl.DataSource = negPersona.ListPersonaSearch(oEntP);
            oEntP = null;
        }

        private void fxRecuperarData(){
            if (gvDatos.SelectedRowsCount == 0) { return; }
            List<entPersona> Lst = new List<entPersona>();
            int[] rowSel = gvDatos.GetSelectedRows();
            for (int i = 0; i < rowSel.Length; i++){
                Lst.Add((entPersona)gvDatos.GetRow(rowSel[i]));
            }
            EstructuraForm.ObjX = Funciones.fnConvert.EntityToObject<entPersona, Object>(Lst);
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

        #endregion

    }
}
