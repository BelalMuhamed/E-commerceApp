using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_commerceBLL.Services;

namespace E_commercePL
{
    public partial class Registeration : Form
    {
        UserServices userServices;
        public Registeration()
        {
            InitializeComponent();
            userServices = new UserServices();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            numericUpDown_age.Value = 0;
            txt_password.Text = "";
            txt_confirm_password.Text = "";
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            int rowAffected =  userServices.Add(txt_name.Text, txt_password.Text,txt_email.Text , (int)numericUpDown_age.Value, txt_address.Text );
            if (rowAffected > 0)
            {
                MessageBox.Show("Registeration Successfully");
            }   
           
        }
    }
}
