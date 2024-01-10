using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace бд
{
    public partial class Forma2 : Form
    {
        private string connectionString;

        public Forma2(string connectionString)
        {
            InitializeComponent();

            this.connectionString = connectionString;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("Подсчет_количества_покупок_платной_услуги_для_резюме", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parameterStartDate = new SqlParameter("@НачалаПериода", SqlDbType.Date);
                    parameterStartDate.Value = dtpStartDate.Value;
                    command.Parameters.Add(parameterStartDate);

                    SqlParameter parameterEndDate = new SqlParameter("@КонецПериода", SqlDbType.Date);
                    parameterEndDate.Value = dtpEndDate.Value;
                    command.Parameters.Add(parameterEndDate);

                    SqlParameter parameterServiceName = new SqlParameter("@Название_услуги", SqlDbType.NVarChar, 100);
                    parameterServiceName.Value = tbServiceName.Text;
                    command.Parameters.Add(parameterServiceName);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvResults.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
