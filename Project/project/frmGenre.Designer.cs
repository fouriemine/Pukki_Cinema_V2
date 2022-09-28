
namespace project
{
    partial class frmGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenre));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbGenreId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.dtgDisplay = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeHelp_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblUpdateGenre = new System.Windows.Forms.Label();
            this.lblDeleteGenre = new System.Windows.Forms.Label();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.LblTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-193, -85);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 235);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(206, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 177);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(443, 94);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(302, 128);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Genres";
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.cmbGenreId);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtbDescription);
            this.groupBox1.Controls.Add(this.comboBoxDescription);
            this.groupBox1.Controls.Add(this.dtgDisplay);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblGenreID);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(272, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1089, 592);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F);
            this.label4.Location = new System.Drawing.Point(561, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search Descriptions";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.txtSearch.Location = new System.Drawing.Point(827, 87);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 48);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_2);
            // 
            // cmbGenreId
            // 
            this.cmbGenreId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenreId.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.cmbGenreId.FormattingEnabled = true;
            this.cmbGenreId.Location = new System.Drawing.Point(256, 94);
            this.cmbGenreId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenreId.Name = "cmbGenreId";
            this.cmbGenreId.Size = new System.Drawing.Size(280, 48);
            this.cmbGenreId.TabIndex = 12;
            this.cmbGenreId.SelectedIndexChanged += new System.EventHandler(this.cmbGenreID_SelecetedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(897, 526);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 47);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(897, 526);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(897, 526);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(159, 47);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbDescription
            // 
            this.txtbDescription.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.txtbDescription.Location = new System.Drawing.Point(256, 169);
            this.txtbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(280, 48);
            this.txtbDescription.TabIndex = 8;
            this.txtbDescription.TextChanged += new System.EventHandler(this.txtbDescription_TextChanged_2);
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(256, 168);
            this.comboBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(280, 48);
            this.comboBoxDescription.TabIndex = 6;
            this.comboBoxDescription.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescription_SelectedIndexChanged);
            // 
            // dtgDisplay
            // 
            this.dtgDisplay.AllowUserToAddRows = false;
            this.dtgDisplay.AllowUserToDeleteRows = false;
            this.dtgDisplay.AllowUserToResizeColumns = false;
            this.dtgDisplay.AllowUserToResizeRows = false;
            this.dtgDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgDisplay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplay.GridColor = System.Drawing.SystemColors.Control;
            this.dtgDisplay.Location = new System.Drawing.Point(555, 176);
            this.dtgDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDisplay.Name = "dtgDisplay";
            this.dtgDisplay.ReadOnly = true;
            this.dtgDisplay.RowHeadersWidth = 51;
            this.dtgDisplay.Size = new System.Drawing.Size(522, 331);
            this.dtgDisplay.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.lblDescription.Location = new System.Drawing.Point(61, 173);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(146, 41);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F);
            this.lblGenreID.Location = new System.Drawing.Point(61, 98);
            this.lblGenreID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(112, 41);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Genre ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.closeHelp_btn);
            this.panel1.Controls.Add(this.help_btn);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.lblUpdateGenre);
            this.panel1.Controls.Add(this.lblDeleteGenre);
            this.panel1.Controls.Add(this.lblAddGenre);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 686);
            this.panel1.TabIndex = 6;
            // 
            // closeHelp_btn
            // 
            this.closeHelp_btn.BackColor = System.Drawing.Color.Purple;
            this.closeHelp_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeHelp_btn.ForeColor = System.Drawing.Color.White;
            this.closeHelp_btn.Location = new System.Drawing.Point(25, 457);
            this.closeHelp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.closeHelp_btn.Name = "closeHelp_btn";
            this.closeHelp_btn.Size = new System.Drawing.Size(185, 48);
            this.closeHelp_btn.TabIndex = 10;
            this.closeHelp_btn.Text = "Close Help";
            this.closeHelp_btn.UseVisualStyleBackColor = false;
            this.closeHelp_btn.Click += new System.EventHandler(this.closeHelp_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Purple;
            this.help_btn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.ForeColor = System.Drawing.Color.White;
            this.help_btn.Location = new System.Drawing.Point(25, 457);
            this.help_btn.Margin = new System.Windows.Forms.Padding(4);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(185, 48);
            this.help_btn.TabIndex = 9;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Purple;
            this.btnPrevious.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(30, 523);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(185, 48);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblUpdateGenre
            // 
            this.lblUpdateGenre.AutoSize = true;
            this.lblUpdateGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateGenre.ForeColor = System.Drawing.Color.White;
            this.lblUpdateGenre.Location = new System.Drawing.Point(8, 117);
            this.lblUpdateGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateGenre.Name = "lblUpdateGenre";
            this.lblUpdateGenre.Size = new System.Drawing.Size(207, 48);
            this.lblUpdateGenre.TabIndex = 7;
            this.lblUpdateGenre.Text = "Update  Genre";
            this.lblUpdateGenre.Click += new System.EventHandler(this.lblUpdateGenre_Click);
            // 
            // lblDeleteGenre
            // 
            this.lblDeleteGenre.AutoSize = true;
            this.lblDeleteGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGenre.ForeColor = System.Drawing.Color.White;
            this.lblDeleteGenre.Location = new System.Drawing.Point(9, 178);
            this.lblDeleteGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteGenre.Name = "lblDeleteGenre";
            this.lblDeleteGenre.Size = new System.Drawing.Size(193, 48);
            this.lblDeleteGenre.TabIndex = 6;
            this.lblDeleteGenre.Text = "Delete Genre";
            this.lblDeleteGenre.Click += new System.EventHandler(this.lblDeleteGenre_Click);
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGenre.ForeColor = System.Drawing.Color.White;
            this.lblAddGenre.Location = new System.Drawing.Point(9, 57);
            this.lblAddGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(158, 48);
            this.lblAddGenre.TabIndex = 5;
            this.lblAddGenre.Text = "Add Genre";
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(336, 370);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 364);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // frmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1388, 782);
            this.MinimumSize = new System.Drawing.Size(1388, 782);
            this.Name = "frmGenre";
            this.Text = "Pukki Cinema";
            this.Load += new System.EventHandler(this.frmGenre_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgDisplay;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblUpdateGenre;
        private System.Windows.Forms.Label lblDeleteGenre;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button closeHelp_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbGenreId;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
    }
}