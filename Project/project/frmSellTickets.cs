using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace project
{
    public partial class frmSellTickets : Form
    {
        public SqlCommand command;
        public SqlConnection connection;
        public SqlDataAdapter adapter;
        public String sql;
        public String connectionString = @"Data Source=BLESSINGSPC\SQLSERVER;Initial Catalog=Pukki_Cinema;Integrated Security=True";
        public int tickets;
        public int schedule_ID;
        public frmSellTickets()
        {
            InitializeComponent();
        }

        private String sqlCon = @"Data Source=BLESSINGSPC\SQLSERVER;Initial Catalog=Pukki_Cinema;Integrated Security=True";

        private void frmSellTickets_Load(object sender, EventArgs e) //initializing variable and controls
        {
            tickets = 0;
            schedule_ID = 0;
            try
            {
                connection = new SqlConnection(sqlCon);
                connection.Open();
                sellTicket_btn.Visible = false;
                help_picbox.Visible = false;
                closeHelp_btn.Visible = false;
                paymentMade_cbx.Visible = false;
                amount_lbl.Text = "Amount to be paid: R0.00";
                GetSellingData();
                comboLoad();
                tickets_txt.Text = "";
                scheduleID_cbx.Text = "";
                connection.Close();
                MessageBox.Show("Connection Successfull");
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }

            sellTicket_btn.Visible = false;
        }

        public void comboLoad() //load combo box to display valid schedule id's
        {
            try
            {
                connection = new SqlConnection(sqlCon);
                adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.Open();
                sql = "SELECT S.Schedule_ID FROM SCHEDULES S, FILMS F WHERE F.Film_ID=S.Film_ID AND F.Status=1";

                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;

                adapter.Fill(ds, "SCHEDULES");
                scheduleID_cbx.ValueMember = "Schedule_ID";
                scheduleID_cbx.DisplayMember = "Schedule_ID";
                scheduleID_cbx.DataSource = ds.Tables["SCHEDULES"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearAll() //method to clear all input and reset variables
        {
            sellTicket_btn.Visible = false;
            tickets_txt.Text = "";
            scheduleID_cbx.Text = "";
            paymentMade_cbx.Checked = false;
            tickets_txt.Enabled = true;
            scheduleID_cbx.Enabled = true;
            paymentMade_cbx.Visible = false;
            amount_lbl.Text = "Amount to be paid: R0.00";
            tickets = 0;
            schedule_ID = 0;
        }

        public void CalcAmount()
        {
            try
            {
                schedule_ID = int.Parse(scheduleID_cbx.Text); //assigning variable to schedule id combo box
            }
            catch
            {
                MessageBox.Show("Please select a Schedule.");
                scheduleID_cbx.Focus();
            }

            if (scheduleID_cbx.Text != "" && tickets_txt.Text != "0")//tesing user input
            {
                try
                {
                    //selecting theatre capacity from selceted schedule and assinging it to a variable
                    connection.Open();
                    SqlCommand capacityCMD = new SqlCommand($"SELECT T.Capacity FROM THEATRES T, SCHEDULES S WHERE T.Theatre_ID=S.Theatre_ID AND S.Schedule_ID='{schedule_ID}'", connection);
                    int capacity = (int)capacityCMD.ExecuteScalar();
                    connection.Close();

                    //selecting current counter from selceted schedule and assigning it to a variable
                    connection.Open();
                    SqlCommand currentCounterCMD = new SqlCommand($"SELECT S.Ticket_Counter FROM SCHEDULES S WHERE S.Schedule_ID='{schedule_ID}'", connection);
                    int currentCounter = (int)currentCounterCMD.ExecuteScalar();
                    connection.Close();

                    //selecting selling price from selceted schedule and assigning it to a variable 
                    connection.Open();
                    SqlCommand calculationCMD = new SqlCommand($"Select F.Selling_Price FROM Films F, SCHEDULES S WHERE S.Film_ID=F.Film_ID AND S.Schedule_ID = '{schedule_ID}'", connection);
                    decimal sellingPrice = (decimal)calculationCMD.ExecuteScalar();
                    connection.Close();

                    if (tickets <= (capacity - currentCounter))//testing if tickets to be sold does not exceed availible tickets for the theatre and dislaying the price of the tickets if valid
                    {
                        paymentMade_cbx.Visible = true;
                        decimal amount = tickets * sellingPrice;
                        amount_lbl.Text = "Amount to be paid: " + amount.ToString("C");

                    }
                    else //displaying a message box when number tickets to be sold is greater availible tickets
                    {
                        DialogResult result = MessageBox.Show("There are not enough availible tickets", "Caution", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            tickets_txt.Text = "";
                            tickets_txt.Focus();
                            amount_lbl.Text = "Amount to be paid: R0.00";
                            paymentMade_cbx.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                amount_lbl.Text = "Amount to be paid: R0.00";
                paymentMade_cbx.Visible = false;
            }
        }

        private void tickets_txt_TextChanged(object sender, EventArgs e)
        {
            //testing if a number is entered 
            if (tickets_txt.Text == "")
            {
                paymentMade_cbx.Visible = false;
            }
            else if (tickets_txt.Text != "0")
            {
                try
                {
                    //assigning the tickets to a variable and calling CalcAmount method
                    tickets = int.Parse(tickets_txt.Text);
                    CalcAmount();

                }
                catch
                {
                    DialogResult result = MessageBox.Show("Please enter a valid number of tickets", "Caution", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        tickets_txt.Text = "";
                        tickets_txt.Focus();
                        amount_lbl.Text = "Amount to be paid: R0.00";
                        paymentMade_cbx.Visible = false;
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Please enter a valid number of tickets", "Caution", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    tickets_txt.Text = "";
                    tickets_txt.Focus();
                    amount_lbl.Text = "Amount to be paid: R0.00";
                    paymentMade_cbx.Visible = false;
                }
            }
        }

        private void sellTicket_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //udating the data base with the new ticket counter and resetting all values and controls
                connection.Open();
                string sellingQuery = $"Select S.Ticket_Counter FROM SCHEDULES S WHERE S.Schedule_ID = {schedule_ID}";
                SqlCommand sellingCMD = new SqlCommand(sellingQuery, connection);
                sellingCMD.Parameters.AddWithValue("@Schedule_ID", schedule_ID);
                int currentCounter = (int)sellingCMD.ExecuteScalar();
                int updatedCounter = currentCounter + tickets;
                string QUERY = $"Update SCHEDULES SET Ticket_Counter = {updatedCounter} WHERE Schedule_ID = {schedule_ID}";
                SqlCommand CMD = new SqlCommand(QUERY, connection);
                CMD.ExecuteNonQuery();
                MessageBox.Show("Sale Information:\n" + tickets + " tickets sold for Schedule ID " + schedule_ID);
                connection.Close();
                connection.Open();
                ClearAll();
                GetSellingData();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount of tickets");
                tickets_txt.Focus();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            //calling ClearAll method and resetting all variables and controls
            paymentMade_cbx.Enabled = true;
            ClearAll();
        }

        private void GetSellingData()
        {
            //creating a data table containing selling information and displaying it in a data grid view
            try
            {
                DataTable dt = new DataTable();
                command = new SqlCommand("SELECT S.Schedule_ID, F.Title, G.Description, F.Age_Restriction, T.Theatre_ID, FORMAT(F.Selling_Price, 'N2') AS Selling_Price, S.Film_Date, TM.Time, F.Length, S.Ticket_Counter  FROM FILMS F, SCHEDULES S, THEATRES T, GENRES G, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID=F.Genre_ID AND T.Theatre_ID=S.Theatre_ID AND TM.Time_ID=S.Time_ID AND F.Status=1", connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                selling_dgv.DataSource = dt;

                string QueryAlert = $"SELECT S.Schedule_ID, F.Title, G.Description, F.Age_Restriction, T.Theatre_ID, FORMAT(F.Selling_Price,'N2') AS Selling_Price, S.Film_Date, TM.Time, F.Length, S.Ticket_Counter FROM FILMS F, SCHEDULES S, THEATRES T, GENRES G, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID=F.Genre_ID AND T.Theatre_ID=S.Theatre_ID AND TM.Time_ID=S.Time_ID AND F.Status=1";
                SqlCommand CMD = new SqlCommand(QueryAlert, connection);
                CMD.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paymentMade_cbx_CheckedChanged(object sender, EventArgs e)
        {
            //testing user input to allow the sale to go through
            if (tickets_txt.Text != "" && tickets_txt.Text != "0")
            {
                paymentMade_cbx.Checked = true;
                tickets_txt.Enabled = false;
                scheduleID_cbx.Enabled = false;
                sellTicket_btn.Visible = true;
                paymentMade_cbx.Enabled = false;
            }
            else
            {
                paymentMade_cbx.Checked = false;
                tickets_txt.Enabled = true;
                scheduleID_cbx.Enabled = true;
                sellTicket_btn.Visible = false;
            }
        }

        //adding help functionality to display helpfull information to the user on how to use this form
        private void help_btn_Click(object sender, EventArgs e)
        {
            help_picbox.Visible = true;
            help_btn.Visible = false;
            closeHelp_btn.Visible = true;
        }

        private void closeHelp_btn_Click(object sender, EventArgs e)
        {
            help_picbox.Visible = false;
            closeHelp_btn.Visible = false;
            help_btn.Visible = true;
        }


    }
}