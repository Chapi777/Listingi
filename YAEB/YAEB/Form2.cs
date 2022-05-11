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
using System.Diagnostics;

namespace YAEB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // Аналогичная проверка производительности для Now
            DateTime dt = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt)
                    {
                        /* do action */
                    }
                }
               listBox1.Items.Add(sw.ElapsedTicks.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            listBox1.Items.Add(mydate.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9); // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата
             // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2, FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }
        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }

        private void butDateDiffCS_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            int month = Convert.ToInt32(textBox2.Text);
            int day = Convert.ToInt32(textBox3.Text);
            string howdays = DaysDiff(DateTime.Today, new DateTime(year, month, day)).ToString();
            int dni = Convert.ToInt32(howdays);
            int goda = Convert.ToInt32(dni/365);
            listBox1.Items.Add("Со дня моего дня рождения прошло: " + goda+" года");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            listBox1.Items.Add(
             String.Format("{0} является високосным годом: {1}",
             DateTime.Now.Year, leapYear));

        }
        public static DateTime EasterDate(int year)
        {
            int Y = year;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int month = (h + L - 7 * m + 114) / 31;
            int day = ((h + L - 7 * m + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day);
            return dt;
        }

        private void butEaster_Click(object sender, EventArgs e)
        {
            // когда была католическая Пасха в 2022 году
            listBox1.Items.Add(EasterDate(2022).ToLongDateString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int parrots = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add(parrots.ToString("X8"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int myvalue = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add(Convert.ToString(myvalue, 2)); // возвратит 100 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int myValue = Convert.ToInt32(textBox4.Text);
            // Преобразуем в восьмеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 16));
        }

        private void butIsNumericVB_Click(object sender, EventArgs e)
        {
            // введите в текстовое поле любое число или слово
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
           listBox1.Items.Add("Является ли " + numstring + " числом: " + bResult1);
        }
        static bool IsNumeric(object Expression)
        {
            // Возвращаемое значение
            bool isNum;
            // Переменная, используемая в качестве параметра
            // в методе TryParse
            double retNum;
            // Метод TryParse конвертирует строку в заданный стиль
            // и локальный формат.
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Является ли " + textBox4.Text +
                             " числом: " + IsNumeric(textBox4.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            int month = Convert.ToInt32(textBox2.Text);
            int day = Convert.ToInt32(textBox3.Text);
            string howdays = DaysDiff(DateTime.Today,new DateTime(year, month, day)).ToString();
            listBox1.Items.Add("Со дня моего дня рождения прошло: " + howdays);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
