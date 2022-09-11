namespace project
{
    partial class frmSellTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellTickets));
            this.panel3 = new System.Windows.Forms.Panel();
            this.sellTickets_lbl = new System.Windows.Forms.Label();
            this.paymentMade_cbx = new System.Windows.Forms.CheckBox();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.tickets_txt = new System.Windows.Forms.TextBox();
            this.numTickets_lbl = new System.Windows.Forms.Label();
            this.filmFilter_gbx = new System.Windows.Forms.GroupBox();
            this.schedule_lbl = new System.Windows.Forms.Label();
            this.scheduleID_cbx = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.sellTicket_btn = new System.Windows.Forms.Button();
            this.datagrid_gbx = new System.Windows.Forms.GroupBox();
            this.help_picbox = new System.Windows.Forms.PictureBox();
            this.selling_dgv = new System.Windows.Forms.DataGridView();
            this.help_btn = new System.Windows.Forms.Button();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.filmFilter_gbx.SuspendLayout();
            this.datagrid_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.sellTickets_lbl);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 203);
            this.panel3.TabIndex = 3;
            // 
            // sellTickets_lbl
            // 
            this.sellTickets_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTickets_lbl.AutoSize = true;
            this.sellTickets_lbl.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F);
            this.sellTickets_lbl.ForeColor = System.Drawing.Color.White;
            this.sellTickets_lbl.Location = new System.Drawing.Point(226, 39);
            this.sellTickets_lbl.Name = "sellTickets_lbl";
            this.sellTickets_lbl.Size = new System.Drawing.Size(374, 103);
            this.sellTickets_lbl.TabIndex = 3;
            this.sellTickets_lbl.Text = "Sell Tickets";
            // 
            // paymentMade_cbx
            // 
            this.paymentMade_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentMade_cbx.AutoSize = true;
            this.paymentMade_cbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.paymentMade_cbx.Location = new System.Drawing.Point(50, 568);
            this.paymentMade_cbx.Name = "paymentMade_cbx";
            this.paymentMade_cbx.Size = new System.Drawing.Size(123, 27);
            this.paymentMade_cbx.TabIndex = 22;
            this.paymentMade_cbx.Text = "Payment made";
            this.paymentMade_cbx.UseVisualStyleBackColor = true;
            this.paymentMade_cbx.CheckedChanged += new System.EventHandler(this.paymentMade_cbx_CheckedChanged);
            // 
            // amount_lbl
            // 
            this.amount_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.amount_lbl.Location = new System.Drawing.Point(45, 506);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(179, 23);
            this.amount_lbl.TabIndex = 21;
            this.amount_lbl.Text = "Amount to be paid:  R 0 .00";
            // 
            // tickets_txt
            // 
            this.tickets_txt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tickets_txt.Location = new System.Drawing.Point(155, 95);
            this.tickets_txt.Name = "tickets_txt";
            this.tickets_txt.Size = new System.Drawing.Size(78, 30);
            this.tickets_txt.TabIndex = 19;
            this.tickets_txt.TextChanged += new System.EventHandler(this.tickets_txt_TextChanged);
            // 
            // numTickets_lbl
            // 
            this.numTickets_lbl.AutoSize = true;
            this.numTickets_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.numTickets_lbl.Location = new System.Drawing.Point(22, 98);
            this.numTickets_lbl.Name = "numTickets_lbl";
            this.numTickets_lbl.Size = new System.Drawing.Size(127, 23);
            this.numTickets_lbl.TabIndex = 18;
            this.numTickets_lbl.Text = "Number of Tickets:";
            // 
            // filmFilter_gbx
            // 
            this.filmFilter_gbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filmFilter_gbx.Controls.Add(this.schedule_lbl);
            this.filmFilter_gbx.Controls.Add(this.scheduleID_cbx);
            this.filmFilter_gbx.Controls.Add(this.numTickets_lbl);
            this.filmFilter_gbx.Controls.Add(this.tickets_txt);
            this.filmFilter_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.filmFilter_gbx.Location = new System.Drawing.Point(23, 232);
            this.filmFilter_gbx.Name = "filmFilter_gbx";
            this.filmFilter_gbx.Size = new System.Drawing.Size(258, 158);
            this.filmFilter_gbx.TabIndex = 20;
            this.filmFilter_gbx.TabStop = false;
            this.filmFilter_gbx.Text = "Tickets Details:";
            // 
            // schedule_lbl
            // 
            this.schedule_lbl.AutoSize = true;
            this.schedule_lbl.Location = new System.Drawing.Point(22, 43);
            this.schedule_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schedule_lbl.Name = "schedule_lbl";
            this.schedule_lbl.Size = new System.Drawing.Size(80, 23);
            this.schedule_lbl.TabIndex = 4;
            this.schedule_lbl.Text = "Schdule_ID:";
            // 
            // scheduleID_cbx
            // 
            this.scheduleID_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scheduleID_cbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.scheduleID_cbx.FormattingEnabled = true;
            this.scheduleID_cbx.Location = new System.Drawing.Point(120, 40);
            this.scheduleID_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleID_cbx.Name = "scheduleID_cbx";
            this.scheduleID_cbx.Size = new System.Drawing.Size(113, 31);
            this.scheduleID_cbx.TabIndex = 3;
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.clear_btn.Location = new System.Drawing.Point(1162, 695);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(150, 58);
            this.clear_btn.TabIndex = 25;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // sellTicket_btn
            // 
            this.sellTicket_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTicket_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sellTicket_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.sellTicket_btn.Location = new System.Drawing.Point(391, 695);
            this.sellTicket_btn.Name = "sellTicket_btn";
            this.sellTicket_btn.Size = new System.Drawing.Size(150, 58);
            this.sellTicket_btn.TabIndex = 23;
            this.sellTicket_btn.Text = "Sell Ticket";
            this.sellTicket_btn.UseVisualStyleBackColor = false;
            this.sellTicket_btn.Click += new System.EventHandler(this.sellTicket_btn_Click);
            // 
            // datagrid_gbx
            // 
            this.datagrid_gbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid_gbx.Controls.Add(this.help_picbox);
            this.datagrid_gbx.Controls.Add(this.selling_dgv);
            this.datagrid_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.datagrid_gbx.Location = new System.Drawing.Point(287, 232);
            this.datagrid_gbx.Name = "datagrid_gbx";
            this.datagrid_gbx.Size = new System.Drawing.Size(1025, 457);
            this.datagrid_gbx.TabIndex = 26;
            this.datagrid_gbx.TabStop = false;
            this.datagrid_gbx.Text = "Current Films:";
            // 
            // help_picbox
            // 
            this.help_picbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_picbox.BackColor = System.Drawing.SystemColors.Control;
            this.help_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_picbox.BackgroundImage")));
            this.help_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_picbox.InitialImage = null;
            this.help_picbox.Location = new System.Drawing.Point(0, -19);
            this.help_picbox.Name = "help_picbox";
            this.help_picbox.Size = new System.Drawing.Size(786, 448);
            this.help_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.help_picbox.TabIndex = 1;
            this.help_picbox.TabStop = false;
            // 
            // selling_dgv
            // 
            this.selling_dgv.AllowUserToAddRows = false;
            this.selling_dgv.AllowUserToDeleteRows = false;
            this.selling_dgv.AllowUserToOrderColumns = true;
            this.selling_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selling_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.selling_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selling_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selling_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selling_dgv.Location = new System.Drawing.Point(6, 35);
            this.selling_dgv.Name = "selling_dgv";
            this.selling_dgv.ReadOnly = true;
            this.selling_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.selling_dgv.Size = new System.Drawing.Size(1013, 422);
            this.selling_dgv.TabIndex = 0;
            this.selling_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selling_dgv_CellContentClick);
            // 
            // help_btn
            // 
            this.help_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.help_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.help_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.help_btn.Location = new System.Drawing.Point(23, 695);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(150, 58);
            this.help_btn.TabIndex = 4;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeHelp_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.closeHelp_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeHelp_btn.Location = new System.Drawing.Point(23, 695);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(150, 58);
            this.closeHelp_btn.TabIndex = 27;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // frmSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.closeHelp_btn);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.sellTicket_btn);
            this.Controls.Add(this.datagrid_gbx);
            this.Controls.Add(this.paymentMade_cbx);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.filmFilter_gbx);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSellTickets";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmSellTickets_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.filmFilter_gbx.ResumeLayout(false);
            this.filmFilter_gbx.PerformLayout();
            this.datagrid_gbx.ResumeLayout(false);
            this.datagrid_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sellTickets_lbl;
        private System.Windows.Forms.CheckBox paymentMade_cbx;
        private System.Windows.Forms.Label amount_lbl;
        private System.Windows.Forms.TextBox tickets_txt;
        private System.Windows.Forms.Label numTickets_lbl;
        private System.Windows.Forms.GroupBox filmFilter_gbx;
        private System.Windows.Forms.Label schedule_lbl;
        private System.Windows.Forms.ComboBox scheduleID_cbx;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button sellTicket_btn;
        private System.Windows.Forms.GroupBox datagrid_gbx;
        private System.Windows.Forms.DataGridView selling_dgv;
        private System.Windows.Forms.PictureBox help_picbox;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button closeHelp_btn;
    }
}