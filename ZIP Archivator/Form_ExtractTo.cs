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
    public partial class Form_ExtractTo : Form
    {
        public Form_ExtractTo()
        {
            InitializeComponent();
        }

        private void Form_ExtractTo_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonChangeFolder_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openDoialog = new OpenFileDialog();
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            //folderBrowserDlg.ShowDialog();
            DialogResult DlgResult = folderBrowserDlg.ShowDialog();
            if (DlgResult==DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDlg.SelectedPath);
                
            }
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            ArchivingActions.ArchExtract(ArchParameters.ArchiveFileToExtract, ArchParameters.ArchivePathToExtract);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
