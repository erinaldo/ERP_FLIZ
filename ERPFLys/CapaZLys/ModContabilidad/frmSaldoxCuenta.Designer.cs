namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmSaldoxCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldoxCuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.grControlMayor = new DevExpress.XtraGrid.GridControl();
            this.gvDatosMayor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CuentaG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalLocalG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalExtG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpLocalG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpExtG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalLocalFinG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalExtFinG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpFiltrar = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnVoucherCta = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetalleCta = new DevExpress.XtraEditors.SimpleButton();
            this.grControlCuenta = new DevExpress.XtraGrid.GridControl();
            this.gvDatosCuenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CuentaG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalLocalG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalExtG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpLocalG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpExtG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalLocalFinG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalExtFinG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControlMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosMayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.grControlCuenta);
            this.pnMain.Controls.Add(this.btnDetalleCta);
            this.pnMain.Controls.Add(this.btnVoucherCta);
            this.pnMain.Controls.Add(this.gpFiltrar);
            this.pnMain.Controls.Add(this.grControlMayor);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Size = new System.Drawing.Size(611, 501);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTROL DE SALDOS - [ POR CUENTA ]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(382, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grControlMayor
            // 
            this.grControlMayor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControlMayor.Location = new System.Drawing.Point(7, 79);
            this.grControlMayor.MainView = this.gvDatosMayor;
            this.grControlMayor.Name = "grControlMayor";
            this.grControlMayor.Size = new System.Drawing.Size(599, 192);
            this.grControlMayor.TabIndex = 12;
            this.grControlMayor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosMayor});
            // 
            // gvDatosMayor
            // 
            this.gvDatosMayor.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatosMayor.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatosMayor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CuentaG,
            this.DescripcionG,
            this.SalLocalG,
            this.SalExtG,
            this.ImpLocalG,
            this.ImpExtG,
            this.SalLocalFinG,
            this.SalExtFinG});
            this.gvDatosMayor.GridControl = this.grControlMayor;
            this.gvDatosMayor.Name = "gvDatosMayor";
            this.gvDatosMayor.OptionsBehavior.Editable = false;
            this.gvDatosMayor.OptionsBehavior.ReadOnly = true;
            this.gvDatosMayor.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatosMayor.OptionsView.ColumnAutoWidth = false;
            this.gvDatosMayor.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDatosMayor.OptionsView.ShowGroupPanel = false;
            this.gvDatosMayor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDatosMayor_RowCellStyle);
            this.gvDatosMayor.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDatosMayor_FocusedRowChanged);
            // 
            // CuentaG
            // 
            this.CuentaG.Caption = "Cuenta";
            this.CuentaG.FieldName = "Cuenta";
            this.CuentaG.Name = "CuentaG";
            this.CuentaG.Visible = true;
            this.CuentaG.VisibleIndex = 0;
            this.CuentaG.Width = 66;
            // 
            // DescripcionG
            // 
            this.DescripcionG.Caption = "Descripcion";
            this.DescripcionG.FieldName = "Descripcion";
            this.DescripcionG.Name = "DescripcionG";
            this.DescripcionG.Visible = true;
            this.DescripcionG.VisibleIndex = 1;
            this.DescripcionG.Width = 291;
            // 
            // SalLocalG
            // 
            this.SalLocalG.Caption = "Saldo inicial Local";
            this.SalLocalG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalLocalG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalLocalG.FieldName = "SalLocal";
            this.SalLocalG.Name = "SalLocalG";
            this.SalLocalG.Visible = true;
            this.SalLocalG.VisibleIndex = 2;
            this.SalLocalG.Width = 96;
            // 
            // SalExtG
            // 
            this.SalExtG.Caption = "Saldo inicial  US$";
            this.SalExtG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalExtG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalExtG.FieldName = "SalExt";
            this.SalExtG.Name = "SalExtG";
            this.SalExtG.Visible = true;
            this.SalExtG.VisibleIndex = 3;
            this.SalExtG.Width = 95;
            // 
            // ImpLocalG
            // 
            this.ImpLocalG.Caption = "Movimientos Local";
            this.ImpLocalG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.ImpLocalG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImpLocalG.FieldName = "ImpLocal";
            this.ImpLocalG.Name = "ImpLocalG";
            this.ImpLocalG.Visible = true;
            this.ImpLocalG.VisibleIndex = 4;
            this.ImpLocalG.Width = 95;
            // 
            // ImpExtG
            // 
            this.ImpExtG.Caption = "Movimientos US$";
            this.ImpExtG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.ImpExtG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImpExtG.FieldName = "ImpExt";
            this.ImpExtG.Name = "ImpExtG";
            this.ImpExtG.Visible = true;
            this.ImpExtG.VisibleIndex = 5;
            this.ImpExtG.Width = 99;
            // 
            // SalLocalFinG
            // 
            this.SalLocalFinG.Caption = "Saldo Final Local";
            this.SalLocalFinG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalLocalFinG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalLocalFinG.FieldName = "SalLocalFin";
            this.SalLocalFinG.Name = "SalLocalFinG";
            this.SalLocalFinG.Visible = true;
            this.SalLocalFinG.VisibleIndex = 6;
            this.SalLocalFinG.Width = 91;
            // 
            // SalExtFinG
            // 
            this.SalExtFinG.Caption = "Saldo Final US$";
            this.SalExtFinG.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalExtFinG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalExtFinG.FieldName = "SalExtFin";
            this.SalExtFinG.Name = "SalExtFinG";
            this.SalExtFinG.Visible = true;
            this.SalExtFinG.VisibleIndex = 7;
            this.SalExtFinG.Width = 90;
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.txtPeriodo);
            this.gpFiltrar.Controls.Add(this.btnBuscar);
            this.gpFiltrar.Controls.Add(this.cmbCompania);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Location = new System.Drawing.Point(8, 34);
            this.gpFiltrar.Name = "gpFiltrar";
            this.gpFiltrar.ShowCaption = false;
            this.gpFiltrar.Size = new System.Drawing.Size(554, 41);
            this.gpFiltrar.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(256, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(299, 10);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodo.TabIndex = 11;
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(64, 10);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(173, 20);
            this.cmbCompania.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Compañía:";
            // 
            // btnVoucherCta
            // 
            this.btnVoucherCta.Image = ((System.Drawing.Image)(resources.GetObject("btnVoucherCta.Image")));
            this.btnVoucherCta.Location = new System.Drawing.Point(7, 275);
            this.btnVoucherCta.Name = "btnVoucherCta";
            this.btnVoucherCta.Size = new System.Drawing.Size(93, 23);
            this.btnVoucherCta.TabIndex = 14;
            this.btnVoucherCta.Text = "&Voucher Cta";
            this.btnVoucherCta.Click += new System.EventHandler(this.btnVoucherCta_Click);
            // 
            // btnDetalleCta
            // 
            this.btnDetalleCta.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleCta.Image")));
            this.btnDetalleCta.Location = new System.Drawing.Point(104, 275);
            this.btnDetalleCta.Name = "btnDetalleCta";
            this.btnDetalleCta.Size = new System.Drawing.Size(86, 23);
            this.btnDetalleCta.TabIndex = 15;
            this.btnDetalleCta.Text = "&Detalle Cta";
            this.btnDetalleCta.Click += new System.EventHandler(this.btnDetalleCta_Click);
            // 
            // grControlCuenta
            // 
            this.grControlCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControlCuenta.Location = new System.Drawing.Point(7, 302);
            this.grControlCuenta.MainView = this.gvDatosCuenta;
            this.grControlCuenta.Name = "grControlCuenta";
            this.grControlCuenta.Size = new System.Drawing.Size(599, 192);
            this.grControlCuenta.TabIndex = 16;
            this.grControlCuenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosCuenta});
            // 
            // gvDatosCuenta
            // 
            this.gvDatosCuenta.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDatosCuenta.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDatosCuenta.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDatosCuenta.Appearance.FooterPanel.Options.UseForeColor = true;            
            this.gvDatosCuenta.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatosCuenta.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatosCuenta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CuentaG2,
            this.DescripcionG2,
            this.SalLocalG2,
            this.SalExtG2,
            this.ImpLocalG2,
            this.ImpExtG2,
            this.SalLocalFinG2,
            this.SalExtFinG2});
            this.gvDatosCuenta.GridControl = this.grControlCuenta;
            this.gvDatosCuenta.Name = "gvDatosCuenta";
            this.gvDatosCuenta.OptionsBehavior.Editable = false;
            this.gvDatosCuenta.OptionsBehavior.ReadOnly = true;
            this.gvDatosCuenta.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatosCuenta.OptionsView.ColumnAutoWidth = false;
            this.gvDatosCuenta.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDatosCuenta.OptionsView.ShowFooter = true;
            this.gvDatosCuenta.OptionsView.ShowGroupPanel = false;
            this.gvDatosCuenta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDatosCuenta_RowCellStyle);
            // 
            // CuentaG2
            // 
            this.CuentaG2.Caption = "Cuenta";
            this.CuentaG2.FieldName = "Cuenta";
            this.CuentaG2.Name = "CuentaG2";
            this.CuentaG2.Visible = true;
            this.CuentaG2.VisibleIndex = 0;
            this.CuentaG2.Width = 66;
            // 
            // DescripcionG2
            // 
            this.DescripcionG2.Caption = "Descripcion";
            this.DescripcionG2.FieldName = "Descripcion";
            this.DescripcionG2.Name = "DescripcionG2";
            this.DescripcionG2.Visible = true;
            this.DescripcionG2.VisibleIndex = 1;
            this.DescripcionG2.Width = 291;
            // 
            // SalLocalG2
            // 
            this.SalLocalG2.Caption = "Saldo inicial Local";
            this.SalLocalG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalLocalG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalLocalG2.FieldName = "SalLocal";
            this.SalLocalG2.Name = "SalLocalG2";
            this.SalLocalG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalLocal", "{0:#,##0.00;(#,##0.00)}")});
            this.SalLocalG2.Visible = true;
            this.SalLocalG2.VisibleIndex = 2;
            this.SalLocalG2.Width = 96;
            // 
            // SalExtG2
            // 
            this.SalExtG2.Caption = "Saldo inicial  US$";
            this.SalExtG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalExtG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalExtG2.FieldName = "SalExt";
            this.SalExtG2.Name = "SalExtG2";
            this.SalExtG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalExt", "{0:#,##0.00;(#,##0.00)}")});
            this.SalExtG2.Visible = true;
            this.SalExtG2.VisibleIndex = 3;
            this.SalExtG2.Width = 95;
            // 
            // ImpLocalG2
            // 
            this.ImpLocalG2.Caption = "Movimientos Local";
            this.ImpLocalG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.ImpLocalG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImpLocalG2.FieldName = "ImpLocal";
            this.ImpLocalG2.Name = "ImpLocalG2";
            this.ImpLocalG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpLocal", "{0:#,##0.00;(#,##0.00)}")});
            this.ImpLocalG2.Visible = true;
            this.ImpLocalG2.VisibleIndex = 4;
            this.ImpLocalG2.Width = 95;
            // 
            // ImpExtG2
            // 
            this.ImpExtG2.Caption = "Movimientos US$";
            this.ImpExtG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.ImpExtG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ImpExtG2.FieldName = "ImpExt";
            this.ImpExtG2.Name = "ImpExtG2";
            this.ImpExtG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImpExt", "{0:#,##0.00;(#,##0.00)}")});
            this.ImpExtG2.Visible = true;
            this.ImpExtG2.VisibleIndex = 5;
            this.ImpExtG2.Width = 99;
            // 
            // SalLocalFinG2
            // 
            this.SalLocalFinG2.Caption = "Saldo Final Local";
            this.SalLocalFinG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalLocalFinG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalLocalFinG2.FieldName = "SalLocalFin";
            this.SalLocalFinG2.Name = "SalLocalFinG2";
            this.SalLocalFinG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalLocalFin", "{0:#,##0.00;(#,##0.00)}")});
            this.SalLocalFinG2.Visible = true;
            this.SalLocalFinG2.VisibleIndex = 6;
            this.SalLocalFinG2.Width = 91;
            // 
            // SalExtFinG2
            // 
            this.SalExtFinG2.Caption = "Saldo Final US$";
            this.SalExtFinG2.DisplayFormat.FormatString = "#,##0.00;(#,##0.00)";
            this.SalExtFinG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SalExtFinG2.FieldName = "SalExtFin";
            this.SalExtFinG2.Name = "SalExtFinG2";
            this.SalExtFinG2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SalExtFin", "{0:#,##0.00;(#,##0.00)}")});
            this.SalExtFinG2.Visible = true;
            this.SalExtFinG2.VisibleIndex = 7;
            this.SalExtFinG2.Width = 90;
            // 
            // frmSaldoxCuenta
            // 
            this.AcceptButton = this.btnBuscar;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(611, 501);
            this.Name = "frmSaldoxCuenta";
            this.Text = "Saldos Contables";
            this.Load += new System.EventHandler(this.frmSaldoxCuenta_Load);
            this.Shown += new System.EventHandler(this.frmSaldoxCuenta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grControlMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosMayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected DevExpress.XtraEditors.SimpleButton btnBuscar;
        protected DevExpress.XtraGrid.GridControl grControlMayor;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatosMayor;
        protected DevExpress.XtraEditors.GroupControl gpFiltrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.SimpleButton btnDetalleCta;
        protected DevExpress.XtraEditors.SimpleButton btnVoucherCta;
        protected DevExpress.XtraGrid.GridControl grControlCuenta;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatosCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaG2;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionG2;
        private DevExpress.XtraGrid.Columns.GridColumn SalLocalG2;
        private DevExpress.XtraGrid.Columns.GridColumn SalExtG2;
        private DevExpress.XtraGrid.Columns.GridColumn ImpLocalG2;
        private DevExpress.XtraGrid.Columns.GridColumn ImpExtG2;
        private DevExpress.XtraGrid.Columns.GridColumn SalLocalFinG2;
        private DevExpress.XtraGrid.Columns.GridColumn SalExtFinG2;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaG;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionG;
        private DevExpress.XtraGrid.Columns.GridColumn SalLocalG;
        private DevExpress.XtraGrid.Columns.GridColumn SalExtG;
        private DevExpress.XtraGrid.Columns.GridColumn ImpLocalG;
        private DevExpress.XtraGrid.Columns.GridColumn ImpExtG;
        private DevExpress.XtraGrid.Columns.GridColumn SalLocalFinG;
        private DevExpress.XtraGrid.Columns.GridColumn SalExtFinG;
    }
}
