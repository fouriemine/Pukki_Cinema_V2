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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblAddGenre_Click(object sender, EventArgs e)
        {
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

                //Populate DataGridview 
                reload();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {
                txtbDescription.Visible = false;
                lblGenreID.Visible = true;
                cmbGenreId.Visible = true;
                comboBoxDescription.Visible = true;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Delete Genre";
                btnDelete.Visible = true;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                lblDescription.Visible = true;
                reload();

                cmbGenreId.Enabled = false;
            }
            catch(Exception ex)
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
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void lblUpdateGenre_Click(object sender, EventArgs e)
        {
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
                //lblMaxCharactersValidation.Visible = false;


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
            try
            {

                if (cmbGenreId.SelectedIndex != -1)
                {
                    if (txtbDescription.Text != "")
                    {
                        con.Open(); //Open connection

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
                        con.Close(); // close connection

                        reload();
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter a description");
                    }
                }
                else
                {
                    MessageBox.Show("Please make select a Genre Id");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Could not update Genre: " + error.Message);
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are sure you want to delete Genre " + comboBoxDescription.SelectedValue+ "?";
                string title = "Delete Genre";
                //verify if the user wants to delete the Genre selected

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    if (comboBoxDescription.SelectedIndex != -1)
                    {
                        con.Open();
                        sql = $"DELETE FROM GENRES WHERE Genre_ID = {int.Parse(cmbGenreId.SelectedValue.ToString())}";
                        adapt = new SqlDataAdapter();
                        dt = new DataTable();
                        comm = new SqlCommand(sql, con);
                        // comm.Parameters.AddWithValue("@id", deleteID);
                        adapt.DeleteCommand = comm;
                        adapt.DeleteCommand.ExecuteNonQuery();

                        //Update user
                        MessageBox.Show("Deleted successfully");


                        //reload griview
                        

                        con.Close();
                        reload();
                    }
                    else
                    {
                        MessageBox.Show("Before you delete a Genre, you need to first select a Genre ID from the options provided");
                    }
                }
                else
                {
                    cmbGenreId.SelectedIndex = -1;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);  //display an exception caught
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtbDescription.Text != "")
                {
                    con.Open(); // open connection


                    sql = "INSERT INTO GENRES (Description) VALUES(@desc)";
                    comm = new SqlCommand(sql, con);
                    comm.Parameters.AddWithValue("@desc", txtbDescription.Text);
                    adapt = new SqlDataAdapter();
                    dt = new DataTable();
                    adapt.InsertCommand = comm;
                    if (MessageBox.Show("Do you wish to add Genre " + txtbDescription.Text, "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {
                        adapt.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted");
                    }
                    con.Close(); //close connection

                    reload();
                }
                else
                {
                    MessageBox.Show("Error, please enter the required data");
                }
            }
            catch
            {

                MessageBox.Show("Could not Add Data");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // close this form to go back to the login form
            this.DialogResult = DialogResult.OK;
            //Application.Run(new frmMenu());
        }

        private void closeHelp_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
            pictureBox2.Visible = false;
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = true;
            help_btn.Visible = false;
            pictureBox2.Visible = true;
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

                flag = false ;
                con.Close();
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
            }
            catch (Exception error)
            {
                MessageBox.Show("Could update database with new request." + error.Message);
            }

        }
    }
}

