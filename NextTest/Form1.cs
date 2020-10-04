using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Threading;
using NextTest;

namespace NetworkManager
{
    public partial class Form1 : Form
    {
        string switchNetworkFile = "";
        public Form1()
        {
            switchNetworkFile = ExtracNetworkBatchFile();
            InitializeComponent();
            this.TransparencyKey = BackColor = Color.Turquoise;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }



        //Toggle switch position activity
        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            int exitCode = 0;
            if (((JCS.ToggleSwitch)sender).CheckedString == "IL")
            {
                exitCode = SwitchNetwork("IL");
                btnDisableNetwork.Enabled = true;
                btnDisableNetwork.Text = "Disable Networks";
                MessageBox.Show($"IL exitCode = {exitCode.ToString()}");
                Thread.Sleep(1000);
                if (exitCode == 0)
                {
                    ChangeLedBulbColor(true);
                }
                else
                {
                    ChangeLedBulbColor(false);
                }
            }
            else
            {
                exitCode = SwitchNetwork("US");
                btnDisableNetwork.Enabled = true;
                btnDisableNetwork.Text = "Disable Networks";
                Thread.Sleep(1000);
                if (exitCode == 0)
                {
                    MessageBox.Show($"US expected: 0, actual: exitCode = {exitCode.ToString()}");

                    ChangeLedBulbColor(true);
                }
                else
                {
                    MessageBox.Show($"US expected: 1, actual: exitCode = {exitCode.ToString()}");
                    ChangeLedBulbColor(false);
                }
            }
        }
        //Disable network Button click 
        private void btnDisableNetwork_Click(object sender, EventArgs e)
        {
            btnDisableNetwork.Enabled = false;
            SwitchNetwork("YAKIR");
            btnDisableNetwork.Text = "Disabled";
            ChangeLedBulbColor(false);
        }
        // Extracting Batch File 
        private string ExtracNetworkBatchFile()
        {
            string switchNetworkFile = Path.Combine(Path.GetTempPath(), "SwitchNetwork.bat");
            string resourcePath = "NextTest.Resources.SwitchNetwork.bat";
            ExtractResource(resourcePath, switchNetworkFile);

            return switchNetworkFile;
        }
        // Led Buld connection indicator
        private void ChangeLedBulbColor(bool isOn)
        {
            LebBulbIndicator.On = isOn;
            
        }

        private int checkNetworkStatus()
        {
            // exit code 2 means connected to IL, else if 3 means connected to US
            string checkNetwork = "netsh interface show interface name=\"EthernetIL\" | find \"Connect state\" |find \"Connected\" > exit 2 || exit 3";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"/c {checkNetwork}";
            startInfo.FileName = "cmd.exe";

            Process process = new Process();
            process.StartInfo = startInfo;

            process.Start();

            process.WaitForExit();
            return process.ExitCode;

        }

        /// Switching networks function.
        private int SwitchNetwork(string country)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"/c {switchNetworkFile} {country}";
            startInfo.FileName = "cmd.exe";

            Process process = new Process();
            process.StartInfo = startInfo;

            process.Start();

            process.WaitForExit();
            return process.ExitCode;
        }
      

        /// <summary>
        /// Extract the given resource to the given output file path
        /// </summary>
        /// <param name="resourcePath">Resource path to extract</param>
        /// <param name="outputFilePath">Destination file path to extract resource</param>
        public void ExtractResource(string resourcePath, string outputFilePath)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
            {
                using (FileStream fileStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    for (int i = 0; i < stream.Length; i++)
                    {
                        fileStream.WriteByte((byte)stream.ReadByte());
                    }
                    fileStream.Close();
                }
            }

        }
    }
}   
                
            

   

