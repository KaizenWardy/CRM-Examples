using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Watch.xaml
    /// </summary>
    public partial class Watch : Window
    {
        public Watch()
        {
            InitializeComponent();
        }



        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Games.Children.Clear();
            SqlDataReader reader = new Connect().SqlSelect($@"SELECT        Game.Name, Genre.Name AS Expr1, Publisher.Name AS Expr2, Game.Cost, Game.Id
                                    FROM            Game INNER JOIN
                         Genre ON Game.GenreId = Genre.Id INNER JOIN
                         Publisher ON Game.PublisherId = Publisher.Id where Game.Name like '%{SearchBox.Text}%'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Game game = new Game(); //создаем пользов эл управления
                    game.Name.Content = reader[0].ToString(); // Заполняем LAbel
                    game.Genre.Content = reader[1].ToString();
                    game.Publisher.Content = reader[2].ToString();
                    game.Cost.Content = reader[3].ToString() + " р";
                    game.Id = reader[4].ToString(); // Запоминаем его Id
                    game.Watch = this;
                    Games.Children.Add(game); // Добавляем на экран
                }
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Grid_Loaded(sender, e);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EditGame editGame = new EditGame();
            editGame.Watch = this;
            editGame.ShowDialog();
        }
    }
}
