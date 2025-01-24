using E_commerceBLL.Services;

namespace E_commercePL
{
    public partial class LoginForm : Form
    {
        LoginServices Login;
        UserServices User;
        public LoginForm()
        {
            InitializeComponent();
            Login = new LoginServices();
            User = new UserServices();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string useremail = email.Text;
            string userpassword = password.Text;
            int userrole;
            bool IsAuth = Login.CheckUserExist(useremail, userpassword);
            if (IsAuth)
            {
                userrole = Login.UserOradmin(useremail, userpassword);
                int UserId = User.GetUserId(useremail, userpassword);
                if (userrole == 1)
                {
                    MessageBox.Show("user is admin");
                    email.Clear();
                    password.Clear();
                }
                else
                {
                    MessageBox.Show("user is user");
                    Categories categories = new Categories(UserId);
                    categories.Show();
                    this.Hide();
                    categories.FormClosed += (s, args) => this.Show();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registeration registeration = new Registeration();
            this.Hide();
            registeration.Show();
            registeration.FormClosed += (s,args) =>this.Show();
        }
    }
}
