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

namespace wardyEx
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Window
    {
        public MainWindow mainWindow;
        public string Id;
        public EditPage()
        {
            InitializeComponent();
        }

        private void Cancerbutt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Savebutt_Click(object sender, RoutedEventArgs e)
        {
            if (EditId.Content.ToString() == "")
            {
                new Connect().SqlEditAddDel($@"
                        UPDATE [dbo].[Client]
                        SET [FirstName] = '{EditFName.Text}'
                        ,[LastName] ='{EditLName.Text}'
                        ,[Patronymic] = '{EditMName.Text}'
                        ,[Birthday] ='{EditDate.Text}'
                        ,[Email] ='{EditMail.Text}'
                        ,[Phone] ='{EditPhone.Text}'
                        ,[GenderCode] ='{comboBox.SelectedIndex + 1}'
                        WHERE ID = '{EditId.Content}'");
            }
            else
            {
                new Connect().SqlEditAddDel($@"
                        INSERT INTO [dbo].[Client]
                                   ([FirstName]
                                   ,[LastName]
                                   ,[Patronymic]
                                   ,[Birthday]
                                   ,[RegistrationDate]
                                   ,[Email]
                                   ,[Phone]
                                   ,[GenderCode])
                             VALUES (
                                '{EditFName.Text}',
                                '{EditLName.Text}',
                                '{EditMName.Text}',
                                '{EditDate.Text}',
                                '{DateTime.Now.ToShortDateString()}',
                                '{EditMail.Text}',
                                '{EditPhone.Text}',
                                {comboBox.SelectedIndex + 1})");
            }
            mainWindow.LoadData();
            this.Close();
        }
    }
}