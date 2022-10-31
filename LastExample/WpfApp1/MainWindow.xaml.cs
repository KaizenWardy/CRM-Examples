using System.Windows;
using System.Data.SqlClient;
namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            SqlDataReader reader =  new Connect().SqlSelect($@"SELECT  *
                        FROM [dbo].[User] 
                where Login = '{textBox.Text}' and Password = '{passwordBox.Password}'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if(reader[5].ToString() == "1")
                    {
                        Watch watch = new Watch();
                        watch.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

        }
    }
}
