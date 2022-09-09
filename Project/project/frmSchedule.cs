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
    public partial class frmSchedule : Form
    {
        public String conStr = @"Data Source=DESKTOP-PJ8SEPG;Initial Catalog=Pukki_Cinema;Integrated Security=True";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        String sql;

        public frmSchedule()
        {
            InitializeComponent();
        }

        /*public void reLoad()
        {
            try
            {
                conn.Open();
                //Populate gridview with Users
                sql = "SELECT * FROM SCHEDULES ";
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "SCHEDULES");
                dgvSchedule.DataSource = ds;
                dgvSchedule.DataMember = "SCHEDULES";
               // conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong: " + err.Message);
            }
        }*/

        public void reset()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();


                ///////POPULATE COMBO BOX FOR FILMS////////
                sql = "SELECT Title FROM FILMS";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbxFilms.DisplayMember = "Title";
                cbxFilms.ValueMember = "Title";
                cbxFilms.DataSource = ds.Tables["FILMS"];

                ///////POPULATE COMBO BOX FOR THEATRES////////
                sql = "SELECT Theatre_ID FROM THEATRES";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "THEATRES");
                cbxTheatres.DisplayMember = "Theatre_ID";
                cbxTheatres.ValueMember = "Theatre_ID";
                cbxTheatres.DataSource = ds.Tables["THEATRES"];

                ///////POPULATE COMBO BOX FOR TIME_ALLOCATIONS////////
                sql = "SELECT Time FROM TIME_ALLOCATIONS";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "TIME_ALLOCATIONS");
                cbxTimes.DisplayMember = "Time";
                cbxTimes.ValueMember = "Time";
                cbxTimes.DataSource = ds.Tables["TIME_ALLOCATIONS"];
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                reset();
                MessageBox.Show("Connection Successfull");
                conn.Close();

                //Populate gridview with Schedule entries
                conn.Open();
                sql = "SELECT * FROM SCHEDULES ";
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "SCHEDULES");
                dgvSchedule.DataSource = ds;
                dgvSchedule.DataMember = "SCHEDULES";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string filmTitle = cbxFilms.Text;
                int theatre_ID = int.Parse(cbxTheatres.Text);
                string showTime = cbxTimes.Text;
                string showDate = dtpShowDate.Text;

                sql = $"SELECT Film_ID FROM FILMS WHERE Title = '{filmTitle}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                int film_ID = (int)com.ExecuteScalar(); //store result of chosen filmID
                adap.Fill(ds, "FILMS");
                MessageBox.Show("Film " + film_ID);

                sql = $"SELECT Time_ID FROM TIME_ALLOCATIONS WHERE Time = '{showTime}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                int time_ID = (int)com.ExecuteScalar(); //store result of chosen timeID
                adap.Fill(ds, "TIME_ALLOCATIONS");
                MessageBox.Show("Time " + time_ID);

                //validate schedule data
                int tFilm_ID;
                int tTheatre_ID;
                int tTime_ID;
                string tShow_Date;
                int cntShowDate = 0;
                int cntTime = 0;
                int cntTheatre = 0;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    tFilm_ID = int.Parse(row["Film_ID"].ToString());
                    tTheatre_ID = int.Parse(row["Theatre_ID"].ToString());
                    tTime_ID = int.Parse(row["Time_ID"].ToString());
                    tShow_Date = row["Film_Date"].ToString();

                    if(tTheatre_ID == theatre_ID)
                    {
                        cntTheatre++;
                    }
                    if(tTime_ID == time_ID)
                    {
                        cntTime++;
                    }
                    if(tShow_Date == showDate)
                    {
                        cntShowDate++;
                    }


                    if(tFilm_ID == film_ID && tTheatre_ID==theatre_ID && tTime_ID==time_ID && tShow_Date==showDate)
                    {
                        MessageBox.Show("This film is already scheduled for this time, theatre and date.");
                        reset();
                    }
                    else if(tTheatre_ID == theatre_ID && tTime_ID == time_ID && tShow_Date == showDate)
                    {
                        MessageBox.Show("Another film is already scheduled for this time, theatre and date.");
                        reset();
                    }
                    else if(tTime_ID == time_ID && tShow_Date==showDate && cntTheatre>3)
                    {
                        MessageBox.Show("All theatres have already been booked for this time and date.");
                        reset();
                    }
                    else if((tTheatre_ID==theatre_ID) && (cntTime>3) && (tShow_Date == showDate))
                    {
                        MessageBox.Show("All times have been booked for this theatre and date.");
                        reset();
                    }
                    else if(cntShowDate>9)
                    {
                        MessageBox.Show("No more bookings could be made for this day.");
                        reset();
                    }
                    else
                    {
                        sql = $"INSERT INTO SCHEDULES (Film_ID,Theatre_ID,Time_ID,Film_Date,Ticket_Counter) VALUES (@film_ID, @theatre_ID, @time_ID, @show_Date, @ticket_Cnt)";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@film_ID", film_ID);
                        command.Parameters.AddWithValue("@theatre_ID", theatre_ID);
                        command.Parameters.AddWithValue("@time_ID", time_ID);
                        command.Parameters.AddWithValue("@show_Date", DateTime.Parse(showDate));
                        command.Parameters.AddWithValue("@ticket_Cnt", "0");
                        command.ExecuteNonQuery();

                        //reLoad();
                        conn.Close();
                        MessageBox.Show(filmTitle + theatre_ID + showTime + showDate);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add schedule entry :" + ex);
            }

        }
    }
}
