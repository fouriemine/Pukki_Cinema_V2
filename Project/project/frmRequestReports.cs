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
    public partial class frmRequestReports : Form
    {
        public frmRequestReports()
        {
            InitializeComponent();
        }


        //recurring variables
        private String conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection conn;
        private SqlCommand com;
        private SqlDataAdapter adap;
        private bool dependancy;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_ProcessReport_Clicked(object sender, EventArgs e)
        {
            try
            {
                //checking if dates are exactly the same or not
                if (dtp_Start.Value.Date != dtp_End.Value.Date)
                {
                    //checks if dates are in a valid order
                    if (CheckDates(dtp_Start.Value.Date, dtp_End.Value.Date))
                    {
                        //gets the data for a specific time period - NOT TOTAL TICKETS SOLD
                        lbl_TotTicketTitle.Text = "";
                        lbl_TotTickets.Text = "";
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        //gets the data from the table
                        com = new SqlCommand("SELECT Film_Date, Ticket_Counter FROM SCHEDULES WHERE Film_Date BETWEEN @startDate AND @endDate", conn);
                        com.Parameters.AddWithValue("@startDate", dtp_Start.Value.Date);
                        com.Parameters.AddWithValue("@endDate", dtp_End.Value.Date);

                        DataTable dt = new DataTable();
                        adap = new SqlDataAdapter(com);
                        adap.Fill(dt);

                        DataTable dtCloned = dt.Clone();
                        dtCloned.Columns[0].DataType = typeof(String);
                        int counter = 0;

                        foreach (DataRow row in dt.Rows)
                        {
                            if (counter < dt.Rows.Count)
                            {
                                dtCloned.ImportRow(row);
                                counter++;
                            }
                        }

                        dtCloned.Rows.Add("End of Report");

                        dgv_ReportView.DataSource = dtCloned;

                        conn.Close();

                        //displays the date this DATA was accessed
                        DateTime currDate = DateTime.Now;
                        lbl_DateAccessed.Text = "Date accessed: " + currDate.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The entered Start Date is after the entered End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The selected dates are exactly the same");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GetOther_Click(object sender, EventArgs e)
        {
            int totTickets = 0;
            int counter;
            try
            {
                //checks if dates are exaclty the same
                if (dtp_Start.Value.Date != dtp_End.Value.Date)
                {
                    //check if the correct part is active - EITHER TOP GENRES OR TICKETS SOLD PER TIME PERIOD
                    //IF IT IS TOTAL TICKETS SOLD
                    if (dependancy)
                    {
                        //check if dates are in correct order
                        if (CheckDates(dtp_Start.Value.Date.Date, dtp_End.Value.Date))
                        {
                            conn = new SqlConnection(conStr);
                            conn.Open();
                            //gets the required data from the tables
                            com = new SqlCommand("SELECT Film_Date, Ticket_Counter FROM SCHEDULES WHERE Film_Date BETWEEN @startDate AND @endDate", conn);
                            com.Parameters.AddWithValue("@startDate", dtp_Start.Value.Date);
                            com.Parameters.AddWithValue("@endDate", dtp_End.Value.Date);

                            DataTable dt = new DataTable();
                            adap = new SqlDataAdapter(com);
                            adap.Fill(dt);

                            //clones data table so that the first column can be of type String to display
                            //End of report at the very end

                            DataTable dtCloned = dt.Clone();
                            dtCloned.Columns[0].DataType = typeof(String);
                            counter = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                if (counter < dt.Rows.Count)
                                {
                                    dtCloned.ImportRow(row);
                                    counter++;
                                }
                            }

                            dtCloned.Rows.Add("End of Report");
                            dgv_ReportView.DataSource = dtCloned;

                            counter = 0;
                            foreach (DataGridViewRow row in dgv_ReportView.Rows)
                            {
                                if (counter < dgv_ReportView.RowCount - 2)
                                {
                                    totTickets += (int)dt.Rows[counter][1];
                                    counter++;
                                }
                            }

                            lbl_TotTicketTitle.Text = "Tickets sold from " + dtp_Start.Value.Date.ToString("dd/MM/yyyy") + " to " + dtp_End.Value.Date.ToString("dd/MM/yyyy");
                            lbl_TotTickets.Text = totTickets + " Tickets.";


                            conn.Close();

                            DateTime currDate = DateTime.Now;
                            lbl_DateAccessed.Text = "Date accessed: " + currDate.ToString();
                        }
                        else
                        {
                            MessageBox.Show("The entered Start Date is after the entered End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //If it is TOP 6 GENRES
                    else
                    {
                        DataTable dt = new DataTable();

                        conn = new SqlConnection(conStr);

                        com = new SqlCommand("SELECT TOP 6 G.Description, SUM(S.Ticket_Counter) AS Total_Tickets FROM FILMS F, SCHEDULES S, GENRES G WHERE F.Film_ID = S.Film_ID AND F.Genre_ID = G.Genre_ID AND S.Film_Date BETWEEN @start AND @end GROUP BY G.Description ORDER BY SUM(S.Ticket_Counter) DESC", conn);
                        com.Parameters.AddWithValue("@start", dtp_Start.Value.Date);
                        com.Parameters.AddWithValue("@end", dtp_End.Value.Date);
                        adap = new SqlDataAdapter(com);
                        adap.Fill(dt);

                        dt.Rows.Add("End of report");

                        dgv_ReportView.DataSource = dt;
                        DateTime currDate = DateTime.Now;
                        lbl_DateAccessed.Text = "Date accessed: " + currDate.ToString();
                        conn.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Error, dates are exactly the same");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lbl_totTicketsSold_Clicked(object sender, EventArgs e)
        {
            btn_GetOther.Text = "Get Total Tickets sold per Time Period";
            btn_ProcessReport.Text = "Process Report";
            dgv_ReportView.DataSource = null;
            btn_ProcessReport.Visible = true;
            ClearData();
            dependancy = true;
            gbx_Info.Text = "Tickets Sold";
        }

        public bool CheckDates(DateTime val1, DateTime val2)
        {
            //if the dates are in the correct order
            if (val1 > val2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ClearData()
        {
            gbx_Info.Visible = true;
            lbl_TotTicketTitle.Text = "";
            lbl_TotTickets.Text = "";
            lbl_DateAccessed.Text = "";
        }

        private void lblGenre_Report_Click(object sender, EventArgs e)
        {
            //displays necessary info when this label is clicked
            btn_ProcessReport.Visible = false;
            dgv_ReportView.DataSource = null;
            ClearData();
            btn_GetOther.Text = "Get top 6 Genres";
            dependancy = false;
            gbx_Info.Text = "Top 6 Genres";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gbx_Info.Visible = false;
        }

        private void btn_CloseHelp_Click(object sender, EventArgs e)
        {

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
