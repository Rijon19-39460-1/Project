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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
                Application.Exit();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-L6S3T5O\SQLEXPRESS; Database=Project ;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Customer1> Customer = new List<Customer1>();
            try 
            {

                conn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "select * from Customer ";

            try
            {
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer1 c = new Customer1();
                    c.CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId"));
                    c.CustomerName = reader.GetString(reader.GetOrdinal("CustomerName"));
                    c.PackageName = reader.GetString(reader.GetOrdinal("PackageName"));
                    c.PackageId = reader.GetInt32(reader.GetOrdinal("PackageId"));                    
                    c.CustomerPhone = reader.GetString(reader.GetOrdinal("CustomerPhone"));
                    c.CustomerEmail = reader.GetString(reader.GetOrdinal("CustomerEmail"));
                    c.PurchaseTime = reader.GetString(reader.GetOrdinal("PurchaseTime"));
                    Customer.Add(c);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }

            conn.Close();
            dtCustomer.DataSource = Customer;
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Manager_page().Show();
        }
    }
}
