﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblScheduleHeading = new System.Windows.Forms.Label();
            this.pnlScheduleHeading = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnScheduleHelp = new System.Windows.Forms.Button();
            this.btnCloseScheduleHelp = new System.Windows.Forms.Button();
            this.btnPreviousSchedule = new System.Windows.Forms.Button();
            this.lblDeleteSchedule = new System.Windows.Forms.Label();
            this.lblAddSchedule = new System.Windows.Forms.Label();
            this.gbxDeleteSchedule = new System.Windows.Forms.GroupBox();
            this.lblChooseRow = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtTheatre = new System.Windows.Forms.TextBox();
            this.txtShowDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeleteSchedule = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDShowDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
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
            this.errProvScheduleAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.pnlScheduleHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel5.SuspendLayout();
            this.gbxDeleteSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSchedule)).BeginInit();
            this.gbxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvScheduleAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScheduleHeading
            // 
            this.lblScheduleHeading.AutoSize = true;
            this.lblScheduleHeading.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleHeading.ForeColor = System.Drawing.Color.White;
            this.lblScheduleHeading.Location = new System.Drawing.Point(411, 21);
            this.lblScheduleHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScheduleHeading.Name = "lblScheduleHeading";
            this.lblScheduleHeading.Size = new System.Drawing.Size(307, 103);
            this.lblScheduleHeading.TabIndex = 3;
            this.lblScheduleHeading.Text = "Schedule";
            // 
            // pnlScheduleHeading
            // 
            this.pnlScheduleHeading.BackColor = System.Drawing.Color.Purple;
            this.pnlScheduleHeading.Controls.Add(this.pbxLogo);
            this.pnlScheduleHeading.Controls.Add(this.lblScheduleHeading);
            this.pnlScheduleHeading.Location = new System.Drawing.Point(-242, 0);
            this.pnlScheduleHeading.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScheduleHeading.Name = "pnlScheduleHeading";
            this.pnlScheduleHeading.Size = new System.Drawing.Size(1618, 150);
            this.pnlScheduleHeading.TabIndex = 10;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(253, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(166, 117);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 4;
            this.pbxLogo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.btnScheduleHelp);
            this.panel5.Controls.Add(this.btnCloseScheduleHelp);
            this.panel5.Controls.Add(this.btnPreviousSchedule);
            this.panel5.Controls.Add(this.lblDeleteSchedule);
            this.panel5.Controls.Add(this.lblAddSchedule);
            this.panel5.Location = new System.Drawing.Point(-1, 149);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 596);
            this.panel5.TabIndex = 14;
            // 
            // btnScheduleHelp
            // 
            this.btnScheduleHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScheduleHelp.BackColor = System.Drawing.Color.Purple;
            this.btnScheduleHelp.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleHelp.ForeColor = System.Drawing.Color.White;
            this.btnScheduleHelp.Location = new System.Drawing.Point(12, 465);
            this.btnScheduleHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnScheduleHelp.Name = "btnScheduleHelp";
            this.btnScheduleHelp.Size = new System.Drawing.Size(134, 40);
            this.btnScheduleHelp.TabIndex = 12;
            this.btnScheduleHelp.Text = "Help";
            this.btnScheduleHelp.UseVisualStyleBackColor = false;
            this.btnScheduleHelp.Click += new System.EventHandler(this.btnScheduleHelp_Click);
            // 
            // btnCloseScheduleHelp
            // 
            this.btnCloseScheduleHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseScheduleHelp.BackColor = System.Drawing.Color.Purple;
            this.btnCloseScheduleHelp.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseScheduleHelp.ForeColor = System.Drawing.Color.White;
            this.btnCloseScheduleHelp.Location = new System.Drawing.Point(10, 465);
            this.btnCloseScheduleHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseScheduleHelp.Name = "btnCloseScheduleHelp";
            this.btnCloseScheduleHelp.Size = new System.Drawing.Size(136, 40);
            this.btnCloseScheduleHelp.TabIndex = 11;
            this.btnCloseScheduleHelp.Text = "Close help";
            this.btnCloseScheduleHelp.UseVisualStyleBackColor = false;
            this.btnCloseScheduleHelp.Click += new System.EventHandler(this.btnCloseScheduleHelp_Click);
            // 
            // btnPreviousSchedule
            // 
            this.btnPreviousSchedule.BackColor = System.Drawing.Color.Purple;
            this.btnPreviousSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousSchedule.ForeColor = System.Drawing.Color.White;
            this.btnPreviousSchedule.Location = new System.Drawing.Point(10, 509);
            this.btnPreviousSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousSchedule.Name = "btnPreviousSchedule";
            this.btnPreviousSchedule.Size = new System.Drawing.Size(136, 40);
            this.btnPreviousSchedule.TabIndex = 10;
            this.btnPreviousSchedule.Text = "Previous";
            this.btnPreviousSchedule.UseVisualStyleBackColor = false;
            this.btnPreviousSchedule.Click += new System.EventHandler(this.btnPreviousSchedule_Click);
            // 
            // lblDeleteSchedule
            // 
            this.lblDeleteSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.lblDeleteSchedule.Location = new System.Drawing.Point(10, 143);
            this.lblDeleteSchedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteSchedule.Name = "lblDeleteSchedule";
            this.lblDeleteSchedule.Size = new System.Drawing.Size(136, 89);
            this.lblDeleteSchedule.TabIndex = 6;
            this.lblDeleteSchedule.Text = "Delete Schedule";
            this.lblDeleteSchedule.Click += new System.EventHandler(this.lblDeleteSchedule_Click);
            // 
            // lblAddSchedule
            // 
            this.lblAddSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSchedule.ForeColor = System.Drawing.Color.White;
            this.lblAddSchedule.Location = new System.Drawing.Point(11, 33);
            this.lblAddSchedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSchedule.Name = "lblAddSchedule";
            this.lblAddSchedule.Size = new System.Drawing.Size(133, 78);
            this.lblAddSchedule.TabIndex = 4;
            this.lblAddSchedule.Text = "Add Schedule";
            this.lblAddSchedule.Click += new System.EventHandler(this.lblAddSchedule_Click);
            // 
            // gbxDeleteSchedule
            // 
            this.gbxDeleteSchedule.Controls.Add(this.lblChooseRow);
            this.gbxDeleteSchedule.Controls.Add(this.txtTime);
            this.gbxDeleteSchedule.Controls.Add(this.txtFilm);
            this.gbxDeleteSchedule.Controls.Add(this.txtTheatre);
            this.gbxDeleteSchedule.Controls.Add(this.txtShowDate);
            this.gbxDeleteSchedule.Controls.Add(this.label1);
            this.gbxDeleteSchedule.Controls.Add(this.dgvDeleteSchedule);
            this.gbxDeleteSchedule.Controls.Add(this.label2);
            this.gbxDeleteSchedule.Controls.Add(this.label3);
            this.gbxDeleteSchedule.Controls.Add(this.lblDShowDate);
            this.gbxDeleteSchedule.Controls.Add(this.label5);
            this.gbxDeleteSchedule.Controls.Add(this.btnDeleteSchedule);
            this.gbxDeleteSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDeleteSchedule.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbxDeleteSchedule.Location = new System.Drawing.Point(185, 154);
            this.gbxDeleteSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDeleteSchedule.Name = "gbxDeleteSchedule";
            this.gbxDeleteSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDeleteSchedule.Size = new System.Drawing.Size(1156, 563);
            this.gbxDeleteSchedule.TabIndex = 15;
            this.gbxDeleteSchedule.TabStop = false;
            this.gbxDeleteSchedule.Text = "Delete Schedule";
            this.gbxDeleteSchedule.VisibleChanged += new System.EventHandler(this.gbxDeleteSchedule_VisibleChanged_1);
            this.gbxDeleteSchedule.Enter += new System.EventHandler(this.gbxDeleteSchedule_Enter);
            // 
            // lblChooseRow
            // 
            this.lblChooseRow.AutoSize = true;
            this.lblChooseRow.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseRow.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblChooseRow.Location = new System.Drawing.Point(49, 70);
            this.lblChooseRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseRow.Name = "lblChooseRow";
            this.lblChooseRow.Size = new System.Drawing.Size(257, 33);
            this.lblChooseRow.TabIndex = 38;
            this.lblChooseRow.Text = "Choose entry to be deleted:";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(721, 440);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(160, 30);
            this.txtTime.TabIndex = 37;
            // 
            // txtFilm
            // 
            this.txtFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilm.Location = new System.Drawing.Point(721, 397);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(160, 30);
            this.txtFilm.TabIndex = 36;
            // 
            // txtTheatre
            // 
            this.txtTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheatre.Location = new System.Drawing.Point(384, 440);
            this.txtTheatre.Name = "txtTheatre";
            this.txtTheatre.Size = new System.Drawing.Size(157, 30);
            this.txtTheatre.TabIndex = 35;
            // 
            // txtShowDate
            // 
            this.txtShowDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDate.Location = new System.Drawing.Point(384, 399);
            this.txtShowDate.Name = "txtShowDate";
            this.txtShowDate.Size = new System.Drawing.Size(157, 30);
            this.txtShowDate.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(625, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Time";
            // 
            // dgvDeleteSchedule
            // 
            this.dgvDeleteSchedule.AllowUserToAddRows = false;
            this.dgvDeleteSchedule.AllowUserToDeleteRows = false;
            this.dgvDeleteSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDeleteSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDeleteSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDeleteSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeleteSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeleteSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeleteSchedule.Location = new System.Drawing.Point(55, 129);
            this.dgvDeleteSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDeleteSchedule.Name = "dgvDeleteSchedule";
            this.dgvDeleteSchedule.ReadOnly = true;
            this.dgvDeleteSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeleteSchedule.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeleteSchedule.RowTemplate.Height = 24;
            this.dgvDeleteSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeleteSchedule.Size = new System.Drawing.Size(1046, 223);
            this.dgvDeleteSchedule.TabIndex = 29;
            this.dgvDeleteSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeleteSchedule_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(625, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Film";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 24;
            // 
            // lblDShowDate
            // 
            this.lblDShowDate.AutoSize = true;
            this.lblDShowDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDShowDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDShowDate.Location = new System.Drawing.Point(241, 394);
            this.lblDShowDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDShowDate.Name = "lblDShowDate";
            this.lblDShowDate.Size = new System.Drawing.Size(56, 33);
            this.lblDShowDate.TabIndex = 12;
            this.lblDShowDate.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(241, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Theatre";
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(1001, 501);
            this.btnDeleteSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(129, 40);
            this.btnDeleteSchedule.TabIndex = 11;
            this.btnDeleteSchedule.Text = "Delete";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click_1);
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
            this.gbxSchedule.Location = new System.Drawing.Point(185, 155);
            this.gbxSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSchedule.Name = "gbxSchedule";
            this.gbxSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSchedule.Size = new System.Drawing.Size(1156, 562);
            this.gbxSchedule.TabIndex = 16;
            this.gbxSchedule.TabStop = false;
            this.gbxSchedule.Text = "Add Schedule";
            this.gbxSchedule.VisibleChanged += new System.EventHandler(this.gbxSchedule_VisibleChanged_1);
            // 
            // cbxTimes
            // 
            this.cbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimes.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimes.FormattingEnabled = true;
            this.cbxTimes.Location = new System.Drawing.Point(721, 136);
            this.cbxTimes.Name = "cbxTimes";
            this.cbxTimes.Size = new System.Drawing.Size(200, 31);
            this.cbxTimes.TabIndex = 34;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTime.Location = new System.Drawing.Point(581, 136);
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
            this.cbxTheatres.Location = new System.Drawing.Point(348, 136);
            this.cbxTheatres.Name = "cbxTheatres";
            this.cbxTheatres.Size = new System.Drawing.Size(186, 31);
            this.cbxTheatres.TabIndex = 32;
            // 
            // cbxFilms
            // 
            this.cbxFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilms.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilms.FormattingEnabled = true;
            this.cbxFilms.Location = new System.Drawing.Point(721, 92);
            this.cbxFilms.Name = "cbxFilms";
            this.cbxFilms.Size = new System.Drawing.Size(200, 31);
            this.cbxFilms.TabIndex = 31;
            // 
            // dtpShowDate
            // 
            this.dtpShowDate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShowDate.Location = new System.Drawing.Point(348, 93);
            this.dtpShowDate.Name = "dtpShowDate";
            this.dtpShowDate.Size = new System.Drawing.Size(186, 30);
            this.dtpShowDate.TabIndex = 30;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToOrderColumns = true;
            this.dgvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(79, 200);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersWidth = 60;
            this.dgvSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSchedule.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(1002, 272);
            this.dgvSchedule.TabIndex = 29;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFilm.Location = new System.Drawing.Point(581, 90);
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
            this.lblDate.Location = new System.Drawing.Point(205, 90);
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
            this.lblTheatre.Location = new System.Drawing.Point(205, 133);
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
            this.btnSchedule.Location = new System.Drawing.Point(1001, 500);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(129, 40);
            this.btnSchedule.TabIndex = 11;
            this.btnSchedule.Text = "Add";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click_1);
            // 
            // errProvScheduleAdd
            // 
            this.errProvScheduleAdd.ContainerControl = this;
            // 
            // pbHelp
            // 
            this.pbHelp.Image = global::project.Properties.Resources.Schedule_help;
            this.pbHelp.Location = new System.Drawing.Point(170, 159);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(375, 455);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHelp.TabIndex = 20;
            this.pbHelp.TabStop = false;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 743);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlScheduleHeading);
            this.Controls.Add(this.gbxDeleteSchedule);
            this.Controls.Add(this.gbxSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.Name = "frmSchedule";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.pnlScheduleHeading.ResumeLayout(false);
            this.pnlScheduleHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.gbxDeleteSchedule.ResumeLayout(false);
            this.gbxDeleteSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteSchedule)).EndInit();
            this.gbxSchedule.ResumeLayout(false);
            this.gbxSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvScheduleAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScheduleHeading;
        private System.Windows.Forms.Panel pnlScheduleHeading;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPreviousSchedule;
        private System.Windows.Forms.Label lblDeleteSchedule;
        private System.Windows.Forms.Label lblAddSchedule;
        private System.Windows.Forms.GroupBox gbxDeleteSchedule;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtTheatre;
        private System.Windows.Forms.TextBox txtShowDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeleteSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDShowDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.GroupBox gbxSchedule;
        private System.Windows.Forms.ComboBox cbxTimes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbxTheatres;
        private System.Windows.Forms.ComboBox cbxFilms;
        private System.Windows.Forms.DateTimePicker dtpShowDate;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTheatre;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnScheduleHelp;
        private System.Windows.Forms.Button btnCloseScheduleHelp;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.ErrorProvider errProvScheduleAdd;
        private System.Windows.Forms.Label lblChooseRow;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}