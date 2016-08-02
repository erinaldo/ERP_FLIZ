﻿namespace FiltroLys.ZLys.Busqueda.General
{
    partial class frmBusqCentroCosto
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
            this.CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEstado = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Clasificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsuarioResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // grControl
            // 
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rilueEstado});
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
            this.CentroCosto,
            this.Nombres,
            this.Clasificacion,
            this.Estado,
            this.UsuarioResponsable});
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
            // 
            // txtDescripcion
            // 
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
            // CentroCosto
            // 
            this.CentroCosto.Caption = "Codigo";
            this.CentroCosto.FieldName = "CentroCosto";
            this.CentroCosto.Name = "CentroCosto";
            this.CentroCosto.Visible = true;
            this.CentroCosto.VisibleIndex = 0;
            this.CentroCosto.Width = 47;
            // 
            // Nombres
            // 
            this.Nombres.Caption = "Descripcion";
            this.Nombres.FieldName = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Nombres", "{0}  Fila(s).")});
            this.Nombres.Visible = true;
            this.Nombres.VisibleIndex = 1;
            this.Nombres.Width = 253;
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
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 68;
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
            // Clasificacion
            // 
            this.Clasificacion.Caption = "Clasificacion";
            this.Clasificacion.FieldName = "Clasificacion";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.Visible = true;
            this.Clasificacion.VisibleIndex = 2;
            this.Clasificacion.Width = 71;
            // 
            // UsuarioResponsable
            // 
            this.UsuarioResponsable.Caption = "Usu.Respons.";
            this.UsuarioResponsable.FieldName = "UsuarioResponsable";
            this.UsuarioResponsable.Name = "UsuarioResponsable";
            this.UsuarioResponsable.Visible = true;
            this.UsuarioResponsable.VisibleIndex = 4;
            this.UsuarioResponsable.Width = 79;
            // 
            // frmBusqCentroCosto
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Name = "frmBusqCentroCosto";
            this.Text = "Busqueda Centro Costo";
            this.Load += new System.EventHandler(this.frmCentroCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rilueEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn CentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn Nombres;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEstado;
        private DevExpress.XtraGrid.Columns.GridColumn Clasificacion;
        private DevExpress.XtraGrid.Columns.GridColumn UsuarioResponsable;
    }
}
