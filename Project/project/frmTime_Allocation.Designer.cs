
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTimeAllocation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAddTimeAllocation = new System.Windows.Forms.Label();
            this.lblChangeTimeAllocation = new System.Windows.Forms.Label();
            this.lblDeleteTimeAllocation = new System.Windows.Forms.Label();
            this.gbTime_Allocation = new System.Windows.Forms.GroupBox();
            this.lblMaxNumberValidation = new System.Windows.Forms.Label();
            this.dgvDisplayTimeAllocvations = new System.Windows.Forms.DataGridView();
            this.bttnDeleteTime = new System.Windows.Forms.Button();
            this.bttnUpdateTime = new System.Windows.Forms.Button();
            this.cbTimeID = new System.Windows.Forms.ComboBox();
            this.tbTimeBracket = new System.Windows.Forms.TextBox();
            this.lblTimeBracket = new System.Windows.Forms.Label();
            this.lblTimeID = new System.Windows.Forms.Label();
            this.bttnAddTime = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbTime_Allocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTimeAllocvations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.lblTimeAllocation);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 203);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // lblTimeAllocation
            // 
            this.lblTimeAllocation.AutoSize = true;
            this.lblTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblTimeAllocation.Location = new System.Drawing.Point(132, 44);
            this.lblTimeAllocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeAllocation.Name = "lblTimeAllocation";
            this.lblTimeAllocation.Size = new System.Drawing.Size(771, 103);
            this.lblTimeAllocation.TabIndex = 3;
            this.lblTimeAllocation.Text = "Maintain Time Allocation";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.lblAddTimeAllocation);
            this.panel5.Controls.Add(this.lblChangeTimeAllocation);
            this.panel5.Controls.Add(this.lblDeleteTimeAllocation);
            this.panel5.Location = new System.Drawing.Point(3, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 551);
            this.panel5.TabIndex = 5;
            // 
            // lblAddTimeAllocation
            // 
            this.lblAddTimeAllocation.AutoSize = true;
            this.lblAddTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblAddTimeAllocation.Location = new System.Drawing.Point(2, 90);
            this.lblAddTimeAllocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTimeAllocation.Name = "lblAddTimeAllocation";
            this.lblAddTimeAllocation.Size = new System.Drawing.Size(119, 39);
            this.lblAddTimeAllocation.TabIndex = 4;
            this.lblAddTimeAllocation.Text = "Add Time ";
            this.lblAddTimeAllocation.Click += new System.EventHandler(this.lblAddTheatre_Click);
            // 
            // lblChangeTimeAllocation
            // 
            this.lblChangeTimeAllocation.AutoSize = true;
            this.lblChangeTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblChangeTimeAllocation.Location = new System.Drawing.Point(2, 147);
            this.lblChangeTimeAllocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeTimeAllocation.Name = "lblChangeTimeAllocation";
            this.lblChangeTimeAllocation.Size = new System.Drawing.Size(163, 39);
            this.lblChangeTimeAllocation.TabIndex = 5;
            this.lblChangeTimeAllocation.Text = "Change Times";
            this.lblChangeTimeAllocation.Click += new System.EventHandler(this.lblChangeTheatre_Click);
            // 
            // lblDeleteTimeAllocation
            // 
            this.lblDeleteTimeAllocation.AutoSize = true;
            this.lblDeleteTimeAllocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTimeAllocation.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTimeAllocation.Location = new System.Drawing.Point(2, 207);
            this.lblDeleteTimeAllocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteTimeAllocation.Name = "lblDeleteTimeAllocation";
            this.lblDeleteTimeAllocation.Size = new System.Drawing.Size(141, 39);
            this.lblDeleteTimeAllocation.TabIndex = 6;
            this.lblDeleteTimeAllocation.Text = "Delete Time";
            this.lblDeleteTimeAllocation.Click += new System.EventHandler(this.lblDeleteTheatre_Click);
            // 
            // gbTime_Allocation
            // 
            this.gbTime_Allocation.Controls.Add(this.lblMaxNumberValidation);
            this.gbTime_Allocation.Controls.Add(this.dgvDisplayTimeAllocvations);
            this.gbTime_Allocation.Controls.Add(this.bttnDeleteTime);
            this.gbTime_Allocation.Controls.Add(this.bttnUpdateTime);
            this.gbTime_Allocation.Controls.Add(this.cbTimeID);
            this.gbTime_Allocation.Controls.Add(this.tbTimeBracket);
            this.gbTime_Allocation.Controls.Add(this.lblTimeBracket);
            this.gbTime_Allocation.Controls.Add(this.lblTimeID);
            this.gbTime_Allocation.Controls.Add(this.bttnAddTime);
            this.gbTime_Allocation.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime_Allocation.Location = new System.Drawing.Point(306, 226);
            this.gbTime_Allocation.Name = "gbTime_Allocation";
            this.gbTime_Allocation.Size = new System.Drawing.Size(910, 524);
            this.gbTime_Allocation.TabIndex = 7;
            this.gbTime_Allocation.TabStop = false;
            this.gbTime_Allocation.Enter += new System.EventHandler(this.gbTime_Allocation_Enter);
            // 
            // lblMaxNumberValidation
            // 
            this.lblMaxNumberValidation.ForeColor = System.Drawing.Color.Black;
            this.lblMaxNumberValidation.Location = new System.Drawing.Point(637, 120);
            this.lblMaxNumberValidation.Name = "lblMaxNumberValidation";
            this.lblMaxNumberValidation.Size = new System.Drawing.Size(257, 66);
            this.lblMaxNumberValidation.TabIndex = 9;
            this.lblMaxNumberValidation.Text = "When inserting the time, insert it in the format \"hh:mm:ss\".\r\n";
            this.lblMaxNumberValidation.Visible = false;
            // 
            // dgvDisplayTimeAllocvations
            // 
            this.dgvDisplayTimeAllocvations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTimeAllocvations.Location = new System.Drawing.Point(35, 249);
            this.dgvDisplayTimeAllocvations.Name = "dgvDisplayTimeAllocvations";
            this.dgvDisplayTimeAllocvations.RowHeadersWidth = 51;
            this.dgvDisplayTimeAllocvations.Size = new System.Drawing.Size(329, 183);
            this.dgvDisplayTimeAllocvations.TabIndex = 8;
            // 
            // bttnDeleteTime
            // 
            this.bttnDeleteTime.Location = new System.Drawing.Point(731, 432);
            this.bttnDeleteTime.Name = "bttnDeleteTime";
            this.bttnDeleteTime.Size = new System.Drawing.Size(166, 50);
            this.bttnDeleteTime.TabIndex = 7;
            this.bttnDeleteTime.Text = "Delete Time";
            this.bttnDeleteTime.UseVisualStyleBackColor = true;
            this.bttnDeleteTime.Click += new System.EventHandler(this.bttnDeleteTheatre_Click);
            // 
            // bttnUpdateTime
            // 
            this.bttnUpdateTime.Location = new System.Drawing.Point(731, 346);
            this.bttnUpdateTime.Name = "bttnUpdateTime";
            this.bttnUpdateTime.Size = new System.Drawing.Size(166, 50);
            this.bttnUpdateTime.TabIndex = 6;
            this.bttnUpdateTime.Text = "Update Time";
            this.bttnUpdateTime.UseVisualStyleBackColor = true;
            this.bttnUpdateTime.Click += new System.EventHandler(this.bttnUpdateTheatre_Click);
            // 
            // cbTimeID
            // 
            this.cbTimeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeID.FormattingEnabled = true;
            this.cbTimeID.Location = new System.Drawing.Point(478, 63);
            this.cbTimeID.Name = "cbTimeID";
            this.cbTimeID.Size = new System.Drawing.Size(148, 31);
            this.cbTimeID.TabIndex = 5;
            // 
            // tbTimeBracket
            // 
            this.tbTimeBracket.Location = new System.Drawing.Point(478, 129);
            this.tbTimeBracket.Name = "tbTimeBracket";
            this.tbTimeBracket.Size = new System.Drawing.Size(148, 30);
            this.tbTimeBracket.TabIndex = 4;
            this.tbTimeBracket.TextChanged += new System.EventHandler(this.tbTimeBracket_TextChanged);
            // 
            // lblTimeBracket
            // 
            this.lblTimeBracket.AutoSize = true;
            this.lblTimeBracket.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeBracket.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTimeBracket.Location = new System.Drawing.Point(68, 136);
            this.lblTimeBracket.Name = "lblTimeBracket";
            this.lblTimeBracket.Size = new System.Drawing.Size(131, 33);
            this.lblTimeBracket.TabIndex = 3;
            this.lblTimeBracket.Text = "Time Bracket";
            // 
            // lblTimeID
            // 
            this.lblTimeID.AutoSize = true;
            this.lblTimeID.BackColor = System.Drawing.Color.White;
            this.lblTimeID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTimeID.Location = new System.Drawing.Point(68, 71);
            this.lblTimeID.Name = "lblTimeID";
            this.lblTimeID.Size = new System.Drawing.Size(79, 33);
            this.lblTimeID.TabIndex = 2;
            this.lblTimeID.Text = "Time ID";
            // 
            // bttnAddTime
            // 
            this.bttnAddTime.Location = new System.Drawing.Point(728, 265);
            this.bttnAddTime.Name = "bttnAddTime";
            this.bttnAddTime.Size = new System.Drawing.Size(166, 50);
            this.bttnAddTime.TabIndex = 1;
            this.bttnAddTime.Text = "Add Time";
            this.bttnAddTime.UseVisualStyleBackColor = true;
            this.bttnAddTime.Click += new System.EventHandler(this.bttnAddTheatre_Click);
            // 
            // frmTime_Allocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.gbTime_Allocation);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Name = "frmTime_Allocation";
            this.Text = "frmTime_Allocation";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbTime_Allocation.ResumeLayout(false);
            this.gbTime_Allocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTimeAllocvations)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDisplayTimeAllocvations;
        private System.Windows.Forms.Button bttnDeleteTime;
        private System.Windows.Forms.Button bttnUpdateTime;
        private System.Windows.Forms.ComboBox cbTimeID;
        private System.Windows.Forms.TextBox tbTimeBracket;
        private System.Windows.Forms.Label lblTimeBracket;
        private System.Windows.Forms.Label lblTimeID;
        private System.Windows.Forms.Button bttnAddTime;
        private System.Windows.Forms.Label lblMaxNumberValidation;
    }
}