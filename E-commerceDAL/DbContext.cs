using Microsoft.Data.SqlClient;
using System.Data;

namespace E_commerceDAL
{
    public class DbContext
    {
        SqlConnection con;
        public DbContext()
        {
            con = new SqlConnection("Server=khaledayman\\MSSQLSERVER01;Database=E-commerceWindowsFromApp;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DataTable ExecuteQuery(string CommandText)
        {
            SqlCommand SelectedCommand = new SqlCommand(CommandText, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = SelectedCommand;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        
        public int ExecuteNonQuery(string CommandText)
        {
            SqlCommand SelectedCommand = new SqlCommand(CommandText, con);
            con.Open();
            int RowAffected = SelectedCommand.ExecuteNonQuery();
            con.Close();
            return RowAffected;
        }
        public bool DoesUserExist(string email, string password)
        {
            string query = "SELECT COUNT(1) FROM Users WHERE Email = @useremail and Password=@userpass";


            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@useremail", email);
            command.Parameters.AddWithValue("@userpass", password);
            con.Open();
            int count = (int)command.ExecuteScalar();
            con.Close();
            return count > 0;


        }
        public int AdminOrUser(string email, string password)
        {
            string query = "SELECT RoleId FROM Users WHERE Email = @useremail and Password=@userpass";


            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@useremail", email);
            command.Parameters.AddWithValue("@userpass", password);
            con.Open();
            int roleid = (int)command.ExecuteScalar();
            con.Close();
            return roleid;


        }
    }
}
