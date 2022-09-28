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
        public String conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        String sql;
        String showDate;
        int film_ID = 0;
        int time_ID = 0;
        string timeDisplayed;
        string showDateDisplayed;
        
        public frmSchedule()
        {
            InitializeComponent();
        }

        public void clearAdd()
        {
            cbxFilms.SelectedIndex = -1;
            cbxTheatres.SelectedIndex = -1;
            cbxTimes.SelectedIndex = -1;
            dtpShowDate.Value = DateTime.Today;
        }

        public void clearDelete()
        {
            txtFilm.Clear();
            txtShowDate.Clear();
            txtTheatre.Clear();
            txtTime.Clear();
        }


        public void reLoadAdd()
        {
            try
            {                
                //POPULATE DATAGRIDVIEW
                conn = new SqlConnection(conStr);
                conn.Open();
                DataTable dt = new DataTable();
                sql = "SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                com = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter(com);
                adap.Fill(dt);
                dgvSchedule.DataSource = dt;

                string QueryAlert = $"SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                SqlCommand CMD = new SqlCommand(QueryAlert, conn);
                CMD.ExecuteReader();
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong: " + err.Message);
            }
        }

        public void reset()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();


                ///////POPULATE COMBO BOX FOR FILMS////////
                sql = "SELECT Title FROM FILMS WHERE Status = 1";
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
                conn.Close();
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
                WindowState = FormWindowState.Maximized;
                dtpShowDate.Format = DateTimePickerFormat.Short;
                
                gbxDeleteSchedule.Visible = false;
                gbxSchedule.Visible = false;
                pbHelp.Visible = false;
                btnCloseScheduleHelp.Visible = false;
                btnScheduleHelp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            

        }

        private void cbxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpShowDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDeleteSchedule_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        String title;
        int theatre;
        DateTime time;
       
        private void dgvDeleteSchedule_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gbxDeleteSchedule_VisibleChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {

        }

        private void lblAddSchedule_Click(object sender, EventArgs e)
        {
            gbxSchedule.Visible = true;
            gbxDeleteSchedule.Visible = false;
            clearAdd();
            pbHelp.Visible = false;
            btnCloseScheduleHelp.Visible = false;
            btnScheduleHelp.Visible = true;
        }

        private void lblDeleteSchedule_Click(object sender, EventArgs e)
        {
            gbxDeleteSchedule.Visible = true;
            gbxSchedule.Visible = false;
            clearDelete();
            pbHelp.Visible = false;
            btnCloseScheduleHelp.Visible = false;
            btnScheduleHelp.Visible = true;
        }
        
        private void btnDeleteSchedule_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (film_ID != 0 && theatre != 0 && time_ID != 0 && showDate != "")
                {
                    String message = "Delete " + title + " scheduled for " + showDateDisplayed + " at " + timeDisplayed + " in theatre " + theatre + "?";
                    String titleHead = "Delete schedule entry";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, titleHead, buttons);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        sql = $"SELECT Schedule_ID FROM SCHEDULES WHERE Film_ID = '{film_ID}' AND Theatre_ID = '{theatre}' AND Time_ID = '{time_ID}' AND Film_Date = '{showDate}'";
                        com = new SqlCommand(sql, conn);
                        adap.SelectCommand = com;
                        int scheduleID = (int)com.ExecuteScalar(); //store result of chosen scheduleID
                        adap.Fill(ds, "SCHEDULES");
                        conn.Close();

                        conn.Open();
                        sql = $"DELETE FROM SCHEDULES WHERE Schedule_ID = '{scheduleID}'";
                        com = new SqlCommand(sql, conn);
                        com.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Schedule with ID: " + scheduleID + " has been deleted successfully!");
                        clearDelete();
                        film_ID = 0;
                        theatre = 0;
                        time_ID = 0;
                        showDate = "";

                        //POPULATE DATAGRIDVIEW
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        DataTable dt = new DataTable();
                        sql = "SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                        com = new SqlCommand(sql, conn);
                        adap = new SqlDataAdapter(com);
                        adap.Fill(dt);
                        dgvDeleteSchedule.DataSource = dt;

                        string QueryAlert = $"SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                        SqlCommand CMD = new SqlCommand(QueryAlert, conn);
                        CMD.ExecuteReader();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ensure a row is selected.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid selection.");
            }
            
            

        }

        private void dgvDeleteSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get film id
            try
            {
                conn.Open();
                title = (string)(dgvDeleteSchedule.CurrentRow.Cells[1].Value.ToString());
                sql = $"SELECT Film_ID FROM FILMS WHERE Title = '{title}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                film_ID = (int)com.ExecuteScalar(); //store result of chosen filmID
                adap.Fill(ds, "FILMS");
                txtFilm.Text = title;


                //get theatre id
                theatre = (int)(dgvDeleteSchedule.CurrentRow.Cells[3].Value);
                txtTheatre.Text = theatre.ToString();

                //get time
                DateTime dtime = DateTime.Parse(dgvDeleteSchedule.CurrentRow.Cells[5].Value.ToString());
                sql = $"SELECT Time_ID FROM TIME_ALLOCATIONS WHERE Time = '{dtime}'";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                time_ID = (int)com.ExecuteScalar(); //store result of chosen timeID

                adap.Fill(ds, "TIME_ALLOCATIONS");
                DateTime? timeDisplay = dtime;
                timeDisplayed = timeDisplay?.ToString("HH:mm:ss");
                txtTime.Text = timeDisplayed;


                showDate = dgvDeleteSchedule.CurrentRow.Cells[4].Value.ToString();
                DateTime? showDateDisplay = DateTime.Parse(dgvDeleteSchedule.CurrentRow.Cells[4].Value.ToString());
                showDateDisplayed = showDateDisplay?.ToString("dd/MM/yyyy");
                txtShowDate.Text = showDateDisplayed;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
            
        }

        private void gbxDeleteSchedule_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnPreviousSchedule_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void gbxDeleteSchedule_VisibleChanged_1(object sender, EventArgs e)
        {
            try
            {
                //POPULATE DATAGRIDVIEW
                conn = new SqlConnection(conStr);
                conn.Open();
                DataTable dt = new DataTable();
                sql = "SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                com = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter(com);
                adap.Fill(dt);
                dgvDeleteSchedule.DataSource = dt;

                string QueryAlert = $"SELECT S.Schedule_ID, F.Title, G.Description, T.Theatre_ID, S.Film_Date, TM.Time FROM SCHEDULES S, FILMS F, GENRES G, THEATRES T, TIME_ALLOCATIONS TM WHERE F.Film_ID=S.Film_ID AND G.Genre_ID = F.Genre_ID AND T.Theatre_ID = S.Theatre_ID AND TM.Time_ID = S.Time_ID";
                SqlCommand CMD = new SqlCommand(QueryAlert, conn);
                CMD.ExecuteReader();
                conn.Close();

                txtFilm.Enabled = false;
                txtShowDate.Enabled = false;
                txtTheatre.Enabled = false;
                txtTime.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex);
            }
        }

        private void gbxSchedule_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void gbxSchedule_VisibleChanged_1(object sender, EventArgs e)
        {
            reLoadAdd();
            reset();
        }

        private void btnSchedule_Click_1(object sender, EventArgs e)
        {
            try
            {
                errProvScheduleAdd.SetError(cbxFilms, "");
                errProvScheduleAdd.SetError(cbxTheatres, "");
                errProvScheduleAdd.SetError(cbxTimes, "");
                if (cbxFilms.SelectedIndex == -1)
                {
                    errProvScheduleAdd.SetError(cbxFilms, "Ensure film is selected");
                }

                else
                {
                    if(cbxTheatres.SelectedIndex == -1)
                    {
                        errProvScheduleAdd.SetError(cbxTheatres, "Ensure theatre is selected");
                    }
                    else
                    {
                        if (cbxTimes.SelectedIndex == -1)
                        {
                            errProvScheduleAdd.SetError(cbxTimes, "Ensure time is selected");
                        }
                        else
                        {
                            conn.Open();
                            string filmTitle = cbxFilms.Text;
                            int theatre_ID = int.Parse(cbxTheatres.Text);
                            string showTime = cbxTimes.Text;
                            showDate = dtpShowDate.Text;
                            DateTime showDateSchedule = DateTime.Parse(showDate);
                            DateTime currentDate = DateTime.Now;

                            //GET FILM ID FROM COMBO BOX
                            sql = $"SELECT Film_ID FROM FILMS WHERE Title = '{filmTitle}'";
                            com = new SqlCommand(sql, conn);
                            adap.SelectCommand = com;
                            film_ID = (int)com.ExecuteScalar(); //store result of chosen filmID
                            adap.Fill(ds, "FILMS");

                            //GET TIME ID FROM COMBO BOX
                            sql = $"SELECT Time_ID FROM TIME_ALLOCATIONS WHERE Time = '{showTime}'";
                            com = new SqlCommand(sql, conn);
                            adap.SelectCommand = com;
                            time_ID = (int)com.ExecuteScalar(); //store result of chosen timeID
                            adap.Fill(ds, "TIME_ALLOCATIONS");

                            //CHECK IF THAT DAYS BOOKINGS ARE ALREADY FULL
                            sql = $"SELECT COUNT(*) FROM SCHEDULES WHERE Film_Date = '{showDate}'";
                            com = new SqlCommand(sql, conn);
                            int countDaySchedule = (int)com.ExecuteScalar();
                            conn.Close();

                            if (showDateSchedule < currentDate)
                            {
                                MessageBox.Show("The schedule deadline for this day has passed.");
                                reset();
                                clearAdd();
                            }
                            else
                            {
                                if (countDaySchedule == 9)
                                {
                                    MessageBox.Show("This day's bookings are already full");
                                    reset();
                                    clearAdd();
                                }
                                else //CHECK HOW MANY IDENTICAL ENTRIES THERE IS
                                {
                                    
                                    conn.Open();
                                    sql = $"SELECT COUNT(*) FROM SCHEDULES WHERE Time_ID = '{time_ID}' AND Theatre_ID = '{theatre_ID}' AND Film_Date = '{showDate}'";
                                    com = new SqlCommand(sql, conn);
                                    int countDuplicates = (int)com.ExecuteScalar();
                                    conn.Close();

                                    if (countDuplicates > 0)//DUPLICATES EXIST
                                    {
                                        MessageBox.Show("There is already a film scheduled for this time, theatre and date.");
                                        reset();
                                        clearAdd();
                                    }
                                    else //NO DUPLICATES-CHECK LENGTH OF MOVIE AGAINST TIME
                                    {
                                        cbxTimes.SelectedIndex = cbxTimes.SelectedIndex + 1;
                                        if (cbxTimes.Text.ToString() == "")
                                        {
                                            conn.Open();
                                            sql = $"INSERT INTO SCHEDULES (Film_ID,Theatre_ID,Time_ID,Film_Date,Ticket_Counter) VALUES (@film_ID, @theatre_ID, @time_ID, @show_Date, @ticket_Cnt)";
                                            SqlCommand command = new SqlCommand(sql, conn);
                                            command.Parameters.AddWithValue("@film_ID", film_ID);
                                            command.Parameters.AddWithValue("@theatre_ID", theatre_ID);
                                            command.Parameters.AddWithValue("@time_ID", time_ID);
                                            command.Parameters.AddWithValue("@show_Date", DateTime.Parse(showDate));
                                            command.Parameters.AddWithValue("@ticket_Cnt", "0");
                                            command.ExecuteNonQuery();
                                            conn.Close();
                                            MessageBox.Show("Film has been scheduled successfully");
                                            reLoadAdd();
                                            reset();
                                            clearAdd();
                                        }
                                        else
                                        {
                                            string nextTime = cbxTimes.Text.ToString();
                                            DateTime time1 = DateTime.Parse(showTime);
                                            DateTime time2 = DateTime.Parse(nextTime);

                                            conn.Open();
                                            sql = $"SELECT Length FROM FILMS WHERE Film_ID = '{film_ID}' ";
                                            com = new SqlCommand(sql, conn);
                                            int length = (int)com.ExecuteScalar();
                                            conn.Close();

                                            TimeSpan duration = new TimeSpan(0, 0, length, 0);
                                            DateTime movieEnd = time1.Add(duration);

                                            if (movieEnd >= time2)
                                            {
                                                MessageBox.Show("The duration of this movie is too long vir this timeslot, please try a different time slot or update times.");
                                                reset();
                                                clearAdd();
                                            }
                                            else
                                            {
                                                conn.Open();
                                                sql = $"INSERT INTO SCHEDULES (Film_ID,Theatre_ID,Time_ID,Film_Date,Ticket_Counter) VALUES (@film_ID, @theatre_ID, @time_ID, @show_Date, @ticket_Cnt)";
                                                SqlCommand command = new SqlCommand(sql, conn);
                                                command.Parameters.AddWithValue("@film_ID", film_ID);
                                                command.Parameters.AddWithValue("@theatre_ID", theatre_ID);
                                                command.Parameters.AddWithValue("@time_ID", time_ID);
                                                command.Parameters.AddWithValue("@show_Date", DateTime.Parse(showDate));
                                                command.Parameters.AddWithValue("@ticket_Cnt", "0");
                                                command.ExecuteNonQuery();
                                                conn.Close();
                                                MessageBox.Show("Film has been scheduled successfully!");
                                                reLoadAdd();
                                                reset();
                                                clearAdd();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add schedule entry :" + ex);
                errProvScheduleAdd.SetError(txtFilm, "");
            }
            conn.Close();
        }

        private void btnScheduleHelp_Click(object sender, EventArgs e)
        {
            pbHelp.Visible = true;
            btnScheduleHelp.Visible = false;
            btnCloseScheduleHelp.Visible = true;
        }

        private void btnCloseScheduleHelp_Click(object sender, EventArgs e)
        {
            pbHelp.Visible = false;
            btnCloseScheduleHelp.Visible = false;
            btnScheduleHelp.Visible = true;
        }

        private void btnClearAdd_Click(object sender, EventArgs e)
        {
            clearAdd();
        }

        private void btnClearDelete_Click(object sender, EventArgs e)
        {
            clearDelete();
        }
    }
}
