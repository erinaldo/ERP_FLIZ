namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    partial class frmAsientoModelo
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
            this.CiaNombreList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.DescripcionList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCCosto = new DevExpress.XtraEditors.SimpleButton();
            this.btnCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.grDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LineaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteCuenta = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.CentroCostoDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteMayus = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.DescripcionDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PorcentajeDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteMonto = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.UltimoUsuarioModDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riluOrigen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ritePersona = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.riceFlagAut = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rideFecha = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtDesde = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMayus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagAut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecha.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(549, 454);
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado});
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CiaNombreList,
            this.ModeloList,
            this.DescripcionList,
            this.Estado,
            this.UltimoUsuario,
            this.UltimaFechaModificacion});
            this.gvDatos.OptionsBehavior.Editable = false;
            this.gvDatos.OptionsBehavior.ReadOnly = true;
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.txtDesde);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.grDetalle);
            this.pnlCuerpo.Controls.Add(this.btnCCosto);
            this.pnlCuerpo.Controls.Add(this.btnCuenta);
            this.pnlCuerpo.Controls.Add(this.btnEliminar);
            this.pnlCuerpo.Controls.Add(this.btnAgregar);
            this.pnlCuerpo.Controls.Add(this.cmbCompania);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbEstado);
            this.pnlCuerpo.Controls.Add(this.txtDescripcion);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtModelo);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(546, 419);
            // 
            // pnMain
            // 
            this.pnMain.Size = new System.Drawing.Size(553, 458);
            // 
            // CiaNombreList
            // 
            this.CiaNombreList.Caption = "Compania";
            this.CiaNombreList.FieldName = "CiaNombre";
            this.CiaNombreList.Name = "CiaNombreList";
            this.CiaNombreList.Visible = true;
            this.CiaNombreList.VisibleIndex = 0;
            this.CiaNombreList.Width = 139;
            // 
            // ModeloList
            // 
            this.ModeloList.Caption = "Modelo";
            this.ModeloList.FieldName = "Modelo";
            this.ModeloList.Name = "ModeloList";
            this.ModeloList.Visible = true;
            this.ModeloList.VisibleIndex = 1;
            this.ModeloList.Width = 66;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 77;
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
            // UltimoUsuario
            // 
            this.UltimoUsuario.Caption = "Ult.Usu.Mod";
            this.UltimoUsuario.FieldName = "UltimoUsuarioMod";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 4;
            this.UltimoUsuario.Width = 88;
            // 
            // UltimaFechaModificacion
            // 
            this.UltimaFechaModificacion.Caption = "Ult.Fec.Mod";
            this.UltimaFechaModificacion.FieldName = "UltimaFechaMod";
            this.UltimaFechaModificacion.Name = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModificacion.Visible = true;
            this.UltimaFechaModificacion.VisibleIndex = 5;
            this.UltimaFechaModificacion.Width = 126;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Módelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(87, 32);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Properties.MaxLength = 5;
            this.txtModelo.Size = new System.Drawing.Size(76, 20);
            this.txtModelo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 56);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(452, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(87, 78);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(326, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(326, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(401, 12);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(138, 20);
            this.txtUltimoUsuario.TabIndex = 17;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(401, 34);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(138, 20);
            this.txtUltimaFecha.TabIndex = 18;
            // 
            // DescripcionList
            // 
            this.DescripcionList.Caption = "Descripcion";
            this.DescripcionList.FieldName = "Descripcion";
            this.DescripcionList.Name = "DescripcionList";
            this.DescripcionList.Visible = true;
            this.DescripcionList.VisibleIndex = 2;
            this.DescripcionList.Width = 328;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Compania:";
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(87, 11);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(138, 20);
            this.cmbCompania.TabIndex = 20;
            // 
            // btnCCosto
            // 
            this.btnCCosto.Location = new System.Drawing.Point(209, 103);
            this.btnCCosto.Name = "btnCCosto";
            this.btnCCosto.Size = new System.Drawing.Size(52, 23);
            this.btnCCosto.TabIndex = 24;
            this.btnCCosto.Text = "C.Costo";
            this.btnCCosto.Click += new System.EventHandler(this.btnCCosto_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(149, 103);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(57, 23);
            this.btnCuenta.TabIndex = 23;
            this.btnCuenta.Text = "&Cuenta";
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(84, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grDetalle
            // 
            this.grDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDetalle.Location = new System.Drawing.Point(10, 128);
            this.grDetalle.MainView = this.gvDetalle;
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riluOrigen,
            this.ritePersona,
            this.riceFlagAut,
            this.riteCuenta,
            this.riteMayus,
            this.rideFecha,
            this.riteMonto});
            this.grDetalle.Size = new System.Drawing.Size(529, 235);
            this.grDetalle.TabIndex = 26;
            this.grDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDetalle.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LineaDet,
            this.CuentaDet,
            this.CentroCostoDet,
            this.DescripcionDet,
            this.PorcentajeDet,
            this.UltimoUsuarioModDet,
            this.UltimaFechaModDet});
            this.gvDetalle.GridControl = this.grDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsCustomization.AllowFilter = false;
            this.gvDetalle.OptionsCustomization.AllowGroup = false;
            this.gvDetalle.OptionsCustomization.AllowSort = false;
            this.gvDetalle.OptionsDetail.EnableMasterViewMode = false;
            this.gvDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvDetalle.OptionsView.ShowFooter = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            this.gvDetalle.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvDetalle_CustomSummaryCalculate);
            this.gvDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDetalle_CellValueChanged);
            this.gvDetalle.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvDetalle_InvalidRowException);
            this.gvDetalle.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDetalle_ValidateRow);
            this.gvDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDetalle_KeyDown);
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
            this.LineaDet.Width = 27;
            // 
            // CuentaDet
            // 
            this.CuentaDet.Caption = "Cuenta";
            this.CuentaDet.ColumnEdit = this.riteCuenta;
            this.CuentaDet.FieldName = "Cuenta";
            this.CuentaDet.Name = "CuentaDet";
            this.CuentaDet.Visible = true;
            this.CuentaDet.VisibleIndex = 1;
            this.CuentaDet.Width = 68;
            // 
            // riteCuenta
            // 
            this.riteCuenta.AutoHeight = false;
            this.riteCuenta.Mask.EditMask = "[0-9]+";
            this.riteCuenta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.riteCuenta.MaxLength = 7;
            this.riteCuenta.Name = "riteCuenta";
            // 
            // CentroCostoDet
            // 
            this.CentroCostoDet.Caption = "C.Costo";
            this.CentroCostoDet.ColumnEdit = this.riteMayus;
            this.CentroCostoDet.FieldName = "CentroCosto";
            this.CentroCostoDet.Name = "CentroCostoDet";
            this.CentroCostoDet.Visible = true;
            this.CentroCostoDet.VisibleIndex = 2;
            this.CentroCostoDet.Width = 54;
            // 
            // riteMayus
            // 
            this.riteMayus.AutoHeight = false;
            this.riteMayus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.riteMayus.Name = "riteMayus";
            // 
            // DescripcionDet
            // 
            this.DescripcionDet.Caption = "Descripción";
            this.DescripcionDet.FieldName = "Descripcion";
            this.DescripcionDet.Name = "DescripcionDet";
            this.DescripcionDet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Descripcion", "Total")});
            this.DescripcionDet.Visible = true;
            this.DescripcionDet.VisibleIndex = 3;
            this.DescripcionDet.Width = 269;
            // 
            // PorcentajeDet
            // 
            this.PorcentajeDet.Caption = "Porc. (%)";
            this.PorcentajeDet.ColumnEdit = this.riteMonto;
            this.PorcentajeDet.FieldName = "Porcentaje";
            this.PorcentajeDet.Name = "PorcentajeDet";
            this.PorcentajeDet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.PorcentajeDet.Visible = true;
            this.PorcentajeDet.VisibleIndex = 4;
            this.PorcentajeDet.Width = 66;
            // 
            // riteMonto
            // 
            this.riteMonto.AutoHeight = false;
            this.riteMonto.DisplayFormat.FormatString = "N2";
            this.riteMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riteMonto.Mask.EditMask = "N2";
            this.riteMonto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteMonto.Name = "riteMonto";
            // 
            // UltimoUsuarioModDet
            // 
            this.UltimoUsuarioModDet.Caption = "Ult.Usu.Mod";
            this.UltimoUsuarioModDet.FieldName = "UltimoUsuarioMod";
            this.UltimoUsuarioModDet.Name = "UltimoUsuarioModDet";
            this.UltimoUsuarioModDet.OptionsColumn.AllowEdit = false;
            this.UltimoUsuarioModDet.OptionsColumn.ReadOnly = true;
            this.UltimoUsuarioModDet.Visible = true;
            this.UltimoUsuarioModDet.VisibleIndex = 5;
            this.UltimoUsuarioModDet.Width = 84;
            // 
            // UltimaFechaModDet
            // 
            this.UltimaFechaModDet.Caption = "Ult.Fec.Mod";
            this.UltimaFechaModDet.FieldName = "UltimaFechaMod";
            this.UltimaFechaModDet.Name = "UltimaFechaModDet";
            this.UltimaFechaModDet.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModDet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModDet.OptionsColumn.AllowEdit = false;
            this.UltimaFechaModDet.OptionsColumn.ReadOnly = true;
            this.UltimaFechaModDet.Visible = true;
            this.UltimaFechaModDet.VisibleIndex = 6;
            this.UltimaFechaModDet.Width = 109;
            // 
            // riluOrigen
            // 
            this.riluOrigen.AutoHeight = false;
            this.riluOrigen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riluOrigen.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.riluOrigen.Name = "riluOrigen";
            // 
            // ritePersona
            // 
            this.ritePersona.Mask.EditMask = "d";
            this.ritePersona.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ritePersona.Name = "ritePersona";
            // 
            // riceFlagAut
            // 
            this.riceFlagAut.AutoHeight = false;
            this.riceFlagAut.Name = "riceFlagAut";
            this.riceFlagAut.ValueChecked = "S";
            this.riceFlagAut.ValueUnchecked = "N";
            // 
            // rideFecha
            // 
            this.rideFecha.AutoHeight = false;
            this.rideFecha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rideFecha.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rideFecha.Name = "rideFecha";
            this.rideFecha.NullDate = new System.DateTime(((long)(0)));
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(473, 78);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesde.Properties.Mask.EditMask = "D";
            this.txtDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDesde.Properties.MaxLength = 4;
            this.txtDesde.Size = new System.Drawing.Size(66, 20);
            this.txtDesde.TabIndex = 28;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(433, 80);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 27;
            this.labelControl7.Text = "Desde:";
            // 
            // frmAsientoModelo
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 458);
            this.Name = "frmAsientoModelo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsientoModelo_FormClosing);
            this.Load += new System.EventHandler(this.frmAsientoModelo_Load);
            this.Shown += new System.EventHandler(this.frmAsientoModelo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMayus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riluOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagAut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecha.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesde.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn CiaNombreList;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloList;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionList;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.SimpleButton btnCCosto;
        private DevExpress.XtraEditors.SimpleButton btnCuenta;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        protected DevExpress.XtraGrid.GridControl grDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagAut;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteCuenta;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritePersona;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteMayus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riluOrigen;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rideFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteMonto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn LineaDet;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaDet;
        private DevExpress.XtraGrid.Columns.GridColumn CentroCostoDet;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionDet;
        private DevExpress.XtraGrid.Columns.GridColumn PorcentajeDet;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuarioModDet;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModDet;
        private DevExpress.XtraEditors.TextEdit txtDesde;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
