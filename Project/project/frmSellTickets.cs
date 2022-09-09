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
        //public DataSet ds;
        public SqlDataAdapter adapter;
        public String sql;
        public String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True";
        public int tickets;
        public frmSellTickets()
        {
            InitializeComponent();
        }

        private String sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True";

        public void comboLoad()
        {
            try
            {
                connection = new SqlConnection(sqlCon);
                adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.Open();
                sql = "SELECT Schedule_ID FROM SCHEDULES";

                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;


                adapter.Fill(ds, "SCHEDULES");
                scheduleID_cbx.ValueMember = "Schedule_ID";
                scheduleID_cbx.DisplayMember = "Schedule_ID";
                scheduleID_cbx.DataSource = ds.Tables["SCHEDULES"];
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmSellTickets_Load_1(object sender, EventArgs e)
        {
            tickets = 0;
            try
            {
                connection = new SqlConnection(sqlCon);
                connection.Open();
                sellTicket_btn.Visible = false;
                //GetSellingData();
                selling_dgv.Enabled = false;
                
                
                GetSellingData();
                connection.Close();
                comboLoad();

                /*populate film combo box
                sql = "SELECT Schedule_ID FROM SCHEDULES";
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "SCHEDULES");
                scheduleID_cbx.DisplayMember = "Schedule_ID";
                scheduleID_cbx.ValueMember = "Schedule_ID";
                scheduleID_cbx.DataSource = ds.Tables["SCHEDULES"];

                /*
                 public String conStr = @"Data Source=DESKTOP-PJ8SEPG;Initial Catalog=Pukki_Cinema;Integrated Security=True";
                conn = new SqlConnection(conStr);
                conn.Open();
                sql = "SELECT Title FROM FILMS";
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbxFilms.DisplayMember = "Title";
                cbxFilms.ValueMember = "Title";
                cbxFilms.DataSource = ds.Tables["FILMS"];
                MessageBox.Show("Connection Successfull");
                conn.Close();*/

                /* //populate date combobox
                 sql = "SELECT Film_Date FROM SCHEDULES WHERE  ";
                 command = new SqlCommand(sql, connection);
                 adapter.SelectCommand = command;
                 adapter.Fill(ds, "SCHEDULES");
                 date_cbx.DisplayMember = "Film_Date";
                 date_cbx.ValueMember = "Film_Date";
                 date_cbx.DataSource = ds.Tables["SCHEDULES"];

                 //populate time combo box
                 sql = "SELECT Time FROM TIME_ALLOCATIONS";
                 command = new SqlCommand(sql, connection);
                 adapter.SelectCommand = command;
                 adapter.Fill(ds, "TIME_ALLOCATIONS");
                 time_cbx.DisplayMember = "Time";
                 time_cbx.ValueMember = "Time";
                 time_cbx.DataSource = ds.Tables["TIME_ALLOCATIONS"];*/


                MessageBox.Show("Connection Successfull");
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }

            sellTicket_btn.Visible = false;
        }

        public void ClearAll()
        {
            tickets = 0;
            sellTicket_btn.Visible = false;
            tickets_txt.Clear();
            scheduleID_cbx.DataSource = null;
            paymentMade_cbx.Checked = false;
        }

        public void CalcAmount()
        {
            try
            {
                connection = new SqlConnection(sqlCon);
                string capacityQuery = $"SELECT T.Capacity FROM T.THEATRES, S.SCHEDULES WHERE T.Theatre_ID=S.Theatre_ID AND S.Schedule_ID={scheduleID_cbx}";
                SqlCommand capacityCMD = new SqlCommand(capacityQuery, connection);
                int capacity = (int)capacityCMD.ExecuteScalar();

                connection = new SqlConnection(sqlCon);
                string currentCounterQuery = $"SELECT S.Ticket_Counter FROM SCHEDULES S WHERE S.Schedule_ID={scheduleID_cbx}";
                SqlCommand currentCounterCMD = new SqlCommand(currentCounterQuery, connection);
                int currentCounter = (int)currentCounterCMD.ExecuteScalar();

                connection = new SqlConnection(sqlCon);
                string calculationQuery = $"Select F.Selling_Price FROM Films F, SCHEDULES S WHERE S.Film_ID=F.Film_ID AND S.Schedule_ID = {scheduleID_cbx.Text}";
                SqlCommand calculationCMD = new SqlCommand(calculationQuery, connection);
                double sellingPrice = (double)calculationCMD.ExecuteScalar();

                tickets = int.Parse(tickets_txt.Text);

                if (tickets > (capacity - currentCounter))
                {
                    double amount = tickets * sellingPrice;
                    amount_lbl.Text = "Amount to be paid: " + amount.ToString("C");
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount of tickets");
                    tickets_txt.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //connection.Close();
        }

        private void tickets_txt_TextChanged(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void sellTicket_btn_Click(object sender, EventArgs e)
        {
               
            try
            {
                string sellingQuery = "Select Ticket_Counter FROM SCHEDULES WHERE Schedule_ID = @schedule";
                SqlCommand sellingCMD = new SqlCommand(sellingQuery, connection);
                sellingCMD.Parameters.AddWithValue("@schedule", scheduleID_cbx.Text);
                int currentCounter = (int)sellingCMD.ExecuteScalar();
                int updatedCounter = currentCounter + tickets;
                string QUERY = $"Update SCHEDULES SET Ticket_Counter ={updatedCounter} WHERE Schedule_ID = {scheduleID_cbx.Text}";
                SqlCommand CMD = new SqlCommand(QUERY, connection);
                CMD.ExecuteNonQuery();

                GetSellingData();
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount of tickets");
                tickets_txt.Focus();
            }

            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void GetSellingData()
        {
            try
            {

                DataTable dt = new DataTable();
                command = new SqlCommand("SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time, F.Length, S.Ticket_Counter  FROM FILMS F, SCHEDULES S, THEATRES T, GENRES G, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID=F.Genre_ID AND T.Theatre_ID=S.Theatre_ID AND TM.Time_ID=S.Time_ID AND F.Status=1", connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                selling_dgv.DataSource = dt;

                string QueryAlert = $"SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time, F.Length, S.Ticket_Counter FROM FILMS F, SCHEDULES S, THEATRES T, GENRES G, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID=F.Genre_ID AND T.Theatre_ID=S.Theatre_ID AND TM.Time_ID=S.Time_ID AND F.Status=1";
                SqlCommand CMD = new SqlCommand(QueryAlert, connection);
                CMD.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void paymentMade_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if( paymentMade_cbx.Checked)
            {
                tickets_txt.Enabled = false;
                scheduleID_cbx.Enabled = false;
                sellTicket_btn.Visible = true; 
            }
        }

    }
}

/*command = new SqlCommand("SELECT Discription FROM GENRES", connection);
           adapter = new SqlDataAdapter(command);
           adapter.Fill(dt1);
           SCHEDULES.Theatre_ID, SCHEDULES.Film_Date, FILMS.Length, SCHEDULES.Ticket_Counter, FILMS.Selling_Price FROM SCHEDULES,FILMS
           */

//adapter = new SqlDataAdapter("SELECT Discription FROM GENRES", connection);
//adapter.Fill(dt1);

//ds.Tables.Add(dt);
//ds.Tables.Add(dt1);





/* command = new SqlCommand("SELECT * from SCHEDULE", connection);
 adapter = new SqlDataAdapter(command);
 DataTable dt = new DataTable();
 adapter.Fill(dt);
 selling_dgv.DataSource = dt;
 SELECT name, commission FROM salesman;

 Table users:
 user_id(pk, ai)
 email
 password
 last_login

 Table data:
 user_id(fk to users.user_id)
 data_1
 data_2

 SELECT users.email, users.password, data.data_1, data.data_2
 FROM users,data
 WHERE users.email = '$user_email' AND users.user_id = data.user_id";*/


