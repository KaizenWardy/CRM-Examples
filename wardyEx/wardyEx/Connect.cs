using System.Data.SqlClient;

namespace wardyEx
{
    internal class Connect
    {
        public SqlConnection Connection = new SqlConnection(@"DataSource = localhost\sqlexpress;
                Initial Catalog = Steam;
                Integrated Secutity = true;");
        public SqlDataReader SqlSelect(string Command)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int SqlEditAddDel(string Command)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Connection);
            int a = cmd.ExecuteNonQuery();
            return a;
        }
    }
}
