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
        public int UserType = 0;


        public frmLogin()
        {
            InitializeComponent();
            
        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gbox_Login.Visible = true;
           /* if (stayLogged)
            {
                gbox_Login.Visible = false;
                gbox_Menu.Visible = true;
            }
            else
            {
                gbox_Login.Visible = true;
                gbox_Menu.Visible = false;
            }*/
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
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand sqlCMD = new SqlCommand("SELECT IsAdmin FROM USERS WHERE Username=@username AND Password=@password;", conn);
                sqlCMD.Parameters.AddWithValue("@username", txt_Username.Text);
                sqlCMD.Parameters.AddWithValue("@password", txt_Password.Text);

                SqlDataAdapter adap = new SqlDataAdapter(sqlCMD);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    switch (dt.Rows[0]["IsAdmin"].ToString())
                    {
                        case "True":
                            UserType = 1;
                            Close();

                            break;

                        case "False":
                            UserType = 2;
                            Close();
                            break;

                        default:
                            MessageBox.Show("Please enter correct details");
                            break;
                    }
                   
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
    }
}
