
namespace project
{
    partial class frmTheatres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheatres));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTheatreHeading = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAddTheatre = new System.Windows.Forms.Label();
            this.lblChangeTheatre = new System.Windows.Forms.Label();
            this.lblDeleteTheatre = new System.Windows.Forms.Label();
            this.gbTheatre = new System.Windows.Forms.GroupBox();
            this.dgvDisplayTheatres = new System.Windows.Forms.DataGridView();
            this.bttnDeleteTheatre = new System.Windows.Forms.Button();
            this.bttnUpdateTheatre = new System.Windows.Forms.Button();
            this.cbTheatreID = new System.Windows.Forms.ComboBox();
            this.tbAddTheatreCapacity = new System.Windows.Forms.TextBox();
            this.lblAddTheatreCapacity = new System.Windows.Forms.Label();
            this.lblTheatreID = new System.Windows.Forms.Label();
            this.bttnAddTheatre = new System.Windows.Forms.Button();
            this.lblMaxNumberValidation = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbTheatre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.lblTheatreHeading);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 203);
            this.panel3.TabIndex = 4;
            // 
            // lblTheatreHeading
            // 
            this.lblTheatreHeading.AutoSize = true;
            this.lblTheatreHeading.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreHeading.ForeColor = System.Drawing.Color.White;
            this.lblTheatreHeading.Location = new System.Drawing.Point(223, 85);
            this.lblTheatreHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheatreHeading.Name = "lblTheatreHeading";
            this.lblTheatreHeading.Size = new System.Drawing.Size(281, 52);
            this.lblTheatreHeading.TabIndex = 3;
            this.lblTheatreHeading.Text = "Maintain Theatres";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.lblAddTheatre);
            this.panel5.Controls.Add(this.lblChangeTheatre);
            this.panel5.Controls.Add(this.lblDeleteTheatre);
            this.panel5.Location = new System.Drawing.Point(3, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 551);
            this.panel5.TabIndex = 5;
            // 
            // lblAddTheatre
            // 
            this.lblAddTheatre.AutoSize = true;
            this.lblAddTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTheatre.ForeColor = System.Drawing.Color.White;
            this.lblAddTheatre.Location = new System.Drawing.Point(8, 80);
            this.lblAddTheatre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTheatre.Name = "lblAddTheatre";
            this.lblAddTheatre.Size = new System.Drawing.Size(144, 39);
            this.lblAddTheatre.TabIndex = 4;
            this.lblAddTheatre.Text = "Add Theatre";
            this.lblAddTheatre.Click += new System.EventHandler(this.lblAddTheatre_Click);
            // 
            // lblChangeTheatre
            // 
            this.lblChangeTheatre.AutoSize = true;
            this.lblChangeTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTheatre.ForeColor = System.Drawing.Color.White;
            this.lblChangeTheatre.Location = new System.Drawing.Point(8, 146);
            this.lblChangeTheatre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeTheatre.Name = "lblChangeTheatre";
            this.lblChangeTheatre.Size = new System.Drawing.Size(182, 39);
            this.lblChangeTheatre.TabIndex = 5;
            this.lblChangeTheatre.Text = "Change Theatre";
            this.lblChangeTheatre.Click += new System.EventHandler(this.lblChangeTheatre_Click);
            // 
            // lblDeleteTheatre
            // 
            this.lblDeleteTheatre.AutoSize = true;
            this.lblDeleteTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTheatre.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTheatre.Location = new System.Drawing.Point(8, 218);
            this.lblDeleteTheatre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteTheatre.Name = "lblDeleteTheatre";
            this.lblDeleteTheatre.Size = new System.Drawing.Size(172, 39);
            this.lblDeleteTheatre.TabIndex = 6;
            this.lblDeleteTheatre.Text = "Delete Theatre";
            this.lblDeleteTheatre.Click += new System.EventHandler(this.lblDeleteTheatre_Click);
            // 
            // gbTheatre
            // 
            this.gbTheatre.Controls.Add(this.lblMaxNumberValidation);
            this.gbTheatre.Controls.Add(this.dgvDisplayTheatres);
            this.gbTheatre.Controls.Add(this.bttnDeleteTheatre);
            this.gbTheatre.Controls.Add(this.bttnUpdateTheatre);
            this.gbTheatre.Controls.Add(this.cbTheatreID);
            this.gbTheatre.Controls.Add(this.tbAddTheatreCapacity);
            this.gbTheatre.Controls.Add(this.lblAddTheatreCapacity);
            this.gbTheatre.Controls.Add(this.lblTheatreID);
            this.gbTheatre.Controls.Add(this.bttnAddTheatre);
            this.gbTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTheatre.Location = new System.Drawing.Point(306, 226);
            this.gbTheatre.Name = "gbTheatre";
            this.gbTheatre.Size = new System.Drawing.Size(910, 524);
            this.gbTheatre.TabIndex = 7;
            this.gbTheatre.TabStop = false;
            this.gbTheatre.Text = "Add Theartre";
            // 
            // dgvDisplayTheatres
            // 
            this.dgvDisplayTheatres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTheatres.Location = new System.Drawing.Point(35, 249);
            this.dgvDisplayTheatres.Name = "dgvDisplayTheatres";
            this.dgvDisplayTheatres.RowHeadersWidth = 51;
            this.dgvDisplayTheatres.Size = new System.Drawing.Size(329, 183);
            this.dgvDisplayTheatres.TabIndex = 8;
            // 
            // bttnDeleteTheatre
            // 
            this.bttnDeleteTheatre.Location = new System.Drawing.Point(731, 432);
            this.bttnDeleteTheatre.Name = "bttnDeleteTheatre";
            this.bttnDeleteTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnDeleteTheatre.TabIndex = 7;
            this.bttnDeleteTheatre.Text = "Delete Theatre";
            this.bttnDeleteTheatre.UseVisualStyleBackColor = true;
            this.bttnDeleteTheatre.Click += new System.EventHandler(this.bttnDeleteTheatre_Click);
            // 
            // bttnUpdateTheatre
            // 
            this.bttnUpdateTheatre.Location = new System.Drawing.Point(731, 346);
            this.bttnUpdateTheatre.Name = "bttnUpdateTheatre";
            this.bttnUpdateTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnUpdateTheatre.TabIndex = 6;
            this.bttnUpdateTheatre.Text = "Update Theatre";
            this.bttnUpdateTheatre.UseVisualStyleBackColor = true;
            this.bttnUpdateTheatre.Click += new System.EventHandler(this.bttnUpdateTheatre_Click);
            // 
            // cbTheatreID
            // 
            this.cbTheatreID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheatreID.FormattingEnabled = true;
            this.cbTheatreID.Location = new System.Drawing.Point(478, 63);
            this.cbTheatreID.Name = "cbTheatreID";
            this.cbTheatreID.Size = new System.Drawing.Size(148, 31);
            this.cbTheatreID.TabIndex = 5;
            // 
            // tbAddTheatreCapacity
            // 
            this.tbAddTheatreCapacity.Location = new System.Drawing.Point(478, 129);
            this.tbAddTheatreCapacity.Name = "tbAddTheatreCapacity";
            this.tbAddTheatreCapacity.Size = new System.Drawing.Size(148, 30);
            this.tbAddTheatreCapacity.TabIndex = 4;
            // 
            // lblAddTheatreCapacity
            // 
            this.lblAddTheatreCapacity.AutoSize = true;
            this.lblAddTheatreCapacity.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTheatreCapacity.Location = new System.Drawing.Point(68, 136);
            this.lblAddTheatreCapacity.Name = "lblAddTheatreCapacity";
            this.lblAddTheatreCapacity.Size = new System.Drawing.Size(117, 23);
            this.lblAddTheatreCapacity.TabIndex = 3;
            this.lblAddTheatreCapacity.Text = "Theatre Capacity";
            // 
            // lblTheatreID
            // 
            this.lblTheatreID.AutoSize = true;
            this.lblTheatreID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreID.Location = new System.Drawing.Point(68, 71);
            this.lblTheatreID.Name = "lblTheatreID";
            this.lblTheatreID.Size = new System.Drawing.Size(74, 23);
            this.lblTheatreID.TabIndex = 2;
            this.lblTheatreID.Text = "Theatre ID";
            // 
            // bttnAddTheatre
            // 
            this.bttnAddTheatre.Location = new System.Drawing.Point(728, 265);
            this.bttnAddTheatre.Name = "bttnAddTheatre";
            this.bttnAddTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnAddTheatre.TabIndex = 1;
            this.bttnAddTheatre.Text = "Add Theatre";
            this.bttnAddTheatre.UseVisualStyleBackColor = true;
            this.bttnAddTheatre.Click += new System.EventHandler(this.bttnAddTheatre_Click);
            // 
            // lblMaxNumberValidation
            // 
            this.lblMaxNumberValidation.Location = new System.Drawing.Point(370, 249);
            this.lblMaxNumberValidation.Name = "lblMaxNumberValidation";
            this.lblMaxNumberValidation.Size = new System.Drawing.Size(317, 183);
            this.lblMaxNumberValidation.TabIndex = 9;
            this.lblMaxNumberValidation.Text = resources.GetString("lblMaxNumberValidation.Text");
            this.lblMaxNumberValidation.Visible = false;
            // 
            // frmTheatres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.gbTheatre);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Name = "frmTheatres";
            this.Text = "frmTheatres";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbTheatre.ResumeLayout(false);
            this.gbTheatre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTheatreHeading;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAddTheatre;
        private System.Windows.Forms.Label lblChangeTheatre;
        private System.Windows.Forms.Label lblDeleteTheatre;
        private System.Windows.Forms.GroupBox gbTheatre;
        private System.Windows.Forms.DataGridView dgvDisplayTheatres;
        private System.Windows.Forms.Button bttnDeleteTheatre;
        private System.Windows.Forms.Button bttnUpdateTheatre;
        private System.Windows.Forms.ComboBox cbTheatreID;
        private System.Windows.Forms.TextBox tbAddTheatreCapacity;
        private System.Windows.Forms.Label lblAddTheatreCapacity;
        private System.Windows.Forms.Label lblTheatreID;
        private System.Windows.Forms.Button bttnAddTheatre;
        private System.Windows.Forms.Label lblMaxNumberValidation;
    }
}