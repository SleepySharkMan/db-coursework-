namespace бд
{
    partial class Formf3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            btnДобавить = new Button();
            btnУдалить = new Button();
            btnИзменить = new Button();
            btnОтобразить = new Button();
            txtЛогин = new TextBox();
            txtТипАккаунта = new TextBox();
            txtТипПользователя = new TextBox();
            txtСтоимость = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dTPДатаНачала = new DateTimePicker();
            dTPДатаОкончания = new DateTimePicker();
            txtИдентификатор = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Location = new Point(13, 137);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(905, 318);
            dataGridView.TabIndex = 0;
            // 
            // btnДобавить
            // 
            btnДобавить.Location = new Point(13, 104);
            btnДобавить.Margin = new Padding(4, 3, 4, 3);
            btnДобавить.Name = "btnДобавить";
            btnДобавить.Size = new Size(117, 27);
            btnДобавить.TabIndex = 1;
            btnДобавить.Text = "Добавить";
            btnДобавить.UseVisualStyleBackColor = true;
            btnДобавить.Click += btnДобавить_Click;
            // 
            // btnУдалить
            // 
            btnУдалить.Location = new Point(138, 104);
            btnУдалить.Margin = new Padding(4, 3, 4, 3);
            btnУдалить.Name = "btnУдалить";
            btnУдалить.Size = new Size(117, 27);
            btnУдалить.TabIndex = 2;
            btnУдалить.Text = "Удалить";
            btnУдалить.UseVisualStyleBackColor = true;
            btnУдалить.Click += btnУдалить_Click;
            // 
            // btnИзменить
            // 
            btnИзменить.Location = new Point(263, 104);
            btnИзменить.Margin = new Padding(4, 3, 4, 3);
            btnИзменить.Name = "btnИзменить";
            btnИзменить.Size = new Size(117, 27);
            btnИзменить.TabIndex = 3;
            btnИзменить.Text = "Изменить";
            btnИзменить.UseVisualStyleBackColor = true;
            btnИзменить.Click += btnИзменить_Click;
            // 
            // btnОтобразить
            // 
            btnОтобразить.Location = new Point(801, 104);
            btnОтобразить.Margin = new Padding(4, 3, 4, 3);
            btnОтобразить.Name = "btnОтобразить";
            btnОтобразить.Size = new Size(117, 27);
            btnОтобразить.TabIndex = 4;
            btnОтобразить.Text = "Получить";
            btnОтобразить.UseVisualStyleBackColor = true;
            btnОтобразить.Click += btnОтобразить_Click;
            // 
            // txtЛогин
            // 
            txtЛогин.Location = new Point(378, 6);
            txtЛогин.Margin = new Padding(4, 3, 4, 3);
            txtЛогин.Name = "txtЛогин";
            txtЛогин.Size = new Size(116, 23);
            txtЛогин.TabIndex = 5;
            // 
            // txtТипАккаунта
            // 
            txtТипАккаунта.Location = new Point(378, 35);
            txtТипАккаунта.Margin = new Padding(4, 3, 4, 3);
            txtТипАккаунта.Name = "txtТипАккаунта";
            txtТипАккаунта.Size = new Size(116, 23);
            txtТипАккаунта.TabIndex = 6;
            // 
            // txtТипПользователя
            // 
            txtТипПользователя.Location = new Point(378, 64);
            txtТипПользователя.Margin = new Padding(4, 3, 4, 3);
            txtТипПользователя.Name = "txtТипПользователя";
            txtТипПользователя.Size = new Size(116, 23);
            txtТипПользователя.TabIndex = 7;
            // 
            // txtСтоимость
            // 
            txtСтоимость.Location = new Point(651, 64);
            txtСтоимость.Margin = new Padding(4, 3, 4, 3);
            txtСтоимость.Name = "txtСтоимость";
            txtСтоимость.Size = new Size(116, 23);
            txtСтоимость.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 12;
            label2.Text = "Тип аккаунта:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 67);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 13;
            label3.Text = "Тип пользователя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 9);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 14;
            label4.Text = "Дата начала:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 38);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 15;
            label5.Text = "Дата окончания:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(537, 67);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 16;
            label6.Text = "Стоимость:";
            // 
            // dTPДатаНачала
            // 
            dTPДатаНачала.Location = new Point(651, 6);
            dTPДатаНачала.Name = "dTPДатаНачала";
            dTPДатаНачала.Size = new Size(116, 23);
            dTPДатаНачала.TabIndex = 17;
            // 
            // dTPДатаОкончания
            // 
            dTPДатаОкончания.Location = new Point(651, 35);
            dTPДатаОкончания.Name = "dTPДатаОкончания";
            dTPДатаОкончания.Size = new Size(116, 23);
            dTPДатаОкончания.TabIndex = 18;
            // 
            // txtИдентификатор
            // 
            txtИдентификатор.Location = new Point(25, 30);
            txtИдентификатор.Margin = new Padding(4, 3, 4, 3);
            txtИдентификатор.Name = "txtИдентификатор";
            txtИдентификатор.Size = new Size(230, 23);
            txtИдентификатор.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 9);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 20;
            label7.Text = "Идентификатор записи:";
            // 
            // Formf3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 472);
            Controls.Add(label7);
            Controls.Add(txtИдентификатор);
            Controls.Add(dTPДатаОкончания);
            Controls.Add(dTPДатаНачала);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtСтоимость);
            Controls.Add(txtТипПользователя);
            Controls.Add(txtТипАккаунта);
            Controls.Add(txtЛогин);
            Controls.Add(btnОтобразить);
            Controls.Add(btnИзменить);
            Controls.Add(btnУдалить);
            Controls.Add(btnДобавить);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Formf3";
            Text = "Личный кабинет Тип аккаунта Тип пользователя";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView;
        private Button btnДобавить;
        private Button btnУдалить;
        private Button btnИзменить;
        private Button btnОтобразить;
        private TextBox txtЛогин;
        private TextBox txtТипАккаунта;
        private TextBox txtТипПользователя;
        private TextBox txtСтоимость;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dTPДатаНачала;
        private DateTimePicker dTPДатаОкончания;
        private TextBox txtИдентификатор;
        private Label label7;
    }
}
