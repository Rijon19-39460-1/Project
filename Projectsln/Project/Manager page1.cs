﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Mpage : Form
    {
        public Mpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Tour_guide().Show();
        }
    }
}