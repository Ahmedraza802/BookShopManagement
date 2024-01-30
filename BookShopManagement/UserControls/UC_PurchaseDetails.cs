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
    public partial class UC_PurchaseDetails : UserControl
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;"); 
       
        public UC_PurchaseDetails()
        {
            InitializeComponent();

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_PurchaseBook where isActive =1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPurchaseBook.DataSource = dt;
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddStock ads = new Form_AddStock())
            {
                ads.ShowDialog();
            }
        }

        private void dgvPurchaseBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
