namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmSaldoxCuentaDet
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
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaNombre = new DevExpress.XtraEditors.TextEdit();
            this.MontoLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoExt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riceModManual = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceModRestr = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Persona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rideFecAprob = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Documento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModManual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModRestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.gpFiltrar.Controls.Add(this.txtCuentaNombre);
            this.gpFiltrar.Controls.Add(this.txtCuenta);
            this.gpFiltrar.Controls.Add(this.labelControl5);
            this.gpFiltrar.Controls.Add(this.txtPeriodo);
            this.gpFiltrar.Controls.Add(this.labelControl3);
            this.gpFiltrar.Controls.Add(this.cmbCompania);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(618, 32);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Location = new System.Drawing.Point(629, 36);
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(6, 65);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riceModManual,
            this.riceModRestr,
            this.rilueEstado,
            this.rilueOrigen,
            this.rideFecAprob});
            this.grControl.Size = new System.Drawing.Size(690, 380);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(784, 23);
            this.label1.Text = "LISTA DE VOUCHER POR CUENTA";
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
            this.Linea,
            this.DescripcionCab,
            this.MontoLocal,
            this.MontoExt,
            this.FechaAprobacion,
            this.Cuenta,
            this.Persona,
            this.Documento,
            this.CentroCosto,
            this.Descripcion});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowFooter = true;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
            this.gvDatos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDatos_RowCellStyle);
            // 
            // pnMain
            // 
            this.pnMain.Size = new System.Drawing.Size(703, 451);
            // 
            // cmbCompania
            // 
            this.cmbCompania.Enabled = false;
            this.cmbCompania.Location = new System.Drawing.Point(64, 5);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(138, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Compañía:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(233, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(276, 5);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodo.TabIndex = 8;
            // 
            // txtCuenta
            // 
            this.txtCuenta.EditValue = "";
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(403, 5);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.Size = new System.Drawing.Size(63, 20);
            this.txtCuenta.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(362, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Cuenta:";
            // 
            // txtCuentaNombre
            // 
            this.txtCuentaNombre.EditValue = "";
            this.txtCuentaNombre.Enabled = false;
            this.txtCuentaNombre.Location = new System.Drawing.Point(468, 5);
            this.txtCuentaNombre.Name = "txtCuentaNombre";
            this.txtCuentaNombre.Properties.Mask.EditMask = "0000";
            this.txtCuentaNombre.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCuentaNombre.Size = new System.Drawing.Size(139, 20);
            this.txtCuentaNombre.TabIndex = 16;
            // 
            // MontoLocal
            // 
            this.MontoLocal.Caption = "Monto Local";
            this.MontoLocal.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.MontoLocal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MontoLocal.FieldName = "MontoLocal";
            this.MontoLocal.Name = "MontoLocal";
            this.MontoLocal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoLocal", "{0:#,##0.00;(#,##0.00)}")});
            this.MontoLocal.Visible = true;
            this.MontoLocal.VisibleIndex = 3;
            this.MontoLocal.Width = 88;
            // 
            // MontoExt
            // 
            this.MontoExt.Caption = "Monto Ext.";
            this.MontoExt.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.MontoExt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MontoExt.FieldName = "MontoExt";
            this.MontoExt.Name = "MontoExt";
            this.MontoExt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MontoExt", "{0:#,##0.00;(#,##0.00)}")});
            this.MontoExt.Visible = true;
            this.MontoExt.VisibleIndex = 4;
            this.MontoExt.Width = 82;
            // 
            // IdVoucher
            // 
            this.IdVoucher.Caption = "Voucher";
            this.IdVoucher.FieldName = "IdVoucher";
            this.IdVoucher.Name = "IdVoucher";
            this.IdVoucher.Visible = true;
            this.IdVoucher.VisibleIndex = 0;
            this.IdVoucher.Width = 60;
            // 
            // DescripcionCab
            // 
            this.DescripcionCab.Caption = "Descripcion Voucher";
            this.DescripcionCab.FieldName = "Descripcion";
            this.DescripcionCab.Name = "DescripcionCab";
            this.DescripcionCab.Visible = true;
            this.DescripcionCab.VisibleIndex = 2;
            this.DescripcionCab.Width = 227;
            // 
            // rilueEstado
            // 
            this.rilueEstado.AutoHeight = false;
            this.rilueEstado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueEstado.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueEstado.Name = "rilueEstado";
            // 
            // Cuenta
            // 
            this.Cuenta.Caption = "Cuenta";
            this.Cuenta.FieldName = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Visible = true;
            this.Cuenta.VisibleIndex = 6;
            this.Cuenta.Width = 69;
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
            // Persona
            // 
            this.Persona.Caption = "Persona";
            this.Persona.FieldName = "Persona";
            this.Persona.Name = "Persona";
            this.Persona.Visible = true;
            this.Persona.VisibleIndex = 7;
            this.Persona.Width = 50;
            // 
            // FechaAprobacion
            // 
            this.FechaAprobacion.Caption = "Fecha Apr.";
            this.FechaAprobacion.ColumnEdit = this.rideFecAprob;
            this.FechaAprobacion.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.FechaAprobacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaAprobacion.FieldName = "FechaAprobacion";
            this.FechaAprobacion.Name = "FechaAprobacion";
            this.FechaAprobacion.Visible = true;
            this.FechaAprobacion.VisibleIndex = 5;
            this.FechaAprobacion.Width = 67;
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
            // Documento
            // 
            this.Documento.Caption = "Documento";
            this.Documento.FieldName = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.Visible = true;
            this.Documento.VisibleIndex = 8;
            this.Documento.Width = 91;
            // 
            // Linea
            // 
            this.Linea.Caption = "L.";
            this.Linea.FieldName = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.Visible = true;
            this.Linea.VisibleIndex = 1;
            this.Linea.Width = 38;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción Registro";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 10;
            this.Descripcion.Width = 312;
            // 
            // CentroCosto
            // 
            this.CentroCosto.Caption = "Centro Costo";
            this.CentroCosto.FieldName = "CentroCosto";
            this.CentroCosto.Name = "CentroCosto";
            this.CentroCosto.Visible = true;
            this.CentroCosto.VisibleIndex = 9;
            // 
            // frmSaldoxCuentaDet
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(703, 451);
            this.Name = "frmSaldoxCuentaDet";
            this.Text = "Lista de Voucher por Cuenta";
            this.Load += new System.EventHandler(this.frmSaldoxCuentaDet_Load);
            this.Shown += new System.EventHandler(this.frmSaldoxCuentaDet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModManual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceModRestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecAprob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.TextEdit txtCuentaNombre;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn MontoLocal;
        private DevExpress.XtraGrid.Columns.GridColumn MontoExt;
        private DevExpress.XtraGrid.Columns.GridColumn IdVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionCab;
        private DevExpress.XtraGrid.Columns.GridColumn Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn Persona;
        private DevExpress.XtraGrid.Columns.GridColumn FechaAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn Documento;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModManual;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModRestr;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueOrigen;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rideFecAprob;
        private DevExpress.XtraGrid.Columns.GridColumn Linea;
        private DevExpress.XtraGrid.Columns.GridColumn CentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;        
    }
}
