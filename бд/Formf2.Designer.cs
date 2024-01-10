namespace бд
{
    partial class Formf2
    {
        private System.ComponentModel.IContainer components = null;
        private Label innLabel;
        private TextBox innTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label industryIdLabel;
        private TextBox industryIdTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button getTableButton;
        private DataGridView dataGridView;

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
            innLabel = new Label();
            innTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            industryIdLabel = new Label();
            industryIdTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            getTableButton = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new Point(14, 17);
            innLabel.Margin = new Padding(4, 0, 4, 0);
            innLabel.Name = "innLabel";
            innLabel.Size = new Size(37, 15);
            innLabel.TabIndex = 0;
            innLabel.Text = "ИНН:";
            // 
            // innTextBox
            // 
            innTextBox.Location = new Point(172, 15);
            innTextBox.Margin = new Padding(4, 3, 4, 3);
            innTextBox.Name = "innTextBox";
            innTextBox.Size = new Size(243, 23);
            innTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(14, 47);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(172, 44);
            nameTextBox.Margin = new Padding(4, 3, 4, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(243, 23);
            nameTextBox.TabIndex = 3;
            // 
            // industryIdLabel
            // 
            industryIdLabel.AutoSize = true;
            industryIdLabel.Location = new Point(14, 77);
            industryIdLabel.Margin = new Padding(4, 0, 4, 0);
            industryIdLabel.Name = "industryIdLabel";
            industryIdLabel.Size = new Size(134, 15);
            industryIdLabel.TabIndex = 4;
            industryIdLabel.Text = "ИД отрасли компании:";
            // 
            // industryIdTextBox
            // 
            industryIdTextBox.Location = new Point(172, 74);
            industryIdTextBox.Margin = new Padding(4, 3, 4, 3);
            industryIdTextBox.Name = "industryIdTextBox";
            industryIdTextBox.Size = new Size(243, 23);
            industryIdTextBox.TabIndex = 5;
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
            // getTableButton
            // 
            getTableButton.Location = new Point(334, 108);
            getTableButton.Margin = new Padding(4, 3, 4, 3);
            getTableButton.Name = "getTableButton";
            getTableButton.Size = new Size(107, 27);
            getTableButton.TabIndex = 9;
            getTableButton.Text = "Получить";
            getTableButton.UseVisualStyleBackColor = true;
            getTableButton.Click += getTableButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.Location = new Point(18, 153);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(422, 173);
            dataGridView.TabIndex = 10;
            // 
            // Formf2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 340);
            Controls.Add(dataGridView);
            Controls.Add(getTableButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(industryIdTextBox);
            Controls.Add(industryIdLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(innTextBox);
            Controls.Add(innLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Formf2";
            Text = "Организация";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}