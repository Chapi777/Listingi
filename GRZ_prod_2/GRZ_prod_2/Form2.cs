using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Reflection.Emit;
using System.Runtime;
using System.Security.AccessControl;

namespace GRZ_prod_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath,
            int shortPathLength);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetLongPathName(
        [MarshalAs(UnmanagedType.LPTStr)] string path,
        [MarshalAs(UnmanagedType.LPTStr)] StringBuilder longPath,
        int longPathLength
        );

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder shortPath = new StringBuilder(1024);
            GetShortPathName(@"C:\Program Files", shortPath, shortPath.Capacity);
            this.Text = shortPath.ToString();
            StringBuilder longPath = new StringBuilder(1024);
            GetLongPathName(this.Text, longPath, longPath.Capacity);
            listBox1.Items.Clear();
            listBox1.Items.Add(longPath.ToString());
        }
    }
}
