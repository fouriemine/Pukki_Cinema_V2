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

namespace Genre
{
    public partial class frmGenre : Form
    {
        //Connect to database
        SqlCommand comm;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet ds;
        String sql;
        int deleteID = 1, updateID;
        

        String connStr = @"Data Source=IPS;Initial Catalog = Pukki_Cinema; Integrated Security = True";
        public frmGenre()
        {
            InitializeComponent();
        }

        private void lblAddGenre_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxDescription.Visible = false;
                txtbDescription.Visible = true;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Add Genre";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                btnAdd.Visible = true;
                txtbGenreId.Visible = true;
                lblMaxCharactersValidation.Visible = true; // show the help fuction


                // clear the tools
                comboBoxDescription.Items.Clear();
                cmbGenreId.Items.Clear();
                txtbGenreId.Text = "";
                txtbDescription.Text = "";


                //Populate DataGridview 
                sql = "SELECT* FROM GENRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                dtgDisplay.DataSource = ds;
                dtgDisplay.DataMember = "GENRES";


            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void lblDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxDescription.Visible = false;
                txtbDescription.Visible = false;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Delete Genre";
                btnDelete.Visible = true;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                cmbGenreId.Visible = true;
                txtbGenreId.Visible = false;

                // clear the tools
                comboBoxDescription.Items.Clear();
                cmbGenreId.Items.Clear();
                txtbGenreId.Text = "";
                txtbDescription.Text = "";

                con.Open();
                sql = $"SELECT Genre_ID FROM GENRES ";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");



                //populating genre Genre ID combo box

                cmbGenreId.DataSource = ds.Tables["GENRES"];
                cmbGenreId.DisplayMember = "Genre_ID";
                cmbGenreId.ValueMember = "Genre_ID";

                con.Close();


            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void frmGenre_Load(object sender, EventArgs e)
        {

            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            groupBox1.Text = " ";
            comboBoxDescription.Enabled = false;
            cmbGenreId.Visible = false;
            txtbDescription.Visible = false;
            txtbGenreId.Visible = false;
            lblMaxCharactersValidation.Visible = false;



            try
            {
                con = new SqlConnection(connStr);
                con.Open();  //open connection

                //Populate DataGridview 
                sql = "SELECT* FROM GENRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                dtgDisplay.DataSource = ds;
                dtgDisplay.DataMember = "GENRES";


                con.Close(); //close connection
                MessageBox.Show("Connection Successful");
            }
            catch
            {
                MessageBox.Show("Connection to database Unsuccessful");
            }


        }

        private void lblUpdateGenre_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Text = "Update Genre";
                dtgDisplay.Visible = true;
                txtbDescription.Visible = true;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtbGenreId.Visible = false;
                cmbGenreId.Visible = true;
                lblMaxCharactersValidation.Visible = false;


                // clear the tools
                comboBoxDescription.Items.Clear();
                cmbGenreId.Items.Clear();
                txtbGenreId.Text = "";
                txtbDescription.Text = "";

                con.Close();
                //Populate DataGridview 
                sql = "SELECT* FROM GENRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                dtgDisplay.DataSource = ds;
                dtgDisplay.DataMember = "GENRES";

                //populating genre description combo box
                cmbGenreId.DataSource = ds.Tables["GENRES"];
                cmbGenreId.DisplayMember = "Genre_ID";
                cmbGenreId.ValueMember = "Genre_ID";
                reload();
                con.Close();

            }
            catch
            {
                MessageBox.Show("Error!");
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbGenreId.SelectedValue != null)
            {

                if (txtbDescription.Text != "")
                {

                    con.Open(); //Open connection
                    sql = $"Update GENRES SET Description ='{txtbDescription.Text}' WHERE Genre_ID ={int.Parse(cmbGenreId.SelectedValue.ToString())}";
                    comm = new SqlCommand(sql, con);
                    adapt = new SqlDataAdapter();
                    ds = new DataSet();
                    adapt.UpdateCommand = comm;
                    adapt.UpdateCommand.ExecuteNonQuery();
                    reload();
                    con.Close(); // close connection




                }
                else
                {
                    MessageBox.Show(" Please Provide a new Genre before you update!! ");
                }
            }
            else
            {
                MessageBox.Show("Please make select a Genre Id!! ");
            }


        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string message = "Are sure you want to delete Genre "   +cmbGenreId.SelectedValue+ "?";
                string title = "Delete Genre";

                //verify if the user wants to delete the Genre selected

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    if (cmbGenreId.SelectedIndex != -1)
                    {
                        deleteID = int.Parse(cmbGenreId.SelectedValue.ToString());
                        con.Open();
                        sql = $"DELETE FROM GENRES WHERE Genre_ID = {int.Parse(cmbGenreId.SelectedValue.ToString())}";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, con);
                        // comm.Parameters.AddWithValue("@id", deleteID);
                        adapt.DeleteCommand = comm;
                        adapt.DeleteCommand.ExecuteNonQuery();

                        //Update user
                        MessageBox.Show("Deleted successfully");

                        //re-populaate combobox
                        sql = "SELECT Genre_ID FROM GENRES";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, con);
                        adapt.SelectCommand = comm;
                        adapt.Fill(ds, "GENRES");


                        //populating combobox with genre Id available
                        cmbGenreId.DataSource = ds.Tables["GENRES"];
                        cmbGenreId.DisplayMember = "Genre_ID";
                        cmbGenreId.ValueMember = "Genre_ID";

                        //reload griview
                        reload();

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Before you delete a Genre, you need to first select a Genre ID from the options provided!! ");
                    }
                }



                else
                {
                    this.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);  //display an exception caught
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtbDescription.Text != "")
                {
                    con.Open(); // open connection


                    sql = $"INSERT  GENRES (Description) VALUES('{txtbDescription.Text}')";
                    comm = new SqlCommand(sql, con);
                    adapt = new SqlDataAdapter();
                    ds = new DataSet();
                    adapt.InsertCommand = comm;
                    adapt.InsertCommand.ExecuteNonQuery();
                    reload();
                    con.Close(); //close connection
                }

                //Display message box 
                MessageBox.Show("Data Inserted");

            }
            catch
            {

                MessageBox.Show("Could not Add Data!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // close this form to go back to the login form
            this.Close();
        }

        private void reload()

        {

            try
            {


                //open the connection
                con = new SqlConnection(connStr);
                con.Open();  //open connection

                //Populate Gridview with current genres
                sql = "SELECT * FROM  GENRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");
                dtgDisplay.DataSource = ds;
                dtgDisplay.DataMember = "GENRES";
                con.Close();

            }
            catch
            {
                MessageBox.Show("Could update database with new request.");
            }

        }
    }
}

