using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class HelpControl : RibbonApplicationUserControl {
        public HelpControl() {
            InitializeComponent();
            this.versionLabel.Text = AssemblyInfo.Version;
            this.copyrightLabel.Text = AssemblyInfo.AssemblyCopyright;
            this.serialNumberLabel.Text = DevExpress.Utils.About.Utility.GetSerial(DevExpress.Utils.About.ProductKind.DXperienceWin, DevExpress.Utils.About.ProductInfoStage.Registered);
        }
    }
}
