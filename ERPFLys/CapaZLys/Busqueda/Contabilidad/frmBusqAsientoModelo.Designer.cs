namespace FiltroLys.ZLys.Busqueda.Contabilidad
{
    partial class frmBusqAsientoModelo
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
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueMoneda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riceEsCliente = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsProveedor = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riceEsEmpleado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grControlDet = new DevExpress.XtraGrid.GridControl();
            this.gvDatosDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LineaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteCuenta = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.CentrocostoDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteMayus = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.PersonaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritePersona = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.PorcentajeDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritePorcentaje = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DocumentoDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.riteCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMayus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
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
            this.grControl.Size = new System.Drawing.Size(443, 143);
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
            this.Modelo,
            this.Descripcion});
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
            this.txtCodigo.Location = new System.Drawing.Point(211, 350);
            this.txtCodigo.Size = new System.Drawing.Size(30, 20);
            this.txtCodigo.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 349);
            this.txtDescripcion.Size = new System.Drawing.Size(0, 20);
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
            this.btnCancelar.Location = new System.Drawing.Point(377, 347);
            this.btnCancelar.Size = new System.Drawing.Size(70, 23);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(303, 346);
            this.btnAceptar.Size = new System.Drawing.Size(70, 23);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(181, 350);
            this.chkActivo.Size = new System.Drawing.Size(24, 19);
            this.chkActivo.Visible = false;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.txtMonto);
            this.pnMain.Controls.Add(this.labelControl1);
            this.pnMain.Controls.Add(this.grControlDet);
            this.pnMain.Size = new System.Drawing.Size(454, 379);
            this.pnMain.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnMain.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.chkActivo, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnMain.Controls.SetChildIndex(this.grControlDet, 0);
            this.pnMain.Controls.SetChildIndex(this.labelControl1, 0);
            this.pnMain.Controls.SetChildIndex(this.txtMonto, 0);
            // 
            // Modelo
            // 
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 0;
            this.Modelo.Width = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 351;
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
            // grControlDet
            // 
            this.grControlDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grControlDet.Location = new System.Drawing.Point(5, 173);
            this.grControlDet.MainView = this.gvDatosDet;
            this.grControlDet.Name = "grControlDet";
            this.grControlDet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteCuenta,
            this.riteMayus,
            this.ritePersona,
            this.ritePorcentaje});
            this.grControlDet.Size = new System.Drawing.Size(443, 169);
            this.grControlDet.TabIndex = 15;
            this.grControlDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatosDet});
            // 
            // gvDatosDet
            // 
            this.gvDatosDet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatosDet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatosDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LineaDet,
            this.CuentaDet,
            this.CentrocostoDet,
            this.PersonaDet,
            this.PorcentajeDet,
            this.DocumentoDet,
            this.DescripcionDet});
            this.gvDatosDet.GridControl = this.grControlDet;
            this.gvDatosDet.Name = "gvDatosDet";
            this.gvDatosDet.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatosDet.OptionsView.ColumnAutoWidth = false;
            this.gvDatosDet.OptionsView.ShowGroupPanel = false;
            this.gvDatosDet.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvDatosDet_CustomColumnDisplayText);
            // 
            // LineaDet
            // 
            this.LineaDet.Caption = "#";
            this.LineaDet.FieldName = "Linea";
            this.LineaDet.Name = "LineaDet";
            this.LineaDet.OptionsColumn.AllowEdit = false;
            this.LineaDet.OptionsColumn.ReadOnly = true;
            this.LineaDet.Visible = true;
            this.LineaDet.VisibleIndex = 0;
            this.LineaDet.Width = 25;
            // 
            // CuentaDet
            // 
            this.CuentaDet.Caption = "Cuenta";
            this.CuentaDet.ColumnEdit = this.riteCuenta;
            this.CuentaDet.FieldName = "Cuenta";
            this.CuentaDet.Name = "CuentaDet";
            this.CuentaDet.Visible = true;
            this.CuentaDet.VisibleIndex = 1;
            this.CuentaDet.Width = 67;
            // 
            // riteCuenta
            // 
            this.riteCuenta.AutoHeight = false;
            this.riteCuenta.Mask.EditMask = "[0-9]+";
            this.riteCuenta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.riteCuenta.MaxLength = 7;
            this.riteCuenta.Name = "riteCuenta";
            // 
            // CentrocostoDet
            // 
            this.CentrocostoDet.AppearanceCell.Options.UseTextOptions = true;
            this.CentrocostoDet.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CentrocostoDet.Caption = "C.Costo";
            this.CentrocostoDet.ColumnEdit = this.riteMayus;
            this.CentrocostoDet.FieldName = "Centrocosto";
            this.CentrocostoDet.Name = "CentrocostoDet";
            this.CentrocostoDet.Visible = true;
            this.CentrocostoDet.VisibleIndex = 2;
            this.CentrocostoDet.Width = 48;
            // 
            // riteMayus
            // 
            this.riteMayus.AutoHeight = false;
            this.riteMayus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.riteMayus.Mask.UseMaskAsDisplayFormat = true;
            this.riteMayus.Name = "riteMayus";
            // 
            // PersonaDet
            // 
            this.PersonaDet.Caption = "Persona";
            this.PersonaDet.ColumnEdit = this.ritePersona;
            this.PersonaDet.FieldName = "Persona";
            this.PersonaDet.Name = "PersonaDet";
            this.PersonaDet.Visible = true;
            this.PersonaDet.VisibleIndex = 3;
            this.PersonaDet.Width = 54;
            // 
            // ritePersona
            // 
            this.ritePersona.AutoHeight = false;
            this.ritePersona.Mask.EditMask = "d";
            this.ritePersona.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ritePersona.Mask.UseMaskAsDisplayFormat = true;
            this.ritePersona.Name = "ritePersona";
            // 
            // PorcentajeDet
            // 
            this.PorcentajeDet.Caption = "%";
            this.PorcentajeDet.ColumnEdit = this.ritePorcentaje;
            this.PorcentajeDet.FieldName = "Porcentaje";
            this.PorcentajeDet.Name = "PorcentajeDet";
            this.PorcentajeDet.Visible = true;
            this.PorcentajeDet.VisibleIndex = 4;
            this.PorcentajeDet.Width = 70;
            // 
            // ritePorcentaje
            // 
            this.ritePorcentaje.AutoHeight = false;
            this.ritePorcentaje.Mask.EditMask = "N2";
            this.ritePorcentaje.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ritePorcentaje.Mask.UseMaskAsDisplayFormat = true;
            this.ritePorcentaje.Name = "ritePorcentaje";
            // 
            // DocumentoDet
            // 
            this.DocumentoDet.Caption = "Documento";
            this.DocumentoDet.FieldName = "Documento";
            this.DocumentoDet.Name = "DocumentoDet";
            this.DocumentoDet.Visible = true;
            this.DocumentoDet.VisibleIndex = 5;
            this.DocumentoDet.Width = 108;
            // 
            // DescripcionDet
            // 
            this.DescripcionDet.Caption = "Descripcion";
            this.DescripcionDet.FieldName = "Descripcion";
            this.DescripcionDet.Name = "DescripcionDet";
            this.DescripcionDet.Visible = true;
            this.DescripcionDet.VisibleIndex = 6;
            this.DescripcionDet.Width = 230;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(337, 153);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Location = new System.Drawing.Point(377, 151);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMonto.Properties.DisplayFormat.FormatString = "N2";
            this.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto.Properties.EditFormat.FormatString = "N2";
            this.txtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMonto.Properties.Mask.EditMask = "N2";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMonto.Size = new System.Drawing.Size(72, 20);
            this.txtMonto.TabIndex = 17;
            // 
            // frmBusqAsientoModelo
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(454, 379);
            this.Name = "frmBusqAsientoModelo";
            this.Text = "Asiento Modelo";
            this.Load += new System.EventHandler(this.frmBusqAsientoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceEsEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grControlDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMayus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueMoneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceEsCliente;
        protected DevExpress.XtraGrid.GridControl grControlDet;
        protected DevExpress.XtraGrid.Views.Grid.GridView gvDatosDet;
        private DevExpress.XtraGrid.Columns.GridColumn LineaDet;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaDet;
        private DevExpress.XtraGrid.Columns.GridColumn CentrocostoDet;
        private DevExpress.XtraGrid.Columns.GridColumn PersonaDet;
        private DevExpress.XtraGrid.Columns.GridColumn PorcentajeDet;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentoDet;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionDet;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteCuenta;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteMayus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritePersona;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritePorcentaje;
    }
}
