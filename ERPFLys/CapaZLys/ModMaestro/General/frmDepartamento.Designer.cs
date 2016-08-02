namespace FiltroLys.ZLys.ModMaestro.General
{
    partial class frmDepartamento
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
            this.txtDepartamento = new DevExpress.XtraEditors.TextEdit();
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
            this.CodigoDepFedd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCodigoDepf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.DepartamentoCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Provincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlagProv = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Ubigeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPais = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProvincia = new DevExpress.XtraEditors.LookUpEdit();
            this.txtUbigeo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDepf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbigeo.Properties)).BeginInit();
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
            this.Descripcion,
            this.Estado,
            this.UltimoUsuario,
            this.UltimaFechaModificacion,
            this.CodigoDepFedd,
            this.Provincia,
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
            this.pnlCuerpo.Controls.Add(this.txtUbigeo);
            this.pnlCuerpo.Controls.Add(this.labelControl9);
            this.pnlCuerpo.Controls.Add(this.cmbProvincia);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.cmbPais);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.txtCodigoDepf);
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
            this.pnlCuerpo.Controls.Add(this.txtDepartamento);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            this.Descripcion.Width = 257;
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
            this.UltimoUsuario.FieldName = "UltimoUsuario";
            this.UltimoUsuario.Name = "UltimoUsuario";
            this.UltimoUsuario.Visible = true;
            this.UltimoUsuario.VisibleIndex = 4;
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
            this.UltimaFechaModificacion.VisibleIndex = 5;
            this.UltimaFechaModificacion.Width = 114;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(87, 44);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Properties.MaxLength = 4;
            this.txtDepartamento.Size = new System.Drawing.Size(68, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 50;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(87, 100);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 242);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(87, 212);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 8;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(87, 240);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 10;
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
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(203, 212);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 9;
            // 
            // CodigoDepFedd
            // 
            this.CodigoDepFedd.Caption = "Código Depf";
            this.CodigoDepFedd.FieldName = "CodigoDepFedd";
            this.CodigoDepFedd.Name = "CodigoDepFedd";
            this.CodigoDepFedd.Visible = true;
            this.CodigoDepFedd.VisibleIndex = 6;
            this.CodigoDepFedd.Width = 69;
            // 
            // txtCodigoDepf
            // 
            this.txtCodigoDepf.Location = new System.Drawing.Point(87, 128);
            this.txtCodigoDepf.Name = "txtCodigoDepf";
            this.txtCodigoDepf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDepf.Properties.MaxLength = 5;
            this.txtCodigoDepf.Size = new System.Drawing.Size(68, 20);
            this.txtCodigoDepf.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 129);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Código Depf:";
            // 
            // DepartamentoCodigo
            // 
            this.DepartamentoCodigo.Caption = "Dep.Código";
            this.DepartamentoCodigo.FieldName = "DepartamentoCodigo";
            this.DepartamentoCodigo.Name = "DepartamentoCodigo";
            this.DepartamentoCodigo.Visible = true;
            this.DepartamentoCodigo.VisibleIndex = 1;
            this.DepartamentoCodigo.Width = 66;
            // 
            // Provincia
            // 
            this.Provincia.AppearanceCell.Options.UseTextOptions = true;
            this.Provincia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Provincia.Caption = "Provincia";
            this.Provincia.ColumnEdit = this.riceFlagProv;
            this.Provincia.FieldName = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.Visible = true;
            this.Provincia.VisibleIndex = 7;
            this.Provincia.Width = 61;
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
            this.Ubigeo.VisibleIndex = 8;
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
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 13);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(23, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "País:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 158);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Provincia:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.Location = new System.Drawing.Point(87, 156);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProvincia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbProvincia.Size = new System.Drawing.Size(68, 20);
            this.cmbProvincia.TabIndex = 6;
            // 
            // txtUbigeo
            // 
            this.txtUbigeo.Location = new System.Drawing.Point(87, 184);
            this.txtUbigeo.Name = "txtUbigeo";
            this.txtUbigeo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUbigeo.Properties.MaxLength = 5;
            this.txtUbigeo.Size = new System.Drawing.Size(68, 20);
            this.txtUbigeo.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 186);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "Ubigeo:";
            // 
            // frmDepartamento
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmDepartamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            this.Shown += new System.EventHandler(this.frmDepartamento_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoDepf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlagProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvincia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUbigeo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtDepartamento;
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
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDepFedd;
        private DevExpress.XtraEditors.TextEdit txtCodigoDepf;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn DepartamentoCodigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlagProv;
        private DevExpress.XtraGrid.Columns.GridColumn Provincia;
        private DevExpress.XtraGrid.Columns.GridColumn Ubigeo;
        private DevExpress.XtraEditors.TextEdit txtUbigeo;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cmbProvincia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbPais;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
