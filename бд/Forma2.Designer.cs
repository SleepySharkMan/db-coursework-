namespace бд
{
    partial class Forma2
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
            btnExecute = new Button();
            dgvResults = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbServiceName = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(275, 110);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(88, 28);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(7, 143);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(356, 188);
            dgvResults.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 84);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Дата начала:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата конца:";
            // 
            // tbServiceName
            // 
            tbServiceName.Location = new Point(112, 114);
            tbServiceName.Name = "tbServiceName";
            tbServiceName.Size = new Size(132, 23);
            tbServiceName.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(99, 81);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(88, 23);
            dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(275, 81);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(88, 23);
            dtpEndDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 117);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Название услуги";
            // 
            // label4
            // 
            label4.Location = new Point(7, 9);
            label4.Name = "label4";
            label4.Size = new Size(352, 53);
            label4.TabIndex = 8;
            label4.Text = "Введите дату начала, дату конца, название платной услуги для резюме, чтобы узнать сколько раз её купили в каждый день из указанного периода";
            // 
            // Forma2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 348);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(tbServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResults);
            Controls.Add(btnExecute);
            Name = "Forma2";
            Text = "2-ой аналитический запрос";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnExecute;
        private DataGridView dgvResults;
        private Label label1;
        private Label label2;
        private TextBox tbServiceName;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label4;
    }
}
