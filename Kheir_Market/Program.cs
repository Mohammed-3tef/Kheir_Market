using Kheir_Market.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kheir_Market
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware(); // Ensure DPI awareness for high DPI displays
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the loading page first
            LoadingPage loadingPage = new LoadingPage();
            loadingPage.ShowDialog(); // Show the loading page modally to ensure it completes before proceeding

            // Start the main window after the loading page is closed
            Application.Run(new MainWindow());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
