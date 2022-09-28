
namespace project
{
    partial class frmTime_Allocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTime_Allocation));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimeAllocation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.Button();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.bttnPrevFromTime = new System.Windows.Forms.Button();
            this.lblAddTimeAllocation = new System.Windows.Forms.Label();
            this.lblChangeTimeAllocation = new System.Windows.Forms.Label();
            this.lblDeleteTimeAllocation = new System.Windows.Forms.Label();
            this.gbTime_Allocation = new System.Windows.Forms.GroupBox();
            this.lblMaxTheatreWarning = new System.Windows.Forms.Label();
            this.dgvDisplayTimeAllocations = new System.Windows.Forms.DataGridView();
            this.bttnDeleteTime = new System.Windows.Forms.Button();
            this.bttnUpdateTime = new System.Windows.Forms.Button();
            this.cbTimeID = new System.Windows.Forms.ComboBox();
            this.tbTimeBracket = new System.Windows.Forms.TextBox();
            this.lblTimeBracket = new System.Windows.Forms.Label();
            this.lblTimeID = new System.Windows.Forms.Label();
            this.bttnAddTime = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errProvTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.gbTime_Allocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTimeAllocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblTimeAllocation);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1773, 203);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 127);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimeAllocation
            // 
            this.lblTimeAllocation.AutoSize = true;
            this.lblTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblTimeAllocation.Location = new System.Drawing.Point(251, 47);
            this.lblTimeAllocation.Name = "lblTimeAllocation";
            this.lblTimeAllocation.Size = new System.Drawing.Size(601, 128);
            this.lblTimeAllocation.TabIndex = 3;
            this.lblTimeAllocation.Text = "Time Allocation";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.help_btn);
            this.panel5.Controls.Add(this.closeHelp_btn);
            this.panel5.Controls.Add(this.bttnPrevFromTime);
            this.panel5.Controls.Add(this.lblAddTimeAllocation);
            this.panel5.Controls.Add(this.lblChangeTimeAllocation);
            this.panel5.Controls.Add(this.lblDeleteTimeAllocation);
            this.panel5.Location = new System.Drawing.Point(0, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 718);
            this.panel5.TabIndex = 5;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Purple;
            this.help_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(31, 366);
            this.help_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(185, 64);
            this.help_btn.TabIndex = 13;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.BackColor = System.Drawing.Color.Purple;
            this.closeHelp_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeHelp_btn.ForeColor = System.Drawing.Color.White;
            this.closeHelp_btn.Location = new System.Drawing.Point(32, 366);
            this.closeHelp_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(185, 64);
            this.closeHelp_btn.TabIndex = 12;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // bttnPrevFromTime
            // 
            this.bttnPrevFromTime.BackColor = System.Drawing.Color.Purple;
            this.bttnPrevFromTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnPrevFromTime.ForeColor = System.Drawing.Color.White;
            this.bttnPrevFromTime.Location = new System.Drawing.Point(32, 450);
            this.bttnPrevFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnPrevFromTime.Name = "bttnPrevFromTime";
            this.bttnPrevFromTime.Size = new System.Drawing.Size(184, 61);
            this.bttnPrevFromTime.TabIndex = 7;
            this.bttnPrevFromTime.Text = "Previous";
            this.bttnPrevFromTime.UseVisualStyleBackColor = false;
            this.bttnPrevFromTime.Click += new System.EventHandler(this.bttnPrevFromTime_Click);
            // 
            // lblAddTimeAllocation
            // 
            this.lblAddTimeAllocation.AutoSize = true;
            this.lblAddTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblAddTimeAllocation.Location = new System.Drawing.Point(16, 46);
            this.lblAddTimeAllocation.Name = "lblAddTimeAllocation";
            this.lblAddTimeAllocation.Size = new System.Drawing.Size(149, 48);
            this.lblAddTimeAllocation.TabIndex = 4;
            this.lblAddTimeAllocation.Text = "Add Time ";
            this.lblAddTimeAllocation.Click += new System.EventHandler(this.lblAddTheatre_Click);
            // 
            // lblChangeTimeAllocation
            // 
            this.lblChangeTimeAllocation.AutoSize = true;
            this.lblChangeTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblChangeTimeAllocation.Location = new System.Drawing.Point(12, 103);
            this.lblChangeTimeAllocation.Name = "lblChangeTimeAllocation";
            this.lblChangeTimeAllocation.Size = new System.Drawing.Size(204, 48);
            this.lblChangeTimeAllocation.TabIndex = 5;
            this.lblChangeTimeAllocation.Text = "Change Times";
            this.lblChangeTimeAllocation.Click += new System.EventHandler(this.lblChangeTheatre_Click);
            // 
            // lblDeleteTimeAllocation
            // 
            this.lblDeleteTimeAllocation.AutoSize = true;
            this.lblDeleteTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTimeAllocation.Location = new System.Drawing.Point(16, 163);
            this.lblDeleteTimeAllocation.Name = "lblDeleteTimeAllocation";
            this.lblDeleteTimeAllocation.Size = new System.Drawing.Size(176, 48);
            this.lblDeleteTimeAllocation.TabIndex = 6;
            this.lblDeleteTimeAllocation.Text = "Delete Time";
            this.lblDeleteTimeAllocation.Click += new System.EventHandler(this.lblDeleteTheatre_Click);
            // 
            // gbTime_Allocation
            // 
            this.gbTime_Allocation.Controls.Add(this.lblMaxTheatreWarning);
            this.gbTime_Allocation.Controls.Add(this.dgvDisplayTimeAllocations);
            this.gbTime_Allocation.Controls.Add(this.bttnDeleteTime);
            this.gbTime_Allocation.Controls.Add(this.bttnUpdateTime);
            this.gbTime_Allocation.Controls.Add(this.cbTimeID);
            this.gbTime_Allocation.Controls.Add(this.tbTimeBracket);
            this.gbTime_Allocation.Controls.Add(this.lblTimeBracket);
            this.gbTime_Allocation.Controls.Add(this.lblTimeID);
            this.gbTime_Allocation.Controls.Add(this.bttnAddTime);
            this.gbTime_Allocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.gbTime_Allocation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbTime_Allocation.Location = new System.Drawing.Point(273, 207);
            this.gbTime_Allocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTime_Allocation.Name = "gbTime_Allocation";
            this.gbTime_Allocation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTime_Allocation.Size = new System.Drawing.Size(1084, 525);
            this.gbTime_Allocation.TabIndex = 7;
            this.gbTime_Allocation.TabStop = false;
            this.gbTime_Allocation.Text = "Current Time Allocations";
            this.gbTime_Allocation.Enter += new System.EventHandler(this.gbTime_Allocation_Enter);
            // 
            // lblMaxTheatreWarning
            // 
            this.lblMaxTheatreWarning.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F);
            this.lblMaxTheatreWarning.Location = new System.Drawing.Point(705, 309);
            this.lblMaxTheatreWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTheatreWarning.Name = "lblMaxTheatreWarning";
            this.lblMaxTheatreWarning.Size = new System.Drawing.Size(347, 103);
            this.lblMaxTheatreWarning.TabIndex = 14;
            this.lblMaxTheatreWarning.Text = "*The maximum number of time slots is 3";
            // 
            // dgvDisplayTimeAllocations
            // 
            this.dgvDisplayTimeAllocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayTimeAllocations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayTimeAllocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTimeAllocations.Location = new System.Drawing.Point(595, 80);
            this.dgvDisplayTimeAllocations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDisplayTimeAllocations.Name = "dgvDisplayTimeAllocations";
            this.dgvDisplayTimeAllocations.RowHeadersWidth = 51;
            this.dgvDisplayTimeAllocations.Size = new System.Drawing.Size(439, 225);
            this.dgvDisplayTimeAllocations.TabIndex = 8;
            // 
            // bttnDeleteTime
            // 
            this.bttnDeleteTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnDeleteTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnDeleteTime.ForeColor = System.Drawing.Color.White;
            this.bttnDeleteTime.Location = new System.Drawing.Point(813, 428);
            this.bttnDeleteTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnDeleteTime.Name = "bttnDeleteTime";
            this.bttnDeleteTime.Size = new System.Drawing.Size(221, 62);
            this.bttnDeleteTime.TabIndex = 7;
            this.bttnDeleteTime.Text = "Delete Time";
            this.bttnDeleteTime.UseVisualStyleBackColor = false;
            this.bttnDeleteTime.Click += new System.EventHandler(this.bttnDeleteTheatre_Click);
            // 
            // bttnUpdateTime
            // 
            this.bttnUpdateTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnUpdateTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnUpdateTime.ForeColor = System.Drawing.Color.White;
            this.bttnUpdateTime.Location = new System.Drawing.Point(813, 428);
            this.bttnUpdateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnUpdateTime.Name = "bttnUpdateTime";
            this.bttnUpdateTime.Size = new System.Drawing.Size(221, 62);
            this.bttnUpdateTime.TabIndex = 6;
            this.bttnUpdateTime.Text = "Update Time";
            this.bttnUpdateTime.UseVisualStyleBackColor = false;
            this.bttnUpdateTime.Click += new System.EventHandler(this.bttnUpdateTheatre_Click);
            // 
            // cbTimeID
            // 
            this.cbTimeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.cbTimeID.FormattingEnabled = true;
            this.cbTimeID.Location = new System.Drawing.Point(307, 80);
            this.cbTimeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTimeID.Name = "cbTimeID";
            this.cbTimeID.Size = new System.Drawing.Size(196, 49);
            this.cbTimeID.TabIndex = 5;
            // 
            // tbTimeBracket
            // 
            this.tbTimeBracket.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.tbTimeBracket.Location = new System.Drawing.Point(307, 160);
            this.tbTimeBracket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimeBracket.Name = "tbTimeBracket";
            this.tbTimeBracket.Size = new System.Drawing.Size(196, 48);
            this.tbTimeBracket.TabIndex = 4;
            this.tbTimeBracket.TextChanged += new System.EventHandler(this.tbTimeBracket_TextChanged);
            // 
            // lblTimeBracket
            // 
            this.lblTimeBracket.AutoSize = true;
            this.lblTimeBracket.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lblTimeBracket.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTimeBracket.Location = new System.Drawing.Point(46, 157);
            this.lblTimeBracket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeBracket.Name = "lblTimeBracket";
            this.lblTimeBracket.Size = new System.Drawing.Size(195, 48);
            this.lblTimeBracket.TabIndex = 3;
            this.lblTimeBracket.Text = "Time Bracket";
            // 
            // lblTimeID
            // 
            this.lblTimeID.AutoSize = true;
            this.lblTimeID.BackColor = System.Drawing.Color.White;
            this.lblTimeID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lblTimeID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTimeID.Location = new System.Drawing.Point(46, 77);
            this.lblTimeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeID.Name = "lblTimeID";
            this.lblTimeID.Size = new System.Drawing.Size(116, 48);
            this.lblTimeID.TabIndex = 2;
            this.lblTimeID.Text = "Time ID";
            // 
            // bttnAddTime
            // 
            this.bttnAddTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnAddTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnAddTime.ForeColor = System.Drawing.Color.White;
            this.bttnAddTime.Location = new System.Drawing.Point(813, 428);
            this.bttnAddTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnAddTime.Name = "bttnAddTime";
            this.bttnAddTime.Size = new System.Drawing.Size(221, 62);
            this.bttnAddTime.TabIndex = 1;
            this.bttnAddTime.Text = "Add Time";
            this.bttnAddTime.UseVisualStyleBackColor = false;
            this.bttnAddTime.Click += new System.EventHandler(this.bttnAddTheatre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(324, 425);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 298);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // errProvTime
            // 
            this.errProvTime.ContainerControl = this;
            // 
            // frmTime_Allocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gbTime_Allocation);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.MinimumSize = new System.Drawing.Size(1388, 782);
            this.Name = "frmTime_Allocation";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbTime_Allocation.ResumeLayout(false);
            this.gbTime_Allocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTimeAllocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTimeAllocation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAddTimeAllocation;
        private System.Windows.Forms.Label lblChangeTimeAllocation;
        private System.Windows.Forms.Label lblDeleteTimeAllocation;
        private System.Windows.Forms.GroupBox gbTime_Allocation;
        private System.Windows.Forms.DataGridView dgvDisplayTimeAllocations;
        private System.Windows.Forms.Button bttnDeleteTime;
        private System.Windows.Forms.Button bttnUpdateTime;
        private System.Windows.Forms.ComboBox cbTimeID;
        private System.Windows.Forms.TextBox tbTimeBracket;
        private System.Windows.Forms.Label lblTimeBracket;
        private System.Windows.Forms.Label lblTimeID;
        private System.Windows.Forms.Button bttnAddTime;
        private System.Windows.Forms.Button bttnPrevFromTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button closeHelp_btn;
        private System.Windows.Forms.ErrorProvider errProvTime;
        private System.Windows.Forms.Label lblMaxTheatreWarning;
    }
}