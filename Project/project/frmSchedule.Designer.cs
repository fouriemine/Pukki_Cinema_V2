
namespace project
{
    partial class frmSchedule
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
            this.lblScheduleHeading = new System.Windows.Forms.Label();
            this.pnlScheduleHeading = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_previousFilms = new System.Windows.Forms.Button();
            this.lbl_deleteFilms = new System.Windows.Forms.Label();
            this.lbl_addFilms = new System.Windows.Forms.Label();
            this.lbl_UpdateFilms = new System.Windows.Forms.Label();
            this.gbxSchedule = new System.Windows.Forms.GroupBox();
            this.cbxTimes = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbxTheatres = new System.Windows.Forms.ComboBox();
            this.cbxFilms = new System.Windows.Forms.ComboBox();
            this.dtpShowDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTheatre = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.pnlScheduleHeading.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScheduleHeading
            // 
            this.lblScheduleHeading.AutoSize = true;
            this.lblScheduleHeading.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleHeading.ForeColor = System.Drawing.Color.White;
            this.lblScheduleHeading.Location = new System.Drawing.Point(394, 9);
            this.lblScheduleHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScheduleHeading.Name = "lblScheduleHeading";
            this.lblScheduleHeading.Size = new System.Drawing.Size(307, 103);
            this.lblScheduleHeading.TabIndex = 3;
            this.lblScheduleHeading.Text = "Schedule";
            // 
            // pnlScheduleHeading
            // 
            this.pnlScheduleHeading.BackColor = System.Drawing.Color.Purple;
            this.pnlScheduleHeading.Controls.Add(this.panel5);
            this.pnlScheduleHeading.Controls.Add(this.lblScheduleHeading);
            this.pnlScheduleHeading.Location = new System.Drawing.Point(-242, 0);
            this.pnlScheduleHeading.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScheduleHeading.Name = "pnlScheduleHeading";
            this.pnlScheduleHeading.Size = new System.Drawing.Size(1285, 127);
            this.pnlScheduleHeading.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.btn_previousFilms);
            this.panel5.Controls.Add(this.lbl_deleteFilms);
            this.panel5.Controls.Add(this.lbl_addFilms);
            this.panel5.Controls.Add(this.lbl_UpdateFilms);
            this.panel5.Location = new System.Drawing.Point(303, 126);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
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
            this.btn_previousFilms.Margin = new System.Windows.Forms.Padding(2);
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
            // gbxSchedule
            // 
            this.gbxSchedule.Controls.Add(this.cbxTimes);
            this.gbxSchedule.Controls.Add(this.lblTime);
            this.gbxSchedule.Controls.Add(this.cbxTheatres);
            this.gbxSchedule.Controls.Add(this.cbxFilms);
            this.gbxSchedule.Controls.Add(this.dtpShowDate);
            this.gbxSchedule.Controls.Add(this.dgvSchedule);
            this.gbxSchedule.Controls.Add(this.lblFilm);
            this.gbxSchedule.Controls.Add(this.lbl_status);
            this.gbxSchedule.Controls.Add(this.lblDate);
            this.gbxSchedule.Controls.Add(this.lblTheatre);
            this.gbxSchedule.Controls.Add(this.btnSchedule);
            this.gbxSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSchedule.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbxSchedule.Location = new System.Drawing.Point(11, 141);
            this.gbxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSchedule.Name = "gbxSchedule";
            this.gbxSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSchedule.Size = new System.Drawing.Size(787, 442);
            this.gbxSchedule.TabIndex = 12;
            this.gbxSchedule.TabStop = false;
            this.gbxSchedule.Text = "Add Schedule";
            // 
            // cbxTimes
            // 
            this.cbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimes.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimes.FormattingEnabled = true;
            this.cbxTimes.Location = new System.Drawing.Point(532, 103);
            this.cbxTimes.Name = "cbxTimes";
            this.cbxTimes.Size = new System.Drawing.Size(200, 31);
            this.cbxTimes.TabIndex = 34;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTime.Location = new System.Drawing.Point(392, 103);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 33);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "Time";
            // 
            // cbxTheatres
            // 
            this.cbxTheatres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheatres.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheatres.FormattingEnabled = true;
            this.cbxTheatres.Location = new System.Drawing.Point(159, 103);
            this.cbxTheatres.Name = "cbxTheatres";
            this.cbxTheatres.Size = new System.Drawing.Size(186, 31);
            this.cbxTheatres.TabIndex = 32;
            // 
            // cbxFilms
            // 
            this.cbxFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilms.FormattingEnabled = true;
            this.cbxFilms.Location = new System.Drawing.Point(159, 61);
            this.cbxFilms.Name = "cbxFilms";
            this.cbxFilms.Size = new System.Drawing.Size(186, 31);
            this.cbxFilms.TabIndex = 31;
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowDate.Location = new System.Drawing.Point(532, 62);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.Size = new System.Drawing.Size(200, 30);
            this.dtpShowDate.TabIndex = 30;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToOrderColumns = true;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(40, 181);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(722, 186);
            this.dgvSchedule.TabIndex = 29;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFilm.Location = new System.Drawing.Point(16, 54);
            this.lblFilm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(53, 33);
            this.lblFilm.TabIndex = 26;
            this.lblFilm.Text = "Film";
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
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDate.Location = new System.Drawing.Point(389, 59);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 33);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            // 
            // lblTheatre
            // 
            this.lblTheatre.AutoSize = true;
            this.lblTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTheatre.Location = new System.Drawing.Point(16, 100);
            this.lblTheatre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheatre.Name = "lblTheatre";
            this.lblTheatre.Size = new System.Drawing.Size(83, 33);
            this.lblTheatre.TabIndex = 11;
            this.lblTheatre.Text = "Theatre";
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(653, 386);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(129, 40);
            this.btnSchedule.TabIndex = 11;
            this.btnSchedule.Text = "add";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 595);
            this.Controls.Add(this.gbxSchedule);
            this.Controls.Add(this.pnlScheduleHeading);
            this.Name = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.pnlScheduleHeading.ResumeLayout(false);
            this.pnlScheduleHeading.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbxSchedule.ResumeLayout(false);
            this.gbxSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScheduleHeading;
        private System.Windows.Forms.Panel pnlScheduleHeading;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_previousFilms;
        private System.Windows.Forms.Label lbl_deleteFilms;
        private System.Windows.Forms.Label lbl_addFilms;
        private System.Windows.Forms.Label lbl_UpdateFilms;
        private System.Windows.Forms.GroupBox gbxSchedule;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTheatre;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.ComboBox cbxTimes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbxTheatres;
        private System.Windows.Forms.ComboBox cbxFilms;
    }
}