using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace V_EditorClassic
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblOS.Text = "Operating System: " + GetWindowsVersion();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetWindowsVersion()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
            {
                string productName = (string)key.GetValue("ProductName");
                string releaseId = (string)key.GetValue("ReleaseId");
                string buildVersion = (string)key.GetValue("CurrentBuild");

                return $"{productName} (Build {buildVersion})";
            }
        }
    }
}