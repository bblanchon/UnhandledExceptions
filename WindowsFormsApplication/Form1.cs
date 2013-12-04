// Copyright © Benoit Blanchon 2013
// http://benoitblanchon.fr/
// MIT License
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
