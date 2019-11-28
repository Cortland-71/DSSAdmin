using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS3FormApplicaiton
{
    public partial class DSSTranscript : Form
    {
        public DSSTranscript()
        {
            InitializeComponent();
        }

        private void DSSTranscript_Load(object sender, EventArgs e)
        {
            ViewTranscript(@"\\yganas01\YDrive\Drop\DSS\DSSTranscripts\");
        }

        private void ViewTranscript(string dssTranscriptPath)
        {
            IOSystem ioTranscriptObj = new IOSystem();
            List<string> transcript = new List<string>();

            string output = string.Empty;
            

            transcript = ioTranscriptObj.ReturnNewestFile(dssTranscriptPath);

            for (int i = 0; i < transcript.Count; i++)
            {
                output += $"{transcript[i]}\r\n";
            }

            dssTranscript_richTextBox.Text = output;
        }
    }
}
