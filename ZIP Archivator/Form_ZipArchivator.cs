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
        List<string> listFiles = new List<string>(); 

        // Constructor
        public FormZipArchivator()
        {
            InitializeComponent();
        }

        // Form Zip Archivator is loaded
        private void FormZipArchivator_Load(object sender, EventArgs e)
        {
            listFiles.Clear();
            listViewFiles.Items.Clear();
            comboBoxAddress.MaxDropDownItems = 10;
            //comboBoxAddress.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            comboBoxAddress.Text = @"e:\temp\";
            ValidateAndOpenDirectory();
            foreach (string item in Directory.GetFileSystemEntries(comboBoxAddress.Text))
            {
                //imageListFiles.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                FileInfo fileInfo = new FileInfo(item);
                ListViewItem lvi = new ListViewItem(Path.GetFileName(item));
               // lvi.SubItems.Add(fileInfo.Length(item));
                

                listFiles.Add(item);
                listViewFiles.Items.Add(Path.GetFileName(item));
                

                
                
                //listFiles.Add(fileInfo.FullName);
                //listViewFiles.Items.Add(fileInfo.Name, imageListFiles.Images.Count - 1);
            }

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

        // button ArchiveTo is clicked
        private void buttonArchiveTo_Click(object sender, EventArgs e)
        {
            // returns selected items
           // ListView.SelectedListViewItemCollection selectedFiles = this.listViewFiles.SelectedItems;
           
            formArchiveTo = new Form_ArchiveTo();

            formArchiveTo.comboBoxFolder.Text = comboBoxAddress.Text +"\\"+ new DirectoryInfo(comboBoxAddress.Text).Name+".zip";
           


            //LeonidC: Block Code Start --->
            //Get Selected Items from ViewList

                    // string[] selectedFiles = new string[this.listViewFiles.SelectedItems.Count];
            List<string> selectedFilesList=new List<string>();
            
            int index = -1;
            foreach (ListViewItem item in this.listViewFiles.SelectedItems)
            {
                index++;
                    //selectedFiles[index] = item.Text;

                selectedFilesList.Add(comboBoxAddress.Text+"\\"+item.Text);
                    //MessageBox.Show(selectedFiles[index]);
            }
            ArchParameters.ItemsToArchive = selectedFilesList;

            // LeonidC: <---Block Code End
            if (index == -1) 
                    MessageBox.Show("No any files are selected!!! \n Please select files to arcive!!!");
            else 
                //Show dialog if any item selected:
                    formArchiveTo.ShowDialog();

        }

        // clear error if Address is updated.
        private void comboBoxAddress_TextUpdate(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void listViewFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void listViewFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void listViewFiles_ItemActivate(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //string selectedFiles = "";

            //foreach (ListViewItem item in this.listViewFiles.SelectedItems)
            //{
              
            //    selectedFiles = selectedFiles + "\n" + item.Text;
            //}
            
            //MessageBox.Show(selectedFiles);


//************************************************

            

           

            
        }

        private void buttonExtractTo_Click(object sender, EventArgs e)
        {

            if (listViewFiles.SelectedItems.Count > 0 )
            {
                
                MessageBox.Show(listViewFiles.FocusedItem.Text);

                formExtractTo = new Form_ExtractTo();
                formExtractTo.comboBox1.Text = this.comboBoxAddress.Text;

                ArchParameters.ArchivePathToExtract = this.comboBoxAddress.Text;
                ArchParameters.ArchiveFileToExtract =this.comboBoxAddress.Text+"\\"+listViewFiles.FocusedItem.Text;
                
                formExtractTo.ShowDialog();
                

            }
            else
                MessageBox.Show("Please select archive to extract");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

      
    }
}
