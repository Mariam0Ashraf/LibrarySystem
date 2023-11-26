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

namespace LibrarySystem
{
    public partial class EditYourProfile : Form
    {
        //SignUpForm SignUp;
        public EditYourProfile()
        {
            InitializeComponent();
            //this.SignUp = signUp;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_RemoveAcc_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(" Data Sourcen.;Initial Catalog-hobbies;Integrated Security-True");
            conn.Open();
            SqlCommand cmmd = new SqlCommand("delete from USERR where USERNAME = " + txt_UserName, conn);
            cmmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your account is deleted");

        }

        private void EditYourProfile_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(" Data Sourcen.;Initial Catalog-hobbies;Integrated Security-True");
            conn.Open();
           // txt_UserName.Text = SignUp.txt_Name.Text;
            //string sqll = "select * from USERR where USERNAME ='"+ ;


        }
    }
}
