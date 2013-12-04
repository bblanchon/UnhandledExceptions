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
