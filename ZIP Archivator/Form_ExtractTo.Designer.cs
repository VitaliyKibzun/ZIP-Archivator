namespace ZIP_Archivator
{
    partial class Form_ExtractTo
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
            this.labelExtractTo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChangeFolder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExtractTo
            // 
            this.labelExtractTo.AutoSize = true;
            this.labelExtractTo.Location = new System.Drawing.Point(13, 13);
            this.labelExtractTo.Name = "labelExtractTo";
            this.labelExtractTo.Size = new System.Drawing.Size(36, 13);
            this.labelExtractTo.TabIndex = 0;
            this.labelExtractTo.Text = "Folder";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonChangeFolder
            // 
            this.buttonChangeFolder.Location = new System.Drawing.Point(379, 29);
            this.buttonChangeFolder.Name = "buttonChangeFolder";
            this.buttonChangeFolder.Size = new System.Drawing.Size(90, 23);
            this.buttonChangeFolder.TabIndex = 2;
            this.buttonChangeFolder.Text = "Change Folder";
            this.buttonChangeFolder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZIP_Archivator.Properties.Resources.Extract_object_icon_72x72;
            this.pictureBox1.Location = new System.Drawing.Point(482, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(379, 73);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(90, 23);
            this.buttonExtract.TabIndex = 4;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            // 
            // ExtractTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 113);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChangeFolder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelExtractTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtractTo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extract To...";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExtractTo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonChangeFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExtract;
    }
}