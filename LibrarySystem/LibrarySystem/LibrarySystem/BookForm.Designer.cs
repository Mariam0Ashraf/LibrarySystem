namespace LibrarySystem
{
    partial class BookForm
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
            this.AuthorNameText = new System.Windows.Forms.Label();
            this.TiltleText = new System.Windows.Forms.Label();
            this.PublisherYearText = new System.Windows.Forms.Label();
            this.GenreText = new System.Windows.Forms.Label();
            this.ISBNtext = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.GenreTextbox = new System.Windows.Forms.TextBox();
            this.PublishingYearTextbox = new System.Windows.Forms.TextBox();
            this.ISBNtextbox = new System.Windows.Forms.TextBox();
            this.but_AddBook = new System.Windows.Forms.Button();
            this.PublisherNameText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uni_LibraryDataSet = new LibrarySystem.Uni_LibraryDataSet();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new LibrarySystem.Uni_LibraryDataSetTableAdapters.authorTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pUBLISHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHERTableAdapter = new LibrarySystem.Uni_LibraryDataSetTableAdapters.PUBLISHERTableAdapter();
            this.pUBLISHERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.URLTextbox = new System.Windows.Forms.TextBox();
            this.URLText = new System.Windows.Forms.Label();
            this.uni_LibraryDataSet1 = new LibrarySystem.Uni_LibraryDataSet1();
            this.pUBLISHERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLISHERTableAdapter1 = new LibrarySystem.Uni_LibraryDataSet1TableAdapters.PUBLISHERTableAdapter();
            this.uni_LibraryDataSet2 = new LibrarySystem.Uni_LibraryDataSet2();
            this.authorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter1 = new LibrarySystem.Uni_LibraryDataSet2TableAdapters.authorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.AutoSize = true;
            this.AuthorNameText.Location = new System.Drawing.Point(64, 255);
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(69, 13);
            this.AuthorNameText.TabIndex = 30;
            this.AuthorNameText.Text = "Author Name";
            // 
            // TiltleText
            // 
            this.TiltleText.AutoSize = true;
            this.TiltleText.Location = new System.Drawing.Point(68, 168);
            this.TiltleText.Name = "TiltleText";
            this.TiltleText.Size = new System.Drawing.Size(27, 13);
            this.TiltleText.TabIndex = 24;
            this.TiltleText.Text = "Title";
            // 
            // PublisherYearText
            // 
            this.PublisherYearText.AutoSize = true;
            this.PublisherYearText.Location = new System.Drawing.Point(53, 295);
            this.PublisherYearText.Name = "PublisherYearText";
            this.PublisherYearText.Size = new System.Drawing.Size(80, 13);
            this.PublisherYearText.TabIndex = 23;
            this.PublisherYearText.Text = "Publishing Year";
            // 
            // GenreText
            // 
            this.GenreText.AutoSize = true;
            this.GenreText.Location = new System.Drawing.Point(63, 213);
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(36, 13);
            this.GenreText.TabIndex = 22;
            this.GenreText.Text = "Genre";
            // 
            // ISBNtext
            // 
            this.ISBNtext.AutoSize = true;
            this.ISBNtext.Location = new System.Drawing.Point(63, 128);
            this.ISBNtext.Name = "ISBNtext";
            this.ISBNtext.Size = new System.Drawing.Size(32, 13);
            this.ISBNtext.TabIndex = 21;
            this.ISBNtext.Text = "ISBN";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(147, 165);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(231, 20);
            this.TitleTextbox.TabIndex = 19;
            // 
            // GenreTextbox
            // 
            this.GenreTextbox.Location = new System.Drawing.Point(147, 206);
            this.GenreTextbox.Name = "GenreTextbox";
            this.GenreTextbox.Size = new System.Drawing.Size(231, 20);
            this.GenreTextbox.TabIndex = 18;
            // 
            // PublishingYearTextbox
            // 
            this.PublishingYearTextbox.Location = new System.Drawing.Point(147, 288);
            this.PublishingYearTextbox.Name = "PublishingYearTextbox";
            this.PublishingYearTextbox.Size = new System.Drawing.Size(231, 20);
            this.PublishingYearTextbox.TabIndex = 17;
            // 
            // ISBNtextbox
            // 
            this.ISBNtextbox.Enabled = false;
            this.ISBNtextbox.Location = new System.Drawing.Point(147, 125);
            this.ISBNtextbox.Name = "ISBNtextbox";
            this.ISBNtextbox.Size = new System.Drawing.Size(231, 20);
            this.ISBNtextbox.TabIndex = 16;
            // 
            // but_AddBook
            // 
            this.but_AddBook.Location = new System.Drawing.Point(290, 402);
            this.but_AddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_AddBook.Name = "but_AddBook";
            this.but_AddBook.Size = new System.Drawing.Size(236, 26);
            this.but_AddBook.TabIndex = 32;
            this.but_AddBook.Text = "Add";
            this.but_AddBook.UseVisualStyleBackColor = true;
            this.but_AddBook.Click += new System.EventHandler(this.but_AddBook_Click);
            // 
            // PublisherNameText
            // 
            this.PublisherNameText.AutoSize = true;
            this.PublisherNameText.Location = new System.Drawing.Point(440, 248);
            this.PublisherNameText.Name = "PublisherNameText";
            this.PublisherNameText.Size = new System.Drawing.Size(81, 13);
            this.PublisherNameText.TabIndex = 34;
            this.PublisherNameText.Text = "Publisher Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.authorBindingSource1, "Ao ID", true));
            this.comboBox1.DataSource = this.authorBindingSource1;
            this.comboBox1.DisplayMember = "aoname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "Ao ID";
            // 
            // uni_LibraryDataSet
            // 
            this.uni_LibraryDataSet.DataSetName = "Uni_LibraryDataSet";
            this.uni_LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.uni_LibraryDataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pUBLISHERBindingSource2, "PUBLISHERID", true));
            this.comboBox2.DataSource = this.pUBLISHERBindingSource2;
            this.comboBox2.DisplayMember = "PUBLISHERNAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(527, 245);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 21);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.ValueMember = "PUBLISHERID";
            // 
            // pUBLISHERBindingSource
            // 
            this.pUBLISHERBindingSource.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource.DataSource = this.uni_LibraryDataSet;
            // 
            // pUBLISHERTableAdapter
            // 
            this.pUBLISHERTableAdapter.ClearBeforeFill = true;
            // 
            // pUBLISHERBindingSource1
            // 
            this.pUBLISHERBindingSource1.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource1.DataSource = this.uni_LibraryDataSet;
            // 
            // URLTextbox
            // 
            this.URLTextbox.Location = new System.Drawing.Point(527, 206);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(231, 20);
            this.URLTextbox.TabIndex = 41;
            // 
            // URLText
            // 
            this.URLText.AutoSize = true;
            this.URLText.Location = new System.Drawing.Point(440, 213);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(57, 13);
            this.URLText.TabIndex = 42;
            this.URLText.Text = "Book URL";
            // 
            // uni_LibraryDataSet1
            // 
            this.uni_LibraryDataSet1.DataSetName = "Uni_LibraryDataSet1";
            this.uni_LibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pUBLISHERBindingSource2
            // 
            this.pUBLISHERBindingSource2.DataMember = "PUBLISHER";
            this.pUBLISHERBindingSource2.DataSource = this.uni_LibraryDataSet1;
            // 
            // pUBLISHERTableAdapter1
            // 
            this.pUBLISHERTableAdapter1.ClearBeforeFill = true;
            // 
            // uni_LibraryDataSet2
            // 
            this.uni_LibraryDataSet2.DataSetName = "Uni_LibraryDataSet2";
            this.uni_LibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource1
            // 
            this.authorBindingSource1.DataMember = "author";
            this.authorBindingSource1.DataSource = this.uni_LibraryDataSet2;
            // 
            // authorTableAdapter1
            // 
            this.authorTableAdapter1.ClearBeforeFill = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.URLText);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PublisherNameText);
            this.Controls.Add(this.but_AddBook);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.TiltleText);
            this.Controls.Add(this.PublisherYearText);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.ISBNtext);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.GenreTextbox);
            this.Controls.Add(this.PublishingYearTextbox);
            this.Controls.Add(this.ISBNtextbox);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLISHERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_LibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AuthorNameText;
        private System.Windows.Forms.Label TiltleText;
        private System.Windows.Forms.Label PublisherYearText;
        private System.Windows.Forms.Label GenreText;
        private System.Windows.Forms.Label ISBNtext;
        private System.Windows.Forms.TextBox TitleTextbox;
        private System.Windows.Forms.TextBox GenreTextbox;
        private System.Windows.Forms.TextBox PublishingYearTextbox;
        private System.Windows.Forms.TextBox ISBNtextbox;
        private System.Windows.Forms.Button but_AddBook;
        private System.Windows.Forms.Label PublisherNameText;
        private System.Windows.Forms.ComboBox comboBox1;
        private Uni_LibraryDataSet uni_LibraryDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private Uni_LibraryDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource;
        private Uni_LibraryDataSetTableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource1;
        private System.Windows.Forms.TextBox URLTextbox;
        private System.Windows.Forms.Label URLText;
        private Uni_LibraryDataSet1 uni_LibraryDataSet1;
        private System.Windows.Forms.BindingSource pUBLISHERBindingSource2;
        private Uni_LibraryDataSet1TableAdapters.PUBLISHERTableAdapter pUBLISHERTableAdapter1;
        private Uni_LibraryDataSet2 uni_LibraryDataSet2;
        private System.Windows.Forms.BindingSource authorBindingSource1;
        private Uni_LibraryDataSet2TableAdapters.authorTableAdapter authorTableAdapter1;
    }
}