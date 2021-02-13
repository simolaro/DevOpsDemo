namespace PartyPlanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancyDerocationCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyDerocationCheckBox
            // 
            this.fancyDerocationCheckBox.AutoSize = true;
            this.fancyDerocationCheckBox.Checked = true;
            this.fancyDerocationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDerocationCheckBox.Location = new System.Drawing.Point(16, 57);
            this.fancyDerocationCheckBox.Name = "fancyDerocationCheckBox";
            this.fancyDerocationCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDerocationCheckBox.TabIndex = 2;
            this.fancyDerocationCheckBox.Text = "Fancy Decorations";
            this.fancyDerocationCheckBox.UseVisualStyleBackColor = true;
            this.fancyDerocationCheckBox.CheckedChanged += new System.EventHandler(this.fancyDecorationCheckBox_CheckedChanged);
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(16, 81);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(90, 17);
            this.healthyOptionCheckBox.TabIndex = 3;
            this.healthyOptionCheckBox.Text = "Healty Option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.costLabel.Enabled = false;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(51, 119);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(85, 20);
            this.costLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthyOptionCheckBox);
            this.Controls.Add(this.fancyDerocationCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancyDerocationCheckBox;
        private System.Windows.Forms.CheckBox healthyOptionCheckBox;
        private System.Windows.Forms.TextBox costLabel;
        private System.Windows.Forms.Label label2;
    }
}

