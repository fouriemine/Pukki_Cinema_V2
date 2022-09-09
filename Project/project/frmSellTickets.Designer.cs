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
            this.selling_dgv = new System.Windows.Forms.DataGridView();
            this.sellTicket_btn = new System.Windows.Forms.Button();
            this.datagrid_gbx = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.filmFilter_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).BeginInit();
            this.datagrid_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
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
            this.sellTickets_lbl.AutoSize = true;
            this.sellTickets_lbl.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F);
            this.sellTickets_lbl.ForeColor = System.Drawing.Color.White;
            this.sellTickets_lbl.Location = new System.Drawing.Point(226, 39);
            this.sellTickets_lbl.Name = "sellTickets_lbl";
            this.sellTickets_lbl.Size = new System.Drawing.Size(464, 128);
            this.sellTickets_lbl.TabIndex = 3;
            this.sellTickets_lbl.Text = "Sell Tickets";
            // 
            // paymentMade_cbx
            // 
            this.paymentMade_cbx.AutoSize = true;
            this.paymentMade_cbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.paymentMade_cbx.Location = new System.Drawing.Point(61, 685);
            this.paymentMade_cbx.Name = "paymentMade_cbx";
            this.paymentMade_cbx.Size = new System.Drawing.Size(152, 33);
            this.paymentMade_cbx.TabIndex = 22;
            this.paymentMade_cbx.Text = "Payment made";
            this.paymentMade_cbx.UseVisualStyleBackColor = true;
            this.paymentMade_cbx.CheckedChanged += new System.EventHandler(this.paymentMade_cbx_CheckedChanged);
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.amount_lbl.Location = new System.Drawing.Point(57, 633);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(226, 29);
            this.amount_lbl.TabIndex = 21;
            this.amount_lbl.Text = "Amount to be paid:  R 0 .00";
            // 
            // tickets_txt
            // 
            this.tickets_txt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tickets_txt.Location = new System.Drawing.Point(235, 123);
            this.tickets_txt.Name = "tickets_txt";
            this.tickets_txt.Size = new System.Drawing.Size(100, 36);
            this.tickets_txt.TabIndex = 19;
            this.tickets_txt.TextChanged += new System.EventHandler(this.tickets_txt_TextChanged);
            // 
            // numTickets_lbl
            // 
            this.numTickets_lbl.AutoSize = true;
            this.numTickets_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.numTickets_lbl.Location = new System.Drawing.Point(22, 130);
            this.numTickets_lbl.Name = "numTickets_lbl";
            this.numTickets_lbl.Size = new System.Drawing.Size(161, 29);
            this.numTickets_lbl.TabIndex = 18;
            this.numTickets_lbl.Text = "Number of Tickets:";
            // 
            // filmFilter_gbx
            // 
            this.filmFilter_gbx.Controls.Add(this.schedule_lbl);
            this.filmFilter_gbx.Controls.Add(this.scheduleID_cbx);
            this.filmFilter_gbx.Controls.Add(this.numTickets_lbl);
            this.filmFilter_gbx.Controls.Add(this.tickets_txt);
            this.filmFilter_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.filmFilter_gbx.Location = new System.Drawing.Point(35, 232);
            this.filmFilter_gbx.Name = "filmFilter_gbx";
            this.filmFilter_gbx.Size = new System.Drawing.Size(341, 183);
            this.filmFilter_gbx.TabIndex = 20;
            this.filmFilter_gbx.TabStop = false;
            this.filmFilter_gbx.Text = "Film Details";
            // 
            // schedule_lbl
            // 
            this.schedule_lbl.AutoSize = true;
            this.schedule_lbl.Location = new System.Drawing.Point(22, 43);
            this.schedule_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schedule_lbl.Name = "schedule_lbl";
            this.schedule_lbl.Size = new System.Drawing.Size(103, 29);
            this.schedule_lbl.TabIndex = 4;
            this.schedule_lbl.Text = "Schdule_ID:";
            // 
            // scheduleID_cbx
            // 
            this.scheduleID_cbx.FormattingEnabled = true;
            this.scheduleID_cbx.Location = new System.Drawing.Point(165, 40);
            this.scheduleID_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleID_cbx.Name = "scheduleID_cbx";
            this.scheduleID_cbx.Size = new System.Drawing.Size(169, 37);
            this.scheduleID_cbx.TabIndex = 3;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.clear_btn.Location = new System.Drawing.Point(1144, 695);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(150, 58);
            this.clear_btn.TabIndex = 25;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // selling_dgv
            // 
            this.selling_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selling_dgv.Location = new System.Drawing.Point(16, 40);
            this.selling_dgv.Name = "selling_dgv";
            this.selling_dgv.RowHeadersWidth = 51;
            this.selling_dgv.Size = new System.Drawing.Size(887, 397);
            this.selling_dgv.TabIndex = 24;
            // 
            // sellTicket_btn
            // 
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
            this.datagrid_gbx.Controls.Add(this.selling_dgv);
            this.datagrid_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.datagrid_gbx.Location = new System.Drawing.Point(391, 232);
            this.datagrid_gbx.Name = "datagrid_gbx";
            this.datagrid_gbx.Size = new System.Drawing.Size(921, 457);
            this.datagrid_gbx.TabIndex = 26;
            this.datagrid_gbx.TabStop = false;
            this.datagrid_gbx.Text = "Current Films:";
            // 
            // frmSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 761);
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
            this.Load += new System.EventHandler(this.frmSellTickets_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.filmFilter_gbx.ResumeLayout(false);
            this.filmFilter_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).EndInit();
            this.datagrid_gbx.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView selling_dgv;
        private System.Windows.Forms.Button sellTicket_btn;
        private System.Windows.Forms.GroupBox datagrid_gbx;
    }
}