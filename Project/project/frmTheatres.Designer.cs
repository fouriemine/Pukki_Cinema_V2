
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
            this.bttnPrevFromTime = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbTheatre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblTheatreHeading);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 165);
            this.panel3.TabIndex = 4;
            // 
            // lblTheatreHeading
            // 
            this.lblTheatreHeading.AutoSize = true;
            this.lblTheatreHeading.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreHeading.ForeColor = System.Drawing.Color.White;
            this.lblTheatreHeading.Location = new System.Drawing.Point(174, 35);
            this.lblTheatreHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheatreHeading.Name = "lblTheatreHeading";
            this.lblTheatreHeading.Size = new System.Drawing.Size(288, 103);
            this.lblTheatreHeading.TabIndex = 3;
            this.lblTheatreHeading.Text = "Theatres";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.help_btn);
            this.panel5.Controls.Add(this.closeHelp_btn);
            this.panel5.Controls.Add(this.bttnPrevFromTime);
            this.panel5.Controls.Add(this.lblAddTheatre);
            this.panel5.Controls.Add(this.lblChangeTheatre);
            this.panel5.Controls.Add(this.lblDeleteTheatre);
            this.panel5.Location = new System.Drawing.Point(0, 162);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 583);
            this.panel5.TabIndex = 5;
            // 
            // bttnPrevFromTime
            // 
            this.bttnPrevFromTime.BackColor = System.Drawing.Color.Purple;
            this.bttnPrevFromTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnPrevFromTime.ForeColor = System.Drawing.Color.White;
            this.bttnPrevFromTime.Location = new System.Drawing.Point(24, 498);
            this.bttnPrevFromTime.Margin = new System.Windows.Forms.Padding(2);
            this.bttnPrevFromTime.Name = "bttnPrevFromTime";
            this.bttnPrevFromTime.Size = new System.Drawing.Size(139, 48);
            this.bttnPrevFromTime.TabIndex = 8;
            this.bttnPrevFromTime.Text = "Previous";
            this.bttnPrevFromTime.UseVisualStyleBackColor = false;
            this.bttnPrevFromTime.Click += new System.EventHandler(this.bttnPrevFromTime_Click);
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
            this.lblChangeTheatre.Size = new System.Drawing.Size(177, 39);
            this.lblChangeTheatre.TabIndex = 5;
            this.lblChangeTheatre.Text = "Update Theatre";
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
            this.gbTheatre.Controls.Add(this.pictureBox2);
            this.gbTheatre.Controls.Add(this.dgvDisplayTheatres);
            this.gbTheatre.Controls.Add(this.bttnDeleteTheatre);
            this.gbTheatre.Controls.Add(this.bttnUpdateTheatre);
            this.gbTheatre.Controls.Add(this.cbTheatreID);
            this.gbTheatre.Controls.Add(this.tbAddTheatreCapacity);
            this.gbTheatre.Controls.Add(this.lblAddTheatreCapacity);
            this.gbTheatre.Controls.Add(this.lblTheatreID);
            this.gbTheatre.Controls.Add(this.bttnAddTheatre);
            this.gbTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTheatre.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbTheatre.Location = new System.Drawing.Point(233, 226);
            this.gbTheatre.Name = "gbTheatre";
            this.gbTheatre.Size = new System.Drawing.Size(731, 489);
            this.gbTheatre.TabIndex = 7;
            this.gbTheatre.TabStop = false;
            this.gbTheatre.Text = "Add Theartre";
            // 
            // dgvDisplayTheatres
            // 
            this.dgvDisplayTheatres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayTheatres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayTheatres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTheatres.Location = new System.Drawing.Point(47, 213);
            this.dgvDisplayTheatres.Name = "dgvDisplayTheatres";
            this.dgvDisplayTheatres.RowHeadersWidth = 51;
            this.dgvDisplayTheatres.Size = new System.Drawing.Size(329, 183);
            this.dgvDisplayTheatres.TabIndex = 8;
            // 
            // bttnDeleteTheatre
            // 
            this.bttnDeleteTheatre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnDeleteTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnDeleteTheatre.ForeColor = System.Drawing.Color.White;
            this.bttnDeleteTheatre.Location = new System.Drawing.Point(467, 433);
            this.bttnDeleteTheatre.Name = "bttnDeleteTheatre";
            this.bttnDeleteTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnDeleteTheatre.TabIndex = 7;
            this.bttnDeleteTheatre.Text = "Delete Theatre";
            this.bttnDeleteTheatre.UseVisualStyleBackColor = false;
            this.bttnDeleteTheatre.Click += new System.EventHandler(this.bttnDeleteTheatre_Click);
            // 
            // bttnUpdateTheatre
            // 
            this.bttnUpdateTheatre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnUpdateTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnUpdateTheatre.ForeColor = System.Drawing.Color.White;
            this.bttnUpdateTheatre.Location = new System.Drawing.Point(467, 433);
            this.bttnUpdateTheatre.Name = "bttnUpdateTheatre";
            this.bttnUpdateTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnUpdateTheatre.TabIndex = 6;
            this.bttnUpdateTheatre.Text = "Update Theatre";
            this.bttnUpdateTheatre.UseVisualStyleBackColor = false;
            this.bttnUpdateTheatre.Click += new System.EventHandler(this.bttnUpdateTheatre_Click);
            // 
            // cbTheatreID
            // 
            this.cbTheatreID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheatreID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheatreID.FormattingEnabled = true;
            this.cbTheatreID.Location = new System.Drawing.Point(450, 63);
            this.cbTheatreID.Name = "cbTheatreID";
            this.cbTheatreID.Size = new System.Drawing.Size(148, 41);
            this.cbTheatreID.TabIndex = 5;
            // 
            // tbAddTheatreCapacity
            // 
            this.tbAddTheatreCapacity.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.tbAddTheatreCapacity.Location = new System.Drawing.Point(450, 136);
            this.tbAddTheatreCapacity.Name = "tbAddTheatreCapacity";
            this.tbAddTheatreCapacity.Size = new System.Drawing.Size(148, 40);
            this.tbAddTheatreCapacity.TabIndex = 4;
            // 
            // lblAddTheatreCapacity
            // 
            this.lblAddTheatreCapacity.AutoSize = true;
            this.lblAddTheatreCapacity.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lblAddTheatreCapacity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAddTheatreCapacity.Location = new System.Drawing.Point(68, 136);
            this.lblAddTheatreCapacity.Name = "lblAddTheatreCapacity";
            this.lblAddTheatreCapacity.Size = new System.Drawing.Size(194, 39);
            this.lblAddTheatreCapacity.TabIndex = 3;
            this.lblAddTheatreCapacity.Text = "Theatre Capacity";
            // 
            // lblTheatreID
            // 
            this.lblTheatreID.AutoSize = true;
            this.lblTheatreID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTheatreID.Location = new System.Drawing.Point(68, 71);
            this.lblTheatreID.Name = "lblTheatreID";
            this.lblTheatreID.Size = new System.Drawing.Size(124, 39);
            this.lblTheatreID.TabIndex = 2;
            this.lblTheatreID.Text = "Theatre ID";
            // 
            // bttnAddTheatre
            // 
            this.bttnAddTheatre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnAddTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnAddTheatre.ForeColor = System.Drawing.Color.White;
            this.bttnAddTheatre.Location = new System.Drawing.Point(467, 433);
            this.bttnAddTheatre.Name = "bttnAddTheatre";
            this.bttnAddTheatre.Size = new System.Drawing.Size(166, 50);
            this.bttnAddTheatre.TabIndex = 1;
            this.bttnAddTheatre.Text = "Add Theatre";
            this.bttnAddTheatre.UseVisualStyleBackColor = false;
            this.bttnAddTheatre.Click += new System.EventHandler(this.bttnAddTheatre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 103);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(470, 411);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.BackColor = System.Drawing.Color.Purple;
            this.closeHelp_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeHelp_btn.ForeColor = System.Drawing.Color.White;
            this.closeHelp_btn.Location = new System.Drawing.Point(24, 421);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(139, 52);
            this.closeHelp_btn.TabIndex = 11;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Purple;
            this.help_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(24, 421);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(139, 52);
            this.help_btn.TabIndex = 12;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // frmTheatres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 737);
            this.Controls.Add(this.gbTheatre);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1011, 776);
            this.MinimumSize = new System.Drawing.Size(1011, 776);
            this.Name = "frmTheatres";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbTheatre.ResumeLayout(false);
            this.gbTheatre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button bttnPrevFromTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button closeHelp_btn;
    }
}