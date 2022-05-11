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

namespace YaEb2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;
            this.richTextBox1.DragEnter +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox2_DragEnter);
            this.richTextBox1.DragDrop +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox2_DragEnter);
            RichTextBoxEx rboxex = new RichTextBoxEx();
            rboxex.Parent = this;
            rboxex.Top = 400;
            richTextBox2.AllowDrop = true;
        }
        class RichTextBoxEx : RichTextBox
        {
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                //Проверяем на нажатие Shift+Insert и Ctrl+V
                if ((keyData & (Keys.Shift | Keys.Insert)) ==
                (Keys.Shift | Keys.Insert)
                || ((keyData & (Keys.Control | Keys.V)) ==
                (Keys.Control | Keys.V)))
                return true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void richTextBox2_DragEnter(object sender,
            System.Windows.Forms.DragEventArgs e)
        {
            if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text))
                ((DragEventArgs)e).Effect = DragDropEffects.Move;
            else
                ((DragEventArgs)e).Effect = DragDropEffects.None;
        }
        private void richTextBox2_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.LoadFile((String)e.Data.GetData("Text"),
            System.Windows.Forms.RichTextBoxStreamType.RichText);
        }

        private void butFormatRTF_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус на richTextBox
            richTextBox1.Focus();
            // Устанавливаем цвет для выделенного текста
            richTextBox1.SelectionColor = Color.Red;
            // Устанавливаем шрифт
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Bold);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус
            dateTimePicker1.Focus();
            // Посылаем команду
            SendKeys.Send("{F4}");
        }

        private void butGetRTF_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Rtf;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void richTextBox2_LinkClicked(object sender,
            LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(60, 255, 192, 192);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rusproject.narod.ru/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "На нашем сайте вы найдете дополнительную информацию";
            linkLabel1.LinkArea = new LinkArea(3, 11);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Вертикальная прокрутка: " +
            IsVertScrollPresent(richTextBox1).ToString() +
               Environment.NewLine + "Горизонтальная прокрутка: " +
            IsHorScrollPresent(richTextBox1).ToString();
        }
        [DllImport("User32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        const int GWL_STYLE = -16;
        const int WS_HSCROLL = 0x00100000;
        const int WS_VSCROLL = 0x00200000;
        // Проверка на наличие вертикальной прокрутки
        bool IsVertScrollPresent(Control control)
        {
            int style = GetWindowLong(control.Handle, GWL_STYLE);
            return (style & WS_VSCROLL) > 0;
        }
        // Проверка на наличие горизонтальной прокрутки
        bool IsHorScrollPresent(Control control)
        {
            int style = GetWindowLong(control.Handle, GWL_STYLE);
            return (style & WS_HSCROLL) > 0;
        }
    }
}
