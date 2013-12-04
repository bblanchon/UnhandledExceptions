// Copyright © Benoit Blanchon 2013
// http://benoitblanchon.fr/
// MIT License
namespace UnhandledExceptions.WpfApplication
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            throw new Exception("Booo!!");
        }
    }
}
