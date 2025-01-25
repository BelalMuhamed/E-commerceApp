namespace E_commercePL
{
    partial class Frm_AdminCategory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgv_categories = new DataGridView();
            txt_Name = new Guna.UI2.WinForms.Guna2TextBox();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            btn_update = new Guna.UI2.WinForms.Guna2Button();
            btn_Add = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            SuspendLayout();
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.Location = new Point(0, 0);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(258, 447);
            dgv_categories.TabIndex = 0;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // txt_Name
            // 
            txt_Name.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Name.BackColor = Color.Transparent;
            txt_Name.BorderColor = Color.Transparent;
            txt_Name.BorderThickness = 0;
            customizableEdges1.BottomLeft = false;
            txt_Name.CustomizableEdges = customizableEdges1;
            txt_Name.DefaultText = "";
            txt_Name.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Name.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Name.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Name.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Name.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Name.Font = new Font("Segoe UI", 14F);
            txt_Name.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Name.Location = new Point(266, 37);
            txt_Name.Margin = new Padding(5, 6, 5, 6);
            txt_Name.Name = "txt_Name";
            txt_Name.PasswordChar = '\0';
            txt_Name.PlaceholderText = "Name";
            txt_Name.SelectedText = "";
            customizableEdges2.BottomLeft = false;
            customizableEdges2.BottomRight = false;
            customizableEdges2.TopLeft = false;
            customizableEdges2.TopRight = false;
            txt_Name.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_Name.Size = new Size(360, 63);
            txt_Name.TabIndex = 6;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.BorderRadius = 12;
            btn_delete.CustomizableEdges = customizableEdges3;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.FillColor = Color.DarkGray;
            btn_delete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_delete.ForeColor = Color.SteelBlue;
            btn_delete.HoverState.BorderColor = Color.Black;
            btn_delete.HoverState.CustomBorderColor = Color.Black;
            btn_delete.HoverState.FillColor = Color.Black;
            btn_delete.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_delete.HoverState.ForeColor = Color.White;
            btn_delete.Location = new Point(266, 261);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_delete.Size = new Size(155, 45);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Transparent;
            btn_update.BorderRadius = 12;
            btn_update.CustomizableEdges = customizableEdges5;
            btn_update.DisabledState.BorderColor = Color.DarkGray;
            btn_update.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_update.FillColor = Color.DarkGray;
            btn_update.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_update.ForeColor = Color.SteelBlue;
            btn_update.HoverState.BorderColor = Color.Black;
            btn_update.HoverState.CustomBorderColor = Color.Black;
            btn_update.HoverState.FillColor = Color.Black;
            btn_update.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_update.HoverState.ForeColor = Color.White;
            btn_update.Location = new Point(421, 355);
            btn_update.Name = "btn_update";
            btn_update.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_update.Size = new Size(155, 45);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.Transparent;
            btn_Add.BorderRadius = 12;
            btn_Add.CustomizableEdges = customizableEdges7;
            btn_Add.DisabledState.BorderColor = Color.DarkGray;
            btn_Add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Add.FillColor = Color.DarkGray;
            btn_Add.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_Add.ForeColor = Color.SteelBlue;
            btn_Add.HoverState.BorderColor = Color.Black;
            btn_Add.HoverState.CustomBorderColor = Color.Black;
            btn_Add.HoverState.FillColor = Color.Black;
            btn_Add.HoverState.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btn_Add.HoverState.ForeColor = Color.White;
            btn_Add.Location = new Point(580, 261);
            btn_Add.Name = "btn_Add";
            btn_Add.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_Add.Size = new Size(155, 45);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.Click += btn_Add_Click_1;
            // 
            // Frm_AdminCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_596626503_jrzjZNYStDexiWxQFqO7oCh6M8PdMlJs;
            ClientSize = new Size(797, 483);
            Controls.Add(btn_Add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(txt_Name);
            Controls.Add(dgv_categories);
            Name = "Frm_AdminCategory";
            Text = "Categories";
            Load += Frm_AdminCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_categories;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
    }
}