using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP_Archivator
{
    public partial class Form_ArchiveTo : Form
    {
        int maxCharactersAllowed = 250;

        // check if required
        FormZipArchivator formZipArchivator = new FormZipArchivator();
        
        // Constructor
        public Form_ArchiveTo()
        {
            InitializeComponent();
        }

        // Form ArchiveName is loaded
        private void Form_ArchiveName_Load(object sender, EventArgs e)
        {
            ValidateAndAddItemToComboBoxFolder();
            ArchiveButtonAvailability();
            errorProviderArchiveButton.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            errorProviderChangeFolderButton.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

           
            //string dirName = new DirectoryInfo(@"E:\Temp\Text456\Text789").Name;
            //MessageBox.Show(dirName);

        }

        // Actions if click "Change Folder" button
        private void buttonChangeFolder_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            //folderBrowserDialog.ShowDialog();
            //if (folderBrowserDialog.SelectedPath != "")
            //{
            //    comboBoxFolder.Text = folderBrowserDialog.SelectedPath;
            //ValidateAndAddItemToComboBoxFolder();
            //}
            //ArchiveButtonAvailability();

            //Leonidc --->********************************************************************

             //Show the FolderBrowserDialog.

            //saveFileDialog1.ShowDialog();

            DialogResult result = saveFileDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {

                            comboBoxFolder.Text = saveFileDialog1.FileName;
                            //ArchParameters.ArchivePathAndName= saveFileDialog1.FileName;

                            //if (!fileOpened)
                            //{
                            //    // No file is opened, bring up openFileDialog in selected path.
                            //    //openFileDialog1.InitialDirectory = folderName;
                            //    //openFileDialog1.FileName = null;
                            //    //openMenuItem.PerformClick();
                            //}
                        }


            //LeonidC <---**************************************************************



        }

        // Validates and adds Path to Folders list.
        private void ValidateAndAddItemToComboBoxFolder()
        {
            if (!comboBoxFolder.Items.Contains(comboBoxFolder.Text))
            {
                comboBoxFolder.Items.Add(comboBoxFolder.Text);
            }
        }

        // Validates specified data on Validate button click
        private bool SpecifiedFieldsOK()
        {
            if (comboBoxFolder.Text != "")
            {
                //if (!File.Exists(comboBoxFolder.Text))
                //{
                //    errorProviderChangeFolderButton.Clear();
                    if (comboBoxFileName.Text != "")
                    {
                        errorProviderArchiveButton.Clear();
                        if (!CharactersAmountOK())
                        {
                            errorProviderArchiveButton.SetIconAlignment(buttonArchive, ErrorIconAlignment.MiddleRight);
                            string errorMessage = String.Format("Folder Path with filename exceed {0} characters.",
                                maxCharactersAllowed);
                            errorProviderArchiveButton.SetError(buttonArchive, errorMessage);
                        }
                        else
                        {
                            buttonArchive.Enabled = true;
                            errorProviderArchiveButton.Clear();
                            return true;
                        }
                    }
                    else
                    {
                        buttonArchive.Enabled = false;
                        errorProviderArchiveButton.SetIconAlignment(buttonArchive, ErrorIconAlignment.MiddleRight);
                        string errorMessage = ("File name couldn't be empty.");
                        errorProviderArchiveButton.SetError(buttonArchive, errorMessage);
                    }
                }
                else
                {
                    errorProviderChangeFolderButton.SetError(buttonChangeFolder, "Specified file already exist. Do you whan to overwrite?");

                }
            //}
            //else
            //{
            //    buttonArchive.Enabled = false;
            //    errorProviderChangeFolderButton.SetIconAlignment(buttonChangeFolder, ErrorIconAlignment.MiddleRight);
            //    string errorMessage = ("Path couldn't be empty.");
            //    errorProviderChangeFolderButton.SetError(buttonChangeFolder, errorMessage);
            //}
            return false;
        }

        private bool CharactersAmountOK()
        {
            
            string fullString = Path.Combine(comboBoxFolder.Text, "\\", comboBoxFileName.Text, ".zip");
            if (fullString.Length <= maxCharactersAllowed)
            {
                return true;
            }
            return false;
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            if (SpecifiedFieldsOK())
            {
                // Call Zip Archivator
                ArchParameters.ArchivePathAndName = comboBoxFolder.Text;
                ArchivingActions.ArchCreate(ArchParameters.ItemsToArchive, ArchParameters.ArchivePathAndName);

                foreach (string item in ArchParameters.ItemsToArchive)
                {
                    MessageBox.Show(item);

                }



            }
        }

        private void comboBoxFolder_TextUpdate(object sender, EventArgs e)
        {
            ArchiveButtonAvailability();
        }

        private void comboBoxFileName_TextUpdate(object sender, EventArgs e)
        {
            ArchiveButtonAvailability();
        }

        private void ArchiveButtonAvailability()
        {
            errorProviderChangeFolderButton.Clear();
            errorProviderArchiveButton.Clear();
            if (comboBoxFolder.Text != "")
            {
                if(comboBoxFileName.Text != "")
                {
                    buttonArchive.Enabled = true;
                }
                else
                {
                    buttonArchive.Enabled = false;
                }
            }
            else
            {
                buttonArchive.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBoxFolder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelZipPath_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form_ArchiveTo.ActiveForm.Close();
            this.Close();
          
        }



    }
}
