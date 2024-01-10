using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace бд
{
    public partial class Forma4 : Form
    {
        private string connectionString;

        public Forma4(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime началоПериода = dtpStart.Value;
                DateTime конецПериода = dtpEnd.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("Расчет_заработанных_денег_на_подписках", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@Начало_периода", SqlDbType.Date).Value = началоПериода;
                    command.Parameters.Add("@Конец_периода", SqlDbType.Date).Value = конецПериода;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvResult.DataSource = table;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

