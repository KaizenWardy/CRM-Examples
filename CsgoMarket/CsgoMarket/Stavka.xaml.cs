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

namespace CsgoMarket
{
    /// <summary>
    /// Логика взаимодействия для Stavka.xaml
    /// </summary>
    public partial class Stavka : UserControl
    {
        public Stavka()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Skind_stavka skind_Stavka = new Skind_stavka();
                Skins.Children.Add(skind_Stavka);
            }
        }

        private void Scroll_skins_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
                Scroll_skins.LineRight();
            else
                Scroll_skins.LineLeft();
        }
    }
}
