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
using System.Windows.Forms.VisualStyles;


namespace ZIP_Archivator
{
    public partial class FormZipArchivator : Form
    {
        // Declare variables
        private Form_ArchiveTo formArchiveTo;
        private Form_ExtractTo formExtractTo;
        private List<string> fileExtension; 
        //private ListView.SelectedListViewItemCollection selectedFiles;

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
            ArchParameters.AbsolutePath = comboBoxAddress.Text;
            ValidateAndOpenDirectory();
            buttonArchiveTo.Enabled = false;
            buttonExtractTo.Enabled = false;
            buttonDelete.Enabled = false;
            buttonTest.Enabled = false;
        }

        // Shows all Directories with assigned icon
        private bool ShowDirectoriesInFolder(string dir)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);

                foreach (DirectoryInfo dirItem in dirInfo.GetDirectories())
                {
                    ListViewItem listViewItemFolder = new ListViewItem(dirItem.Name);
                    listViewItemFolder.ImageIndex = 0;
                    listViewFiles.Items.Add(listViewItemFolder);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Access is denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxAddress.Text = Path.GetFullPath(Path.Combine(comboBoxAddress.Text, @"..\"));
                ValidateAndOpenDirectory();
                return false;
            }
        }

        // Shows all Files in folder with associated icon. Returns True if success. Returns False if Exception is catched.
        private bool ShowFilesInFolder(string dir)
        {
            try
            {
                DirectoryInfo fileInfo = new DirectoryInfo(dir);

                foreach (FileInfo fileItem in fileInfo.GetFiles())
                {
                    imageListFiles.Images.Add(Icon.ExtractAssociatedIcon(fileItem.FullName));
                    listViewFiles.Items.Add(fileItem.Name, imageListFiles.Images.Count - 1);
                    //fileExtension.Add(fileItem.FullName, fileItem.Extension);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Access is denied.");
                return false;
            }
        }

        // Validates and opens specified directory
        private void ValidateAndOpenDirectory()
        {
            if (Directory.Exists(comboBoxAddress.Text))
            {
                errorProviderAddress.Clear();
                listViewFiles.Items.Clear();
                ArchParameters.AbsolutePath = comboBoxAddress.Text;

                if (ShowDirectoriesInFolder(comboBoxAddress.Text))
                {
                    ShowFilesInFolder(comboBoxAddress.Text);
                }

                buttonArchiveTo.Enabled = false;
                
                
                buttonExtractTo.Enabled = false;
                buttonDelete.Enabled = false;
                buttonTest.Enabled = false;


                ValidateAndAddItemToComboBoxAddress();
            }
            else
            {
                errorProviderAddress.SetIconAlignment(labelAddress, ErrorIconAlignment.MiddleLeft);
                errorProviderAddress.SetError(labelAddress, "Specified directory doesn't exist.");
            }
        }

        // "Go" button opens specified directory
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

        // Goes to folder UP
        private void buttonUp_Click(object sender, EventArgs e)
        {
            comboBoxAddress.Text = Path.GetFullPath(Path.Combine(comboBoxAddress.Text, @"..\"));
            ValidateAndOpenDirectory();
        }

        // opens paths from Drop-Down list of Adress
        private void comboBoxAddress_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxAddress.Text = (string) comboBoxAddress.SelectedItem;
            ArchParameters.AbsolutePath = comboBoxAddress.Text;
            ValidateAndOpenDirectory();
        }

        // Validates and adds Item to Address (like history of visited addresses)
        private void ValidateAndAddItemToComboBoxAddress()
        {
            if (!comboBoxAddress.Items.Contains(comboBoxAddress.Text))
            {
                comboBoxAddress.Items.Add(comboBoxAddress.Text);
            }
        }

        // button ArchiveTo is clicked
        private void buttonArchiveTo_Click(object sender, EventArgs e)
        {
            // returns selected items
           // ListView.SelectedListViewItemCollection selectedFiles = this.listViewFiles.SelectedItems;
           
            formArchiveTo = new Form_ArchiveTo();
            formArchiveTo.comboBoxFolder.Text = comboBoxAddress.Text +@"\"+ new DirectoryInfo(comboBoxAddress.Text).Name+".zip";
           
            formArchiveTo.ShowDialog();

        }


        
        // clear error if Address is updated.
        private void comboBoxAddress_TextUpdate(object sender, EventArgs e)
        {
            errorProviderAddress.Clear();
        }

        // 
        private void buttonInfo_Click(object sender, EventArgs e)
        {
           
        }

        // double click on folder to open the directory
        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (IsFolder())
            {
                string focusedItemName = listViewFiles.FocusedItem.Text;
                string fullPathToFocusedItem = Path.Combine(comboBoxAddress.Text, focusedItemName);
                comboBoxAddress.Text = fullPathToFocusedItem;
                ValidateAndOpenDirectory();

            }
        }

        // Verify if selected item is Folder (return True if Folder, False if not a folder)
        private bool IsFolder()
        {
            if (listViewFiles.SelectedItems.Count == 1)
            {
                string focusedItemName = listViewFiles.FocusedItem.Text;
                string fullPathToFocusedItem = Path.Combine(comboBoxAddress.Text, focusedItemName);
                if (!File.Exists(fullPathToFocusedItem))
                {
                    if (Directory.Exists(fullPathToFocusedItem))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Opens Folder selection dialog
        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialogOpenFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialogOpenFolder.ShowDialog();
            if (folderBrowserDialogOpenFolder.SelectedPath != "")
            {
                comboBoxAddress.Text = folderBrowserDialogOpenFolder.SelectedPath;
                ValidateAndOpenDirectory();
            }
        }

        // opens About dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count >= 1)
            {
                buttonArchiveTo.Enabled = true;
                buttonDelete.Enabled = true;
                //LC: Getting list of selected files
                List<string> selectedFilesList = new List<string>();

                int index = -1;
                foreach (ListViewItem item in this.listViewFiles.SelectedItems)
                {
                    index++;
                    selectedFilesList.Add(comboBoxAddress.Text + "\\" + item.Text);
                }

                ArchParameters.ItemsToArchive = selectedFilesList;

                // End

                if (listViewFiles.FocusedItem.Text.Contains(".zip"))
                {
                    buttonExtractTo.Enabled = true;
                    buttonTest.Enabled = true;
                    
                    ArchParameters.ArchiveFileToExtract = this.comboBoxAddress.Text + "\\" + listViewFiles.FocusedItem.Text;
                    
                }
                
            }
            if (listViewFiles.SelectedItems.Count < 1)
            {
                buttonArchiveTo.Enabled = false;
                buttonExtractTo.Enabled = false;
                buttonTest.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }


private void buttonExtractTo_Click(object sender, EventArgs e)
{

    if (listViewFiles.SelectedItems.Count > 0)
    {

        
        formExtractTo = new Form_ExtractTo();
        formExtractTo.comboBox1.Text = this.comboBoxAddress.Text;

        ArchParameters.ArchivePathToExtract = this.comboBoxAddress.Text;
       
        formExtractTo.ShowDialog();


    }
    else
        MessageBox.Show("Please select archive to extract");


}



private void buttonTest_Click(object sender, EventArgs e)
{
    ArchivingActions.ArchiveIsOk(ArchParameters.ArchiveFileToExtract);
}

private void buttonDelete_Click(object sender, EventArgs e)
{
    //ValidateAndOpenDirectory();
        
    DialogResult resultForDelete =MessageBox.Show("Selected items will be deleted!","Deleting files",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
    if (resultForDelete == DialogResult.Yes)
    {
        string absolutePathFile = "";

        //Verify each selected item if it's a folder or file and do appropriate Delete
        foreach (ListViewItem item in this.listViewFiles.SelectedItems)
        {
            absolutePathFile = ArchParameters.AbsolutePath + "\\" + item.Text;
            try
            {


                if (Directory.Exists(absolutePathFile))
                {


                    System.IO.DirectoryInfo di = new DirectoryInfo(absolutePathFile);

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }

                    Directory.Delete(absolutePathFile);
            }

                else
                    if (File.Exists(absolutePathFile))

                        File.Delete(absolutePathFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need to catch this Exception!!!!");
                MessageBox.Show(ex.ToString());

            }
        }
    }

}

private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
{
    List<string> selectedFilesList = new List<string>();

    int index = -1;
    foreach (ListViewItem item in this.listViewFiles.SelectedItems)
    {
        index++;
        selectedFilesList.Add(comboBoxAddress.Text + "\\" + item.Text);
       
    }

    ArchParameters.ItemsToArchive = selectedFilesList;
}

private void buttonView_Click(object sender, EventArgs e)
{



}


    
    }
}
