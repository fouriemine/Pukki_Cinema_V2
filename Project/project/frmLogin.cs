using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class frmLogin : Form
    {
        /*public String connStr = ("@Data Source=DESKTOP-0B9U4DP;Initial Catalog=LoginTry();Integrated Security=True");
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;*/


        public frmLogin()
        {
            InitializeComponent();
           /* try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Connection Successfull");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
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
                MySqlConnection conn = new MySqlConnection(@"Data Source = DESKTOP - 0B9U4DP; Initial Catalog = LoginTry(); Integrated Security = True");
                MySqlCommand sqlCMD = new MySqlCommand("select Admin from Login_new where Username=@username AND Password=@password;", conn);
                sqlCMD.Parameters.AddWithValue("@username", txt_Username.Text);
                sqlCMD.Parameters.AddWithValue("@password", txt_Password.Text);

                MySqlDataAdapter adap = new MySqlDataAdapter(sqlCMD);
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
                    /*gbox_Login.Visible = false;
                    gbox_Menu.Visible = true;*/
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
