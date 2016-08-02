namespace FiltroLys.ZLys.ModMaestro.General
{
    partial class frmDistrito
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
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDistrito = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.Pais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.CodigoDistFedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigoDistf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.DepartamentoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlagProv = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Ubigeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPais = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUbigeo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.DepartamentoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProvinciaCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbDepartamento = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.DistritoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProvinciaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProvincia = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDistf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbigeo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado,
            this.riceFlags,
            this.riceFlagProv});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Pais,
            this.DepartamentoCodigo,
            this.DepartamentoNombre,
            this.ProvinciaCodigo,
            this.ProvinciaNombre,
            this.DistritoCodigo,
            this.Descripcion,
            this.Estado,
            this.UltimoUsuario,
            this.UltimaFechaModificacion,
            this.CodigoDistFedd,
            this.Ubigeo});
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
            this.pnlCuerpo.Controls.Add(this.cmbProvincia);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.cmbDepartamento);
            this.pnlCuerpo.Controls.Add(this.labelControl10);
            this.pnlCuerpo.Controls.Add(this.txtUbigeo);
            this.pnlCuerpo.Controls.Add(this.labelControl9);
            this.pnlCuerpo.Controls.Add(this.cmbPais);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.txtCodigoDistf);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbEstado);
            this.pnlCuerpo.Controls.Add(this.txtDescripcion);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtDistrito);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 6;
            this.Descripcion.Width = 142;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
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
            this.UltimoUsuario.FieldName = "UltimoUsuario";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 8;
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
            this.UltimaFechaModificacion.VisibleIndex = 9;
            this.UltimaFechaModificacion.Width = 114;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 94);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Distrito Cod:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(87, 96);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistrito.Properties.MaxLength = 4;
            this.txtDistrito.Size = new System.Drawing.Size(68, 20);
            this.txtDistrito.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(87, 151);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 239);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 266);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(87, 236);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 9;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(87, 264);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 11;
            // 
            // Pais
            // 
            this.Pais.Caption = "Pais";
            this.Pais.FieldName = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.Visible = true;
            this.Pais.VisibleIndex = 0;
            this.Pais.Width = 51;
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
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(203, 236);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 10;
            // 
            // CodigoDistFedd
            // 
            this.CodigoDistFedd.Caption = "Código Distf.";
            this.CodigoDistFedd.FieldName = "CodigoDistFedd";
            this.CodigoDistFedd.Name = "CodigoDistFedd";
            this.CodigoDistFedd.Visible = true;
            this.CodigoDistFedd.VisibleIndex = 10;
            // 
            // txtCodigoDistf
            // 
            this.txtCodigoDistf.Location = new System.Drawing.Point(87, 179);
            this.txtCodigoDistf.Name = "txtCodigoDistf";
            this.txtCodigoDistf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDistf.Properties.MaxLength = 5;
            this.txtCodigoDistf.Size = new System.Drawing.Size(68, 20);
            this.txtCodigoDistf.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 180);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Código Distf:";
            // 
            // DepartamentoCodigo
            // 
            this.DepartamentoCodigo.Caption = "D.C";
            this.DepartamentoCodigo.FieldName = "DepartamentoCodigo";
            this.DepartamentoCodigo.Name = "DepartamentoCodigo";
            this.DepartamentoCodigo.Visible = true;
            this.DepartamentoCodigo.VisibleIndex = 1;
            this.DepartamentoCodigo.Width = 30;
            // 
            // riceFlagProv
            // 
            this.riceFlagProv.AutoHeight = false;
            this.riceFlagProv.Name = "riceFlagProv";
            this.riceFlagProv.ValueChecked = "S";
            this.riceFlagProv.ValueUnchecked = "N";
            // 
            // Ubigeo
            // 
            this.Ubigeo.Caption = "Ubigeo";
            this.Ubigeo.FieldName = "Ubigeo";
            this.Ubigeo.Name = "Ubigeo";
            this.Ubigeo.Visible = true;
            this.Ubigeo.VisibleIndex = 11;
            this.Ubigeo.Width = 62;
            // 
            // cmbPais
            // 
            this.cmbPais.Location = new System.Drawing.Point(87, 16);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPais.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pais", 30, "Pais"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Descripcion")});
            this.cmbPais.Size = new System.Drawing.Size(288, 20);
            this.cmbPais.TabIndex = 1;
            this.cmbPais.EditValueChanged += new System.EventHandler(this.cmbPais_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "País:";
            // 
            // txtUbigeo
            // 
            this.txtUbigeo.Location = new System.Drawing.Point(87, 208);
            this.txtUbigeo.Name = "txtUbigeo";
            this.txtUbigeo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUbigeo.Properties.MaxLength = 5;
            this.txtUbigeo.Size = new System.Drawing.Size(68, 20);
            this.txtUbigeo.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 210);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Ubigeo:";
            // 
            // DepartamentoNombre
            // 
            this.DepartamentoNombre.Caption = "Departamento";
            this.DepartamentoNombre.FieldName = "DepartamentoNombre";
            this.DepartamentoNombre.Name = "DepartamentoNombre";
            this.DepartamentoNombre.Visible = true;
            this.DepartamentoNombre.VisibleIndex = 2;
            this.DepartamentoNombre.Width = 124;
            // 
            // ProvinciaCodigo
            // 
            this.ProvinciaCodigo.Caption = "P.C";
            this.ProvinciaCodigo.FieldName = "ProvinciaCodigo";
            this.ProvinciaCodigo.Name = "ProvinciaCodigo";
            this.ProvinciaCodigo.Visible = true;
            this.ProvinciaCodigo.VisibleIndex = 3;
            this.ProvinciaCodigo.Width = 36;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Location = new System.Drawing.Point(87, 43);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamento.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartamentoCodigo", 30, "Dep"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Descripcion")});
            this.cmbDepartamento.Size = new System.Drawing.Size(288, 20);
            this.cmbDepartamento.TabIndex = 2;
            this.cmbDepartamento.EditValueChanged += new System.EventHandler(this.cmbDepartamento_EditValueChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 41);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(73, 13);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "Departamento:";
            // 
            // DistritoCodigo
            // 
            this.DistritoCodigo.Caption = "Dist.C";
            this.DistritoCodigo.FieldName = "DistritoCodigo";
            this.DistritoCodigo.Name = "DistritoCodigo";
            this.DistritoCodigo.Visible = true;
            this.DistritoCodigo.VisibleIndex = 5;
            this.DistritoCodigo.Width = 39;
            // 
            // ProvinciaNombre
            // 
            this.ProvinciaNombre.Caption = "Provincia";
            this.ProvinciaNombre.FieldName = "ProvinciaNombre";
            this.ProvinciaNombre.Name = "ProvinciaNombre";
            this.ProvinciaNombre.Visible = true;
            this.ProvinciaNombre.VisibleIndex = 4;
            this.ProvinciaNombre.Width = 124;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.Location = new System.Drawing.Point(87, 70);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProvincia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProvinciaCodigo", 30, "Prov"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Descripcion")});
            this.cmbProvincia.Size = new System.Drawing.Size(288, 20);
            this.cmbProvincia.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 68);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Provincia:";
            // 
            // frmDistrito
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmDistrito";
            this.Load += new System.EventHandler(this.frmDistrito_Load);
            this.Shown += new System.EventHandler(this.frmDistrito_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDistrito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDistf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbigeo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtDistrito;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn Pais;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDistFedd;
        private DevExpress.XtraEditors.TextEdit txtCodigoDistf;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn DepartamentoCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagProv;
        private DevExpress.XtraGrid.Columns.GridColumn Ubigeo;
        private DevExpress.XtraEditors.TextEdit txtUbigeo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cmbPais;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn DepartamentoNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ProvinciaCodigo;
        private DevExpress.XtraEditors.LookUpEdit cmbDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.Columns.GridColumn ProvinciaNombre;
        private DevExpress.XtraGrid.Columns.GridColumn DistritoCodigo;
        private DevExpress.XtraEditors.LookUpEdit cmbProvincia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
