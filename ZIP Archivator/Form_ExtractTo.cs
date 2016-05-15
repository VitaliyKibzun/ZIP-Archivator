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


        private void buttonChangeFolder_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            
            DialogResult DlgResult = folderBrowserDlg.ShowDialog();
            if (DlgResult==DialogResult.OK)
            {
                
                comboBox1.Text = folderBrowserDlg.SelectedPath;
            }
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {

            ArchParameters.OverwriteSilently= this.ExtractWithOverwrite.Checked;

            //Perform extracting depending with ArchParameters.OverwriteSilently
            ArchivingActions.ArchExtract(ArchParameters.ArchiveFileToExtract,comboBox1.Text) ;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_ExtractTo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_ExtractTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
