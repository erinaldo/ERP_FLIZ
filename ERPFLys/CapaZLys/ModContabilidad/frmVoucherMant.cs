using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.Errores;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Maestro.Mantenimiento;
using FiltroLys.Domain.Maestro.Mantenimiento;
using FiltroLys.Model.Tesoreria;
using FiltroLys.Model.Logistica;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using FiltroLys.ZLys.Busqueda.General;
using FiltroLys.ZLys.Busqueda.Contabilidad;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmVoucherMant : FiltroLys.ZLys.Controles.Formulario.frmMant
    {
        #region "==Propiedades=="
        
        private String sOperacion, sCompania, sPeriodo, sTipoVoucher, sNumeroVoucher, sCopia;
        private entVoucher oEntVoucher = new entVoucher();
        private List<entVoucherDet> LstDetVoucher = new List<entVoucherDet>();
        private Decimal nTotalDebeLoc = 0, nTotalDebeExt = 0, nTotalHaberLoc = 0, nTotalHaberExt = 0;
        private Decimal nSaldoLoc = 0, nSaldoExt = 0;
        
        public String Operacion
        {
            get
            {
                return sOperacion;
            }
            set
            {
                sOperacion = value;
            }
        }
        
        public String Compania
        {
            get
            {
                return sCompania;
            }
            set
            {
                sCompania = value;
            }
        }
        
        public String Periodo
        {
            get
            {
                return sPeriodo;
            }
            set
            {
                sPeriodo = value;
            }
        }
        
        public String TipoVoucher
        {
            get
            {
                return sTipoVoucher;
            }
            set
            {
                sTipoVoucher = value;
            }
        }
        
        public String NumeroVoucher
        {
            get
            {
                return sNumeroVoucher;
            }
            set
            {
                sNumeroVoucher = value;
            }
        }
        
        public String Copia
        {
            get
            {
                return sCopia;
            }
            set
            {
                sCopia = value;
            }
        }
        
        #endregion
        
        #region "==Evento Form=="
        
        public frmVoucherMant()
        {
            InitializeComponent();
        }
        
        private void frmVoucherMant_Load(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxCargarCombos();
            fxCargarCombosDetalle();
            fxPreOpen();
            fxPostOpen();
            fxAddEvent();
        }
        
        private void frmVoucherMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            oEntVoucher = null;
            LstDetVoucher = null;
            GC.SuppressFinalize(this);
        }
        
        #endregion
        
        #region "==EventObject=="
        
        private void cmbTipoVoucher_EditValueChanged(object sender, EventArgs e)
        {
            String sTipo = cmbTipoVoucher.EditValue.ToString();
            if (sTipo.Equals(fnConst.TextSeleccioneNomF2))
                return;
            entTipoVoucher oEnt = negTipoVoucher.GetFormID(sTipo);
            oEntVoucher.NumeroManual = oEnt.CorrelativoManual;
            oEnt = null;
        }
        
        private void cmbMoneda_EditValueChanged(object sender, EventArgs e)
        {
            String sMoneda = cmbMoneda.EditValue.ToString();
            if (sMoneda.Equals(fnConst.TextSeleccioneNomF2))
                return;
            if (chkConvAutomatica.Checked)
            {
                Decimal nTipoCamb = oEntVoucher.TipoCambio;
                fxConvertirDetalle(sMoneda, nTipoCamb);
            }
        }
        
        private void chkConvAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConvAutomatica.Checked)
            {
                String sMoneda = cmbMoneda.EditValue.ToString();
                Decimal nTipoCamb = 0;
                Decimal.TryParse(txtTC.Text, out nTipoCamb);
                String sTexto = (sMoneda.Equals("L")) ? "Extranjero" : "Local";
                if (MessageBox.Show("La información del Monto " + sTexto + " será modificada, ¿Desea continuar?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    fxConvertirDetalle(sMoneda, nTipoCamb);
                }
            }
            else
            {
                gvDetalle.Columns["MontoLocal"].ColumnEdit.ReadOnly = false;
                gvDetalle.Columns["MontoExt"].ColumnEdit.ReadOnly = false;                
            }
        }
        
        private void txtTC_EditValueChanged(object sender, EventArgs e)
        {
            Decimal nTipoCamb = 0;
            Decimal.TryParse(txtTC.Text, out nTipoCamb);
            txtTC.Text = nTipoCamb.ToString("N3");
            if (chkConvAutomatica.Checked)
            {
                String sMoneda = cmbMoneda.EditValue.ToString();
                fxConvertirDetalle(sMoneda, nTipoCamb);
            }
        }
        
        private void txtFecha_EditValueChanged(object sender, EventArgs e)
        {
            Decimal nTipoCamb = 0;
            DateTime dFecha = DateTime.MinValue;
            DateTime.TryParse(txtFecha.Text, out dFecha);
            if (dFecha != DateTime.MinValue)
            {
                nTipoCamb = negTipoCambio.GetTipoCambioXTipo(dFecha, "V");
            }
            
            if (nTipoCamb <= 0)
            {
                fnMensaje.MensajeInfo("No se pudo obtener el tipo de cambio del día.");
            }
            
            txtTC.Text = nTipoCamb.ToString("N3");
            if (chkConvAutomatica.Checked)
            {
                String sMoneda = cmbMoneda.EditValue.ToString();
                fxConvertirDetalle(sMoneda, nTipoCamb);
            }
        }
        
        #endregion
        
        #region "==EventObjectDet=="
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nLinea = LstDetVoucher.Count() + 1;
            entVoucherDet objE = new entVoucherDet();
            objE.Compania = sCompania;
            objE.Periodo = sPeriodo;
            objE.TipoVoucher = sTipoVoucher;
            objE.NumeroVoucher = sNumeroVoucher;
            objE.Linea = nLinea;
            objE.RegEditado = fnEnum.RegEditado.Si;
            LstDetVoucher.Add(objE);
            objE = null;
            fxLinkDet();
            fxSetearLinea();
            gvDetalle.Focus();
            gvDetalle.FocusedRowHandle = gvDetalle.RowCount - 1;
            gvDetalle.FocusedColumn = gvDetalle.Columns["Cuenta"];
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            LstDetVoucher.Remove(objE);
            objE = null;
            fxLinkDet();
            fxSetearLinea();
        }
        
        private void btnMaquina_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqMaquina frm = new frmBusqMaquina();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.EstructuraForm.StrX.Insert(0, sCompania);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.CodMaquina = fnConvert.ObjectToEntity<entMaquina>(frm.EstructuraForm.ObjX)[0].Maquina;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["CodMaquina"];
            }
            objE = null;
            frm = null;
        }
        
        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.Cuenta = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0].Cuenta;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["Cuenta"];                
            }
            objE = null;
            frm = null;
        }
        
        private void btnPersona_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqPersona frm = new frmBusqPersona();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.Compania = sCompania;
            frm.VerEmpleado = true;
            frm.VerCliente = true;
            frm.VerProveedor = true;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.Persona = fnConvert.ObjectToEntity<entPersona>(frm.EstructuraForm.ObjX)[0].Persona;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["Persona"];
            }
            objE = null;
            frm = null;
        }
        
        private void btnCCosto_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqCentroCosto frm = new frmBusqCentroCosto();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.EstructuraForm.StrX.Insert(0, sCompania);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.CentroCosto = fnConvert.ObjectToEntity<entCentroCosto>(frm.EstructuraForm.ObjX)[0].CentroCosto;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["CentroCosto"];
            }
            objE = null;
            frm = null;
        }
        
        private void btnFlujoCaja_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqFlujoCaja frm = new frmBusqFlujoCaja();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.FlujoCaja = fnConvert.ObjectToEntity<entFlujoCaja>(frm.EstructuraForm.ObjX)[0].FlujoCaja;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["FlujoCaja"];
            }
            objE = null;
            frm = null;
        }
        
        private void btnDocumento_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            if (objE.OrigenDoc.Equals("MN"))
            {
                fnMensaje.MensajeInfo("Esta opción sólo puede utilizarse para buscar documentos de origen diferente de manual.");
                objE = null;
                return;
            }
            
            if (objE.Persona == 0)
            {
                fnMensaje.MensajeInfo("Primero debe ingresar un código de persona válido.");
                objE = null;
                return;
            }
            
            frmBusqObligacion frm = new frmBusqObligacion();
            frm.Compania = sCompania;
            frm.Proveedor = objE.Persona;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                entObligacion objX = fnConvert.ObjectToEntity<entObligacion>(frm.EstructuraForm.ObjX)[0];
                objE.CodigoDoc = objX.Obligacion;
                objE.Documento = objX.DocumentoCompleto;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["Documento"];
                objX = null;
            }
            objE = null;
            frm = null;
        }
        
        private void btnProyecto_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            frmBusqProyecto frm = new frmBusqProyecto();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.EstructuraForm.StrX.Insert(0, sCompania);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                objE.Proyecto = fnConvert.ObjectToEntity<entProyecto>(frm.EstructuraForm.ObjX)[0].ProyectoCodigo;
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["Proyecto"];
            }
            objE = null;
            frm = null;
        }
        
        private void btnOC_Click(object sender, EventArgs e)
        {
            if (gvDetalle.RowCount == 0)
            {
                return;
            }
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            
            frmBusqImportacion frm = new frmBusqImportacion();
            frm.Compania = sCompania;
            frm.MultipleSelect = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                entOrdenes objX = fnConvert.ObjectToEntity<entOrdenes>(frm.EstructuraForm.ObjX)[0];
                objE.OrdenCompra = objX.NumeroOrden;
                objE.Secuencia_OC = objX.Ampliacion;
                objE.OCompraID = objX.NumeroOrden + "-" + objX.Ampliacion.ToString();
                objE.RegEditado = fnEnum.RegEditado.Si;
                gvDetalle.UpdateCurrentRow();
                gvDetalle.Focus();
                gvDetalle.FocusedColumn = gvDetalle.Columns["OCompraID"];
                objX = null;
            }
            objE = null;
            frm = null;
        }
        
        private void btnModelo_Click(object sender, EventArgs e)
        {
            String sMoneda = "";
            Decimal nTipoCambio = 0;
            int nLinea = 1;
            Decimal nMonto = 0, nMontoLocal = 0, nMontoExt = 0;            
            if (!(Operacion.Equals("M") || Operacion.Equals("A")))
            {
                return;
            }
            if (MessageBox.Show("Esta opción eliminará la información actual, ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            
            frmBusqAsientoModelo frm = new frmBusqAsientoModelo();
            frm.Compania = sCompania;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LstDetVoucher.RemoveAll(x => x.Linea != 0);
                sMoneda = cmbMoneda.EditValue.ToString();
                nTipoCambio = Decimal.Parse(txtTC.Text);
                
                List<entAsientoModeloDet> Lst = fnConvert.ObjectToEntity<entAsientoModeloDet>(frm.EstructuraForm.ObjX);
                foreach (entAsientoModeloDet objX in Lst)
                {
                    nMonto = objX.Monto;
                    nMontoLocal = 0;
                    nMontoExt = 0;
                    if (sMoneda.Equals("L"))
                    {
                        nMontoLocal = nMonto;
                        if (nTipoCambio > 0)
                            nMontoExt = Math.Round(nMonto / nTipoCambio, 2);
                    }
                    else
                    {
                        nMontoExt = nMonto;
                        if (nTipoCambio > 0)
                            nMontoLocal = Math.Round(nMonto * nTipoCambio, 2);
                    }
                    
                    entVoucherDet objE = new entVoucherDet();
                    objE.Compania = sCompania;
                    objE.Periodo = sPeriodo;
                    objE.TipoVoucher = sTipoVoucher;
                    objE.NumeroVoucher = sNumeroVoucher;
                    objE.Linea = nLinea;
                    objE.Cuenta = objX.Cuenta;
                    objE.CentroCosto = objX.CentroCosto;
                    objE.Persona = objX.Persona;
                    objE.OrigenDoc = "MN";
                    objE.Documento = objX.Documento;
                    objE.Descripcion = objX.Descripcion;
                    objE.MontoLocal = nMontoLocal;
                    objE.MontoExt = nMontoExt;
                    objE.RegEditado = fnEnum.RegEditado.Si;
                    LstDetVoucher.Add(objE);
                    objE = null;
                    nLinea++;
                }
                Lst = null;
            }
            fxLinkDet();
            frm = null;
        }
        
        private void btnImportar_Click(object sender, EventArgs e)
        {
        }
        
        private void gvDetalle_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            String sColumn = e.Column.Name;
            switch (sColumn)
            {
                case "Persona":
                    if ((Int32)e.Value == 0)
                    {
                        e.DisplayText = "";
                    }
                    break;
            }
        }
        
        private void gvDetalle_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridSummaryItem xColumn = (GridSummaryItem)e.Item;
            GridView view = (GridView)sender;
            
            //Inicio Variables
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
            {
                nTotalDebeLoc = 0;
                nTotalDebeExt = 0;
                nTotalHaberLoc = 0;
                nTotalHaberExt = 0;
                nSaldoLoc = 0;
                nSaldoExt = 0;
            }
            
            //Calculado
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                Decimal xMonLoc = (Decimal)view.GetRowCellValue(e.RowHandle, "MontoLocal");
                Decimal xMonExt = (Decimal)view.GetRowCellValue(e.RowHandle, "MontoExt");
                
                if (xMonLoc > 0)
                    nTotalDebeLoc = nTotalDebeLoc + xMonLoc;
                if (xMonExt > 0)
                    nTotalDebeExt = nTotalDebeExt + xMonExt;
                if (xMonLoc < 0)
                    nTotalHaberLoc = nTotalHaberLoc + xMonLoc;
                if (xMonExt < 0)
                    nTotalHaberExt = nTotalHaberExt + xMonExt;
                
                nSaldoLoc = nSaldoLoc + xMonLoc;
                nSaldoExt = nSaldoExt + xMonExt;
            }
            
            //Finaliacion
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                switch (xColumn.FieldName)
                {
                    case "MontoLocal":
                        e.TotalValue = nTotalDebeLoc.ToString("N2") + "\n\r" + nTotalDebeExt.ToString("N2");
                        break;
                    case "MontoExt":
                        e.TotalValue = nTotalHaberLoc.ToString("N2") + "\n\r" + nTotalHaberExt.ToString("N2");
                        break;
                    case "Fecha":
                        e.TotalValue = nSaldoLoc.ToString("N2") + "\n\r" + nSaldoExt.ToString("N2");
                        break;
                    case "Documento":
                        e.TotalValue = "Total Loc\n\rTotal Ext:";
                        break;
                }
            }
        }
        
        private void gvDetalle_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            int nHeight = (e.Bounds.Height * 2) - 10;
            
            if (e.Column.FieldName == "Documento")
            {
                e.Info.Appearance.BackColor = Color.Transparent;
                e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                e.Info.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                e.Info.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                Rectangle r = new Rectangle(e.Info.Bounds.Left, e.Info.Bounds.Top, e.Info.Bounds.Width, nHeight);
                e.Info.BackAppearance.DrawString(e.Cache, e.Info.DisplayText, r);
            }
            else
            {
                e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                e.Info.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.White, Color.White, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                Rectangle r = e.Bounds;
                r.Height = nHeight;
                ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.Etched);
                r.Inflate(-1, -1);
                e.Graphics.FillRectangle(brush, r);
                r.Inflate(-2, 0);
                e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
            }
            e.Handled = true;
        }
        
        private void gvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            entVoucherDet objE = (entVoucherDet)gvDetalle.GetRow(gvDetalle.FocusedRowHandle);
            objE.RegEditado = fnEnum.RegEditado.Si;
            gvDetalle.UpdateCurrentRow();
            objE = null;
        }
        
        private void gvDetalle_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colCuenta = view.Columns["Cuenta"];
            GridColumn colPerson = view.Columns["Persona"];
            GridColumn colMaquin = view.Columns["CodMaquina"];
            GridColumn colCCosto = view.Columns["CentroCosto"];
            GridColumn colFlCaja = view.Columns["FlujoCaja"];
            
            String sCuenta = (String)view.GetRowCellValue(e.RowHandle, colCuenta);
            Int32 nPerson = (Int32)view.GetRowCellValue(e.RowHandle, colPerson);
            String sMaquin = (String)view.GetRowCellValue(e.RowHandle, colMaquin);
            String sCCosto = (String)view.GetRowCellValue(e.RowHandle, colCCosto);
            String sFlCaja = (String)view.GetRowCellValue(e.RowHandle, colFlCaja);
            
            view.SetColumnError(colCuenta, String.Empty);
            view.SetColumnError(colPerson, String.Empty);
            view.SetColumnError(colMaquin, String.Empty);
            view.SetColumnError(colCCosto, String.Empty);
            view.SetColumnError(colFlCaja, String.Empty);
            
            //Cuenta
            if (!String.IsNullOrEmpty(sCuenta))
            {
                entCuentaContable objCta = negCuentaContable.GetFormID(sCuenta);
                if (!objCta.ResultadoBusqueda || !objCta.Estado.Equals("A"))
                {
                    e.Valid = false;
                    view.SetColumnError(colCuenta, "Cuenta contable ingresada es inválida.");
                }
                objCta = null;
            }
            
            //Persona
            if (nPerson != 0)
            {
                entPersona objPer = negPersona.GetPersonaFormID(Compania, nPerson);
                if (!objPer.ResultadoBusqueda || !objPer.Estado.Equals("A"))
                {
                    e.Valid = false;
                    view.SetColumnError(colPerson, "Persona ingresada es inválida.");
                }
                objPer = null;
            }
            
            //Centro Costo
            if (!String.IsNullOrEmpty(sCCosto))
            {
                entCentroCosto objCos = negCentroCosto.GetCentroCostoFormID(Compania, sCCosto);
                if (!objCos.ResultadoBusqueda || !objCos.Estado.Equals("A"))
                {
                    e.Valid = false;
                    view.SetColumnError(colCCosto, "Centro de costo ingresado es inválido.");
                }
                objCos = null;
            }
            
            //Flujo Caja
            if (!String.IsNullOrEmpty(sFlCaja))
            {
                entFlujoCaja objFcj = negFlujoCaja.GetFlujoCajaFormID(sFlCaja);
                if (!objFcj.ResultadoBusqueda || !objFcj.Estado.Equals("A"))
                {
                    e.Valid = false;
                    view.SetColumnError(colFlCaja, "Flujo de caja ingresado es inválido.");
                }
                objFcj = null;
            }
            
            //Maquina
            if (!String.IsNullOrEmpty(sMaquin))
            {
                entMaquina objMaq = negMaquina.GetMaquinaFormID(Compania, sMaquin);
                if (!objMaq.ResultadoBusqueda || !objMaq.Estado.Equals("A"))
                {
                    e.Valid = false;
                    view.SetColumnError(colFlCaja, "Flujo de caja ingresado es inválido.");
                }
                objMaq = null;
            }
        }
        
        private void gvDetalle_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
        
        private void gvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            String sNameCol = "";
            if (e.KeyCode == Keys.F1)
            {
                if (!(Operacion.Equals("M") || Operacion.Equals("A")))
                {
                    return;
                }
                if (gvDetalle.FocusedRowHandle >= 0)
                {
                    sNameCol = gvDetalle.FocusedColumn.Name;
                    EventArgs EventClick = new EventArgs();
                    switch (sNameCol)
                    {
                        case "Cuenta":
                            btnCuenta_Click(sender, EventClick);
                            break;
                        case "Persona":
                            btnPersona_Click(sender, EventClick);
                            break;
                        case "CentroCosto":
                            btnCCosto_Click(sender, EventClick);
                            break;
                        case "FlujoCaja":
                            btnFlujoCaja_Click(sender, EventClick);
                            break;
                        case "Proyecto":
                            btnProyecto_Click(sender, EventClick);
                            break;
                        case "Documento":
                            btnDocumento_Click(sender, EventClick);
                            break;
                        case "CodMaquina":
                            btnMaquina_Click(sender, EventClick);
                            break;
                        case "OCompraID":
                            btnOC_Click(sender, EventClick);
                            break;
                    }
                    EventClick = null;
                }
            }
        }
        
        #endregion
        
        #region "==FuncionesForm=="
        
        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListCompaniaForm(fnConst.StringT, fnConst.StringT, fnConst.StringPorc);
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;
            
            //Departamento
            List<entDepartCia> LstB = negDepartCia.ListaCombo(sCompania, fnConst.StringA, new String[] { fnConst.TextRaya3, fnConst.TextSeleccioneNom });
            cmbDepartamento.Properties.DataSource = LstB;
            cmbDepartamento.Properties.DisplayMember = "Descripcion";
            cmbDepartamento.Properties.ValueMember = "DepartamentoCiaCodigo";
            LstB = null;
            
            //TipoVoucher
            List<entTipoVoucher> LstC = negTipoVoucher.ListaCombo(fnConst.StringPorc, fnConst.StringN, fnConst.StringPorc, new String[] { fnConst.TextSeleccioneNomF2, fnConst.TextSeleccioneNomF2 });
            cmbTipoVoucher.Properties.DataSource = LstC;
            cmbTipoVoucher.Properties.DisplayMember = "TipoVoucher";
            cmbTipoVoucher.Properties.ValueMember = "TipoVoucher";            
            LstC = null;
            
            //Estado
            List<entComboList> LstD = new List<entComboList>();
            LstD.Add(new entComboList() { Codigo = fnConst.EstadoRegAprobadoCod, Nombre = fnConst.EstadoRegAprobadoNom });
            LstD.Add(new entComboList() { Codigo = fnConst.EstadoRegAnuladoCod, Nombre = fnConst.EstadoRegAnuladoNom });
            LstD.Add(new entComboList() { Codigo = fnConst.EstadoRegPendienteCod, Nombre = fnConst.EstadoRegPendienteNom });
            cmbEstado.Properties.DataSource = LstD;
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
            LstD = null;
            
            //Origen
            List<entComboList> LstE = new List<entComboList>();
            LstE.Add(new entComboList() { Codigo = fnConst.TextSeleccioneCod, Nombre = fnConst.TextSeleccioneNomF2 });
            LstE.Add(new entComboList() { Codigo = fnConst.ManualMNCod, Nombre = fnConst.ManualMNNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModActivoFijoCod, Nombre = fnConst.ModActivoFijoNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModComercialCod, Nombre = fnConst.ModComercialNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModContabilidadCod, Nombre = fnConst.ModContabilidadNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModLogisticaCod, Nombre = fnConst.ModLogisticaNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModProduccionCod, Nombre = fnConst.ModProduccionNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModRRHHCod, Nombre = fnConst.ModRRHHNom });
            LstE.Add(new entComboList() { Codigo = fnConst.ModTesoreriaCod, Nombre = fnConst.ModTesoreriaNom });
            cmbOrigen.Properties.DataSource = LstE;
            cmbOrigen.Properties.DisplayMember = "Nombre";
            cmbOrigen.Properties.ValueMember = "Codigo";
            LstE = null;
            
            //Moneda
            List<entComboList> LstF = new List<entComboList>();
            LstF.Add(new entComboList() { Codigo = fnConst.TextSeleccioneCod, Nombre = fnConst.TextSeleccioneNomF2 });
            LstF.Add(new entComboList() { Codigo = fnConst.MonedaLocalCod, Nombre = fnConst.MonedaLocalNom });
            LstF.Add(new entComboList() { Codigo = fnConst.MonedaExtCod, Nombre = fnConst.MonedaExtNom });
            cmbMoneda.Properties.DataSource = LstF;
            cmbMoneda.Properties.DisplayMember = "Nombre";
            cmbMoneda.Properties.ValueMember = "Codigo";
            LstF = null;
        }
        
        private void fxCargarCombosDetalle()
        {
            //Origen
            List<entComboList> LstA = new List<entComboList>();
            LstA.Add(new entComboList() { Codigo = fnConst.ModTesoreriaCod, Nombre = fnConst.ModTesoreriaNom });
            LstA.Add(new entComboList() { Codigo = fnConst.ManualMNCod, Nombre = fnConst.ManualMNNom });
            
            riluOrigen.DataSource = LstA;
            riluOrigen.DisplayMember = "Nombre";
            riluOrigen.ValueMember = "Codigo";
            LstA = null;
        }
        
        private void fxPreOpen()
        {
            String sTitle = "";
            Copia = "N";
            
            switch (Operacion)
            {
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
                case "AN":
                    sTitle = " - Anular";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "AP":
                    sTitle = " - Aprobar";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "PE":
                    sTitle = " - Pasar Pendiente";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "CP":
                    sTitle = " - Copiar";
                    Copia = "S";
                    fxCargarReg();
                    fxHabilitarOCX();
                    fxCopiarReg();
                    break;
            }
            this.Text = this.Text + sTitle;
        }
        
        private void fxPostOpen()
        {
            if (Operacion.Equals("PE"))
            {
                LstDetVoucher.RemoveAll(p => p.FlagAutomatico.Equals("S"));
                fxLinkDet();
            }
        }
        
        private void fxNuevoReg()
        {
            String sPerTrab = negPeriodoCia.GetPerTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
            String sPerHoy = fnGeneral.FormatoDateTime(DateTime.Now, fnEnum.FormatFecha.FechaPeriodo);
            String sPerTemp = "";
            DateTime dFecha = DateTime.MinValue;
            
            if (sPerTrab.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("No se pudo obtener periodo de trabajo actual. Asignar uno válido.");
                this.Close();
            }
            
            cmbCompania.EditValue = Compania;
            txtPeriodo.Text = sPerTrab;
            cmbDepartamento.EditValue = fnConst.TextRaya3;
            cmbEstado.EditValue = fnConst.EstadoRegPendienteCod;
            txtDescripcion.Text = String.Empty;
            cmbTipoVoucher.EditValue = fnConst.TextSeleccioneNomF2;
            txtNroVoucher.Text = String.Empty;
            cmbMoneda.EditValue = fnConst.MonedaLocalCod;
            txtFecha.DateTime = DateTime.Now;
            //txtTC.Text = "0.000";
            txtUserRegistro.Text = GlobalVar.UsuarioLogeo;
            txtFechaRegistro.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtUserAprob.Text = String.Empty;
            txtFechaAprob.Text = String.Empty;
            cmbOrigen.EditValue = fnConst.ManualMNCod;
            chkModManual.Checked = true;
            chkModRestringida.Checked = false;
            
            oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            Operacion = "A";
            Periodo = String.Empty;
            TipoVoucher = String.Empty;
            NumeroVoucher = String.Empty;
            
            entParametro oEntA = new entParametro();
            //Tipo Voucher
            oEntA = negParametro.GetFormID(Compania, fnConst.ModContabilidadCod, "TVOUCHER");
            if (oEntA.ResultadoBusqueda && oEntA.Estado.Equals("A"))
            {
                String sTipoVo = oEntA.Texto;
                entTipoVoucher oEntB = negTipoVoucher.GetFormID(sTipoVo);
                if (oEntB.ResultadoBusqueda && oEntB.Equals("A"))
                {
                    cmbTipoVoucher.EditValue = sTipoVo;
                    oEntVoucher.NumeroManual = oEntB.CorrelativoManual;
                }
                oEntB = null;
            }
            
            //Departamento
            String sDepart = "";
            oEntA = negParametro.GetFormID(Compania, fnConst.ModContabilidadCod, "DVOUCHER");
            if (oEntA.ResultadoBusqueda && oEntA.Estado.Equals("A"))
            {
                sDepart = oEntA.Texto;
                cmbDepartamento.EditValue = sDepart;
            }
            
            //Moneda
            String sMoneda = fnConst.MonedaLocalCod;
            oEntA = negParametro.GetFormID(Compania, fnConst.ModContabilidadCod, "MVOUCHER");
            if (oEntA.ResultadoBusqueda && oEntA.Estado.Equals("A"))
            {
                sMoneda = oEntA.Texto;
                cmbMoneda.EditValue = sMoneda;
            }
            
            if (!sPerTrab.Equals(sPerHoy))
            {
                if (String.Compare(sPerTrab, sPerHoy) > 0)
                {
                    dFecha = new DateTime(int.Parse(sPerTrab.Substring(0, 4)), int.Parse(sPerTrab.Substring(4, 2)), 1);
                }
                else
                {
                    sPerTemp = sPerTrab;
                    dFecha = new DateTime(int.Parse(sPerTrab.Substring(0, 4)), int.Parse(sPerTrab.Substring(4, 2)), 1).AddMonths(1).AddDays(-1);
                }
            }
            else
            {
                dFecha = DateTime.Now;
            }
            
            Decimal nTC = negTipoCambio.GetTipoCambioXTipo(dFecha, "V");
            txtFecha.DateTime = dFecha;
            txtTC.Text = nTC.ToString("N3");
            
            //Tipo Cambio
            if (Copia.Equals("N"))
            {
                chkConvAutomatica.Checked = true;
            }
            
            //Lista Detalle            
            fxConvertirDetalle(sMoneda, nTC);
            txtFecha.Focus();
            oEntA = null;
        }
        
        private void fxCargarReg()
        {
            oEntVoucher = negVoucher.GetVoucherFormID(Compania, Periodo, TipoVoucher, NumeroVoucher);
            oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (oEntVoucher.ResultadoBusqueda)
            {
                cmbCompania.EditValue = oEntVoucher.Compania;
                txtPeriodo.Text = oEntVoucher.Periodo;
                cmbDepartamento.EditValue = oEntVoucher.Departamento;
                cmbEstado.EditValue = oEntVoucher.Estado;
                txtDescripcion.Text = oEntVoucher.Descripcion;
                cmbTipoVoucher.EditValue = oEntVoucher.TipoVoucher;
                txtNroVoucher.Text = oEntVoucher.NumeroVoucher;
                cmbMoneda.EditValue = oEntVoucher.Moneda;
                txtFecha.DateTime = oEntVoucher.Fecha;
                txtTC.Text = oEntVoucher.TipoCambio.ToString("N3");
                txtUserRegistro.Text = oEntVoucher.UsuarioRegistro;
                txtFechaRegistro.Text = fnGeneral.FormatoDateTime(oEntVoucher.FechaRegistro);
                txtUserAprob.Text = oEntVoucher.UsuarioAprobacion;
                txtFechaAprob.Text = fnGeneral.FormatoDateTime(oEntVoucher.FechaAprobacion);
                cmbOrigen.EditValue = oEntVoucher.Origen;
                chkModManual.Checked = (oEntVoucher.FlagModManual.Equals("S")) ? true : false;
                chkModRestringida.Checked = (oEntVoucher.FlagModRestringida.Equals("S")) ? true : false;
            }
            fxCargarDet();
        }
        
        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (Operacion.Equals("A") || Operacion.Equals("M") || Operacion.Equals("CP"))
            {
                sHabilitado = true;
            }
            
            cmbCompania.ReadOnly = true;
            cmbEstado.ReadOnly = true;
            cmbOrigen.ReadOnly = true;
            chkModRestringida.ReadOnly = true;
            chkModManual.ReadOnly = true;
            txtUserRegistro.ReadOnly = true;
            txtFechaRegistro.ReadOnly = true;
            txtUserAprob.ReadOnly = true;
            txtFechaAprob.ReadOnly = true;
            txtNroVoucher.ReadOnly = true;
            
            cmbTipoVoucher.ReadOnly = !sHabilitado;            
            txtPeriodo.ReadOnly = !sHabilitado;
            cmbDepartamento.ReadOnly = !sHabilitado;
            cmbMoneda.ReadOnly = !sHabilitado;
            txtFecha.ReadOnly = !sHabilitado;
            txtTC.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            chkConvAutomatica.ReadOnly = !sHabilitado;
            
            btnAgregar.Enabled = sHabilitado;
            btnEliminar.Enabled = sHabilitado;
            btnMaquina.Enabled = sHabilitado;
            btnCuenta.Enabled = sHabilitado;
            btnPersona.Enabled = sHabilitado;
            btnCCosto.Enabled = sHabilitado;
            btnFlujoCaja.Enabled = sHabilitado;
            btnDocumento.Enabled = sHabilitado;
            btnProyecto.Enabled = sHabilitado;
            btnOC.Enabled = sHabilitado;
            btnModelo.Enabled = sHabilitado;
            btnImportar.Enabled = sHabilitado;
            
            gvDetalle.OptionsBehavior.Editable = sHabilitado;
            gvDetalle.OptionsBehavior.ReadOnly = !sHabilitado;
            
            if (sOperacion.Equals("M"))
            {
                cmbTipoVoucher.ReadOnly = true;
                txtPeriodo.ReadOnly = true;
            }
        }
        
        private void fxCopiarReg()
        {
            String sPerTrab = negPeriodoCia.GetPerTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
            String sPerHoy = fnGeneral.FormatoDateTime(DateTime.Now, fnEnum.FormatFecha.FechaPeriodo);
            String sPerTemp = "";
            DateTime dFecha = DateTime.MinValue;
            
            if (sPerTrab.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("No se pudo obtener periodo de trabajo actual. Asignar uno válido.");
                this.Close();
            }
            
            txtNroVoucher.Text = String.Empty;
            txtPeriodo.Text = sPerTrab;
            cmbEstado.EditValue = fnConst.EstadoRegPendienteCod;
            chkModManual.Checked = true;
            cmbOrigen.EditValue = fnConst.ManualMNCod;
            chkModManual.Checked = true;
            chkModRestringida.Checked = false;
            txtUserRegistro.Text = GlobalVar.UsuarioLogeo;
            txtFechaRegistro.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtUserAprob.Text = String.Empty;
            txtFechaAprob.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            
            //Departamento
            String sDepart = "";
            entParametro oEntA = negParametro.GetFormID(Compania, fnConst.ModContabilidadCod, "DVOUCHER");
            if (oEntA.ResultadoBusqueda && oEntA.Estado.Equals("A"))
            {
                sDepart = oEntA.Texto;
                cmbDepartamento.EditValue = sDepart;
            }
            
            txtFecha.DateTime = DateTime.Now;
            txtTC.Text = "0.000";
            
            if (!sPerTrab.Equals(sPerHoy))
            {
                if (String.Compare(sPerTrab, sPerHoy) > 0)
                {
                    dFecha = new DateTime(int.Parse(sPerTrab.Substring(0, 4)), int.Parse(sPerTrab.Substring(4, 2)), 1);
                }
                else
                {
                    sPerTemp = sPerTrab;
                    dFecha = new DateTime(int.Parse(sPerTrab.Substring(0, 4)), int.Parse(sPerTrab.Substring(4, 2)), 1).AddMonths(1).AddDays(-1);
                }
            }
            else
            {
                dFecha = DateTime.Now;
            }
            
            Decimal nTC = negTipoCambio.GetTipoCambioXTipo(dFecha, "V");
            txtFecha.DateTime = dFecha;
            txtTC.Text = nTC.ToString("N3");
            
            chkConvAutomatica.Checked = false;
            foreach (entVoucherDet oEnt in LstDetVoucher)
            {
                oEnt.Periodo = String.Empty;
                oEnt.TipoVoucher = String.Empty;
                oEnt.NumeroVoucher = String.Empty;
                oEnt.UltimoUsuarioMod = String.Empty;
                oEnt.UltimaFechaMod = DateTime.MinValue;
            }
            Periodo = String.Empty;
            TipoVoucher = String.Empty;
            NumeroVoucher = String.Empty;
            Operacion = "A";
        }
        
        private void fxQuitEvent()
        {
            this.cmbTipoVoucher.EditValueChanged -= new EventHandler(cmbTipoVoucher_EditValueChanged);
            this.cmbMoneda.EditValueChanged -= new EventHandler(cmbMoneda_EditValueChanged);
            this.chkConvAutomatica.CheckedChanged -= new EventHandler(chkConvAutomatica_CheckedChanged);
            this.txtFecha.EditValueChanged -= new EventHandler(txtFecha_EditValueChanged);
        }
        
        private void fxAddEvent()
        {
            this.cmbTipoVoucher.EditValueChanged += new EventHandler(cmbTipoVoucher_EditValueChanged);
            this.cmbMoneda.EditValueChanged += new EventHandler(cmbMoneda_EditValueChanged);
            this.chkConvAutomatica.CheckedChanged += new EventHandler(chkConvAutomatica_CheckedChanged);            
            this.txtFecha.EditValueChanged += new EventHandler(txtFecha_EditValueChanged);
        }
        
        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Replace("-", "");
            String sTipoVO = cmbTipoVoucher.EditValue.ToString();
            String sNumeVO = txtNroVoucher.Text;
            String sDepart = cmbDepartamento.EditValue.ToString();
            String sMoneda = cmbMoneda.EditValue.ToString();
            String sOrigen = cmbOrigen.EditValue.ToString();
            String sModMan = (chkModManual.Checked) ? "S" : "N";
            String sModRes = (chkModRestringida.Checked) ? "S" : "N";
            String sEstado = cmbEstado.EditValue.ToString();
            String sDescri = txtDescripcion.Text.Trim();
            Decimal nTcamb = 0;
            Decimal.TryParse(txtTC.Text, out nTcamb);
            DateTime dFecha = txtFecha.DateTime;
            
            //Revisando código de compañía
            if (sCia.Equals(fnConst.StringN))
            {
                fnMensaje.MensajeInfo("Debe ingresar el código de compañía.");
                cmbCompania.Focus();
                return bOk;
            }
            
            //Revisando periodo de voucher
            if (sPer.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                txtPeriodo.Focus();
                return bOk;
            }
            
            Int32 nResult = negPeriodoCia.GetValidaPeriodoCia(fnConst.ModContabilidadCod, sCia, sPer);
            if (nResult <= 0)
            {
                if (Operacion.Equals("AN"))
                {
                    String sEstVo = negVoucher.GetEstadoVoucher(sCia, sPer, sTipoVoucher, sNumeroVoucher);
                    if (!sEstVo.Equals("PE"))
                    {
                        fnMensaje.MensajeInfo("Periodo es inválido o se encuentra cerrado.");
                        txtPeriodo.Focus();
                        return bOk;
                    }
                }
                else
                {
                    fnMensaje.MensajeInfo("Periodo es inválido o se encuentra cerrado.");
                    txtPeriodo.Focus();
                    return bOk;
                }
            }
            
            entPeriodoCia EPeri = negPeriodoCia.GetFormID(sCia, sPer, fnConst.ModContabilidadCod);
            if (EPeri.ResultadoBusqueda)
            {
                if (EPeri.FlagBloqueo.Equals("S"))
                {
                    fnMensaje.MensajeInfo("Periodo se encuentra Bloqueado");
                    return bOk;
                }
            }
            EPeri = null;
            
            //Revisando departamento
            if (sDepart.Equals(fnConst.TextRaya3))
            {
                fnMensaje.MensajeInfo("Debe ingresar un departamento válido.");
                cmbDepartamento.Focus();
                return bOk;
            }
            
            //Revisando tipo voucher
            if (sTipoVO.Equals(fnConst.TextSeleccioneNomF2))
            {
                fnMensaje.MensajeInfo("Debe ingresar un tipo de voucher.");
                cmbTipoVoucher.Focus();
                return bOk;
            }
            
            //Revisando Moneda
            if (sMoneda.Equals(fnConst.TextSeleccioneCod))
            {
                fnMensaje.MensajeInfo("Debe ingresar una moneda para el voucher.");
                cmbMoneda.Focus();
                return bOk;
            }
            
            //Revisando tipo de cambio
            if (nTcamb <= 0)
            {
                fnMensaje.MensajeInfo("Debe ingresar un tipo de cambio válido.");
                txtTC.Focus();
                return bOk;
            }
            
            //Revisando fecha
            if (dFecha == DateTime.MinValue)
            {
                fnMensaje.MensajeInfo("Debe ingresar una fecha.");
                txtFecha.Focus();
                return bOk;
            }
            
            String sPerTmp = String.Format("{0:yyyyMM}", dFecha);
            if (!sPer.Equals(sPerTmp))
            {
                fnMensaje.MensajeInfo("Fecha debe pertenecer al periodo registrado.");
                txtFecha.Focus();
                return bOk;
            }
            
            //Revisando Descripcion
            if (sDescri.Equals(String.Empty))
            {
                fnMensaje.MensajeInfo("Debe ingresar una descripción.");
                txtDescripcion.Focus();
                return bOk;
            }
            
            //Fecha Servidor
            DateTime dFechaServ = negGeneral.GetFechaServidor();
            
            //Correlativo Voucher
            if (Operacion.Equals("A"))
            {
                txtUserRegistro.Text = GlobalVar.UsuarioLogeo;
                txtFechaRegistro.Text = fnGeneral.FormatoDateTime(dFechaServ);
                
                oEntVoucher.UsuarioRegistro = GlobalVar.UsuarioLogeo;
                oEntVoucher.FechaRegistro = dFechaServ;
                
                Periodo = sPer;
                TipoVoucher = sTipoVO;
            }
            
            //Ingresar Detalle
            if (LstDetVoucher.Count == 0)
            {
                fnMensaje.MensajeInfo("Debe ingresar el detalle del voucher. No se puede continuar.");
                return bOk;
            }
            
            if (!Operacion.Equals("AP"))
            {
                if (Operacion.Equals("PE"))
                {
                    sEstado = "PE";
                    txtUserAprob.Text = String.Empty;
                    txtFechaAprob.Text = String.Empty;
                    oEntVoucher.UsuarioAprobacion = String.Empty;
                    oEntVoucher.FechaAprobacion = DateTime.MinValue;
                }
                
                if (Operacion.Equals("AN"))
                {
                    sEstado = "AN";
                }
                
                oEntVoucher.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
                oEntVoucher.UltimaFechaMod = dFechaServ;
            }
            
            cmbEstado.EditValue = sEstado;
            
            //Actualizando Datos Entidad
            oEntVoucher.Compania = sCia;
            oEntVoucher.Periodo = sPer;
            oEntVoucher.TipoVoucher = sTipoVO;
            oEntVoucher.NumeroVoucher = sNumeVO;
            oEntVoucher.Departamento = sDepart;
            oEntVoucher.Moneda = sMoneda;
            oEntVoucher.Fecha = txtFecha.DateTime;
            oEntVoucher.TipoCambio = nTcamb;
            oEntVoucher.Descripcion = sDescri;
            oEntVoucher.Origen = sOrigen;
            oEntVoucher.FlagModManual = sModMan;
            oEntVoucher.FlagModRestringida = sModRes;
            oEntVoucher.Estado = sEstado;
            oEntVoucher.UsuarioSys = GlobalVar.UsuarioLogeo;
            oEntVoucher.DetalleVoucher = LstDetVoucher;
            
            bOk = true;
            return bOk;
        }
        
        private Boolean fxPreUpdate()
        {
            entErrores oErr = new entErrores();
            Boolean bOK = true;
            
            switch (Operacion)
            {
                case "A":
                    oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Insertar;
                    break;
                case "M":
                case "AN":
                    oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                    break;
                case "AP":
                    oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Aprobar;
                    break;
                case "PE":
                    oEntVoucher.OperMantenimiento = fnEnum.OperacionMant.Pendiente;
                    break;
            }
            
            oErr = negVoucher.MantVoucher(oEntVoucher);
            NumeroVoucher = oErr.CodigoGeneradoText;
            if (oErr.Errores.Count > 0)
            {
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
                bOK = false;
            }
            oErr = null;
            return bOK;
        }
        
        private void fxPostUpdate()
        {
            String sMensaje = "";
            
            switch (Operacion)
            {
                case "A":
                    Operacion = "M";
                    txtNroVoucher.Text = NumeroVoucher;
                    sMensaje = "creó";
                    break;
                case "M":
                    sMensaje = "guardó";
                    break;
                case "AN":
                    sMensaje = "anuló";
                    break;
                case "AP":
                    sMensaje = "aprobó";
                    break;
                case "PE":
                    sMensaje = "paso a pendiente";
                    break;
            }
            
            if (Operacion.Equals("AP") || Operacion.Equals("PE"))
            {
                fxCargarReg();
                fxCargarDet();
            }
            
            sMensaje = "Se " + sMensaje + " el voucher " + TipoVoucher + "-" + NumeroVoucher + " satisfactoriamente";
            fnMensaje.MensajeInfo(sMensaje);
            
            /*if (Operacion.Equals("A") || Operacion.Equals("M")) {
            Operacion = "V";               
            fxPreOpen();                
            }*/
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        
        #endregion
        
        #region "==FuncionesDet=="
        
        private void fxCargarDet()
        {
            LstDetVoucher = negVoucher.GetVoucherFormIDDet(Compania, Periodo, TipoVoucher, NumeroVoucher);
            fxLinkDet();
        }
        
        private void fxLinkDet()
        {
            grControl.DataSource = null;
            if (LstDetVoucher.Count > 0)
            {
                grControl.DataSource = LstDetVoucher;
            }
        }
        
        private void fxSetearLinea()
        {
            int nLin = 1;
            foreach (entVoucherDet oEnt in LstDetVoucher)
            {
                oEnt.Linea = nLin;
                nLin++;
            }
            grControl.Refresh();
        }
        
        private void fxEliminarDet()
        {
            LstDetVoucher.RemoveAll(x => x.Linea >= -1);
            fxLinkDet();           
        }
        
        private void fxConvertirDetalle(String sMoneda, Decimal nTipoCambio)
        {
            Decimal nMonto = 0;
            
            if (sMoneda.Equals("L"))
            {
                gvDetalle.Columns["MontoLocal"].ColumnEdit.ReadOnly = false;
                gvDetalle.Columns["MontoExt"].ColumnEdit.ReadOnly = true;
            }
            else
            {
                gvDetalle.Columns["MontoLocal"].ColumnEdit.ReadOnly = true;
                gvDetalle.Columns["MontoExt"].ColumnEdit.ReadOnly = false;
            }
            
            foreach (entVoucherDet oEnt in LstDetVoucher)
            {
                if (sMoneda.Equals("L"))
                {
                    nMonto = oEnt.MontoLocal;
                    nMonto = (nTipoCambio <= 0) ? 0 : Math.Round(nMonto / nTipoCambio, 2);
                    oEnt.MontoExt = nMonto;
                }
                else
                {
                    nMonto = oEnt.MontoExt;
                    nMonto = (nTipoCambio <= 0) ? 0 : Math.Round(nMonto * nTipoCambio, 2);
                    oEnt.MontoLocal = nMonto;
                }
                oEnt.RegEditado = fnEnum.RegEditado.Si;
            }
            gvDetalle.RefreshData();
        }
        
        private Boolean fxValidarDetalle()
        {
            Boolean bOk = false;
            
            if (!Operacion.Equals("PE"))
            {
                if (LstDetVoucher.Count() == 0)
                {
                    fnMensaje.MensajeInfo("Debe ingresar al menos un registro en el detalle.");
                    return bOk;
                }
                
                entErrores oErr = negCuentaContable.GetValidaEstructuraCuenta(Compania, LstDetVoucher);
                foreach (entVoucherDet oDet in LstDetVoucher)
                {
                    if (!oDet.OrigenDoc.Equals("MN"))
                    {
                        if (oDet.CodigoDoc == 0 || oDet.CodigoDoc == Int32.MinValue)
                        {
                            oErr.Errores.Add(new entFail() { IdReg = oDet.Linea, Descripcion = "Documento ingresado es inválido." });
                        }
                    }
                }
                
                Decimal nMontoDebeLocal = LstDetVoucher.Where(x => x.MontoLocal > 0).Sum(y => y.MontoLocal);
                Decimal nMontoHaberLocal = LstDetVoucher.Where(x => x.MontoLocal < 0).Sum(y => y.MontoLocal);
                Decimal nMontoDebeExt = LstDetVoucher.Where(x => x.MontoExt > 0).Sum(y => y.MontoExt);
                Decimal nMontoHaberExt = LstDetVoucher.Where(x => x.MontoExt < 0).Sum(y => y.MontoExt);
                
                nMontoDebeLocal = Math.Round(nMontoDebeLocal, 2);
                nMontoHaberLocal = Math.Round(nMontoHaberLocal, 2);
                nMontoDebeExt = Math.Round(nMontoDebeExt, 2);
                nMontoHaberExt = Math.Round(nMontoHaberExt, 2);
                
                if (nMontoDebeLocal + nMontoHaberLocal != 0)
                {
                    oErr.Errores.Add(new entFail() { IdReg = 0, Descripcion = "Hay una diferencia de " + (nMontoDebeLocal + nMontoHaberLocal).ToString() + " entre los montos locales." });
                }
                
                if (nMontoDebeExt + nMontoHaberExt != 0)
                {
                    oErr.Errores.Add(new entFail() { IdReg = 0, Descripcion = "Hay una diferencia de " + (nMontoDebeExt + nMontoHaberExt).ToString() + " entre los montos extranjeros." });
                }
                
                if (oErr.Errores.Count > 0)
                {
                    frmErrMain oFrm = new frmErrMain();
                    oFrm.ListErrores = oErr;
                    oFrm.ShowDialog();
                    return bOk;
                }
                
                //Fecha Servidor
                DateTime dFechaServ = negGeneral.GetFechaServidor();
                if (Operacion.Equals("PE"))
                {
                    foreach (entVoucherDet oDet in LstDetVoucher)
                    {
                        if (!oDet.FlagAutomatico.Equals("S"))
                        {
                            LstDetVoucher.Remove(oDet);
                        }
                    }
                }
                
                foreach (entVoucherDet oDet in LstDetVoucher)
                {
                    if (Operacion.Equals("A"))
                    {
                        oDet.Periodo = Periodo;
                        oDet.TipoVoucher = TipoVoucher;
                        oDet.NumeroVoucher = NumeroVoucher;
                    }
                    
                    if (oDet.RegEditado == fnEnum.RegEditado.Si)
                    {
                        oDet.UltimoUsuarioMod = GlobalVar.UsuarioLogeo;
                        oDet.UltimaFechaMod = dFechaServ;
                    }
                }
            }
            
            bOk = true;
            return bOk;
        }
        
        #endregion
        
        #region "==EventInherit=="
        
        public override void ue_nuevo()
        {
            Operacion = "A";
            fxQuitEvent();
            fxPreOpen();
            fxEliminarDet();
            fxAddEvent();
        }
        
        public override void ue_guardar()
        {
            if (!fxValidar())
            {
                return;
            }
            ;
            if (!fxValidarDetalle())
            {
                return;
            }
            ;
            if (!fxPreUpdate())
            {
                return;
            }
            ;
            fxPostUpdate();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        
        public override void ue_cancelar()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    
        #endregion
    }
}