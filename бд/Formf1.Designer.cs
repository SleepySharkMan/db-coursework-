namespace бд
{
    partial class Formf1
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
            getTableButton = new Button();
            dataGridView = new DataGridView();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // getTableButton
            // 
            getTableButton.Location = new Point(347, 108);
            getTableButton.Name = "getTableButton";
            getTableButton.Size = new Size(92, 27);
            getTableButton.TabIndex = 9;
            getTableButton.Text = "Получить";
            getTableButton.UseVisualStyleBackColor = true;
            getTableButton.Click += getTableButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.Location = new Point(14, 159);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(428, 225);
            dataGridView.TabIndex = 10;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(14, 17);
            loginLabel.Margin = new Padding(4, 0, 4, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(44, 15);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(148, 14);
            loginTextBox.Margin = new Padding(4, 3, 4, 3);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(291, 23);
            loginTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(14, 47);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(148, 43);
            passwordTextBox.Margin = new Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(291, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(14, 77);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 15);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Электронная почта:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(148, 74);
            emailTextBox.Margin = new Padding(4, 3, 4, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(291, 23);
            emailTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(14, 108);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(110, 108);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 7;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(206, 108);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Formf1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 396);
            Controls.Add(getTableButton);
            Controls.Add(dataGridView);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Formf1";
            Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox loginTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button getTableButton;
        private DataGridView dataGridView;
    }

}