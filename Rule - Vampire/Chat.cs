﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rule___Vampire
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey && e.KeyCode == Keys.Enter)
            {
 
            }
            else if (e.KeyCode == Keys.Enter)
            {
                textBox1.Text = string.Empty;
            }
        }
    }
}
