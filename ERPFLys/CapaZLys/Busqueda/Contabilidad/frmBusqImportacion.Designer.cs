namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    partial class frmBusqImportacion
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
            this.NumeroOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ampliacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueMoneda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPreparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceEsCliente = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grControlDet = new DevExpress.XtraGrid.GridControl();
            this.gvDatosDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadPedidaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioUnitarioDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MontoTotalDet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosDet)).BeginInit();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControl.Location = new System.Drawing.Point(6, 5);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueMoneda,
            this.riceEsEmpleado,
            this.riceEsProveedor,
            this.riceEsCliente});
            this.grControl.Size = new System.Drawing.Size(561, 171);
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
            this.NumeroOrden,
            this.Ampliacion,
            this.FechaPreparacion,
            this.Proveedor,
            this.RazonSocial,
            this.Moneda,
            this.MontoTotal,
            this.Observacion});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
            this.gvDatos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDatos_FocusedRowChanged);
            this.gvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDatos_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(296, 350);
            this.txtCodigo.Size = new System.Drawing.Size(30, 20);
            this.txtCodigo.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(236, 349);
            this.txtDescripcion.Size = new System.Drawing.Size(114, 20);
            this.txtDescripcion.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Location = new System.Drawing.Point(5, 348);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(495, 347);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(422, 347);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(266, 350);
            this.chkActivo.Size = new System.Drawing.Size(24, 19);
            this.chkActivo.Visible = false;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.grControlDet);
            this.pnMain.Size = new System.Drawing.Size(572, 379);
            this.pnMain.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnMain.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.chkActivo, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControlDet, 0);
            // 
            // NumeroOrden
            // 
            this.NumeroOrden.Caption = "Numero Orden";
            this.NumeroOrden.FieldName = "NumeroOrden";
            this.NumeroOrden.Name = "NumeroOrden";
            this.NumeroOrden.Visible = true;
            this.NumeroOrden.VisibleIndex = 0;
            this.NumeroOrden.Width = 99;
            // 
            // Ampliacion
            // 
            this.Ampliacion.Caption = "A.";
            this.Ampliacion.FieldName = "Ampliacion";
            this.Ampliacion.Name = "Ampliacion";
            this.Ampliacion.Visible = true;
            this.Ampliacion.VisibleIndex = 1;
            this.Ampliacion.Width = 21;
            // 
            // Moneda
            // 
            this.Moneda.Caption = "Moneda";
            this.Moneda.ColumnEdit = this.rilueMoneda;
            this.Moneda.FieldName = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.Visible = true;
            this.Moneda.VisibleIndex = 5;
            this.Moneda.Width = 54;
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
            // Proveedor
            // 
            this.Proveedor.Caption = "Prov.";
            this.Proveedor.FieldName = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Visible = true;
            this.Proveedor.VisibleIndex = 3;
            this.Proveedor.Width = 48;
            // 
            // FechaPreparacion
            // 
            this.FechaPreparacion.Caption = "Fecha Prep.";
            this.FechaPreparacion.FieldName = "FechaPreparacion";
            this.FechaPreparacion.Name = "FechaPreparacion";
            this.FechaPreparacion.Visible = true;
            this.FechaPreparacion.VisibleIndex = 2;
            this.FechaPreparacion.Width = 69;
            // 
            // riceEsCliente
            // 
            this.riceEsCliente.AutoHeight = false;
            this.riceEsCliente.Name = "riceEsCliente";
            this.riceEsCliente.ValueChecked = "S";
            this.riceEsCliente.ValueUnchecked = "N";
            // 
            // riceEsProveedor
            // 
            this.riceEsProveedor.AutoHeight = false;
            this.riceEsProveedor.Name = "riceEsProveedor";
            this.riceEsProveedor.ValueChecked = "S";
            this.riceEsProveedor.ValueUnchecked = "N";
            // 
            // riceEsEmpleado
            // 
            this.riceEsEmpleado.AutoHeight = false;
            this.riceEsEmpleado.Name = "riceEsEmpleado";
            this.riceEsEmpleado.ValueChecked = "S";
            this.riceEsEmpleado.ValueUnchecked = "N";
            // 
            // RazonSocial
            // 
            this.RazonSocial.Caption = "Razon Social";
            this.RazonSocial.FieldName = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Visible = true;
            this.RazonSocial.VisibleIndex = 4;
            this.RazonSocial.Width = 157;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 7;
            this.Observacion.Width = 104;
            // 
            // MontoTotal
            // 
            this.MontoTotal.Caption = "Monto Total";
            this.MontoTotal.DisplayFormat.FormatString = "N2";
            this.MontoTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.MontoTotal.FieldName = "MontoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.Visible = true;
            this.MontoTotal.VisibleIndex = 6;
            this.MontoTotal.Width = 78;
            // 
            // grControlDet
            // 
            this.grControlDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControlDet.Location = new System.Drawing.Point(5, 180);
            this.grControlDet.MainView = this.gvDatosDet;
            this.grControlDet.Name = "grControlDet";
            this.grControlDet.Size = new System.Drawing.Size(561, 162);
            this.grControlDet.TabIndex = 15;
            this.grControlDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosDet});
            // 
            // gvDatosDet
            // 
            this.gvDatosDet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatosDet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatosDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemDet,
            this.DescripcionDet,
            this.CantidadPedidaDet,
            this.PrecioUnitarioDet,
            this.MontoTotalDet});
            this.gvDatosDet.GridControl = this.grControlDet;
            this.gvDatosDet.Name = "gvDatosDet";
            this.gvDatosDet.OptionsBehavior.Editable = false;
            this.gvDatosDet.OptionsBehavior.ReadOnly = true;
            this.gvDatosDet.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatosDet.OptionsView.ColumnAutoWidth = false;
            this.gvDatosDet.OptionsView.ShowGroupPanel = false;
            // 
            // ItemDet
            // 
            this.ItemDet.Caption = "Item";
            this.ItemDet.FieldName = "Item";
            this.ItemDet.Name = "ItemDet";
            this.ItemDet.Visible = true;
            this.ItemDet.VisibleIndex = 0;
            this.ItemDet.Width = 99;
            // 
            // DescripcionDet
            // 
            this.DescripcionDet.Caption = "Descripción";
            this.DescripcionDet.FieldName = "Descripcion";
            this.DescripcionDet.Name = "DescripcionDet";
            this.DescripcionDet.Visible = true;
            this.DescripcionDet.VisibleIndex = 1;
            this.DescripcionDet.Width = 203;
            // 
            // CantidadPedidaDet
            // 
            this.CantidadPedidaDet.Caption = "Cant Pedida";
            this.CantidadPedidaDet.DisplayFormat.FormatString = "N2";
            this.CantidadPedidaDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CantidadPedidaDet.FieldName = "CantidadPedida";
            this.CantidadPedidaDet.Name = "CantidadPedidaDet";
            this.CantidadPedidaDet.Visible = true;
            this.CantidadPedidaDet.VisibleIndex = 2;
            // 
            // PrecioUnitarioDet
            // 
            this.PrecioUnitarioDet.Caption = "Precio Unit.";
            this.PrecioUnitarioDet.DisplayFormat.FormatString = "N4";
            this.PrecioUnitarioDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.PrecioUnitarioDet.FieldName = "PrecioUnitario";
            this.PrecioUnitarioDet.Name = "PrecioUnitarioDet";
            this.PrecioUnitarioDet.Visible = true;
            this.PrecioUnitarioDet.VisibleIndex = 3;
            // 
            // MontoTotalDet
            // 
            this.MontoTotalDet.Caption = "Monto Total";
            this.MontoTotalDet.DisplayFormat.FormatString = "N2";
            this.MontoTotalDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.MontoTotalDet.FieldName = "MontoTotal";
            this.MontoTotalDet.Name = "MontoTotalDet";
            this.MontoTotalDet.Visible = true;
            this.MontoTotalDet.VisibleIndex = 4;
            // 
            // frmBusqImportacion
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(572, 379);
            this.Name = "frmBusqImportacion";
            this.Text = "Importaciones";
            this.Load += new System.EventHandler(this.frmBusqImportacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn NumeroOrden;
        private DevExpress.XtraGrid.Columns.GridColumn Ampliacion;
        private DevExpress.XtraGrid.Columns.GridColumn Moneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueMoneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsCliente;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPreparacion;
        private DevExpress.XtraGrid.Columns.GridColumn Proveedor;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn MontoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        protected DevExpress.XtraGrid.GridControl grControlDet;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatosDet;
        private DevExpress.XtraGrid.Columns.GridColumn ItemDet;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionDet;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadPedidaDet;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioUnitarioDet;
        private DevExpress.XtraGrid.Columns.GridColumn MontoTotalDet;
    }
}
