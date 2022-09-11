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
        public String connStr = ("@Data Source=DESKTOP-0B9U4DP;Initial Catalog=LoginTry();Integrated Security=True");
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;


        public frmLogin()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Connection Successfull");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Could not connect to db");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("@Data Source=DESKTOP-0B9U4DP;Initial Catalog=LoginTry();Integrated Security=True");
                SqlDataAdapter adap = new SqlDataAdapter("select Admin from Login_new where Username= '" + txt_Username.Text + "'and Password= '" + txt_Password.Text + "'", conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    switch (dt.Rows[0]["Admin"].ToString())
                    {
                        case "Yes":
                            gbox_Login.Visible = false;
                            gbox_Menu.Visible = true;
                            break;

                        case "No":
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

            }
            catch
            {
                MessageBox.Show("Error");
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
    }
}
