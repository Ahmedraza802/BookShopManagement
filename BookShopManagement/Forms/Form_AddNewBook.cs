using BookShopManagement.UserControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopManagement.Forms
{
    public partial class Form_AddNewBook : Form
    {
      
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=BookShop;Integrated Security=true;");
        
        public Form_AddNewBook()
        {
            InitializeComponent();

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Author where isActive = 1",sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow drAuthor;
            drAuthor = dt.NewRow();
            drAuthor.ItemArray = new object[] { 0, "--Select Author--" };
            dt.Rows.InsertAt(drAuthor, 0);
            cmbAuthor.ValueMember = "Id";
            cmbAuthor.DisplayMember = "AuthorName";
            cmbAuthor.DataSource = dt;



            SqlDataAdapter  daPublisher = new SqlDataAdapter("select * from tbl_Publisher where  isActive = 1", sql);
            DataTable dtPublisher = new DataTable();
            daPublisher.Fill(dtPublisher);
            DataRow drPublisher;
            drPublisher = dtPublisher.NewRow();
            drPublisher.ItemArray = new object[] { 0, "--Select Publisher--" };
            dtPublisher.Rows.InsertAt(drPublisher, 0);
            cmbPublisher.ValueMember = "Id";
            cmbPublisher.DisplayMember = "PublisherName";
            cmbPublisher.DataSource = dtPublisher;



            SqlDataAdapter daCategory = new SqlDataAdapter("select * from tbl_Category where isActive=1", sql);
            DataTable dtCategory = new DataTable();
            daCategory.Fill(dtCategory);
            DataRow drCategory;
            drCategory = dtCategory.NewRow();
            drCategory.ItemArray = new object[] { 0, "--Select Category--" };
            dtCategory.Rows.InsertAt(drCategory, 0);
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = dtCategory;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddCategory ac = new Form_AddCategory())
            {
                ac.ShowDialog();
            }
        }

        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbAuthor.Text  = string.Empty;
        }

        private void btnSave(object sender, EventArgs e)
        {
            var bookTitle = tbBookTitle.Text;
            var autherId = cmbAuthor.SelectedIndex;
            var quantity = tbQuantity.Text;
            var publisherId = cmbPublisher.SelectedIndex;
            var categoryId = cmbCategory.SelectedIndex;
            var costPrice = tbCostPrice.Text;
            var sellingPrice = tbSellingPrice.Text;
            var barcode = tbBarCode.Text;
            var remarks = rtbRemarks.Text;

            SqlCommand cmdInsertbook = new SqlCommand($"insert into tbl_PurchaseBook BookTitle, AuthorId, Quantity , PublisherId, CategoryId, CostPrice, SellingPrice, Barcode, Remarks values({bookTitle},{autherId},{quantity},{publisherId},{categoryId},{costPrice},{sellingPrice},{barcode},{remarks})" ,sql);
            int modified = cmdInsertbook.ExecuteNonQuery();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bookTitle = tbBookTitle.Text;
            var autherId = cmbAuthor.SelectedIndex;
            var quantity = Convert.ToInt32(tbQuantity.Text);
            var publisherId = cmbPublisher.SelectedIndex;
            var categoryId = cmbCategory.SelectedIndex;
            var costPrice = Convert.ToDecimal(tbCostPrice.Text);
            var sellingPrice = Convert.ToDecimal(tbSellingPrice.Text);
            var barcode = (string.IsNullOrEmpty(tbBarCode.Text) ? "barcode" : tbBarCode.Text);
            var remarks = rtbRemarks.Text;

            SqlCommand cmdInsertbook = new SqlCommand($"insert into tbl_PurchaseBook (BookTitle, AuthorId, Quantity , PublisherId, CategoryId, CostPrice, SellingPrice, Barcode, Remarks, isActive) values('{bookTitle}',{autherId},{quantity},{publisherId},{categoryId},{costPrice},{sellingPrice},'{barcode}','{remarks}',1)", sql);
            sql.Open();
            int modified = cmdInsertbook.ExecuteNonQuery();
            sql.Close();


            MessageBox.Show("Successfully Inserted");

        }

        private void tbTrackingID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_AddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void rtbRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAuthor_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

}
