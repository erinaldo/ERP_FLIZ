namespace FiltroLys.ZLys.ModContabilidad
{
    partial class frmVoucherList
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkDepartamento = new DevExpress.XtraEditors.CheckEdit();
            this.cmbDepartamento = new DevExpress.XtraEditors.LookUpEdit();
            this.chkPeriodo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTipoVoucher = new DevExpress.XtraEditors.TextEdit();
            this.chkVoucher = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtVoucherIni = new DevExpress.XtraEditors.TextEdit();
            this.txtVoucherFin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPasarPend = new DevExpress.XtraEditors.SimpleButton();
            this.btnAprobar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopiar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdVoucher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UsuarioRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.FlagModManual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceModManual = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.FlagModRestringida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceModRestr = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.UsuarioAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaAprobacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rideFecAprob = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.UltimoUsuarioMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaMod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherFin.Properties)).BeginInit();
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
            this.gpFiltrar.Controls.Add(this.labelControl6);
            this.gpFiltrar.Controls.Add(this.txtVoucherFin);
            this.gpFiltrar.Controls.Add(this.txtVoucherIni);
            this.gpFiltrar.Controls.Add(this.txtTipoVoucher);
            this.gpFiltrar.Controls.Add(this.chkVoucher);
            this.gpFiltrar.Controls.Add(this.labelControl5);
            this.gpFiltrar.Controls.Add(this.cmbEstado);
            this.gpFiltrar.Controls.Add(this.chkEstado);
            this.gpFiltrar.Controls.Add(this.labelControl4);
            this.gpFiltrar.Controls.Add(this.txtPeriodo);
            this.gpFiltrar.Controls.Add(this.chkPeriodo);
            this.gpFiltrar.Controls.Add(this.labelControl3);
            this.gpFiltrar.Controls.Add(this.cmbDepartamento);
            this.gpFiltrar.Controls.Add(this.chkDepartamento);
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.cmbCompania);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(652, 52);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(577, 87);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grControl
            // 
            this.grControl.Location = new System.Drawing.Point(6, 113);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riceModManual,
            this.riceModRestr,
            this.rilueEstado,
            this.rilueOrigen,
            this.rideFecAprob});
            this.grControl.Size = new System.Drawing.Size(650, 332);
            // 
            // label1
            // 
            this.label1.Text = "REGISTRO DE VOUCHER";
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.FooterPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDatos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gvDatos.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDatos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Periodo,
            this.Fecha,
            this.IdVoucher,
            this.DepartNombre,
            this.Descripcion,
            this.Estado,
            this.UsuarioRegistro,
            this.FechaRegistro,
            this.Origen,
            this.FlagModManual,
            this.FlagModRestringida,
            this.UsuarioAprobacion,
            this.FechaAprobacion,
            this.UltimoUsuarioMod,
            this.UltimaFechaMod});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowFooter = true;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDatos_RowCellClick);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnImprimir);
            this.pnMain.Controls.Add(this.btnCopiar);
            this.pnMain.Controls.Add(this.btnAnular);
            this.pnMain.Controls.Add(this.btnPasarPend);
            this.pnMain.Controls.Add(this.btnAprobar);
            this.pnMain.Controls.Add(this.btnModificar);
            this.pnMain.Controls.Add(this.btnNuevo);
            this.pnMain.Size = new System.Drawing.Size(663, 451);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.gpFiltrar, 0);
            this.pnMain.Controls.SetChildIndex(this.label1, 0);
            this.pnMain.Controls.SetChildIndex(this.btnNuevo, 0);
            this.pnMain.Controls.SetChildIndex(this.btnModificar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAprobar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnPasarPend, 0);
            this.pnMain.Controls.SetChildIndex(this.btnAnular, 0);
            this.pnMain.Controls.SetChildIndex(this.btnCopiar, 0);
            this.pnMain.Controls.SetChildIndex(this.btnImprimir, 0);
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(82, 5);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(138, 20);
            this.cmbCompania.TabIndex = 1;
            this.cmbCompania.EditValueChanged += new System.EventHandler(this.cmbCompania_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Compañía:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Departamento:";
            // 
            // chkDepartamento
            // 
            this.chkDepartamento.EditValue = true;
            this.chkDepartamento.Location = new System.Drawing.Point(82, 28);
            this.chkDepartamento.Name = "chkDepartamento";
            this.chkDepartamento.Properties.Caption = "";
            this.chkDepartamento.Size = new System.Drawing.Size(16, 19);
            this.chkDepartamento.TabIndex = 4;
            this.chkDepartamento.CheckedChanged += new System.EventHandler(this.chkDepartamento_CheckedChanged);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.Location = new System.Drawing.Point(98, 28);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbDepartamento.Properties.PopupWidth = 250;
            this.cmbDepartamento.Size = new System.Drawing.Size(122, 20);
            this.cmbDepartamento.TabIndex = 5;
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.Location = new System.Drawing.Point(295, 4);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Properties.Caption = "";
            this.chkPeriodo.Size = new System.Drawing.Size(16, 19);
            this.chkPeriodo.TabIndex = 7;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(253, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(312, 5);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodo.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Location = new System.Drawing.Point(312, 28);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(122, 20);
            this.cmbEstado.TabIndex = 11;
            // 
            // chkEstado
            // 
            this.chkEstado.EditValue = true;
            this.chkEstado.Location = new System.Drawing.Point(295, 27);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "";
            this.chkEstado.Size = new System.Drawing.Size(16, 19);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(253, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Estado:";
            // 
            // txtTipoVoucher
            // 
            this.txtTipoVoucher.EditValue = "";
            this.txtTipoVoucher.Enabled = false;
            this.txtTipoVoucher.Location = new System.Drawing.Point(523, 5);
            this.txtTipoVoucher.Name = "txtTipoVoucher";
            this.txtTipoVoucher.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoVoucher.Size = new System.Drawing.Size(31, 20);
            this.txtTipoVoucher.TabIndex = 14;
            // 
            // chkVoucher
            // 
            this.chkVoucher.EditValue = true;
            this.chkVoucher.Location = new System.Drawing.Point(508, 4);
            this.chkVoucher.Name = "chkVoucher";
            this.chkVoucher.Properties.Caption = "";
            this.chkVoucher.Size = new System.Drawing.Size(16, 19);
            this.chkVoucher.TabIndex = 13;
            this.chkVoucher.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(464, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Voucher:";
            // 
            // txtVoucherIni
            // 
            this.txtVoucherIni.EditValue = "";
            this.txtVoucherIni.Enabled = false;
            this.txtVoucherIni.Location = new System.Drawing.Point(557, 5);
            this.txtVoucherIni.Name = "txtVoucherIni";
            this.txtVoucherIni.Properties.Mask.EditMask = "0000";
            this.txtVoucherIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtVoucherIni.Size = new System.Drawing.Size(42, 20);
            this.txtVoucherIni.TabIndex = 15;
            // 
            // txtVoucherFin
            // 
            this.txtVoucherFin.EditValue = "";
            this.txtVoucherFin.Enabled = false;
            this.txtVoucherFin.Location = new System.Drawing.Point(613, 5);
            this.txtVoucherFin.Name = "txtVoucherFin";
            this.txtVoucherFin.Properties.Mask.EditMask = "0000";
            this.txtVoucherFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtVoucherFin.Size = new System.Drawing.Size(42, 20);
            this.txtVoucherFin.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(603, 8);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(4, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "-";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 87);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 23);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(75, 87);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnPasarPend
            // 
            this.btnPasarPend.Location = new System.Drawing.Point(231, 87);
            this.btnPasarPend.Name = "btnPasarPend";
            this.btnPasarPend.Size = new System.Drawing.Size(75, 23);
            this.btnPasarPend.TabIndex = 14;
            this.btnPasarPend.Text = "&Pasar Pend.";
            this.btnPasarPend.Click += new System.EventHandler(this.btnPasarPend_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(153, 87);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 13;
            this.btnAprobar.Text = "&Aprobar";
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(465, 87);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(387, 87);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 16;
            this.btnCopiar.Text = "&Copiar";
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(309, 87);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 15;
            this.btnAnular.Text = "A&nular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // Periodo
            // 
            this.Periodo.Caption = "Periodo";
            this.Periodo.FieldName = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.Visible = true;
            this.Periodo.VisibleIndex = 0;
            this.Periodo.Width = 60;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 1;
            this.Fecha.Width = 70;
            // 
            // IdVoucher
            // 
            this.IdVoucher.Caption = "Voucher";
            this.IdVoucher.FieldName = "IdVoucher";
            this.IdVoucher.Name = "IdVoucher";
            this.IdVoucher.Visible = true;
            this.IdVoucher.VisibleIndex = 2;
            this.IdVoucher.Width = 60;
            // 
            // DepartNombre
            // 
            this.DepartNombre.Caption = "Departamento";
            this.DepartNombre.FieldName = "DepartNombre";
            this.DepartNombre.Name = "DepartNombre";
            this.DepartNombre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdVoucher", "{0}  Fila(s).")});
            this.DepartNombre.Visible = true;
            this.DepartNombre.VisibleIndex = 3;
            this.DepartNombre.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 4;
            this.Descripcion.Width = 200;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 5;
            this.Estado.Width = 65;
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
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.Caption = "U.Registro";
            this.UsuarioRegistro.FieldName = "UsuarioRegistro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.Visible = true;
            this.UsuarioRegistro.VisibleIndex = 6;
            this.UsuarioRegistro.Width = 80;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.Caption = "F.Registro";
            this.FechaRegistro.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaRegistro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaRegistro.FieldName = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Visible = true;
            this.FechaRegistro.VisibleIndex = 7;
            this.FechaRegistro.Width = 115;
            // 
            // Origen
            // 
            this.Origen.Caption = "Origen";
            this.Origen.ColumnEdit = this.rilueOrigen;
            this.Origen.FieldName = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.Visible = true;
            this.Origen.VisibleIndex = 8;
            this.Origen.Width = 60;
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
            // FlagModManual
            // 
            this.FlagModManual.Caption = "Mod.Manual";
            this.FlagModManual.ColumnEdit = this.riceModManual;
            this.FlagModManual.FieldName = "FlagModManual";
            this.FlagModManual.Name = "FlagModManual";
            this.FlagModManual.Visible = true;
            this.FlagModManual.VisibleIndex = 9;
            this.FlagModManual.Width = 70;
            // 
            // riceModManual
            // 
            this.riceModManual.AutoHeight = false;
            this.riceModManual.Name = "riceModManual";
            this.riceModManual.ValueChecked = "S";
            this.riceModManual.ValueUnchecked = "N";
            // 
            // FlagModRestringida
            // 
            this.FlagModRestringida.Caption = "Mod.Rest.";
            this.FlagModRestringida.ColumnEdit = this.riceModRestr;
            this.FlagModRestringida.FieldName = "FlagModRestringida";
            this.FlagModRestringida.Name = "FlagModRestringida";
            this.FlagModRestringida.Visible = true;
            this.FlagModRestringida.VisibleIndex = 10;
            this.FlagModRestringida.Width = 70;
            // 
            // riceModRestr
            // 
            this.riceModRestr.AutoHeight = false;
            this.riceModRestr.Name = "riceModRestr";
            this.riceModRestr.ValueChecked = "S";
            this.riceModRestr.ValueUnchecked = "N";
            // 
            // UsuarioAprobacion
            // 
            this.UsuarioAprobacion.Caption = "U.Aprobacion";
            this.UsuarioAprobacion.FieldName = "UsuarioAprobacion";
            this.UsuarioAprobacion.Name = "UsuarioAprobacion";
            this.UsuarioAprobacion.Visible = true;
            this.UsuarioAprobacion.VisibleIndex = 11;
            this.UsuarioAprobacion.Width = 80;
            // 
            // FechaAprobacion
            // 
            this.FechaAprobacion.Caption = "F.Aprobacion";
            this.FechaAprobacion.ColumnEdit = this.rideFecAprob;
            this.FechaAprobacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.FechaAprobacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.FechaAprobacion.FieldName = "FechaAprobacion";
            this.FechaAprobacion.Name = "FechaAprobacion";
            this.FechaAprobacion.Visible = true;
            this.FechaAprobacion.VisibleIndex = 12;
            this.FechaAprobacion.Width = 115;
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
            // UltimoUsuarioMod
            // 
            this.UltimoUsuarioMod.Caption = "Ult.Usu.Mod";
            this.UltimoUsuarioMod.FieldName = "UltimoUsuarioMod";
            this.UltimoUsuarioMod.Name = "UltimoUsuarioMod";
            this.UltimoUsuarioMod.Visible = true;
            this.UltimoUsuarioMod.VisibleIndex = 13;
            this.UltimoUsuarioMod.Width = 90;
            // 
            // UltimaFechaMod
            // 
            this.UltimaFechaMod.Caption = "Ult.Fec.Mod";
            this.UltimaFechaMod.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaMod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaMod.FieldName = "UltimaFechaMod";
            this.UltimaFechaMod.Name = "UltimaFechaMod";
            this.UltimaFechaMod.Visible = true;
            this.UltimaFechaMod.VisibleIndex = 14;
            this.UltimaFechaMod.Width = 115;
            // 
            // frmVoucherList
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Name = "frmVoucherList";
            this.Text = "Registro de Voucher";
            this.Load += new System.EventHandler(this.frmVoucherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherFin.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LookUpEdit cmbDepartamento;
        private DevExpress.XtraEditors.CheckEdit chkDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtVoucherFin;
        private DevExpress.XtraEditors.TextEdit txtVoucherIni;
        private DevExpress.XtraEditors.TextEdit txtTipoVoucher;
        private DevExpress.XtraEditors.CheckEdit chkVoucher;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnPasarPend;
        private DevExpress.XtraEditors.SimpleButton btnAprobar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnCopiar;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
        private DevExpress.XtraGrid.Columns.GridColumn Periodo;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdVoucher;
        private DevExpress.XtraGrid.Columns.GridColumn DepartNombre;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn FechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn Origen;
        private DevExpress.XtraGrid.Columns.GridColumn FlagModManual;
        private DevExpress.XtraGrid.Columns.GridColumn FlagModRestringida;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn FechaAprobacion;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuarioMod;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaMod;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModManual;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceModRestr;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueOrigen;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rideFecAprob;        
    }
}
