using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSS3FormApplicaiton
{
    public partial class TicketForm : Form
    {
        string ticketPath = @"M:\Count\Tickets\";

        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            ViewTicketFile(ticketPath);
            SendKeys.Send("{Up}");
        }

        //Tickets
        private void ViewTicketFile(string ticketPath)
        {
            IOSystem ioTicketObj = new IOSystem();
            List<string> ticketList = new List<string>();

            string output = string.Empty;
            int numberOfTickets = 0;

            ticketList = ioTicketObj.ReturnNewestFile(ticketPath);

            for (int i = 0; i < ticketList.Count; i++)
            {
                output += $"{i}. {ticketList[i]}\r\n";
                numberOfTickets = i;
            }

            ticket_textBox.Text = output;
            totalTicketsScanned_label.Text = numberOfTickets.ToString();
        }
    }
}
