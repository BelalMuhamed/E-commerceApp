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
        public UserServices()
        {
            _dbContext = new DbContext();
        }
        public int Add(string name ,string password ,string email , int age ,string address)
        {
            string command = $"insert into Users (UserName,Password,Email,Age,Address) values('{name}',{password},'{email}',{age},'{address}')";
            return _dbContext.ExecuteNonQuery(command);
        }
    }
}
