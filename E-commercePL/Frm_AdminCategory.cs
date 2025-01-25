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
            
            dgv_categories.DataSource = _services.GetAll();

           
            if (dgv_categories.Columns.Contains("CategoryId"))
            {
                dgv_categories.Columns["CategoryId"].Visible = false;
            }
        }

        private void Frm_AdminCategory_Load(object sender, EventArgs e)
        {
            RefreshCategoryGrid();
            btn_update.Visible = false;
            btn_Add.Visible = true;
            btn_delete.Visible = false;
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            
            if (id <= 0)
            {
                MessageBox.Show("Please select a valid category to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Delete Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                
                Response response = _services.Delete(id);

                
                MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                    response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                
                RefreshCategoryGrid();
                txt_Name.Text = "";
                btn_update.Visible = false;
                btn_Add.Visible = true;
                btn_delete.Visible = false;
            }
        }


        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Category category = new Category
            {
                Name = txt_Name.Text.Trim()
            };

            
            Response response = _services.AddCategory(category);

            
            MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            
            RefreshCategoryGrid();
            txt_Name.Text = "";
        }


        int id;
        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_categories.SelectedRows[0].Cells["CategoryId"].Value;
            txt_Name.Text = dgv_categories.SelectedRows[0].Cells["CategoryName"].Value.ToString();
            btn_update.Visible = true;
            btn_Add.Visible=false;
            btn_delete.Visible = true;
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Category category = new Category
            {
                Id = id, 
                Name = txt_Name.Text.Trim()
            };

           
            Response response = _services.Update(category);

            
            MessageBox.Show(response.Text, "Operation Result", MessageBoxButtons.OK,
                response.Flag ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            RefreshCategoryGrid();
            txt_Name.Text = "";
            btn_update.Visible = false;
            btn_Add.Visible = true;
            btn_delete.Visible = false;
        }

        
    }
}
