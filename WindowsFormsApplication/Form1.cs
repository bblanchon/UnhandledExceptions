/*
 * This file is part of the Satimo Software Framework
 *
 * Copyright © Satimo 2013 All Rights Reserved, http://satimo.fr/
 */
namespace UnhandledExceptions.WindowsFormsApplication
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            throw new Exception("Booo!!");
        }
    }
}
