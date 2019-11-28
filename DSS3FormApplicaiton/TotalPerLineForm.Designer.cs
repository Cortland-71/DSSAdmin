namespace DSS3FormApplicaiton
{
    partial class TotalPerLineForm
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
            this.PerLineYCRadioButton = new System.Windows.Forms.RadioButton();
            this.PerLineBCRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTotals_button = new System.Windows.Forms.Button();
            this.searchTotals_textBox = new System.Windows.Forms.TextBox();
            this.Totals_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PerLineYCRadioButton
            // 
            this.PerLineYCRadioButton.AutoSize = true;
            this.PerLineYCRadioButton.ForeColor = System.Drawing.Color.White;
            this.PerLineYCRadioButton.Location = new System.Drawing.Point(92, 26);
            this.PerLineYCRadioButton.Name = "PerLineYCRadioButton";
            this.PerLineYCRadioButton.Size = new System.Drawing.Size(64, 17);
            this.PerLineYCRadioButton.TabIndex = 42;
            this.PerLineYCRadioButton.TabStop = true;
            this.PerLineYCRadioButton.Text = "Yavapai";
            this.PerLineYCRadioButton.UseVisualStyleBackColor = true;
            this.PerLineYCRadioButton.CheckedChanged += new System.EventHandler(this.PerLineYCRadioButton_CheckedChanged);
            // 
            // PerLineBCRadioButton
            // 
            this.PerLineBCRadioButton.AutoSize = true;
            this.PerLineBCRadioButton.ForeColor = System.Drawing.Color.White;
            this.PerLineBCRadioButton.Location = new System.Drawing.Point(24, 26);
            this.PerLineBCRadioButton.Name = "PerLineBCRadioButton";
            this.PerLineBCRadioButton.Size = new System.Drawing.Size(62, 17);
            this.PerLineBCRadioButton.TabIndex = 41;
            this.PerLineBCRadioButton.TabStop = true;
            this.PerLineBCRadioButton.Text = "Bucky\'s";
            this.PerLineBCRadioButton.UseVisualStyleBackColor = true;
            this.PerLineBCRadioButton.CheckedChanged += new System.EventHandler(this.PerLineBCRadioButton_CheckedChanged);
            // 
            // searchTotals_button
            // 
            this.searchTotals_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchTotals_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTotals_button.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTotals_button.ForeColor = System.Drawing.Color.Lime;
            this.searchTotals_button.Location = new System.Drawing.Point(370, 21);
            this.searchTotals_button.Name = "searchTotals_button";
            this.searchTotals_button.Size = new System.Drawing.Size(50, 26);
            this.searchTotals_button.TabIndex = 44;
            this.searchTotals_button.Text = "search";
            this.searchTotals_button.UseVisualStyleBackColor = true;
            this.searchTotals_button.Click += new System.EventHandler(this.searchTotals_button_Click);
            // 
            // searchTotals_textBox
            // 
            this.searchTotals_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTotals_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTotals_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchTotals_textBox.Location = new System.Drawing.Point(178, 23);
            this.searchTotals_textBox.Name = "searchTotals_textBox";
            this.searchTotals_textBox.Size = new System.Drawing.Size(186, 20);
            this.searchTotals_textBox.TabIndex = 43;
            // 
            // Totals_richTextBox
            // 
            this.Totals_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Totals_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totals_richTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.Totals_richTextBox.Location = new System.Drawing.Point(24, 67);
            this.Totals_richTextBox.Name = "Totals_richTextBox";
            this.Totals_richTextBox.Size = new System.Drawing.Size(633, 655);
            this.Totals_richTextBox.TabIndex = 45;
            this.Totals_richTextBox.Text = "";
            // 
            // TotalPerLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(680, 748);
            this.Controls.Add(this.Totals_richTextBox);
            this.Controls.Add(this.searchTotals_button);
            this.Controls.Add(this.searchTotals_textBox);
            this.Controls.Add(this.PerLineYCRadioButton);
            this.Controls.Add(this.PerLineBCRadioButton);
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Name = "TotalPerLineForm";
            this.Text = "TotalPerLineForm";
            this.Load += new System.EventHandler(this.TotalPerLineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton PerLineYCRadioButton;
        private System.Windows.Forms.RadioButton PerLineBCRadioButton;
        private System.Windows.Forms.Button searchTotals_button;
        private System.Windows.Forms.TextBox searchTotals_textBox;
        private System.Windows.Forms.RichTextBox Totals_richTextBox;
    }
}