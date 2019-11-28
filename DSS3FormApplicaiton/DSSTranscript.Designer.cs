namespace DSS3FormApplicaiton
{
    partial class DSSTranscript
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
            this.dssTranscript_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dssTranscript_richTextBox
            // 
            this.dssTranscript_richTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.dssTranscript_richTextBox.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dssTranscript_richTextBox.Location = new System.Drawing.Point(24, 47);
            this.dssTranscript_richTextBox.Name = "dssTranscript_richTextBox";
            this.dssTranscript_richTextBox.Size = new System.Drawing.Size(528, 614);
            this.dssTranscript_richTextBox.TabIndex = 0;
            this.dssTranscript_richTextBox.Text = "";
            // 
            // DSSTranscript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(578, 685);
            this.Controls.Add(this.dssTranscript_richTextBox);
            this.Name = "DSSTranscript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSSTranscript";
            this.Load += new System.EventHandler(this.DSSTranscript_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox dssTranscript_richTextBox;
    }
}