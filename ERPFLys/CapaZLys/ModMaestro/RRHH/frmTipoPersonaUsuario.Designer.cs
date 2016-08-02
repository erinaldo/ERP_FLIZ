namespace FiltroLys.ZLys.ModMaestro.RRHH
{
    partial class frmTipoPersonaUsuario
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
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.TipoPersonaUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.FlagProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.FlagEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlagCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFlagCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbFlagEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbFlagProveedor = new DevExpress.XtraEditors.LookUpEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagProveedor.Properties)).BeginInit();
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
            this.riceCheckBox});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoPersonaUsuario,
            this.Descripcion,
            this.FlagCliente,
            this.FlagEmpleado,
            this.FlagProveedor,
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
            this.lblTitulo.Size = new System.Drawing.Size(0, 35);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.cmbFlagProveedor);
            this.pnlCuerpo.Controls.Add(this.labelControl8);
            this.pnlCuerpo.Controls.Add(this.cmbFlagEmpleado);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.cmbFlagCliente);
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
            this.pnlCuerpo.Controls.Add(this.txtTipo);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            this.Descripcion.Width = 312;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 5;
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
            this.UltimoUsuario.VisibleIndex = 6;
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
            this.UltimaFechaModificacion.VisibleIndex = 7;
            this.UltimaFechaModificacion.Width = 114;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(87, 22);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Properties.MaxLength = 3;
            this.txtTipo.Size = new System.Drawing.Size(66, 20);
            this.txtTipo.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 172);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 51);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.MaxLength = 60;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(87, 171);
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
            this.labelControl4.Location = new System.Drawing.Point(10, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 243);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(87, 219);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 7;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(87, 248);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 9;
            // 
            // TipoPersonaUsuario
            // 
            this.TipoPersonaUsuario.Caption = "Tipo";
            this.TipoPersonaUsuario.FieldName = "TipoPersonaUsuario";
            this.TipoPersonaUsuario.Name = "TipoPersonaUsuario";
            this.TipoPersonaUsuario.Visible = true;
            this.TipoPersonaUsuario.VisibleIndex = 0;
            this.TipoPersonaUsuario.Width = 64;
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
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(203, 219);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 8;
            // 
            // FlagProveedor
            // 
            this.FlagProveedor.AppearanceCell.Options.UseTextOptions = true;
            this.FlagProveedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagProveedor.Caption = "Flag Proveedor";
            this.FlagProveedor.ColumnEdit = this.riceCheckBox;
            this.FlagProveedor.FieldName = "FlagProveedor";
            this.FlagProveedor.Name = "FlagProveedor";
            this.FlagProveedor.Visible = true;
            this.FlagProveedor.VisibleIndex = 4;
            this.FlagProveedor.Width = 95;
            // 
            // riceCheckBox
            // 
            this.riceCheckBox.AutoHeight = false;
            this.riceCheckBox.Name = "riceCheckBox";
            this.riceCheckBox.ValueChecked = "S";
            this.riceCheckBox.ValueUnchecked = "N";
            // 
            // FlagEmpleado
            // 
            this.FlagEmpleado.AppearanceCell.Options.UseTextOptions = true;
            this.FlagEmpleado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagEmpleado.Caption = "Flag Empleado";
            this.FlagEmpleado.ColumnEdit = this.riceCheckBox;
            this.FlagEmpleado.FieldName = "FlagEmpleado";
            this.FlagEmpleado.Name = "FlagEmpleado";
            this.FlagEmpleado.Visible = true;
            this.FlagEmpleado.VisibleIndex = 3;
            this.FlagEmpleado.Width = 88;
            // 
            // FlagCliente
            // 
            this.FlagCliente.AppearanceCell.Options.UseTextOptions = true;
            this.FlagCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagCliente.Caption = "Flag Cliente";
            this.FlagCliente.ColumnEdit = this.riceCheckBox;
            this.FlagCliente.FieldName = "FlagCliente";
            this.FlagCliente.Name = "FlagCliente";
            this.FlagCliente.Visible = true;
            this.FlagCliente.VisibleIndex = 2;
            // 
            // cmbFlagCliente
            // 
            this.cmbFlagCliente.Location = new System.Drawing.Point(87, 81);
            this.cmbFlagCliente.Name = "cmbFlagCliente";
            this.cmbFlagCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFlagCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbFlagCliente.Size = new System.Drawing.Size(66, 20);
            this.cmbFlagCliente.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Flag Cliente:";
            // 
            // cmbFlagEmpleado
            // 
            this.cmbFlagEmpleado.Location = new System.Drawing.Point(87, 112);
            this.cmbFlagEmpleado.Name = "cmbFlagEmpleado";
            this.cmbFlagEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFlagEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbFlagEmpleado.Size = new System.Drawing.Size(66, 20);
            this.cmbFlagEmpleado.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 112);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Flag Empleado:";
            // 
            // cmbFlagProveedor
            // 
            this.cmbFlagProveedor.Location = new System.Drawing.Point(87, 142);
            this.cmbFlagProveedor.Name = "cmbFlagProveedor";
            this.cmbFlagProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFlagProveedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbFlagProveedor.Size = new System.Drawing.Size(66, 20);
            this.cmbFlagProveedor.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 142);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "Flag Proveedor:";
            // 
            // frmTipoPersonaUsuario
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmTipoPersonaUsuario";
            this.Load += new System.EventHandler(this.frmTipoPersonaUsuario_Load);
            this.Shown += new System.EventHandler(this.frmTipoPersonaUsuario_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFlagProveedor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtTipo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn TipoPersonaUsuario;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn FlagCliente;
        private DevExpress.XtraGrid.Columns.GridColumn FlagEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn FlagProveedor;
        private DevExpress.XtraEditors.LookUpEdit cmbFlagProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbFlagEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cmbFlagCliente;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
