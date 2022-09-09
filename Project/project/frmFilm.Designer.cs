
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
            this.gbx_films = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_films = new System.Windows.Forms.Label();
            this.lbl_addFilm = new System.Windows.Forms.Label();
            this.lbl_updateFilm = new System.Windows.Forms.Label();
            this.lbl_deleteFilm = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_filmID = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.cbx_filmID = new System.Windows.Forms.ComboBox();
            this.lbl_filmCost = new System.Windows.Forms.Label();
            this.txt_filmCost = new System.Windows.Forms.TextBox();
            this.lbl_sellingPrice = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.lbl_length = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.cbx_genre = new System.Windows.Forms.ComboBox();
            this.lbl_ageRestriction = new System.Windows.Forms.Label();
            this.txt_ageRestiction = new System.Windows.Forms.TextBox();
            this.label_genre = new System.Windows.Forms.Label();
            this.btn_addCgangeDelete = new System.Windows.Forms.Button();
            this.dgv_films = new System.Windows.Forms.DataGridView();
            this.gbx_films.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_films
            // 
            this.gbx_films.BackColor = System.Drawing.Color.Purple;
            this.gbx_films.Controls.Add(this.lbl_films);
            this.gbx_films.Location = new System.Drawing.Point(-2, 0);
            this.gbx_films.Name = "gbx_films";
            this.gbx_films.Size = new System.Drawing.Size(1329, 184);
            this.gbx_films.TabIndex = 0;
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
            // lbl_films
            // 
            this.lbl_films.AutoSize = true;
            this.lbl_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_films.ForeColor = System.Drawing.Color.White;
            this.lbl_films.Location = new System.Drawing.Point(270, 24);
            this.lbl_films.Name = "lbl_films";
            this.lbl_films.Size = new System.Drawing.Size(309, 160);
            this.lbl_films.TabIndex = 0;
            this.lbl_films.Text = "Films";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_films);
            this.groupBox1.Controls.Add(this.btn_addCgangeDelete);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.lbl_length);
            this.groupBox1.Controls.Add(this.txt_length);
            this.groupBox1.Controls.Add(this.cbx_genre);
            this.groupBox1.Controls.Add(this.lbl_ageRestriction);
            this.groupBox1.Controls.Add(this.txt_ageRestiction);
            this.groupBox1.Controls.Add(this.label_genre);
            this.groupBox1.Controls.Add(this.lbl_sellingPrice);
            this.groupBox1.Controls.Add(this.txt_sellingPrice);
            this.groupBox1.Controls.Add(this.lbl_filmCost);
            this.groupBox1.Controls.Add(this.txt_filmCost);
            this.groupBox1.Controls.Add(this.cbx_filmID);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.lbl_filmID);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(254, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 560);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Films";
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(49, 123);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(98, 60);
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
            // cbx_filmID
            // 
            this.cbx_filmID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filmID.FormattingEnabled = true;
            this.cbx_filmID.Location = new System.Drawing.Point(252, 63);
            this.cbx_filmID.Name = "cbx_filmID";
            this.cbx_filmID.Size = new System.Drawing.Size(234, 48);
            this.cbx_filmID.TabIndex = 5;
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
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(540, 255);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(105, 48);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Status";
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(769, 255);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(234, 48);
            this.txt_status.TabIndex = 16;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(540, 63);
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
            this.cbx_genre.Location = new System.Drawing.Point(769, 191);
            this.cbx_genre.Name = "cbx_genre";
            this.cbx_genre.Size = new System.Drawing.Size(234, 48);
            this.cbx_genre.TabIndex = 13;
            // 
            // lbl_ageRestriction
            // 
            this.lbl_ageRestriction.AutoSize = true;
            this.lbl_ageRestriction.Location = new System.Drawing.Point(540, 126);
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
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(540, 194);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(100, 48);
            this.label_genre.TabIndex = 10;
            this.label_genre.Text = "Genre";
            // 
            // btn_addCgangeDelete
            // 
            this.btn_addCgangeDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_addCgangeDelete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCgangeDelete.ForeColor = System.Drawing.Color.White;
            this.btn_addCgangeDelete.Location = new System.Drawing.Point(883, 493);
            this.btn_addCgangeDelete.Name = "btn_addCgangeDelete";
            this.btn_addCgangeDelete.Size = new System.Drawing.Size(160, 51);
            this.btn_addCgangeDelete.TabIndex = 3;
            this.btn_addCgangeDelete.Text = "Add Film";
            this.btn_addCgangeDelete.UseVisualStyleBackColor = false;
            // 
            // dgv_films
            // 
            this.dgv_films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_films.Location = new System.Drawing.Point(36, 326);
            this.dgv_films.Name = "dgv_films";
            this.dgv_films.RowHeadersWidth = 51;
            this.dgv_films.RowTemplate.Height = 24;
            this.dgv_films.Size = new System.Drawing.Size(970, 150);
            this.dgv_films.TabIndex = 18;
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 762);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbx_films);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.gbx_films.ResumeLayout(false);
            this.gbx_films.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gbx_films;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_films;
        private System.Windows.Forms.Label lbl_addFilm;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Label lbl_deleteFilm;
        private System.Windows.Forms.Label lbl_updateFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.ComboBox cbx_genre;
        private System.Windows.Forms.Label lbl_ageRestriction;
        private System.Windows.Forms.TextBox txt_ageRestiction;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label lbl_sellingPrice;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label lbl_filmCost;
        private System.Windows.Forms.TextBox txt_filmCost;
        private System.Windows.Forms.ComboBox cbx_filmID;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_filmID;
        private System.Windows.Forms.DataGridView dgv_films;
        private System.Windows.Forms.Button btn_addCgangeDelete;
    }
}