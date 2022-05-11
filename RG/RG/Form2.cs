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

namespace RG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(p.ToString());
        }

        private void butWindowProcess_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in
            Process.GetProcesses(System.Environment.MachineName))
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    // Оконные приложения
                    listBox1.Items.Add(p.ToString());
                }
            }
        }
    }
}
