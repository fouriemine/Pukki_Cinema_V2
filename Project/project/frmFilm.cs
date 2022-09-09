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
    public partial class frmFilm : Form
    {

        public String conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        String sql;

        
        public frmFilm()
        {
            InitializeComponent();
            lbl_filmCost.Visible = false;
            lbl_filmID.Visible = false;
            lbl_length.Visible = false;
            lbl_status.Visible = false;
            lbl_sellingPrice.Visible = false;
            lbl_genre.Visible = false;
            lbl_ageRestriction.Visible = false;
            lbl_title.Visible = false;

            txt_ageRestiction.Visible = false;
            txt_filmCost.Visible = false;
            txt_length.Visible = false;
            txt_sellingPrice.Visible = false;
            pnl_Status.Visible = false;
            txt_title.Visible = false;

            cbx_filmID.Visible = false;
            cbx_genre.Visible = false;
            cbx_title.Visible = false;

            gbx_films.Visible = true;
            dgv_films.Visible = true;

            btn_add.Visible = false;
            btn_update.Visible = false;
            btn_delete.Visible = false;

            gbx_films.Text = "Films";

        }

        private void lbl_addFilm_Click(object sender, EventArgs e)
        {

            dispAll();
            lbl_filmID.Visible = false;
            cbx_filmID.Visible = false;
            cbx_title.Visible = false;

            btn_update.Visible = false;
            btn_delete.Visible = false;


            gbx_films.Text = "Add Film";

            comboBoxesload();


        }

        private void lbl_updateFilm_Click(object sender, EventArgs e)
        {
            dispAll();

            btn_add.Visible = false;
            btn_delete.Visible = false;

            gbx_films.Text = "Update Film";

            comboBoxesload();


        }

        private void lbl_deleteFilm_Click(object sender, EventArgs e)
        {
            dispAll();
                       
            btn_add.Visible = false;
            btn_update.Visible = false;
            gbx_films.Text = "Delete Film";

            comboBoxesload();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {

            reLoad(); 

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                String title = txt_title.Text;
                decimal filmCost = decimal.Parse(txt_filmCost.Text);
                decimal sellingPrice = decimal.Parse(txt_sellingPrice.Text);
                int length = int.Parse(txt_length.Text);
                int ageRestriction = int.Parse(txt_ageRestiction.Text);
                String genre_ID = cbx_genre.Text;
                
                

                if (rdo_Active.Checked || rdo_Inactive.Checked)
                {
                    bool temp = false;

                    if (rdo_Active.Checked)
                    {
                        temp = true;
                    }

                    conn.Open();
                    com = new SqlCommand("insert into FILMS(Title, Film_Cost, Selling_Price, Length, Age_Restriction, Genre_ID, Status) values(@title, @filmCost , @sellingprice, @length, @ageRestriction, @genre_Desc, @status)", conn);
                    com.Parameters.AddWithValue("@title", txt_title.Text);
                    com.Parameters.AddWithValue("@filmCost", txt_filmCost.Text);
                    com.Parameters.AddWithValue("@sellingprice", txt_sellingPrice.Text);
                    com.Parameters.AddWithValue("@length", txt_length.Text);
                    com.Parameters.AddWithValue("@ageRestriction", txt_ageRestiction.Text);
                    com.Parameters.AddWithValue("@genre_Desc", (cbx_genre.SelectedIndex + 1));
                    com.Parameters.AddWithValue("@status", temp);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Added the record successfully");
                    reLoad();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Invalid status");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                String title = cbx_title.GetItemText(cbx_title.SelectedItem);
                conn.Open();
                com = new SqlCommand("SELECT * FROM TABLES WHERE Title=@title", conn);
                com.Parameters.AddWithValue("@title", title);
                com.ExecuteNonQuery();
                MessageBox.Show("Added the record successfully");
                reLoad();
                ClearData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn = new SqlConnection(conStr);
                String title = cbx_title.GetItemText(cbx_title.SelectedItem);
                conn.Open();
                com = new SqlCommand("SELECT * FROM FILMS WHERE Titl= @title", conn);
                com.Parameters.AddWithValue("@title", title);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbx_filmID.ValueMember = "Film_ID";
                cbx_filmID.DisplayMember = "Film_ID";
                cbx_filmID.DataSource = ds.Tables["FILMS"];


                com = new SqlCommand("DELETE FROM FILMS WHERE Title=@title", conn);
                com.Parameters.AddWithValue("@title", title);
                com.ExecuteNonQuery();
                MessageBox.Show("Deleted the record successfully");
                reLoad();
                ClearData();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dispAll()
        {
            lbl_filmCost.Visible = true;
            lbl_filmID.Visible = true;
            lbl_length.Visible = true;
            lbl_status.Visible = true;
            lbl_sellingPrice.Visible = true;
            lbl_genre.Visible = true;
            lbl_ageRestriction.Visible = true;
            lbl_title.Visible = true;

            txt_ageRestiction.Visible = true;
            txt_filmCost.Visible = true;
            txt_length.Visible = true;
            txt_sellingPrice.Visible = true;
            pnl_Status.Visible = true;
            txt_title.Visible = true;

            cbx_filmID.Visible = true;
            cbx_genre.Visible = true;
            cbx_title.Visible = true;

            gbx_films.Visible = true;
            dgv_films.Visible = true;

            btn_add.Visible = true;
            btn_update.Visible = true;
            btn_delete.Visible = true;
        }

        public void comboBoxesload()
        {
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();


                ///////POPULATE COMBO BOXES
                sql = "SELECT Film_ID FROM FILMS";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbx_filmID.ValueMember = "Film_ID";
                cbx_filmID.DisplayMember = "Film_ID";
                cbx_filmID.DataSource = ds.Tables["FILMS"];

                sql = "SELECT Description FROM GENRES";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "GENRES");
                cbx_genre.ValueMember = "Description";
                cbx_genre.DisplayMember = "Description";
                cbx_genre.DataSource = ds.Tables["GENRES"];

                sql = "SELECT Title FROM FILMS";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILM_TITLES");
                cbx_title.ValueMember = "Title";
                cbx_title.DisplayMember = "Title";
                cbx_title.DataSource = ds.Tables["FILM_TITLES"];

                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearData()
        {
            txt_ageRestiction.Text = "";
            txt_filmCost.Text = "";
            txt_length.Text = "";
            txt_sellingPrice.Text = "";
            rdo_Active.Checked = false;
            rdo_Inactive.Checked = false;
            txt_title.Text = "";

            cbx_filmID.Text = "";
            cbx_genre.Text = "";
            cbx_title.Text = "";

        }

        public void reLoad()
        {
            gbx_films.Visible = true;
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                DataTable ds = new DataTable();
                //Populate gridview with Users
                sql = "SELECT F.Film_ID, F.Title, F.Film_Cost, F.Selling_Price, F.Length, F.Age_Restriction, G.Description, F.Status FROM FILMS F, GENRES G WHERE F.Genre_ID = G.Genre_ID";
                com = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter(com);
                adap.Fill(ds);

                dgv_films.DataSource = ds;

                SqlCommand CMD_new = new SqlCommand(sql, conn);
                CMD_new.ExecuteReader();

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
