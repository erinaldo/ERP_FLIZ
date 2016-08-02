namespace FiltroLys.ZLys.Busqueda.General
{
    partial class frmBusqPersona
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
            this.Persona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmbBuscarPor = new DevExpress.XtraEditors.LookUpEdit();
            this.DocumentoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentoIdentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EsCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EsProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EsEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceEsEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsCliente = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuscarPor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado,
            this.riceEsEmpleado,
            this.riceEsProveedor,
            this.riceEsCliente});
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
            this.Persona,
            this.NombreCompleto,
            this.EsEmpleado,
            this.EsProveedor,
            this.EsCliente,
            this.DocumentoIdentidad,
            this.DocumentoFiscal,
            this.Estado});
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
            this.txtCodigo.Location = new System.Drawing.Point(254, 350);
            this.txtCodigo.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 6);
            this.txtDescripcion.Size = new System.Drawing.Size(298, 20);
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
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.cmbBuscarPor);
            this.pnMain.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnMain.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.chkActivo, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnMain.Controls.SetChildIndex(this.cmbBuscarPor, 0);
            // 
            // Persona
            // 
            this.Persona.Caption = "Persona";
            this.Persona.FieldName = "Persona";
            this.Persona.Name = "Persona";
            this.Persona.Visible = true;
            this.Persona.VisibleIndex = 0;
            this.Persona.Width = 63;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Caption = "Nombre Completo";
            this.NombreCompleto.FieldName = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nombres", "{0}  Fila(s).")});
            this.NombreCompleto.Visible = true;
            this.NombreCompleto.VisibleIndex = 1;
            this.NombreCompleto.Width = 159;
            // 
            // Estado
            // 
            this.Estado.AppearanceCell.Options.UseTextOptions = true;
            this.Estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
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
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.Location = new System.Drawing.Point(5, 6);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBuscarPor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbBuscarPor.Size = new System.Drawing.Size(98, 20);
            this.cmbBuscarPor.TabIndex = 15;
            // 
            // DocumentoFiscal
            // 
            this.DocumentoFiscal.Caption = "Doc Fiscal";
            this.DocumentoFiscal.FieldName = "DocumentoFiscal";
            this.DocumentoFiscal.Name = "DocumentoFiscal";
            this.DocumentoFiscal.Visible = true;
            this.DocumentoFiscal.VisibleIndex = 6;
            this.DocumentoFiscal.Width = 97;
            // 
            // DocumentoIdentidad
            // 
            this.DocumentoIdentidad.Caption = "Doc Ident.";
            this.DocumentoIdentidad.FieldName = "DocumentoIdentidad";
            this.DocumentoIdentidad.Name = "DocumentoIdentidad";
            this.DocumentoIdentidad.Visible = true;
            this.DocumentoIdentidad.VisibleIndex = 5;
            this.DocumentoIdentidad.Width = 84;
            // 
            // EsCliente
            // 
            this.EsCliente.AppearanceCell.Options.UseTextOptions = true;
            this.EsCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EsCliente.Caption = "Cliente?";
            this.EsCliente.ColumnEdit = this.riceEsCliente;
            this.EsCliente.FieldName = "EsCliente";
            this.EsCliente.Name = "EsCliente";
            this.EsCliente.Visible = true;
            this.EsCliente.VisibleIndex = 4;
            this.EsCliente.Width = 50;
            // 
            // EsProveedor
            // 
            this.EsProveedor.AppearanceCell.Options.UseTextOptions = true;
            this.EsProveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EsProveedor.Caption = "Prov?";
            this.EsProveedor.ColumnEdit = this.riceEsProveedor;
            this.EsProveedor.FieldName = "EsProveedor";
            this.EsProveedor.Name = "EsProveedor";
            this.EsProveedor.Visible = true;
            this.EsProveedor.VisibleIndex = 3;
            this.EsProveedor.Width = 43;
            // 
            // EsEmpleado
            // 
            this.EsEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.EsEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EsEmpleado.Caption = "Emp?";
            this.EsEmpleado.ColumnEdit = this.riceEsEmpleado;
            this.EsEmpleado.FieldName = "EsEmpleado";
            this.EsEmpleado.Name = "EsEmpleado";
            this.EsEmpleado.Visible = true;
            this.EsEmpleado.VisibleIndex = 2;
            this.EsEmpleado.Width = 40;
            // 
            // riceEsEmpleado
            // 
            this.riceEsEmpleado.AutoHeight = false;
            this.riceEsEmpleado.Name = "riceEsEmpleado";
            this.riceEsEmpleado.ValueChecked = "S";
            this.riceEsEmpleado.ValueUnchecked = "N";
            // 
            // riceEsProveedor
            // 
            this.riceEsProveedor.AutoHeight = false;
            this.riceEsProveedor.Name = "riceEsProveedor";
            this.riceEsProveedor.ValueChecked = "S";
            this.riceEsProveedor.ValueUnchecked = "N";
            // 
            // riceEsCliente
            // 
            this.riceEsCliente.AutoHeight = false;
            this.riceEsCliente.Name = "riceEsCliente";
            this.riceEsCliente.ValueChecked = "S";
            this.riceEsCliente.ValueUnchecked = "N";
            // 
            // frmBusqPersona
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Name = "frmBusqPersona";
            this.Text = "Busqueda Persona";
            this.Load += new System.EventHandler(this.frmBusqPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuscarPor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Persona;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraEditors.LookUpEdit cmbBuscarPor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsCliente;
        private DevExpress.XtraGrid.Columns.GridColumn EsEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn EsProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn EsCliente;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentoIdentidad;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentoFiscal;
    }
}
