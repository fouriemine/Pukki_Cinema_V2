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
    public partial class Login : Form
    {
        public String connStr = ("@Data Source=DESKTOP-PJ8SEPG;Initial Catalog=Pukki_Cinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlCommand com;
        public SqlConnection conn;
        public DataSet ds;
        public SqlDataAdapter adap;

        public Login()
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
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0B9U4DP;Initial Catalog=LoginTry();Integrated Security=True");
                SqlDataAdapter adap = new SqlDataAdapter("select Type from Login_new where Username= '" + txt_Username.Text + "'and Password= '" + txt_Password.Text + "'", conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    switch (dt.Rows[0]["Type"].ToString())
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

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
