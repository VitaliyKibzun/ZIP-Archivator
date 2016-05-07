namespace ZIP_Archivator
{
    partial class FormZipArchivator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonArchiveTo = new System.Windows.Forms.Button();
            this.buttonExtractTo = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonArchiveTo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonExtractTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTest, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonView, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFind, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInfo, 6, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 74);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(193, 107);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(405, 21);
            this.comboBoxAddress.TabIndex = 2;
            this.comboBoxAddress.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAddress_SelectionChangeCommitted);
            this.comboBoxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxAddress_KeyDown);
            this.comboBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAddress_KeyPress);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(142, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(3, 134);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(650, 408);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderAddress.ContainerControl = this;
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::ZIP_Archivator.Properties.Resources.up_icon;
            this.buttonUp.Location = new System.Drawing.Point(85, 105);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(35, 23);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Image = global::ZIP_Archivator.Properties.Resources.forward_icon;
            this.buttonForward.Location = new System.Drawing.Point(44, 105);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(35, 23);
            this.buttonForward.TabIndex = 7;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Image = global::ZIP_Archivator.Properties.Resources.back_icon;
            this.buttonBack.Location = new System.Drawing.Point(3, 105);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 23);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Image = global::ZIP_Archivator.Properties.Resources.Button_Next_icon16x16;
            this.buttonGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGo.Location = new System.Drawing.Point(604, 107);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(49, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Go";
            this.buttonGo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // buttonArchiveTo
            // 
            this.buttonArchiveTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonArchiveTo.Image = global::ZIP_Archivator.Properties.Resources.Archive_icon;
            this.buttonArchiveTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonArchiveTo.Location = new System.Drawing.Point(3, 7);
            this.buttonArchiveTo.Name = "buttonArchiveTo";
            this.buttonArchiveTo.Size = new System.Drawing.Size(70, 60);
            this.buttonArchiveTo.TabIndex = 2;
            this.buttonArchiveTo.Text = "Archive To";
            this.buttonArchiveTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonArchiveTo.UseVisualStyleBackColor = true;
            this.buttonArchiveTo.Click += new System.EventHandler(this.buttonArchiveTo_Click);
            // 
            // buttonExtractTo
            // 
            this.buttonExtractTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExtractTo.Image = global::ZIP_Archivator.Properties.Resources.Extract_object_icon;
            this.buttonExtractTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExtractTo.Location = new System.Drawing.Point(79, 7);
            this.buttonExtractTo.Name = "buttonExtractTo";
            this.buttonExtractTo.Size = new System.Drawing.Size(70, 60);
            this.buttonExtractTo.TabIndex = 3;
            this.buttonExtractTo.TabStop = false;
            this.buttonExtractTo.Text = "Extract To";
            this.buttonExtractTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExtractTo.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonTest.Image = global::ZIP_Archivator.Properties.Resources.Tests_icon;
            this.buttonTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTest.Location = new System.Drawing.Point(155, 7);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(70, 60);
            this.buttonTest.TabIndex = 4;
            this.buttonTest.Text = "Test";
            this.buttonTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonView.Image = global::ZIP_Archivator.Properties.Resources.search_icon;
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonView.Location = new System.Drawing.Point(231, 7);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(70, 60);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "View";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelete.Image = global::ZIP_Archivator.Properties.Resources.edit_delete_icon;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(307, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 60);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFind.Image = global::ZIP_Archivator.Properties.Resources.Symbols_Find_icon;
            this.buttonFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFind.Location = new System.Drawing.Point(383, 7);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(70, 60);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonInfo.Image = global::ZIP_Archivator.Properties.Resources.Symbols_Info_icon;
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInfo.Location = new System.Drawing.Point(459, 7);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(70, 60);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // FormZipArchivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 694);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormZipArchivator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZIP Archivator";
            this.Load += new System.EventHandler(this.FormZipArchivator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonArchiveTo;
        private System.Windows.Forms.Button buttonExtractTo;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.Button buttonUp;
        public System.Windows.Forms.ComboBox comboBoxAddress;
    }
}

