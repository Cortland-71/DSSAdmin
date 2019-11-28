namespace DSS3FormApplicaiton
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
            this.BC_radioButton = new System.Windows.Forms.RadioButton();
            this.YC_radioButton = new System.Windows.Forms.RadioButton();
            this.view_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notABox_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalBoxesScanned_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jisseki_richTextBox = new System.Windows.Forms.RichTextBox();
            this.searchJisseki_button = new System.Windows.Forms.Button();
            this.searchJisseki_textBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.afterCurrency_richTextBox = new System.Windows.Forms.RichTextBox();
            this.beforeCurrency_richTextBox = new System.Windows.Forms.RichTextBox();
            this.searchAfterCurrency_button = new System.Windows.Forms.Button();
            this.searchAfterCurrency_textBox = new System.Windows.Forms.TextBox();
            this.searchBeforeCurrency_button = new System.Windows.Forms.Button();
            this.searchBeforeCurrency_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.currencyTotalAfter_label = new System.Windows.Forms.Label();
            this.currencyTotalBefore_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.afterCurrencyCount_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.beforeCurrencyCount_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dupBox_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dupMachine_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.notAMachine_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zero_textBox = new System.Windows.Forms.TextBox();
            this.totalsPerLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BC_radioButton
            // 
            this.BC_radioButton.AutoSize = true;
            this.BC_radioButton.Location = new System.Drawing.Point(12, 20);
            this.BC_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BC_radioButton.Name = "BC_radioButton";
            this.BC_radioButton.Size = new System.Drawing.Size(71, 21);
            this.BC_radioButton.TabIndex = 2;
            this.BC_radioButton.TabStop = true;
            this.BC_radioButton.Text = "Bucky\'s";
            this.BC_radioButton.UseVisualStyleBackColor = true;
            // 
            // YC_radioButton
            // 
            this.YC_radioButton.AutoSize = true;
            this.YC_radioButton.Location = new System.Drawing.Point(12, 58);
            this.YC_radioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YC_radioButton.Name = "YC_radioButton";
            this.YC_radioButton.Size = new System.Drawing.Size(71, 21);
            this.YC_radioButton.TabIndex = 3;
            this.YC_radioButton.TabStop = true;
            this.YC_radioButton.Text = "Yavapai";
            this.YC_radioButton.UseVisualStyleBackColor = true;
            // 
            // view_Button
            // 
            this.view_Button.BackColor = System.Drawing.Color.Transparent;
            this.view_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_Button.ForeColor = System.Drawing.Color.DarkOrange;
            this.view_Button.Location = new System.Drawing.Point(1267, 190);
            this.view_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.view_Button.Name = "view_Button";
            this.view_Button.Size = new System.Drawing.Size(99, 30);
            this.view_Button.TabIndex = 5;
            this.view_Button.Text = "View";
            this.view_Button.UseVisualStyleBackColor = false;
            this.view_Button.Click += new System.EventHandler(this.view_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "# / Date / Machine / Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "*JISSEKI.CSV";
            // 
            // notABox_textBox
            // 
            this.notABox_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.notABox_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notABox_textBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.notABox_textBox.Location = new System.Drawing.Point(282, 37);
            this.notABox_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notABox_textBox.Multiline = true;
            this.notABox_textBox.Name = "notABox_textBox";
            this.notABox_textBox.ReadOnly = true;
            this.notABox_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notABox_textBox.Size = new System.Drawing.Size(181, 114);
            this.notABox_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not Boxes";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(119, 53);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(46, 17);
            this.date_label.TabIndex = 10;
            this.date_label.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Today\'s date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Boxes Scanned:";
            // 
            // totalBoxesScanned_label
            // 
            this.totalBoxesScanned_label.AutoSize = true;
            this.totalBoxesScanned_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBoxesScanned_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.totalBoxesScanned_label.Location = new System.Drawing.Point(234, 6);
            this.totalBoxesScanned_label.Name = "totalBoxesScanned_label";
            this.totalBoxesScanned_label.Size = new System.Drawing.Size(21, 24);
            this.totalBoxesScanned_label.TabIndex = 13;
            this.totalBoxesScanned_label.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Jisseki_richTextBox);
            this.panel1.Controls.Add(this.searchJisseki_button);
            this.panel1.Controls.Add(this.searchJisseki_textBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dupBox_textBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dupMachine_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.notAMachine_textBox);
            this.panel1.Controls.Add(this.notABox_textBox);
            this.panel1.Controls.Add(this.totalBoxesScanned_label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 647);
            this.panel1.TabIndex = 14;
            // 
            // Jisseki_richTextBox
            // 
            this.Jisseki_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Jisseki_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jisseki_richTextBox.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jisseki_richTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.Jisseki_richTextBox.Location = new System.Drawing.Point(13, 69);
            this.Jisseki_richTextBox.Name = "Jisseki_richTextBox";
            this.Jisseki_richTextBox.Size = new System.Drawing.Size(242, 551);
            this.Jisseki_richTextBox.TabIndex = 32;
            this.Jisseki_richTextBox.Text = "";
            // 
            // searchJisseki_button
            // 
            this.searchJisseki_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchJisseki_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchJisseki_button.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJisseki_button.ForeColor = System.Drawing.Color.Lime;
            this.searchJisseki_button.Location = new System.Drawing.Point(205, 35);
            this.searchJisseki_button.Name = "searchJisseki_button";
            this.searchJisseki_button.Size = new System.Drawing.Size(50, 26);
            this.searchJisseki_button.TabIndex = 31;
            this.searchJisseki_button.Text = "search";
            this.searchJisseki_button.UseVisualStyleBackColor = true;
            this.searchJisseki_button.Click += new System.EventHandler(this.searchJisseki_button_Click);
            // 
            // searchJisseki_textBox
            // 
            this.searchJisseki_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchJisseki_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchJisseki_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchJisseki_textBox.Location = new System.Drawing.Point(13, 37);
            this.searchJisseki_textBox.Name = "searchJisseki_textBox";
            this.searchJisseki_textBox.Size = new System.Drawing.Size(186, 22);
            this.searchJisseki_textBox.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.afterCurrency_richTextBox);
            this.panel3.Controls.Add(this.beforeCurrency_richTextBox);
            this.panel3.Controls.Add(this.searchAfterCurrency_button);
            this.panel3.Controls.Add(this.searchAfterCurrency_textBox);
            this.panel3.Controls.Add(this.searchBeforeCurrency_button);
            this.panel3.Controls.Add(this.searchBeforeCurrency_textBox);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.currencyTotalAfter_label);
            this.panel3.Controls.Add(this.currencyTotalBefore_label);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.afterCurrencyCount_label);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.beforeCurrencyCount_label);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(266, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 456);
            this.panel3.TabIndex = 29;
            // 
            // afterCurrency_richTextBox
            // 
            this.afterCurrency_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.afterCurrency_richTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.afterCurrency_richTextBox.Location = new System.Drawing.Point(484, 83);
            this.afterCurrency_richTextBox.Name = "afterCurrency_richTextBox";
            this.afterCurrency_richTextBox.Size = new System.Drawing.Size(453, 354);
            this.afterCurrency_richTextBox.TabIndex = 37;
            this.afterCurrency_richTextBox.Text = "";
            // 
            // beforeCurrency_richTextBox
            // 
            this.beforeCurrency_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.beforeCurrency_richTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.beforeCurrency_richTextBox.Location = new System.Drawing.Point(15, 83);
            this.beforeCurrency_richTextBox.Name = "beforeCurrency_richTextBox";
            this.beforeCurrency_richTextBox.Size = new System.Drawing.Size(456, 354);
            this.beforeCurrency_richTextBox.TabIndex = 36;
            this.beforeCurrency_richTextBox.Text = "";
            // 
            // searchAfterCurrency_button
            // 
            this.searchAfterCurrency_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchAfterCurrency_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAfterCurrency_button.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAfterCurrency_button.ForeColor = System.Drawing.Color.Lime;
            this.searchAfterCurrency_button.Location = new System.Drawing.Point(709, 53);
            this.searchAfterCurrency_button.Name = "searchAfterCurrency_button";
            this.searchAfterCurrency_button.Size = new System.Drawing.Size(50, 26);
            this.searchAfterCurrency_button.TabIndex = 35;
            this.searchAfterCurrency_button.Text = "search";
            this.searchAfterCurrency_button.UseVisualStyleBackColor = true;
            this.searchAfterCurrency_button.Click += new System.EventHandler(this.searchAfterCurrency_button_Click);
            // 
            // searchAfterCurrency_textBox
            // 
            this.searchAfterCurrency_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchAfterCurrency_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchAfterCurrency_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchAfterCurrency_textBox.Location = new System.Drawing.Point(479, 55);
            this.searchAfterCurrency_textBox.Name = "searchAfterCurrency_textBox";
            this.searchAfterCurrency_textBox.Size = new System.Drawing.Size(224, 22);
            this.searchAfterCurrency_textBox.TabIndex = 34;
            // 
            // searchBeforeCurrency_button
            // 
            this.searchBeforeCurrency_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBeforeCurrency_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBeforeCurrency_button.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBeforeCurrency_button.ForeColor = System.Drawing.Color.Lime;
            this.searchBeforeCurrency_button.Location = new System.Drawing.Point(245, 53);
            this.searchBeforeCurrency_button.Name = "searchBeforeCurrency_button";
            this.searchBeforeCurrency_button.Size = new System.Drawing.Size(50, 26);
            this.searchBeforeCurrency_button.TabIndex = 33;
            this.searchBeforeCurrency_button.Text = "search";
            this.searchBeforeCurrency_button.UseVisualStyleBackColor = true;
            this.searchBeforeCurrency_button.Click += new System.EventHandler(this.searchBeforeCurrency_button_Click);
            // 
            // searchBeforeCurrency_textBox
            // 
            this.searchBeforeCurrency_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBeforeCurrency_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBeforeCurrency_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.searchBeforeCurrency_textBox.Location = new System.Drawing.Point(15, 55);
            this.searchBeforeCurrency_textBox.Name = "searchBeforeCurrency_textBox";
            this.searchBeforeCurrency_textBox.Size = new System.Drawing.Size(224, 22);
            this.searchBeforeCurrency_textBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(690, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Total Currency:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(224, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Total Currency:";
            // 
            // currencyTotalAfter_label
            // 
            this.currencyTotalAfter_label.AutoSize = true;
            this.currencyTotalAfter_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTotalAfter_label.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.currencyTotalAfter_label.Location = new System.Drawing.Point(786, 26);
            this.currencyTotalAfter_label.Name = "currencyTotalAfter_label";
            this.currencyTotalAfter_label.Size = new System.Drawing.Size(59, 24);
            this.currencyTotalAfter_label.TabIndex = 23;
            this.currencyTotalAfter_label.Text = "$0.00";
            // 
            // currencyTotalBefore_label
            // 
            this.currencyTotalBefore_label.AutoSize = true;
            this.currencyTotalBefore_label.BackColor = System.Drawing.Color.Transparent;
            this.currencyTotalBefore_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTotalBefore_label.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.currencyTotalBefore_label.Location = new System.Drawing.Point(321, 25);
            this.currencyTotalBefore_label.Name = "currencyTotalBefore_label";
            this.currencyTotalBefore_label.Size = new System.Drawing.Size(59, 24);
            this.currencyTotalBefore_label.TabIndex = 22;
            this.currencyTotalBefore_label.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(475, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "After";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total currency items:";
            // 
            // afterCurrencyCount_label
            // 
            this.afterCurrencyCount_label.AutoSize = true;
            this.afterCurrencyCount_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterCurrencyCount_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.afterCurrencyCount_label.Location = new System.Drawing.Point(608, 24);
            this.afterCurrencyCount_label.Name = "afterCurrencyCount_label";
            this.afterCurrencyCount_label.Size = new System.Drawing.Size(21, 24);
            this.afterCurrencyCount_label.TabIndex = 17;
            this.afterCurrencyCount_label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(11, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Before ";
            // 
            // beforeCurrencyCount_label
            // 
            this.beforeCurrencyCount_label.AutoSize = true;
            this.beforeCurrencyCount_label.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeCurrencyCount_label.ForeColor = System.Drawing.Color.DarkOrange;
            this.beforeCurrencyCount_label.Location = new System.Drawing.Point(144, 25);
            this.beforeCurrencyCount_label.Name = "beforeCurrencyCount_label";
            this.beforeCurrencyCount_label.Size = new System.Drawing.Size(21, 24);
            this.beforeCurrencyCount_label.TabIndex = 20;
            this.beforeCurrencyCount_label.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total currency items:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Thistle;
            this.label11.Location = new System.Drawing.Point(475, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Duplicate Boxes";
            // 
            // dupBox_textBox
            // 
            this.dupBox_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dupBox_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dupBox_textBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.dupBox_textBox.Location = new System.Drawing.Point(478, 37);
            this.dupBox_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dupBox_textBox.Multiline = true;
            this.dupBox_textBox.Name = "dupBox_textBox";
            this.dupBox_textBox.ReadOnly = true;
            this.dupBox_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dupBox_textBox.Size = new System.Drawing.Size(260, 114);
            this.dupBox_textBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Thistle;
            this.label12.Location = new System.Drawing.Point(941, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Duplicate Machines";
            // 
            // dupMachine_textBox
            // 
            this.dupMachine_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dupMachine_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dupMachine_textBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.dupMachine_textBox.Location = new System.Drawing.Point(944, 38);
            this.dupMachine_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dupMachine_textBox.Multiline = true;
            this.dupMachine_textBox.Name = "dupMachine_textBox";
            this.dupMachine_textBox.ReadOnly = true;
            this.dupMachine_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dupMachine_textBox.Size = new System.Drawing.Size(260, 114);
            this.dupMachine_textBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Not Machines";
            // 
            // notAMachine_textBox
            // 
            this.notAMachine_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.notAMachine_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notAMachine_textBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.notAMachine_textBox.Location = new System.Drawing.Point(751, 37);
            this.notAMachine_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notAMachine_textBox.Multiline = true;
            this.notAMachine_textBox.Name = "notAMachine_textBox";
            this.notAMachine_textBox.ReadOnly = true;
            this.notAMachine_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notAMachine_textBox.Size = new System.Drawing.Size(181, 114);
            this.notAMachine_textBox.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.YC_radioButton);
            this.panel2.Controls.Add(this.BC_radioButton);
            this.panel2.Location = new System.Drawing.Point(1267, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 100);
            this.panel2.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.originalViewToolStripMenuItem,
            this.totalsPerLineToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currencyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.currencyToolStripMenuItem.Text = "DSS Transcript";
            this.currencyToolStripMenuItem.Click += new System.EventHandler(this.currencyToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ticketsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ticketsToolStripMenuItem_Click);
            // 
            // originalViewToolStripMenuItem
            // 
            this.originalViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.originalViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.originalViewToolStripMenuItem.Name = "originalViewToolStripMenuItem";
            this.originalViewToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.originalViewToolStripMenuItem.Text = "Original View";
            this.originalViewToolStripMenuItem.Click += new System.EventHandler(this.originalViewToolStripMenuItem_Click);
            // 
            // zero_textBox
            // 
            this.zero_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zero_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zero_textBox.ForeColor = System.Drawing.SystemColors.Info;
            this.zero_textBox.Location = new System.Drawing.Point(407, 37);
            this.zero_textBox.Name = "zero_textBox";
            this.zero_textBox.Size = new System.Drawing.Size(224, 22);
            this.zero_textBox.TabIndex = 33;
            this.zero_textBox.Text = "0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00";
            this.zero_textBox.Visible = false;
            // 
            // totalsPerLineToolStripMenuItem
            // 
            this.totalsPerLineToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.totalsPerLineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalsPerLineToolStripMenuItem.Name = "totalsPerLineToolStripMenuItem";
            this.totalsPerLineToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.totalsPerLineToolStripMenuItem.Text = "Totals per line";
            this.totalsPerLineToolStripMenuItem.Click += new System.EventHandler(this.totalsPerLineToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1386, 744);
            this.Controls.Add(this.zero_textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.view_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " DSS Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton BC_radioButton;
        private System.Windows.Forms.RadioButton YC_radioButton;
        private System.Windows.Forms.Button view_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notABox_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalBoxesScanned_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label afterCurrencyCount_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label beforeCurrencyCount_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox notAMachine_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dupMachine_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dupBox_textBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label currencyTotalAfter_label;
        private System.Windows.Forms.Label currencyTotalBefore_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button searchJisseki_button;
        private System.Windows.Forms.TextBox searchJisseki_textBox;
        private System.Windows.Forms.RichTextBox Jisseki_richTextBox;
        private System.Windows.Forms.Button searchAfterCurrency_button;
        private System.Windows.Forms.TextBox searchAfterCurrency_textBox;
        private System.Windows.Forms.Button searchBeforeCurrency_button;
        private System.Windows.Forms.TextBox searchBeforeCurrency_textBox;
        private System.Windows.Forms.RichTextBox beforeCurrency_richTextBox;
        private System.Windows.Forms.RichTextBox afterCurrency_richTextBox;
        private System.Windows.Forms.TextBox zero_textBox;
        private System.Windows.Forms.ToolStripMenuItem originalViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalsPerLineToolStripMenuItem;
    }
}

