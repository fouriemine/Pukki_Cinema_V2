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

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            try
            {
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
                conn.Close();

                //Populate gridview with Users
                sql = "SELECT * FROM USERS ";
                adap = new SqlDataAdapter();
                ds = new DataSet();
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "USERS");
                dgvSchedule.DataSource = ds;
                dgvSchedule.DataMember = "USERS";
                conn.Close();
            }
            catch
            {

            }
        }
    }
}
