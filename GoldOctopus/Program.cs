using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using GoldOctopus.Business;
using GoldOctopus.Forms;

namespace GoldOctopus
{
    internal static class Program
    {
        public static frmMain mainForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.EnableFormSkins();

            SplashScreenManager.ShowForm(typeof(frmSplash));
            UtilBL.Init();
            mainForm = new frmMain();
            Application.Run(mainForm);
        }
    }
}
