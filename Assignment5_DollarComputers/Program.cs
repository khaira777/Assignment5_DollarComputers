using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_DollarComputers
{
    static class Program
    {
        public static StartForm startform;
        public static SelectForm selectform;
        public static ProductInfoForm productinfoform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startform = new StartForm();
            selectform = new SelectForm();
            productinfoform = new ProductInfoForm();
            Application.Run(new SplashForm());
        }
    }
}
