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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.BackgroundColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = Color.Red;
            Properties.Settings.Default.Save();
        }
    }
}
