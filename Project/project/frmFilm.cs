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
        //Creating my sql connection string, sql command, connection, dataset and adapter
        public String conStr = @"Data Source=LAPTOP-H4VOFVUF\MSSQLSERVER1;Initial Catalog=Pukki_Cinema;Integrated Security=True";
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;
        String sql;
        int genreID;



        public frmFilm()
        {

            //Initializing the from on startup
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
            txt_film_ID.Visible = false;

            lv_filmID.Visible = false;
            lv_genre.Visible = false;
            lv_title.Visible = false;

            gbx_films.Visible = true;
            dgv_films.Visible = true;

            btn_add.Visible = false;
            btn_update.Visible = false;
            btn_delete.Visible = false;

            gbx_films.Text = "Films";

            cbx_title.Visible = false;
            cbx_genre.Visible = false;
            cbx_filmID.Visible = false;

            pcb_help.Visible = false;

        }

        private void lbl_addFilm_Click(object sender, EventArgs e)
        {

            //showing all controls that need to visisible and enabled when add film lable is clicked
            ClearData();
            dispAll();
            enable();
            lbl_filmID.Visible = false;
            lv_filmID.Visible = false;
            lv_title.Visible = false;
            txt_film_ID.Visible = false;

            cbx_title.Visible = false;
            cbx_filmID.Visible = false;


            btn_update.Visible = false;
            btn_delete.Visible = false;


            gbx_films.Text = "Add Film";

            //Loading combo boxes
            comboBoxesload();
            ClearData();


        }

        private void lbl_updateFilm_Click(object sender, EventArgs e)
        {

            //showing all controls that need to visisible and enabled when update film lable is clicked
            ClearData();
            dispAll();
            enable();

            btn_add.Visible = false;
            btn_delete.Visible = false;
            cbx_filmID.Visible = false;

            txt_film_ID.Visible = true;
            txt_film_ID.Enabled = false;

            cbx_filmID.Visible = false;
            lv_filmID.Visible = true;

            gbx_films.Text = "Update Film";

            //loading combo boxes
            comboBoxesload();
            ClearData();


        }

        private void lbl_deleteFilm_Click(object sender, EventArgs e)
        {

            //showing all controls that need to visisible and enabled when delete film lable is clicked
            dispAll();
            disable();
            comboBoxesload();

            cbx_filmID.Visible = false;
            btn_add.Visible = false;
            btn_update.Visible = false;
            txt_film_ID.Visible = true;
            gbx_films.Text = "Delete Film";


            //Loading combo boxes
            comboBoxesload();
            ClearData();
        }

        private void frmFilm_Load(object sender, EventArgs e)
        {
            //Loading form
            reLoad();
            ClearData();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //when add button is clicked use the add mthod to add to database
            addFilm();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //when update button is clicked use update film method to update database
            updateFilm();
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //when delete btn is clicked use delete film method to delete from database
            deleteFilm();
            comboBoxesload();
            ClearData();
        }

        public void dispAll()
        {
            //Creating a method to display all controls needed
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
            txt_film_ID.Visible = true;

            lv_filmID.Visible = false;
            lv_genre.Visible = false;
            lv_title.Visible = false;

            gbx_films.Visible = true;
            dgv_films.Visible = true;

            btn_add.Visible = true;
            btn_update.Visible = true;
            btn_delete.Visible = true;

            cbx_filmID.Visible = true;
            cbx_genre.Visible = true;
            cbx_title.Visible = true;


        }

        public void comboBoxesload()
        {

            //Creating method to populate combo boxes
            try
            {
                ClearData();
                conn = new SqlConnection(conStr);
                conn.Open();

                adap = new SqlDataAdapter();
                ds = new DataSet();


                ///////POPULATE COMBO BOXES
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



                sql = "SELECT Film_ID FROM FILMS";
                com = new SqlCommand(sql, conn);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbx_filmID.ValueMember = "Film_ID";
                cbx_filmID.DisplayMember = "Film_ID";
                cbx_filmID.DataSource = ds.Tables["FILMS"];

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Creating clear method for controls
        public void ClearData()
        {
            txt_ageRestiction.Text = "";
            txt_filmCost.Text = "";
            txt_length.Text = "";
            txt_sellingPrice.Text = "";
            rdo_Active.Checked = false;
            rdo_Inactive.Checked = false;
            txt_title.Text = "";
            txt_film_ID.Text = "";

            cbx_title.Text = "";
            cbx_genre.Text = "";
            cbx_filmID.Text = "";
            cbx_genre.SelectedIndex = -1;
            cbx_title.SelectedIndex = -1;

        }
        //Craeting method to load gridbox
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

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //Creating method to add a film
        public void addFilm()
        {
            try
            {
                //iff statements for vailidation
                if ((txt_title.Text.Length <= 100) && (txt_title.Text.Length > 0))
                {
                    String title = txt_title.Text;
                    decimal filmCost;
                    decimal sellingPrice;
                    int length;
                    int ageRestriction;
                    String genre_ID = cbx_genre.Text;
                    if (decimal.TryParse(txt_filmCost.Text, out filmCost) && (filmCost > 0))
                    {
                        if (decimal.TryParse(txt_sellingPrice.Text, out sellingPrice) && (sellingPrice > 0))
                        {
                            if (int.TryParse(txt_length.Text, out length) && (length > 0))
                            {
                                if (int.TryParse(txt_ageRestiction.Text, out ageRestriction) && (ageRestriction >= 0))
                                {
                                    if (cbx_genre.SelectedIndex!=-1)
                                    {

                                        if (rdo_Active.Checked || rdo_Inactive.Checked)
                                        {
                                            bool temp = false;

                                            if (rdo_Active.Checked)
                                            {
                                                temp = true;
                                            }

                                            //Sql query for adding
                                            conn.Open();
                                            com = new SqlCommand("insert into FILMS(Title, Film_Cost, Selling_Price, Length, Age_Restriction, Genre_ID, Status) values(@title, @filmCost , @sellingprice, @length, @ageRestriction, @genre_Desc, @status)", conn);
                                            com.Parameters.AddWithValue("@title", txt_title.Text);
                                            com.Parameters.AddWithValue("@filmCost", txt_filmCost.Text);
                                            com.Parameters.AddWithValue("@sellingprice", txt_sellingPrice.Text);
                                            com.Parameters.AddWithValue("@length", txt_length.Text);
                                            com.Parameters.AddWithValue("@ageRestriction", txt_ageRestiction.Text);
                                            com.Parameters.AddWithValue("@genre_Desc", (cbx_genre.SelectedIndex + 1));
                                            com.Parameters.AddWithValue("@status", temp);

                                            DialogResult res = MessageBox.Show("Are you sure you want to add movie: " + txt_title.Text + "?", "Caution", MessageBoxButtons.YesNo);
                                            if (res == DialogResult.Yes)
                                            {
                                                com.ExecuteNonQuery();
                                                MessageBox.Show("Added the record successfully");
                                            }

                                            reLoad();
                                            comboBoxesload();
                                            ClearData();

                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid status. Make sure you have selected a status.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Genre must be selected.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Age Restriction must have an input and make sure it is a valid number.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Length must have an input and make sure it is a valid number.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selling Price must have an input and make sure it is a valid number.");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Film cost must have an input and make sure it is a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Title must have an input and must be less than 100 characters.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    

        public void updateFilm()
        {
            try
            {
                //If else statemnts for validation
                if ((cbx_title.Text.Length <= 100) && (cbx_title.Text.Length > 0))
                {
                    String title = cbx_title.Text;

                    conn = new SqlConnection(conStr);
                    conn.Open();
                    com = new SqlCommand();

                    decimal filmCost;
                    decimal sellingPrice;
                    int length;
                    int ageRestriction;
                    String genre_ID = cbx_genre.Text;
                    if (decimal.TryParse(txt_filmCost.Text, out filmCost)&&(filmCost>0))
                    {
                        if (decimal.TryParse(txt_sellingPrice.Text, out sellingPrice)&&(sellingPrice>0))
                        {
                            if (int.TryParse(txt_length.Text, out length)&&(length>0))
                            {
                                if (int.TryParse(txt_ageRestiction.Text, out ageRestriction)&&(ageRestriction>=0))
                                {
                                    if (cbx_genre.SelectedIndex != -1)
                                    {
                                        
                                        if (rdo_Active.Checked || rdo_Inactive.Checked)
                                        {
                                            bool temp = false;

                                            if (rdo_Active.Checked)
                                            {
                                                temp = true;
                                            }

                                            //sql queries for updating
                                            conn = new SqlConnection(conStr);
                                            conn.Open();

                                            com = new SqlCommand("SELECT Title FROM FILMS WHERE Film_ID = @filmID", conn);
                                            com.Parameters.AddWithValue("@filmID", txt_film_ID.Text);
                                            title = (String)com.ExecuteScalar();

                                            com = new SqlCommand("UPDATE FILMS set Title = @title, Film_Cost = @filmCost, Selling_Price = @sellingPrice, Length = @length, Age_Restriction = @ageRestriction, Status = @status where Film_ID=@checkID;", conn);
                                            com.Parameters.AddWithValue("@title", cbx_title.Text);
                                            com.Parameters.AddWithValue("@filmCost", decimal.Parse(txt_filmCost.Text));
                                            com.Parameters.AddWithValue("@sellingprice", decimal.Parse(txt_sellingPrice.Text));
                                            com.Parameters.AddWithValue("@length", int.Parse(txt_length.Text));
                                            com.Parameters.AddWithValue("@ageRestriction", int.Parse(txt_ageRestiction.Text));
                                            com.Parameters.AddWithValue("@status", temp);
                                            com.Parameters.AddWithValue("@checkID", txt_film_ID.Text);

                                            DialogResult res = MessageBox.Show("Are you sure you want to update " + title + "?", "Caution", MessageBoxButtons.YesNo);
                                            if (res == DialogResult.Yes)
                                            {
                                                com.ExecuteNonQuery();
                                                com = new SqlCommand("SELECT Genre_ID FROM GENRES WHERE Description = @desc", conn);
                                                com.Parameters.AddWithValue("@desc", cbx_genre.SelectedValue);
                                                genreID = (int)com.ExecuteScalar();
                                                com = new SqlCommand("UPDATE FILMS SET Genre_ID = @genreID WHERE Title = @title", conn);
                                                com.Parameters.AddWithValue("@genreID", genreID);
                                                com.Parameters.AddWithValue("@title", cbx_title.Text);

                                                com.ExecuteNonQuery();
                                                MessageBox.Show("Updated the record successfully");
                                            }

                                            reLoad();
                                            comboBoxesload();
                                            ClearData();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid status. Make sure you have selected a status");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Genre must be selected.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Age Restriction must have an input and make sure it is a valid number.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Length must have an input and make sure it is a valid number.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selling Price must have an input and make sure it is a valid number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Film cost must have an input and make sure it is a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Title must have an input and must be less than 100 characters.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteFilm()
        {
            //sql queries for deleting 
            try
            {
                conn = new SqlConnection(conStr);
                String title = cbx_title.GetItemText(cbx_title.SelectedItem);
                conn.Open();
                com = new SqlCommand("SELECT * FROM FILMS WHERE Title= @title", conn);
                com.Parameters.AddWithValue("@title", title);
                adap.SelectCommand = com;
                adap.Fill(ds, "FILMS");
                cbx_filmID.ValueMember = "Film_ID";
                cbx_filmID.DisplayMember = "Film_ID";
                cbx_filmID.DataSource = ds.Tables["FILMS"];

                if(cbx_title.SelectedIndex != -1)
                {
                    com = new SqlCommand("DELETE FROM FILMS WHERE Title=@title", conn);
                    com.Parameters.AddWithValue("@title", title);

                    DialogResult res = MessageBox.Show("Are you sure you want to delete " + title + "?", "Caution", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Deleted the record successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Movie invalid. Please select a valid movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reLoad();
                ClearData();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //creating clear button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //allow users to select a combo box item from title to display all the information from the table
        private void cbx_title_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_title.SelectedIndex != -1)
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();

                    adap = new SqlDataAdapter();
                    ds = new DataSet();

                    sql = $"SELECT Film_ID FROM FILMS WHERE Title = '{cbx_title.Text}'  ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    int film_id = (int)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");
                    txt_film_ID.Text = film_id.ToString();


                    sql = $"SELECT Film_Cost FROM FILMS WHERE Title =  '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    decimal film = (decimal)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");
                    txt_filmCost.Text = film.ToString();


                    sql = $"SELECT Selling_Price FROM FILMS WHERE Title = '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    decimal price = (decimal)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");
                    txt_sellingPrice.Text = price.ToString();


                    sql = $"SELECT Length FROM FILMS WHERE Title =  '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    int length = (int)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");
                    txt_length.Text = length.ToString();


                    sql = $"SELECT Age_Restriction FROM FILMS WHERE Title =  '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    int age = (int)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");
                    txt_ageRestiction.Text = age.ToString();

                    sql = $"SELECT Genre_ID FROM FILMS WHERE Title =  '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    genreID = (int)com.ExecuteScalar();

                    sql = $"SELECT Description FROM GENRES WHERE Genre_ID = {genreID}";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    adap.Fill(ds, "GENRES");
                    cbx_genre.ValueMember = "Description";
                    cbx_genre.DisplayMember = "Description";
                    cbx_genre.DataSource = ds.Tables["GENRES"];

                    sql = $"SELECT Description FROM GENRES WHERE NOT Genre_ID = {genreID}";

                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    adap.Fill(ds, "GENRES");
                    cbx_genre.ValueMember = "Description";
                    cbx_genre.DisplayMember = "Description";
                    cbx_genre.DataSource = ds.Tables["GENRES"];

                    sql = $"SELECT Status FROM FILMS WHERE Title =  '{cbx_title.Text}' ";
                    com = new SqlCommand(sql, conn);
                    adap.SelectCommand = com;
                    Boolean status = (Boolean)com.ExecuteScalar();
                    adap.Fill(ds, "FILMS");

                    conn.Close();

                    if (status)
                    {
                        rdo_Active.Checked = true;
                        rdo_Inactive.Checked = false;
                    }
                    else
                    {
                        rdo_Active.Checked = false;
                        rdo_Inactive.Checked = true;
                    }

                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        //Creating a disable method for controls
        public void disable()
        {
            lbl_filmCost.Enabled = false;
            lbl_filmID.Enabled = false;
            lbl_length.Enabled = false;
            lbl_status.Enabled = false;
            lbl_sellingPrice.Enabled = false;
            lbl_genre.Enabled =false ;
            lbl_ageRestriction.Enabled = false;
            lbl_title.Visible = true;

            txt_ageRestiction.Enabled = false;
            txt_filmCost.Enabled = false;
            txt_length.Enabled = false;
            txt_sellingPrice.Enabled = false;
            pnl_Status.Enabled = false;
            txt_title.Enabled = false;
            txt_film_ID.Enabled = false;

            lv_filmID.Enabled = false;
            lv_genre.Enabled = false;
            lv_title.Enabled = false;

            gbx_films.Enabled = true;
            dgv_films.Enabled = true;

            btn_add.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = true;

            cbx_filmID.Enabled = false;
            cbx_genre.Enabled = false;
            cbx_title.Enabled = true;

            pcb_help.Visible = false;
        }
        //Creating a enable method for controls
        public void enable()
        {
            lbl_filmCost.Enabled = true;
            lbl_filmID.Enabled = true;
            lbl_length.Enabled = true;
            lbl_status.Enabled = true;
            lbl_sellingPrice.Enabled = true;
            lbl_genre.Enabled = true;
            lbl_ageRestriction.Enabled = true;
            lbl_title.Visible = true;

            txt_ageRestiction.Enabled = true;
            txt_filmCost.Enabled = true;
            txt_length.Enabled = true;
            txt_sellingPrice.Enabled = true;
            pnl_Status.Enabled = true;
            txt_title.Enabled = true;
            txt_film_ID.Enabled = true;

            lv_filmID.Enabled = false;
            lv_genre.Enabled = false;
            lv_title.Enabled = false;

            gbx_films.Enabled = true;
            dgv_films.Enabled = true;

            btn_add.Enabled = true;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            cbx_filmID.Enabled = true;
            cbx_genre.Enabled = true;
            cbx_title.Enabled = true;
        }

        
        //Craeting help button for films
        private void btn_help_Click(object sender, EventArgs e)
        {
            pcb_help.Visible = true;
        }
        //creating help close button for films to close the help image
        private void btn_helpClose_Click(object sender, EventArgs e)
        {
            pcb_help.Visible = false;
        }
        //Craeting button to go back to previous aintain film
        private void btn_previous_Click(object sender, EventArgs e)
        {
            frmLogin oldLog = new frmLogin();
            oldLog.ShowDialog();
            this.Close();
        }
    }
}
