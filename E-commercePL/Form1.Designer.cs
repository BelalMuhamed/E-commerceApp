namespace E_commercePL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            colorDialog1 = new ColorDialog();
            email = new Guna.UI2.WinForms.Guna2TextBox();
            password = new Guna.UI2.WinForms.Guna2TextBox();
            btnlogin = new Guna.UI2.WinForms.Guna2Button();
            btnRegister = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // email
            // 
            email.AutoCompleteMode = AutoCompleteMode.Suggest;
            email.BackColor = Color.Transparent;
            email.BorderColor = Color.Transparent;
            email.BorderThickness = 0;
            customizableEdges1.BottomLeft = false;
            email.CustomizableEdges = customizableEdges1;
            email.DefaultText = "";
            email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            email.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Font = new Font("Segoe UI", 14F);
            email.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            email.Location = new Point(262, 258);
            email.Margin = new Padding(5, 6, 5, 6);
            email.Name = "email";
            email.PasswordChar = '\0';
            email.PlaceholderText = "E-mail";
            email.SelectedText = "";
            customizableEdges2.BottomLeft = false;
            customizableEdges2.BottomRight = false;
            customizableEdges2.TopLeft = false;
            customizableEdges2.TopRight = false;
            email.ShadowDecoration.CustomizableEdges = customizableEdges2;
            email.Size = new Size(360, 63);
            email.TabIndex = 0;
            // 
            // password
            // 
            password.AutoCompleteMode = AutoCompleteMode.Suggest;
            password.BackColor = Color.Transparent;
            password.BorderColor = Color.Transparent;
            password.BorderThickness = 0;
            customizableEdges3.BottomLeft = false;
            password.CustomizableEdges = customizableEdges3;
            password.DefaultText = "";
            password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Font = new Font("Segoe UI", 14F);
            password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            password.Location = new Point(262, 370);
            password.Margin = new Padding(5, 6, 5, 6);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.SelectedText = "";
            customizableEdges4.BottomLeft = false;
            customizableEdges4.BottomRight = false;
            customizableEdges4.TopLeft = false;
            customizableEdges4.TopRight = false;
            password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            password.Size = new Size(360, 63);
            password.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Transparent;
            btnlogin.BorderRadius = 12;
            btnlogin.CustomizableEdges = customizableEdges5;
            btnlogin.DisabledState.BorderColor = Color.DarkGray;
            btnlogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnlogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlogin.FillColor = Color.DarkGray;
            btnlogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnlogin.ForeColor = Color.SteelBlue;
            btnlogin.HoverState.BorderColor = Color.Black;
            btnlogin.HoverState.CustomBorderColor = Color.Black;
            btnlogin.HoverState.FillColor = Color.Black;
            btnlogin.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnlogin.HoverState.ForeColor = Color.White;
            btnlogin.Location = new Point(262, 490);
            btnlogin.Name = "btnlogin";
            btnlogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnlogin.Size = new Size(155, 45);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login";
            btnlogin.Click += btnlogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BorderRadius = 12;
            btnRegister.CustomizableEdges = customizableEdges7;
            btnRegister.DisabledState.BorderColor = Color.DarkGray;
            btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRegister.FillColor = Color.DarkGray;
            btnRegister.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegister.ForeColor = Color.SteelBlue;
            btnRegister.HoverState.BorderColor = Color.Black;
            btnRegister.HoverState.CustomBorderColor = Color.Black;
            btnRegister.HoverState.FillColor = Color.Black;
            btnRegister.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRegister.HoverState.ForeColor = Color.White;
            btnRegister.Location = new Point(467, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRegister.Size = new Size(155, 45);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._3ac5e1c374f04535bdd0df23;
            ClientSize = new Size(866, 751);
            Controls.Add(btnRegister);
            Controls.Add(btnlogin);
            Controls.Add(password);
            Controls.Add(email);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
    }
}
