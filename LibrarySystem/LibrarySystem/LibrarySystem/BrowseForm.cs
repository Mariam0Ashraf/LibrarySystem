using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BrowseForm : Form
    {
        private string _URL;
        public BrowseForm(string URL)
        {
            InitializeComponent();
              _URL = URL;

    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Uri url = new Uri(_URL);
            webBrowser1.Url = url;
            webBrowser1.Navigate(url);
            
        }
    }
}
