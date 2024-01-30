using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;");

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string enteredLogin = txtEmailId.Text;
            //string enteredPassword = txtpassword.Text;

            //if (string.IsNullOrEmpty(enteredLogin) || string.IsNullOrEmpty(enteredPassword))
            //{
            //    // Empty fields, show an error message for each empty field.
            //    if (string.IsNullOrEmpty(enteredLogin))
            //    {
            //        MessageBox.Show("Please Enter Valid EmailId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (string.IsNullOrEmpty(enteredPassword))
            //    {
            //        MessageBox.Show("Please Enter Valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    string expectedEmail = "AhmedRaza@gmail.com";
            //    string expectedPassword = "123456789";

            //    if (enteredLogin == expectedEmail && enteredPassword == expectedPassword)
            //    {
            //        // Login successful, show a customized welcome message.
            //        string welcomeMessage = "Welcome To Screen";
            //        MessageBox.Show(welcomeMessage, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // You can open another form or do whatever is needed for a successful login.
                   using (Form_Dashboard fd = new Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                }
        //        else
        //        {
        //            // Login failed, show an error message.
        //            MessageBox.Show("Login failed. Please check your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

