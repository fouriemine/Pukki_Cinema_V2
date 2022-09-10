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
        String showDate;

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
                dtpShowDate.Format = DateTimePickerFormat.Short;
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
                showDate = dtpShowDate.Text;

                //GET FILM ID FROM COMBO BOX
                sql = $"SELECT Film_ID FROM FILMS WHERE Title = '{filmTitle}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                int film_ID = (int)com.ExecuteScalar(); //store result of chosen filmID
                adap.Fill(ds, "FILMS");
                MessageBox.Show("Film " + film_ID);

                //GET TIME ID FROM COMBO BOX
                sql = $"SELECT Time_ID FROM TIME_ALLOCATIONS WHERE Time = '{showTime}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                int time_ID = (int)com.ExecuteScalar(); //store result of chosen timeID
                adap.Fill(ds, "TIME_ALLOCATIONS");
                MessageBox.Show("Time " + time_ID);

                //CHECK IF THAT DAYS BOOKINGS ARE ALREADY FULL
                sql = $"SELECT COUNT(*) FROM SCHEDULES WHERE Film_Date = '{showDate}'";
                com = new SqlCommand(sql, conn);
                int countDaySchedule = (int)com.ExecuteScalar();
                MessageBox.Show("Counter for days bookings = " + countDaySchedule);
                if(countDaySchedule == 9)
                {
                    MessageBox.Show("This day's bookings are already full");
                }
                else //CHECK HOW MANY IDENTICAL ENTRIES THERE IS
                {                    
                    MessageBox.Show("Theatre " + theatre_ID);
                    MessageBox.Show("Date " + showDate);
                    sql = $"SELECT COUNT(*) FROM SCHEDULES WHERE Time_ID = '{time_ID}' AND Theatre_ID = '{theatre_ID}' AND Film_Date = '{showDate}'";
                    com = new SqlCommand(sql, conn);
                    int countDuplicates = (int)com.ExecuteScalar();
                    MessageBox.Show("Counter = " + countDuplicates);
                    if (countDuplicates > 0)//DUPLICATES EXIST
                    {
                        MessageBox.Show("There is already a film scheduled for this time, theatre and date.");
                    }
                    else //NO DUPLICATES-CHECK LENGTH OF MOVIE AGAINST TIME
                    {
                        cbxTimes.SelectedIndex = cbxTimes.SelectedIndex + 1;
                        if (cbxTimes.Text.ToString() == null)
                        {
                            sql = $"INSERT INTO SCHEDULES (Film_ID,Theatre_ID,Time_ID,Film_Date,Ticket_Counter) VALUES (@film_ID, @theatre_ID, @time_ID, @show_Date, @ticket_Cnt)";
                            SqlCommand command = new SqlCommand(sql, conn);
                            command.Parameters.AddWithValue("@film_ID", film_ID);
                            command.Parameters.AddWithValue("@theatre_ID", theatre_ID);
                            command.Parameters.AddWithValue("@time_ID", time_ID);
                            command.Parameters.AddWithValue("@show_Date", DateTime.Parse(showDate));
                            command.Parameters.AddWithValue("@ticket_Cnt", "0");
                            command.ExecuteNonQuery();
                            MessageBox.Show("Film has been scheduled successfully!");
                        }
                        else
                        {
                            string nextTime = cbxTimes.Text.ToString();
                            MessageBox.Show("this time: " + showTime);
                            MessageBox.Show("next time: " + nextTime);
                            DateTime time1 = DateTime.Parse(showTime);
                            DateTime time2 = DateTime.Parse(nextTime);

                            sql = $"SELECT Length FROM FILMS WHERE Film_ID = '{film_ID}' ";
                            com = new SqlCommand(sql, conn);
                            int length = (int)com.ExecuteScalar();
                            MessageBox.Show("length: " + length);
                            TimeSpan duration = new TimeSpan(0, 0, length, 0);
                            DateTime movieEnd = time1.Add(duration);
                            MessageBox.Show("movie end: " + movieEnd.ToString());
                            if (movieEnd >= time2)
                            {
                                MessageBox.Show("The duration of this movie is too long vir this timeslot, please try a different time slot or update times.");
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
                                MessageBox.Show("Film has been scheduled successfully!");
                            }
                        }
                        
                        /*
                        String time2 = null;
                        sql = $"SELECT top 1 Time FROM TIME_ALLOCATIONS WHERE Time_ID > '{time_ID}' ";
                        com = new SqlCommand(sql, conn);
                        time2 = (string)com.ExecuteScalar();
                        MessageBox.Show("time2 = " + time2.ToString());
                        DateTime time1 = DateTime.Parse(cbxTimes.Text);
                        MessageBox.Show(time1.ToString());
                        //TimeSpan duration = new TimeSpan(length,0,0,0);
                        //DateTime time1 = default(DateTime).Add(cbxTimes.Text.TimeOfDay)
                        */

                        /*sql = $"INSERT INTO SCHEDULES (Film_ID,Theatre_ID,Time_ID,Film_Date,Ticket_Counter) VALUES (@film_ID, @theatre_ID, @time_ID, @show_Date, @ticket_Cnt)";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@film_ID", film_ID);
                        command.Parameters.AddWithValue("@theatre_ID", theatre_ID);
                        command.Parameters.AddWithValue("@time_ID", time_ID);
                        command.Parameters.AddWithValue("@show_Date", DateTime.Parse(showDate));
                        command.Parameters.AddWithValue("@ticket_Cnt", "0");
                        command.ExecuteNonQuery();
                        */
                    }
                }
                
                conn.Close();

                /*sql = "SELECT * FROM SCHEDULE";
                using (conn)
                {
                    conn.Open();
                    //MessageBox.Show("TFilmID: 1");
                    SqlDataReader reader = com.ExecuteReader();
                   // MessageBox.Show("TFilmID: 2");
                    while (reader.Read())
                    {
                        tFilm_ID = int.Parse(reader[0].ToString());
                        MessageBox.Show("TFilmID: " + tFilm_ID);

                    }
                    reader.Close();
                }
                conn.Close();
                */

                /*DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    tFilm_ID = int.Parse(row["Film_ID"].ToString());
                    MessageBox.Show("tFilm is: " + tFilm_ID);
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
                }*/

            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add schedule entry :" + ex);
            }

        }

        private void cbxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpShowDate_ValueChanged(object sender, EventArgs e)
        {
            /*
            //validate schedule data
            int noOfShowingsPerDay = 9; //count number of showings per day = number of times * number of theatres
            int tFilm_ID;
            int tTheatre_ID;
            int tTime_ID;
            string tShow_Date;
           // int cntShowDate = 0;
            int cntTime = 0;
            int cntTheatre = 0;
            showDate = dtpShowDate.Text;

            conn.Open();
            sql = $"SELECT COUNT(*) FROM SCHEDULES WHERE Film_Date = '{showDate}'";
            com = new SqlCommand(sql, conn);
            adap.SelectCommand = com;
            int cntShowDate = Convert.ToInt32(com.ExecuteScalar()); //store counter result of chosen showDate
            adap.Fill(ds, "SCHEDULES");
            MessageBox.Show("show date chosen " + cntShowDate);
            if (cntShowDate < noOfShowingsPerDay)
            {
                //populate time combo box with available times
                sql = $"SELECT T.Time FROM SCHEDULES S, TIME_ALLOCATIONS T WHERE Film_Date = '{showDate}' && S.Time_ID != T.Time_ID";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "TIME_ALLOCATIONS");
                cbxTimes.DisplayMember = "Time";
                cbxTimes.ValueMember = "Time";
                cbxTimes.DataSource = ds.Tables["TIME_ALLOCATIONS"];
            }
            else
            {
                MessageBox.Show("This day's schedule is already fully booked.");
            }
            conn.Close();

            */
        }

        private void cbxTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
