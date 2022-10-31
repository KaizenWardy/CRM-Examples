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

namespace wardyEx
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

        public MainWindow mainWindow;

        private void ToEditbutt_Click(object sender, RoutedEventArgs e)
        {
            EditPage editPage = new EditPage();
            editPage.EditId.Content = Idlabel.Content;
            editPage.EditFName.Text = FirstNamelabel.Content.ToString();
            editPage.EditLName.Text = LastNamelabel.Content.ToString();
            editPage.EditMName.Text = MidleNamelabel.Content.ToString();
            editPage.EditDate.Text = BirthDatalabel.Content.ToString();
            editPage.EditMail.Text = EmailLabel.Content.ToString();
            editPage.EditPhone.Text = Phonelabel.Content.ToString();
            editPage.comboBox.SelectedIndex = Male.Content.ToString() == "мужской" ? 0 : 1;
            editPage.image.Source = image.Source;
            editPage.mainWindow = mainWindow;
            editPage.ShowDialog();
        }

        private void del_butt_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"
                    Data Source = tcp:Unity;
                    Initial Catalog = wardy;
                    user ID = 201;
                    Password = 201;"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"
                        DELETE FROM [dbo].[Client]
                        WHERE ID = {Idlabel.Content}", connection);
                command.ExecuteNonQuery();

                mainWindow.LoadData();
            }
        }
    }
}
