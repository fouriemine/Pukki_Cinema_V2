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


namespace project
{
    public partial class frmUsers : Form
    {
        //connecting to database
        public String conStr = @"Data Source=LAPTOP-H4VOFVUF\MSSQLSERVER1;Initial Catalog=Pukki_Cinema;Integrated Security=True";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        string sql = " ";

        public frmUsers()
        {
            InitializeComponent();
            reLoad();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {//set the group box to be invisible when loading
            gbx_users.Visible = false;
            
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                MessageBox.Show("Connection Successfull");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }

            try
            {
                reLoad();
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Cannot populate the grid view");
            }

            ClearData();
        }
        public void reLoad()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                //Populate gridview with Users
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand("select * from USERS", conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "USERS");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "USERS";
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Cannot update the database with the new request");
            }
        }
        //Clear Data  
        private void ClearData()
        {
            textbx_Username.Text = "";
            txt_password.Text = "";
            rdo_AdminYes.Checked = false;
            rdo_AdminNo.Checked = false;
            txtBox_UserID.Text = "";

        }

        public void dispAll()
        {
            gbx_users.Visible = true;
            lbl_UserId.Visible = true;
            txtBox_UserID.Visible = true;
            txt_password.Visible = true;
            textbx_Username.Visible = true;
            pnl_Admin.Visible = true;
            lbl_username.Visible = true;
            lbl_password.Visible = true;
            lbl_adminYN.Visible = true;
            btn_Update.Visible = true;
            btn_Delete.Visible = true;
            btn_add.Visible = true;
            dataGridView1.Visible = true;
            //btn_GetUser.Visible = true;
        }

        private void lblAdd_Users_Click(object sender, EventArgs e)
        {
            dispAll();
            //setting controls when the Add label is clicked
            lbl_UserId.Visible = false;
            gbx_users.Text = "Add Users";
            txtBox_UserID.Visible = false;
            btn_Update.Visible = false;
            btn_Delete.Visible = false;
           // btn_GetUser.Visible = false;
            ClearData();
            reLoad();
        }

        private void lblUpdate_Users_Click(object sender, EventArgs e)
        {
            //setting controls when the update label is clicked
            gbx_users.Text = "Update Users";
            dispAll();
            btn_add.Visible = false;
            //btn_GetUser.Visible = false;
            btn_Delete.Visible = false;
            ClearData();
            reLoad();
        }

        private void lbl_DeleteUsers_Click(object sender, EventArgs e)
        {
            //setting controls when the delete label is clicked
            gbx_users.Text = "Delete Users";
            dispAll();
            txt_password.Visible = false;
            textbx_Username.Visible = false;
            pnl_Admin.Visible = false;
            lbl_adminYN.Visible = false;
            lbl_password.Visible = false;
            lbl_username.Visible = false;
            btn_add.Visible = false;
            //btn_GetUser.Visible = false;
            btn_Update.Visible = false;
            ClearData();
            reLoad();
        }
        /*private void lbl_GetUser_Click(object sender, EventArgs e)
        {
            //setting controls when the delete label is clicked
            gbx_users.Text = "Get Users";
            dispAll();
            txt_password.Visible = false;
            txtBox_UserID.Visible = false;
            pnl_Admin.Visible = false;
            lbl_adminYN.Visible = false;
            lbl_password.Visible = false;
            lbl_UserId.Visible = false;
            btn_add.Visible = false;
            btn_Update.Visible = false;
            dataGridView1.Visible = false;
            btn_Delete.Visible = false;
            ClearData();
        }*/
        //ADD DATA
        private void btn_add_Click(object sender, EventArgs e)
        {
            String isAdmin;
            bool rdoFlag = false; ;
            if (rdo_AdminYes.Checked || rdo_AdminNo.Checked)
            {
                rdoFlag = true;
            }
            if (textbx_Username.Text != "" && txt_password.Text != "" && rdoFlag)
            {
                if (rdo_AdminNo.Checked)
                {
                    isAdmin = "false";
                }
                else
                {
                    isAdmin = "true";
                }

                conn.Open();
                com = new SqlCommand("insert into USERS(Username,Password, IsAdmin) values(@username, @password , @IsAdmin)", conn);
                com.Parameters.AddWithValue("@username", textbx_Username.Text);
                com.Parameters.AddWithValue("@password", txt_password.Text);
                com.Parameters.AddWithValue("@IsAdmin", isAdmin);
                com.ExecuteNonQuery();
                MessageBox.Show("Added the record successfully");
                reLoad();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter details to add to the database. ");
            }

        }
        //UPDATING RECORD DETAILS
        private void btn_Update_Click(object sender, EventArgs e)
        {
            String isAdmin;
            bool rdoFlag = false; ;
            if (rdo_AdminYes.Checked || rdo_AdminNo.Checked)
            {
                rdoFlag = true;
            }
            if (textbx_Username.Text != "" && txt_password.Text != "" && rdoFlag)
            {
                if(rdo_AdminNo.Checked)
                {
                    isAdmin = "false";
                }
                else
                {
                    isAdmin = "true";
                }
                conn.Open();
                com = new SqlCommand("update USERS set Username=@username , Password = @password , IsAdmin = @IsAdmin where Users_ID= @id", conn);
                com.Parameters.AddWithValue("@id", txtBox_UserID.Text);
                com.Parameters.AddWithValue("@username", textbx_Username.Text);
                com.Parameters.AddWithValue("@password", txt_password.Text);
                com.Parameters.AddWithValue("@IsAdmin", isAdmin);
                com.ExecuteNonQuery();
                MessageBox.Show("Updated the record successfully");
                conn.Close();
                reLoad();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the record you want to update to the database. ");
            }

        }

        /*private void btn_GetUSers_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            if(textbx_Username.Text != "")
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                //Populate gridview with Users
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand("select * from USERS where Username = @username", conn);
                com.Parameters.AddWithValue("@username", textbx_Username.Text);
                adap.SelectCommand = com;
                adap.Fill(ds, "USERS");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "USERS";
                conn.Close();
                dataGridView1.Visible = true;
                ClearData();
                if(dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("User not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter all necessary details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        //DELETE USERS DETAILS
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtBox_UserID.Text != "")
            {
                conn.Open();
                com = new SqlCommand("delete from USERS where Users_ID = @id", conn);
                com.Parameters.AddWithValue("@id",txtBox_UserID.Text);
                com.ExecuteNonQuery();
                MessageBox.Show(" record deleted successfully");
                reLoad();
                ClearData();
            }
            else {
                MessageBox.Show("Please enter the Id number you want to delete");
            }
        }

        private void gbx_users_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //displays help function
            HelpFunctionPicture.Visible = true;
        }

        private void btnclose_help_Click(object sender, EventArgs e)
        {
            HelpFunctionPicture.Visible = false;
        }

       private void txt_password_TextChanged(object sender, EventArgs e)
         { //Minimum of 8 characters and maximum of 14 characters
             if (txt_password.TextLength < 8 || txt_password.TextLength > 14)
             {
                MessageBox.Show("Password should be a minimum of 8 characters and a maximum of 14 letters");
             }
             /*
             //password should contain one upper case
             else if ( txt_password >= 'a' && txt_password <= 'z')
                MessageBox.Show("Password should contain one upper case");

            //Password should contain one lower case
            else if (!txt_password.Any(char.IsLower))
                MessageBox.Show("Password should contain one lower case");

            //Password should not have any white spaces
            else if (txt_password.Contains(" "))
                MessageBox.Show("Password should not contain any white spaces");

            //checks if password has any special characters
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
             char[] specialCh = specialCh.ToCharArray();
             foreach (char ch in specialChArray)
             {
                 if (txt_password.Contains(ch))
                    MessageBox.Show("Strong Password, you may continue");
            }*/



         }
    }
}

