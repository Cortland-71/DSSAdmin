using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace DSS3FormApplicaiton
{
    public partial class TotalPerLineForm : Form
    {
        public TotalPerLineForm()
        {
            InitializeComponent();
        }

        private void TotalPerLineForm_Load(object sender, EventArgs e)
        {

        }

        private void PerLineYCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string ycCurrencyBackupPath = @"\\yganas01\YDrive\Drop\DSS\YCCurrencyBackup\";
            GetTotalsForEachLine(ycCurrencyBackupPath);
        }

        private void PerLineBCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string bcCurrencyBackupPath = @"\\yganas01\YDrive\Drop\DSS\BCCurrencyBackup\";
            GetTotalsForEachLine(bcCurrencyBackupPath);
        }

        private void GetTotalsForEachLine(string path)
        {
            Totals_richTextBox.Clear();
            IOSystem ioTicketObj = new IOSystem();

            List<string> ycCurrencyList = new List<string>();
            ycCurrencyList = ioTicketObj.ReturnNewestFile(path);

            string[] numStringArr = null;
            List<double> numTotalsList = new List<double>();
            double answer = 0;

            for (int i = 0; i < ycCurrencyList.Count; i++)
            {
                answer = 0;
                int index = ycCurrencyList[i].IndexOf(',');
                string j = ycCurrencyList[i].Substring(index + 1);

                numStringArr = j.Split(',');

                for (int i2 = 0; i2 < numStringArr.Length; i2++)
                {
                    answer += double.Parse(numStringArr[i2]);
                }
                numTotalsList.Add(answer);

            }

            for (int i = 0; i < numTotalsList.Count; i++)
            {
                Totals_richTextBox.AppendText(i + ". " + numTotalsList[i] + "    " + ycCurrencyList[i] + "\n");
            }
        }

        private void searchTotals_button_Click(object sender, EventArgs e)
        {
            Search(Totals_richTextBox, searchTotals_textBox);
        }

        private void Search(RichTextBox rtextbox, TextBox searchField)
        {
            int index = 0;

            string temp = rtextbox.Text;
            rtextbox.Text = string.Empty;
            rtextbox.Text = temp;

            searchField.Text = searchField.Text.ToUpper();

            while (index < rtextbox.Text.LastIndexOf(searchField.Text))
            {
                rtextbox.Find(searchField.Text, index, rtextbox.TextLength, RichTextBoxFinds.None);

                rtextbox.SelectionBackColor = Color.Red;
                rtextbox.SelectionColor = Color.White;

                index = rtextbox.Text.IndexOf(searchField.Text, index) + 1;
            }
        }
    }
}
