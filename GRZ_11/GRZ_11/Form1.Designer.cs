
namespace GRZ_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCreateShortcut = new System.Windows.Forms.Button();
            this.butGetPrinters = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butSetDefaultPrinter = new System.Windows.Forms.Button();
            this.butNetworkDrives = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCreateShortcut
            // 
            this.butCreateShortcut.Location = new System.Drawing.Point(12, 12);
            this.butCreateShortcut.Name = "butCreateShortcut";
            this.butCreateShortcut.Size = new System.Drawing.Size(109, 52);
            this.butCreateShortcut.TabIndex = 0;
            this.butCreateShortcut.Text = "Создание ярлыка";
            this.butCreateShortcut.UseVisualStyleBackColor = true;
            this.butCreateShortcut.Click += new System.EventHandler(this.butCreateShortcut_Click);
            // 
            // butGetPrinters
            // 
            this.butGetPrinters.Location = new System.Drawing.Point(127, 12);
            this.butGetPrinters.Name = "butGetPrinters";
            this.butGetPrinters.Size = new System.Drawing.Size(121, 52);
            this.butGetPrinters.TabIndex = 1;
            this.butGetPrinters.Text = "Получение списка установленных принтеров";
            this.butGetPrinters.UseVisualStyleBackColor = true;
            this.butGetPrinters.Click += new System.EventHandler(this.butGetPrinters_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 160);
            this.listBox1.TabIndex = 2;
            // 
            // butSetDefaultPrinter
            // 
            this.butSetDefaultPrinter.Location = new System.Drawing.Point(254, 12);
            this.butSetDefaultPrinter.Name = "butSetDefaultPrinter";
            this.butSetDefaultPrinter.Size = new System.Drawing.Size(121, 52);
            this.butSetDefaultPrinter.TabIndex = 3;
            this.butSetDefaultPrinter.Text = "Установка принтера по умолчанию";
            this.butSetDefaultPrinter.UseVisualStyleBackColor = true;
            this.butSetDefaultPrinter.Click += new System.EventHandler(this.butSetDefaultPrinter_Click);
            // 
            // butNetworkDrives
            // 
            this.butNetworkDrives.Location = new System.Drawing.Point(127, 236);
            this.butNetworkDrives.Name = "butNetworkDrives";
            this.butNetworkDrives.Size = new System.Drawing.Size(121, 52);
            this.butNetworkDrives.TabIndex = 4;
            this.butNetworkDrives.Text = "Получение списка сетевых дисков";
            this.butNetworkDrives.UseVisualStyleBackColor = true;
            this.butNetworkDrives.Click += new System.EventHandler(this.butNetworkDrives_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(402, 299);
            this.Controls.Add(this.butNetworkDrives);
            this.Controls.Add(this.butSetDefaultPrinter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butGetPrinters);
            this.Controls.Add(this.butCreateShortcut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCreateShortcut;
        private System.Windows.Forms.Button butGetPrinters;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butSetDefaultPrinter;
        private System.Windows.Forms.Button butNetworkDrives;
    }
}

