using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_AddStock : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;");
        public Form_AddStock()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Existingstock = tblExistingstock.Text;
            var Newstock = tblnewstock.Text;
            var TotalStock = tbltotalstock.Text;
            var CostPrice = tblcostprice.Text;
            var Sellingprice = tblsellingprice.Text;
            SqlCommand cmd = new SqlCommand($"insert into tbl_AddStock Existingstock, NewStock, TotalStock , CostPrice,SellingPrice values({Existingstock},{Newstock},{TotalStock},{CostPrice},{Sellingprice})", sql);
            int modified = cmd.ExecuteNonQuery();
        }
    }
}