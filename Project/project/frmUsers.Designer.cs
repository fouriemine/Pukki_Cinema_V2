
namespace project
{
    partial class frmUsers
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_previousFilms = new System.Windows.Forms.Button();
            this.lbl_deleteFilms = new System.Windows.Forms.Label();
            this.lbl_addFilms = new System.Windows.Forms.Label();
            this.lbl_UpdateFilms = new System.Windows.Forms.Label();
            this.lbl_films = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_GetUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_DeleteUsers = new System.Windows.Forms.Label();
            this.lblAdd_Users = new System.Windows.Forms.Label();
            this.lblUpdate_Users = new System.Windows.Forms.Label();
            this.gbx_users = new System.Windows.Forms.GroupBox();
            this.btn_GetUser = new System.Windows.Forms.Button();
            this.pnl_Admin = new System.Windows.Forms.Panel();
            this.rdo_AdminNo = new System.Windows.Forms.RadioButton();
            this.rdo_AdminYes = new System.Windows.Forms.RadioButton();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtBox_UserID = new System.Windows.Forms.TextBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_adminYN = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbx_users.SuspendLayout();
            this.pnl_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lbl_films);
            this.panel3.Location = new System.Drawing.Point(-294, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 127);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.btn_previousFilms);
            this.panel5.Controls.Add(this.lbl_deleteFilms);
            this.panel5.Controls.Add(this.lbl_addFilms);
            this.panel5.Controls.Add(this.lbl_UpdateFilms);
            this.panel5.Location = new System.Drawing.Point(303, 126);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(152, 478);
            this.panel5.TabIndex = 10;
            // 
            // btn_previousFilms
            // 
            this.btn_previousFilms.BackColor = System.Drawing.Color.Purple;
            this.btn_previousFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previousFilms.ForeColor = System.Drawing.Color.White;
            this.btn_previousFilms.Location = new System.Drawing.Point(49, 436);
            this.btn_previousFilms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_previousFilms.Name = "btn_previousFilms";
            this.btn_previousFilms.Size = new System.Drawing.Size(95, 40);
            this.btn_previousFilms.TabIndex = 10;
            this.btn_previousFilms.Text = "Previous";
            this.btn_previousFilms.UseVisualStyleBackColor = false;
            // 
            // lbl_deleteFilms
            // 
            this.lbl_deleteFilms.AutoSize = true;
            this.lbl_deleteFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteFilms.ForeColor = System.Drawing.Color.White;
            this.lbl_deleteFilms.Location = new System.Drawing.Point(11, 142);
            this.lbl_deleteFilms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_deleteFilms.Name = "lbl_deleteFilms";
            this.lbl_deleteFilms.Size = new System.Drawing.Size(136, 39);
            this.lbl_deleteFilms.TabIndex = 6;
            this.lbl_deleteFilms.Text = "Delete Film";
            // 
            // lbl_addFilms
            // 
            this.lbl_addFilms.AutoSize = true;
            this.lbl_addFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addFilms.ForeColor = System.Drawing.Color.White;
            this.lbl_addFilms.Location = new System.Drawing.Point(11, 33);
            this.lbl_addFilms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_addFilms.Name = "lbl_addFilms";
            this.lbl_addFilms.Size = new System.Drawing.Size(108, 39);
            this.lbl_addFilms.TabIndex = 4;
            this.lbl_addFilms.Text = "Add Film";
            // 
            // lbl_UpdateFilms
            // 
            this.lbl_UpdateFilms.AutoSize = true;
            this.lbl_UpdateFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UpdateFilms.ForeColor = System.Drawing.Color.White;
            this.lbl_UpdateFilms.Location = new System.Drawing.Point(11, 87);
            this.lbl_UpdateFilms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UpdateFilms.Name = "lbl_UpdateFilms";
            this.lbl_UpdateFilms.Size = new System.Drawing.Size(141, 39);
            this.lbl_UpdateFilms.TabIndex = 5;
            this.lbl_UpdateFilms.Text = "Update Film";
            // 
            // lbl_films
            // 
            this.lbl_films.AutoSize = true;
            this.lbl_films.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_films.ForeColor = System.Drawing.Color.White;
            this.lbl_films.Location = new System.Drawing.Point(394, 9);
            this.lbl_films.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_films.Name = "lbl_films";
            this.lbl_films.Size = new System.Drawing.Size(202, 103);
            this.lbl_films.TabIndex = 3;
            this.lbl_films.Text = "Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lbl_GetUser);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_DeleteUsers);
            this.panel1.Controls.Add(this.lblAdd_Users);
            this.panel1.Controls.Add(this.lblUpdate_Users);
            this.panel1.Location = new System.Drawing.Point(1, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 489);
            this.panel1.TabIndex = 10;
            // 
            // lbl_GetUser
            // 
            this.lbl_GetUser.AutoSize = true;
            this.lbl_GetUser.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GetUser.ForeColor = System.Drawing.Color.White;
            this.lbl_GetUser.Location = new System.Drawing.Point(20, 197);
            this.lbl_GetUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GetUser.Name = "lbl_GetUser";
            this.lbl_GetUser.Size = new System.Drawing.Size(106, 39);
            this.lbl_GetUser.TabIndex = 11;
            this.lbl_GetUser.Text = "Get User";
            this.lbl_GetUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GetUser.Click += new System.EventHandler(this.lbl_GetUser_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_DeleteUsers
            // 
            this.lbl_DeleteUsers.AutoSize = true;
            this.lbl_DeleteUsers.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeleteUsers.ForeColor = System.Drawing.Color.White;
            this.lbl_DeleteUsers.Location = new System.Drawing.Point(4, 142);
            this.lbl_DeleteUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DeleteUsers.Name = "lbl_DeleteUsers";
            this.lbl_DeleteUsers.Size = new System.Drawing.Size(151, 39);
            this.lbl_DeleteUsers.TabIndex = 6;
            this.lbl_DeleteUsers.Text = "Delete Users";
            this.lbl_DeleteUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_DeleteUsers.Click += new System.EventHandler(this.lbl_DeleteUsers_Click);
            // 
            // lblAdd_Users
            // 
            this.lblAdd_Users.AutoSize = true;
            this.lblAdd_Users.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_Users.ForeColor = System.Drawing.Color.White;
            this.lblAdd_Users.Location = new System.Drawing.Point(10, 33);
            this.lblAdd_Users.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd_Users.Name = "lblAdd_Users";
            this.lblAdd_Users.Size = new System.Drawing.Size(123, 39);
            this.lblAdd_Users.TabIndex = 4;
            this.lblAdd_Users.Text = "Add Users";
            this.lblAdd_Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd_Users.Click += new System.EventHandler(this.lblAdd_Users_Click);
            // 
            // lblUpdate_Users
            // 
            this.lblUpdate_Users.AutoSize = true;
            this.lblUpdate_Users.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate_Users.ForeColor = System.Drawing.Color.White;
            this.lblUpdate_Users.Location = new System.Drawing.Point(6, 87);
            this.lblUpdate_Users.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate_Users.Name = "lblUpdate_Users";
            this.lblUpdate_Users.Size = new System.Drawing.Size(156, 39);
            this.lblUpdate_Users.TabIndex = 5;
            this.lblUpdate_Users.Text = "Update Users";
            this.lblUpdate_Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdate_Users.Click += new System.EventHandler(this.lblUpdate_Users_Click);
            // 
            // gbx_users
            // 
            this.gbx_users.Controls.Add(this.btn_GetUser);
            this.gbx_users.Controls.Add(this.pnl_Admin);
            this.gbx_users.Controls.Add(this.btn_Delete);
            this.gbx_users.Controls.Add(this.btn_Update);
            this.gbx_users.Controls.Add(this.txtBox_UserID);
            this.gbx_users.Controls.Add(this.lbl_UserId);
            this.gbx_users.Controls.Add(this.dataGridView1);
            this.gbx_users.Controls.Add(this.textbx_Username);
            this.gbx_users.Controls.Add(this.lbl_username);
            this.gbx_users.Controls.Add(this.lbl_status);
            this.gbx_users.Controls.Add(this.txt_password);
            this.gbx_users.Controls.Add(this.lbl_adminYN);
            this.gbx_users.Controls.Add(this.lbl_password);
            this.gbx_users.Controls.Add(this.btn_add);
            this.gbx_users.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_users.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbx_users.Location = new System.Drawing.Point(177, 158);
            this.gbx_users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_users.Name = "gbx_users";
            this.gbx_users.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_users.Size = new System.Drawing.Size(938, 442);
            this.gbx_users.TabIndex = 11;
            this.gbx_users.TabStop = false;
            this.gbx_users.Text = "~";
            this.gbx_users.Enter += new System.EventHandler(this.gbx_users_Enter);
            // 
            // btn_GetUser
            // 
            this.btn_GetUser.AllowDrop = true;
            this.btn_GetUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_GetUser.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetUser.ForeColor = System.Drawing.Color.White;
            this.btn_GetUser.Location = new System.Drawing.Point(187, 388);
            this.btn_GetUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GetUser.Name = "btn_GetUser";
            this.btn_GetUser.Size = new System.Drawing.Size(129, 40);
            this.btn_GetUser.TabIndex = 1000;
            this.btn_GetUser.Text = "Get User";
            this.btn_GetUser.UseVisualStyleBackColor = false;
            this.btn_GetUser.Click += new System.EventHandler(this.btn_GetUSers_Click);
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Admin.Controls.Add(this.rdo_AdminNo);
            this.pnl_Admin.Controls.Add(this.rdo_AdminYes);
            this.pnl_Admin.Location = new System.Drawing.Point(160, 223);
            this.pnl_Admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(183, 82);
            this.pnl_Admin.TabIndex = 34;
            // 
            // rdo_AdminNo
            // 
            this.rdo_AdminNo.AutoSize = true;
            this.rdo_AdminNo.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_AdminNo.Location = new System.Drawing.Point(105, 20);
            this.rdo_AdminNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_AdminNo.Name = "rdo_AdminNo";
            this.rdo_AdminNo.Size = new System.Drawing.Size(55, 37);
            this.rdo_AdminNo.TabIndex = 5;
            this.rdo_AdminNo.TabStop = true;
            this.rdo_AdminNo.Text = "No";
            this.rdo_AdminNo.UseVisualStyleBackColor = true;
            // 
            // rdo_AdminYes
            // 
            this.rdo_AdminYes.AutoSize = true;
            this.rdo_AdminYes.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_AdminYes.Location = new System.Drawing.Point(26, 20);
            this.rdo_AdminYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_AdminYes.Name = "rdo_AdminYes";
            this.rdo_AdminYes.Size = new System.Drawing.Size(62, 37);
            this.rdo_AdminYes.TabIndex = 4;
            this.rdo_AdminYes.TabStop = true;
            this.rdo_AdminYes.Text = "Yes";
            this.rdo_AdminYes.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(339, 388);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(129, 40);
            this.btn_Delete.TabIndex = 999;
            this.btn_Delete.Text = "Delete User";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(500, 388);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(129, 40);
            this.btn_Update.TabIndex = 999;
            this.btn_Update.Text = "Update User";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtBox_UserID
            // 
            this.txtBox_UserID.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserID.Location = new System.Drawing.Point(160, 42);
            this.txtBox_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_UserID.Multiline = true;
            this.txtBox_UserID.Name = "txtBox_UserID";
            this.txtBox_UserID.Size = new System.Drawing.Size(183, 34);
            this.txtBox_UserID.TabIndex = 1;
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserId.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_UserId.Location = new System.Drawing.Point(21, 42);
            this.lbl_UserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(77, 33);
            this.lbl_UserId.TabIndex = 30;
            this.lbl_UserId.Text = "User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 327);
            this.dataGridView1.TabIndex = 29;
            // 
            // textbx_Username
            // 
            this.textbx_Username.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbx_Username.Location = new System.Drawing.Point(160, 97);
            this.textbx_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbx_Username.Multiline = true;
            this.textbx_Username.Name = "textbx_Username";
            this.textbx_Username.Size = new System.Drawing.Size(183, 34);
            this.textbx_Username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_username.Location = new System.Drawing.Point(21, 97);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(105, 33);
            this.lbl_username.TabIndex = 26;
            this.lbl_username.Text = "Username";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_status.Location = new System.Drawing.Point(16, 186);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 33);
            this.lbl_status.TabIndex = 24;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(160, 155);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(183, 34);
            this.txt_password.TabIndex = 3;
            // 
            // lbl_adminYN
            // 
            this.lbl_adminYN.AutoSize = true;
            this.lbl_adminYN.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminYN.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_adminYN.Location = new System.Drawing.Point(21, 223);
            this.lbl_adminYN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adminYN.Name = "lbl_adminYN";
            this.lbl_adminYN.Size = new System.Drawing.Size(111, 33);
            this.lbl_adminYN.TabIndex = 12;
            this.lbl_adminYN.Text = "Admin(y/n)";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_password.Location = new System.Drawing.Point(21, 155);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(101, 33);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(653, 388);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 40);
            this.btn_add.TabIndex = 999;
            this.btn_add.Text = "Add User";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gbx_users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_users.ResumeLayout(false);
            this.gbx_users.PerformLayout();
            this.pnl_Admin.ResumeLayout(false);
            this.pnl_Admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_previousFilms;
        private System.Windows.Forms.Label lbl_deleteFilms;
        private System.Windows.Forms.Label lbl_addFilms;
        private System.Windows.Forms.Label lbl_UpdateFilms;
        private System.Windows.Forms.Label lbl_films;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_DeleteUsers;
        private System.Windows.Forms.Label lblAdd_Users;
        private System.Windows.Forms.Label lblUpdate_Users;
        private System.Windows.Forms.GroupBox gbx_users;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbx_Username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_adminYN;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txtBox_UserID;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel pnl_Admin;
        private System.Windows.Forms.RadioButton rdo_AdminNo;
        private System.Windows.Forms.RadioButton rdo_AdminYes;
        private System.Windows.Forms.Label lbl_GetUser;
        private System.Windows.Forms.Button btn_GetUser;
    }
}