﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmy.GUI
{
    public partial class ExceptionWindow : Form
    {
        public ExceptionWindow(string message)
        {
            
            InitializeComponent();
            lbException.Text = message;
        }

        private void Exception_Load(object sender, EventArgs e)
        {

        }

        private void lbException_Click(object sender, EventArgs e)
        {

        }
    }
}
