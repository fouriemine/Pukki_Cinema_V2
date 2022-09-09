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
        //Connect to database
        SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter adapt;
        DataSet ds;
        String sql;

        String connStr = @"Data Source=BLESSINGSPC\SQLSERVER;Initial Catalog=Pukki_Cinema;Integrated Security=True";

        public frmTheatres()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTheatres_Load(object sender, EventArgs e)
        {
            try
            {

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
                lblTheatreID.Visible = true;
                cbTheatreID.Visible = true;
                lblAddTheatreCapacity.Visible = true;
                tbAddTheatreCapacity.Visible = true;
                bttnAddTheatre.Visible = true;
                bttnUpdateTheatre.Visible = true;
                bttnDeleteTheatre.Visible = true;
                

              //Disable combobox, change and delete buttons
              bttnAddTheatre.Enabled = true;
                tbAddTheatreCapacity.Enabled = true;
                tbAddTheatreCapacity.Text = " ";
                cbTheatreID.Enabled = false;
                bttnDeleteTheatre.Enabled = false;
                bttnUpdateTheatre.Enabled = false;

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
                MessageBox.Show("Could not access updated theatre table.");
            }
        }
    }
}
