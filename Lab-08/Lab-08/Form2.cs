﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class Form2 : Form
    {
        string allLocales = "";

        public Form2()
        {
            InitializeComponent();
            
        }

        public void GetLoc(string loc)
        {
            allLocales = loc;
        }
        

        private void btShowAll_Click(object sender, EventArgs e)
        {
            rtF2.Text = allLocales;
        }
        
    }
}
