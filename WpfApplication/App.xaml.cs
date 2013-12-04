/*
 * This file is part of the Satimo Software Framework
 *
 * Copyright © Satimo 2013 All Rights Reserved, http://satimo.fr/
 */
namespace UnhandledExceptions.WpfApplication
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
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
