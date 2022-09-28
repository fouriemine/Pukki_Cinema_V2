using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace project
{
    public partial class frmUsers : Form
    {
        //connecting to database
        public String conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        public SqlDataReader dr;
        string sql;
    
        private bool flag = true;

        private String isValidPass;

        public frmUsers()
        {
            InitializeComponent();
            reLoad();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {//set the group box to be invisible when loading
            gbx_users.Visible = false;
            button2.Visible = true;
            HelpFunctionPicture.Visible = true;
            btnclose_help.Visible = false;
            HelpFunctionPicture.Visible = false;
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                // MessageBox.Show("Connection Successfull");
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
                cbUserID.DataSource = ds.Tables["USERS"];
                cbUserID.DisplayMember = "Users_ID";
                cbUserID.ValueMember = "Users_ID";
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
            cbUserID.Text = "";
            txtSearch.Text = "";

        }

        public void dispAll()
        {
            gbx_users.Visible = true;
            lbl_UserId.Visible = true;
            cbUserID.Visible = true;
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
            lbl_PasswordDisp.Visible = true;
            label2.Visible = true;
            //btn_GetUser.Visible = true;
        }

        private void lblAdd_Users_Click(object sender, EventArgs e)
        {

            dispAll();
            //setting controls when the Add label is clicked
            lbl_UserId.Visible = false;
            gbx_users.Text = "Add Users";
            cbUserID.Visible = false;
            btn_Update.Visible = false;
            btn_Delete.Visible = false;
            label2.Visible = false;

            errorProvider1.SetError(textbx_Username, "");
            errorProvider1.SetError(txt_password, "");
            errorProvider1.SetError(pnl_Admin, "");

            ClearData();
            reLoad();
            cbUserID.SelectedIndex = -1;
            cbUserID.SelectedText = "";

            cbUserID.Text = " ";
            textbx_Username.Clear();
            txt_password.Clear();
        }

        private void lblUpdate_Users_Click(object sender, EventArgs e)
        {
            
 
            sql = "SELECT Users_ID FROM USERS";
            adap = new SqlDataAdapter();
            ds = new DataSet();
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            adap.Fill(ds, "USERS");

            errorProvider1.SetError(cbUserID, "");
            errorProvider1.SetError(textbx_Username, "");
            errorProvider1.SetError(txt_password, "");
            errorProvider1.SetError(pnl_Admin, "");


            //populating combobox with Users Id available
            cbUserID.DataSource = ds.Tables["USERS"];
            cbUserID.DisplayMember = "Users_ID";
            cbUserID.ValueMember = "Users_ID";

            //setting controls when the update label is clicked
            gbx_users.Text = "Update Users";
            dispAll();
            btn_add.Visible = false;
            label2.Visible = false;
       
            //btn_GetUser.Visible = false;
            btn_Delete.Visible = false;
            ClearData();
            reLoad();
            cbUserID.SelectedIndex =-1;
            cbUserID.SelectedText = "";

            cbUserID.Text = " ";
            textbx_Username.Text = " ";
            txt_password.Text = " ";
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
            lbl_PasswordDisp.Visible = false;
            label2.Visible = false;
            btn_Update.Visible = false;

            errorProvider1.SetError(cbUserID, "");

            ClearData();
            reLoad();
            cbUserID.SelectedIndex = -1;  //not working
        }

        //ADD DATA
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbx_Username.Text != "")
                {
                    errorProvider1.SetError(textbx_Username, "");
                }
                else
                {
                    errorProvider1.SetError(textbx_Username, "Please enter the username that needs to be updated");
                }
                if (txt_password.Text != "")
                {
                    errorProvider1.SetError(txt_password, "");
                }
                else
                {
                    errorProvider1.SetError(txt_password, "Please enter the password that needs to be updated");
                }

                String isAdmin;
                bool rdoFlag = false;
                if (rdo_AdminYes.Checked || rdo_AdminNo.Checked)
                {
                    rdoFlag = true;

                    errorProvider1.SetError(pnl_Admin, "");
                }
                else
                {
                    errorProvider1.SetError(pnl_Admin, "Please selecter whether the user is an admin or not");
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
                    /* if (isValidPass != "")
                     {
                         MessageBox.Show(isValidPass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }*/
                    conn.Open();
                    SqlCommand com = new SqlCommand("Select count(*) from USERS where Username= @Username", conn);
                    com.Parameters.AddWithValue("@Username", this.textbx_Username.Text);
                    
                    int result = (int)com.ExecuteScalar();
                    if (result != 0)
                    {
                        MessageBox.Show(string.Format("Username {0} already exist", this.textbx_Username.Text));
                        conn.Close();
                        reLoad();
                        ClearData();

                    }

                    if (isValidPass != "")
                    {
                        MessageBox.Show(isValidPass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        com = new SqlCommand("insert into USERS(Username,Password, IsAdmin) values(@username, @password , @IsAdmin)", conn);
                        com.Parameters.AddWithValue("@username", textbx_Username.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);
                        com.Parameters.AddWithValue("@IsAdmin", isAdmin);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Added the record successfully");
                        conn.Close();
                        reLoad();
                        ClearData();
                    }



                }
                else
                {
                    errorProvider1.SetError(textbx_Username, "Ensure the username to be added ");
                    errorProvider1.SetError(txt_password, "Please enter the password to be added");
                    errorProvider1.SetError(pnl_Admin, "Please selecter whether the user is an admin or not");
                    //MessageBox.Show("Please enter details to add to the database. ");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Unable to add new user: " + error.Message);
            }

        }
        //UPDATING RECORD DETAILS
        private void btn_Update_Click(object sender, EventArgs e)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            if (textbx_Username.Text != "")
            {
                errorProvider1.SetError(textbx_Username, "");
                flag1 = true;
            }
            else
            {
                errorProvider1.SetError(textbx_Username, "Please enter the username that needs to be updated");

            }
            if (txt_password.Text != "")
            {
                errorProvider1.SetError(txt_password, "");
                flag2 = true;
            }
            else
            {
                errorProvider1.SetError(txt_password, "Please enter the password that needs to be updated");

            }
            if (cbUserID.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbUserID, "Please select the ID to be updated");
            }
            else
            {
                errorProvider1.SetError(cbUserID, "");
                flag3 = true;
            }


            try
            {



                String isAdmin;
                bool rdoFlag = false;
                if (rdo_AdminYes.Checked || rdo_AdminNo.Checked)
                {
                    rdoFlag = true;
                    errorProvider1.SetError(pnl_Admin, "");
                }
                else
                {
                    errorProvider1.SetError(pnl_Admin, "Please selecter whether the user is an admin or not");
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
                    if (isValidPass != "")
                    {
                        MessageBox.Show(isValidPass, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SqlCommand com = new SqlCommand("Select count(*) from USERS where Username= @Username", conn);
                    com.Parameters.AddWithValue("@Username", this.textbx_Username.Text);
                    conn.Open();
                    int result = (int)com.ExecuteScalar();
                    if (result != 0)
                    {
                        MessageBox.Show(string.Format("Username {0} already exist", this.textbx_Username.Text));
                        conn.Close();
                        reLoad();
                        ClearData();

                    }
                    /*do
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        com = new SqlCommand("update USERS set Username=@username , Password = @password , IsAdmin = @IsAdmin where Users_ID= @id", conn);
                        com.Parameters.AddWithValue("@id", cbUserID.SelectedValue);
                        com.Parameters.AddWithValue("@username", textbx_Username.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);
                        com.Parameters.AddWithValue("@IsAdmin", isAdmin);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Updated the record successfully");
                        conn.Close();
                        reLoad();
                        ClearData();

                    }
                    while
                    {
                        catchMessage1 == true && catchMessage2 == true && catchMessage3 == true

                    }*/
                    else
                    {
                        //if (catchMessage1 == true && catchMessage2 == true && catchMessage3 == true)
                        //{
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        com = new SqlCommand("update USERS set Username=@username , Password = @password , IsAdmin = @IsAdmin where Users_ID= @id", conn);
                        com.Parameters.AddWithValue("@id", cbUserID.SelectedValue);
                        com.Parameters.AddWithValue("@username", textbx_Username.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);
                        com.Parameters.AddWithValue("@IsAdmin", isAdmin);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Updated the record successfully");
                        conn.Close();
                        reLoad();
                        ClearData();
                        //}
                    }

                }
                else
                {
                    //errorProvider1.SetError(cbUserID, "Please select the ID to be updated");
                    /*errorProvider1.SetError(textbx_Username, "Please enter the username that needs to be updated");
                    errorProvider1.SetError(txt_password, "Please enter the password that needs to be updated");
                    errorProvider1.SetError(pnl_Admin, "Please selecter whether the user is an admin or not");*/
                }


            }
            catch (Exception error)
            {

                if (cbUserID.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cbUserID, "Please select the ID to be updated");
                }
                else
                {
                    errorProvider1.SetError(cbUserID, "");

                }
            }

        }

        //DELETE USERS DETAILS
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cbUserID.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbUserID, "Please select the ID to be updated");
            }
            else
            {
                errorProvider1.SetError(cbUserID, "");

            }

            try
            {
                lbl_PasswordDisp.Visible = false;
                label2.Visible = false;
                //deletes if an id is selected
                if (cbUserID.SelectedValue != "")
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    com = new SqlCommand("SELECT Username FROM USERS WHERE Users_ID=@userID", conn);
                    com.Parameters.AddWithValue("@userID", cbUserID.SelectedValue);
                    String name = (String)com.ExecuteScalar();
                    conn.Close();
                    if (MessageBox.Show("Are you sure you want to delete " + name + "?", "Deleted Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        com = new SqlCommand("delete from USERS where Users_ID = @id", conn);
                        com.Parameters.AddWithValue("@id", cbUserID.SelectedValue);
                        com.ExecuteNonQuery();
                        MessageBox.Show(" Record deleted successfully");
                        reLoad();
                        ClearData();
                    }
                }
                else
                {

                    errorProvider1.SetError(cbUserID, "Please select the ID to be deleted");

                }

                cbUserID.SelectedIndex = -1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gbx_users_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //displays help function
            HelpFunctionPicture.Visible = true;
            button2.Visible = false;
            btnclose_help.Visible = true;
        }

        private void btnclose_help_Click(object sender, EventArgs e)
        {
            HelpFunctionPicture.Visible = false;
            button2.Visible = true;
            btnclose_help.Visible = false;

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        { //Minimum of 8 characters and maximum of 14 characters

            String temp = txt_password.Text;
            lbl_PasswordDisp.Visible = true;
            string regex = "^(?=.*[a-z])(?=."
                    + "*[A-Z])(?=.*\\d)"
                    + "(?=.*[-+_!@#$%^&*., ?]).+$";

            Regex p = new Regex(regex);

            Match m = p.Match(temp);
            if (!(temp.Length < 8 || temp.Length > 14))
            {
                if (!m.Success || temp.Contains(" "))
                {
                    isValidPass = "Password should contain upper case, lower case and a special character\n" +
                        "Password should not contain whitespaces.";
                    lbl_PasswordDisp.Text = isValidPass;
                }
                else
                {
                    isValidPass = "";
                    lbl_PasswordDisp.Text = "";
                }
            }
            else
            {
                isValidPass = "Password should be a minimum of 8 characters and a maximum of 14 letters";
                lbl_PasswordDisp.Text = isValidPass;
            }

        }

        private void lblSearchUser_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from USERS WHERE Username LIKE '%" + txtSearch.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conStr);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Username");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Username";

            /* if (txtSearch.Text != "")
             {
                 conn = new SqlConnection(conStr);
                 conn.Open();
                 //Populate gridview with Users
                 adap = new SqlDataAdapter();
                 ds = new DataSet();
                 com = new SqlCommand("select * from USERS where Username = @username", conn);
                 com.Parameters.AddWithValue("@username", txtSearch.Text);
                 adap.SelectCommand = com;
                 adap.Fill(ds, "USERS");
                 dataGridView1.DataSource = ds;
                 dataGridView1.DataMember = "USERS";
                 conn.Close();
                 dataGridView1.Visible = true;
                 ClearData();*/

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("User not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*else
            {
                MessageBox.Show("Enter all necessary details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        //dataGridView1.Visible = false;
        /*if (txtSearch.Text != "")
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            //Populate gridview with Users
            adap = new SqlDataAdapter();
            ds = new DataSet();
            com = new SqlCommand("select * from USERS where Username = @username", conn);
            com.Parameters.AddWithValue("@username", txtSearch.Text);
            adap.SelectCommand = com;
            adap.Fill(ds, "USERS");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "USERS";
            conn.Close();
            dataGridView1.Visible = true;
            ClearData();

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("User not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Enter all necessary details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }*/

        private void btn_previous_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



        private void textbx_Username_TextChanged(object sender, EventArgs e)
        {
            String temp = textbx_Username.Text;
            label2.Visible = true;
            string regex = "([a-z])";

            Regex p = new Regex(regex);

            Match m = p.Match(temp);
            if (!(temp.Length < 0 || temp.Length > 55))
            {
                if (temp.Contains(" "))
                {
                    isValidPass = "Username should not contain whitespace.";
                    label2.Text = isValidPass;
                }
                else
                {
                    isValidPass = "";
                    label2.Text = "";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            reLoad();
        }

        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        
        {

            if (cbUserID.SelectedIndex != -1)
            {
                try
                {
                    if (cbUserID.SelectedIndex != -1)
                    {

                        conn.Close();
                        conn.Open();

                        textbx_Username.Enabled = true;
                        txt_password.Enabled = true;

                        adap = new SqlDataAdapter();
                        DataSet ds = new DataSet();

                        sql = $"SELECT Username FROM USERS WHERE Users_ID = {int.Parse(cbUserID.Text)}";
                        com = new SqlCommand(sql, conn);
                        adap.SelectCommand = com;
                        adap.Fill(ds, "USERS");
                        string username = com.ExecuteScalar().ToString();
                        textbx_Username.Text = username;


                        sql = $"SELECT Password FROM USERS WHERE Users_ID = {int.Parse(cbUserID.Text)}";
                        com = new SqlCommand(sql, conn);
                        adap.SelectCommand = com;
                        adap.Fill(ds, "USERS");
                        string pass = (string)com.ExecuteScalar();
                        txt_password.Text = pass;

                        
                        flag = false;
                        conn.Close();

                    }
                }
                catch (Exception error)
                {
                    

                }
            }
        }

        private void lbl_PasswordDisp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_adminYN_Click(object sender, EventArgs e)
        {

        }
    }
}

