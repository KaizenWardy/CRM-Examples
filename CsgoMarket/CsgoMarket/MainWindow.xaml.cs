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
using MaterialDesignThemes;
using System.Data.SQLite;
using MaterialDesignThemes.Wpf;

namespace CsgoMarket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dialog.IsOpen = true;
            dialog.Visibility = Visibility.Visible;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Button).BorderThickness = new Thickness(0,0,0,1);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Button).BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private string User_id { get; set; }

        private string path = AppDomain.CurrentDomain.BaseDirectory;
        private void Load_data()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Market.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand($@"SELECT Skin.Skin_name,Skin.Skin_rare,Skin.Skin_cost,Skin.Skin_image,Inventory.Skin_quality
  FROM Inventory inner join Skin on Skin.Skin_id = Inventory.Skin_id where User_id = {User_id}", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Skin skin = new Skin();
                        // skin.Skin_border.Background = Brushes.Black;
                        skin.Skin_name.Content = reader[0];
                        switch (reader[1].ToString())
                        {
                            case "Legendary":
                                skin.Skin_rar.Fill = Brushes.Orange;
                                break;
                            default:
                                break;
                        }

                        skin.Skin_image.Source = new BitmapImage(new Uri(path + reader[3]));
                        skin.Skin_second_name.Content = reader[4];
                        skin.Skin_price.Content = reader[2] +"$";
                        Skins_panel.Children.Add(skin);
                    }
                }
            }
        }
        private void WrapPanel_Loaded(object sender, RoutedEventArgs e)
        {
            


               


            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Koef koef = new Koef();
                koef.Border_koef.BorderBrush = new SolidColorBrush(Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
                Brush brush = koef.Border_koef.BorderBrush.Clone();
                brush.Opacity = 0.1;
                koef.Border_koef.Background = brush;
                koef.Text_koef.Content = random.Next(50).ToString() + "x";
                Koef_plane.Children.Add(koef);

                Stavka stavka = new Stavka();
                Stavka_panel.Children.Add(stavka);


                Message message = new Message();
                Message_panel.Children.Add(message);
                Scroll_message.ScrollToEnd();
            }
        }

        private void Log_but_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Market.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand($@"Select * from User 
                        where User_login = '{user_login.Text}'
                        and user_password = '{user_password.Password}'", connection);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User_id = reader[0].ToString();
                        User_name.Content = reader[3];
                        User_balane.Content = "Balance: " + reader[4].ToString() + "$";
                        User_photo.Fill = new ImageBrush(new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + reader[5].ToString())));
                    }
                    Load_data();
                    dialog.IsOpen = false;
                    dialog.Visibility = Visibility.Hidden;
                }
                else
                {
                    HintAssist.SetHelperText(user_password,"Мудила проверь пароль");
                }
            }
        }

        private void Cancel_but_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
