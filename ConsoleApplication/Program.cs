/*
 * This file is part of the Satimo Software Framework
 *
 * Copyright © Satimo 2013 All Rights Reserved, http://satimo.fr/
 */
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
#if !DEBUG
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("-- Press [Enter] to close --");
            Console.ReadLine();
            Environment.Exit(1);
#endif
        }
    }
}
