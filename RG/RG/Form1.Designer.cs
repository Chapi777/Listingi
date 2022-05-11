
namespace RG
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
            this.butExePath = new System.Windows.Forms.Button();
            this.butBaseDirectory = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.butRunNotepad2 = new System.Windows.Forms.Button();
            this.butCloseNotepad = new System.Windows.Forms.Button();
            this.Start1 = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.butProcCount = new System.Windows.Forms.Button();
            this.butProcCount2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butExePath
            // 
            this.butExePath.Location = new System.Drawing.Point(89, 72);
            this.butExePath.Name = "butExePath";
            this.butExePath.Size = new System.Drawing.Size(177, 39);
            this.butExePath.TabIndex = 0;
            this.butExePath.Text = "Полное имя файла";
            this.butExePath.UseVisualStyleBackColor = true;
            this.butExePath.Click += new System.EventHandler(this.butExePath_Click);
            // 
            // butBaseDirectory
            // 
            this.butBaseDirectory.Location = new System.Drawing.Point(89, 117);
            this.butBaseDirectory.Name = "butBaseDirectory";
            this.butBaseDirectory.Size = new System.Drawing.Size(177, 38);
            this.butBaseDirectory.TabIndex = 1;
            this.butBaseDirectory.Text = "Получение пути к папке";
            this.butBaseDirectory.UseVisualStyleBackColor = true;
            this.butBaseDirectory.Click += new System.EventHandler(this.butBaseDirectory_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(333, 72);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 38);
            this.Start.TabIndex = 2;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // butRunNotepad2
            // 
            this.butRunNotepad2.Location = new System.Drawing.Point(333, 117);
            this.butRunNotepad2.Name = "butRunNotepad2";
            this.butRunNotepad2.Size = new System.Drawing.Size(130, 38);
            this.butRunNotepad2.TabIndex = 3;
            this.butRunNotepad2.Text = "Блокнот";
            this.butRunNotepad2.UseVisualStyleBackColor = true;
            this.butRunNotepad2.Click += new System.EventHandler(this.butRunNotepad2_Click);
            // 
            // butCloseNotepad
            // 
            this.butCloseNotepad.Location = new System.Drawing.Point(530, 72);
            this.butCloseNotepad.Name = "butCloseNotepad";
            this.butCloseNotepad.Size = new System.Drawing.Size(75, 38);
            this.butCloseNotepad.TabIndex = 4;
            this.butCloseNotepad.Text = "Закрыть блокнот";
            this.butCloseNotepad.UseVisualStyleBackColor = true;
            this.butCloseNotepad.Click += new System.EventHandler(this.butCloseNotepad_Click);
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(333, 28);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(130, 38);
            this.Start1.TabIndex = 5;
            this.Start1.Text = "Браузер";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(333, 161);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(130, 52);
            this.open.TabIndex = 6;
            this.open.Text = "Открытие файла в ассоциированном приложении";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // butProcCount
            // 
            this.butProcCount.Location = new System.Drawing.Point(487, 161);
            this.butProcCount.Name = "butProcCount";
            this.butProcCount.Size = new System.Drawing.Size(136, 52);
            this.butProcCount.TabIndex = 7;
            this.butProcCount.Text = "Получение числа процессоров в системе";
            this.butProcCount.UseVisualStyleBackColor = true;
            this.butProcCount.Click += new System.EventHandler(this.butProcCount_Click);
            // 
            // butProcCount2
            // 
            this.butProcCount2.Location = new System.Drawing.Point(487, 219);
            this.butProcCount2.Name = "butProcCount2";
            this.butProcCount2.Size = new System.Drawing.Size(136, 52);
            this.butProcCount2.TabIndex = 8;
            this.butProcCount2.Text = " Второй способ получения процессоров в системе ";
            this.butProcCount2.UseVisualStyleBackColor = true;
            this.butProcCount2.Click += new System.EventHandler(this.butProcCount2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butProcCount2);
            this.Controls.Add(this.butProcCount);
            this.Controls.Add(this.open);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.butCloseNotepad);
            this.Controls.Add(this.butRunNotepad2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.butBaseDirectory);
            this.Controls.Add(this.butExePath);
            this.Name = "Form1";
            this.Text = "S_Prog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butExePath;
        private System.Windows.Forms.Button butBaseDirectory;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button butRunNotepad2;
        private System.Windows.Forms.Button butCloseNotepad;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button butProcCount;
        private System.Windows.Forms.Button butProcCount2;
    }
}

