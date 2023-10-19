using System;

using System.Windows.Forms;

namespace Sistema.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
   
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
           // ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
        }
    }
}