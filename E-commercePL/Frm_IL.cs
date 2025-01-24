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
    public partial class Frm_IL : Form
    {
        public Frm_IL()
        {
            InitializeComponent();
        }
            
        

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            Frm_AdminCategory frm_AdminCategory = new Frm_AdminCategory();
            this.Hide();
            frm_AdminCategory.Show();
        }
    }
}
