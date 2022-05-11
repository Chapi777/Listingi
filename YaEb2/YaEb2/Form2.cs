using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YaEb2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ComboBox cboNotDrop = new ComboBox();
            cboNotDrop.Parent = this;
            cboNotDrop.Width = 140;
            cboNotDrop.Height = 60;
            cboNotDrop.Location = new Point(185,13);
            cboNotDrop.Items.Add("One");
            cboNotDrop.Items.Add("Two");
            // ... и так далее
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // константы для левой кнопки мыши
            const int WM_LBUTTONDOWN = 0x201;
            const int WM_LBUTTONDBLCLK = 0x203;
            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONDBLCLK)
                return;
            base.WndProc(ref m);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");
            lstColor.Items.Add(Color.Red.Name);
            lstColor.Items.Add(Color.Yellow.Name);
            lstColor.Items.Add(Color.Green.Name);
            lstColor.Items.Add(Color.Blue.Name);
        }
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Извлекаем имя перетаскиваемого файла
            string[] astrings = (string[])e.Data.GetData(DataFormats.FileDrop,
            true);

            foreach (string strfile in astrings)
            {
                // только имя файла
                listBox1.Items.Add(strfile.Substring(1 +
                strfile.LastIndexOf(@"\")));
                // или полный путь к файлу
                listBox1.Items.Add(strfile);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = comboBox1.CreateGraphics();
            float maxWidth = 0f;
            foreach (object o in comboBox1.Items)
            {
                float w = g.MeasureString(o.ToString(), comboBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
            }
            g.Dispose();
            // 28 - учитываем ширину кнопки в поле со списком
            comboBox1.Width = (int)maxWidth + 28;
        }

        private void lstColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) != 0)
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            string itemText = lstColor.Items[e.Index].ToString();
            Color color = Color.FromName(itemText);
            //Рисуем строку
            e.Graphics.DrawString(itemText, Font, new SolidBrush(color),
            e.Bounds);
            Pen pen = new Pen(color);

            //Рисуем линию под строкой
            e.Graphics.DrawLine(pen, e.Bounds.X, e.Bounds.Bottom - 1,
            e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Font = new Font("Arial", 16);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == 'Б')
                e.Handled = true;  
            // по шаблону разрешаем вводить в поле цифры, знаки плюс, минус и запятую
            string pattern = "0123456789+-,";
            if (!Char.IsControl(e.KeyChar))
                if (pattern.IndexOf(e.KeyChar.ToString()) < 0)
                    e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
