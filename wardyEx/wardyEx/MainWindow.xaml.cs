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
using System.IO;

namespace wardyEx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clients_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }


        public void LoadData()
        {
            Clients.Children.Clear();
            using (SqlConnection connection = new SqlConnection(@"
                    Data Source = tcp:Unity;
                    Initial Catalog = wardy;
                    user ID = 201;
                    Password = 201;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"
                                                    SELECT Client.ID,
                                                    Client.FirstName,
                                                    Client.LastName,
                                                    Client.Patronymic,
                                                    Client.Birthday,
                                                    Client.Email,
                                                    Client.Phone,
                                                    Client.RegistrationDate,
                                                    Client.PhotoPath,
                                                    Gender.Name,
                                                    (select count(id) from [wardy].[dbo].[Client])

                                                    FROM Client Inner JOIN
                                                    Gender on Client.GenderCode = Gender.Code " + searchtmp + sort + sort2, connection);
                SqlDataReader reader = command.ExecuteReader();
                string allcoint = "";
                while(reader.Read())
                {
                    Client client = new Client();
                    client.Idlabel.Content = reader[0].ToString();
                    client.FirstNamelabel.Content = reader[1].ToString();
                    client.LastNamelabel.Content = reader[2].ToString();
                    client.MidleNamelabel.Content = reader[3].ToString();
                    client.BirthDatalabel.Content = reader[4].ToString().Replace("0:00:00", "");
                    client.EmailLabel.Content = reader[5].ToString();
                    client.Phonelabel.Content = reader[6].ToString();
                    client.RegistrationDate.Content = reader[7].ToString().Replace("0:00:00", "");
                    if (reader[8].ToString().Replace("..", ".") == "")
                        client.image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\9.jpg"));
                    else
                        client.image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\" + reader[8].ToString().Replace("..", ".")));

                    client.Male.Content = reader[9].ToString();
                    client.mainWindow = this;
                    allcoint = reader[10].ToString();
                    Clients.Children.Add(client);
                }

                counterer.Content = Clients.Children.Count.ToString() + " Из " + allcoint;
            }
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            EditPage editPage = new EditPage();
            editPage.mainWindow = this; 
            editPage.ShowDialog();
        }

        public string searchtmp;
        private void searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchtmp = $@"where FirstName Like '{searchbox.Text}'
                        or lastName Like '%{searchbox.Text}%'
                        or Patronymic Like '%{searchbox.Text}%'
                        or Email Like '%{searchbox.Text}%'
                        or Phone Like '%{searchbox.Text}%'";
            LoadData();
        }

        string sort = "";
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex != 0)
                sort = " and GenderCode = " + comboBox.SelectedIndex.ToString();
            else
                sort = "";
            LoadData();
        }

        string sort2;
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                string mouth = DateTime.Now.Month.ToString();
                if (mouth.Length < 2)
                    mouth = "0" + mouth;
                sort2 = $" and Birthday like '%-{mouth}-%'";
            }
            else
                sort2 = "";
            LoadData();
        }
    }
}
