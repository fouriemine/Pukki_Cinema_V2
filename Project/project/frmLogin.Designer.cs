
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picbox_Login = new System.Windows.Forms.PictureBox();
            this.gbox_Login = new System.Windows.Forms.GroupBox();
            this.btn_HidePassword = new System.Windows.Forms.Button();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).BeginInit();
            this.gbox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox_Login
            // 
            this.picbox_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_Login.BackgroundImage")));
            this.picbox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_Login.Location = new System.Drawing.Point(71, 192);
            this.picbox_Login.Name = "picbox_Login";
            this.picbox_Login.Size = new System.Drawing.Size(453, 374);
            this.picbox_Login.TabIndex = 4;
            this.picbox_Login.TabStop = false;
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
            this.gbox_Login.Location = new System.Drawing.Point(608, 213);
            this.gbox_Login.Name = "gbox_Login";
            this.gbox_Login.Size = new System.Drawing.Size(640, 353);
            this.gbox_Login.TabIndex = 3;
            this.gbox_Login.TabStop = false;
            this.gbox_Login.Text = "Pukkie Cinema";
            // 
            // btn_HidePassword
            // 
            this.btn_HidePassword.BackColor = System.Drawing.Color.White;
            this.btn_HidePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HidePassword.BackgroundImage")));
            this.btn_HidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HidePassword.Location = new System.Drawing.Point(419, 155);
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
            this.btn_ShowPassword.Location = new System.Drawing.Point(419, 155);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(34, 40);
            this.btn_ShowPassword.TabIndex = 6;
            this.btn_ShowPassword.UseVisualStyleBackColor = false;
            this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Purple;
            this.btn_Login.Location = new System.Drawing.Point(286, 239);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(99, 46);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Log in";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(246, 155);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(167, 40);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(247, 73);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(167, 40);
            this.txt_Username.TabIndex = 3;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(156, 80);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(85, 23);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(156, 162);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(84, 23);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1324, 761);
            this.Controls.Add(this.gbox_Login);
            this.Controls.Add(this.picbox_Login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1340, 800);
            this.MinimumSize = new System.Drawing.Size(1340, 800);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pukki Cinema";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Login)).EndInit();
            this.gbox_Login.ResumeLayout(false);
            this.gbox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Login;
        private System.Windows.Forms.GroupBox gbox_Login;
        private System.Windows.Forms.Button btn_HidePassword;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
    }
}

