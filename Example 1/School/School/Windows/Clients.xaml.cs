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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
        }
        private void Load_data(string birthday)
        {
            Clients_panel.Children.Clear();

                using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = School; Integrated Security = true;"))
                {
                    //Открываем подключение
                    connection.Open();
                    SqlCommand command = new SqlCommand($@"SELECT * FROM[School].[dbo].[Client] 
            where (LastName like '{Search.Text}%' 
                    or FirstName like '{Search.Text}%' 
                    or Patronymic like '{Search.Text}%' 
                    or Email like '{Search.Text}%' 
                    or Phone like '{Search.Text}%') 
                    and GenderCode like '{(Gender.SelectedIndex == 0 ? "" : Gender.SelectedIndex.ToString())}%' {birthday}", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Controls.Client client = new Controls.Client();
                            client.Id.Content = reader[0];
                            client.Fio.Content = $"{reader[2]} {reader[1]} {reader[3]}";
                            client.Birthday.Content = reader[4];
                            client.Reg_data.Content = reader[5];
                            client.Email.Content = reader[6];
                            client.Phone.Content = reader[7];
                            client.Gender.Content = reader[8].ToString() == "1" ? "м" : "ж";
                            //client.Image.Source = new BitmapImage(new Uri(@"C:\Users\admin\Desktop\School\School\bin\Debug\" + reader[9].ToString()));
                            Clients_panel.Children.Add(client);
                        }
                    }
                }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Load_data("");
        }

        private void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Load_data("");
        }

        private void Gender_Loaded(object sender, RoutedEventArgs e)
        {
            Gender.SelectedIndex = 0;
        }

        private void Birthday_mouth_Click(object sender, RoutedEventArgs e)
        {
            Load_data($"and Birthday like '%-{(DateTime.Now.Month.ToString().Length==1 ? "0"+DateTime.Now.Month : DateTime.Now.Month.ToString())}-%'");
        }

        private void Add_client_Click(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            edit.ShowDialog();
        }
    }
}
