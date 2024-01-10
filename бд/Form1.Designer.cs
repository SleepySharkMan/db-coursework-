namespace бд
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(440, 23);
            button1.TabIndex = 0;
            button1.Tag = "f1";
            button1.Text = "1-ая форма на добавление/модификацию/удаление данных";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClick;
            // 
            // button2
            // 
            button2.Location = new Point(12, 41);
            button2.Name = "button2";
            button2.Size = new Size(440, 23);
            button2.TabIndex = 1;
            button2.Tag = "f2";
            button2.Text = "2-ая форма на добавление/модификацию/удаление данных";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // button3
            // 
            button3.Location = new Point(12, 99);
            button3.Name = "button3";
            button3.Size = new Size(440, 23);
            button3.TabIndex = 2;
            button3.Tag = "a1";
            button3.Text = "1-ый аналитический запрос";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClick;
            // 
            // button4
            // 
            button4.Location = new Point(12, 128);
            button4.Name = "button4";
            button4.Size = new Size(440, 23);
            button4.TabIndex = 3;
            button4.Tag = "a2";
            button4.Text = "2-ой аналитический запрос";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Location = new Point(12, 157);
            button5.Name = "button5";
            button5.Size = new Size(440, 23);
            button5.TabIndex = 4;
            button5.Tag = "a3";
            button5.Text = "3-ий аналитический запрос";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Location = new Point(12, 70);
            button6.Name = "button6";
            button6.Size = new Size(440, 23);
            button6.TabIndex = 5;
            button6.Tag = "f3";
            button6.Text = "3-я форма на добавление/модификацию/удаление данных";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.Location = new Point(12, 186);
            button7.Name = "button7";
            button7.Size = new Size(440, 23);
            button7.TabIndex = 6;
            button7.Tag = "a4";
            button7.Text = "4-ый аналитический запрос";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Location = new Point(12, 215);
            button8.Name = "button8";
            button8.Size = new Size(440, 23);
            button8.TabIndex = 7;
            button8.Tag = "a5";
            button8.Text = "5-ый аналитический запрос";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 247);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Работа с базой данных";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}