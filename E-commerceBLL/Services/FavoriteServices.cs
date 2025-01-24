using Azure;
using E_commerceBLL.Models;
using E_commerceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceBLL.Services
{
    public class FavoriteServices
    {
        private readonly DbContext _context;

        public FavoriteServices() => _context = new DbContext();


        public int AddToFavorite(Favorite favorite)
        {
            string command = $"insert into Favourities values({favorite.UserId},{favorite.ProductId})";
            return _context.ExecuteNonQuery(command);
        }

        public DataTable GetFavorites(int userId)
        {
            return _context.ExecuteQuery($"select p.ProductId,p.ProductName,p.Price from Favourities f join Products p on f.ProductId = p.ProductId where f.UserId = {userId}");
        }

        public int Remove(int Productid,int UserId)
        {
            return _context.ExecuteNonQuery($"Delete from Favourities where ProductId = {Productid} and UserId = {UserId}");
        }
    }
}
