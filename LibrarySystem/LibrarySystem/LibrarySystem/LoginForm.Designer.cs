namespace LibrarySystem
{
    partial class LoginForm
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.but_Login = new System.Windows.Forms.Button();
            this.but_Signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(202, 35);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(170, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(202, 59);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(170, 20);
            this.txt_Pass.TabIndex = 1;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // but_Login
            // 
            this.but_Login.Location = new System.Drawing.Point(126, 106);
            this.but_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Login.Name = "but_Login";
            this.but_Login.Size = new System.Drawing.Size(93, 21);
            this.but_Login.TabIndex = 2;
            this.but_Login.Text = "Login";
            this.but_Login.UseVisualStyleBackColor = true;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // but_Signup
            // 
            this.but_Signup.Location = new System.Drawing.Point(249, 106);
            this.but_Signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Signup.Name = "but_Signup";
            this.but_Signup.Size = new System.Drawing.Size(93, 21);
            this.but_Signup.TabIndex = 3;
            this.but_Signup.Text = "Sign Up";
            this.but_Signup.UseVisualStyleBackColor = true;
            this.but_Signup.Click += new System.EventHandler(this.but_Signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Signup);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Button but_Signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}