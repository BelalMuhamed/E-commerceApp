using E_commerceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceBLL.Services
{
    public class LoginServices
    {
        DbContext _dbContext;
        public LoginServices()
        {
            _dbContext = new DbContext();
        }
        public bool CheckUserExist(string email , string password)
        {
            return _dbContext.DoesUserExist(email, password);
        }
        public int UserOradmin(string email, string password)
        {
            return _dbContext.AdminOrUser(email, password);
        }

    }
}
