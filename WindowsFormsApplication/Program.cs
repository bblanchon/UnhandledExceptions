/*
 * This file is part of the Satimo Software Framework
 *
 * Copyright © Satimo 2013 All Rights Reserved, http://satimo.fr/
 */
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
#if !DEBUG
            MessageBox.Show(e.ExceptionObject.ToString());
            Environment.Exit(1);
#endif
        }
    }
}
