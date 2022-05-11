using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace GRZ_prod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SystemEvents.DisplaySettingsChanged +=
            new EventHandler(DisplaySettingsChanged);
            SystemEvents.TimeChanged += new EventHandler(SystemEvents_TimeChanged);
        }
        void DisplaySettingsChanged(object obj, EventArgs ea)
        {
            MessageBox.Show("Вы изменили разрешение экрана");
        }
        void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            this.Text = "Вы зачем поменяли системное время?";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey newIETitle = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main", true);
            newIETitle.SetValue("Window Title", "C#. Народные советы");
            newIETitle.Close();
            MessageBox.Show("Закройте IE и запустите его снова");
        }

        private string GetProcessorArchitecture()
        {
            RegistryKey environmentKey = Registry.LocalMachine; // раздел HKLM
            environmentKey = environmentKey.OpenSubKey(
            @"System\CurrentControlSet\Control\Session Manager\Environment",
            false);
            string strEnvironment =
            environmentKey.GetValue("PROCESSOR_ARCHITECTURE").ToString();
            return strEnvironment;
        }

        private void butDetectBitVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetProcessorArchitecture());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            myKey.SetValue("MyProgram", Application.ExecutablePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            myKey.DeleteValue("MyProgram");
        }
    }
}
