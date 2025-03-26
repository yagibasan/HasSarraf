using DevExpress.XtraSplashScreen;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HasSarraf.BackOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashScreenManager.ShowForm(typeof(frmSplasScreen));
            Application.Run(new frmMaster());
        }
    }
}
