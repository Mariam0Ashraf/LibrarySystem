namespace LibrarySystem
{
    partial class SignUpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.but_Submit = new System.Windows.Forms.Button();
            this.check_Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card ID";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(184, 138);
            this.txt_CardID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(170, 20);
            this.txt_CardID.TabIndex = 7;
            this.txt_CardID.TextChanged += new System.EventHandler(this.txt_CardID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(187, 101);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(170, 20);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(187, 62);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(170, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(187, 176);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(170, 20);
            this.txt_Pass.TabIndex = 15;
            // 
            // but_Submit
            // 
            this.but_Submit.Location = new System.Drawing.Point(121, 254);
            this.but_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Submit.Name = "but_Submit";
            this.but_Submit.Size = new System.Drawing.Size(236, 26);
            this.but_Submit.TabIndex = 18;
            this.but_Submit.Text = "Submit";
            this.but_Submit.UseVisualStyleBackColor = true;
            this.but_Submit.Click += new System.EventHandler(this.but_Submit_Click);
            // 
            // check_Admin
            // 
            this.check_Admin.AutoSize = true;
            this.check_Admin.Location = new System.Drawing.Point(187, 212);
            this.check_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_Admin.Name = "check_Admin";
            this.check_Admin.Size = new System.Drawing.Size(66, 17);
            this.check_Admin.TabIndex = 19;
            this.check_Admin.Text = "Is Admin";
            this.check_Admin.UseVisualStyleBackColor = true;
            this.check_Admin.Visible = false;
            this.check_Admin.CheckedChanged += new System.EventHandler(this.check_Admin_CheckedChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 313);
            this.Controls.Add(this.check_Admin);
            this.Controls.Add(this.but_Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CardID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button but_Submit;
        private System.Windows.Forms.CheckBox check_Admin;
    }
}