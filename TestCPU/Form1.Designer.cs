namespace TestCPU
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ident = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.sysName = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numLogCore = new System.Windows.Forms.TextBox();
            this.curSpeed = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.Cache1 = new System.Windows.Forms.TextBox();
            this.Cache2 = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.nextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(122, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(337, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество ядер";
            // 
            // numCore
            // 
            this.numCore.Location = new System.Drawing.Point(122, 46);
            this.numCore.Name = "numCore";
            this.numCore.Size = new System.Drawing.Size(337, 20);
            this.numCore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Идентификатор";
            // 
            // ident
            // 
            this.ident.Location = new System.Drawing.Point(122, 74);
            this.ident.Name = "ident";
            this.ident.Size = new System.Drawing.Size(337, 20);
            this.ident.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max скорость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Системное имя";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(122, 101);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(337, 20);
            this.speed.TabIndex = 8;
            // 
            // sysName
            // 
            this.sysName.Location = new System.Drawing.Point(122, 128);
            this.sysName.Name = "sysName";
            this.sysName.Size = new System.Drawing.Size(337, 20);
            this.sysName.TabIndex = 9;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(21, 429);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 10;
            this.start.Text = "Запуск";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Число логических процессоров";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Текущая скорость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Разрядность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Размер кэша1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Размер кэша2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Нагрузка";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 369);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Производитель";
            // 
            // numLogCore
            // 
            this.numLogCore.Location = new System.Drawing.Point(196, 160);
            this.numLogCore.Name = "numLogCore";
            this.numLogCore.Size = new System.Drawing.Size(263, 20);
            this.numLogCore.TabIndex = 20;
            // 
            // curSpeed
            // 
            this.curSpeed.Location = new System.Drawing.Point(122, 194);
            this.curSpeed.Name = "curSpeed";
            this.curSpeed.Size = new System.Drawing.Size(337, 20);
            this.curSpeed.TabIndex = 21;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(122, 233);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(337, 20);
            this.data.TabIndex = 22;
            // 
            // Cache1
            // 
            this.Cache1.Location = new System.Drawing.Point(122, 273);
            this.Cache1.Name = "Cache1";
            this.Cache1.Size = new System.Drawing.Size(337, 20);
            this.Cache1.TabIndex = 23;
            // 
            // Cache2
            // 
            this.Cache2.Location = new System.Drawing.Point(122, 303);
            this.Cache2.Name = "Cache2";
            this.Cache2.Size = new System.Drawing.Size(337, 20);
            this.Cache2.TabIndex = 25;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(122, 337);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(337, 20);
            this.Load.TabIndex = 27;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(122, 366);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(337, 20);
            this.Manufacturer.TabIndex = 28;
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(291, 429);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(182, 23);
            this.nextForm.TabIndex = 29;
            this.nextForm.Text = "Переход к следующей форме";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 464);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Cache2);
            this.Controls.Add(this.Cache1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.curSpeed);
            this.Controls.Add(this.numLogCore);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sysName);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ident);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Свойства ЦП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numCore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox sysName;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox numLogCore;
        private System.Windows.Forms.TextBox curSpeed;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox Cache1;
        private System.Windows.Forms.TextBox Cache2;
        private System.Windows.Forms.TextBox Load;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Button nextForm;
    }
}

