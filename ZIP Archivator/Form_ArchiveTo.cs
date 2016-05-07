using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP_Archivator
{
    public partial class Form_ArchiveTo : Form
    {
        FormZipArchivator formZipArchivator = new FormZipArchivator();
        public Form_ArchiveTo()
        {
            InitializeComponent();
        }

        private void Form_ArchiveName_Load(object sender, EventArgs e)
        {
            ValidateAndAddItemToComboBoxFolder();
        }

        private void buttonChangeFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "")
            {
                comboBoxFolder.Text = folderBrowserDialog.SelectedPath;
            ValidateAndAddItemToComboBoxFolder();
            }
        }

        private void ValidateAndAddItemToComboBoxFolder()
        {
            if (!comboBoxFolder.Items.Contains(comboBoxFolder.Text))
            {
                comboBoxFolder.Items.Add(comboBoxFolder.Text);
            }
        }
    }
}
