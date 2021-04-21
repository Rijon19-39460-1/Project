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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Admin2.Visible = true;
            Manager2.Visible = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
               
            Admin1.Visible = true;
            Manager1.Visible = true;
        }

        private void Admin1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LAdmin().Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Admin2.Visible = false;
            Manager2.Visible = false;
            Admin1.Visible = false;
            Manager1.Visible = false;
        }

        private void Admin2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new REGISTRATION_A().Show();
        }

        private void Manager2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration_M().Show();
        }

        private void Manager1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LManager().Show();
        }
    }
}
