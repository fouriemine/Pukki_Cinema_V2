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


        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(stayLogged)
            {
                gbox_Login.Visible = false;
                gbox_Menu.Visible = true;
            }
            else
            {
                gbox_Login.Visible = true;
                gbox_Menu.Visible = false;
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
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - 0B9U4DP; Initial Catalog = LoginTry(); Integrated Security = True");
                SqlCommand sqlCMD = new SqlCommand("select Admin from Login_new where Username=@username AND Password=@password;", conn);
                sqlCMD.Parameters.AddWithValue("@username", txt_Username.Text);
                sqlCMD.Parameters.AddWithValue("@password", txt_Password.Text);

                SqlDataAdapter adap = new SqlDataAdapter(sqlCMD);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    switch (dt.Rows[0]["Admin"].ToString())
                    {
                        case "Admin":
                            gbox_Login.Visible = false;
                            gbox_Menu.Visible = true;
                            break;

                        case "User":
                            MessageBox.Show("Can only sell tickets");
                            break;

                        default:
                            MessageBox.Show("Please enter correct details");
                            break;
                    }
                    stayLogged = true;
                }
                else
                {
                    MessageBox.Show("Incorrect details");
                    txt_Username.Clear();
                    txt_Password.Clear();
                }

                
                sqlCMD.Parameters.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_Users_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Films_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Genres_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Theatres_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Schedule_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Reports_Click(object sender, EventArgs e)
        {

        }
    }
}
