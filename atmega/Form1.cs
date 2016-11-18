using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace atmega
{
    public partial class Form1 : Form
    {
        private string Avrdude = "avrdude";
        private string Verbose = "-v";
        private string AtmegaName = "-p m128";
        private string Programmer = "-c jtag1";
        private string COMPortParameter = "-P";
        private string COMPort;
        private string Flash = "-Uflash:w:";
        private string HexaName;
        private string IHexa = ":i";
        private string command = null;

        

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "HEX fájlok (*.hex) | *.hex";
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                COMPortComboBox.Items.Add(port);
            }
        }

        private void HexaOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                HexaName = openFileDialog1.FileName;
                HexSelectedLabel.Visible = true;
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.Arguments = "/C" + " " + CMDTextbox.Text;
            Process proc = new Process();
            proc.StartInfo = info;
            proc.Start();
            HexSelectedLabel.Visible = false;
            COMSelectedLabel.Visible = false;
            CMDTextbox.Text = "";
            HexaName = null;
            command = null;
            COMPort = null;
            COMPortComboBox.SelectedItem = null;
            COMPortComboBox.SelectedText = null;
            COMPortComboBox.SelectedValue = null;
            WriteButton.Enabled = false;
        }

        private void COMPortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (COMPortComboBox.SelectedItem != null)
            {
                COMPort = COMPortComboBox.SelectedItem.ToString();
                COMSelectedLabel.Visible = true;
            }
        }

        private void CheckCMDButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMPort == null) throw new Exception("COM port választása kötelező!");
                else if (HexaName == null) throw new Exception("HEX fájl kiválasztása kötelező!");
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(Avrdude);
                    sb.Append(" ");
                    sb.Append(Verbose);
                    sb.Append(" ");
                    sb.Append(AtmegaName);
                    sb.Append(" ");
                    sb.Append(Programmer);
                    sb.Append(" ");
                    sb.Append(COMPortParameter);
                    sb.Append(" ");
                    sb.Append(COMPort);
                    sb.Append(" ");
                    sb.Append(Flash);
                    sb.AppendFormat("\"{0}\"", HexaName);
                    sb.Append(IHexa);
                    command = sb.ToString();
                    command.Replace("\\", "/");
                    CMDTextbox.Text = command;
                    WriteButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CMDTextbox.Text = "";
            HexaName = null;
            command = null;
            COMPort = null;
            COMPortComboBox.SelectedItem = null;
            COMPortComboBox.SelectedText = null;
            COMPortComboBox.SelectedValue = null;
            HexSelectedLabel.Visible = false;
            COMSelectedLabel.Visible = false;
            WriteButton.Enabled = false;
        }
    }
}
