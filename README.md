# Properly dealing with unhandled exceptions

Here are sample projects showing how to display a custom dialog box when an unhandled exception occurs in:

1. A Console application
2. A WinForm application
3. A WPF application

Exceptions are caught only if the debugger is attached.
In other word, they are still caught by Visual Studio, but your customer will always see the custom dialog box.

The principle is simple:

1. Attach to event `AppDomain.CurrentDomain.UnhandledException`
2. Check `System.Diagnostics.Debugger.IsAttached`
3. Show custom dialog
4. Exit the application

See http://blog.benoitblanchon.fr/unhandled-exceptions/

