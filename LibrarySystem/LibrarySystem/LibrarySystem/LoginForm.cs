using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    public partial class LoginForm : Form
    {
        private string _userType;
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void but_Signup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm("Student","new",0);
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void but_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from USERR where USERNAME = '" + txt_Name.Text + "'and PASSWORD ='" + txt_Pass.Text + "'", con);
            SqlDataReader sqlReader = cmd.ExecuteReader();
           // sqlReader.Read();
            //var userTypeID = sqlReader["USERTYPEID"];
            

            if (sqlReader.Read())
            {
                var userType = (int)sqlReader["USERTYPEID"];
                var userID = (int)sqlReader["USERID"];

                if (userType == 1)
                    _userType = "Admin";
                else
                    _userType = "user";

                MessageBox.Show(sqlReader["USERTYPEID"] + " - " + _userType + " - " + sqlReader.GetValue(2));
                MainForm mainForm = new MainForm(_userType,userID);
                mainForm.Text = mainForm.Text + "  -  " + _userType;
                this.Hide();
                con.Close();
                mainForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Check your password and ID ");
            }

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
