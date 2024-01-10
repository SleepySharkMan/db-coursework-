namespace бд
{
    partial class Forma4
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
            btnExecute = new Button();
            lblResult = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgvResult = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(256, 102);
            btnExecute.Margin = new Padding(4, 3, 4, 3);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(88, 27);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Выполнить";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(14, 127);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(113, 73);
            dtpStart.Margin = new Padding(4, 3, 4, 3);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(137, 23);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(113, 102);
            dtpEnd.Margin = new Padding(4, 3, 4, 3);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(137, 23);
            dtpEnd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Дата начала:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата окончания:";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(14, 145);
            dgvResult.Margin = new Padding(4, 3, 4, 3);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(330, 173);
            dgvResult.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(330, 61);
            label3.TabIndex = 5;
            label3.Text = "Введите дату начала, дату конца, чтобы узнать сколько было получено денег за подписки в каждый день из указанного периода";
            // 
            // Forma4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 332);
            Controls.Add(label3);
            Controls.Add(dgvResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(lblResult);
            Controls.Add(btnExecute);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Forma4";
            Text = "4-ый аналитический запрос";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private Label lblResult;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label1;
        private Label label2;
        private DataGridView dgvResult;
        private Label label3;
    }
}
