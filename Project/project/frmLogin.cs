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
    public partial class frmLogin : Form
    {
        private bool stayLogged = false;
        public bool UserType = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserType = false;
            WindowState = FormWindowState.Maximized;
            if (stayLogged)
            {
                gbox_Login.Visible = false;
                gbox_Menu.Visible = true;
            }
            else
            {
                gbox_Login.Visible = true;
                gbox_Menu.Visible = false;
                txt_Username.Clear();
                txt_Password.Clear();
            }


        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_HidePassword.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_ShowPassword.Visible = true;
            btn_HidePassword.Visible = false;
            txt_Password.UseSystemPasswordChar = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try 
            {                         

                if (string.IsNullOrEmpty(txt_Username.Text))
                {
                    txt_Username.Focus();
                    errorProvider.SetError(txt_Username, "Username cannot be empty");
                }
                else
                {
                    errorProvider.SetError(txt_Username, null);
                    if (string.IsNullOrEmpty(txt_Password.Text))
                    {
                        txt_Password.Focus();
                        errorProvider.SetError(txt_Password, "Password cannot be empty");
                    }
                    else
                    {
                        errorProvider.SetError(txt_Password, null);
                        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        SqlCommand sqlCMD = new SqlCommand("select IsAdmin from USERS where Username=@username AND Password=@password;", conn);
                        sqlCMD.Parameters.AddWithValue("@username", txt_Username.Text);
                        sqlCMD.Parameters.AddWithValue("@password", txt_Password.Text);

                        SqlDataAdapter adap = new SqlDataAdapter(sqlCMD);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        if (dt.Rows.Count != 0)
                        {
                            if (dt.Rows[0]["IsAdmin"].ToString() == "True")
                            {
                                gbox_Login.Visible = false;
                                gbox_Menu.Visible = true;

                            }
                            else
                            {
                                UserType = true;
                                //Application.Run(new frmSellTickets());
                                //frmSellTickets tickets = new frmSellTickets();
                                //tickets.Show();
                                Close();
                            }

                            stayLogged = true;
                        }
                        else
                        {
                            errorProvider.SetError(txt_Password, "Incorrect Password");
                            errorProvider.SetError(txt_Username, "Incorrect Username");
                            txt_Username.Clear();
                            txt_Password.Clear();

                        }

                        sqlCMD.Parameters.Clear();
                    }
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsers user = new frmUsers();
            user.ShowDialog();
            this.Show();
            //frmLogin Login = new frmLogin();
            //Login.Hide();
        }

        private void lbl_Films_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFilm film = new frmFilm();
            film.ShowDialog();
            this.Show();
        }

        private void lbl_Genres_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenre genre = new frmGenre();
            genre.ShowDialog();
            this.Show();
        }

        private void lbl_Theatres_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTheatres theatres = new frmTheatres();
            theatres.ShowDialog();
            this.Show();
        }

        private void lbl_Schedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchedule schedule = new frmSchedule();
            schedule.ShowDialog();
            this.Show();
        }

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSellTickets tickets = new frmSellTickets();
            tickets.ShowDialog();
            this.Show();
        }

        private void lbl_Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRequestReports reports = new frmRequestReports();
            reports.ShowDialog();
            this.Show();
        }

        private void lblTimes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTime_Allocation times = new frmTime_Allocation();
            times.ShowDialog();
            this.Show();
        }

        /* private void txt_Username_Validating(object sender, CancelEventArgs e)
         {
             if(string.IsNullOrEmpty(txt_Username.Text))
             {
                 e.Cancel = true;
                 txt_Username.Focus();
                 errorProvider.SetError(txt_Username, "Username cannot be empty!");
             }
             else
             {
                 e.Cancel = false;
                 errorProvider.SetError(txt_Username, null);
             }
         }*/

        /* private void txt_Password_Validating(object sender, CancelEventArgs e)
          {
              if (string.IsNullOrEmpty(txt_Password.Text))
              {
                  e.Cancel = true;
                  txt_Password.Focus();
                  errorProvider.SetError(txt_Password, "Username cannot be empty!");
              }
              else
              {
                  e.Cancel = false;
                  errorProvider.SetError(txt_Password, null);
              }
          }*/
    }
}
