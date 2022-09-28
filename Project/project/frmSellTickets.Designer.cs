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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellTickets));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sellTickets_lbl = new System.Windows.Forms.Label();
            this.paymentMade_cbx = new System.Windows.Forms.CheckBox();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.numTickets_lbl = new System.Windows.Forms.Label();
            this.filmFilter_gbx = new System.Windows.Forms.GroupBox();
            this.tickets_txt = new System.Windows.Forms.NumericUpDown();
            this.schedule_lbl = new System.Windows.Forms.Label();
            this.scheduleID_cbx = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.sellTicket_btn = new System.Windows.Forms.Button();
            this.datagrid_gbx = new System.Windows.Forms.GroupBox();
            this.selling_dgv = new System.Windows.Forms.DataGridView();
            this.help_picbox = new System.Windows.Forms.PictureBox();
            this.help_btn = new System.Windows.Forms.Button();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.tickets_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.schedule_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filmFilter_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_txt)).BeginInit();
            this.datagrid_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.sellTickets_lbl);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 165);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 159);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sellTickets_lbl
            // 
            this.sellTickets_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellTickets_lbl.AutoSize = true;
            this.sellTickets_lbl.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F);
            this.sellTickets_lbl.ForeColor = System.Drawing.Color.White;
            this.sellTickets_lbl.Location = new System.Drawing.Point(216, 22);
            this.sellTickets_lbl.Name = "sellTickets_lbl";
            this.sellTickets_lbl.Size = new System.Drawing.Size(465, 128);
            this.sellTickets_lbl.TabIndex = 3;
            this.sellTickets_lbl.Text = "Sell Tickets";
            // 
            // paymentMade_cbx
            // 
            this.paymentMade_cbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentMade_cbx.AutoSize = true;
            this.paymentMade_cbx.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.paymentMade_cbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.paymentMade_cbx.Location = new System.Drawing.Point(46, 481);
            this.paymentMade_cbx.Name = "paymentMade_cbx";
            this.paymentMade_cbx.Size = new System.Drawing.Size(185, 40);
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
            this.amount_lbl.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.amount_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.amount_lbl.Location = new System.Drawing.Point(41, 421);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(276, 36);
            this.amount_lbl.TabIndex = 21;
            this.amount_lbl.Text = "Amount to be paid:  R 0 .00";
            // 
            // numTickets_lbl
            // 
            this.numTickets_lbl.AutoSize = true;
            this.numTickets_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.numTickets_lbl.Location = new System.Drawing.Point(22, 98);
            this.numTickets_lbl.Name = "numTickets_lbl";
            this.numTickets_lbl.Size = new System.Drawing.Size(198, 36);
            this.numTickets_lbl.TabIndex = 18;
            this.numTickets_lbl.Text = "Number of Tickets:";
            // 
            // filmFilter_gbx
            // 
            this.filmFilter_gbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filmFilter_gbx.Controls.Add(this.tickets_txt);
            this.filmFilter_gbx.Controls.Add(this.schedule_lbl);
            this.filmFilter_gbx.Controls.Add(this.scheduleID_cbx);
            this.filmFilter_gbx.Controls.Add(this.numTickets_lbl);
            this.filmFilter_gbx.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.filmFilter_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.filmFilter_gbx.Location = new System.Drawing.Point(19, 227);
            this.filmFilter_gbx.Name = "filmFilter_gbx";
            this.filmFilter_gbx.Size = new System.Drawing.Size(284, 174);
            this.filmFilter_gbx.TabIndex = 20;
            this.filmFilter_gbx.TabStop = false;
            this.filmFilter_gbx.Text = "Tickets Details:";
            // 
            // tickets_txt
            // 
            this.tickets_txt.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickets_txt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tickets_txt.Location = new System.Drawing.Point(189, 96);
            this.tickets_txt.Name = "tickets_txt";
            this.tickets_txt.ReadOnly = true;
            this.tickets_txt.Size = new System.Drawing.Size(79, 44);
            this.tickets_txt.TabIndex = 28;
            this.tickets_txt.ValueChanged += new System.EventHandler(this.tickets_txt_ValueChanged);
            // 
            // schedule_lbl
            // 
            this.schedule_lbl.AutoSize = true;
            this.schedule_lbl.Location = new System.Drawing.Point(22, 43);
            this.schedule_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schedule_lbl.Name = "schedule_lbl";
            this.schedule_lbl.Size = new System.Drawing.Size(128, 36);
            this.schedule_lbl.TabIndex = 4;
            this.schedule_lbl.Text = "Schdule_ID:";
            // 
            // scheduleID_cbx
            // 
            this.scheduleID_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scheduleID_cbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.scheduleID_cbx.FormattingEnabled = true;
            this.scheduleID_cbx.Location = new System.Drawing.Point(155, 40);
            this.scheduleID_cbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleID_cbx.Name = "scheduleID_cbx";
            this.scheduleID_cbx.Size = new System.Drawing.Size(113, 44);
            this.scheduleID_cbx.TabIndex = 3;
            this.scheduleID_cbx.SelectedIndexChanged += new System.EventHandler(this.scheduleID_cbx_SelectedIndexChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.clear_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.clear_btn.Location = new System.Drawing.Point(311, 687);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(136, 44);
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
            this.sellTicket_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.sellTicket_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.sellTicket_btn.Location = new System.Drawing.Point(1224, 687);
            this.sellTicket_btn.Name = "sellTicket_btn";
            this.sellTicket_btn.Size = new System.Drawing.Size(136, 44);
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
            this.datagrid_gbx.Controls.Add(this.selling_dgv);
            this.datagrid_gbx.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.datagrid_gbx.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.datagrid_gbx.Location = new System.Drawing.Point(332, 227);
            this.datagrid_gbx.Name = "datagrid_gbx";
            this.datagrid_gbx.Size = new System.Drawing.Size(1028, 430);
            this.datagrid_gbx.TabIndex = 26;
            this.datagrid_gbx.TabStop = false;
            this.datagrid_gbx.Text = "Current Films:";
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
            this.selling_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.selling_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selling_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selling_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selling_dgv.Location = new System.Drawing.Point(20, 35);
            this.selling_dgv.Name = "selling_dgv";
            this.selling_dgv.ReadOnly = true;
            this.selling_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.selling_dgv.Size = new System.Drawing.Size(990, 379);
            this.selling_dgv.TabIndex = 0;
            this.selling_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selling_dgv_CellContentClick);
            // 
            // help_picbox
            // 
            this.help_picbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_picbox.BackColor = System.Drawing.SystemColors.Control;
            this.help_picbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_picbox.BackgroundImage")));
            this.help_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_picbox.InitialImage = null;
            this.help_picbox.Location = new System.Drawing.Point(562, 271);
            this.help_picbox.Name = "help_picbox";
            this.help_picbox.Size = new System.Drawing.Size(510, 419);
            this.help_picbox.TabIndex = 1;
            this.help_picbox.TabStop = false;
            // 
            // help_btn
            // 
            this.help_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.help_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.help_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.help_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.help_btn.Location = new System.Drawing.Point(66, 687);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(136, 44);
            this.help_btn.TabIndex = 4;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeHelp_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.closeHelp_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.closeHelp_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeHelp_btn.Location = new System.Drawing.Point(66, 687);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(136, 44);
            this.closeHelp_btn.TabIndex = 27;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // tickets_errorProvider
            // 
            this.tickets_errorProvider.ContainerControl = this;
            // 
            // schedule_errorProvider
            // 
            this.schedule_errorProvider.ContainerControl = this;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(847, 185);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(513, 44);
            this.search_txt.TabIndex = 30;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_lbl
            // 
            this.search_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_lbl.AutoSize = true;
            this.search_lbl.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.search_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.search_lbl.Location = new System.Drawing.Point(640, 188);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(201, 36);
            this.search_lbl.TabIndex = 32;
            this.search_lbl.Text = "Search Movie Title:";
            // 
            // frmSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.help_picbox);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_txt);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmSellTickets";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmSellTickets_Load);
            this.Shown += new System.EventHandler(this.frmSellTickets_Shown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filmFilter_gbx.ResumeLayout(false);
            this.filmFilter_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_txt)).EndInit();
            this.datagrid_gbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selling_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sellTickets_lbl;
        private System.Windows.Forms.CheckBox paymentMade_cbx;
        private System.Windows.Forms.Label amount_lbl;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider tickets_errorProvider;
        private System.Windows.Forms.ErrorProvider schedule_errorProvider;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown tickets_txt;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
    }
}