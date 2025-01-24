using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerceDAL;

namespace E_commerceBLL.Services
{
    public class UserServices
    {
        DbContext _dbContext;
        LoginServices loginServices;
        public UserServices()
        {
            _dbContext = new DbContext();
            loginServices = new LoginServices();
        }
        public int Add(string name ,string password ,string email , int age ,string address)
        {
            string command = $"insert into Users (UserName,Password,Email,Age,Address) values('{name}',{password},'{email}',{age},'{address}')";
            return _dbContext.ExecuteNonQuery(command);
        }

        public int GetUserId(string email, string password)
        {
            try
            {
                string query = $"SELECT UserId FROM Users WHERE Email = '{email}' AND Password = '{password}'";

                var dt = _dbContext.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["UserId"]);
                }


                return -1;
            }
            catch (Exception ex)
            {
                // Log the exception and rethrow or handle appropriately
                throw new Exception("An error occurred while fetching the user ID.", ex);
            }
        }

    }
}
