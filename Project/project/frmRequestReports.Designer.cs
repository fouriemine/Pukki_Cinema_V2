
namespace project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestReports));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.bl_ReportTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_GenreReport = new System.Windows.Forms.Label();
            this.gbx_Info = new System.Windows.Forms.GroupBox();
            this.lbl_TotTickets = new System.Windows.Forms.Label();
            this.lbl_TotTicketTitle = new System.Windows.Forms.Label();
            this.btn_GetOther = new System.Windows.Forms.Button();
            this.btn_ProcessReport = new System.Windows.Forms.Button();
            this.lbl_DateAccessed = new System.Windows.Forms.Label();
            this.dgv_ReportView = new System.Windows.Forms.DataGridView();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbx_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Purple;
            this.pnl_Header.Controls.Add(this.pictureBox1);
            this.pnl_Header.Controls.Add(this.bl_ReportTitle);
            this.pnl_Header.Location = new System.Drawing.Point(1, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1345, 165);
            this.pnl_Header.TabIndex = 0;
            // 
            // bl_ReportTitle
            // 
            this.bl_ReportTitle.AutoSize = true;
            this.bl_ReportTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 63.75F);
            this.bl_ReportTitle.ForeColor = System.Drawing.Color.White;
            this.bl_ReportTitle.Location = new System.Drawing.Point(255, 25);
            this.bl_ReportTitle.Name = "bl_ReportTitle";
            this.bl_ReportTitle.Size = new System.Drawing.Size(259, 103);
            this.bl_ReportTitle.TabIndex = 0;
            this.bl_ReportTitle.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btn_Previous);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_GenreReport);
            this.panel1.Location = new System.Drawing.Point(1, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 625);
            this.panel1.TabIndex = 1;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.Purple;
            this.btn_Previous.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Location = new System.Drawing.Point(19, 547);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(208, 53);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 106);
            this.label1.TabIndex = 6;
            this.label1.Text = "Get Tickets Sold per Time Period";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.lbl_totTicketsSold_Clicked);
            // 
            // lbl_GenreReport
            // 
            this.lbl_GenreReport.AutoSize = true;
            this.lbl_GenreReport.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GenreReport.ForeColor = System.Drawing.Color.White;
            this.lbl_GenreReport.Location = new System.Drawing.Point(44, 92);
            this.lbl_GenreReport.Name = "lbl_GenreReport";
            this.lbl_GenreReport.Size = new System.Drawing.Size(150, 39);
            this.lbl_GenreReport.TabIndex = 5;
            this.lbl_GenreReport.Text = "Top 6 Genres";
            this.lbl_GenreReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GenreReport.Click += new System.EventHandler(this.lblGenre_Report_Click);
            // 
            // gbx_Info
            // 
            this.gbx_Info.Controls.Add(this.lbl_TotTickets);
            this.gbx_Info.Controls.Add(this.lbl_TotTicketTitle);
            this.gbx_Info.Controls.Add(this.btn_GetOther);
            this.gbx_Info.Controls.Add(this.btn_ProcessReport);
            this.gbx_Info.Controls.Add(this.lbl_DateAccessed);
            this.gbx_Info.Controls.Add(this.dgv_ReportView);
            this.gbx_Info.Controls.Add(this.dtp_End);
            this.gbx_Info.Controls.Add(this.dtp_Start);
            this.gbx_Info.Controls.Add(this.lbl_EndTime);
            this.gbx_Info.Controls.Add(this.lbl_StartTime);
            this.gbx_Info.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.gbx_Info.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbx_Info.Location = new System.Drawing.Point(274, 240);
            this.gbx_Info.Name = "gbx_Info";
            this.gbx_Info.Size = new System.Drawing.Size(1071, 689);
            this.gbx_Info.TabIndex = 2;
            this.gbx_Info.TabStop = false;
            // 
            // lbl_TotTickets
            // 
            this.lbl_TotTickets.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_TotTickets.Location = new System.Drawing.Point(876, 339);
            this.lbl_TotTickets.Name = "lbl_TotTickets";
            this.lbl_TotTickets.Size = new System.Drawing.Size(136, 106);
            this.lbl_TotTickets.TabIndex = 9;
            // 
            // lbl_TotTicketTitle
            // 
            this.lbl_TotTicketTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_TotTicketTitle.Location = new System.Drawing.Point(525, 339);
            this.lbl_TotTicketTitle.Name = "lbl_TotTicketTitle";
            this.lbl_TotTicketTitle.Size = new System.Drawing.Size(305, 106);
            this.lbl_TotTicketTitle.TabIndex = 8;
            // 
            // btn_GetOther
            // 
            this.btn_GetOther.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_GetOther.ForeColor = System.Drawing.Color.White;
            this.btn_GetOther.Location = new System.Drawing.Point(48, 320);
            this.btn_GetOther.Name = "btn_GetOther";
            this.btn_GetOther.Size = new System.Drawing.Size(437, 46);
            this.btn_GetOther.TabIndex = 7;
            this.btn_GetOther.UseVisualStyleBackColor = false;
            this.btn_GetOther.Click += new System.EventHandler(this.btn_GetOther_Click);
            // 
            // btn_ProcessReport
            // 
            this.btn_ProcessReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ProcessReport.ForeColor = System.Drawing.Color.White;
            this.btn_ProcessReport.Location = new System.Drawing.Point(48, 256);
            this.btn_ProcessReport.Name = "btn_ProcessReport";
            this.btn_ProcessReport.Size = new System.Drawing.Size(437, 46);
            this.btn_ProcessReport.TabIndex = 6;
            this.btn_ProcessReport.UseVisualStyleBackColor = false;
            this.btn_ProcessReport.Click += new System.EventHandler(this.btn_ProcessReport_Clicked);
            // 
            // lbl_DateAccessed
            // 
            this.lbl_DateAccessed.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_DateAccessed.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_DateAccessed.Location = new System.Drawing.Point(525, 29);
            this.lbl_DateAccessed.Name = "lbl_DateAccessed";
            this.lbl_DateAccessed.Size = new System.Drawing.Size(487, 47);
            this.lbl_DateAccessed.TabIndex = 5;
            // 
            // dgv_ReportView
            // 
            this.dgv_ReportView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ReportView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReportView.Location = new System.Drawing.Point(529, 79);
            this.dgv_ReportView.Name = "dgv_ReportView";
            this.dgv_ReportView.RowHeadersWidth = 51;
            this.dgv_ReportView.RowTemplate.Height = 24;
            this.dgv_ReportView.Size = new System.Drawing.Size(483, 255);
            this.dgv_ReportView.TabIndex = 4;
            // 
            // dtp_End
            // 
            this.dtp_End.CalendarFont = new System.Drawing.Font("Bahnschrift Light Condensed", 13F);
            this.dtp_End.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13F);
            this.dtp_End.Location = new System.Drawing.Point(202, 141);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(214, 28);
            this.dtp_End.TabIndex = 3;
            // 
            // dtp_Start
            // 
            this.dtp_Start.CalendarFont = new System.Drawing.Font("Bahnschrift Light Condensed", 13F);
            this.dtp_Start.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13F);
            this.dtp_Start.Location = new System.Drawing.Point(202, 48);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(214, 28);
            this.dtp_Start.TabIndex = 2;
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_EndTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_EndTime.Location = new System.Drawing.Point(41, 132);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(113, 39);
            this.lbl_EndTime.TabIndex = 1;
            this.lbl_EndTime.Text = "End Date:";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lbl_StartTime.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_StartTime.Location = new System.Drawing.Point(41, 48);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(128, 39);
            this.lbl_StartTime.TabIndex = 0;
            this.lbl_StartTime.Text = "Start Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 103);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmRequestReports
            // 
            this.ClientSize = new System.Drawing.Size(1359, 787);
            this.Controls.Add(this.gbx_Info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1375, 826);
            this.MinimumSize = new System.Drawing.Size(1375, 826);
            this.Name = "frmRequestReports";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_Info.ResumeLayout(false);
            this.gbx_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label bl_ReportTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbx_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_GenreReport;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label lbl_DateAccessed;
        private System.Windows.Forms.DataGridView dgv_ReportView;
        private System.Windows.Forms.Label lbl_TotTickets;
        private System.Windows.Forms.Label lbl_TotTicketTitle;
        private System.Windows.Forms.Button btn_GetOther;
        private System.Windows.Forms.Button btn_ProcessReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}