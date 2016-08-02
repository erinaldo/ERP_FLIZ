namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    partial class frmLineaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLineaProducto));
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoBien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueTipoBien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbTipoBien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.LineaProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.riceFlagProv = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.rilueControl = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rilueTipoActivo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmbTipoActivo = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CompaniaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CtaDepreciacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtCtaContable = new DevExpress.XtraEditors.TextEdit();
            this.btnCtaContable = new DevExpress.XtraEditors.SimpleButton();
            this.btnCtaDepreciacion = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtCtaDepreciacion = new DevExpress.XtraEditors.TextEdit();
            this.TipoActivoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueTipoBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoBien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueTipoActivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaContable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaDepreciacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueTipoBien,
            this.riceFlags,
            this.riceFlagProv,
            this.rilueControl,
            this.rilueTipoActivo});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CompaniaNombre,
            this.LineaProducto,
            this.Descripcion,
            this.CuentaContable,
            this.TipoActivoNombre,
            this.TipoBien,
            this.CtaDepreciacion,
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
            this.lblTitulo.Size = new System.Drawing.Size(0, 35);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.btnCtaDepreciacion);
            this.pnlCuerpo.Controls.Add(this.labelControl10);
            this.pnlCuerpo.Controls.Add(this.txtCtaDepreciacion);
            this.pnlCuerpo.Controls.Add(this.btnCtaContable);
            this.pnlCuerpo.Controls.Add(this.labelControl9);
            this.pnlCuerpo.Controls.Add(this.txtCtaContable);
            this.pnlCuerpo.Controls.Add(this.cmbCompania);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.cmbTipoActivo);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbTipoBien);
            this.pnlCuerpo.Controls.Add(this.txtDescripcion);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtCodigo);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            this.Descripcion.Width = 245;
            // 
            // TipoBien
            // 
            this.TipoBien.Caption = "Tipo Bien";
            this.TipoBien.ColumnEdit = this.rilueTipoBien;
            this.TipoBien.FieldName = "TipoBien";
            this.TipoBien.Name = "TipoBien";
            this.TipoBien.Visible = true;
            this.TipoBien.VisibleIndex = 5;
            this.TipoBien.Width = 105;
            // 
            // rilueTipoBien
            // 
            this.rilueTipoBien.AutoHeight = false;
            this.rilueTipoBien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueTipoBien.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueTipoBien.Name = "rilueTipoBien";
            // 
            // UltimoUsuario
            // 
            this.UltimoUsuario.Caption = "Ult.Usu.Mod";
            this.UltimoUsuario.FieldName = "UltimoUsuario";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 7;
            this.UltimoUsuario.Width = 88;
            // 
            // UltimaFechaModificacion
            // 
            this.UltimaFechaModificacion.Caption = "Ult.Fec.Mod";
            this.UltimaFechaModificacion.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.UltimaFechaModificacion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UltimaFechaModificacion.FieldName = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Name = "UltimaFechaModificacion";
            this.UltimaFechaModificacion.Visible = true;
            this.UltimaFechaModificacion.VisibleIndex = 8;
            this.UltimaFechaModificacion.Width = 114;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Properties.MaxLength = 5;
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tipo Bien:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(332, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // cmbTipoBien
            // 
            this.cmbTipoBien.Location = new System.Drawing.Point(87, 154);
            this.cmbTipoBien.Name = "cmbTipoBien";
            this.cmbTipoBien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoBien.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTipoBien.Size = new System.Drawing.Size(186, 20);
            this.cmbTipoBien.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 183);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 211);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(87, 183);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 10;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(87, 212);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 12;
            // 
            // LineaProducto
            // 
            this.LineaProducto.Caption = "Código";
            this.LineaProducto.FieldName = "LineaProducto";
            this.LineaProducto.Name = "LineaProducto";
            this.LineaProducto.Visible = true;
            this.LineaProducto.VisibleIndex = 1;
            this.LineaProducto.Width = 46;
            // 
            // riceFlags
            // 
            this.riceFlags.AutoHeight = false;
            this.riceFlags.Name = "riceFlags";
            this.riceFlags.ValueChecked = "S";
            this.riceFlags.ValueUnchecked = "N";
            // 
            // txtUltimoUsuarioNombre
            // 
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(203, 183);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(216, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 11;
            // 
            // riceFlagProv
            // 
            this.riceFlagProv.AutoHeight = false;
            this.riceFlagProv.Name = "riceFlagProv";
            this.riceFlagProv.ValueChecked = "S";
            this.riceFlagProv.ValueUnchecked = "N";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Código:";
            // 
            // rilueControl
            // 
            this.rilueControl.AutoHeight = false;
            this.rilueControl.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueControl.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueControl.Name = "rilueControl";
            // 
            // rilueTipoActivo
            // 
            this.rilueTipoActivo.AutoHeight = false;
            this.rilueTipoActivo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueTipoActivo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueTipoActivo.Name = "rilueTipoActivo";
            // 
            // cmbTipoActivo
            // 
            this.cmbTipoActivo.Location = new System.Drawing.Point(87, 126);
            this.cmbTipoActivo.Name = "cmbTipoActivo";
            this.cmbTipoActivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoActivo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoActivo", 40, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbTipoActivo.Size = new System.Drawing.Size(186, 20);
            this.cmbTipoActivo.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Tipo Activo:";
            // 
            // CompaniaNombre
            // 
            this.CompaniaNombre.Caption = "Compania";
            this.CompaniaNombre.FieldName = "CompaniaNombre";
            this.CompaniaNombre.Name = "CompaniaNombre";
            this.CompaniaNombre.Visible = true;
            this.CompaniaNombre.VisibleIndex = 0;
            this.CompaniaNombre.Width = 146;
            // 
            // CuentaContable
            // 
            this.CuentaContable.Caption = "Cuenta Contable";
            this.CuentaContable.FieldName = "CuentaContable";
            this.CuentaContable.Name = "CuentaContable";
            this.CuentaContable.Visible = true;
            this.CuentaContable.VisibleIndex = 3;
            this.CuentaContable.Width = 89;
            // 
            // CtaDepreciacion
            // 
            this.CtaDepreciacion.Caption = "Cta. Depreciación";
            this.CtaDepreciacion.FieldName = "CtaDepreciacion";
            this.CtaDepreciacion.Name = "CtaDepreciacion";
            this.CtaDepreciacion.Visible = true;
            this.CtaDepreciacion.VisibleIndex = 6;
            this.CtaDepreciacion.Width = 108;
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(87, 14);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(150, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 15);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Compania:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 97);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(68, 13);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Cta.Contable:";
            // 
            // txtCtaContable
            // 
            this.txtCtaContable.Location = new System.Drawing.Point(87, 97);
            this.txtCtaContable.Name = "txtCtaContable";
            this.txtCtaContable.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCtaContable.Properties.Mask.EditMask = "n0";
            this.txtCtaContable.Properties.MaxLength = 10;
            this.txtCtaContable.Size = new System.Drawing.Size(68, 20);
            this.txtCtaContable.TabIndex = 4;
            this.txtCtaContable.Leave += new System.EventHandler(this.txtCtaContable_Leave);
            // 
            // btnCtaContable
            // 
            this.btnCtaContable.Image = ((System.Drawing.Image)(resources.GetObject("btnCtaContable.Image")));
            this.btnCtaContable.Location = new System.Drawing.Point(159, 97);
            this.btnCtaContable.Name = "btnCtaContable";
            this.btnCtaContable.Size = new System.Drawing.Size(25, 20);
            this.btnCtaContable.TabIndex = 5;
            this.btnCtaContable.Click += new System.EventHandler(this.btnCtaContable_Click);
            // 
            // btnCtaDepreciacion
            // 
            this.btnCtaDepreciacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCtaDepreciacion.Image")));
            this.btnCtaDepreciacion.Location = new System.Drawing.Point(394, 97);
            this.btnCtaDepreciacion.Name = "btnCtaDepreciacion";
            this.btnCtaDepreciacion.Size = new System.Drawing.Size(25, 20);
            this.btnCtaDepreciacion.TabIndex = 7;
            this.btnCtaDepreciacion.Click += new System.EventHandler(this.btnCtaDepreciacion_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(230, 97);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 13);
            this.labelControl10.TabIndex = 30;
            this.labelControl10.Text = "Cta.Depreciación:";
            // 
            // txtCtaDepreciacion
            // 
            this.txtCtaDepreciacion.Location = new System.Drawing.Point(322, 97);
            this.txtCtaDepreciacion.Name = "txtCtaDepreciacion";
            this.txtCtaDepreciacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCtaDepreciacion.Properties.MaxLength = 10;
            this.txtCtaDepreciacion.Size = new System.Drawing.Size(68, 20);
            this.txtCtaDepreciacion.TabIndex = 6;
            this.txtCtaDepreciacion.Leave += new System.EventHandler(this.txtCtaDepreciacion_Leave);
            // 
            // TipoActivoNombre
            // 
            this.TipoActivoNombre.Caption = "Tipo Activo";
            this.TipoActivoNombre.FieldName = "TipoActivoNombre";
            this.TipoActivoNombre.Name = "TipoActivoNombre";
            this.TipoActivoNombre.Visible = true;
            this.TipoActivoNombre.VisibleIndex = 4;
            this.TipoActivoNombre.Width = 102;
            // 
            // frmLineaProducto
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmLineaProducto";
            this.Load += new System.EventHandler(this.frmLineaProducto_Load);
            this.Shown += new System.EventHandler(this.frmLineaProducto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueTipoBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoBien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueTipoActivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaContable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCtaDepreciacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueTipoBien;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn TipoBien;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoBien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn LineaProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagProv;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueControl;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoActivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn CompaniaNombre;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaContable;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueTipoActivo;
        private DevExpress.XtraGrid.Columns.GridColumn CtaDepreciacion;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtCtaContable;
        private DevExpress.XtraEditors.SimpleButton btnCtaContable;
        private DevExpress.XtraEditors.SimpleButton btnCtaDepreciacion;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtCtaDepreciacion;
        private DevExpress.XtraGrid.Columns.GridColumn TipoActivoNombre;
    }
}
