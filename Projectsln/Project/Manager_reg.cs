﻿using System;
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
    public partial class Registration_M : Form
    {
        string gender;
        public Registration_M()
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
            string Fname = fname.Text;
            string Lname = lname.Text;
            string fullname = string.Concat(Fname, " ", Lname);
            string padress = adress.Text;
            string ntion = nation.Text;
            string Dob = dt1.Text;
            string phn1 = ph1.Text;
            string phn2 = ph2.Text;
            string phn = string.Concat(phn1, phn2);
            string username = uname.Text;
            string mail = email.Text;
            string pass = password.Text;
            if (rd1.Checked == true)
            {
                gender = rd1.Text;
            }
            else if (rd2.Checked == true)
            {
                gender = rd2.Text;
            }

            string connString = @"Server=LAPTOP-D3473TU4;Database=Project;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("insert into Manager values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", Fname, Lname, fullname, gender, Dob, ntion, padress, phn, mail, username, pass);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Registration Done!!");
                }
                else
                {
                    MessageBox.Show("Failed to Registration. Try again...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
