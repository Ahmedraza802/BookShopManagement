using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShopManagement.Forms;
using System.Data.SqlClient;

namespace BookShopManagement.UserControls
{
    public partial class UC_ManageExpense : UserControl
    {
        SqlConnection SqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Bookshop;Integrated Security=True;");

        public UC_ManageExpense()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Newexpense Where IsActive =1", SqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense ae = new Form_AddExpense())
            {
                ae.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var Id = 0;
            if (!string.IsNullOrEmpty(textmanageId.Text))
            {
                Id = Convert.ToInt32(textmanageId.Text);
            }

            SqlDataAdapter Da = new SqlDataAdapter($"Delete from tbl_Newexpense Where Id = {Id}", SqlConnection);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            MessageBox.Show("Successfully Delete");

        }





        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Newexpense Where IsActive =1", SqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
