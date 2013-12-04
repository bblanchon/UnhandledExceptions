// Copyright © Benoit Blanchon 2013
// http://benoitblanchon.fr/
// MIT License

namespace UnhandledExceptions.WindowsFormsApplication
{
    using System;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached) return;

            MessageBox.Show(e.ExceptionObject.ToString());
            Environment.Exit(1);
        }
    }
}
