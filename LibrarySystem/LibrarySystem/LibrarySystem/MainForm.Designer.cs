namespace LibrarySystem
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_AddBook = new System.Windows.Forms.Button();
            this.but_Browse = new System.Windows.Forms.Button();
            this.but_DelBook = new System.Windows.Forms.Button();
            this.but_EditBook = new System.Windows.Forms.Button();
            this.btn_EditProfile = new System.Windows.Forms.Button();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.BrowsingTextbox = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOKURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHINGYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookName,
            this.GENRE,
            this.aoname,
            this.BOOKURL,
            this.PUBLISHINGYEAR});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(944, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // but_AddBook
            // 
            this.but_AddBook.Location = new System.Drawing.Point(482, 383);
            this.but_AddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_AddBook.Name = "but_AddBook";
            this.but_AddBook.Size = new System.Drawing.Size(93, 21);
            this.but_AddBook.TabIndex = 5;
            this.but_AddBook.Text = "Add Book";
            this.but_AddBook.UseVisualStyleBackColor = true;
            this.but_AddBook.Visible = false;
            this.but_AddBook.Click += new System.EventHandler(this.but_AddBook_Click);
            // 
            // but_Browse
            // 
            this.but_Browse.Location = new System.Drawing.Point(71, 383);
            this.but_Browse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Browse.Name = "but_Browse";
            this.but_Browse.Size = new System.Drawing.Size(93, 21);
            this.but_Browse.TabIndex = 4;
            this.but_Browse.Text = "Browse";
            this.but_Browse.UseVisualStyleBackColor = true;
            this.but_Browse.Click += new System.EventHandler(this.but_Browse_Click);
            // 
            // but_DelBook
            // 
            this.but_DelBook.Location = new System.Drawing.Point(693, 383);
            this.but_DelBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_DelBook.Name = "but_DelBook";
            this.but_DelBook.Size = new System.Drawing.Size(93, 21);
            this.but_DelBook.TabIndex = 7;
            this.but_DelBook.Text = "Delete Book";
            this.but_DelBook.UseVisualStyleBackColor = true;
            this.but_DelBook.Visible = false;
            this.but_DelBook.Click += new System.EventHandler(this.but_DelBook_Click);
            // 
            // but_EditBook
            // 
            this.but_EditBook.Location = new System.Drawing.Point(583, 383);
            this.but_EditBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_EditBook.Name = "but_EditBook";
            this.but_EditBook.Size = new System.Drawing.Size(93, 21);
            this.but_EditBook.TabIndex = 6;
            this.but_EditBook.Text = "Edit Book";
            this.but_EditBook.UseVisualStyleBackColor = true;
            this.but_EditBook.Visible = false;
            this.but_EditBook.Click += new System.EventHandler(this.but_EditBook_Click);
            // 
            // btn_EditProfile
            // 
            this.btn_EditProfile.Location = new System.Drawing.Point(820, 383);
            this.btn_EditProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditProfile.Name = "btn_EditProfile";
            this.btn_EditProfile.Size = new System.Drawing.Size(93, 21);
            this.btn_EditProfile.TabIndex = 9;
            this.btn_EditProfile.Text = "Edit your profile";
            this.btn_EditProfile.UseVisualStyleBackColor = true;
            this.btn_EditProfile.Click += new System.EventHandler(this.btn_EditProfile_Click);
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.Location = new System.Drawing.Point(820, 431);
            this.btn_AddAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(93, 21);
            this.btn_AddAdmin.TabIndex = 10;
            this.btn_AddAdmin.Text = "Add Admin";
            this.btn_AddAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddAdmin.UseVisualStyleBackColor = true;
            this.btn_AddAdmin.Visible = false;
            this.btn_AddAdmin.Click += new System.EventHandler(this.btn_AddAdmin_Click);
            // 
            // BrowsingTextbox
            // 
            this.BrowsingTextbox.Location = new System.Drawing.Point(190, 383);
            this.BrowsingTextbox.Name = "BrowsingTextbox";
            this.BrowsingTextbox.Size = new System.Drawing.Size(244, 20);
            this.BrowsingTextbox.TabIndex = 11;
            this.BrowsingTextbox.TextChanged += new System.EventHandler(this.BrowsingTextbox_TextChanged);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "BookID";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 125;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "TITLE";
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 125;
            // 
            // GENRE
            // 
            this.GENRE.DataPropertyName = "GENRE";
            this.GENRE.HeaderText = "Genre";
            this.GENRE.Name = "GENRE";
            this.GENRE.ReadOnly = true;
            // 
            // aoname
            // 
            this.aoname.DataPropertyName = "aoname";
            this.aoname.HeaderText = "Author Name";
            this.aoname.Name = "aoname";
            this.aoname.ReadOnly = true;
            // 
            // BOOKURL
            // 
            this.BOOKURL.DataPropertyName = "BOOKURL";
            this.BOOKURL.HeaderText = "Book URL";
            this.BOOKURL.Name = "BOOKURL";
            this.BOOKURL.ReadOnly = true;
            // 
            // PUBLISHINGYEAR
            // 
            this.PUBLISHINGYEAR.DataPropertyName = "PUBLISHINGYEAR";
            this.PUBLISHINGYEAR.HeaderText = "publishing year";
            this.PUBLISHINGYEAR.Name = "PUBLISHINGYEAR";
            this.PUBLISHINGYEAR.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.BrowsingTextbox);
            this.Controls.Add(this.btn_AddAdmin);
            this.Controls.Add(this.btn_EditProfile);
            this.Controls.Add(this.but_DelBook);
            this.Controls.Add(this.but_EditBook);
            this.Controls.Add(this.but_AddBook);
            this.Controls.Add(this.but_Browse);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_AddBook;
        private System.Windows.Forms.Button but_Browse;
        private System.Windows.Forms.Button but_DelBook;
        private System.Windows.Forms.Button but_EditBook;
        private System.Windows.Forms.Button btn_EditProfile;
        private System.Windows.Forms.Button btn_AddAdmin;
        private System.Windows.Forms.TextBox BrowsingTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn aoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOKURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHINGYEAR;
    }
}