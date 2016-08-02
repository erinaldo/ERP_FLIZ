namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    partial class frmRelCtaGenEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCtaGenEmp));
            this.TieneDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceTieneDestino = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaAnt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaNvo = new DevExpress.XtraEditors.TextEdit();
            this.cmbTieneDestino = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.CuentaAnt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDestinoDebe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CuentaNvoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaAntNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaNvo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaDestinoDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CuentaDestinoHaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDestinoHaber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaAntNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaNvoNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnDestinoDebe = new DevExpress.XtraEditors.SimpleButton();
            this.btnDestinoHaber = new DevExpress.XtraEditors.SimpleButton();
            this.btnCuentaAnt = new DevExpress.XtraEditors.SimpleButton();
            this.btnCuentaNvo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riceTieneDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaAnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNvo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTieneDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinoDebe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinoHaber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaAntNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNvoNombre.Properties)).BeginInit();
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
            this.riceTieneDestino});
            this.grControl.Size = new System.Drawing.Size(549, 394);
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CuentaAnt,
            this.CuentaAntNombre,
            this.CuentaNvo,
            this.CuentaNvoNombre,
            this.TieneDestino,
            this.CuentaDestinoDebe,
            this.CuentaDestinoHaber,
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
            this.pnlCuerpo.Controls.Add(this.btnCuentaNvo);
            this.pnlCuerpo.Controls.Add(this.btnCuentaAnt);
            this.pnlCuerpo.Controls.Add(this.btnDestinoHaber);
            this.pnlCuerpo.Controls.Add(this.btnDestinoDebe);
            this.pnlCuerpo.Controls.Add(this.txtCuentaNvoNombre);
            this.pnlCuerpo.Controls.Add(this.txtCuentaAntNombre);
            this.pnlCuerpo.Controls.Add(this.txtDestinoHaber);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.txtDestinoDebe);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbTieneDestino);
            this.pnlCuerpo.Controls.Add(this.txtCuentaNvo);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.txtCuentaAnt);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
           
            // 
            // TieneDestino
            // 
            this.TieneDestino.Caption = "Tiene Destino";
            this.TieneDestino.ColumnEdit = this.riceTieneDestino;
            this.TieneDestino.FieldName = "TieneDestino";
            this.TieneDestino.Name = "TieneDestino";
            this.TieneDestino.Visible = true;
            this.TieneDestino.VisibleIndex = 4;
            this.TieneDestino.Width = 93;
            // 
            // riceTieneDestino
            // 
            this.riceTieneDestino.AutoHeight = false;
            this.riceTieneDestino.Name = "riceTieneDestino";
            this.riceTieneDestino.ValueChecked = "S";
            this.riceTieneDestino.ValueUnchecked = "N";
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
            this.UltimoUsuario.VisibleIndex = 7;
            this.UltimoUsuario.Width = 93;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cuenta Anterior:";
            // 
            // txtCuentaAnt
            // 
            this.txtCuentaAnt.Location = new System.Drawing.Point(99, 15);
            this.txtCuentaAnt.Name = "txtCuentaAnt";
            this.txtCuentaAnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaAnt.Properties.Appearance.Options.UseFont = true;
            this.txtCuentaAnt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaAnt.Properties.MaxLength = 6;
            this.txtCuentaAnt.Size = new System.Drawing.Size(70, 20);
            this.txtCuentaAnt.TabIndex = 1;
            this.txtCuentaAnt.Leave += new System.EventHandler(this.txtCuentaAnt_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cuenta Nueva:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tiene Destino:";
            // 
            // txtCuentaNvo
            // 
            this.txtCuentaNvo.Location = new System.Drawing.Point(99, 46);
            this.txtCuentaNvo.Name = "txtCuentaNvo";
            this.txtCuentaNvo.Properties.MaxLength = 7;
            this.txtCuentaNvo.Size = new System.Drawing.Size(70, 20);
            this.txtCuentaNvo.TabIndex = 4;
            this.txtCuentaNvo.Leave += new System.EventHandler(this.txtCuentaNvo_Leave);
            // 
            // cmbTieneDestino
            // 
            this.cmbTieneDestino.Location = new System.Drawing.Point(99, 79);
            this.cmbTieneDestino.Name = "cmbTieneDestino";
            this.cmbTieneDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTieneDestino.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTieneDestino.Size = new System.Drawing.Size(113, 20);
            this.cmbTieneDestino.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(99, 146);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 12;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(99, 178);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 14;
            // 
            // CuentaAnt
            // 
            this.CuentaAnt.Caption = "Cuenta Ant";
            this.CuentaAnt.FieldName = "CuentaAnt";
            this.CuentaAnt.Name = "CuentaAnt";
            this.CuentaAnt.Visible = true;
            this.CuentaAnt.VisibleIndex = 0;
            this.CuentaAnt.Width = 72;
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
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(215, 146);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(263, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 13;
            // 
            // txtDestinoDebe
            // 
            this.txtDestinoDebe.Location = new System.Drawing.Point(99, 113);
            this.txtDestinoDebe.Name = "txtDestinoDebe";
            this.txtDestinoDebe.Properties.MaxLength = 100;
            this.txtDestinoDebe.Size = new System.Drawing.Size(70, 20);
            this.txtDestinoDebe.TabIndex = 8;
            this.txtDestinoDebe.Leave += new System.EventHandler(this.txtDestinoDebe_Leave);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Destino Debe:";
            // 
            // CuentaNvoNombre
            // 
            this.CuentaNvoNombre.Caption = "Cuenta Nueva(Nombre)";
            this.CuentaNvoNombre.FieldName = "CuentaNvoNombre";
            this.CuentaNvoNombre.Name = "CuentaNvoNombre";
            this.CuentaNvoNombre.Visible = true;
            this.CuentaNvoNombre.VisibleIndex = 3;
            this.CuentaNvoNombre.Width = 228;
            // 
            // CuentaAntNombre
            // 
            this.CuentaAntNombre.Caption = "Cuenta Ant(Nombre)";
            this.CuentaAntNombre.FieldName = "CuentaAntNombre";
            this.CuentaAntNombre.Name = "CuentaAntNombre";
            this.CuentaAntNombre.Visible = true;
            this.CuentaAntNombre.VisibleIndex = 1;
            this.CuentaAntNombre.Width = 198;
            // 
            // CuentaNvo
            // 
            this.CuentaNvo.Caption = "Cuenta Nueva";
            this.CuentaNvo.FieldName = "CuentaNvo";
            this.CuentaNvo.Name = "CuentaNvo";
            this.CuentaNvo.Visible = true;
            this.CuentaNvo.VisibleIndex = 2;
            this.CuentaNvo.Width = 88;
            // 
            // CuentaDestinoDebe
            // 
            this.CuentaDestinoDebe.Caption = "Destino Debe";
            this.CuentaDestinoDebe.FieldName = "CuentaDestinoDebe";
            this.CuentaDestinoDebe.Name = "CuentaDestinoDebe";
            this.CuentaDestinoDebe.Visible = true;
            this.CuentaDestinoDebe.VisibleIndex = 5;
            // 
            // CuentaDestinoHaber
            // 
            this.CuentaDestinoHaber.Caption = "Destino Haber";
            this.CuentaDestinoHaber.FieldName = "CuentaDestinoHaber";
            this.CuentaDestinoHaber.Name = "CuentaDestinoHaber";
            this.CuentaDestinoHaber.Visible = true;
            this.CuentaDestinoHaber.VisibleIndex = 6;
            this.CuentaDestinoHaber.Width = 91;
            // 
            // txtDestinoHaber
            // 
            this.txtDestinoHaber.Location = new System.Drawing.Point(368, 113);
            this.txtDestinoHaber.Name = "txtDestinoHaber";
            this.txtDestinoHaber.Properties.MaxLength = 100;
            this.txtDestinoHaber.Size = new System.Drawing.Size(81, 20);
            this.txtDestinoHaber.TabIndex = 10;
            this.txtDestinoHaber.Leave += new System.EventHandler(this.txtDestinoHaber_Leave);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(290, 111);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Destino Haber:";
            // 
            // txtCuentaAntNombre
            // 
            this.txtCuentaAntNombre.Location = new System.Drawing.Point(171, 15);
            this.txtCuentaAntNombre.Name = "txtCuentaAntNombre";
            this.txtCuentaAntNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaAntNombre.Properties.Appearance.Options.UseFont = true;
            this.txtCuentaAntNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaAntNombre.Properties.MaxLength = 2;
            this.txtCuentaAntNombre.Size = new System.Drawing.Size(279, 20);
            this.txtCuentaAntNombre.TabIndex = 2;
            // 
            // txtCuentaNvoNombre
            // 
            this.txtCuentaNvoNombre.Location = new System.Drawing.Point(172, 46);
            this.txtCuentaNvoNombre.Name = "txtCuentaNvoNombre";
            this.txtCuentaNvoNombre.Properties.MaxLength = 100;
            this.txtCuentaNvoNombre.Size = new System.Drawing.Size(278, 20);
            this.txtCuentaNvoNombre.TabIndex = 5;
            // 
            // btnDestinoDebe
            // 
            this.btnDestinoDebe.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinoDebe.Image")));
            this.btnDestinoDebe.Location = new System.Drawing.Point(172, 113);
            this.btnDestinoDebe.Name = "btnDestinoDebe";
            this.btnDestinoDebe.Size = new System.Drawing.Size(25, 20);
            this.btnDestinoDebe.TabIndex = 9;
            this.btnDestinoDebe.Click += new System.EventHandler(this.btnDestinoDebe_Click);
            // 
            // btnDestinoHaber
            // 
            this.btnDestinoHaber.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinoHaber.Image")));
            this.btnDestinoHaber.Location = new System.Drawing.Point(453, 113);
            this.btnDestinoHaber.Name = "btnDestinoHaber";
            this.btnDestinoHaber.Size = new System.Drawing.Size(25, 20);
            this.btnDestinoHaber.TabIndex = 11;
            this.btnDestinoHaber.Click += new System.EventHandler(this.btnDestinoHaber_Click);
            // 
            // btnCuentaAnt
            // 
            this.btnCuentaAnt.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentaAnt.Image")));
            this.btnCuentaAnt.Location = new System.Drawing.Point(453, 13);
            this.btnCuentaAnt.Name = "btnCuentaAnt";
            this.btnCuentaAnt.Size = new System.Drawing.Size(25, 20);
            this.btnCuentaAnt.TabIndex = 3;
            this.btnCuentaAnt.Click += new System.EventHandler(this.btnCuentaAnt_Click);
            // 
            // btnCuentaNvo
            // 
            this.btnCuentaNvo.Image = ((System.Drawing.Image)(resources.GetObject("btnCuentaNvo.Image")));
            this.btnCuentaNvo.Location = new System.Drawing.Point(453, 46);
            this.btnCuentaNvo.Name = "btnCuentaNvo";
            this.btnCuentaNvo.Size = new System.Drawing.Size(25, 20);
            this.btnCuentaNvo.TabIndex = 6;
            this.btnCuentaNvo.Click += new System.EventHandler(this.btnCuentaNvo_Click);
            // 
            // frmRelCtaGenEmp
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmRelCtaGenEmp";
            this.Load += new System.EventHandler(this.frmRelCtaGenEmp_Load);
            this.Shown += new System.EventHandler(this.frmRelCtaGenEmp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riceTieneDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaAnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNvo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTieneDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinoDebe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinoHaber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaAntNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNvoNombre.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn TieneDestino;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.TextEdit txtCuentaAnt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCuentaNvo;
        private DevExpress.XtraEditors.LookUpEdit cmbTieneDestino;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaAnt;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraEditors.TextEdit txtDestinoDebe;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaAntNombre;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaNvo;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaNvoNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceTieneDestino;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaDestinoDebe;
        private DevExpress.XtraGrid.Columns.GridColumn CuentaDestinoHaber;
        private DevExpress.XtraEditors.TextEdit txtDestinoHaber;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCuentaNvoNombre;
        private DevExpress.XtraEditors.TextEdit txtCuentaAntNombre;
        private DevExpress.XtraEditors.SimpleButton btnDestinoHaber;
        private DevExpress.XtraEditors.SimpleButton btnDestinoDebe;
        private DevExpress.XtraEditors.SimpleButton btnCuentaNvo;
        private DevExpress.XtraEditors.SimpleButton btnCuentaAnt;
    }
}
