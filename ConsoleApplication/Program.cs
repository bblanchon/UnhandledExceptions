// Copyright © Benoit Blanchon 2013
// http://benoitblanchon.fr/
// MIT License

namespace UnhandledExceptions.ConsoleApplication
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

            // ...
            throw new Exception("Booo!!");
        }

        static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached) return;
            
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("-- Press [Enter] to close --");
            Console.ReadLine();

            Environment.Exit(1);
        }
    }
}
