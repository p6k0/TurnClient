﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnPlace1.AddLineGroup("Новая группа");
        }

        private void Form1_Shown(object sender, EventArgs e) => turnPlace1.PlaceWidth = ClientSize.Width;
    }
}
