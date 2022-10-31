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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        public string Id = "";
        public Watch Watch;
        public Game()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new Connect().SqlDelEditAdd($@"DELETE FROM [dbo].[Game]
                             WHERE Id = {Id}");
            Watch.Grid_Loaded(sender, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EditGame edit = new EditGame();
            edit.Name.Text = Name.Content.ToString();
            edit.Cost.Text = Cost.Content.ToString();
            edit.Id = Id;
            edit.Watch = Watch;
            edit.ShowDialog();
        }
    }
}
