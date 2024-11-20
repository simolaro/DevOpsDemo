namespace ExcuseManager
{
    partial class Form1
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
            this.randomButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderButton = new System.Windows.Forms.Button();
            this.excuseLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.lastUsedLabel = new System.Windows.Forms.Label();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.fileDate = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.randomButton.Enabled = false;
            this.randomButton.Location = new System.Drawing.Point(285, 123);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 0;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(205, 123);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(124, 123);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.folderButton.Location = new System.Drawing.Point(43, 123);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 3;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // excuseLabel
            // 
            this.excuseLabel.AutoSize = true;
            this.excuseLabel.Location = new System.Drawing.Point(13, 10);
            this.excuseLabel.Name = "excuseLabel";
            this.excuseLabel.Size = new System.Drawing.Size(42, 13);
            this.excuseLabel.TabIndex = 4;
            this.excuseLabel.Text = "Excuse";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(13, 36);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "Results";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lastUsedLabel
            // 
            this.lastUsedLabel.AutoSize = true;
            this.lastUsedLabel.Location = new System.Drawing.Point(13, 61);
            this.lastUsedLabel.Name = "lastUsedLabel";
            this.lastUsedLabel.Size = new System.Drawing.Size(55, 13);
            this.lastUsedLabel.TabIndex = 6;
            this.lastUsedLabel.Text = "Last Used";
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.AutoSize = true;
            this.fileDateLabel.Location = new System.Drawing.Point(13, 87);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(49, 13);
            this.fileDateLabel.TabIndex = 7;
            this.fileDateLabel.Text = "File Date";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(74, 10);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(286, 20);
            this.description.TabIndex = 8;
            this.description.TextChanged += new System.EventHandler(this.currentExcuse_TextChanged);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(74, 36);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(286, 20);
            this.results.TabIndex = 9;
            this.results.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // fileDate
            // 
            this.fileDate.Location = new System.Drawing.Point(74, 88);
            this.fileDate.Name = "fileDate";
            this.fileDate.ReadOnly = true;
            this.fileDate.Size = new System.Drawing.Size(286, 20);
            this.fileDate.TabIndex = 11;
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(75, 63);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(285, 20);
            this.lastUsed.TabIndex = 12;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 161);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.lastUsedLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.excuseLabel);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.randomButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label excuseLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label lastUsedLabel;
        private System.Windows.Forms.Label fileDateLabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TextBox fileDate;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

