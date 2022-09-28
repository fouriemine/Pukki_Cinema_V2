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
        String sql, addValue, prevAddValue;
        DateTime time;
        int deleteID;
        bool timeSpan = false;
        DateTime maxValue, prevMaxValue;

        String connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
                dgvDisplayTimeAllocations.DataSource = ds;
                dgvDisplayTimeAllocations.DataMember = "TIME_ALLOCATIONS";
                conn.Close();
                conn.Dispose();
                cbTimeID.SelectedIndex = -1;

            }
            catch
            {
                MessageBox.Show("Could update database with new request.");
            }
        }


        private void frmTheatres_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
            pictureBox2.Visible = false;
            try
            {
                //set all controls to invisible
                lblTimeID.Visible = false;
                cbTimeID.Visible = false;
                lblTimeBracket.Visible = false;
                tbTimeBracket.Visible = false;
                bttnAddTime.Visible = false;
                bttnUpdateTime.Visible = false;
                bttnDeleteTime.Visible = false;

                reLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblAddTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                
                errProvTime.SetError(cbTimeID, "");
                errProvTime.SetError(tbTimeBracket, "");

                gbTime_Allocation.Text = "Add Time Group";
                //make the necessary controls visible
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = true;
                bttnUpdateTime.Visible = false;
                bttnDeleteTime.Visible = false;


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

                //Populate Gridview with current theatres
                sql = "SELECT * FROM TIME_ALLOCATIONS";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, conn);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "TIME_ALLOCATIONS");
                dgvDisplayTimeAllocations.DataSource = ds;
                dgvDisplayTimeAllocations.DataMember = "TIME_ALLOCATIONS";
                conn.Close();
                conn.Dispose();

                lblMaxTheatreWarning.Visible = true;
                lblTimeID.Visible = false;
                cbTimeID.Visible = false;



            }
            catch(Exception error)
            {
                MessageBox.Show("Could not access updated Time table. " + error.Message);
            }
        }

        private void bttnAddTheatre_Click(object sender, EventArgs e)
        {
            errProvTime.SetError(tbTimeBracket, "");
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                sql = "SELECT MAX(Time_ID) FROM TIME_ALLOCATIONS";
                comm = new SqlCommand(sql, conn);
                int maxID = (int)comm.ExecuteScalar();     
                conn.Close();

                conn = new SqlConnection(connStr);
                conn.Open();
                DateTime maxValue;
               
                sql = $"SELECT Time FROM TIME_ALLOCATIONS WHERE Time_ID = {maxID}";
                comm = new SqlCommand(sql, conn);

                maxValue = DateTime.Parse(comm.ExecuteScalar().ToString());
                addValue = maxValue.ToString("HH:mm:ss");
                conn.Close();


                if (DateTime.Compare(DateTime.Parse(tbTimeBracket.Text), maxValue) > 0)
                {
                   // MessageBox.Show("Okay");
                    timeSpan = true;
                }
                else
                {
                    timeSpan = false;
                }

           

                if (tbTimeBracket.Text != " " && timeSpan)
                {
                    if (tbTimeBracket.Text != " ")
                    {
                        //DateTime.TryParse(tbTimeBracket.Text, out time

                        conn = new SqlConnection(connStr);
                        conn.Open();
                        sql = $"INSERT INTO TIME_ALLOCATIONS(Time) VALUES('{tbTimeBracket.Text}')";
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
                        errProvTime.SetError(tbTimeBracket, "Time has to be in the format of the example");

                    }
                }
                else
                    errProvTime.SetError(cbTimeID, "You have to specify the time in the provided textbox, and ensure that the time entered is numerically bigger than the latest time in the schedule.");
                   
            }
            catch (Exception wrong)
            {
                if (tbTimeBracket.Text == " ")
                {
                    errProvTime.SetError(tbTimeBracket, "You need to enter a value");
                    timeSpan = false;
                }
                else
                {
                    if ((dgvDisplayTimeAllocations.Rows.Count) - 1 == 3)
                        MessageBox.Show("The number of time slots has reached its maximum capacity");
                    else
                        MessageBox.Show("Could not add to Time Allocations table." + wrong.Message);
                    this.Close();
                }
            }
        }

        private void lblChangeTheatre_Click(object sender, EventArgs e)
        {
            gbTime_Allocation.Text = "Update Time Group";
            cbTimeID.Enabled = true;

            errProvTime.SetError(cbTimeID, "");
            errProvTime.SetError(tbTimeBracket, "");

            //Hide validation label

            try
            {
                //making all controls visible 
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = false;
                bttnUpdateTime.Visible = true;
                bttnDeleteTime.Visible = false;

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

                lblMaxTheatreWarning.Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bttnUpdateTheatre_Click(object sender, EventArgs e)
        {
            errProvTime.SetError(cbTimeID, "");
            errProvTime.SetError(tbTimeBracket, "");

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                sql = "SELECT * FROM TIME_ALLOCATIONS";
                comm = new SqlCommand(sql, conn);
                adapt = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                conn.Close(); 

                bool flag = true;
                
               // if (dt.Rows.Count == 3)
                    //errProvTime.SetError(tbTimeBracket, "You cannot add more time-slots. The Time Allocation table has reached its maximum.");
                int changing = int.Parse(cbTimeID.Text);
                DateTime changeTime = DateTime.Parse(tbTimeBracket.Text);

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    //if (i == 2)
                       // MessageBox.Show("You cannot have more than 3 Time allocations");
                        //errProvTime.SetError(tbTimeBracket, "You cannot add more time-slots. The Time Allocation table has reached its maximum.");
                    if (changing == int.Parse(dt.Rows[0][0].ToString()))
                    {
                        if (i < dt.Rows.Count-1)
                        {
                            if (changeTime > DateTime.Parse(((DateTime.Parse(dt.Rows[i+1][1].ToString())).ToString("HH:mm:ss"))))
                            {
                                errProvTime.SetError(tbTimeBracket, "Time is later than the next time slot");
                                flag = false;
                                break;
                            }
                        }
                    }
                    else if(changing == int.Parse(dt.Rows[dt.Rows.Count-1][0].ToString()))
                    {
                        if (changeTime < DateTime.Parse(((DateTime.Parse(dt.Rows[i][1].ToString())).ToString("HH:mm:ss"))))
                        {
                            errProvTime.SetError(tbTimeBracket, "Time is earlier than the previous time slot");
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        if (i < dt.Rows.Count - 1)
                        {
                            int counter = cbTimeID.SelectedIndex;
                            if (changeTime >= DateTime.Parse(((DateTime.Parse(dt.Rows[counter+1][1].ToString())).ToString("HH:mm:ss"))))
                            {
                                errProvTime.SetError(tbTimeBracket, "Time later than next time slot");
                                flag = false;
                                break;
                            }
                        }
                        else if (i > 0)
                        {
                            int counter = cbTimeID.SelectedIndex;
                            if (changeTime <= DateTime.Parse(((DateTime.Parse(dt.Rows[counter-1][1].ToString())).ToString("HH:mm:ss"))))
                            {
                                errProvTime.SetError(tbTimeBracket, "Time is earlier than previous time slot");
                                flag = false;
                                break;

                            }
                        }
                    }
                }
                
                
                if (flag)
                {
                    sql = "UPDATE TIME_ALLOCATIONS SET Time=@time WHERE Time_ID = @timeId";
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    comm = new SqlCommand(sql, conn);
                    comm.Parameters.AddWithValue("timeId", (int)cbTimeID.SelectedValue);
                    comm.Parameters.AddWithValue("time", DateTime.Parse((DateTime.Parse(tbTimeBracket.Text)).ToString("HH:mm:ss")));
                    if (MessageBox.Show("Are you sure you wish to update " + cbTimeID.SelectedValue.ToString() + "?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        comm.ExecuteNonQuery();
                        reLoad();
                        MessageBox.Show("Updated Successfully");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Could not update");
                }

            }
            catch (Exception error)
            {
                if (tbTimeBracket.Text == " ")
                {
                    errProvTime.SetError(tbTimeBracket, "You need to enter a value");
                    timeSpan = false;
                }
                else if(cbTimeID.SelectedIndex == -1)
                {
                    errProvTime.SetError(cbTimeID, "You need to select a time frame to update");
                    timeSpan = false;
                }
                else
                {
                    MessageBox.Show("Could not add to Time_Allocation table." + error.Message);
                    //this.Close();
                }
            }
        }

        private void bttnDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                errProvTime.SetError(cbTimeID, "");
                
                    if (!tbTimeBracket.Enabled)
                    {

                        if (cbTimeID.SelectedIndex != -1)
                        {
                            conn = new SqlConnection(connStr);
                            conn.Open();
                            string delete = cbTimeID.GetItemText(cbTimeID.SelectedItem);
                            sql = $"SELECT Time FROM TIME_ALLOCATIONS WHERE Time_ID = @deleteID";
                            comm = new SqlCommand(sql, conn);
                            comm.Parameters.AddWithValue("@deleteID", delete);
                            conn.Close();

                        DialogResult res = MessageBox.Show("Do you want to delete the time slot " + delete + "?", "Delete record", MessageBoxButtons.YesNo);

                        if (res == DialogResult.Yes)
                            {
                                deleteID = int.Parse(cbTimeID.SelectedValue.ToString());
                                conn = new SqlConnection(connStr);
                                conn.Open();

                                sql = $"DELETE FROM TIME_ALLOCATIONS WHERE Time_ID = {int.Parse(cbTimeID.SelectedValue.ToString())}";
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
                                return;
                            }
                    }
                        else
                        {
                            errProvTime.SetError(cbTimeID, "Before you delete a theatre, you need to first select a theatre ID from the options provided");
                            
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

        private void help_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = true;
            help_btn.Visible = false;
            pictureBox2.Visible = true;
        }

        private void closeHelp_btn_Click(object sender, EventArgs e)
        {
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
            pictureBox2.Visible = false;
        }

        private void lblDeleteTheatre_Click(object sender, EventArgs e)
        {
            try
            {
                errProvTime.SetError(cbTimeID, "");
                errProvTime.SetError(tbTimeBracket, "");

                gbTime_Allocation.Text = "Delete Time Group";

                //making all controls visible 
                lblTimeID.Visible = true;
                cbTimeID.Visible = true;
                lblTimeBracket.Visible = true;
                tbTimeBracket.Visible = true;
                bttnAddTime.Visible = false;
                bttnUpdateTime.Visible = false;
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
                lblMaxTheatreWarning.Visible = false;

                lblTimeBracket.Visible = false;
                tbTimeBracket.Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbTimeBracket_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnPrevFromTime_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
