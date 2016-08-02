namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmMayorizacionGene
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMayorizacionGene));
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkSelTodos = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodoProc = new DevExpress.XtraEditors.TextEdit();
            this.cmbProceso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.IdVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueMoneda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riceModManual = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceModRestr = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rideFecAprob = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtPeriodoAct = new DevExpress.XtraEditors.TextEdit();
            this.MontoExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelTodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoProc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModRestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoAct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Controls.Add(this.txtPeriodoAct);
            this.gpFiltrar.Controls.Add(this.txtTipoCambio);
            this.gpFiltrar.Controls.Add(this.labelControl5);
            this.gpFiltrar.Controls.Add(this.cmbProceso);
            this.gpFiltrar.Controls.Add(this.labelControl4);
            this.gpFiltrar.Controls.Add(this.txtPeriodoProc);
            this.gpFiltrar.Controls.Add(this.labelControl3);
            this.gpFiltrar.Controls.Add(this.chkSelTodos);
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.btnProcesar);
            this.gpFiltrar.Controls.Add(this.cmbCompania);
            this.gpFiltrar.Controls.Add(this.btnSeleccionar);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(652, 52);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(49, 402);
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(6, 85);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riceModManual,
            this.riceModRestr,
            this.rilueMoneda,
            this.rilueOrigen,
            this.rideFecAprob});
            this.grControl.Size = new System.Drawing.Size(650, 360);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(688, 23);
            this.label1.Text = "MAYORIZACIÓN - DESMAYORIZACIÓN";
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDatos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDatos.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDatos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdVoucher,
            this.Descripcion,
            this.Moneda,
            this.MontoLocal,
            this.MontoExt,
            this.Origen});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsSelection.MultiSelect = true;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowFooter = true;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
            this.gvDatos.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvDatos_CustomSummaryCalculate);
            this.gvDatos.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvDatos_SelectionChanged);
            // 
            // pnMain
            // 
            this.pnMain.Size = new System.Drawing.Size(663, 451);
            // 
            // cmbCompania
            // 
            this.cmbCompania.Enabled = false;
            this.cmbCompania.Location = new System.Drawing.Point(262, 5);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(122, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Periodo a Procesar";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Periodo Actual";
            // 
            // chkSelTodos
            // 
            this.chkSelTodos.Location = new System.Drawing.Point(413, 27);
            this.chkSelTodos.Name = "chkSelTodos";
            this.chkSelTodos.Properties.Caption = "--Seleccionar Todos--";
            this.chkSelTodos.Size = new System.Drawing.Size(134, 19);
            this.chkSelTodos.TabIndex = 4;
            this.chkSelTodos.CheckedChanged += new System.EventHandler(this.chkSelTodos_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(194, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Compañía";
            // 
            // txtPeriodoProc
            // 
            this.txtPeriodoProc.EditValue = "";
            this.txtPeriodoProc.Enabled = false;
            this.txtPeriodoProc.Location = new System.Drawing.Point(100, 6);
            this.txtPeriodoProc.Name = "txtPeriodoProc";
            this.txtPeriodoProc.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodoProc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodoProc.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodoProc.TabIndex = 8;
            // 
            // cmbProceso
            // 
            this.cmbProceso.Enabled = false;
            this.cmbProceso.Location = new System.Drawing.Point(262, 28);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProceso.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbProceso.Size = new System.Drawing.Size(122, 20);
            this.cmbProceso.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(194, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Proceso Reg";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.EditValue = "";
            this.txtTipoCambio.Enabled = false;
            this.txtTipoCambio.Location = new System.Drawing.Point(461, 4);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCambio.Size = new System.Drawing.Size(49, 20);
            this.txtTipoCambio.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(413, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "T.Cambio";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.Location = new System.Drawing.Point(552, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 23);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "&Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(552, 27);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(93, 23);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "&Ejec. Proceso";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // IdVoucher
            // 
            this.IdVoucher.Caption = "Voucher";
            this.IdVoucher.FieldName = "IdVoucher";
            this.IdVoucher.Name = "IdVoucher";
            this.IdVoucher.Visible = true;
            this.IdVoucher.VisibleIndex = 0;
            this.IdVoucher.Width = 73;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 527;
            // 
            // Moneda
            // 
            this.Moneda.Caption = "Moneda";
            this.Moneda.ColumnEdit = this.rilueMoneda;
            this.Moneda.FieldName = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.Visible = true;
            this.Moneda.VisibleIndex = 2;
            this.Moneda.Width = 65;
            // 
            // rilueMoneda
            // 
            this.rilueMoneda.AutoHeight = false;
            this.rilueMoneda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueMoneda.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueMoneda.Name = "rilueMoneda";
            // 
            // Origen
            // 
            this.Origen.Caption = "Origen";
            this.Origen.ColumnEdit = this.rilueOrigen;
            this.Origen.FieldName = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.Visible = true;
            this.Origen.VisibleIndex = 5;
            this.Origen.Width = 92;
            // 
            // rilueOrigen
            // 
            this.rilueOrigen.AutoHeight = false;
            this.rilueOrigen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueOrigen.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueOrigen.Name = "rilueOrigen";
            // 
            // riceModManual
            // 
            this.riceModManual.AutoHeight = false;
            this.riceModManual.Name = "riceModManual";
            this.riceModManual.ValueChecked = "S";
            this.riceModManual.ValueUnchecked = "N";
            // 
            // riceModRestr
            // 
            this.riceModRestr.AutoHeight = false;
            this.riceModRestr.Name = "riceModRestr";
            this.riceModRestr.ValueChecked = "S";
            this.riceModRestr.ValueUnchecked = "N";
            // 
            // rideFecAprob
            // 
            this.rideFecAprob.AutoHeight = false;
            this.rideFecAprob.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rideFecAprob.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rideFecAprob.Name = "rideFecAprob";
            this.rideFecAprob.NullDate = new System.DateTime(((long)(0)));
            // 
            // txtPeriodoAct
            // 
            this.txtPeriodoAct.EditValue = "";
            this.txtPeriodoAct.Enabled = false;
            this.txtPeriodoAct.Location = new System.Drawing.Point(100, 28);
            this.txtPeriodoAct.Name = "txtPeriodoAct";
            this.txtPeriodoAct.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodoAct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodoAct.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodoAct.TabIndex = 18;
            // 
            // MontoExt
            // 
            this.MontoExt.Caption = "Dolar";
            this.MontoExt.DisplayFormat.FormatString = "N2";
            this.MontoExt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MontoExt.FieldName = "MontoExt";
            this.MontoExt.Name = "MontoExt";
            this.MontoExt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.MontoExt.Visible = true;
            this.MontoExt.VisibleIndex = 4;
            this.MontoExt.Width = 95;
            // 
            // MontoLocal
            // 
            this.MontoLocal.Caption = "Local";
            this.MontoLocal.DisplayFormat.FormatString = "N2";
            this.MontoLocal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MontoLocal.FieldName = "MontoLocal";
            this.MontoLocal.Name = "MontoLocal";
            this.MontoLocal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.MontoLocal.Visible = true;
            this.MontoLocal.VisibleIndex = 3;
            this.MontoLocal.Width = 92;
            // 
            // frmMayorizacionGene
            // 
            this.AcceptButton = null;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Name = "frmMayorizacionGene";
            this.Text = "Mayorización - Desmayorización";
            this.Load += new System.EventHandler(this.frmMayorizacionGene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelTodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoProc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModRestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodoAct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkSelTodos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodoProc;
        private DevExpress.XtraEditors.LookUpEdit cmbProceso;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnSeleccionar;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraGrid.Columns.GridColumn IdVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn Origen;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModManual;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModRestr;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueMoneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueOrigen;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rideFecAprob;
        private DevExpress.XtraEditors.TextEdit txtPeriodoAct;
        private DevExpress.XtraGrid.Columns.GridColumn MontoLocal;
        private DevExpress.XtraGrid.Columns.GridColumn MontoExt;        
    }
}
