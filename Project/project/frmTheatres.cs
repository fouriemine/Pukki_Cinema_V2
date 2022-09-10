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
    public partial class frmTheatres : Form
    {
        //Blessing Lache-Evandip
        //Connect to database
        SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataSet ds;
        String sql;
        int deleteID = 1, updateID;

        String connStr = @"Data Source=BLESSINGSPC\SQLSERVER;Initial Catalog=Pukki_Cinema;Integrated Security=True";

        public frmTheatres()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void reLoad()
        {
            try
            {
                
                //open the connection
                conn = new SqlConnection(connStr);
                conn.Open();  //open connection

                //Populate Gridview with current theatres
                sql = "SELECT * FROM THEATRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "THEATRES");
                dgvDisplayTheatres.DataSource = ds;
                dgvDisplayTheatres.DataMember = "THEATRES";
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Could update database with new request.");
            }
        }


        private void frmTheatres_Load(object sender, EventArgs e)
        {
            try
            {
                gbTheatre.Text = " ";
                //set all controls to invisible
                lblTheatreID.Visible = false;
                cbTheatreID.Visible = false;
                lblAddTheatreCapacity.Visible = false;
                tbAddTheatreCapacity.Visible = false;
                bttnAddTheatre.Visible = false;
                bttnUpdateTheatre.Visible = false;
                bttnDeleteTheatre.Visible = false;

                //open the connection
                conn = new SqlConnection(connStr);
                conn.Open();  //open connection

                //Populate Gridview with current theatres
                sql = "SELECT * FROM THEATRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "THEATRES");
                dgvDisplayTheatres.DataSource = ds;
                dgvDisplayTheatres.DataMember = "THEATRES";
                conn.Close();
            }
            catch
            {

            }
        }

        private void lblAddTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                gbTheatre.Text = "Add Theatre";
                //make the necessary controls visible
                lblTheatreID.Visible = true;
                cbTheatreID.Visible = true;
                lblAddTheatreCapacity.Visible = true;
                tbAddTheatreCapacity.Visible = true;
                bttnAddTheatre.Visible = true;
                bttnUpdateTheatre.Visible = true;
                bttnDeleteTheatre.Visible = true;
                

              //Enable the needed controls
              bttnAddTheatre.Enabled = true;
                tbAddTheatreCapacity.Enabled = true;
                tbAddTheatreCapacity.Text = " ";
                cbTheatreID.Enabled = false;
                bttnDeleteTheatre.Enabled = false;
                bttnUpdateTheatre.Enabled = false;

                //open the connection
                conn = new SqlConnection(connStr);
                conn.Open();  //open connection

                //Display warning
                lblMaxNumberValidation.Visible = true;

                //Populate Gridview with current theatres
                sql = "SELECT * FROM THEATRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "THEATRES");
                dgvDisplayTheatres.DataSource = ds;
                dgvDisplayTheatres.DataMember = "THEATRES";
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Could not access updated theatre table.");
            }
        }

        private void bttnAddTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                int addCapacity;
                if (tbAddTheatreCapacity.Text != " ")
                {
                    if (int.TryParse(tbAddTheatreCapacity.Text, out addCapacity))
                    {
                        conn.Open();
                        sql = $"INSERT INTO THEATRES(Capacity) VALUES('{tbAddTheatreCapacity.Text}')";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        adapt.InsertCommand = comm;
                        adapt.InsertCommand.ExecuteNonQuery();
                        comm.Dispose();

                        //Notify user
                        MessageBox.Show("Record added successfully");

                        reLoad();

                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Capacity can only be an integer");
                    }
                }
                else
                    MessageBox.Show("You have to specify the capacity in the provided textbox.");
            }
            catch(Exception wrong)
            {
                MessageBox.Show("Could not add to theatre table." + wrong.Message);
                this.Close();
            }
        }

        private void lblChangeTheatre_Click(object sender, EventArgs e)
        {
            gbTheatre.Text = "Update Theatre";
            cbTheatreID.Enabled = true;

            //Hide validation label
            lblMaxNumberValidation.Visible = false;

            try
            {
                //making all controls visible 
                lblTheatreID.Visible = true;
                cbTheatreID.Visible = true;
                lblAddTheatreCapacity.Visible = true;
                tbAddTheatreCapacity.Visible = true;
                bttnAddTheatre.Visible = true;
                bttnUpdateTheatre.Visible = true;
                bttnDeleteTheatre.Visible = true;

                //enabling needed controls
                bttnAddTheatre.Enabled = false;
                tbAddTheatreCapacity.Enabled = true;
                tbAddTheatreCapacity.Text = " ";  //ensure to set the defalut text to nothing
                cbTheatreID.Enabled = true;
                bttnDeleteTheatre.Enabled = false;
                bttnUpdateTheatre.Enabled = true;

                conn.Open();
                sql = "SELECT Theatre_ID FROM THEATRES";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "THEATRES");
                

                //populating combobox with theatres Id available
                cbTheatreID.DataSource = ds.Tables["THEATRES"];
                cbTheatreID.DisplayMember = "Theatre_ID";
                cbTheatreID.ValueMember = "Theatre_ID";
                reLoad();

            }
            catch
            {
                MessageBox.Show("Could not access updated theatre table.");
            }
        }

        private void bttnUpdateTheatre_Click(object sender, EventArgs e)
        {
            try
            { 
                if (cbTheatreID.SelectedIndex != -1 )
                {
                        if (tbAddTheatreCapacity.Text != " ")
                        {
                            conn.Open();
                            sql = $"UPDATE THEATRES SET Capacity = {int.Parse(tbAddTheatreCapacity.Text)} WHERE Theatre_ID = {int.Parse(cbTheatreID.SelectedValue.ToString())} ";
                            adapt = new SqlDataAdapter();
                            ds = new DataSet();
                            comm = new SqlCommand(sql, conn);
                            adapt.UpdateCommand = comm;
                            adapt.UpdateCommand.ExecuteNonQuery();

                            //update user
                            MessageBox.Show("Updated successfully");
                            
                            reLoad();

                            conn.Close();
                        }
                        else
                            MessageBox.Show("Before you update a theatre, you need to provide a new size for the theatre!!");
                }
            else
            {
                MessageBox.Show("Before you update a theatre, you need to first select a theatre ID from the options provided!!");
            }

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bttnDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbAddTheatreCapacity.Enabled)
                {

                    if (cbTheatreID.SelectedIndex != -1)
                    {
                        deleteID = int.Parse(cbTheatreID.SelectedValue.ToString());
                        conn.Open();
                        sql = $"DELETE FROM THEATRES WHERE Theatre_ID = {int.Parse(cbTheatreID.SelectedValue.ToString())} ";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        // comm.Parameters.AddWithValue("@id", deleteID);
                        adapt.DeleteCommand = comm;
                        adapt.DeleteCommand.ExecuteNonQuery();

                        //Update user
                        MessageBox.Show("Deleted successfully");

                        //re-populaate combobox
                        sql = "SELECT Theatre_ID FROM THEATRES";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        adapt.SelectCommand = comm;
                        adapt.Fill(ds, "THEATRES");


                        //populating combobox with theatres Id available
                        cbTheatreID.DataSource = ds.Tables["THEATRES"];
                        cbTheatreID.DisplayMember = "Theatre_ID";
                        cbTheatreID.ValueMember = "Theatre_ID";

                        //reload griview
                        reLoad();

                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Before you delete a theatre, you need to first select a theatre ID from the options provided!! ");
                    }
                }
                else
                {
                    tbAddTheatreCapacity.Enabled = false;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void lblDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                //hide validation lale
                lblMaxNumberValidation.Visible = false; 

                gbTheatre.Text = "Delete Theatre";
                //making all controls visible 
                lblTheatreID.Visible = true;
                cbTheatreID.Visible = true;
                lblAddTheatreCapacity.Visible = true;
                tbAddTheatreCapacity.Visible = true;
                bttnAddTheatre.Visible = true;
                bttnUpdateTheatre.Visible = true;
                bttnDeleteTheatre.Visible = true;

                //enabling the combobox and disabling the textbox, add and update buttons
                cbTheatreID.Enabled = true;
                bttnDeleteTheatre.Enabled = true;
                tbAddTheatreCapacity.Text = "Cannot input value!!";
                tbAddTheatreCapacity.Enabled = false;
                bttnAddTheatre.Enabled = false;
                bttnUpdateTheatre.Enabled = false;

                conn.Open();
                sql = $"SELECT Theatre_ID  FROM THEATRES ";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "THEATRES");


                //populating combobox with theatres Id available
                cbTheatreID.DataSource = ds.Tables["THEATRES"];
                cbTheatreID.DisplayMember = "Theatre_ID";
                cbTheatreID.ValueMember = "Theatre_ID";

                reLoad();  //populate gridview

            }
            catch
            {
                MessageBox.Show("Could not access updated theatre table.");
            }
        }
    }
}
