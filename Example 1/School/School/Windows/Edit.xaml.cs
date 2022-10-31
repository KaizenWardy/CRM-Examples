using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace School.Windows
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = 308-7\SQLEXPRESS; Initial Catalog = School; Integrated Security = true;"))
            {
                //Открываем подключение
                connection.Open();
                SqlCommand command = new SqlCommand($@"UPDATE [dbo].[Client]
                       SET [FirstName] = '{FirstName.Text}'
                          ,[LastName] = '{LastName.Text}'
                          ,[Patronymic] = '{Patronymic.Text}'
                          ,[Birthday] = '{Birthday.SelectedDate}'
                          ,[Email] = '{Email.Text}'
                          ,[Phone] = '{Phone.Text}'
                          ,[GenderCode] = '{Gender.SelectedIndex+1}'
                     WHERE ID = {Id.Content}", connection);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Сохранено");
                }
                catch 
                {
                    MessageBox.Show("Не корректные данные!");
                }
            }
        }
    }
}
