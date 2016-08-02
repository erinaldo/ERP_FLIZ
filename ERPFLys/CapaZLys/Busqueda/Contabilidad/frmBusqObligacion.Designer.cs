namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    partial class frmBusqObligacion
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
            this.DocumentoCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.Voucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceEsCliente = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNroDoc = new DevExpress.XtraEditors.TextEdit();
            this.chkNroDoc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoDoc = new DevExpress.XtraEditors.TextEdit();
            this.chkTipoDoc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNroDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTipoDoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(6, 58);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado,
            this.riceEsEmpleado,
            this.riceEsProveedor,
            this.riceEsCliente});
            this.grControl.Size = new System.Drawing.Size(471, 286);
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
            this.DocumentoCompleto,
            this.FechaEmision,
            this.FechaVencimiento,
            this.Voucher,
            this.EstadoDoc});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowFooter = true;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
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
            this.txtDescripcion.Size = new System.Drawing.Size(24, 20);
            this.txtDescripcion.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
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
            this.pnMain.Controls.Add(this.panelControl1);
            this.pnMain.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnMain.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.chkActivo, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnMain.Controls.SetChildIndex(this.panelControl1, 0);
            // 
            // DocumentoCompleto
            // 
            this.DocumentoCompleto.Caption = "Documento";
            this.DocumentoCompleto.FieldName = "DocumentoCompleto";
            this.DocumentoCompleto.Name = "DocumentoCompleto";
            this.DocumentoCompleto.Visible = true;
            this.DocumentoCompleto.VisibleIndex = 0;
            this.DocumentoCompleto.Width = 107;
            // 
            // FechaEmision
            // 
            this.FechaEmision.Caption = "F.Emisión";
            this.FechaEmision.FieldName = "FechaEmision";
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nombres", "{0}  Fila(s).")});
            this.FechaEmision.Visible = true;
            this.FechaEmision.VisibleIndex = 1;
            this.FechaEmision.Width = 77;
            // 
            // EstadoDoc
            // 
            this.EstadoDoc.AppearanceCell.Options.UseTextOptions = true;
            this.EstadoDoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EstadoDoc.Caption = "Estado";
            this.EstadoDoc.ColumnEdit = this.rilueEstado;
            this.EstadoDoc.FieldName = "EstadoDoc";
            this.EstadoDoc.Name = "EstadoDoc";
            this.EstadoDoc.Visible = true;
            this.EstadoDoc.VisibleIndex = 4;
            this.EstadoDoc.Width = 93;
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
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Location = new System.Drawing.Point(209, 25);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(98, 20);
            this.cmbEstado.TabIndex = 15;
            // 
            // Voucher
            // 
            this.Voucher.Caption = "Voucher";
            this.Voucher.FieldName = "Voucher";
            this.Voucher.Name = "Voucher";
            this.Voucher.Visible = true;
            this.Voucher.VisibleIndex = 3;
            this.Voucher.Width = 82;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.Caption = "F.Vencim.";
            this.FechaVencimiento.FieldName = "FechaVencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Visible = true;
            this.FechaVencimiento.VisibleIndex = 2;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chkEstado);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtNroDoc);
            this.panelControl1.Controls.Add(this.chkNroDoc);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtTipoDoc);
            this.panelControl1.Controls.Add(this.chkTipoDoc);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbEstado);
            this.panelControl1.Location = new System.Drawing.Point(6, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(360, 50);
            this.panelControl1.TabIndex = 16;
            // 
            // chkEstado
            // 
            this.chkEstado.EditValue = true;
            this.chkEstado.Location = new System.Drawing.Point(191, 25);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "";
            this.chkEstado.Size = new System.Drawing.Size(18, 19);
            this.chkEstado.TabIndex = 23;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(144, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Estado:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Enabled = false;
            this.txtNroDoc.Location = new System.Drawing.Point(209, 4);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroDoc.Properties.MaxLength = 2;
            this.txtNroDoc.Size = new System.Drawing.Size(98, 20);
            this.txtNroDoc.TabIndex = 21;
            // 
            // chkNroDoc
            // 
            this.chkNroDoc.EditValue = true;
            this.chkNroDoc.Location = new System.Drawing.Point(191, 4);
            this.chkNroDoc.Name = "chkNroDoc";
            this.chkNroDoc.Properties.Caption = "";
            this.chkNroDoc.Size = new System.Drawing.Size(18, 19);
            this.chkNroDoc.TabIndex = 20;
            this.chkNroDoc.CheckedChanged += new System.EventHandler(this.chkNroDoc_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(144, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Num Doc:";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Enabled = false;
            this.txtTipoDoc.Location = new System.Drawing.Point(71, 5);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoDoc.Properties.MaxLength = 2;
            this.txtTipoDoc.Size = new System.Drawing.Size(36, 20);
            this.txtTipoDoc.TabIndex = 18;
            // 
            // chkTipoDoc
            // 
            this.chkTipoDoc.EditValue = true;
            this.chkTipoDoc.Location = new System.Drawing.Point(54, 5);
            this.chkTipoDoc.Name = "chkTipoDoc";
            this.chkTipoDoc.Properties.Caption = "";
            this.chkTipoDoc.Size = new System.Drawing.Size(18, 19);
            this.chkTipoDoc.TabIndex = 17;
            this.chkTipoDoc.CheckedChanged += new System.EventHandler(this.chkTipoDoc_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tipo Doc:";
            // 
            // frmBusqObligacion
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Name = "frmBusqObligacion";
            this.Text = "Busqueda Documentos";
            this.Load += new System.EventHandler(this.frmBusqObligacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNroDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTipoDoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn DocumentoCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEmision;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoDoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsCliente;
        private DevExpress.XtraGrid.Columns.GridColumn FechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Voucher;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTipoDoc;
        private DevExpress.XtraEditors.CheckEdit chkTipoDoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNroDoc;
        private DevExpress.XtraEditors.CheckEdit chkNroDoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
