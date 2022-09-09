
namespace Genre
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.txtbGenreId = new System.Windows.Forms.TextBox();
            this.comboBoxDescription = new System.Windows.Forms.ComboBox();
            this.dtgDisplay = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblUpdateGenre = new System.Windows.Forms.Label();
            this.lblDeleteGenre = new System.Windows.Forms.Label();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.LblTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-145, -10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 217);
            this.panel2.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(562, 55);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(243, 103);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Genres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtbDescription);
            this.groupBox1.Controls.Add(this.txtbGenreId);
            this.groupBox1.Controls.Add(this.comboBoxDescription);
            this.groupBox1.Controls.Add(this.dtgDisplay);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblGenreID);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(253, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 460);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Genre";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(646, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 52);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(646, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 52);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(646, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 52);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(153, 116);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(211, 33);
            this.txtbDescription.TabIndex = 8;
            // 
            // txtbGenreId
            // 
            this.txtbGenreId.Location = new System.Drawing.Point(153, 46);
            this.txtbGenreId.Name = "txtbGenreId";
            this.txtbGenreId.Size = new System.Drawing.Size(211, 33);
            this.txtbGenreId.TabIndex = 7;
            // 
            // comboBoxDescription
            // 
            this.comboBoxDescription.FormattingEnabled = true;
            this.comboBoxDescription.Location = new System.Drawing.Point(153, 113);
            this.comboBoxDescription.Name = "comboBoxDescription";
            this.comboBoxDescription.Size = new System.Drawing.Size(211, 33);
            this.comboBoxDescription.TabIndex = 6;
            // 
            // dtgDisplay
            // 
            this.dtgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisplay.Location = new System.Drawing.Point(34, 168);
            this.dtgDisplay.Name = "dtgDisplay";
            this.dtgDisplay.Size = new System.Drawing.Size(596, 185);
            this.dtgDisplay.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 116);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 27);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Location = new System.Drawing.Point(6, 59);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(73, 27);
            this.lblGenreID.TabIndex = 0;
            this.lblGenreID.Text = "Genre ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.lblUpdateGenre);
            this.panel1.Controls.Add(this.lblDeleteGenre);
            this.panel1.Controls.Add(this.lblAddGenre);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(2, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 555);
            this.panel1.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrevious.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(28, 378);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(139, 52);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // lblUpdateGenre
            // 
            this.lblUpdateGenre.AutoSize = true;
            this.lblUpdateGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateGenre.ForeColor = System.Drawing.Color.White;
            this.lblUpdateGenre.Location = new System.Drawing.Point(13, 183);
            this.lblUpdateGenre.Name = "lblUpdateGenre";
            this.lblUpdateGenre.Size = new System.Drawing.Size(165, 39);
            this.lblUpdateGenre.TabIndex = 7;
            this.lblUpdateGenre.Text = "Update  Genre";
            this.lblUpdateGenre.Click += new System.EventHandler(this.lblUpdateGenre_Click);
            // 
            // lblDeleteGenre
            // 
            this.lblDeleteGenre.AutoSize = true;
            this.lblDeleteGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGenre.ForeColor = System.Drawing.Color.White;
            this.lblDeleteGenre.Location = new System.Drawing.Point(13, 112);
            this.lblDeleteGenre.Name = "lblDeleteGenre";
            this.lblDeleteGenre.Size = new System.Drawing.Size(154, 39);
            this.lblDeleteGenre.TabIndex = 6;
            this.lblDeleteGenre.Text = "Delete Genre";
            this.lblDeleteGenre.Click += new System.EventHandler(this.lblDeleteGenre_Click);
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGenre.ForeColor = System.Drawing.Color.White;
            this.lblAddGenre.Location = new System.Drawing.Point(13, 46);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(126, 39);
            this.lblAddGenre.TabIndex = 5;
            this.lblAddGenre.Text = "Add Genre";
            this.lblAddGenre.Click += new System.EventHandler(this.lblAddGenre_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 587);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenre";
            this.Text = "frmGenres";
            this.Load += new System.EventHandler(this.frmGenre_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbGenreId;
        private System.Windows.Forms.ComboBox comboBoxDescription;
        private System.Windows.Forms.DataGridView dtgDisplay;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenreID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblUpdateGenre;
        private System.Windows.Forms.Label lblDeleteGenre;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}