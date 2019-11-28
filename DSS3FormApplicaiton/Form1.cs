using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace DSS3FormApplicaiton
{
    public partial class Form1 : Form
    {
        string BCJissekiPath = @"\\yganas01\YDrive\Drop\DSS\BC_JISSEKI\";
        string YCJissekiPath = @"\\yganas01\YDrive\Drop\DSS\YC_JISSEKI\";

        string BCCurrencyPath = @"M:\Count\Currency\Buckys\";
        string YCCurrencyPath = @"M:\Count\Currency\Yavapai\";

        string bcCurrencyBackupPath = @"\\yganas01\YDrive\Drop\DSS\BCCurrencyBackup\";
        string ycCurrencyBackupPath = @"\\yganas01\YDrive\Drop\DSS\YCCurrencyBackup\";

        IOSystem ioSystemObj = new IOSystem();

        public string ShowTotalBefore { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            date_label.Text = date;
        }

        private List<bool> radioButtonList()
        {
            List<bool> locationButtons = new List<bool>();
            locationButtons.Add(BC_radioButton.Checked.Equals(true));
            locationButtons.Add(YC_radioButton.Checked.Equals(true));

            return locationButtons;
        }

        private void view_Button_Click(object sender, EventArgs e)
        {
            int location = CheckLocation(radioButtonList());
            Jisseki_richTextBox.Text = string.Empty;
            beforeCurrency_richTextBox.Text = string.Empty;
            afterCurrency_richTextBox.Text = string.Empty;

            if (location == 0)
            {
                ViewJissekiFile(BCJissekiPath);

                ViewCurrencyFiles(BCCurrencyPath, bcCurrencyBackupPath);
                Search(beforeCurrency_richTextBox, zero_textBox);
                Search(afterCurrency_richTextBox, zero_textBox);

                ShowNotBoxes(BCJissekiPath);
                ShowNotMachines(BCJissekiPath);
                ViewDuplicateMachines(BCJissekiPath);
                ViewDuplicateBoxes(BCJissekiPath);
            }
            else if (location == 1)
            {
                ViewJissekiFile(YCJissekiPath);

                ViewCurrencyFiles(YCCurrencyPath, ycCurrencyBackupPath);
                Search(beforeCurrency_richTextBox, zero_textBox);
                Search(afterCurrency_richTextBox, zero_textBox);
                ShowNotBoxes(YCJissekiPath);
                ShowNotMachines(YCJissekiPath);
                ViewDuplicateMachines(YCJissekiPath);
                ViewDuplicateBoxes(YCJissekiPath);
            }
            else
                MessageBox.Show("No location was selected");
        }

        //Jisseki file----------------------------------------------------------------------------------------------------------
        private void ViewJissekiFile(string jissekiPath)
        {
            List<string> jissekiFile = new List<string>();

            jissekiFile = ioSystemObj.ReturnNewestFile(jissekiPath);

            string output = string.Empty;

            for (int i = 0; i < jissekiFile.Count; i++)
            {
                jissekiFile[i] = jissekiFile[i].Replace(" ", "");
                jissekiFile[i] = jissekiFile[i].Replace(",", ", ");

                output += $"{i}. {jissekiFile[i]}\r\n";
            }

            Jisseki_richTextBox.Text = output;
            GetTotalBoxesScanned(jissekiFile);
        }

        private void GetTotalBoxesScanned(List<string> jissekiFile)
        {
            totalBoxesScanned_label.Text = jissekiFile.Count.ToString();
        }

        //------------------------------------------------------------------------------------------------------------------------
        private void ViewCurrencyFiles(string currencyFilePath, string currencyBackupPath)
        {
            
            beforeCurrency_richTextBox.Text = GetCurrencyFile(currencyBackupPath);

            beforeCurrencyCount_label.Text = GetTotalCurrencyItems(currencyBackupPath);
            currencyTotalBefore_label.Text = ShowCurrencyTotals(currencyBackupPath);

            afterCurrency_richTextBox.Text = GetCurrencyFile(currencyFilePath);
            afterCurrencyCount_label.Text = GetTotalCurrencyItems(currencyFilePath);
            currencyTotalAfter_label.Text = ShowCurrencyTotals(currencyFilePath);
        }

        private string GetCurrencyFile(string currencyPath)
        {
            string output = string.Empty;
            List<string> currencyFile = new List<string>();

            currencyFile = ioSystemObj.ReturnNewestFile(currencyPath);

            for (int i = 0; i < currencyFile.Count; i++)
            {
                currencyFile[i] = currencyFile[i].Replace(" ", "");
                currencyFile[i] = currencyFile[i].Replace(",", ", ");

                output += $"{i}. {currencyFile[i]}\r\n";
            }
            return output;
        }

        private string[] CutListDownToOnlyCurrency(string currencyPath)
        {

            List<string> cutList = new List<string>();
            List<string> currencyFile = new List<string>();
            string rawCurrencyFile = string.Empty;

            currencyFile = ioSystemObj.ReturnNewestFile(currencyPath);

            int camaIndex = 0;
            string output = string.Empty;

            for (int i = 0; i < currencyFile.Count; i++)
            {
                camaIndex = currencyFile[i].IndexOf(',');

                cutList.Add(currencyFile[i].Remove(0, camaIndex + 1));
            }

            rawCurrencyFile = string.Join(",", cutList);

            string[] list = rawCurrencyFile.Split(',');

            return list;

        }
        
        private string GetTotalCurrencyItems(string currencyFile)
        {
            List<string> currencyList = new List<string>();

            currencyList = ioSystemObj.ReturnNewestFile(currencyFile);

            return currencyList.Count.ToString();
        }

        private string ShowCurrencyTotals(string currencyPath)
        {
            string[] list = CutListDownToOnlyCurrency(currencyPath);

            double total = 0;
            foreach (string j in list)
            {
                if (double.TryParse(j, out double result).Equals(true))
                {
                    total += result;

                }
                else
                {
                    continue;
                }
            }
            return $"{total:C2}";
        }

        //-------------------------------------------------------------------------------------------------------------------
        //Errors
        private void ViewDuplicateMachines(string jissekiPath)
        {
            List<string> jissekiList = new List<string>();
            List<string> justMachineList = new List<string>();
            List<string> duplicateList = new List<string>();
            

            jissekiList = ioSystemObj.ReturnNewestFile(jissekiPath);

            string output = string.Empty;

            int firstCama = 0;
            int lastCama = 0;

            for (int i = 0; i < jissekiList.Count; i++)
            {
                firstCama = jissekiList[i].IndexOf(',');
                string temp = jissekiList[i].Remove(0, firstCama + 1).Replace(" ", "");

                lastCama = temp.LastIndexOf(',');

                justMachineList.Add(temp.Remove(lastCama));
            }

            for (int i = 0; i < justMachineList.Count; i++)
            {
                string temp = justMachineList[i];
                justMachineList.Remove(temp);

                for (int j = 0;  j < justMachineList.Count;  j++)
                {
                    if (temp == justMachineList[j])
                        duplicateList.Add($"Machine: {temp} at line {i}");
                }

                justMachineList.Insert(i, temp);
            }

            duplicateList.Sort();
            foreach (string i in duplicateList)
                output += $"{i}\r\n";

            dupMachine_textBox.Text = output;
        }

        private void ViewDuplicateBoxes(string jissekiPath)
        {
            List<string> jissekiList = new List<string>();
            List<string> justBoxList = new List<string>();
            List<string> duplicateList = new List<string>();


            jissekiList = ioSystemObj.ReturnNewestFile(jissekiPath);

            string output = string.Empty;

            int lastCama = 0;
           

            for (int i = 0; i < jissekiList.Count; i++)
            {
                lastCama = jissekiList[i].LastIndexOf(',');
                justBoxList.Add(jissekiList[i].Remove(0, lastCama + 1).Replace(" ", ""));
            }

            for (int i = 0; i < justBoxList.Count; i++)
            {
                string temp = justBoxList[i];
                justBoxList.Remove(temp);

                for (int j = 0; j < justBoxList.Count; j++)
                {
                    if (temp == justBoxList[j])
                        duplicateList.Add($"Box: {temp} at line {i}");
                }

                justBoxList.Insert(i, temp);
            }

            duplicateList.Sort();
            foreach (string i in duplicateList)
                output += $"{i}\r\n";

            dupBox_textBox.Text = output;
        }
        
        private void ShowNotBoxes(string jissekiPath)
        {
            List<string> jissekiList = new List<string>();
            List<string> boxList = new List<string>();
            List<string> notABoxList = new List<string>();

            jissekiList = ioSystemObj.ReturnNewestFile(jissekiPath);

            string output = string.Empty;

            int lastCama = 0;

            for (int i = 0; i < jissekiList.Count; i++)
            {
                lastCama = jissekiList[i].LastIndexOf(',');

                boxList.Add(jissekiList[i].Remove(0, lastCama + 1).Replace(" ",""));

                if (boxList[i][1] != 'C')
                    notABoxList.Add($"{boxList[i]} : at line {i}");
            }

            notABoxList.Sort();
            foreach (string i in notABoxList)
                output += $"{i}\r\n";

            notABox_textBox.Text = output;
        }
        
        private void ShowNotMachines(string jissekiPath)
        {
            List<string> jissekiList = new List<string>();
            List<string> machineList = new List<string>();
            List<string> notAMachineList = new List<string>();

            jissekiList = ioSystemObj.ReturnNewestFile(jissekiPath);

            string output = string.Empty;

            int firstCama = 0;
            int lastCama = 0;

            for (int i = 0; i < jissekiList.Count; i++)
            {
                firstCama = jissekiList[i].IndexOf(",");
                

                string currentLine = jissekiList[i].Remove(0, firstCama + 1).Replace(" ", "");

                lastCama = currentLine.LastIndexOf(",");

                machineList.Add(currentLine.Remove(lastCama));

                if (machineList[i][1] == 'C')
                    notAMachineList.Add($"{machineList[i]} : at line {i}");
            }

            notAMachineList.Sort();
            foreach (string i in notAMachineList)
                output += $"{i}\r\n";

            notAMachine_textBox.Text = output;

        }

        //----------------------------------------------------------------------------------------------------------------

        //Check the radio button location
        private int CheckLocation(List<bool> locationButton)
        {
            if (locationButton[0].Equals(true))
                return 0;
            else if (locationButton[1].Equals(true))
                return 1;
            else
                return 2;
        }
        
        //Tool strip menu-------------------------------------------------------------------------------------------------
        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.ShowDialog();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSTranscript dssTranscriptForm = new DSSTranscript();
            dssTranscriptForm.ShowDialog();
        }

        private void originalViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ycJissekiBackupPath = @"\\yganas01\YDrive\Drop\DSS\YC_JissekiBackup\";
            string bcJissekiBackupPath = @"\\yganas01\YDrive\Drop\DSS\BC_JissekiBackup\";

            List<string> latestBackupFile = new List<string>();

            latestBackupFile = ioSystemObj.ReturnNewestFile(ycJissekiBackupPath);

            string output = string.Empty;

            for (int i = 0; i < latestBackupFile.Count; i++)
            {
                latestBackupFile[i] = latestBackupFile[i].Replace(" ", "");
                latestBackupFile[i] = latestBackupFile[i].Replace(",", ", ");

                output += $"{i}. {latestBackupFile[i]}\r\n";
            }

            Jisseki_richTextBox.Text = output;
            ShowNotBoxes(ycJissekiBackupPath);
            ShowNotMachines(ycJissekiBackupPath);
            ViewDuplicateMachines(ycJissekiBackupPath);
            ViewDuplicateBoxes(ycJissekiBackupPath);
        }

        //Searching--------------------------------------------------------------------------------------------------------
        private void searchJisseki_button_Click(object sender, EventArgs e)
        {
            Search(Jisseki_richTextBox, searchJisseki_textBox);
        }

        private void searchBeforeCurrency_button_Click(object sender, EventArgs e)
        {
            Search(beforeCurrency_richTextBox, searchBeforeCurrency_textBox);
        }

        private void searchAfterCurrency_button_Click(object sender, EventArgs e)
        {
            Search(afterCurrency_richTextBox, searchAfterCurrency_textBox);
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

        private void totalsPerLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalPerLineForm totalPerLineForm = new TotalPerLineForm();
            totalPerLineForm.ShowDialog();
        }
    }
}
