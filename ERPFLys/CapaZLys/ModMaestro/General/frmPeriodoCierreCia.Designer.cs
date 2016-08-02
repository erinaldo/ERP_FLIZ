namespace FiltroLys.ZLys.ModMaestro.General
{
    partial class frmPeriodoCierreCia
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
            this.CompaniaNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UltimoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUltimoUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtUltimaFecha = new DevExpress.XtraEditors.TextEdit();
            this.Periodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlagTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.FlagBloqueo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceFlags = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.txtUltimoUsuarioNombre = new DevExpress.XtraEditors.TextEdit();
            this.chkFlagBloqueo = new DevExpress.XtraEditors.CheckEdit();
            this.chkFlagTrabajo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagBloqueo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
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
            this.CompaniaNombre,
            this.Periodo,
            this.Estado,
            this.FlagTrabajo,
            this.FlagBloqueo,
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
            this.pnlCuerpo.Controls.Add(this.txtPeriodo);
            this.pnlCuerpo.Controls.Add(this.chkFlagTrabajo);
            this.pnlCuerpo.Controls.Add(this.labelControl7);
            this.pnlCuerpo.Controls.Add(this.chkFlagBloqueo);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuarioNombre);
            this.pnlCuerpo.Controls.Add(this.cmbCompania);
            this.pnlCuerpo.Controls.Add(this.labelControl6);
            this.pnlCuerpo.Controls.Add(this.txtUltimaFecha);
            this.pnlCuerpo.Controls.Add(this.txtUltimoUsuario);
            this.pnlCuerpo.Controls.Add(this.labelControl5);
            this.pnlCuerpo.Controls.Add(this.labelControl4);
            this.pnlCuerpo.Controls.Add(this.cmbEstado);
            this.pnlCuerpo.Controls.Add(this.labelControl3);
            this.pnlCuerpo.Controls.Add(this.labelControl2);
            this.pnlCuerpo.Controls.Add(this.labelControl1);
            this.pnlCuerpo.Size = new System.Drawing.Size(0, 0);
            // 
            // CompaniaNombre
            // 
            this.CompaniaNombre.Caption = "Compania";
            this.CompaniaNombre.FieldName = "CompaniaNombre";
            this.CompaniaNombre.Name = "CompaniaNombre";
            this.CompaniaNombre.Visible = true;
            this.CompaniaNombre.VisibleIndex = 0;
            this.CompaniaNombre.Width = 130;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.ColumnEdit = this.rilueEstado;
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 2;
            this.Estado.Width = 93;
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
            this.UltimoUsuario.VisibleIndex = 5;
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
            this.UltimaFechaModificacion.VisibleIndex = 6;
            this.UltimaFechaModificacion.Width = 144;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Periodo:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bloqueado:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(110, 117);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Size = new System.Drawing.Size(113, 20);
            this.cmbEstado.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Ultimo Usuario:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 186);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Ultima Fecha:";
            // 
            // txtUltimoUsuario
            // 
            this.txtUltimoUsuario.Location = new System.Drawing.Point(110, 159);
            this.txtUltimoUsuario.Name = "txtUltimoUsuario";
            this.txtUltimoUsuario.Size = new System.Drawing.Size(113, 20);
            this.txtUltimoUsuario.TabIndex = 6;
            // 
            // txtUltimaFecha
            // 
            this.txtUltimaFecha.Location = new System.Drawing.Point(110, 185);
            this.txtUltimaFecha.Name = "txtUltimaFecha";
            this.txtUltimaFecha.Size = new System.Drawing.Size(150, 20);
            this.txtUltimaFecha.TabIndex = 8;
            // 
            // Periodo
            // 
            this.Periodo.Caption = "Periodo";
            this.Periodo.FieldName = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.Visible = true;
            this.Periodo.VisibleIndex = 1;
            this.Periodo.Width = 69;
            // 
            // FlagTrabajo
            // 
            this.FlagTrabajo.AppearanceCell.Options.UseTextOptions = true;
            this.FlagTrabajo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagTrabajo.Caption = "Trabajo Actual";
            this.FlagTrabajo.ColumnEdit = this.riceCheckBox;
            this.FlagTrabajo.FieldName = "FlagTrabajo";
            this.FlagTrabajo.Name = "FlagTrabajo";
            this.FlagTrabajo.Visible = true;
            this.FlagTrabajo.VisibleIndex = 3;
            this.FlagTrabajo.Width = 89;
            // 
            // riceCheckBox
            // 
            this.riceCheckBox.AutoHeight = false;
            this.riceCheckBox.Name = "riceCheckBox";
            this.riceCheckBox.ValueChecked = "S";
            this.riceCheckBox.ValueUnchecked = "N";
            // 
            // FlagBloqueo
            // 
            this.FlagBloqueo.AppearanceCell.Options.UseTextOptions = true;
            this.FlagBloqueo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FlagBloqueo.Caption = "Bloqueado";
            this.FlagBloqueo.ColumnEdit = this.riceCheckBox;
            this.FlagBloqueo.FieldName = "FlagBloqueo";
            this.FlagBloqueo.Name = "FlagBloqueo";
            this.FlagBloqueo.Visible = true;
            this.FlagBloqueo.VisibleIndex = 4;
            this.FlagBloqueo.Width = 77;
            // 
            // riceFlags
            // 
            this.riceFlags.AutoHeight = false;
            this.riceFlags.Name = "riceFlags";
            this.riceFlags.ValueChecked = "S";
            this.riceFlags.ValueUnchecked = "N";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 18);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Compania:";
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(110, 17);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 45, "Codigo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Nombre")});
            this.cmbCompania.Properties.PopupWidth = 250;
            this.cmbCompania.Size = new System.Drawing.Size(189, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // txtUltimoUsuarioNombre
            // 
            this.txtUltimoUsuarioNombre.Location = new System.Drawing.Point(224, 159);
            this.txtUltimoUsuarioNombre.Name = "txtUltimoUsuarioNombre";
            this.txtUltimoUsuarioNombre.Size = new System.Drawing.Size(172, 20);
            this.txtUltimoUsuarioNombre.TabIndex = 7;
            // 
            // chkFlagBloqueo
            // 
            this.chkFlagBloqueo.Location = new System.Drawing.Point(110, 70);
            this.chkFlagBloqueo.Name = "chkFlagBloqueo";
            this.chkFlagBloqueo.Properties.Caption = "";
            this.chkFlagBloqueo.Size = new System.Drawing.Size(27, 19);
            this.chkFlagBloqueo.TabIndex = 3;
            // 
            // chkFlagTrabajo
            // 
            this.chkFlagTrabajo.Location = new System.Drawing.Point(110, 95);
            this.chkFlagTrabajo.Name = "chkFlagTrabajo";
            this.chkFlagTrabajo.Properties.Caption = "";
            this.chkFlagTrabajo.Size = new System.Drawing.Size(27, 19);
            this.chkFlagTrabajo.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 97);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "Trabajo Actual:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(110, 44);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(64, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // frmPeriodoCierreCia
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(553, 398);
            this.Name = "frmPeriodoCierreCia";
            this.Load += new System.EventHandler(this.frmPeriodoCierreCia_Load);
            this.Shown += new System.EventHandler(this.frmPeriodoCierreCia_Shown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimaFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltimoUsuarioNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagBloqueo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFlagTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn CompaniaNombre;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn UltimoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFechaModificacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuario;
        private DevExpress.XtraEditors.TextEdit txtUltimaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn Periodo;
        private DevExpress.XtraGrid.Columns.GridColumn FlagTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn FlagBloqueo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceFlags;
        private DevExpress.XtraEditors.TextEdit txtUltimoUsuarioNombre;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceCheckBox;
        private DevExpress.XtraEditors.CheckEdit chkFlagTrabajo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chkFlagBloqueo;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
    }
}
