﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();

            lucinda = new Elephant() { Name = "Lucinda", Earsize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", Earsize = 40 );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}