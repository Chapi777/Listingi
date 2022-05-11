using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRZ_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            this.Text = WMP.versionInfo;
            WMP.URL =
            @"C:\Users\student\Downloads\ZAPOMNI – Я всё решу (Intro).mp3";
            WMP.controls.play();
        }
    }
}
