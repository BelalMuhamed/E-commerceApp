namespace E_commercePL
{
    partial class Frm_IL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_products = new Guna.UI2.WinForms.Guna2Button();
            btn_Categories = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.Transparent;
            btn_products.BorderRadius = 12;
            btn_products.CustomizableEdges = customizableEdges1;
            btn_products.DisabledState.BorderColor = Color.DarkGray;
            btn_products.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_products.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_products.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_products.FillColor = Color.DarkGray;
            btn_products.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_products.ForeColor = Color.SteelBlue;
            btn_products.HoverState.BorderColor = Color.Black;
            btn_products.HoverState.CustomBorderColor = Color.Black;
            btn_products.HoverState.FillColor = Color.Black;
            btn_products.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_products.HoverState.ForeColor = Color.White;
            btn_products.Location = new Point(140, 108);
            btn_products.Name = "btn_products";
            btn_products.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_products.Size = new Size(252, 45);
            btn_products.TabIndex = 10;
            btn_products.Text = "Products";
            // 
            // btn_Categories
            // 
            btn_Categories.BackColor = Color.Transparent;
            btn_Categories.BorderRadius = 12;
            btn_Categories.CustomizableEdges = customizableEdges3;
            btn_Categories.DisabledState.BorderColor = Color.DarkGray;
            btn_Categories.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Categories.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Categories.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Categories.FillColor = Color.DarkGray;
            btn_Categories.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_Categories.ForeColor = Color.SteelBlue;
            btn_Categories.HoverState.BorderColor = Color.Black;
            btn_Categories.HoverState.CustomBorderColor = Color.Black;
            btn_Categories.HoverState.FillColor = Color.Black;
            btn_Categories.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_Categories.HoverState.ForeColor = Color.White;
            btn_Categories.Location = new Point(131, 269);
            btn_Categories.Name = "btn_Categories";
            btn_Categories.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_Categories.Size = new Size(252, 45);
            btn_Categories.TabIndex = 11;
            btn_Categories.Text = "Categories";
            btn_Categories.Click += btn_Categories_Click;
            // 
            // Frm_IL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(513, 450);
            Controls.Add(btn_Categories);
            Controls.Add(btn_products);
            Name = "Frm_IL";
            Text = "Frm_IL";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Guna.UI2.WinForms.Guna2Button btn_products;
        private Guna.UI2.WinForms.Guna2Button btn_Categories;
    }
}