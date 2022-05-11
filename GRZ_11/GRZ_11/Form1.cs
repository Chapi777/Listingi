using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Collections;

namespace GRZ_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCreateShortcut_Click(object sender, EventArgs e)
        {
            // Создадим ярлык на Рабочем столе
            object shortDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            // Путь к ярлыку
            string shortcutAddress =
            (string)shell.SpecialFolders.Item(ref shortDesktop) +
            @"\Блокнотик.lnk";
            // Создаем объект ярлыка
            IWshShortcut shortcut =
            (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            // Задаем свойства для ярлыка
            // Описание ярлыка в всплывающей подсказке
            shortcut.Description = "Ярлык для текстового редактора";
            // Горячая клавиша
            shortcut.Hotkey = "Ctrl+Shift+N";
            // Путь к самой программе Блокнот
            shortcut.TargetPath =
            Environment.GetFolderPath(Environment.SpecialFolder.System) +
            @"\notepad.exe";
            // Все готово. Можно создавать ярлык
            shortcut.Save();
        }

        private void butGetPrinters_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();
            // Получим список всех принтеров
            foreach (IEnumerable printer in network.EnumPrinterConnections())
            {
                listBox1.Items.Add(printer);
            }
        }

        private void butSetDefaultPrinter_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();
            // Получим список принтеров
            IWshCollection Printers = network.EnumPrinterConnections();
            if (Printers.Count() > 0)
            {
                // Выбираем индекс устанавливаемого принтера
                object index = (object)"1";
                // Устанавливаем выбранный принтер как принтер по умолчанию
                network.SetDefaultPrinter((string)Printers.Item(ref index));
            }
        }

        private void butNetworkDrives_Click(object sender, EventArgs e)
        {
            WshNetwork network = new WshNetwork();
            // Перебираем все сетевые диски
            foreach (IEnumerable driver in network.EnumNetworkDrives())
            {
                listBox1.Items.Add(driver.ToString());
            }
        }
    }
}
