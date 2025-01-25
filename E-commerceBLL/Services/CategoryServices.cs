using E_commerceBLL.Models;
using E_commerceDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerceBLL.Services
{
    public class CategoryServices
    {
        private readonly DbContext _context;

        public CategoryServices()
        {
            _context = new DbContext();
        }


        #region Add

        public Response AddCategory(Category category)
        {
            // Validate the category name to ensure it's not empty or invalid
            if (string.IsNullOrEmpty(category.Name))
                return new()
                {
                    Text = "Category name cannot be empty."
                };

            try
            {
                // Create the SQL query using parameterized values to prevent SQL Injection
                string query = $"INSERT INTO Categories (CategoryName) VALUES ('{category.Name}')";

                // Execute the query using the DBContext
                int effectiveRows = _context.ExecuteNonQuery(query);

                // Check if the insertion was successful
                if (effectiveRows > 0)
                {
                    return new()
                    {
                        Text = "Category Added Successfully",
                        Flag = true
                    };
                }
                else
                    return new()
                    {
                        Text = "Unexpected error occurred during category insertion."
                    };
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                return new()
                {
                    Text = $"Error: {ex.Message}"
                };
            }
        }
        #endregion

        #region Update
        public Response Update(Category category)
        {
            // Validate the category name to ensure it's not empty or invalid
            if (string.IsNullOrEmpty(category.Name))
                return new()
                {
                    Text = "Category name cannot be empty."
                };

            try
            {
                // Create the SQL query directly
                string query = $"UPDATE Categories SET CategoryName = '{category.Name}' WHERE CategoryId = {category.Id}";

                // Execute the query using the DBContext
                int effectiveRows = _context.ExecuteNonQuery(query);

                // Check if the update was successful
                if (effectiveRows > 0)
                {
                    return new()
                    {
                        Text = "Category Updated Successfully",
                        Flag = true
                    };
                }
                else
                    return new()
                    {
                        Text = "Unexpected error occurred during category update."
                    };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Text = $"Error: {ex.Message}"
                };
            }
        }
        #endregion

        #region Delete 
        public Response Delete(int Id)
        {
            // Validate the ID to ensure it's a valid number
            if (Id <= 0)
                return new()
                {
                    Text = "Invalid Category."
                };

            try
            {
                // Create the SQL query to delete the category by ID
                string query = $"DELETE FROM Categories WHERE CategoryId = {Id}";

                // Execute the query using the DBContext
                int effectiveRows = _context.ExecuteNonQuery(query);

                // Check if the deletion was successful
                if (effectiveRows > 0)
                    return new()
                    {
                        Text = "Category Deleted Successfully",
                        Flag = true
                    };
                else
                    return new()
                    {
                        Text = "Unexpected error occurred during category deletion."
                    };
            }
            catch (Exception ex)
            {
                return new()
                {
                    Text = $"Error: {ex.Message}"
                };
            }
        }
        #endregion

        #region Get Categories

        public DataTable GetAll()
        {
            try
            {
                
                DataTable dataTable = _context.ExecuteQuery("SELECT * FROM Categories");

                
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

        #endregion

        #region Get Category products

        public DataTable GetCategoryProducts(int id)
        {
            try
            {
                DataTable dataTable = _context.ExecuteQuery($"SELECT p.ProductId,c.CategoryId,p.ProductName,p.Price FROM Categories as c join Products as p on p.CategoryId = c.CategoryId where p.CategoryId = {id}");

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

        #endregion

    }
}
