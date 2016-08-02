using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials.Controls;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Taskbar;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.XtraEditors.Popup;
using FiltroLys.ZLys.Seguridad;
using FiltroLys.ZLys.Sistema;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.Controles.Formulario;
using FiltroLys.ZLys.ModMaestro;

namespace FiltroLys.ZLys.Inicio
{
    public partial class frmMdi : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        #region "==Event Inherit=="

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SplashScreenManager.CloseForm(false);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        #endregion

        #region "==Event Form=="

        public frmMdi()
        {
            InitializeComponent();            
            InitSkinGallery();           
            ListaThemeOffice();
            CargarComboThemeColor();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(OnLookAndFeelStyleChanged);
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", typeof(frmMdi).Assembly);
            GlobalVar.formMDI = this;
        }

        private void frmMdi_Load(object sender, System.EventArgs e)
        {
            ribbonControl1.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbonControl1;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;            
            barEditItem1.EditValue = (Bitmap)DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("FiltroLys.ZLys.online.gif", typeof(frmMdi).Assembly);
        }

        private void frmMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void OnLookAndFeelStyleChanged(object sender, EventArgs e) {
            ActualizarThemeCombo();
        }

        #endregion

        #region "==Function Skin=="

        private void ListaThemeOffice()
        {
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("TabletOffice", RibbonControlStyle.TabletOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("OfficeUniversal", RibbonControlStyle.OfficeUniversal, -1));
            biStyle.EditValue = ribbonControl1.RibbonStyle;
        }

        private void CargarComboThemeColor()
        {
            foreach (object obj in Enum.GetValues(typeof(RibbonControlColorScheme)))
            {
                repositoryItemComboBox1.Items.Add(obj);
            }
            beScheme.EditValue = RibbonControlColorScheme.Yellow;
        }

        private void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void ActualizarSkinOffice()
        {
            string skinName;
            RibbonControlStyle style = ribbonControl1.RibbonStyle;
            switch (style)
            {
                case RibbonControlStyle.Default:
                case RibbonControlStyle.Office2007:
                    skinName = "Office 2007 Blue";
                    break;
                case RibbonControlStyle.Office2013:
                case RibbonControlStyle.TabletOffice:
                case RibbonControlStyle.OfficeUniversal:
                    skinName = "Office 2013";
                    break;
                case RibbonControlStyle.Office2010:
                case RibbonControlStyle.MacOffice:
                default:
                    skinName = "Office 2010 Blue";
                    break;
            }
            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }

        private void ActualizarThemeCombo()
        {
            if (ribbonControl1.RibbonStyle == RibbonControlStyle.MacOffice ||
                ribbonControl1.RibbonStyle == RibbonControlStyle.Office2010 || ribbonControl1.RibbonStyle == RibbonControlStyle.Office2013)
            {
                beScheme.Visibility = UserLookAndFeel.Default.ActiveSkinName.Contains("Office 2010") ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
            else
            {
                beScheme.Visibility = BarItemVisibility.Never;
            }
        }    

        #endregion

        #region "==Event Sking=="

        private void ribbonControl1_ApplicationButtonDoubleClick(object sender, EventArgs e) {
            if(ribbonControl1.RibbonStyle == RibbonControlStyle.Office2007)
                this.Close();
        }

        private void biStyle_EditValueChanged(object sender, EventArgs e) {
            RibbonControlStyle style = (RibbonControlStyle)biStyle.EditValue;
            ribbonControl1.RibbonStyle = style;
            if(style == RibbonControlStyle.Office2010 || style == RibbonControlStyle.MacOffice || style == RibbonControlStyle.Office2013 || style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal) {
                //ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            }
            else {
                ribbonControl1.ApplicationButtonDropDownControl = pmAppMain;
            }
            if(style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal) {
                this.btPrefAutoSave.Visibility = BarItemVisibility.Always;
            }
            else {
                this.btPrefAutoSave.Visibility = BarItemVisibility.Never;
            }
            ActualizarThemeCombo();
            ActualizarSkinOffice();
        }

        private void beScheme_EditValueChanged(object sender, EventArgs e) {
            ribbonControl1.ColorScheme = ((RibbonControlColorScheme)beScheme.EditValue);
        }

        #endregion

        #region "==Event Preference=="

        private void biPrefSegAuditoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListAuditoria frm = new frmListAuditoria();
            fnAddTab.FormOpen(frm);
        }

        private void biPrefSegUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListTabla frm = new frmListTabla();
            fnAddTab.FormOpen(frm);
        }

        private void bbColorMix_ItemClick(object sender, ItemClickEventArgs e)
        {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }

        private void biPrefExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "==Event Sistemas=="

        private void nbarSistContabilidad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInicioContabilidad frm = new frmInicioContabilidad();
            fnAddTab.FormOpen(frm);            
        }

        #endregion

        #region "==Event Menu Mant=="

        public void setVisibleX(Boolean valor) {
            rpcMainMenuMant.Visible = valor;
            if (valor){
                ribbonControl1.SelectedPage = rbpMainMant;
                rbMainPreferencia.Category.Expanded = false;
                rbMainReporte.Category.Expanded = false;
                rbMainGaleria.Category.Expanded = false;
            }else {
                ribbonControl1.SelectedPage = rbMainPreferencia;
                rbMainPreferencia.Category.Expanded = true;
                rbMainReporte.Category.Expanded = true;
                rbMainGaleria.Category.Expanded = true;
            }
        }

        private void biMenuMantCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMant frm = (frmMant) this.ActiveMdiChild;
            frm.ue_cancelar();
        }

        private void biMenuMantGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMant frm = (frmMant)this.ActiveMdiChild;
            frm.ue_guardar();
        }

        private void biMenuMantNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMant frm = (frmMant)this.ActiveMdiChild;
            frm.ue_nuevo();
        }

        #endregion

        #region "==Event Maestro=="

        private void nbiMaestro_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMaestrosMain frm = new frmMaestrosMain();
            fnAddTab.FormOpen(frm);
        }

        #endregion

        private void biPrefSegMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*FiltroLys.ZLys.ModReporte.frmReportesMain frmRpt = new FiltroLys.ZLys.ModReporte.frmReportesMain();
            //orpt.viewReport();
            //frmInicioContabilidad frm = new frmInicioContabilidad();
            fnAddTab.FormOpen(frmRpt); */
        }

        private void biPrefReporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            FiltroLys.ZLys.ModReporte.frmReportesMain frmRpt = new FiltroLys.ZLys.ModReporte.frmReportesMain();
            //orpt.viewReport();
            //frmInicioContabilidad frm = new frmInicioContabilidad();
            fnAddTab.FormOpen(frmRpt); 
        }

    }
    
}
