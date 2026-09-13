using System;
using System.Windows.Forms;

namespace BankSampah
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                WargaWebServer.Start();
            }
            catch { }

            Application.Run(new FormLogin());

            try
            {
                WargaWebServer.Stop();
            }
            catch { }
        }
    }
}
