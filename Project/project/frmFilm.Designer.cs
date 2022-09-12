
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilm));
            this.pnl_purple = new System.Windows.Forms.Panel();
            this.lbl_films = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_helpClose = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.lbl_deleteFilm = new System.Windows.Forms.Label();
            this.lbl_updateFilm = new System.Windows.Forms.Label();
            this.lbl_addFilm = new System.Windows.Forms.Label();
            this.gbx_films = new System.Windows.Forms.GroupBox();
            this.pcb_help = new System.Windows.Forms.PictureBox();
            this.txt_film_ID = new System.Windows.Forms.TextBox();
            this.lv_genre = new System.Windows.Forms.ListView();
            this.lv_title = new System.Windows.Forms.ListView();
            this.lv_filmID = new System.Windows.Forms.ListView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.rdo_Inactive = new System.Windows.Forms.RadioButton();
            this.rdo_Active = new System.Windows.Forms.RadioButton();
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
            this.pnl_purple.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbx_films.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_help)).BeginInit();
            this.pnl_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_purple
            // 
            this.pnl_purple.BackColor = System.Drawing.Color.Purple;
            this.pnl_purple.Controls.Add(this.lbl_films);
            this.pnl_purple.Location = new System.Drawing.Point(-2, 0);
            this.pnl_purple.Name = "pnl_purple";
            this.pnl_purple.Size = new System.Drawing.Size(1821, 184);
            this.pnl_purple.TabIndex = 43;
            // 
            // lbl_films
            // 
            this.lbl_films.AutoSize = true;
            this.lbl_films.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_films.ForeColor = System.Drawing.Color.White;
            this.lbl_films.Location = new System.Drawing.Point(270, 24);
            this.lbl_films.Name = "lbl_films";
            this.lbl_films.Size = new System.Drawing.Size(247, 128);
            this.lbl_films.TabIndex = 42;
            this.lbl_films.Text = "Films";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btn_help);
            this.panel2.Controls.Add(this.btn_helpClose);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Controls.Add(this.lbl_deleteFilm);
            this.panel2.Controls.Add(this.lbl_updateFilm);
            this.panel2.Controls.Add(this.lbl_addFilm);
            this.panel2.Location = new System.Drawing.Point(-2, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 715);
            this.panel2.TabIndex = 1;
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_help.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.Location = new System.Drawing.Point(49, 528);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(160, 51);
            this.btn_help.TabIndex = 28;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_helpClose
            // 
            this.btn_helpClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_helpClose.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_helpClose.ForeColor = System.Drawing.Color.White;
            this.btn_helpClose.Location = new System.Drawing.Point(49, 585);
            this.btn_helpClose.Name = "btn_helpClose";
            this.btn_helpClose.Size = new System.Drawing.Size(160, 51);
            this.btn_helpClose.TabIndex = 29;
            this.btn_helpClose.Text = "Help Close";
            this.btn_helpClose.UseVisualStyleBackColor = false;
            this.btn_helpClose.Click += new System.EventHandler(this.btn_helpClose_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Purple;
            this.btn_previous.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(49, 642);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(160, 51);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // lbl_deleteFilm
            // 
            this.lbl_deleteFilm.AutoSize = true;
            this.lbl_deleteFilm.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteFilm.ForeColor = System.Drawing.Color.White;
            this.lbl_deleteFilm.Location = new System.Drawing.Point(41, 247);
            this.lbl_deleteFilm.Name = "lbl_deleteFilm";
            this.lbl_deleteFilm.Size = new System.Drawing.Size(171, 48);
            this.lbl_deleteFilm.TabIndex = 46;
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
            this.lbl_updateFilm.TabIndex = 45;
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
            this.lbl_addFilm.TabIndex = 44;
            this.lbl_addFilm.Text = "Add Film";
            this.lbl_addFilm.Click += new System.EventHandler(this.lbl_addFilm_Click);
            // 
            // gbx_films
            // 
            this.gbx_films.Controls.Add(this.pcb_help);
            this.gbx_films.Controls.Add(this.txt_film_ID);
            this.gbx_films.Controls.Add(this.lv_genre);
            this.gbx_films.Controls.Add(this.lv_title);
            this.gbx_films.Controls.Add(this.lv_filmID);
            this.gbx_films.Controls.Add(this.btn_clear);
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
            this.gbx_films.Size = new System.Drawing.Size(1553, 695);
            this.gbx_films.TabIndex = 41;
            this.gbx_films.TabStop = false;
            this.gbx_films.Text = "Add";
            // 
            // pcb_help
            // 
            this.pcb_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_help.BackgroundImage")));
            this.pcb_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_help.Location = new System.Drawing.Point(36, 287);
            this.pcb_help.Name = "pcb_help";
            this.pcb_help.Size = new System.Drawing.Size(543, 398);
            this.pcb_help.TabIndex = 28;
            this.pcb_help.TabStop = false;
            // 
            // txt_film_ID
            // 
            this.txt_film_ID.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_film_ID.Location = new System.Drawing.Point(252, 63);
            this.txt_film_ID.Name = "txt_film_ID";
            this.txt_film_ID.Size = new System.Drawing.Size(234, 48);
            this.txt_film_ID.TabIndex = 0;
            // 
            // lv_genre
            // 
            this.lv_genre.HideSelection = false;
            this.lv_genre.Location = new System.Drawing.Point(249, 191);
            this.lv_genre.Name = "lv_genre";
            this.lv_genre.Size = new System.Drawing.Size(234, 48);
            this.lv_genre.TabIndex = 2;
            this.lv_genre.UseCompatibleStateImageBehavior = false;
            // 
            // lv_title
            // 
            this.lv_title.HideSelection = false;
            this.lv_title.Location = new System.Drawing.Point(252, 126);
            this.lv_title.Name = "lv_title";
            this.lv_title.Size = new System.Drawing.Size(234, 49);
            this.lv_title.TabIndex = 1;
            this.lv_title.UseCompatibleStateImageBehavior = false;
            // 
            // lv_filmID
            // 
            this.lv_filmID.HideSelection = false;
            this.lv_filmID.Location = new System.Drawing.Point(252, 63);
            this.lv_filmID.Name = "lv_filmID";
            this.lv_filmID.Size = new System.Drawing.Size(234, 48);
            this.lv_filmID.TabIndex = 24;
            this.lv_filmID.UseCompatibleStateImageBehavior = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_clear.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(36, 634);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(160, 51);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pnl_Status
            // 
            this.pnl_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Status.Controls.Add(this.rdo_Inactive);
            this.pnl_Status.Controls.Add(this.rdo_Active);
            this.pnl_Status.Location = new System.Drawing.Point(1307, 131);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(234, 75);
            this.pnl_Status.TabIndex = 7;
            // 
            // rdo_Inactive
            // 
            this.rdo_Inactive.AutoSize = true;
            this.rdo_Inactive.Font = new System.Drawing.Font("Arial", 11F);
            this.rdo_Inactive.Location = new System.Drawing.Point(133, 25);
            this.rdo_Inactive.Name = "rdo_Inactive";
            this.rdo_Inactive.Size = new System.Drawing.Size(96, 26);
            this.rdo_Inactive.TabIndex = 9;
            this.rdo_Inactive.TabStop = true;
            this.rdo_Inactive.Text = "Inactive";
            this.rdo_Inactive.UseVisualStyleBackColor = true;
            // 
            // rdo_Active
            // 
            this.rdo_Active.AutoSize = true;
            this.rdo_Active.Font = new System.Drawing.Font("Arial", 11F);
            this.rdo_Active.Location = new System.Drawing.Point(3, 25);
            this.rdo_Active.Name = "rdo_Active";
            this.rdo_Active.Size = new System.Drawing.Size(83, 26);
            this.rdo_Active.TabIndex = 8;
            this.rdo_Active.TabStop = true;
            this.rdo_Active.Text = "Active";
            this.rdo_Active.UseVisualStyleBackColor = true;
            // 
            // cbx_title
            // 
            this.cbx_title.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_title.FormattingEnabled = true;
            this.cbx_title.Location = new System.Drawing.Point(252, 127);
            this.cbx_title.Name = "cbx_title";
            this.cbx_title.Size = new System.Drawing.Size(234, 48);
            this.cbx_title.TabIndex = 21;
            this.cbx_title.SelectedIndexChanged += new System.EventHandler(this.cbx_title_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_update.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(1381, 638);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(160, 51);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1381, 638);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 51);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_films
            // 
            this.dgv_films.AllowUserToAddRows = false;
            this.dgv_films.AllowUserToDeleteRows = false;
            this.dgv_films.AllowUserToOrderColumns = true;
            this.dgv_films.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_films.ColumnHeadersHeight = 40;
            this.dgv_films.Location = new System.Drawing.Point(36, 287);
            this.dgv_films.Name = "dgv_films";
            this.dgv_films.ReadOnly = true;
            this.dgv_films.RowHeadersWidth = 30;
            this.dgv_films.RowTemplate.Height = 35;
            this.dgv_films.Size = new System.Drawing.Size(1511, 329);
            this.dgv_films.TabIndex = 18;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1381, 638);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 51);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(1114, 131);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(105, 48);
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Text = "Status";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(1114, 67);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(112, 48);
            this.lbl_length.TabIndex = 15;
            this.lbl_length.Text = "Length";
            // 
            // txt_length
            // 
            this.txt_length.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_length.Location = new System.Drawing.Point(1307, 64);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(234, 48);
            this.txt_length.TabIndex = 6;
            // 
            // cbx_genre
            // 
            this.cbx_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_genre.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_genre.FormattingEnabled = true;
            this.cbx_genre.Location = new System.Drawing.Point(252, 191);
            this.cbx_genre.Name = "cbx_genre";
            this.cbx_genre.Size = new System.Drawing.Size(231, 48);
            this.cbx_genre.TabIndex = 13;
            // 
            // lbl_ageRestriction
            // 
            this.lbl_ageRestriction.AutoSize = true;
            this.lbl_ageRestriction.Location = new System.Drawing.Point(565, 191);
            this.lbl_ageRestriction.Name = "lbl_ageRestriction";
            this.lbl_ageRestriction.Size = new System.Drawing.Size(223, 48);
            this.lbl_ageRestriction.TabIndex = 12;
            this.lbl_ageRestriction.Text = "Age Restriction";
            // 
            // txt_ageRestiction
            // 
            this.txt_ageRestiction.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ageRestiction.Location = new System.Drawing.Point(811, 191);
            this.txt_ageRestiction.Name = "txt_ageRestiction";
            this.txt_ageRestiction.Size = new System.Drawing.Size(234, 48);
            this.txt_ageRestiction.TabIndex = 5;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(49, 191);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(100, 48);
            this.lbl_genre.TabIndex = 10;
            this.lbl_genre.Text = "Genre";
            // 
            // lbl_sellingPrice
            // 
            this.lbl_sellingPrice.AutoSize = true;
            this.lbl_sellingPrice.Location = new System.Drawing.Point(565, 128);
            this.lbl_sellingPrice.Name = "lbl_sellingPrice";
            this.lbl_sellingPrice.Size = new System.Drawing.Size(188, 48);
            this.lbl_sellingPrice.TabIndex = 9;
            this.lbl_sellingPrice.Text = "Selling Price";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingPrice.Location = new System.Drawing.Point(811, 131);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(234, 48);
            this.txt_sellingPrice.TabIndex = 4;
            // 
            // lbl_filmCost
            // 
            this.lbl_filmCost.AutoSize = true;
            this.lbl_filmCost.Location = new System.Drawing.Point(565, 64);
            this.lbl_filmCost.Name = "lbl_filmCost";
            this.lbl_filmCost.Size = new System.Drawing.Size(143, 48);
            this.lbl_filmCost.TabIndex = 7;
            this.lbl_filmCost.Text = "Film Cost";
            // 
            // txt_filmCost
            // 
            this.txt_filmCost.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filmCost.Location = new System.Drawing.Point(811, 67);
            this.txt_filmCost.Name = "txt_filmCost";
            this.txt_filmCost.Size = new System.Drawing.Size(234, 48);
            this.txt_filmCost.TabIndex = 3;
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
            this.lbl_title.Location = new System.Drawing.Point(49, 131);
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
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 897);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcb_help)).EndInit();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_films)).EndInit();
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
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ListView lv_genre;
        private System.Windows.Forms.ListView lv_title;
        private System.Windows.Forms.ListView lv_filmID;
        private System.Windows.Forms.TextBox txt_film_ID;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_helpClose;
        private System.Windows.Forms.PictureBox pcb_help;
    }
}