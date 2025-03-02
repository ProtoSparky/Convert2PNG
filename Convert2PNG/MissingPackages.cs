using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Convert2PNG
{
    public partial class MissingPackages : Form
    {
        private string DownloadLink = "https://protosparky.uk"; //temporary storage with a temporary link
        public MissingPackages()
        {
            InitializeComponent();
        }
        public void PopulateText(string packageName, string downloadLink)
        {
            DownloadLink = downloadLink; 
            errorLabel.Text = "Convert2PNG did not find " + packageName + " on your system!";
        }
        private void OpenDownloadLink(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = DownloadLink,
                    UseShellExecute = true // Ensures the system opens the default browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open link: " + ex.Message);
            }
        }
        private void Ok(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
