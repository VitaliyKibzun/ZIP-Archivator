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
        private Form_ArchiveTo formArchiveTo;

        public ComboBox ComboBoxAddress
        {
            get { return comboBoxAddress; }
        }

        public FormZipArchivator()
        {
            InitializeComponent();
        }

        private void FormZipArchivator_Load(object sender, EventArgs e)
        {
            comboBoxAddress.MaxDropDownItems = 10;
            //comboBoxAddress.Text = Directory.GetCurrentDirectory();
            comboBoxAddress.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Environment.SpecialFolder smth = Environment.SpecialFolder.MyComputer;
            //comboBoxAddress.Text = (string)Environment.SpecialFolder.MyComputer;
            ValidateAndOpenDirectory();
        }

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

       
        private void buttonGo_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            ValidateAndOpenDirectory();
        }

        private void comboBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            errorProviderAddress.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                ValidateAndOpenDirectory();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }

        private void comboBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderAddress.Clear();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            comboBoxAddress.Text = Path.GetFullPath(Path.Combine(webBrowser.Url.LocalPath, @"..\"));
            ValidateAndOpenDirectory();
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            comboBoxAddress.Text = webBrowser.Url.LocalPath;
            ValidateAndAddItemToComboBoxAddress();
        }

        private void comboBoxAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxAddress.Text = (string) comboBoxAddress.SelectedItem;
            ValidateAndOpenDirectory();
        }

        private void ValidateAndAddItemToComboBoxAddress()
        {
            if (!comboBoxAddress.Items.Contains(webBrowser.Url.LocalPath))
            {
                comboBoxAddress.Items.Add(webBrowser.Url.LocalPath);
            }
        }

        private void buttonArchiveTo_Click(object sender, EventArgs e)
        {
            formArchiveTo = new Form_ArchiveTo();
            formArchiveTo.comboBoxFolder.Text = comboBoxAddress.Text;
            formArchiveTo.ShowDialog();
        }
    }
}
