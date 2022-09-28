
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheatres));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTheatreHeading = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.Button();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.bttnPrevFromTime = new System.Windows.Forms.Button();
            this.lblAddTheatre = new System.Windows.Forms.Label();
            this.lblChangeTheatre = new System.Windows.Forms.Label();
            this.lblDeleteTheatre = new System.Windows.Forms.Label();
            this.gbTheatre = new System.Windows.Forms.GroupBox();
            this.lblMaxTheatreWarning = new System.Windows.Forms.Label();
            this.dgvDisplayTheatres = new System.Windows.Forms.DataGridView();
            this.bttnDeleteTheatre = new System.Windows.Forms.Button();
            this.bttnUpdateTheatre = new System.Windows.Forms.Button();
            this.cbTheatreID = new System.Windows.Forms.ComboBox();
            this.tbAddTheatreCapacity = new System.Windows.Forms.TextBox();
            this.lblAddTheatreCapacity = new System.Windows.Forms.Label();
            this.lblTheatreID = new System.Windows.Forms.Label();
            this.bttnAddTheatre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errProvCapacity = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.gbTheatre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblTheatreHeading);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1773, 203);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblTheatreHeading
            // 
            this.lblTheatreHeading.AutoSize = true;
            this.lblTheatreHeading.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreHeading.ForeColor = System.Drawing.Color.White;
            this.lblTheatreHeading.Location = new System.Drawing.Point(232, 43);
            this.lblTheatreHeading.Name = "lblTheatreHeading";
            this.lblTheatreHeading.Size = new System.Drawing.Size(364, 128);
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
            this.panel5.Location = new System.Drawing.Point(0, 199);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 718);
            this.panel5.TabIndex = 5;
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Purple;
            this.help_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(32, 378);
            this.help_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(185, 64);
            this.help_btn.TabIndex = 12;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.BackColor = System.Drawing.Color.Purple;
            this.closeHelp_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeHelp_btn.ForeColor = System.Drawing.Color.White;
            this.closeHelp_btn.Location = new System.Drawing.Point(32, 378);
            this.closeHelp_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(185, 64);
            this.closeHelp_btn.TabIndex = 11;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // bttnPrevFromTime
            // 
            this.bttnPrevFromTime.BackColor = System.Drawing.Color.Purple;
            this.bttnPrevFromTime.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnPrevFromTime.ForeColor = System.Drawing.Color.White;
            this.bttnPrevFromTime.Location = new System.Drawing.Point(32, 456);
            this.bttnPrevFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnPrevFromTime.Name = "bttnPrevFromTime";
            this.bttnPrevFromTime.Size = new System.Drawing.Size(185, 59);
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
            this.lblAddTheatre.Location = new System.Drawing.Point(11, 98);
            this.lblAddTheatre.Name = "lblAddTheatre";
            this.lblAddTheatre.Size = new System.Drawing.Size(181, 48);
            this.lblAddTheatre.TabIndex = 4;
            this.lblAddTheatre.Text = "Add Theatre";
            this.lblAddTheatre.Click += new System.EventHandler(this.lblAddTheatre_Click);
            // 
            // lblChangeTheatre
            // 
            this.lblChangeTheatre.AutoSize = true;
            this.lblChangeTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeTheatre.ForeColor = System.Drawing.Color.White;
            this.lblChangeTheatre.Location = new System.Drawing.Point(11, 180);
            this.lblChangeTheatre.Name = "lblChangeTheatre";
            this.lblChangeTheatre.Size = new System.Drawing.Size(222, 48);
            this.lblChangeTheatre.TabIndex = 5;
            this.lblChangeTheatre.Text = "Update Theatre";
            this.lblChangeTheatre.Click += new System.EventHandler(this.lblChangeTheatre_Click);
            // 
            // lblDeleteTheatre
            // 
            this.lblDeleteTheatre.AutoSize = true;
            this.lblDeleteTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteTheatre.ForeColor = System.Drawing.Color.White;
            this.lblDeleteTheatre.Location = new System.Drawing.Point(11, 268);
            this.lblDeleteTheatre.Name = "lblDeleteTheatre";
            this.lblDeleteTheatre.Size = new System.Drawing.Size(216, 48);
            this.lblDeleteTheatre.TabIndex = 6;
            this.lblDeleteTheatre.Text = "Delete Theatre";
            this.lblDeleteTheatre.Click += new System.EventHandler(this.lblDeleteTheatre_Click);
            // 
            // gbTheatre
            // 
            this.gbTheatre.Controls.Add(this.lblMaxTheatreWarning);
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
            this.gbTheatre.Location = new System.Drawing.Point(269, 221);
            this.gbTheatre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTheatre.Name = "gbTheatre";
            this.gbTheatre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTheatre.Size = new System.Drawing.Size(1088, 501);
            this.gbTheatre.TabIndex = 7;
            this.gbTheatre.TabStop = false;
            this.gbTheatre.Text = "Add Theatre";
            // 
            // lblMaxTheatreWarning
            // 
            this.lblMaxTheatreWarning.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTheatreWarning.Location = new System.Drawing.Point(741, 298);
            this.lblMaxTheatreWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTheatreWarning.Name = "lblMaxTheatreWarning";
            this.lblMaxTheatreWarning.Size = new System.Drawing.Size(347, 103);
            this.lblMaxTheatreWarning.TabIndex = 13;
            this.lblMaxTheatreWarning.Text = "*The maximum number of theatres is 3";
            // 
            // dgvDisplayTheatres
            // 
            this.dgvDisplayTheatres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayTheatres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDisplayTheatres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayTheatres.Location = new System.Drawing.Point(619, 69);
            this.dgvDisplayTheatres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDisplayTheatres.Name = "dgvDisplayTheatres";
            this.dgvDisplayTheatres.RowHeadersWidth = 51;
            this.dgvDisplayTheatres.Size = new System.Drawing.Size(439, 225);
            this.dgvDisplayTheatres.TabIndex = 8;
            this.dgvDisplayTheatres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayTheatres_CellContentClick);
            // 
            // bttnDeleteTheatre
            // 
            this.bttnDeleteTheatre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnDeleteTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnDeleteTheatre.ForeColor = System.Drawing.Color.White;
            this.bttnDeleteTheatre.Location = new System.Drawing.Point(819, 431);
            this.bttnDeleteTheatre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnDeleteTheatre.Name = "bttnDeleteTheatre";
            this.bttnDeleteTheatre.Size = new System.Drawing.Size(221, 62);
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
            this.bttnUpdateTheatre.Location = new System.Drawing.Point(819, 432);
            this.bttnUpdateTheatre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnUpdateTheatre.Name = "bttnUpdateTheatre";
            this.bttnUpdateTheatre.Size = new System.Drawing.Size(221, 62);
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
            this.cbTheatreID.Location = new System.Drawing.Point(383, 75);
            this.cbTheatreID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTheatreID.Name = "cbTheatreID";
            this.cbTheatreID.Size = new System.Drawing.Size(196, 49);
            this.cbTheatreID.TabIndex = 5;
            // 
            // tbAddTheatreCapacity
            // 
            this.tbAddTheatreCapacity.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20.25F);
            this.tbAddTheatreCapacity.Location = new System.Drawing.Point(383, 164);
            this.tbAddTheatreCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddTheatreCapacity.Name = "tbAddTheatreCapacity";
            this.tbAddTheatreCapacity.Size = new System.Drawing.Size(196, 48);
            this.tbAddTheatreCapacity.TabIndex = 4;
            // 
            // lblAddTheatreCapacity
            // 
            this.lblAddTheatreCapacity.AutoSize = true;
            this.lblAddTheatreCapacity.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.lblAddTheatreCapacity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAddTheatreCapacity.Location = new System.Drawing.Point(44, 164);
            this.lblAddTheatreCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddTheatreCapacity.Name = "lblAddTheatreCapacity";
            this.lblAddTheatreCapacity.Size = new System.Drawing.Size(245, 48);
            this.lblAddTheatreCapacity.TabIndex = 3;
            this.lblAddTheatreCapacity.Text = "Theatre Capacity";
            // 
            // lblTheatreID
            // 
            this.lblTheatreID.AutoSize = true;
            this.lblTheatreID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheatreID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTheatreID.Location = new System.Drawing.Point(44, 84);
            this.lblTheatreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheatreID.Name = "lblTheatreID";
            this.lblTheatreID.Size = new System.Drawing.Size(156, 48);
            this.lblTheatreID.TabIndex = 2;
            this.lblTheatreID.Text = "Theatre ID";
            // 
            // bttnAddTheatre
            // 
            this.bttnAddTheatre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bttnAddTheatre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.bttnAddTheatre.ForeColor = System.Drawing.Color.White;
            this.bttnAddTheatre.Location = new System.Drawing.Point(819, 431);
            this.bttnAddTheatre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnAddTheatre.Name = "bttnAddTheatre";
            this.bttnAddTheatre.Size = new System.Drawing.Size(221, 62);
            this.bttnAddTheatre.TabIndex = 1;
            this.bttnAddTheatre.Text = "Add Theatre";
            this.bttnAddTheatre.UseVisualStyleBackColor = false;
            this.bttnAddTheatre.Click += new System.EventHandler(this.bttnAddTheatre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(52, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 234);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // errProvCapacity
            // 
            this.errProvCapacity.ContainerControl = this;
            // 
            // frmTheatres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.gbTheatre);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.MinimumSize = new System.Drawing.Size(1388, 782);
            this.Name = "frmTheatres";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmTheatres_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbTheatre.ResumeLayout(false);
            this.gbTheatre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayTheatres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvCapacity)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errProvCapacity;
        private System.Windows.Forms.Label lblMaxTheatreWarning;
    }
}