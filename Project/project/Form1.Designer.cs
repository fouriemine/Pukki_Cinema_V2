
namespace Genre_report
{
    partial class frmRequestReports
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.txtbGenreId = new System.Windows.Forms.TextBox();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.dtgDisplay = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbl_totTicketsSold = new System.Windows.Forms.Label();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gbx_Report = new System.Windows.Forms.GroupBox();
            this.lbl_TotTickets = new System.Windows.Forms.Label();
            this.lbl_finalTickets = new System.Windows.Forms.Label();
            this.btn_GetTotal = new System.Windows.Forms.Button();
            this.dgv_Report = new System.Windows.Forms.DataGridView();
            this.btn_ProcessReport = new System.Windows.Forms.Button();
            this.lbl_DateAccessed = new System.Windows.Forms.Label();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbx_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.LblTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-353, -7);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2472, 267);
            this.panel2.TabIndex = 7;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(1040, 64);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(327, 128);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtbDescription);
            this.groupBox1.Controls.Add(this.txtbGenreId);
            this.groupBox1.Controls.Add(this.comboBoxDescription);
            this.groupBox1.Controls.Add(this.dtgDisplay);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblGenreID);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(177, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Genre";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(861, 453);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 64);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(861, 453);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 64);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(861, 453);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 64);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(204, 143);
            this.txtbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(280, 40);
            this.txtbDescription.TabIndex = 8;
            // 
            // txtbGenreId
            // 
            this.txtbGenreId.Location = new System.Drawing.Point(204, 57);
            this.txtbGenreId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbGenreId.Name = "txtbGenreId";
            this.txtbGenreId.Size = new System.Drawing.Size(280, 40);
            this.txtbGenreId.TabIndex = 7;
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(204, 139);
            this.comboBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(280, 41);
            this.comboBoxDescription.TabIndex = 6;
            // 
            // dtgDisplay
            // 
            this.dtgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplay.Location = new System.Drawing.Point(45, 207);
            this.dtgDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDisplay.Name = "dtgDisplay";
            this.dtgDisplay.RowHeadersWidth = 51;
            this.dtgDisplay.Size = new System.Drawing.Size(795, 228);
            this.dtgDisplay.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 143);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 33);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Location = new System.Drawing.Point(8, 73);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(90, 33);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Genre ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.lbl_totTicketsSold);
            this.panel1.Controls.Add(this.lblAddGenre);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 666);
            this.panel1.TabIndex = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrevious.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(37, 465);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(185, 64);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbl_totTicketsSold
            // 
            this.lbl_totTicketsSold.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totTicketsSold.ForeColor = System.Drawing.Color.White;
            this.lbl_totTicketsSold.Location = new System.Drawing.Point(17, 150);
            this.lbl_totTicketsSold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totTicketsSold.Name = "lbl_totTicketsSold";
            this.lbl_totTicketsSold.Size = new System.Drawing.Size(353, 123);
            this.lbl_totTicketsSold.TabIndex = 6;
            this.lbl_totTicketsSold.Text = "Total Tickets Sold per Time Period";
            this.lbl_totTicketsSold.Click += new System.EventHandler(this.lbl_totTicketsSold_Clicked);
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGenre.ForeColor = System.Drawing.Color.White;
            this.lblAddGenre.Location = new System.Drawing.Point(17, 57);
            this.lblAddGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(296, 48);
            this.lblAddGenre.TabIndex = 5;
            this.lblAddGenre.Text = "Top Six Genre Report";
            this.lblAddGenre.Click += new System.EventHandler(this.lblAddGenre_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 722);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gbx_Report
            // 
            this.gbx_Report.Controls.Add(this.lbl_TotTickets);
            this.gbx_Report.Controls.Add(this.lbl_finalTickets);
            this.gbx_Report.Controls.Add(this.btn_GetTotal);
            this.gbx_Report.Controls.Add(this.dgv_Report);
            this.gbx_Report.Controls.Add(this.btn_ProcessReport);
            this.gbx_Report.Controls.Add(this.lbl_DateAccessed);
            this.gbx_Report.Controls.Add(this.lbl_EndTime);
            this.gbx_Report.Controls.Add(this.lbl_StartTime);
            this.gbx_Report.Controls.Add(this.dtp_End);
            this.gbx_Report.Controls.Add(this.dtp_Start);
            this.gbx_Report.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.gbx_Report.Location = new System.Drawing.Point(383, 283);
            this.gbx_Report.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_Report.Name = "gbx_Report";
            this.gbx_Report.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_Report.Size = new System.Drawing.Size(1367, 636);
            this.gbx_Report.TabIndex = 11;
            this.gbx_Report.TabStop = false;
            this.gbx_Report.Text = "Select the Time Period";
            // 
            // lbl_TotTickets
            // 
            this.lbl_TotTickets.Location = new System.Drawing.Point(1089, 473);
            this.lbl_TotTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotTickets.Name = "lbl_TotTickets";
            this.lbl_TotTickets.Size = new System.Drawing.Size(248, 38);
            this.lbl_TotTickets.TabIndex = 9;
            // 
            // lbl_finalTickets
            // 
            this.lbl_finalTickets.Location = new System.Drawing.Point(583, 473);
            this.lbl_finalTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_finalTickets.Name = "lbl_finalTickets";
            this.lbl_finalTickets.Size = new System.Drawing.Size(499, 38);
            this.lbl_finalTickets.TabIndex = 8;
            // 
            // btn_GetTotal
            // 
            this.btn_GetTotal.Location = new System.Drawing.Point(41, 223);
            this.btn_GetTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GetTotal.Name = "btn_GetTotal";
            this.btn_GetTotal.Size = new System.Drawing.Size(503, 48);
            this.btn_GetTotal.TabIndex = 7;
            this.btn_GetTotal.Text = "Get Total Tickets For Time Period";
            this.btn_GetTotal.UseVisualStyleBackColor = true;
            this.btn_GetTotal.Click += new System.EventHandler(this.btn_GetTotal_Click);
            // 
            // dgv_Report
            // 
            this.dgv_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Report.Location = new System.Drawing.Point(583, 85);
            this.dgv_Report.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Report.Name = "dgv_Report";
            this.dgv_Report.RowHeadersWidth = 51;
            this.dgv_Report.Size = new System.Drawing.Size(755, 379);
            this.dgv_Report.TabIndex = 6;
            // 
            // btn_ProcessReport
            // 
            this.btn_ProcessReport.Location = new System.Drawing.Point(41, 167);
            this.btn_ProcessReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ProcessReport.Name = "btn_ProcessReport";
            this.btn_ProcessReport.Size = new System.Drawing.Size(503, 48);
            this.btn_ProcessReport.TabIndex = 5;
            this.btn_ProcessReport.Text = "Process Report";
            this.btn_ProcessReport.UseVisualStyleBackColor = true;
            this.btn_ProcessReport.Click += new System.EventHandler(this.btn_ProcessReport_Clicked);
            // 
            // lbl_DateAccessed
            // 
            this.lbl_DateAccessed.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F);
            this.lbl_DateAccessed.Location = new System.Drawing.Point(835, 39);
            this.lbl_DateAccessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateAccessed.Name = "lbl_DateAccessed";
            this.lbl_DateAccessed.Size = new System.Drawing.Size(503, 39);
            this.lbl_DateAccessed.TabIndex = 4;
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F);
            this.lbl_EndTime.Location = new System.Drawing.Point(36, 110);
            this.lbl_EndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(86, 29);
            this.lbl_EndTime.TabIndex = 3;
            this.lbl_EndTime.Text = "End Date:";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F);
            this.lbl_StartTime.Location = new System.Drawing.Point(36, 53);
            this.lbl_StartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(97, 29);
            this.lbl_StartTime.TabIndex = 2;
            this.lbl_StartTime.Text = "Start Date:";
            // 
            // dtp_End
            // 
            this.dtp_End.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.5F);
            this.dtp_End.Location = new System.Drawing.Point(235, 102);
            this.dtp_End.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(308, 35);
            this.dtp_End.TabIndex = 1;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13.5F);
            this.dtp_Start.Location = new System.Drawing.Point(235, 46);
            this.dtp_Start.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Start.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtp_Start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_Start.Size = new System.Drawing.Size(308, 35);
            this.dtp_Start.TabIndex = 0;
            // 
            // frmRequestReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 937);
            this.Controls.Add(this.gbx_Report);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRequestReports";
            this.Text = "frmRequestReports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_Report.ResumeLayout(false);
            this.gbx_Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.TextBox txtbGenreId;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private System.Windows.Forms.DataGridView dtgDisplay;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lbl_totTicketsSold;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbx_Report;
        private System.Windows.Forms.Label lbl_DateAccessed;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Button btn_ProcessReport;
        private System.Windows.Forms.DataGridView dgv_Report;
        private System.Windows.Forms.Button btn_GetTotal;
        private System.Windows.Forms.Label lbl_TotTickets;
        private System.Windows.Forms.Label lbl_finalTickets;
    }
}

