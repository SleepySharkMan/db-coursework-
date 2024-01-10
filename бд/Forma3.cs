using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace бд
{
    public partial class Forma3 : Form
    {
        private string connectionString;

        public Forma3(string connectionString1)
        {
            InitializeComponent();
            this.connectionString = connectionString1;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(txtYear.Text, out year))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand("Получить_количество_поданных_резюме_по_месяцам_за_определенный_год", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Год", year);


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
            else
            {
                MessageBox.Show("Неверный формат года.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
