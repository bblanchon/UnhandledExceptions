// Copyright © Benoit Blanchon 2013
// http://benoitblanchon.fr/
// MIT License
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
            if (System.Diagnostics.Debugger.IsAttached) return;

            MessageBox.Show(e.ExceptionObject.ToString());

            Environment.Exit(1);
        }
    }
}
