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

namespace project
{
    public partial class frmTime_Allocation : Form
    {
        //Blessing Lache-Evandip
        //Connect to database
        SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataSet ds;
        String sql;
        int deleteID;
        DateTime time;

        String connStr = @"Data Source=BLESSINGSPC\SQLSERVER;Initial Catalog=Pukki_Cinema;Integrated Security=True";

        public frmTime_Allocation()
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
                sql = "SELECT * FROM TIME_ALLOCATIONS";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");
                dgvDisplayTimeAllocvations.DataSource = ds;
                dgvDisplayTimeAllocvations.DataMember = "TIME_ALLOCATIONS";
                conn.Close();
                conn.Dispose();

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
                gbTime_Allocation.Text = " ";
                //set all controls to invisible
                lblTimeID.Visible = false;
                cbTimeID.Visible = false;
                lblTimeBracket.Visible = false;
                tbTimeBracket.Visible = false;
                bttnAddTime.Visible = false;
                bttnUpdateTime.Visible = false;
                bttnDeleteTime.Visible = false;

                //open the connection
                conn = new SqlConnection(connStr);
                conn.Open();  //open connection

                //Populate Gridview with current theatres
                sql = "SELECT * FROM TIME_ALLOCATION";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");
                dgvDisplayTimeAllocvations.DataSource = ds;
                dgvDisplayTimeAllocvations.DataMember = "TIME_ALLOCATIONS";
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        private void lblAddTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                gbTime_Allocation.Text = "Add Time Group";
                //make the necessary controls visible
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = true;
                bttnUpdateTime.Visible = true;
                bttnDeleteTime.Visible = true;


                //Enable the needed controls
                bttnAddTime.Enabled = true;
                tbTimeBracket.Enabled = true;
                tbTimeBracket.Text = " ";
                cbTimeID.Enabled = false;
                bttnDeleteTime.Enabled = false;
                bttnUpdateTime.Enabled = false;

                //open the connection
                conn = new SqlConnection(connStr);
                conn.Open();  //open connection

                //Display warning
                lblMaxNumberValidation.Visible = true;

                //Populate Gridview with current theatres
                sql = "SELECT * FROM TIME_ALLOCATIONS";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");
                dgvDisplayTimeAllocvations.DataSource = ds;
                dgvDisplayTimeAllocvations.DataMember = "TIME_ALLOCATIONS";
                conn.Close();
                conn.Dispose();

            }
            catch(Exception error)
            {
                MessageBox.Show("Could not access updated Time table. " + error.Message);
            }
        }

        private void bttnAddTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tbTimeBracket.Text != " ")
                {
                    if (DateTime.TryParse(tbTimeBracket.Text, out time))
                    {
                        conn = new SqlConnection(connStr);
                        conn.Open();
                        sql = $"INSERT INTO TIME_ALLOCATIONS(Time) VALUES('{time}')";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        adapt.InsertCommand = comm;
                        adapt.InsertCommand.ExecuteNonQuery();
                        conn.Close();
                        comm.Dispose();

                        //Notify user
                        MessageBox.Show("Time added successfully");

                        reLoad();

                    }
                    else
                    {
                        MessageBox.Show("Time has to be in the format of the example");
                    }
                }
                else
                    MessageBox.Show("You have to specify the time in the provided textbox.");
            }
            catch (Exception wrong)
            {
                MessageBox.Show("Could not add to Time_Allocation table." + wrong.Message);
                this.Close();
            }
        }

        private void lblChangeTheatre_Click(object sender, EventArgs e)
        {
            gbTime_Allocation.Text = "Update Time Group";
            cbTimeID.Enabled = true;

            //Hide validation label
            lblMaxNumberValidation.Visible = false;

            try
            {
                //making all controls visible 
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = true;
                bttnUpdateTime.Visible = true;
                bttnDeleteTime.Visible = true;

                //enabling needed controls
                bttnAddTime.Enabled = false;
                tbTimeBracket.Enabled = true;
                tbTimeBracket.Text = " ";  //ensure to set the defalut text to nothing
                cbTimeID.Enabled = true;
                bttnDeleteTime.Enabled = false;
                bttnUpdateTime.Enabled = true;

                conn = new SqlConnection(connStr);
                conn.Open();

                sql = "SELECT Time_ID FROM TIME_ALLOCATIONS";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");


                //populating combobox with theatres Id available
                cbTimeID.DataSource = ds.Tables["TIME_ALLOCATIONS"];
                cbTimeID.DisplayMember = "Time_ID";
                cbTimeID.ValueMember = "Time_ID";
                conn.Close();
                conn.Dispose();
                reLoad();


            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bttnUpdateTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTimeID.SelectedIndex != -1)
                {
                    if (tbTimeBracket.Text != " " && DateTime.TryParse(tbTimeBracket.Text, out time))
                    {
                        conn = new SqlConnection(connStr);
                        conn.Open();
                        sql = $"UPDATE TIME_ALLOCATIONS SET Time = '{time}' WHERE Time_ID = {int.Parse(cbTimeID.SelectedValue.ToString())} ";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        adapt.UpdateCommand = comm;
                        adapt.UpdateCommand.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();

                        //update user
                        MessageBox.Show("Updated successfully");

                        reLoad();

                       
                    }
                    else
                        MessageBox.Show("Before you update a time group, you need to provide a new time group in the correct format!!");
                }
                else
                {
                    MessageBox.Show("Before you update a time group, you need to first select the time ID from the options provided!!");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bttnDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbTimeBracket.Enabled)
                {

                    if (cbTimeID.SelectedIndex != -1)
                    {
                        deleteID = int.Parse(cbTimeID.SelectedValue.ToString());
                        conn = new SqlConnection(connStr);
                        conn.Open();
                        sql = $"DELETE FROM TIME_ALLOCATIONS WHERE Time_ID = {int.Parse(cbTimeID.SelectedValue.ToString())} ";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        // comm.Parameters.AddWithValue("@id", deleteID);
                        adapt.DeleteCommand = comm;
                        adapt.DeleteCommand.ExecuteNonQuery();

                        //Update user
                        MessageBox.Show("Deleted successfully");

                        //re-populaate combobox
                        sql = "SELECT Time_ID FROM TIME_ALLOCATIONS";
                        adapt = new SqlDataAdapter();
                        ds = new DataSet();
                        comm = new SqlCommand(sql, conn);
                        adapt.SelectCommand = comm;
                        adapt.Fill(ds, "TIME_ALLOCATIONS");


                        //populating combobox with theatres Id available
                        cbTimeID.DataSource = ds.Tables["TIME_ALLOCATIONS"];
                        cbTimeID.DisplayMember = "Time_ID";
                        cbTimeID.ValueMember = "Time_ID";
                        conn.Close();
                        conn.Dispose();

                        //reload griview
                        reLoad();

                    }
                    else
                    {
                        MessageBox.Show("Before you delete a theatre, you need to first select a theatre ID from the options provided!! ");
                    }
                }
                else
                {
                    tbTimeBracket.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gbTime_Allocation_Enter(object sender, EventArgs e)
        {

        }

        private void lblDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                //hide validation lale
                lblMaxNumberValidation.Visible = false;

                gbTime_Allocation.Text = "Delete Time Group";
                //making all controls visible 
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = true;
                bttnUpdateTime.Visible = true;
                bttnDeleteTime.Visible = true;

                //enabling the combobox and disabling the textbox, add and update buttons
                cbTimeID.Enabled = true;
                bttnDeleteTime.Enabled = true;
                tbTimeBracket.Text = "Cannot input value!!";
                tbTimeBracket.Enabled = false;
                bttnAddTime.Enabled = false;
                bttnUpdateTime.Enabled = false;

                conn = new SqlConnection(connStr);
                conn.Open();
                sql = $"SELECT Time_ID  FROM TIME_ALLOCATIONS ";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");


                //populating combobox with theatres Id available
                cbTimeID.DataSource = ds.Tables["TIME_ALLOCATIONS"];
                cbTimeID.DisplayMember = "Time_ID";
                cbTimeID.ValueMember = "Time_ID";
                conn.Close();
                conn.Dispose();

                reLoad();  //populate gridview

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
