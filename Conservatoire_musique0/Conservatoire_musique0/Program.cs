using Conservatoire_musique0.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Conservatoire_musique0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

        }
    }
}