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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using School.Windows;

namespace School.Controls
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : UserControl
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Tag_panel_Loaded(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = localhost; Initial Catalog = School; Integrated Security = true;"))
            {
                //Открываем подключение
                connection.Open();
                SqlCommand command = new SqlCommand($@"SELECT        Tag.Title, Tag.Color
                        FROM            Tag INNER JOIN
                         TagOfClient ON Tag.ID = TagOfClient.TagID where TagOfClient.ClientID = {Id.Content}", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Label tag = new Label();
                        tag.Content = reader[0];
                        switch (reader[1].ToString().Trim())
                        {
                            case "Red":
                                tag.Foreground = Brushes.Red;
                                break;
                            case "Green":
                                tag.Foreground = Brushes.Green;
                                break;
                            case "Blue":
                                tag.Foreground = Brushes.Blue;
                                break;
                            default:
                                break;
                        }
                        Tag_panel.Children.Add(tag);

                    }
                }
            }
        }

        private void Edit_client_Click(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            string[] a = Fio.Content.ToString().Split();
            edit.LastName.Text = a[0];
            edit.FirstName.Text = a[1];
            edit.Patronymic.Text = a[2];
            edit.Email.Text = Email.Content.ToString();
            edit.Phone.Text = Phone.Content.ToString();
            edit.Birthday.SelectedDate = Convert.ToDateTime(Birthday.Content.ToString());
            edit.Id.Content = Id.Content;
            edit.Photo.Source = Image.Source;
            edit.Gender.SelectedIndex = Gender.Content.ToString() == "м" ? 0 : 1;
            edit.ShowDialog();
        }
    }
}
