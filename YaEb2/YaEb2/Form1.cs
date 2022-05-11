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

namespace YaEb2
{
    public partial class Form1 : Form
    {
        const string strTextForButton = "Тестовая строкаааааааааааааа";
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Width = 110;
            btn.Height = 50;
            btn.Left = 130;
            btn.Top = 10;
            btn.Location = new Point(479,396); 
            btn.Text = "Я новая кнопка";
            btn.Visible = true;
            this.Controls.Add(btn);
            //
            button9.Text = strTextForButton;
            using (Graphics graphics = button9.CreateGraphics())

                button6.Width = (int)graphics.MeasureString(strTextForButton,
                Font).Width;
            this.Text = button1.Width.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки
            Rectangle smallRectangle = button1.ClientRectangle;

            // уменьшим размеры прямоугольника
            smallRectangle.Inflate(-3, -3);
            // создадим эллипс, используя полученные размеры
            gp.AddEllipse(smallRectangle);
            button1.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки
            g.DrawEllipse(new Pen(Color.Gray, 2),
            button1.Left + 1,
            button1.Top + 1,
            button1.Width - 3,
            button1.Height - 3);
            // освобождаем ресурсы
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = listBox1.CreateGraphics();
            float maxWidth = 0f;
            float height = 0f;
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                float w = g.MeasureString(listBox1.Items[i].ToString(),
                listBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
                height += listBox1.GetItemHeight(i);
            }
            g.Dispose();
            listBox1.Width = (int)(maxWidth + 8 + ((height > listBox1.Height - 4) ?
             16 : 0)); // 16 - ширина прокрутки
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Выводим кнопку button2 на передний край
            this.Controls.SetChildIndex(button9, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            const int MAX_LENGTH = 5;
            if (textBox1.Text.Length == MAX_LENGTH)
                // переводим фокус на следующий элемент управления
                SelectNextControl(textBox1, true, true, false, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                // Работаем только с текстовыми полями
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "Народные советы";
            }
        }
        private void IterateControls(Control ctrl)
        {
            // Работаем только с текстовыми полями
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "Народные советы";
            }
            // Проходим через элементы рекурсивно,
            // чтобы не пропустить элементы, которые находятся в контейнерах
            foreach (Control ctrlChild in ctrl.Controls)
            {
                IterateControls(ctrlChild);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Шаг 1
            TextBox tb = new TextBox();
            // Шаг 2
            tb.Location = new Point(627,231);
            tb.Size = new Size(100, 20);
            tb.Text = "Я был создан во время выполнения программы";
            // Шаг 3
            this.Controls.Add(tb);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                // Работаем только с текстовыми полями
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "Народные советы";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
