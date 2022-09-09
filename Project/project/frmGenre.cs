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

namespace Genre
{
    public partial class frmGenre : Form
    {
        //Connect to database
        SqlCommand comm;
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet ds;
        String sql;

        String connStr = "Data Source=IPS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public frmGenre()
        {
            InitializeComponent();
        }

        private void lblAddGenre_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxDescription.Visible = false;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Add Genre";
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            catch 
            {
                MessageBox.Show("Error!");
            }
        }

        private void lblDeleteGenre_Click(object sender, EventArgs e)
        {
            try 
            {
                comboBoxDescription.Visible = true;
                txtbDescription.Visible = false;
                dtgDisplay.Visible = true;
                groupBox1.Text = "Delete Genre";
                btnDelete.Visible = true;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;

                con.Open();
                sql = $"SELECT Desecription FROM GENRES ";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.SelectCommand = comm;
                adapt.Fill(ds, "GENRES");


                //populating genre description combo box
                comboBoxDescription.DataSource = ds.Tables["GENRES"];
                comboBoxDescription.DisplayMember = "Description";
                comboBoxDescription.ValueMember = "Description";


            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void frmGenre_Load(object sender, EventArgs e)
        {
            
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            groupBox1.Text = " ";
            comboBoxDescription.Enabled = false;
            
        
            con = new SqlConnection(connStr);
            con.Open();  //open connection

            //Populate DataGridview 
            sql = "SELECT* FROM GENRES";
            adapt = new SqlDataAdapter();
            ds = new DataSet();
            comm = new SqlCommand(sql, con);
            adapt.SelectCommand = comm;
            adapt.Fill(ds, "GENRES");
            dtgDisplay.DataSource = ds;
            dtgDisplay.DataMember = "GENRES";

            con.Close(); //close connection

        }

        private void lblUpdateGenre_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Text = "Update Genre";
                dtgDisplay.Visible = true;
                txtbDescription.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
            }
            catch
            {
                MessageBox.Show("Error!");
            }
           


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(comboBoxDescription.SelectedIndex != -1)
                {
                con.Open();

                sql = $"DELETE * FROM GENRES WHERE Description = '{comboBoxDescription.SelectedItem}')";
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                comm = new SqlCommand(sql, con);
                adapt.DeleteCommand = comm;
                adapt.DeleteCommand.ExecuteNonQuery();
                comm.Dispose();
               

                con.Close();
            }
                else
            {
                MessageBox.Show("Choose a genre description! ");
            }
        }

    }
    }

