using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using FiltroLys.ZLys.Inicio;

namespace FiltroLys.ZLys
{
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //Application.Run(new FiltroLys.ZLys.ModReporte.Contabilidad.frmReportePrueba());
        }
    }
}
