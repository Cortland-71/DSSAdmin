namespace DSS3FormApplicaiton
{
    partial class TicketForm
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
            this.ticket_textBox = new System.Windows.Forms.TextBox();
            this.totalTicketsScanned_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quickFixTicket_button = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticket_textBox
            // 
            this.ticket_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ticket_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticket_textBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_textBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.ticket_textBox.Location = new System.Drawing.Point(26, 69);
            this.ticket_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket_textBox.Multiline = true;
            this.ticket_textBox.Name = "ticket_textBox";
            this.ticket_textBox.ReadOnly = true;
            this.ticket_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ticket_textBox.Size = new System.Drawing.Size(356, 544);
            this.ticket_textBox.TabIndex = 32;
            // 
            // totalTicketsScanned_label
            // 
            this.totalTicketsScanned_label.AutoSize = true;
            this.totalTicketsScanned_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTicketsScanned_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.totalTicketsScanned_label.Location = new System.Drawing.Point(146, 4);
            this.totalTicketsScanned_label.Name = "totalTicketsScanned_label";
            this.totalTicketsScanned_label.Size = new System.Drawing.Size(21, 24);
            this.totalTicketsScanned_label.TabIndex = 35;
            this.totalTicketsScanned_label.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total number of tickets:";
            // 
            // quickFixTicket_button
            // 
            this.quickFixTicket_button.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickFixTicket_button.Location = new System.Drawing.Point(164, 37);
            this.quickFixTicket_button.Name = "quickFixTicket_button";
            this.quickFixTicket_button.Size = new System.Drawing.Size(64, 25);
            this.quickFixTicket_button.TabIndex = 38;
            this.quickFixTicket_button.Text = "Quick fix";
            this.quickFixTicket_button.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(26, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bucky\'s";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(94, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yavapai";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(234, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 25);
            this.button1.TabIndex = 41;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(408, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.quickFixTicket_button);
            this.Controls.Add(this.totalTicketsScanned_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticket_textBox);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ticket_textBox;
        private System.Windows.Forms.Label totalTicketsScanned_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button quickFixTicket_button;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
    }
}