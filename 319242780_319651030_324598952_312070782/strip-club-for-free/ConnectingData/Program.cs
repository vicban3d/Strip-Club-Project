using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConnectingData
{
    static class Program
    {
        public static FormController FormController = new FormController();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormController.F_login.Show();
            Application.Run();
        }
    }
}