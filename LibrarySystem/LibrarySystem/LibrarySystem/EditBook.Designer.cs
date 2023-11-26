namespace LibrarySystem
{
    partial class EditBook
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
            this.URLText = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PublisherNameText = new System.Windows.Forms.Label();
            this.AuthorNameText = new System.Windows.Forms.Label();
            this.TiltleText = new System.Windows.Forms.Label();
            this.PublisherYearText = new System.Windows.Forms.Label();
            this.GenreText = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.PublishingYearTextbox = new System.Windows.Forms.TextBox();
            this.ISBNtext = new System.Windows.Forms.Label();
            this.ISBNtextbox = new System.Windows.Forms.TextBox();
            this.but_AddBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLText
            // 
            this.URLText.AutoSize = true;
            this.URLText.Location = new System.Drawing.Point(425, 216);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(57, 13);
            this.URLText.TabIndex = 56;
            this.URLText.Text = "Book URL";
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(512, 209);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(231, 20);
            this.URLTextbox.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "PUBLISHER NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(512, 248);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 54;
            this.comboBox2.ValueMember = "PUBLISHER ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "ao name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.ValueMember = "Ao ID";
            // 
            // PublisherNameText
            // 
            this.PublisherNameText.AutoSize = true;
            this.PublisherNameText.Location = new System.Drawing.Point(425, 251);
            this.PublisherNameText.Name = "PublisherNameText";
            this.PublisherNameText.Size = new System.Drawing.Size(81, 13);
            this.PublisherNameText.TabIndex = 52;
            this.PublisherNameText.Text = "Publisher Name";
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.AutoSize = true;
            this.AuthorNameText.Location = new System.Drawing.Point(49, 258);
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(69, 13);
            this.AuthorNameText.TabIndex = 51;
            this.AuthorNameText.Text = "Author Name";
            // 
            // TiltleText
            // 
            this.TiltleText.AutoSize = true;
            this.TiltleText.Location = new System.Drawing.Point(53, 171);
            this.TiltleText.Name = "TiltleText";
            this.TiltleText.Size = new System.Drawing.Size(27, 13);
            this.TiltleText.TabIndex = 50;
            this.TiltleText.Text = "Title";
            // 
            // PublisherYearText
            // 
            this.PublisherYearText.AutoSize = true;
            this.PublisherYearText.Location = new System.Drawing.Point(38, 298);
            this.PublisherYearText.Name = "PublisherYearText";
            this.PublisherYearText.Size = new System.Drawing.Size(80, 13);
            this.PublisherYearText.TabIndex = 49;
            this.PublisherYearText.Text = "Publishing Year";
            // 
            // GenreText
            // 
            this.GenreText.AutoSize = true;
            this.GenreText.Location = new System.Drawing.Point(48, 216);
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(36, 13);
            this.GenreText.TabIndex = 48;
            this.GenreText.Text = "Genre";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(132, 168);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(231, 20);
            this.TitleTextbox.TabIndex = 46;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(132, 209);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(231, 20);
            this.GenreTextbox.TabIndex = 45;
            // 
            // PublishingYearTextbox
            // 
            this.PublishingYearTextbox.Location = new System.Drawing.Point(132, 291);
            this.PublishingYearTextbox.Name = "PublishingYearTextbox";
            this.PublishingYearTextbox.Size = new System.Drawing.Size(231, 20);
            this.PublishingYearTextbox.TabIndex = 44;
            // 
            // ISBNtext
            // 
            this.ISBNtext.AutoSize = true;
            this.ISBNtext.Location = new System.Drawing.Point(48, 131);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.Size = new System.Drawing.Size(32, 13);
            this.ISBNtext.TabIndex = 47;
            this.ISBNtext.Text = "ISBN";
            // 
            // ISBNtextbox
            // 
            this.ISBNtextbox.Location = new System.Drawing.Point(132, 128);
            this.ISBNtextbox.Name = "ISBNtextbox";
            this.ISBNtextbox.Size = new System.Drawing.Size(231, 20);
            this.ISBNtextbox.TabIndex = 43;
            // 
            // but_AddBook
            // 
            this.but_AddBook.Location = new System.Drawing.Point(270, 357);
            this.but_AddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_AddBook.Name = "but_AddBook";
            this.but_AddBook.Size = new System.Drawing.Size(236, 26);
            this.but_AddBook.TabIndex = 57;
            this.but_AddBook.Text = "Save Changes";
            this.but_AddBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 26);
            this.button1.TabIndex = 58;
            this.button1.Text = "Delete Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_AddBook);
            this.Controls.Add(this.URLText);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PublisherNameText);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.TiltleText);
            this.Controls.Add(this.PublisherYearText);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.ISBNtext);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.PublishingYearTextbox);
            this.Controls.Add(this.ISBNtextbox);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLText;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PublisherNameText;
        private System.Windows.Forms.Label AuthorNameText;
        private System.Windows.Forms.Label TiltleText;
        private System.Windows.Forms.Label PublisherYearText;
        private System.Windows.Forms.Label GenreText;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.TextBox PublishingYearTextbox;
        private System.Windows.Forms.Label ISBNtext;
        private System.Windows.Forms.TextBox ISBNtextbox;
        private System.Windows.Forms.Button but_AddBook;
        private System.Windows.Forms.Button button1;
    }
}