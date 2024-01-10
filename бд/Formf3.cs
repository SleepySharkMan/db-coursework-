using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace бд
{
    public partial class Formf3 : Form
    {
        private string connectionString;
        public Formf3(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void btnДобавить_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert_Личный_кабинет_Тип_аккаунта_Тип_пользователя", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Логин", string.IsNullOrEmpty(txtЛогин.Text) ? null : txtЛогин.Text);
                    command.Parameters.AddWithValue("@Тип_аккаунта", string.IsNullOrEmpty(txtТипАккаунта.Text) ? null : txtТипАккаунта.Text);
                    command.Parameters.AddWithValue("@Тип_пользователя", string.IsNullOrEmpty(txtТипПользователя.Text) ? null : txtТипПользователя.Text);
                    command.Parameters.AddWithValue("@Дата_начала", dTPДатаНачала.Value);
                    command.Parameters.AddWithValue("@Дата_окончания", dTPДатаОкончания.Value);
                    decimal стоимость;
                    decimal.TryParse(txtСтоимость.Text, out стоимость);
                    command.Parameters.AddWithValue("@Стоимость", стоимость);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void btnУдалить_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete_Личный_кабинет_Тип_аккаунта_Тип_пользователя", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Идентификатор_Личный_кабинет_Тип_аккаунта_Тип_пользователя", string.IsNullOrEmpty(txtИдентификатор.Text) ? null : txtИдентификатор.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно удалены");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении данных: " + ex.Message);
            }
        }

        private void btnИзменить_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update_Личный_кабинет_Тип_аккаунта_Тип_пользователя", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Идентификатор_Личный_кабинет_Тип_аккаунта_Тип_пользователя", string.IsNullOrEmpty(txtИдентификатор.Text) ? null : txtИдентификатор.Text);
                    command.Parameters.AddWithValue("@Логин", string.IsNullOrEmpty(txtЛогин.Text) ? null : txtЛогин.Text);
                    command.Parameters.AddWithValue("@Тип_аккаунта", string.IsNullOrEmpty(txtТипАккаунта.Text) ? null : txtТипАккаунта.Text);
                    command.Parameters.AddWithValue("@Тип_пользователя", string.IsNullOrEmpty(txtТипПользователя.Text) ? null : txtТипПользователя.Text);
                    command.Parameters.AddWithValue("@Дата_начала", dTPДатаНачала.Value);
                    command.Parameters.AddWithValue("@Дата_окончания", dTPДатаОкончания.Value);
                    decimal стоимость;
                    decimal.TryParse(txtСтоимость.Text, out стоимость);
                    command.Parameters.AddWithValue("@Стоимость", стоимость);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно изменены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
                }
            }
        }

        private void btnОтобразить_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("Select_Личный_кабинет_Тип_аккаунта_Тип_пользователя", connection);

                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
