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
    public partial class MainForm : Form
    {
        private string _userType;
        private int _userID;
        public MainForm(string userType, int userID)
        {
            InitializeComponent();
            _userType = userType;
            _userID= userID;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void but_AddBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm("new");
            bookForm.ShowDialog();
            MainForm_Load(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void but_Browse_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");
            // con.Open();
            //// SqlCommand commando = new SqlCommand("select * from BOOK where ISBN ='"+BrowsingTextbox+"'",con);
            //// commando.ExecuteNonQuery();

            // string sql = "select * from BOOK where ISBN ='" + BrowsingTextbox + "'";
            // SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            // DataSet ds = new DataSet();
            // dataadapter.Fill(ds);
            // dataGridView1.DataSource = ds.Tables[0];
            // con.Close();
            BrowseForm browseForm = new BrowseForm("https://classroom.google.com/c/NTQyNjg2MTMwNzQx/a/NjEwNjAwNjAwMTU1/details");
            browseForm.ShowDialog();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BrowsingTextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void but_EditBook_Click(object sender, EventArgs e)
        {

        }
        
            private void MainForm_Load(object sender, EventArgs e)
            {
                if (_userType == "Admin")
                {
                    but_AddBook.Visible = true;
                    but_EditBook.Visible = true;
                    but_DelBook.Visible = true;
                    btn_AddAdmin.Visible = true;
                }
                else
                {
                    but_AddBook.Visible = false;
                    but_EditBook.Visible = false;
                    but_DelBook.Visible = false;
                    btn_AddAdmin.Visible = false;
                }

                SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");

                con.Open();

            //SqlCommand command = new SqlCommand("select * from T_Book", con);

            // string sql = "select *from BOOK";
            string sql = "SELECT  BOOK.ISBN AS 'BookID', PUBLISHINGYEAR, GENRE, TITLE, BOOKURL, aoname, PUBLISHERNAME FROM dbo.author INNER JOIN "+
                        " dbo.BOOK_AUTHOR ON dbo.author.[Ao ID] = dbo.BOOK_AUTHOR.[AO ID] INNER JOIN "+
                        " dbo.BOOK ON dbo.BOOK_AUTHOR.ISBN = dbo.BOOK.ISBN INNER JOIN "+
                        " dbo.PUBLISHER ON dbo.BOOK.PUBLISHERID = dbo.PUBLISHER.PUBLISHERID";
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                 con.Close();
            }

            //SqlConnection conn =new SqlConnection(" Data Sourcen.;Initial Catalog-hobbies;Integrated Security-True");

        

        private void btn_AddAdmin_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(_userType,"new", 0);
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void BrowsingTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BrowsingTextbox.Text = dataGridView1.CurrentRow.Cells["BOOKNAME"].Value.ToString();
        }

        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            SignUpForm editYourProfile = new SignUpForm(_userType, "edit", _userID);
            this.Hide();
            editYourProfile.ShowDialog();
            this.Show();
        }

        private void but_DelBook_Click(object sender, EventArgs e)
        {
            int _isbn = int.Parse(dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString());
        }
    }
}
