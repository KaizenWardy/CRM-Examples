using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WpfApp1
{
    internal class Connect
    {

        public SqlConnection Connection = new SqlConnection(@"Data Source = localhost\sqlexpress;
                Initial Catalog = Steam;
                Integrated Security = true;");
        public SqlDataReader SqlSelect(string Command)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int SqlDelEditAdd(string Command)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Connection);
            int a = cmd.ExecuteNonQuery();
            return a;
        }
       

    }
}
