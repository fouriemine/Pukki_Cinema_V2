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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void grp_Info_Enter(object sender, EventArgs e)
        {

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
                if (CheckDates(dtp_Start.Value.Date, dtp_End.Value.Date))
                {
                    lbl_TotTicketTitle.Text = "";
                    lbl_TotTickets.Text = "";
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    com = new SqlCommand("SELECT Film_Date, Ticket_Counter FROM SCHEDULES WHERE Film_Date BETWEEN @startDate AND @endDate", conn);
                    com.Parameters.AddWithValue("@startDate", dtp_Start.Value.Date);
                    com.Parameters.AddWithValue("@endDate", dtp_End.Value.Date);

                    DataTable dt = new DataTable();
                    adap = new SqlDataAdapter(com);
                    adap.Fill(dt);

                    dgv_ReportView.DataSource = dt;

                    conn.Close();

                    DateTime currDate = DateTime.Now;
                    lbl_DateAccessed.Text = "Date accessed: " + currDate.ToString();
                }
                else
                {
                    MessageBox.Show("The entered Start Date is after the entered End Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int counter = 0;
            try
            {
                if (dependancy)
                {
                    if (CheckDates(dtp_Start.Value.Date.Date, dtp_End.Value.Date))
                    {
                        conn = new SqlConnection(conStr);
                        conn.Open();
                        com = new SqlCommand("SELECT Film_Date, Ticket_Counter FROM SCHEDULES WHERE Film_Date BETWEEN @startDate AND @endDate", conn);
                        com.Parameters.AddWithValue("@startDate", dtp_Start.Value.Date);
                        com.Parameters.AddWithValue("@endDate", dtp_End.Value.Date);

                        DataTable dt = new DataTable();
                        adap = new SqlDataAdapter(com);
                        adap.Fill(dt);

                        DataTable dtCloned = dt.Clone();
                        dtCloned.Columns[0].DataType = typeof(String);
                        counter = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            if (counter < dt.Rows.Count - 1)
                            {
                                dtCloned.ImportRow(row);
                                counter++;
                            }
                        }

                        dtCloned.Rows.Add("End of Report");
                        //dt.Rows.Add("End of report");
                        dgv_ReportView.DataSource = dtCloned;

                        counter = 0;
                        foreach (DataGridViewRow row in dgv_ReportView.Rows)
                        {
                            if (counter < dgv_ReportView.RowCount - 1)
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
            catch
            {
                MessageBox.Show("Input Error");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

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
            btn_ProcessReport.Visible = false;
            dgv_ReportView.DataSource = null;
            ClearData();
            btn_GetOther.Text = "Get top 6 Genres";
            dependancy = false;
            gbx_Info.Text = "Top 6 Genres";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            gbx_Info.Visible = false;
        }
    }
}
