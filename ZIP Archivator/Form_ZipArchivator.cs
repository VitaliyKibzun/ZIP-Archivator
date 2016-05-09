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
        // Declare variables
        private Form_ArchiveTo formArchiveTo;
        private Form_ExtractTo formExtractTo;

        // Constructor
        public FormZipArchivator()
        {
            InitializeComponent();
        }

        // Form Zip Archivator is loaded
        private void FormZipArchivator_Load(object sender, EventArgs e)
        {
            comboBoxAddress.MaxDropDownItems = 10;
            comboBoxAddress.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //comboBoxAddress.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ValidateAndOpenDirectory();
        }

        // Validates and opens specified directory
        private void ValidateAndOpenDirectory()
        {
            if (Directory.Exists(comboBoxAddress.Text))
            {
                errorProviderAddress.Clear();
                webBrowser.Url = new Uri(comboBoxAddress.Text);
            }
            else
            {
                errorProviderAddress.SetIconAlignment(labelAddress, ErrorIconAlignment.MiddleLeft);
                errorProviderAddress.SetError(labelAddress,"Specified directory doesn't exist.");
            }
        }

        // "Go" button is clicked
        private void buttonGo_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            ValidateAndOpenDirectory();
        }

        // Opens directory if press Enter
        private void comboBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            errorProviderAddress.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                ValidateAndOpenDirectory();
            }
        }

        // Returns to previous address if Back button clicked
        private void buttonBack_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        // Goes forward address after back is used
        private void buttonForward_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        // Goes to folder UP
        private void buttonUp_Click(object sender, EventArgs e)
        {
            comboBoxAddress.Text = Path.GetFullPath(Path.Combine(webBrowser.Url.LocalPath, @"..\"));
            ValidateAndOpenDirectory();
        }

        // writes address if web browser changed navigation
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            comboBoxAddress.Text = webBrowser.Url.LocalPath;
            ValidateAndAddItemToComboBoxAddress();
        }

        // opens paths from Drop-Down list of Adress
        private void comboBoxAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxAddress.Text = (string) comboBoxAddress.SelectedItem;
            ValidateAndOpenDirectory();
        }

        // Validates and adds Item to Address (like history of visited addresses)
        private void ValidateAndAddItemToComboBoxAddress()
        {
            if (!comboBoxAddress.Items.Contains(webBrowser.Url.LocalPath))
            {
                comboBoxAddress.Items.Add(webBrowser.Url.LocalPath);
            }
        }

        // button Archive is clicked
        private void buttonArchiveTo_Click(object sender, EventArgs e)
        {
            formArchiveTo = new Form_ArchiveTo();
            formArchiveTo.comboBoxFolder.Text = comboBoxAddress.Text;
            formArchiveTo.ShowDialog();
        }

        // clear error if Address is updated.
        private void comboBoxAddress_TextUpdate(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
        }
    }
}
