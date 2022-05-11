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
using System.Threading;

namespace RG
{
    public partial class Form1 : Form
    {
        protected Process[] procs;

        public Form1()
        {
            InitializeComponent();
        }

        private void butExePath_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;
            // Выводим полный путь к файлу
            MessageBox.Show(appPath);
        }

        private void butBaseDirectory_Click(object sender, EventArgs e)
        {
            // Выводим путь к папке, откуда запущено приложение
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
            // Другой способ
            MessageBox.Show(Application.StartupPath);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Запускаем Блокнот с файлом test.txt
            Process.Start("notepad.exe");
            
        }

        private void butRunNotepad2_Click(object sender, EventArgs e)
        {
            // Устанавливаем информацию
            ProcessStartInfo start_info = new ProcessStartInfo
            (@"C:\windows\system32\notepad.exe");
            start_info.UseShellExecute = false;
            start_info.CreateNoWindow = true;
            // создаем новый процесс
            Process proc = new Process();
            proc.StartInfo = start_info;
            // Запускаем процесс
            proc.Start();
            // Ждем, пока Блокнот запущен
            proc.WaitForExit();
            MessageBox.Show("Код завершения: " + proc.ExitCode, "Завершение " +
            "Код", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butCloseNotepad_Click(object sender, EventArgs e)
        {
            procs = Process.GetProcessesByName("Notepad");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
                MessageBox.Show("Всего : " + i.ToString());
            }
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void open_Click(object sender, EventArgs e)
        {
            // Получим путь к нужной папке
            string sysFolder =
            Environment.GetFolderPath(Environment.SpecialFolder.System);
            // Создадим новую структуру ProcessStartInfo
            ProcessStartInfo pInfo = new ProcessStartInfo();
            // Установим полный путь к имени файла
            pInfo.FileName = sysFolder + @"\yandex.exe";
            // По умолчанию UseShellExecute равно true.
            // В данном случае указываем это поле явно для иллюстрации.
            pInfo.UseShellExecute = true;
            Process p = Process.Start(pInfo);
        }

        private void butProcCount_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();
            int processorCount = 0;
            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }
            MessageBox.Show(processorCount.ToString());
        }

        private void butProcCount2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Число процессоров: {0}",
                Environment.ProcessorCount.ToString()));
        }
    }
}
