using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAEB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            // Уникальный идентификатор с дефисами
            MessageBox.Show(newGuid.ToString());
            // Уникальный идентификатор без дефисов
            listBox1.Items.Add(newGuid.ToString("N"));
        }

        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };
        private void button2_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // Перечисляем все значения перечисления
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получаем массив строк, содержащих все цвета в системе
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            // Выводим все имена в список
            listBox1.Items.AddRange(allcolors);
            // Другой вариант
            foreach (string s in allcolors)
            {
            listBox1.Items.Add(s);
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor), listBox1.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
