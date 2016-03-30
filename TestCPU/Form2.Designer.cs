namespace TestCPU
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sha1Res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tempProc = new System.Windows.Forms.TextBox();
            this.curTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(33, 279);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 0;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHA1";
            // 
            // sha1Res
            // 
            this.sha1Res.Location = new System.Drawing.Point(87, 23);
            this.sha1Res.Name = "sha1Res";
            this.sha1Res.Size = new System.Drawing.Size(331, 20);
            this.sha1Res.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текущая температура процессора";
            // 
            // tempProc
            // 
            this.tempProc.Location = new System.Drawing.Point(236, 198);
            this.tempProc.Name = "tempProc";
            this.tempProc.Size = new System.Drawing.Size(100, 20);
            this.tempProc.TabIndex = 4;
            // 
            // curTemp
            // 
            this.curTemp.Location = new System.Drawing.Point(236, 231);
            this.curTemp.Name = "curTemp";
            this.curTemp.Size = new System.Drawing.Size(100, 20);
            this.curTemp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Допустимая температура процессора";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.curTemp);
            this.Controls.Add(this.tempProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sha1Res);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.Name = "Form2";
            this.Text = "Тесты-процессы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sha1Res;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempProc;
        private System.Windows.Forms.TextBox curTemp;
        private System.Windows.Forms.Label label3;
    }
}