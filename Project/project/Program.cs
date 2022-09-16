using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //etsing
            //Application.Run(new frmGenre()) ;

            frmLogin Login = new frmLogin();
            Application.Run(Login);

            if (Login.UserType == 1)
            {
                Application.Run(new frmMenu());
            }
            else if (Login.UserType == 2)
            {
                Application.Run(new frmSellTickets());
            }


            //<<<<<<< Updated upstream
            //Application.Run(new frmUsers());
            //=======

            //Application.Run(new frmLogin());
            //>>>>>>> Stashed changes
        }
    }
}