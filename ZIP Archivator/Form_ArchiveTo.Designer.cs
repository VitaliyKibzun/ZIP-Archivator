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
            this.labelZipPath.Location = new System.Drawing.Point(13, 13);
            this.labelZipPath.Name = "labelZipPath";
            this.labelZipPath.Size = new System.Drawing.Size(39, 13);
            this.labelZipPath.TabIndex = 1;
            this.labelZipPath.Text = "Folder:";
            // 
            // buttonChangeFolder
            // 
            this.buttonChangeFolder.Location = new System.Drawing.Point(379, 29);
            this.buttonChangeFolder.Name = "buttonChangeFolder";
            this.buttonChangeFolder.Size = new System.Drawing.Size(90, 23);
            this.buttonChangeFolder.TabIndex = 2;
            this.buttonChangeFolder.Text = "Change Folder";
            this.buttonChangeFolder.UseVisualStyleBackColor = true;
            this.buttonChangeFolder.Click += new System.EventHandler(this.buttonChangeFolder_Click);
            // 
            // labelZipFileName
            // 
            this.labelZipFileName.AutoSize = true;
            this.labelZipFileName.Location = new System.Drawing.Point(13, 57);
            this.labelZipFileName.Name = "labelZipFileName";
            this.labelZipFileName.Size = new System.Drawing.Size(57, 13);
            this.labelZipFileName.TabIndex = 3;
            this.labelZipFileName.Text = "File Name:";
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.FormattingEnabled = true;
            this.comboBoxFolder.Location = new System.Drawing.Point(16, 30);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(357, 21);
            this.comboBoxFolder.TabIndex = 4;
            this.comboBoxFolder.TextUpdate += new System.EventHandler(this.comboBoxFolder_TextUpdate);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(379, 72);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(90, 23);
            this.buttonArchive.TabIndex = 6;
            this.buttonArchive.TabStop = false;
            this.buttonArchive.Text = "Archive";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Location = new System.Drawing.Point(16, 73);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(328, 21);
            this.comboBoxFileName.TabIndex = 7;
            this.comboBoxFileName.TextUpdate += new System.EventHandler(this.comboBoxFileName_TextUpdate);
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(350, 77);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(23, 13);
            this.labelExtension.TabIndex = 9;
            this.labelExtension.Text = ".zip";
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
            this.pictureBoxStatus.Location = new System.Drawing.Point(482, 25);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxStatus.TabIndex = 10;
            this.pictureBoxStatus.TabStop = false;
            // 
            // Form_ArchiveTo
            // 
            this.AcceptButton = this.buttonArchive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 115);
            this.Controls.Add(this.pictureBoxStatus);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.comboBoxFileName);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.comboBoxFolder);
            this.Controls.Add(this.labelZipFileName);
            this.Controls.Add(this.buttonChangeFolder);
            this.Controls.Add(this.labelZipPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}