
namespace project
{
    partial class frmFilm
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
            this.pnl_purple = new System.Windows.Forms.Panel();
            this.lbl_films = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_previous = new System.Windows.Forms.Button();
            this.lbl_deleteFilm = new System.Windows.Forms.Label();
            this.lbl_updateFilm = new System.Windows.Forms.Label();
            this.lbl_addFilm = new System.Windows.Forms.Label();
            this.gbx_films = new System.Windows.Forms.GroupBox();
            this.cbx_title = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_films = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.cbx_genre = new System.Windows.Forms.ComboBox();
            this.lbl_ageRestriction = new System.Windows.Forms.Label();
            this.txt_ageRestiction = new System.Windows.Forms.TextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_sellingPrice = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_filmCost = new System.Windows.Forms.Label();
            this.txt_filmCost = new System.Windows.Forms.TextBox();
            this.cbx_filmID = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_filmID = new System.Windows.Forms.Label();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.rdo_Active = new System.Windows.Forms.RadioButton();
            this.rdo_Inactive = new System.Windows.Forms.RadioButton();
            this.pnl_purple.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbx_films.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).BeginInit();
            this.pnl_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_purple
            // 
            this.pnl_purple.BackColor = System.Drawing.Color.Purple;
            this.pnl_purple.Controls.Add(this.lbl_films);
            this.pnl_purple.Location = new System.Drawing.Point(-2, 0);
            this.pnl_purple.Name = "pnl_purple";
            this.pnl_purple.Size = new System.Drawing.Size(1329, 184);
            this.pnl_purple.TabIndex = 0;
            // 
            // lbl_films
            // 
            this.lbl_films.AutoSize = true;
            this.lbl_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_films.ForeColor = System.Drawing.Color.White;
            this.lbl_films.Location = new System.Drawing.Point(270, 24);
            this.lbl_films.Name = "lbl_films";
            this.lbl_films.Size = new System.Drawing.Size(247, 128);
            this.lbl_films.TabIndex = 0;
            this.lbl_films.Text = "Films";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Controls.Add(this.lbl_deleteFilm);
            this.panel2.Controls.Add(this.lbl_updateFilm);
            this.panel2.Controls.Add(this.lbl_addFilm);
            this.panel2.Location = new System.Drawing.Point(-2, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 581);
            this.panel2.TabIndex = 1;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Purple;
            this.btn_previous.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(49, 501);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(160, 51);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            // 
            // lbl_deleteFilm
            // 
            this.lbl_deleteFilm.AutoSize = true;
            this.lbl_deleteFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteFilm.ForeColor = System.Drawing.Color.White;
            this.lbl_deleteFilm.Location = new System.Drawing.Point(41, 247);
            this.lbl_deleteFilm.Name = "lbl_deleteFilm";
            this.lbl_deleteFilm.Size = new System.Drawing.Size(171, 48);
            this.lbl_deleteFilm.TabIndex = 2;
            this.lbl_deleteFilm.Text = "Delete Film";
            this.lbl_deleteFilm.Click += new System.EventHandler(this.lbl_deleteFilm_Click);
            // 
            // lbl_updateFilm
            // 
            this.lbl_updateFilm.AutoSize = true;
            this.lbl_updateFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateFilm.ForeColor = System.Drawing.Color.White;
            this.lbl_updateFilm.Location = new System.Drawing.Point(41, 154);
            this.lbl_updateFilm.Name = "lbl_updateFilm";
            this.lbl_updateFilm.Size = new System.Drawing.Size(177, 48);
            this.lbl_updateFilm.TabIndex = 1;
            this.lbl_updateFilm.Text = "Update Film";
            this.lbl_updateFilm.Click += new System.EventHandler(this.lbl_updateFilm_Click);
            // 
            // lbl_addFilm
            // 
            this.lbl_addFilm.AutoSize = true;
            this.lbl_addFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addFilm.ForeColor = System.Drawing.Color.White;
            this.lbl_addFilm.Location = new System.Drawing.Point(42, 59);
            this.lbl_addFilm.Name = "lbl_addFilm";
            this.lbl_addFilm.Size = new System.Drawing.Size(136, 48);
            this.lbl_addFilm.TabIndex = 0;
            this.lbl_addFilm.Text = "Add Film";
            this.lbl_addFilm.Click += new System.EventHandler(this.lbl_addFilm_Click);
            // 
            // gbx_films
            // 
            this.gbx_films.Controls.Add(this.pnl_Status);
            this.gbx_films.Controls.Add(this.cbx_title);
            this.gbx_films.Controls.Add(this.btn_update);
            this.gbx_films.Controls.Add(this.btn_delete);
            this.gbx_films.Controls.Add(this.dgv_films);
            this.gbx_films.Controls.Add(this.btn_add);
            this.gbx_films.Controls.Add(this.lbl_status);
            this.gbx_films.Controls.Add(this.lbl_length);
            this.gbx_films.Controls.Add(this.txt_length);
            this.gbx_films.Controls.Add(this.cbx_genre);
            this.gbx_films.Controls.Add(this.lbl_ageRestriction);
            this.gbx_films.Controls.Add(this.txt_ageRestiction);
            this.gbx_films.Controls.Add(this.lbl_genre);
            this.gbx_films.Controls.Add(this.lbl_sellingPrice);
            this.gbx_films.Controls.Add(this.txt_sellingPrice);
            this.gbx_films.Controls.Add(this.lbl_filmCost);
            this.gbx_films.Controls.Add(this.txt_filmCost);
            this.gbx_films.Controls.Add(this.cbx_filmID);
            this.gbx_films.Controls.Add(this.lbl_title);
            this.gbx_films.Controls.Add(this.txt_title);
            this.gbx_films.Controls.Add(this.lbl_filmID);
            this.gbx_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_films.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gbx_films.Location = new System.Drawing.Point(254, 190);
            this.gbx_films.Name = "gbx_films";
            this.gbx_films.Size = new System.Drawing.Size(1049, 560);
            this.gbx_films.TabIndex = 3;
            this.gbx_films.TabStop = false;
            this.gbx_films.Text = "Add Films";
            // 
            // cbx_title
            // 
            this.cbx_title.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_title.FormattingEnabled = true;
            this.cbx_title.Location = new System.Drawing.Point(252, 126);
            this.cbx_title.Name = "cbx_title";
            this.cbx_title.Size = new System.Drawing.Size(234, 48);
            this.cbx_title.TabIndex = 21;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_update.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(883, 493);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(160, 51);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update Film";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(883, 493);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 51);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete Film";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_films
            // 
            this.dgv_films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_films.Location = new System.Drawing.Point(36, 326);
            this.dgv_films.Name = "dgv_films";
            this.dgv_films.RowHeadersWidth = 70;
            this.dgv_films.RowTemplate.Height = 24;
            this.dgv_films.Size = new System.Drawing.Size(970, 150);
            this.dgv_films.TabIndex = 18;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(883, 493);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 51);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Film";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(523, 255);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(105, 48);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Status";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(523, 63);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(112, 48);
            this.lbl_length.TabIndex = 15;
            this.lbl_length.Text = "Length";
            // 
            // txt_length
            // 
            this.txt_length.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_length.Location = new System.Drawing.Point(769, 63);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(234, 48);
            this.txt_length.TabIndex = 14;
            // 
            // cbx_genre
            // 
            this.cbx_genre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_genre.FormattingEnabled = true;
            this.cbx_genre.Location = new System.Drawing.Point(772, 191);
            this.cbx_genre.Name = "cbx_genre";
            this.cbx_genre.Size = new System.Drawing.Size(234, 48);
            this.cbx_genre.TabIndex = 13;
            // 
            // lbl_ageRestriction
            // 
            this.lbl_ageRestriction.AutoSize = true;
            this.lbl_ageRestriction.Location = new System.Drawing.Point(523, 126);
            this.lbl_ageRestriction.Name = "lbl_ageRestriction";
            this.lbl_ageRestriction.Size = new System.Drawing.Size(223, 48);
            this.lbl_ageRestriction.TabIndex = 12;
            this.lbl_ageRestriction.Text = "Age Restriction";
            // 
            // txt_ageRestiction
            // 
            this.txt_ageRestiction.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ageRestiction.Location = new System.Drawing.Point(769, 126);
            this.txt_ageRestiction.Name = "txt_ageRestiction";
            this.txt_ageRestiction.Size = new System.Drawing.Size(234, 48);
            this.txt_ageRestiction.TabIndex = 11;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(523, 194);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(100, 48);
            this.lbl_genre.TabIndex = 10;
            this.lbl_genre.Text = "Genre";
            // 
            // lbl_sellingPrice
            // 
            this.lbl_sellingPrice.AutoSize = true;
            this.lbl_sellingPrice.Location = new System.Drawing.Point(49, 252);
            this.lbl_sellingPrice.Name = "lbl_sellingPrice";
            this.lbl_sellingPrice.Size = new System.Drawing.Size(188, 48);
            this.lbl_sellingPrice.TabIndex = 9;
            this.lbl_sellingPrice.Text = "Selling Price";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingPrice.Location = new System.Drawing.Point(252, 255);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(234, 48);
            this.txt_sellingPrice.TabIndex = 8;
            // 
            // lbl_filmCost
            // 
            this.lbl_filmCost.AutoSize = true;
            this.lbl_filmCost.Location = new System.Drawing.Point(49, 188);
            this.lbl_filmCost.Name = "lbl_filmCost";
            this.lbl_filmCost.Size = new System.Drawing.Size(143, 48);
            this.lbl_filmCost.TabIndex = 7;
            this.lbl_filmCost.Text = "Film Cost";
            // 
            // txt_filmCost
            // 
            this.txt_filmCost.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filmCost.Location = new System.Drawing.Point(252, 191);
            this.txt_filmCost.Name = "txt_filmCost";
            this.txt_filmCost.Size = new System.Drawing.Size(234, 48);
            this.txt_filmCost.TabIndex = 6;
            // 
            // cbx_filmID
            // 
            this.cbx_filmID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filmID.FormattingEnabled = true;
            this.cbx_filmID.Location = new System.Drawing.Point(252, 63);
            this.cbx_filmID.Name = "cbx_filmID";
            this.cbx_filmID.Size = new System.Drawing.Size(234, 48);
            this.cbx_filmID.TabIndex = 5;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(49, 123);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(78, 48);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_title.Location = new System.Drawing.Point(252, 126);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(234, 48);
            this.txt_title.TabIndex = 3;
            // 
            // lbl_filmID
            // 
            this.lbl_filmID.AutoSize = true;
            this.lbl_filmID.Location = new System.Drawing.Point(49, 63);
            this.lbl_filmID.Name = "lbl_filmID";
            this.lbl_filmID.Size = new System.Drawing.Size(111, 48);
            this.lbl_filmID.TabIndex = 2;
            this.lbl_filmID.Text = "Film ID";
            // 
            // pnl_Status
            // 
            this.pnl_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Status.Controls.Add(this.rdo_Inactive);
            this.pnl_Status.Controls.Add(this.rdo_Active);
            this.pnl_Status.Location = new System.Drawing.Point(769, 245);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(234, 75);
            this.pnl_Status.TabIndex = 22;
            // 
            // rdo_Active
            // 
            this.rdo_Active.AutoSize = true;
            this.rdo_Active.Font = new System.Drawing.Font("Arial", 11F);
            this.rdo_Active.Location = new System.Drawing.Point(3, 25);
            this.rdo_Active.Name = "rdo_Active";
            this.rdo_Active.Size = new System.Drawing.Size(83, 26);
            this.rdo_Active.TabIndex = 0;
            this.rdo_Active.TabStop = true;
            this.rdo_Active.Text = "Active";
            this.rdo_Active.UseVisualStyleBackColor = true;
            // 
            // rdo_Inactive
            // 
            this.rdo_Inactive.AutoSize = true;
            this.rdo_Inactive.Font = new System.Drawing.Font("Arial", 11F);
            this.rdo_Inactive.Location = new System.Drawing.Point(133, 25);
            this.rdo_Inactive.Name = "rdo_Inactive";
            this.rdo_Inactive.Size = new System.Drawing.Size(96, 26);
            this.rdo_Inactive.TabIndex = 1;
            this.rdo_Inactive.TabStop = true;
            this.rdo_Inactive.Text = "Inactive";
            this.rdo_Inactive.UseVisualStyleBackColor = true;
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 762);
            this.Controls.Add(this.gbx_films);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_purple);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            this.pnl_purple.ResumeLayout(false);
            this.pnl_purple.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbx_films.ResumeLayout(false);
            this.gbx_films.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).EndInit();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_purple;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_films;
        private System.Windows.Forms.Label lbl_addFilm;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Label lbl_deleteFilm;
        private System.Windows.Forms.Label lbl_updateFilm;
        private System.Windows.Forms.GroupBox gbx_films;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.ComboBox cbx_genre;
        private System.Windows.Forms.Label lbl_ageRestriction;
        private System.Windows.Forms.TextBox txt_ageRestiction;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_sellingPrice;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label lbl_filmCost;
        private System.Windows.Forms.TextBox txt_filmCost;
        private System.Windows.Forms.ComboBox cbx_filmID;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_filmID;
        private System.Windows.Forms.DataGridView dgv_films;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbx_title;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.RadioButton rdo_Inactive;
        private System.Windows.Forms.RadioButton rdo_Active;
    }
}