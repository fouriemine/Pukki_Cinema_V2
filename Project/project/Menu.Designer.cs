
namespace project
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Users = new System.Windows.Forms.Label();
            this.lbl_Films = new System.Windows.Forms.Label();
            this.lbl_Genres = new System.Windows.Forms.Label();
            this.lbl_Theatres = new System.Windows.Forms.Label();
            this.lbl_Schedule = new System.Windows.Forms.Label();
            this.lbl_Reports = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(468, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 260);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Users
            // 
            this.lbl_Users.AutoSize = true;
            this.lbl_Users.ForeColor = System.Drawing.Color.White;
            this.lbl_Users.Location = new System.Drawing.Point(596, 253);
            this.lbl_Users.Name = "lbl_Users";
            this.lbl_Users.Size = new System.Drawing.Size(45, 23);
            this.lbl_Users.TabIndex = 2;
            this.lbl_Users.Text = "Users";
            // 
            // lbl_Films
            // 
            this.lbl_Films.AutoSize = true;
            this.lbl_Films.ForeColor = System.Drawing.Color.White;
            this.lbl_Films.Location = new System.Drawing.Point(596, 300);
            this.lbl_Films.Name = "lbl_Films";
            this.lbl_Films.Size = new System.Drawing.Size(44, 23);
            this.lbl_Films.TabIndex = 3;
            this.lbl_Films.Text = "Films";
            // 
            // lbl_Genres
            // 
            this.lbl_Genres.AutoSize = true;
            this.lbl_Genres.ForeColor = System.Drawing.Color.White;
            this.lbl_Genres.Location = new System.Drawing.Point(596, 345);
            this.lbl_Genres.Name = "lbl_Genres";
            this.lbl_Genres.Size = new System.Drawing.Size(53, 23);
            this.lbl_Genres.TabIndex = 4;
            this.lbl_Genres.Text = "Genres";
            // 
            // lbl_Theatres
            // 
            this.lbl_Theatres.AutoSize = true;
            this.lbl_Theatres.Location = new System.Drawing.Point(596, 395);
            this.lbl_Theatres.Name = "lbl_Theatres";
            this.lbl_Theatres.Size = new System.Drawing.Size(65, 23);
            this.lbl_Theatres.TabIndex = 5;
            this.lbl_Theatres.Text = "Theatres";
            // 
            // lbl_Schedule
            // 
            this.lbl_Schedule.AutoSize = true;
            this.lbl_Schedule.Location = new System.Drawing.Point(596, 442);
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(67, 23);
            this.lbl_Schedule.TabIndex = 6;
            this.lbl_Schedule.Text = "Schedule";
            // 
            // lbl_Reports
            // 
            this.lbl_Reports.AutoSize = true;
            this.lbl_Reports.Location = new System.Drawing.Point(596, 490);
            this.lbl_Reports.Name = "lbl_Reports";
            this.lbl_Reports.Size = new System.Drawing.Size(59, 23);
            this.lbl_Reports.TabIndex = 7;
            this.lbl_Reports.Text = "Reports";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1324, 761);
            this.Controls.Add(this.lbl_Reports);
            this.Controls.Add(this.lbl_Schedule);
            this.Controls.Add(this.lbl_Theatres);
            this.Controls.Add(this.lbl_Genres);
            this.Controls.Add(this.lbl_Films);
            this.Controls.Add(this.lbl_Users);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Users;
        private System.Windows.Forms.Label lbl_Films;
        private System.Windows.Forms.Label lbl_Genres;
        private System.Windows.Forms.Label lbl_Theatres;
        private System.Windows.Forms.Label lbl_Schedule;
        private System.Windows.Forms.Label lbl_Reports;
    }
}