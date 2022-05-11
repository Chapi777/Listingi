using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaEb2
{
    public partial class Form3 : Form
    {
        class TextBoxEx : TextBox
        {
            const int WM_PASTE = 0x0302;
                protected override void WndProc(ref Message m)
            {
                //Запрещаем обрабатывать WM_PASTE
                if (m.Msg == WM_PASTE)
                    return;
                base.WndProc(ref m);
            }
        }
        public Form3()
        {
            InitializeComponent();
            InitializeComponent();
            TextBoxEx txtNotPaste = new TextBoxEx();
            txtNotPaste.Parent = this;
            txtNotPaste.Multiline = true;
            txtNotPaste.Height = 60;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strWeekDay = { "Понедельник", "Вторник", "Среда" };
            txtLinesCount.Multiline = true;
            txtLinesCount.Lines = strWeekDay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Используем escape-последовательности для переноса текста
            // на новую строку
            txtLinesCount.Text = "Раз\r\nДва\r\nТри";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Используем свойство NewLine для переноса строк
            txtLinesCount.Text = "Месяцы года:" + Environment.NewLine + "Декабрь" +
             Environment.NewLine + "Январь...";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Все вводимые символы переводятся в верхний регистр
            this.textBox1.CharacterCasing =
             System.Windows.Forms.CharacterCasing.Upper;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
            else
                base.OnKeyPress(e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtLinesCount.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = "0123456789+-,";
            if (!Char.IsControl(e.KeyChar))
                if (pattern.IndexOf(e.KeyChar.ToString()) < 0)
                    e.Handled = true;
        }
    }
}
