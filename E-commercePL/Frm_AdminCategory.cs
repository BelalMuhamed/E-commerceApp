using E_commerceBLL.Models;
using E_commerceBLL.Services;
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
    public partial class Frm_AdminCategory : Form
    {
        private readonly CategoryServices _services;
        public Frm_AdminCategory()
        {
            InitializeComponent();
            _services = new CategoryServices();
        }
        private void RefreshCategoryGrid()
        {
            // Update the data source for the DataGridView
            dgv_categories.DataSource = _services.GetCategories();

            // Hide the 'CategoryId' column if it exists
            if (dgv_categories.Columns.Contains("CategoryId"))
            {
                dgv_categories.Columns["CategoryId"].Visible = false;
            }
        }

        private void Frm_AdminCategory_Load(object sender, EventArgs e)
        {
            RefreshCategoryGrid();

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            // Ensure an ID is selected before proceeding
            if (id <= 0)
            {
                MessageBox.Show("Please select a valid category to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the delete operation with the user
            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                // Call the Delete method and get the response
                Response response = _services.Delete(id);

                // Provide feedback to the user
                MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                    response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                // Refresh the DataGridView
                RefreshCategoryGrid();
                txt_Name.Text = "";
            }
        }


        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            // Validate that the user has entered a name
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a Category object from the user input
            Category category = new Category
            {
                Name = txt_Name.Text.Trim()
            };

            // Call the AddCategory method and get the response
            Response response = _services.AddCategory(category);

            // Provide feedback to the user
            MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            // Refresh the DataGridView to reflect updated categories
            RefreshCategoryGrid();
            txt_Name.Text = "";
        }


        int id;
        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_categories.SelectedRows[0].Cells["CategoryId"].Value;
            txt_Name.Text = dgv_categories.SelectedRows[0].Cells["CategoryName"].Value.ToString();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            // Validate that the user has entered a name
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a Category object from the user input
            Category category = new Category
            {
                Id = id, // Ensure 'id' is properly initialized elsewhere
                Name = txt_Name.Text.Trim()
            };

            // Call the Update method and get the response
            Response response = _services.Update(category);

            // Provide feedback to the user
            MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            RefreshCategoryGrid();
            txt_Name.Text = "";
        }

        
    }
}
