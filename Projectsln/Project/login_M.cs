using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Project
{
    public partial class LManager : Form
    {
        public LManager()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }
    }
}
