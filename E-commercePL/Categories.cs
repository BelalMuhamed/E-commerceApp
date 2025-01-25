using E_commerceBLL.Models;
using E_commerceBLL.Services;
using E_commerceDAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commercePL
{
    public partial class Categories : Form
    {
        private readonly CategoryServices categoryServices;
        private readonly FavoriteServices favoriteServices;
        public readonly int _userId;
        ProductServices productServices;
        public Categories(int userId)
        {
            InitializeComponent();
            this.categoryServices = new CategoryServices();
            this.favoriteServices = new FavoriteServices();
            this._userId = userId;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = categoryServices.GetAll();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            DataTable dt = new DataTable();
        }
        int id;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            txt_Name.Text = dataGridView1.SelectedRows[0].Cells["ProductName"].Value.ToString();
            txt_price.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["CategoryId"]);

            dataGridView1.DataSource = categoryServices.GetCategoryProducts(categoryId);
            dataGridView1.Columns["ProductId"].Visible = false;
            dataGridView1.Columns["CategoryId"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (_userId <= 0 || id <= 0)
                {
                    MessageBox.Show("Invalid user or product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new Favorite object
                Favorite favorite = new()
                {
                    UserId = _userId,
                    ProductId = id
                };

                // Attempt to add the favorite
                int result = favoriteServices.AddToFavorite(favorite);

                // Check the result
                if (result > 0)
                {
                    MessageBox.Show("Product added to favorites successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add product to favorites. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional, for debugging purposes)
                Console.WriteLine($"An error occurred: {ex.Message}");

                // Display a user-friendly error message
                MessageBox.Show("An unexpected error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Favourite favourite = new Favourite(_userId);
            favourite.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
