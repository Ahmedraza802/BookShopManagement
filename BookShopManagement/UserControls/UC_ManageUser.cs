using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookShopManagement.Forms;
using System.Diagnostics;

namespace BookShopManagement.UserControls
{
   
    public partial class UC_ManageUser : UserControl
    {
       SqlConnection SqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Bookshop;Integrated Security=True;");
 
        public UC_ManageUser()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_MangerUser where IsActive= 1 ", SqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
       
        
      

        private void button2_Click(object sender, EventArgs e)
        {
            var Id = 0;
            if (!string.IsNullOrEmpty(txtUserID.Text.ToString())) { 
                Id = Convert.ToInt32(txtUserID.Text.ToString());
            }
            
            var FirstName = txtFirstName.Text;
            var LastName = txtLastName.Text;
            var Phone = txtPhone.Text;
            var Cnic = txtCnic.Text;
            var Email = txtEmail.Text;
            var UserName = txtUserName.Text;
            var Password = txtPassword.Text;
            var Role = cmbRole.SelectedIndex;
            var messageType = string.Empty;

            var sql = string.Empty;

            if (Id > 0)
            {
                sql = $"Update tbl_MangerUser Set FirstName ='{FirstName}',LastName ='{LastName}',Phone='{Phone}',CNIC ='{Cnic}',Email='{Email}',UserName='{UserName}',Password='{Password}',Role='{Role}',Isactive={1}  Where Id = '{Id}'";
                messageType = "Updated";
            }
            else
            {
                sql = $"Insert into tbl_MangerUser(FirstName,LastName,Phone,CNIC,Email,UserName,Password,Role,Isactive) values('{FirstName}', '{LastName}', '{Phone}','{Cnic}','{Email}','{UserName}','{Password}','{Role}','{1}')";
                messageType = "Inserted";
            }


            SqlCommand Add = new SqlCommand(sql, SqlConnection);
            SqlConnection.Open();
           Add.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show($"Successfully {messageType}");

            //Clear The Record 
            txtLastName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCnic.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUserName.Text = string.Empty;txtFirstName.Text = string.Empty;
            



            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_MangerUser where IsActive= 1 ", SqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }
        

      




        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Admin1
        {
            public int Id { get; set; }
            public String AdminName { get; set; }
        }
        public class Empolyee
        {
            public int Id { get; set; }
            public String EmpolyeeName { get; set; }
        }


        public class Admin
        {
            public int Id  { get; set; }
            public string AminName  { get; set; }
        }
        public class User
        {
            public int Id { get; set; }
            public string UserName { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            var Id = txtUserID.ToString();
            var FirstName = txtFirstName.Text;
            var LastName = txtLastName.Text;
            var Phone = txtPhone.Text;
            var Cnic = txtCnic.Text;
            var Email = txtEmail.Text;
            var UserName = txtUserName.Text;
            var Password = txtPassword.Text;
            var Role = cmbRole.SelectedIndex;

            var sql = string.Empty;
            if (string.IsNullOrEmpty(txtUserID.ToString()))
            {
                sql = $"Insert into tbl_MangerUser( FirstName,LastName,Phone,CNIC,Email,UserName,Password,Role,Isactive) values('{FirstName}', '{LastName}', '{Phone}','{Cnic}','{Email}','{UserName}','{Password}','{Role}',1)";
            }
            else
            {
                sql = $"Update tbl_MangerUser Set FirstName ={FirstName},LastName ={LastName},Phone={Phone},CNIC ={Cnic},Email={Email},UserName={UserName},Password={Password},Role{Role},Isactive{1} Where Id = {Id}'";
            }
            SqlCommand Add = new SqlCommand(sql, SqlConnection);
            SqlConnection.Open();
             Add.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Successfully Update");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtLastName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtCnic.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUserName.Text = string.Empty; txtFirstName.Text = string.Empty;


        }

        private void UC_ManageUser_Load(object sender, EventArgs e)
        {

        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            var Id = 0;
            if(!string.IsNullOrEmpty(txtUserID.Text))
            {
                Id = Convert.ToInt32(txtUserID.Text);
            }
            
            SqlDataAdapter Da = new SqlDataAdapter($"Delete from tbl_MangerUser Where Id = {Id}", SqlConnection);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            MessageBox.Show("Successfully Delete");
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_MangerUser where IsActive= 1 ", SqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string FirstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string LastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string Phone = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string CNIC = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string Email = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string UserName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string Password = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string Role = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            txtUserID.Text = Id;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtPhone.Text = Phone;
            txtCnic.Text = CNIC;
            txtEmail.Text = Email;
            txtUserName.Text = UserName;
            txtPassword.Text = Password;
            cmbRole.SelectedIndex = 0;

        }
    }
}
