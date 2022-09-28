
namespace project
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gbox_Login = new System.Windows.Forms.GroupBox();
            this.btn_HidePassword = new System.Windows.Forms.Button();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.gbox_Menu = new System.Windows.Forms.GroupBox();
            this.lbl_Reports = new System.Windows.Forms.Label();
            this.lbl_Schedule = new System.Windows.Forms.Label();
            this.lbl_Theatres = new System.Windows.Forms.Label();
            this.lbl_Genres = new System.Windows.Forms.Label();
            this.lbl_Films = new System.Windows.Forms.Label();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.picbox_Login = new System.Windows.Forms.PictureBox();
            this.lblTimes = new System.Windows.Forms.Label();
            this.gbox_Login.SuspendLayout();
            this.gbox_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_Login
            // 
            this.gbox_Login.Controls.Add(this.btn_HidePassword);
            this.gbox_Login.Controls.Add(this.btn_ShowPassword);
            this.gbox_Login.Controls.Add(this.btn_Login);
            this.gbox_Login.Controls.Add(this.txt_Password);
            this.gbox_Login.Controls.Add(this.txt_Username);
            this.gbox_Login.Controls.Add(this.lbl_Username);
            this.gbox_Login.Controls.Add(this.lbl_Password);
            this.gbox_Login.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Login.ForeColor = System.Drawing.Color.White;
            this.gbox_Login.Location = new System.Drawing.Point(684, 212);
            this.gbox_Login.Name = "gbox_Login";
            this.gbox_Login.Size = new System.Drawing.Size(388, 296);
            this.gbox_Login.TabIndex = 3;
            this.gbox_Login.TabStop = false;
            this.gbox_Login.Text = "Pukkie Cinema";
            // 
            // btn_HidePassword
            // 
            this.btn_HidePassword.BackColor = System.Drawing.Color.White;
            this.btn_HidePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HidePassword.BackgroundImage")));
            this.btn_HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HidePassword.Location = new System.Drawing.Point(300, 153);
            this.btn_HidePassword.Name = "btn_HidePassword";
            this.btn_HidePassword.Size = new System.Drawing.Size(34, 40);
            this.btn_HidePassword.TabIndex = 7;
            this.btn_HidePassword.UseVisualStyleBackColor = false;
            this.btn_HidePassword.Visible = false;
            this.btn_HidePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.BackColor = System.Drawing.Color.White;
            this.btn_ShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ShowPassword.BackgroundImage")));
            this.btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ShowPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ShowPassword.Location = new System.Drawing.Point(300, 153);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(34, 40);
            this.btn_ShowPassword.TabIndex = 6;
            this.btn_ShowPassword.UseVisualStyleBackColor = false;
            this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Purple;
            this.btn_Login.Location = new System.Drawing.Point(196, 227);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(99, 46);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(127, 153);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(167, 40);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(128, 71);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(167, 40);
            this.txt_Username.TabIndex = 3;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(37, 78);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(85, 23);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(37, 160);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(84, 23);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // gbox_Menu
            // 
            this.gbox_Menu.BackColor = System.Drawing.Color.Purple;
            this.gbox_Menu.Controls.Add(this.lblTimes);
            this.gbox_Menu.Controls.Add(this.lbl_Reports);
            this.gbox_Menu.Controls.Add(this.lbl_Schedule);
            this.gbox_Menu.Controls.Add(this.lbl_Theatres);
            this.gbox_Menu.Controls.Add(this.lbl_Genres);
            this.gbox_Menu.Controls.Add(this.lbl_Films);
            this.gbox_Menu.Controls.Add(this.lbl_Users);
            this.gbox_Menu.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Menu.ForeColor = System.Drawing.Color.White;
            this.gbox_Menu.Location = new System.Drawing.Point(684, 211);
            this.gbox_Menu.Name = "gbox_Menu";
            this.gbox_Menu.Size = new System.Drawing.Size(388, 296);
            this.gbox_Menu.TabIndex = 5;
            this.gbox_Menu.TabStop = false;
            this.gbox_Menu.Text = "Menu";
            this.gbox_Menu.Visible = false;
            // 
            // lbl_Reports
            // 
            this.lbl_Reports.AutoSize = true;
            this.lbl_Reports.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reports.ForeColor = System.Drawing.Color.White;
            this.lbl_Reports.Location = new System.Drawing.Point(20, 235);
            this.lbl_Reports.Name = "lbl_Reports";
            this.lbl_Reports.Size = new System.Drawing.Size(90, 33);
            this.lbl_Reports.TabIndex = 5;
            this.lbl_Reports.Text = "Reports";
            this.lbl_Reports.Click += new System.EventHandler(this.lbl_Reports_Click);
            // 
            // lbl_Schedule
            // 
            this.lbl_Schedule.AutoSize = true;
            this.lbl_Schedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Schedule.ForeColor = System.Drawing.Color.White;
            this.lbl_Schedule.Location = new System.Drawing.Point(20, 202);
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(106, 33);
            this.lbl_Schedule.TabIndex = 4;
            this.lbl_Schedule.Text = "Schedule";
            this.lbl_Schedule.Click += new System.EventHandler(this.lbl_Schedule_Click);
            // 
            // lbl_Theatres
            // 
            this.lbl_Theatres.AutoSize = true;
            this.lbl_Theatres.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Theatres.ForeColor = System.Drawing.Color.White;
            this.lbl_Theatres.Location = new System.Drawing.Point(20, 137);
            this.lbl_Theatres.Name = "lbl_Theatres";
            this.lbl_Theatres.Size = new System.Drawing.Size(101, 33);
            this.lbl_Theatres.TabIndex = 3;
            this.lbl_Theatres.Text = "Theatres";
            this.lbl_Theatres.Click += new System.EventHandler(this.lbl_Theatres_Click);
            // 
            // lbl_Genres
            // 
            this.lbl_Genres.AutoSize = true;
            this.lbl_Genres.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genres.ForeColor = System.Drawing.Color.White;
            this.lbl_Genres.Location = new System.Drawing.Point(20, 104);
            this.lbl_Genres.Name = "lbl_Genres";
            this.lbl_Genres.Size = new System.Drawing.Size(84, 33);
            this.lbl_Genres.TabIndex = 2;
            this.lbl_Genres.Text = "Genres";
            this.lbl_Genres.Click += new System.EventHandler(this.lbl_Genres_Click);
            // 
            // lbl_Films
            // 
            this.lbl_Films.AutoSize = true;
            this.lbl_Films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Films.ForeColor = System.Drawing.Color.White;
            this.lbl_Films.Location = new System.Drawing.Point(20, 69);
            this.lbl_Films.Name = "lbl_Films";
            this.lbl_Films.Size = new System.Drawing.Size(68, 33);
            this.lbl_Films.TabIndex = 1;
            this.lbl_Films.Text = "Films";
            this.lbl_Films.Click += new System.EventHandler(this.lbl_Films_Click);
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Users.ForeColor = System.Drawing.Color.White;
            this.lbl_Users.Location = new System.Drawing.Point(20, 36);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(70, 33);
            this.lbl_Users.TabIndex = 0;
            this.lbl_Users.Text = "Users";
            this.lbl_Users.Click += new System.EventHandler(this.lbl_Users_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // picbox_Login
            // 
            this.picbox_Login.Image = global::project.Properties.Resources.PukkiCinema_Logo;
            this.picbox_Login.Location = new System.Drawing.Point(278, 177);
            this.picbox_Login.Name = "picbox_Login";
            this.picbox_Login.Size = new System.Drawing.Size(421, 349);
            this.picbox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Login.TabIndex = 4;
            this.picbox_Login.TabStop = false;
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.ForeColor = System.Drawing.Color.White;
            this.lblTimes.Location = new System.Drawing.Point(21, 170);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(72, 33);
            this.lblTimes.TabIndex = 6;
            this.lblTimes.Text = "Times";
            this.lblTimes.Click += new System.EventHandler(this.lblTimes_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1372, 743);
            this.Controls.Add(this.gbox_Menu);
            this.Controls.Add(this.gbox_Login);
            this.Controls.Add(this.picbox_Login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pukki Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbox_Login.ResumeLayout(false);
            this.gbox_Login.PerformLayout();
            this.gbox_Menu.ResumeLayout(false);
            this.gbox_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Login;
        private System.Windows.Forms.GroupBox gbox_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.GroupBox gbox_Menu;
        private System.Windows.Forms.Label lbl_Reports;
        private System.Windows.Forms.Label lbl_Schedule;
        private System.Windows.Forms.Label lbl_Theatres;
        private System.Windows.Forms.Label lbl_Genres;
        private System.Windows.Forms.Label lbl_Films;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.Button btn_HidePassword;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTimes;
    }
}

