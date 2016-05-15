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
            this.button1 = new System.Windows.Forms.Button();
            this.ExtractWithOverwrite = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExtractTo
            // 
            this.labelExtractTo.AutoSize = true;
            this.labelExtractTo.Location = new System.Drawing.Point(17, 16);
            this.labelExtractTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtractTo.Name = "labelExtractTo";
            this.labelExtractTo.Size = new System.Drawing.Size(48, 17);
            this.labelExtractTo.TabIndex = 0;
            this.labelExtractTo.Text = "Folder";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(475, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonChangeFolder
            // 
            this.buttonChangeFolder.Location = new System.Drawing.Point(505, 36);
            this.buttonChangeFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeFolder.Name = "buttonChangeFolder";
            this.buttonChangeFolder.Size = new System.Drawing.Size(120, 28);
            this.buttonChangeFolder.TabIndex = 2;
            this.buttonChangeFolder.Text = "Change Folder";
            this.buttonChangeFolder.UseVisualStyleBackColor = true;
            this.buttonChangeFolder.Click += new System.EventHandler(this.buttonChangeFolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZIP_Archivator.Properties.Resources.Extract_object_icon_72x72;
            this.pictureBox1.Location = new System.Drawing.Point(649, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(364, 90);
            this.buttonExtract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(120, 28);
            this.buttonExtract.TabIndex = 4;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExtractWithOverwrite
            // 
            this.ExtractWithOverwrite.AutoSize = true;
            this.ExtractWithOverwrite.Location = new System.Drawing.Point(44, 78);
            this.ExtractWithOverwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExtractWithOverwrite.Name = "ExtractWithOverwrite";
            this.ExtractWithOverwrite.Size = new System.Drawing.Size(196, 21);
            this.ExtractWithOverwrite.TabIndex = 6;
            this.ExtractWithOverwrite.Text = "Overwrite all existing items";
            this.ExtractWithOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(44, 105);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(159, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Another functionality";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // Form_ExtractTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 139);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ExtractWithOverwrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChangeFolder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelExtractTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ExtractTo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extract To...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_ExtractTo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExtractTo;
        private System.Windows.Forms.Button buttonChangeFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ExtractWithOverwrite;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}