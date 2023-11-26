using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibrarySystem
{
    public partial class SignUpForm : Form
    {
        private string _userType;
        private string _mode;
        private int _userID = 0;
        public SignUpForm(string userType,string mode, int userID)
        {
            InitializeComponent();
            _userType = userType;
            _mode = mode;
            _userID = userID;
        }

        private void but_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");
            con.Open();
           if (_mode=="new")
            {
                if (check_Admin.Checked)
                {
                    // Checkbox is checked
                    // Perform some action
                    //Admin
                    SqlCommand myCommandd = new SqlCommand("insert into USERR (USERNAME ,EMAIL,PASSWORD,CARDID,USERTYPEID) values('" + txt_Name.Text + "','" + txt_Email.Text + "','" + txt_Pass.Text + "','" + txt_CardID.Text + "',1)", con);
                    myCommandd.ExecuteNonQuery();
                }
                else
                {
                    //Student
                    SqlCommand myCommand = new SqlCommand("insert into USERR (USERNAME ,EMAIL,PASSWORD,CARDID,USERTYPEID) values('" + txt_Name.Text + "','" + txt_Email.Text + "','" + txt_Pass.Text + "','" + txt_CardID.Text + "',2)", con);
                    myCommand.ExecuteNonQuery();
                    // Checkbox is not checked
                    // Perform some other action
                }
            }
           else if (_mode =="edit")
            {
                if (check_Admin.Checked)
                {
                    // Checkbox is checked
                    // Perform some action
                    //Admin
                    SqlCommand myCommandd = new SqlCommand("update USERR set USERNAME = '"+ txt_Name.Text+ "', EMAIL = '"+txt_Email.Text +"', PASSWORD ='"+txt_Pass.Text+
                                                            "' ,CARDID = '" + txt_CardID.Text +"', USERTYPEID = 1 where USERID ="+_userID, con);
                    myCommandd.ExecuteNonQuery();
                }
                else
                {
                    //Student
                    SqlCommand myCommand = new SqlCommand("update USERR set USERNAME = '" + txt_Name.Text + "', EMAIL = '" + txt_Email.Text + "', PASSWORD ='" + txt_Pass.Text +
                                                            "' ,CARDID = '" + txt_CardID.Text + "', USERTYPEID = 2 where USERID =" + _userID, con);
                    myCommand.ExecuteNonQuery();
                    // Checkbox is not checked
                    // Perform some other action
                }
            }
           

            
            

            this.Hide();
            LoginForm loginForm= new LoginForm();
            loginForm.ShowDialog();
            this.Show();
            con.Close();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void check_Admin_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        

        private void SignUpForm_Load_1(object sender, EventArgs e)
        {
            if (_userType == "Admin")
            {
                check_Admin.Visible = true;
            }
            else
            {
                check_Admin.Visible = false;
            }
            if (_mode == "edit")
            {
                SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from USERR where USERID = '" + _userID + "'", con);
                SqlDataReader sqlReader = cmd.ExecuteReader();
               if( sqlReader.Read())
                {
                    txt_Name.Text = sqlReader["USERNAME"].ToString();
                    txt_Pass.Text = sqlReader["PASSWORD"].ToString();
                    txt_Email.Text = sqlReader["EMAIL"].ToString();
                    txt_CardID.Text = sqlReader["CARDID"].ToString();


                }
                con.Close();
            }
        }

        private void txt_CardID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
