using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Windows.Forms;

namespace бд
{
    public partial class Formf2 : Form
    {
        string connectionString;

        public Formf2(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inn = string.IsNullOrEmpty(innTextBox.Text) ? null : innTextBox.Text;
                string name = string.IsNullOrEmpty(nameTextBox.Text) ? null : nameTextBox.Text;
                int industryId = 0;
                int.TryParse(industryIdTextBox.Text, out industryId);

                using (var connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert_Организация", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@inn", inn);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@industryId", industryId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string inn = string.IsNullOrEmpty(innTextBox.Text) ? null : innTextBox.Text;
            string name = string.IsNullOrEmpty(nameTextBox.Text) ? null : nameTextBox.Text;
            int industryId;
            int.TryParse(industryIdTextBox.Text, out industryId);

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update_Организация", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@inn", inn);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@industryId", industryId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно изменены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string inn = string.IsNullOrEmpty(innTextBox.Text) ? null : innTextBox.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete_Организация", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@inn", inn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении данных: " + ex.Message);
                }
            }
        }

        private void getTableButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select_Организация", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }
    }
}
