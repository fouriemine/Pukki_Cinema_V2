
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_films = new System.Windows.Forms.Label();
            this.gbx_users = new System.Windows.Forms.GroupBox();
            this.lbl_PasswordDisp = new System.Windows.Forms.Label();
            this.HelpFunctionPicture = new System.Windows.Forms.PictureBox();
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
            this.lblUpdate_Users = new System.Windows.Forms.Label();
            this.lblAdd_Users = new System.Windows.Forms.Label();
            this.lbl_DeleteUsers = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btnclose_help = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.gbx_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpFunctionPicture)).BeginInit();
            this.pnl_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_films);
            this.panel3.Location = new System.Drawing.Point(-294, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1580, 165);
            this.panel3.TabIndex = 9;
            // 
            // lbl_films
            // 
            this.lbl_films.AutoSize = true;
            this.lbl_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 63.75F);
            this.lbl_films.ForeColor = System.Drawing.Color.White;
            this.lbl_films.Location = new System.Drawing.Point(480, 30);
            this.lbl_films.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_films.Name = "lbl_films";
            this.lbl_films.Size = new System.Drawing.Size(201, 103);
            this.lbl_films.TabIndex = 3;
            this.lbl_films.Text = "Users";
            // 
            // gbx_users
            // 
            this.gbx_users.Controls.Add(this.HelpFunctionPicture);
            this.gbx_users.Controls.Add(this.lbl_PasswordDisp);
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
            this.gbx_users.Location = new System.Drawing.Point(177, 179);
            this.gbx_users.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_users.Name = "gbx_users";
            this.gbx_users.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_users.Size = new System.Drawing.Size(953, 488);
            this.gbx_users.TabIndex = 11;
            this.gbx_users.TabStop = false;
            this.gbx_users.Text = "Current Users";
            this.gbx_users.Enter += new System.EventHandler(this.gbx_users_Enter);
            // 
            // lbl_PasswordDisp
            // 
            this.lbl_PasswordDisp.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_PasswordDisp.Location = new System.Drawing.Point(158, 200);
            this.lbl_PasswordDisp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PasswordDisp.Name = "lbl_PasswordDisp";
            this.lbl_PasswordDisp.Size = new System.Drawing.Size(182, 103);
            this.lbl_PasswordDisp.TabIndex = 1000;
            // 
            // HelpFunctionPicture
            // 
            this.HelpFunctionPicture.Image = ((System.Drawing.Image)(resources.GetObject("HelpFunctionPicture.Image")));
            this.HelpFunctionPicture.Location = new System.Drawing.Point(28, 17);
            this.HelpFunctionPicture.Margin = new System.Windows.Forms.Padding(2);
            this.HelpFunctionPicture.Name = "HelpFunctionPicture";
            this.HelpFunctionPicture.Size = new System.Drawing.Size(349, 440);
            this.HelpFunctionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpFunctionPicture.TabIndex = 12;
            this.HelpFunctionPicture.TabStop = false;
            this.HelpFunctionPicture.Visible = false;
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Admin.Controls.Add(this.rdo_AdminNo);
            this.pnl_Admin.Controls.Add(this.rdo_AdminYes);
            this.pnl_Admin.Location = new System.Drawing.Point(161, 327);
            this.pnl_Admin.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(183, 71);
            this.pnl_Admin.TabIndex = 34;
            // 
            // rdo_AdminNo
            // 
            this.rdo_AdminNo.AutoSize = true;
            this.rdo_AdminNo.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_AdminNo.Location = new System.Drawing.Point(105, 20);
            this.rdo_AdminNo.Margin = new System.Windows.Forms.Padding(2);
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
            this.rdo_AdminYes.Margin = new System.Windows.Forms.Padding(2);
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
            this.btn_Delete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(791, 415);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(143, 49);
            this.btn_Delete.TabIndex = 999;
            this.btn_Delete.Text = "Delete User";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(791, 418);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(143, 46);
            this.btn_Update.TabIndex = 999;
            this.btn_Update.Text = "Update User";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txtBox_UserID
            // 
            this.txtBox_UserID.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_UserID.Location = new System.Drawing.Point(160, 42);
            this.txtBox_UserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_UserID.Multiline = true;
            this.txtBox_UserID.Name = "txtBox_UserID";
            this.txtBox_UserID.Size = new System.Drawing.Size(183, 34);
            this.txtBox_UserID.TabIndex = 1;
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_UserId.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_UserId.Location = new System.Drawing.Point(21, 42);
            this.lbl_UserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(91, 39);
            this.lbl_UserId.TabIndex = 30;
            this.lbl_UserId.Text = "User ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(395, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 274);
            this.dataGridView1.TabIndex = 29;
            // 
            // textbx_Username
            // 
            this.textbx_Username.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbx_Username.Location = new System.Drawing.Point(160, 97);
            this.textbx_Username.Margin = new System.Windows.Forms.Padding(2);
            this.textbx_Username.Multiline = true;
            this.textbx_Username.Name = "textbx_Username";
            this.textbx_Username.Size = new System.Drawing.Size(183, 34);
            this.textbx_Username.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_username.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_username.Location = new System.Drawing.Point(21, 97);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(124, 39);
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
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(183, 34);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lbl_adminYN
            // 
            this.lbl_adminYN.AutoSize = true;
            this.lbl_adminYN.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminYN.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_adminYN.Location = new System.Drawing.Point(21, 348);
            this.lbl_adminYN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_adminYN.Name = "lbl_adminYN";
            this.lbl_adminYN.Size = new System.Drawing.Size(71, 33);
            this.lbl_adminYN.TabIndex = 12;
            this.lbl_adminYN.Text = "Admin";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_password.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_password.Location = new System.Drawing.Point(21, 155);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(120, 39);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(791, 415);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 49);
            this.btn_add.TabIndex = 999;
            this.btn_add.Text = "Add User";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.Purple;
            this.btn_Help.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.Location = new System.Drawing.Point(17, 425);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(138, 55);
            this.btn_Help.TabIndex = 11;
            this.btn_Help.Text = "Help Function Open";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclose_help
            // 
            this.btnclose_help.BackColor = System.Drawing.Color.Purple;
            this.btnclose_help.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btnclose_help.ForeColor = System.Drawing.Color.White;
            this.btnclose_help.Location = new System.Drawing.Point(18, 425);
            this.btnclose_help.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose_help.Name = "btnclose_help";
            this.btnclose_help.Size = new System.Drawing.Size(137, 55);
            this.btnclose_help.TabIndex = 12;
            this.btnclose_help.Text = "Close Help";
            this.btnclose_help.UseVisualStyleBackColor = false;
            this.btnclose_help.Visible = false;
            this.btnclose_help.Click += new System.EventHandler(this.btnclose_help_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Purple;
            this.btn_previous.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(17, 364);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(2);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(138, 51);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btn_previous);
            this.panel1.Controls.Add(this.btnclose_help);
            this.panel1.Controls.Add(this.btn_Help);
            this.panel1.Controls.Add(this.lbl_DeleteUsers);
            this.panel1.Controls.Add(this.lblAdd_Users);
            this.panel1.Controls.Add(this.lblUpdate_Users);
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 504);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(305, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 103);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 675);
            this.Controls.Add(this.gbx_users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1158, 714);
            this.MinimumSize = new System.Drawing.Size(1158, 714);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pukki Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbx_users.ResumeLayout(false);
            this.gbx_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpFunctionPicture)).EndInit();
            this.pnl_Admin.ResumeLayout(false);
            this.pnl_Admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_films;
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
        private System.Windows.Forms.PictureBox HelpFunctionPicture;
        private System.Windows.Forms.Label lbl_PasswordDisp;
        private System.Windows.Forms.Label lblUpdate_Users;
        private System.Windows.Forms.Label lblAdd_Users;
        private System.Windows.Forms.Label lbl_DeleteUsers;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btnclose_help;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}