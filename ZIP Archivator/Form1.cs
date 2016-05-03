using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net.Configuration;

namespace ZIP_Archivator
{
    public partial class FormZipArchivator : Form
    {
        public FormZipArchivator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void FormZipArchivator_Load(object sender, EventArgs e)
        {
            comboBoxAddress.Text = Directory.GetCurrentDirectory();

            ValidateAndOpenDirectory();
        }

        private void ValidateAndOpenDirectory()
        {
            if (Directory.Exists(comboBoxAddress.Text))
            {
                webBrowser.Url = new Uri(comboBoxAddress.Text);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            ValidateAndOpenDirectory();
        }

        private void comboBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateAndOpenDirectory();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        //private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        //{
        //    comboBoxAddress.Text = webBrowser.Url.ToString();
        //}
    }
}
