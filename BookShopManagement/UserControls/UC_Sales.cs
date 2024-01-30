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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopManagement.UserControls
{
    public partial class UC_Sales : UserControl
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;");


        public UC_Sales()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT BookTitle,Qty,Price FROM Tbl_SellBooks", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["BookTitle"].ToString());
                item.SubItems.Add(row["Qty"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                DatalistView.Items.Add(item);
            }
        }
         private void button7_Click(object sender, EventArgs e)
        {
            using (Form_FinishOrder uf = new Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }

        private void btnBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Barcode= Convert.ToInt32( btnBarcode.Text);
            var Tracking= Convert.ToInt32(btnTracking.Text);
            var Booktitle = btnbooktitle.Text;
            var Auther = btnAuthor.Text;
            var Published = btnpublisher.Text;
            var Qty = Convert.ToInt32(btnqty.Text);
            var Price = btnprice.Text;
            var discount = btndiscount.Text;
            SqlCommand cmd = new SqlCommand($"insert into Tbl_SellBooks (Barcode,Trackingii,Booktitle,Auther,Publisher,Qty,Price,Discount, Isactive) values('{Barcode}','{Tracking}','{Booktitle}','{Auther}','{Published}','{Qty}','{Price}','{discount}',1)", sql);
            sql.Open();
            int modified = cmd.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Successfully Inserted");
            btnBarcode.Text = string.Empty;
            btnTracking.Text = string.Empty;
            btnbooktitle.Text = String.Empty;
            btnAuthor.Text = string.Empty;
            btnpublisher.Text = string.Empty;
            btnprice.Text = string.Empty;
            btndiscount.Text = string.Empty;
            btnqty.Text = string.Empty;
          
            

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
















        private void button3_Click(object sender, EventArgs e)
        {


        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {

        }

        private void btnbooktitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


