using E_commerceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

      
    }
}
