using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gbox_Menu.Visible = true;
        }

        private void lbl_Users_Click(object sender, EventArgs e)
        {
            frmUsers Users = new frmUsers();
            this.Hide();
            Users.ShowDialog();
            this.Show();
            
        }

        private void lbl_Films_Click(object sender, EventArgs e)
        {
            frmFilm Films = new frmFilm();
            this.Hide();
            Films.ShowDialog();
            this.Show();           
        }

        private void lbl_Genres_Click(object sender, EventArgs e)
        {
            frmGenre Genre = new frmGenre();
            this.Hide();
            Genre.ShowDialog();
            this.Show();
        }

        private void lbl_Theatres_Click(object sender, EventArgs e)
        {
            frmTheatres Theatres = new frmTheatres();
            this.Hide();
            Theatres.ShowDialog();
            this.Show();
        }

        private void lbl_Schedule_Click(object sender, EventArgs e)
        {
            frmSchedule Schedule = new frmSchedule();
            this.Hide();
            Schedule.ShowDialog();
            this.Show();
        }

        private void lbl_Tickets_Click(object sender, EventArgs e)
        {
            frmSellTickets SellTickets = new frmSellTickets();
            this.Hide();
            SellTickets.ShowDialog();
            this.Show();
        }

        private void lbl_Reports_Click(object sender, EventArgs e)
        {
            frmRequestReports RequestReports = new frmRequestReports();
            this.Hide();
            RequestReports.ShowDialog();
            this.Show();
        }
    }
}
