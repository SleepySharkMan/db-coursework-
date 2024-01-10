namespace бд
{
    partial class Forma3
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnExecute;
        private DataGridView dgvResult;
        private Label lblDescription;
        private Label lblYear;
        private TextBox txtYear;

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
            dgvResult = new DataGridView();
            lblDescription = new Label();
            lblYear = new Label();
            txtYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(274, 54);
            btnExecute.Margin = new Padding(4, 3, 4, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(91, 27);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(15, 87);
            dgvResult.Margin = new Padding(4, 3, 4, 3);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(350, 173);
            dgvResult.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(14, 10);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(349, 41);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Введите год, чтобы получить количество поданных резюме по месяцам в заданном году";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(16, 60);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 3;
            lblYear.Text = "Год:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(57, 57);
            txtYear.Margin = new Padding(4, 3, 4, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(116, 23);
            txtYear.TabIndex = 4;
            // 
            // Forma3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 275);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lblDescription);
            Controls.Add(dgvResult);
            Controls.Add(btnExecute);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Forma3";
            Text = "3-ий аналитический запрос";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
