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
    public partial class BookForm : Form
    {
       // private string _userType;
        public string _mode;
        public BookForm(string mode)
        {
            InitializeComponent();
            _mode= mode;
                    }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_LibraryDataSet2.author' table. You can move, or remove it, as needed.
            this.authorTableAdapter1.Fill(this.uni_LibraryDataSet2.author);
            // TODO: This line of code loads data into the 'uni_LibraryDataSet1.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter1.Fill(this.uni_LibraryDataSet1.PUBLISHER);
            // TODO: This line of code loads data into the 'uni_LibraryDataSet.PUBLISHER' table. You can move, or remove it, as needed.
            //this.pUBLISHERTableAdapter.Fill(this.uni_LibraryDataSet.PUBLISHER);
            // TODO: This line of code loads data into the 'uni_LibraryDataSet.author' table. You can move, or remove it, as needed.
          //  this.authorTableAdapter.Fill(this.uni_LibraryDataSet.author);

        }

        private void but_AddBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MES;Initial Catalog=Uni_Library;Integrated Security=True");


            con.Open();

            SqlCommand myCommand = new SqlCommand("insert into Book ( GENRE,PUBLISHINGYEAR,TITLE,BOOKURL, PUBLISHERID) values(' "  + GenreTextbox.Text + "','" + int.Parse(PublishingYearTextbox.Text) + "','" + TitleTextbox.Text  + "','" + URLTextbox.Text + "','" + (int)comboBox2.SelectedValue + "')", con);
            //SqlCommand myCommandPublisher = new SqlCommand("insert into Publisher ([PUBLISHER ID], [PUBLISHER NAME],) values(' " + PublisherIDTextbox.Text + "','" + PublisherNameTextbox.Text + "')", con);
          // myCommandPublisher.ExecuteNonQuery();
          // myCommandd.ExecuteNonQuery();

            myCommand.ExecuteNonQuery();
            
            SqlCommand cmd = new SqlCommand("select Top 1 ISBN from BOOK order by ISBN desc ", con);
            SqlDataReader sqlReader = cmd.ExecuteReader();
            sqlReader.Read();
            
            var newISBN = (int)sqlReader[0];
            sqlReader.Close();
            SqlCommand myCommandd = new SqlCommand("insert into BOOK_AUTHOR (ISBN ,[Ao ID]) values(' " + newISBN + "','" + int.Parse(comboBox1.SelectedValue.ToString()) +  "')", con);
            myCommandd.ExecuteNonQuery();
            MessageBox.Show("Book Added ");
            

            con.Close();
            this.Hide();
           // MainForm mainForm = new MainForm("Admin",);
            //mainForm.ShowDialog();
           // this.Show();
           // mainForm.MainForm_Load(null,null);

        }

        private void AuthorNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PublisherNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
