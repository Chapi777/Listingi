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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace YAEB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(3, insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string bookTitle = textBox1.Text;
            // Удаляем подстроку с третьей позиции
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string bookTitle = textBox1.Text;
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string str1 = "око";
            string str2 = "Царь-колокол";
            int i = str2.IndexOf(str1);
            // Проверяем, входит ли строка око в слово Царь-колокол
            if (i >= 0) listBox1.Items.Add(str1 + " входит в строку " + str2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox2.Text += Environment.NewLine + all.ToString(); // получим 5
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            // Unicode-код для торговой марки
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            // Создаем строку из 5 звездочек
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            string AutoName;
            AutoName = "BMW";
            textBox1.Text = String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }

        private void butColorName_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Blue;
            // Получим имя выбранного цвета
            textBox1.Text = (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }

        private void SayHello_Click(object sender, EventArgs e)
        {
            string name;
            name = null;
            textBox1.Text = name;
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            listBox1.Items.Add(string.Concat("Hello, "));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Взять текст из текстового поля
            // Например, А роза упала на лапу Азора
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            listBox1.Items.Add(myString);
        }
        public static string ReverseString(string str)
        {
            // Проверка на непустоту строки.
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }// Создадим объект StringBuilder с нужной длиной.
            StringBuilder revStr = new StringBuilder(str.Length);
            // Перебираем в цикле все символы
            // и присоединяем каждый символ к StringBuilder
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // Возвращаем перевернутую строку
            return revStr.ToString();
        }

        private void butReverseCS_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReverseString(textBox1.Text);
        }

        private void butDateTime_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            listBox1.Items.Add(today.Date.ToLongDateString());
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(System.Text.StringBuilder pszOut,string pszSrc,Int32 cchMax,Int32 dwFlags);
        private void button12_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            "c:/program files/My SuperProgram/skins/sample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "Старт")
            {
                timer1.Enabled = true;
                button13.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button13.Text = "Старт";
            }
        }
        public static int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "C#.Народные советы";

            this.Text = typingText.Substring(0, counter);
            counter++;
            if (counter > typingText.Length)
                counter = 0;
        }

        private void butScroll_Click_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        private string scrollText = "C#.Народные советы ";
        private void timer2_Tick(object sender, EventArgs e)
        {
            // Удаляем один символ слева и прибавляем его с правой стороны
            scrollText = scrollText.Substring(1,
            (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }
    }
}
