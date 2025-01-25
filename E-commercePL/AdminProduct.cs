using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_commerceBLL.Models;
using E_commerceBLL.Services;
namespace E_commercePL 
{
    public partial class AdminProduct : Form
    {
        ProductServices services;
        CategoryServices categoryServices;
        public AdminProduct()
        {
            InitializeComponent();
            services = new ProductServices();
            categoryServices = new CategoryServices();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            DataTable dt = services.GetAll();
            dgv_adminProduct.DataSource = dt;
            DataTable dt2 = categoryServices.GetAll();
            cb_category.DataSource = dt2;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowAffected = services.Update(txt_name.Text, txt_price.Text, (int)cb_category.SelectedValue, id);
            if (rowAffected > 0)
            {
                MessageBox.Show("Updated Successfully");
                DataTable dt = services.GetAll();
                dgv_adminProduct.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowAfected = services.ADD(txt_name.Text, txt_price.Text, (int)cb_category.SelectedValue);
            if (rowAfected > 0)
            {
                MessageBox.Show("Added Successfully");
                DataTable dt = services.GetAll();
                dgv_adminProduct.DataSource = dt;
            }
        }
        int id;
        private void dgv_adminProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_adminProduct.SelectedRows[0].Cells["ProductId"].Value;
            txt_name.Text = dgv_adminProduct.SelectedRows[0].Cells["ProductName"].Value.ToString();
            txt_price.Text = dgv_adminProduct.SelectedRows[0].Cells["Price"].Value.ToString();
            cb_category.SelectedValue = dgv_adminProduct.SelectedRows[0].Cells["CategoryId"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowAffected = services.Deleted(id);
            if (rowAffected > 0)
            {
                MessageBox.Show("Deleted Successfully");
                DataTable dt = services.GetAll();
                dgv_adminProduct.DataSource = dt;
            }
        }
    }
}
