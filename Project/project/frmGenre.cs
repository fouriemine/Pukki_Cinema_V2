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
using System.Text.RegularExpressions;

namespace project
{
    public partial class frmGenre : Form
    {
        //Connect to database
        SqlCommand comm;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        String sql;
        int deleteID = 1, updateID;
        private bool flag = true;
        ErrorProvider errProvDescription = new ErrorProvider();
        ErrorProvider errProvID = new ErrorProvider();


        String connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public frmGenre()
        {
            InitializeComponent();
        }

        public void ComboLoad()
        {
            //Creating method to populate combo boxes
            try
            {
                con.Open();

                adapt = new SqlDataAdapter();
                DataSet ds = new DataSet();


                ///////POPULATE COMBO BOXES
                sql = "SELECT * FROM GENRES";
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                comboBoxDescription.ValueMember = "Description";
                comboBoxDescription.DisplayMember = "Description";
                comboBoxDescription.DataSource = ds.Tables["GENRES"];
                cmbGenreId.ValueMember = "Genre_ID";
                cmbGenreId.DisplayMember = "Genre_ID";
                cmbGenreId.DataSource = ds.Tables["GENRES"];
                con.Close();
                errProvDescription.SetError(txtbDescription, "");
                errProvID.SetError(cmbGenreId, "");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblAddGenre_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
            try
            {
                comboBoxDescription.Visible = false;
                txtbDescription.Visible = true;
                lblGenreID.Visible = false;
                cmbGenreId.Visible = false;
                lblDescription.Visible = true;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Add Genre";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                lblDescription.Visible = true;
                txtSearch.Visible = true;
                dtgDisplay.Visible = true;

                



                //Populate DataGridview 
                reload();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblDeleteGenre_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
            try
            {
                txtbDescription.Visible = false;
                lblGenreID.Visible = true;
                cmbGenreId.Visible = true;
                comboBoxDescription.Visible = false;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Delete Genre";
                btnDelete.Visible = true;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                lblDescription.Visible = false;
                txtSearch.Visible = true;
                dtgDisplay.Visible = true;
                

                reload();

                comboBoxDescription.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGenre_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connStr);
            pictureBox2.Visible = false;
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
            comboBoxDescription.Visible = false;
            txtbDescription.Visible = false;
            lblGenreID.Visible = false;
            cmbGenreId.Visible = false;
            txtSearch.Visible = true;
            dtgDisplay.Visible = true;
          

            try
            {
                WindowState = FormWindowState.Maximized;

                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                groupBox1.Text = "Current Genres";
                lblDescription.Visible = false;

                reload();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void lblUpdateGenre_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");

            try
            {
                groupBox1.Text = "Update Genre";
                cmbGenreId.Visible = true;
                lblGenreID.Visible = true;
                dtgDisplay.Visible = true;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                lblDescription.Visible = true;
                comboBoxDescription.Visible = false;
                txtbDescription.Visible = true;
                txtSearch.Visible = true;
                dtgDisplay.Visible = true;
               



                // clear the tools

                reload();
                cmbGenreId.Enabled = true;
                txtbDescription.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");

            try
            {

                if (cmbGenreId.SelectedIndex != -1)
                {
                    if (txtbDescription.Text != "")
                    {



                        con.Open(); // open connection
                        SqlCommand com = new SqlCommand("Select count(*) from GENRES where Description = @desc", con);
                        com.Parameters.AddWithValue("@desc", this.txtbDescription.Text);

                        int result = (int)com.ExecuteScalar();

                        if (result != 0)
                        {
                            MessageBox.Show(string.Format("Description {0} already exists", this.txtbDescription.Text)); // display message if Genre already exists
                            //con.Close();
                            reload();
                            ComboLoad();
                        }
                        else
                        {
                            sql = $"Update GENRES SET Description ='{txtbDescription.Text}' WHERE Genre_ID ={int.Parse(cmbGenreId.SelectedValue.ToString())}";
                            comm = new SqlCommand(sql, con);
                            adapt = new SqlDataAdapter();
                            dt = new DataTable();
                            adapt.UpdateCommand = comm;
                            if (MessageBox.Show("Do you wish to update Genre " + cmbGenreId.SelectedValue.ToString(), "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                adapt.UpdateCommand.ExecuteNonQuery();
                                MessageBox.Show("Record updated successfully");
                                txtbDescription.Text = "";
                            }
                        }

                    }
                    else
                    {
                        errProvDescription.SetError(txtbDescription, "Please provide a Genre Discription");
                    }
                    con.Close(); //close connection 
                    reload();
                }
                else
                {
                    errProvID.SetError(cmbGenreId, "Please select a Genre Id"); // display an error provider

                }


            }

            catch (Exception error)
            {
                MessageBox.Show("Could not update Genre: " + error.Message);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
            try
            {
                ErrorProvider errProvDescription = new ErrorProvider();
                ErrorProvider errProvID = new ErrorProvider();

                string message = "Are sure you want to delete Genre " + comboBoxDescription.SelectedValue + "?";
                string title = "Delete Genre";
                //verify if the user wants to delete the Genre selected

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    if (cmbGenreId.SelectedValue != null)
                    {
                        con.Open();
                        sql = $"DELETE FROM GENRES WHERE Genre_ID = {int.Parse(cmbGenreId.SelectedValue.ToString())}";
                        adapt = new SqlDataAdapter();
                        dt = new DataTable();
                        comm = new SqlCommand(sql, con);

                        adapt.DeleteCommand = comm;
                        adapt.DeleteCommand.ExecuteNonQuery();

                        //Update user
                        MessageBox.Show("Deleted successfully");


                        con.Close();
                        reload();
                    }
                    else
                    {
                        errProvID.SetError(cmbGenreId, "Select a Genre ID"); // dispaly an error provider
                    }
                }
                else
                {
                    cmbGenreId.SelectedIndex = -1;
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("This genre cannot be deleted until all corresponding films for it has been deleted.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);  //display an exception caught
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
            try
            {
                if (txtbDescription.Text != "")
                {


                    con.Open(); // open connection
                    SqlCommand com = new SqlCommand("Select count(*) from GENRES where Description = @desc", con);
                    com.Parameters.AddWithValue("@desc", this.txtbDescription.Text);

                    int result = (int)com.ExecuteScalar();

                    if (result != 0)
                    {
                        MessageBox.Show(string.Format("Description {0} already exists", this.txtbDescription.Text)); // display message if Genre already exist
                        reload();
                        ComboLoad();
                    }
                    else
                    {
                        //add new Genre Description

                        sql = "INSERT INTO GENRES (Description) VALUES(@desc)";
                        comm = new SqlCommand(sql, con);
                        comm.Parameters.AddWithValue("@desc", txtbDescription.Text);
                        adapt = new SqlDataAdapter();
                        dt = new DataTable();
                        adapt.InsertCommand = comm;
                        if (MessageBox.Show("Do you wish to add Genre " + txtbDescription.Text, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)  //Ask if user wants to add inserted description
                        {
                            adapt.InsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Data Inserted");
                        }


                    }
                    con.Close();
                    reload();
                }
                else
                {
                    errProvDescription.SetError(txtbDescription, "Please provide a description");
                }

            }
            catch (Exception length)
            {

                MessageBox.Show("Could not Add Data" + length.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // close this form to go back to the login form
            this.DialogResult = DialogResult.OK;
        }

        private void closeHelp_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
            pictureBox2.Visible = false;
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = true;
            help_btn.Visible = false;
            pictureBox2.Visible = true;
            errProvDescription.SetError(txtbDescription, "");
            errProvID.SetError(cmbGenreId, "");
        }

        private void comboBoxDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (comboBoxDescription.SelectedIndex != -1)
                {
                    con = new SqlConnection(connStr);
                    con.Open();

                    adapt = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    sql = $"SELECT Genre_ID FROM GENRES WHERE Description = '{(String)comboBoxDescription.SelectedValue}'";
                    comm = new SqlCommand(sql, con);
                    adapt.SelectCommand = comm;
                    adapt.Fill(ds, "GENRES");
                    cmbGenreId.ValueMember = "Genre_ID";
                    cmbGenreId.DisplayMember = "Genre_ID";
                    cmbGenreId.DataSource = ds.Tables["GENRES"];


                    con.Close();
                }
                flag = true;
            }
        }

        private void cmbGenreID_SelecetedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGenreId.SelectedIndex != -1)
            {
                con = new SqlConnection(connStr);
                con.Open();

                adapt = new SqlDataAdapter();
                DataSet ds = new DataSet();

                sql = $"SELECT Description FROM GENRES WHERE Genre_ID = '{(int)cmbGenreId.SelectedValue}'";
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                String desc = (String)comm.ExecuteScalar();
                txtbDescription.Text = desc;

                flag = false;
                con.Close();
            }
        }

       

        

        private void txtSearch_TextChanged_2(object sender, EventArgs e)
        {
            // search through the data table
            (dtgDisplay.DataSource as DataTable).DefaultView.RowFilter = string.Format("Description LIKE '%{0}%'", txtSearch.Text);
        }

        private void txtbDescription_TextChanged_2(object sender, EventArgs e)
        {
           // Check for duplicates
            string regex = "([a-z])";

            Regex p = new Regex(regex);

            Match M = p.Match(txtbDescription.Text);
            if (!(txtbDescription.Text.Length < 0 || txtbDescription.Text.Length > 20))
            {
                if (txtbDescription.Text.Contains(" "))
                {
                    errProvDescription.SetError(txtbDescription, "Genre Description cannot contain whitespaces");
                }
                else
                {

                }
            }
        }

        private void reload()
        {
            try
            {
                cmbGenreId.SelectedIndex = -1;

                //open the connection
                con = new SqlConnection(connStr);
                con.Open();  //open connection

                //Populate Gridview with current genres
                sql = "SELECT * FROM  GENRES";

                dt = new DataTable();
                comm = new SqlCommand(sql, con);
                adapt = new SqlDataAdapter(comm);
                adapt.Fill(dt);
                dtgDisplay.DataSource = dt;
                con.Close();
                ComboLoad();
                cmbGenreId.SelectedIndex = -1;
                comboBoxDescription.SelectedIndex = -1;
                txtbDescription.Text = "";
                errProvDescription.SetError(txtbDescription, "");
                errProvID.SetError(cmbGenreId, "");
            }
            catch (Exception error)
            {
                MessageBox.Show("Could update database with new request." + error.Message);
            }

        }



    }

}

