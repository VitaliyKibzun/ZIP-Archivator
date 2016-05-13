namespace ZIP_Archivator
{
    partial class Form_ArchiveTo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelZipPath = new System.Windows.Forms.Label();
            this.buttonChangeFolder = new System.Windows.Forms.Button();
            this.labelZipFileName = new System.Windows.Forms.Label();
            this.comboBoxFolder = new System.Windows.Forms.ComboBox();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.comboBoxFileName = new System.Windows.Forms.ComboBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProviderArchiveButton = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderChangeFolderButton = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.includeFullPath = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArchiveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangeFolderButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // labelZipPath
            // 
            this.labelZipPath.AutoSize = true;
            this.labelZipPath.Location = new System.Drawing.Point(17, 16);
            this.labelZipPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZipPath.Name = "labelZipPath";
            this.labelZipPath.Size = new System.Drawing.Size(75, 17);
            this.labelZipPath.TabIndex = 1;
            this.labelZipPath.Text = "File Name:";
            this.labelZipPath.Click += new System.EventHandler(this.labelZipPath_Click);
            // 
            // buttonChangeFolder
            // 
            this.buttonChangeFolder.Location = new System.Drawing.Point(505, 36);
            this.buttonChangeFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChangeFolder.Name = "buttonChangeFolder";
            this.buttonChangeFolder.Size = new System.Drawing.Size(120, 28);
            this.buttonChangeFolder.TabIndex = 2;
            this.buttonChangeFolder.Text = "Change Folder";
            this.buttonChangeFolder.UseVisualStyleBackColor = true;
            this.buttonChangeFolder.Click += new System.EventHandler(this.buttonChangeFolder_Click);
            // 
            // labelZipFileName
            // 
            this.labelZipFileName.AutoSize = true;
            this.labelZipFileName.Location = new System.Drawing.Point(482, 291);
            this.labelZipFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZipFileName.Name = "labelZipFileName";
            this.labelZipFileName.Size = new System.Drawing.Size(75, 17);
            this.labelZipFileName.TabIndex = 3;
            this.labelZipFileName.Text = "File Name:";
            this.labelZipFileName.Visible = false;
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.FormattingEnabled = true;
            this.comboBoxFolder.Location = new System.Drawing.Point(21, 37);
            this.comboBoxFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(475, 24);
            this.comboBoxFolder.TabIndex = 4;
            this.comboBoxFolder.SelectedIndexChanged += new System.EventHandler(this.comboBoxFolder_SelectedIndexChanged);
            this.comboBoxFolder.TextUpdate += new System.EventHandler(this.comboBoxFolder_TextUpdate);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(459, 266);
            this.buttonArchive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(120, 28);
            this.buttonArchive.TabIndex = 6;
            this.buttonArchive.TabStop = false;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Location = new System.Drawing.Point(0, 291);
            this.comboBoxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(436, 24);
            this.comboBoxFileName.TabIndex = 7;
            this.comboBoxFileName.Text = "test.zip";
            this.comboBoxFileName.Visible = false;
            this.comboBoxFileName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileName_SelectedIndexChanged);
            this.comboBoxFileName.TextUpdate += new System.EventHandler(this.comboBoxFileName_TextUpdate);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(444, 298);
            this.labelExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(30, 17);
            this.labelExtension.TabIndex = 9;
            this.labelExtension.Text = ".zip";
            this.labelExtension.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // errorProviderArchiveButton
            // 
            this.errorProviderArchiveButton.ContainerControl = this;
            // 
            // errorProviderChangeFolderButton
            // 
            this.errorProviderChangeFolderButton.ContainerControl = this;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Image = global::ZIP_Archivator.Properties.Resources.folder_zip_icon;
            this.pictureBoxStatus.Location = new System.Drawing.Point(643, 31);
            this.pictureBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(96, 89);
            this.pictureBoxStatus.TabIndex = 10;
            this.pictureBoxStatus.TabStop = false;
            // 
            // includeFullPath
            // 
            this.includeFullPath.AutoSize = true;
            this.includeFullPath.Location = new System.Drawing.Point(21, 139);
            this.includeFullPath.Name = "includeFullPath";
            this.includeFullPath.Size = new System.Drawing.Size(129, 21);
            this.includeFullPath.TabIndex = 11;
            this.includeFullPath.Text = "Include full path";
            this.includeFullPath.UseVisualStyleBackColor = true;
            this.includeFullPath.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "zip";
            this.saveFileDialog1.Filter = "Zip files|*.zip";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ArchiveTo
            // 
            this.AcceptButton = this.buttonArchive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.includeFullPath);
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.comboBoxFileName);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.comboBoxFolder);
            this.Controls.Add(this.labelZipFileName);
            this.Controls.Add(this.buttonChangeFolder);
            this.Controls.Add(this.labelZipPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ArchiveTo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Archive To...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_ArchiveName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArchiveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangeFolderButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelZipPath;
        private System.Windows.Forms.Button buttonChangeFolder;
        private System.Windows.Forms.Label labelZipFileName;
        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.ComboBox comboBoxFileName;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        public System.Windows.Forms.ComboBox comboBoxFolder;
        private System.Windows.Forms.ErrorProvider errorProviderArchiveButton;
        private System.Windows.Forms.ErrorProvider errorProviderChangeFolderButton;
        private System.Windows.Forms.CheckBox includeFullPath;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}