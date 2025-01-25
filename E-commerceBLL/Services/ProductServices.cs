using E_commerceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceBLL.Services
{
    public class ProductServices
    {
        private readonly DbContext _context;

        public ProductServices() => _context = new DbContext();

        public DataTable GetAll()
        {
            try
            {
                DataTable dataTable = _context.ExecuteQuery("SELECT * FROM Products");

                if (dataTable.Rows.Count > 0)
                {
                    return dataTable;
                }
                else
                {
                    return new DataTable();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
        public int ADD(string name , string price , int categoryid)
        {
            string command = $"insert into Products (ProductName,Price,CategoryId) values('{name}',{price},{categoryid})";
            return _context.ExecuteNonQuery(command);
        }
        public int Update(string name , string price , int categoryid , int productname)
        {
            string com = $"Update Products set ProductName='{name}' , Price = {price} , CategoryId ={categoryid} where ProductId ={productname}";
            return _context.ExecuteNonQuery(com);
        }
        public int Deleted(int productname)
        {
            string com = $"delete from Products  where ProductId ={productname}";
            return _context.ExecuteNonQuery(com);
        }

    }
}
