using E_commerceBLL.Services;
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
    public partial class Favourite : Form
    {
        public readonly int _userId;
        FavoriteServices _service;
        public Favourite(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _service = new FavoriteServices();
        }

        private void Favourite_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetFavorites(_userId);
            dataGridView1.Columns["ProductId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(_userId);
            categories.Show();
            this.Hide();
        }
        int id;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            txt_Name.Text = dataGridView1.SelectedRows[0].Cells["productName"].Value.ToString();
            txt_price.Text = dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _service.Remove(id,_userId);
            MessageBox.Show("Favorite Removed Successfully");
            dataGridView1.DataSource = _service.GetFavorites(_userId);
            dataGridView1.Columns["ProductId"].Visible = false;
        }
    }
}
