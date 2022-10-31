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
using System.Data.SqlClient;//<-------------------
namespace WpfApp1
{

    public partial class EditGame : Window
    {
        public Watch Watch;
        public string Id = "";
        public EditGame()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Id == "")
                new Connect().SqlDelEditAdd($@"INSERT INTO [dbo].[Game]
           ([Name]
           ,[Year]
           ,[GenreId]
           ,[SystemParametrs]
           ,[PublisherId]
           ,[Cost]
           ,[Description])
     VALUES
           ('{Name.Text}'
           ,'{Year.Text}'
           ,{Genre.SelectedIndex + 1}
           ,'{SystemParams.Text}'
           ,{Publicher.SelectedIndex + 1}
           ,{Cost.Text}
           ,'{Description.Text}')");
            else
                new Connect().SqlDelEditAdd($@"UPDATE [dbo].[Game]
                           SET [Name] = '{Name.Text}'
                              ,[Year] = '{Year.Text}'
                              ,[GenreId] = {Genre.SelectedIndex + 1}
                              ,[SystemParametrs] = '{SystemParams.Text}'
                              ,[PublisherId] = {Publicher.SelectedIndex + 1}
                              ,[Cost] = {Cost.Text}
                              ,[Description] = '{Description.Text}'
                         WHERE Id = {Id}");
            Watch.Grid_Loaded(sender, e);
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlDataReader reader = new Connect().SqlSelect("Select Name from [dbo].[Genre]");
            while (reader.Read())
            {
                Genre.Items.Add(reader[0].ToString());
            }
            reader = new Connect().SqlSelect("Select Name from [dbo].[Publisher]");
            while (reader.Read())
            {
                Publicher.Items.Add(reader[0].ToString());
            }
        }
    }
}
