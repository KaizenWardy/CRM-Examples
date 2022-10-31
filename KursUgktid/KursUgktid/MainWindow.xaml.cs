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
namespace KursUgktid
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //Integrated Security = true;
            using (SqlConnection connection = new SqlConnection(@"Data Source = tcp: Unity-201;
                            Initial Catalog = Mannanov4; User ID = 201; Password = 201;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM[Mannanov4].[dbo].[Material]", connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    while (reader.Read())
                    {
                        Client client = new Client();
                        client.TypeTitle.Content = reader[1].ToString();
                        client.MinCount.Content = reader[5].ToString();
                        Materials.Children.Add(client);
                    }
            }
        }                
    }
}
