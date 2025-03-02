using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert2PNG
{
    public partial class ErrorReporting : Form
    {
        public ErrorReporting()
        {
            InitializeComponent();
        }

        private void ErrorReporting_Load(object sender, EventArgs e)
        {

        }
        public void Append2ErrorBox(string error)
        {
            ErrorBox.AppendText(error);
        }
        private void okPressed(object sender, EventArgs e)
        {
            Close(); //Closes the form when the OK button is pressed
        }
        private void submitError(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(ErrorBox.Text);
            var submit_link = "https://github.com/ProtoSparky/Convert2PNG/issues/new";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = submit_link,
                    UseShellExecute = true // Ensures the system opens the default browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open link: " + ex.Message);
            }
        }
    }
}
