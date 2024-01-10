using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace бд
{
    public partial class Formf1 : Form
    {
        string connectionString;

        public Formf1(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string login = string.IsNullOrEmpty(loginTextBox.Text) ? null : loginTextBox.Text;
            string password = string.IsNullOrEmpty(passwordTextBox.Text) ? null : passwordTextBox.Text;
            string email = string.IsNullOrEmpty(emailTextBox.Text) ? null : emailTextBox.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert_Личный_кабинет", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string login = string.IsNullOrEmpty(loginTextBox.Text) ? null : loginTextBox.Text;
            string password = string.IsNullOrEmpty(passwordTextBox.Text) ? null : passwordTextBox.Text;
            string email = string.IsNullOrEmpty(emailTextBox.Text) ? null : emailTextBox.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update_Личный_кабинет", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        command.Parameters.AddWithValue("@password", password);
                    }
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        command.Parameters.AddWithValue("@email", email);
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно обновлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string login = string.IsNullOrEmpty(loginTextBox.Text) ? null : loginTextBox.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete_Личный_кабинет", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@login", login);
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
                    SqlCommand command = new SqlCommand("Select_Личный_кабинет", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении данных: " + ex.Message);
                }
            }
        }
    }
}
