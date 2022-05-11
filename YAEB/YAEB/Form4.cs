using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YAEB
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public static int FinfMax3(int a, int b, int c)
        {
            int max;
            max = Math.Max(a, Math.Max(b,c));
            return max;
        }
        public static int FinfMin3(int a, int b, int c)
        {
            int min;
            min = Math.Min(a, Math.Min(b, c));
            return min;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Add("Наибольшее из 3 чисел" + FinfMax3(x, y, z));
            listBox1.Items.Add("Наименьшее из 3 чисел" + FinfMin3(x,y,z));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь","");
            listBox1.Items.Add(s[Convert.ToInt32(textBox4)]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void butScreenRes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Screen.PrimaryScreen.Bounds.Width.ToString() +"x" + Screen.PrimaryScreen.Bounds.Height.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Screen.GetWorkingArea(this).Width.ToString() + "x" + Screen.GetWorkingArea(this).Height.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap,
             new System.Drawing.Rectangle(new Point(0, 0), this.Size));
            // сохраняем в файл
            bitmap.Save("c:\\t.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
