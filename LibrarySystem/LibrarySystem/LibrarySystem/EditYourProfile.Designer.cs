namespace LibrarySystem
{
    partial class EditYourProfile
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
            this.but_Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.btn_RemoveAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Submit
            // 
            this.but_Submit.Location = new System.Drawing.Point(183, 271);
            this.but_Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Submit.Name = "but_Submit";
            this.but_Submit.Size = new System.Drawing.Size(236, 26);
            this.but_Submit.TabIndex = 32;
            this.but_Submit.Text = "Save Changes";
            this.but_Submit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(214, 224);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(170, 20);
            this.txt_Pass.TabIndex = 29;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(215, 100);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(170, 20);
            this.txt_UserName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "User Name";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(215, 138);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(170, 20);
            this.txt_Email.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Card ID";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(215, 183);
            this.txt_CardID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(170, 20);
            this.txt_CardID.TabIndex = 21;
            // 
            // btn_RemoveAcc
            // 
            this.btn_RemoveAcc.Location = new System.Drawing.Point(211, 314);
            this.btn_RemoveAcc.Name = "btn_RemoveAcc";
            this.btn_RemoveAcc.Size = new System.Drawing.Size(174, 23);
            this.btn_RemoveAcc.TabIndex = 33;
            this.btn_RemoveAcc.Text = "Remove your Account";
            this.btn_RemoveAcc.UseVisualStyleBackColor = true;
            this.btn_RemoveAcc.Click += new System.EventHandler(this.btn_RemoveAcc_Click);
            // 
            // EditYourProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 359);
            this.Controls.Add(this.btn_RemoveAcc);
            this.Controls.Add(this.but_Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CardID);
            this.Name = "EditYourProfile";
            this.Text = "EditYourProfile";
            this.Load += new System.EventHandler(this.EditYourProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.Button btn_RemoveAcc;
    }
}