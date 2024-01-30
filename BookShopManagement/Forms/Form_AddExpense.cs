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

namespace BookShopManagement.Forms
{
    public partial class Form_AddExpense : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;");

        public Form_AddExpense()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Newexpense  Where IsActive =1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
            



          



        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Expense = tblExpense.Text;
            var Amount = tblAmount.Text;
            var Description = tblDescription.Text;

            SqlCommand cmd = new SqlCommand($"Insert into Tbl_Newexpense (ExpenseTitle,Amount,Description, IsActive) values('{Expense}','{Amount}','{Description}',1)",sql);
            sql.Open();
            int modified = cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Successfully Inserted");

            tblExpense.Text = string.Empty;
            tblDescription.Text = string.Empty;
            tblAmount.Text = string.Empty;

            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Newexpense  Where IsActive =1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);



        }

        private void Form_AddExpense_Load(object sender, EventArgs e)
        {

        }
    }
}
