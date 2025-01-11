using E_commerceBLL.Services;

namespace E_commercePL
{
    public partial class LoginForm : Form
    {
        LoginServices Login;
        public LoginForm()
        {
            InitializeComponent();
           Login = new LoginServices();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string useremail =email.Text;
            string userpassword = password.Text;
            int userrole;
            bool IsAuth = Login.CheckUserExist(useremail, userpassword);
            if (IsAuth) 
            {
                userrole=Login.UserOradmin(useremail,userpassword);
                if (userrole == 1)
                {
                    MessageBox.Show("user is admin");
                    email.Clear();
                    password.Clear();
                }
                else
                {
                    MessageBox.Show("user is user");
                    email.Clear();
                    password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter valid data");
                email.Clear();
                password.Clear();
            }

        }
    }
}
