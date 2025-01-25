namespace E_commercePL
{
    partial class AdminProduct
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
            dgv_adminProduct = new DataGridView();
            txt_name = new TextBox();
            txt_price = new TextBox();
            cb_category = new ComboBox();
            v = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_adminProduct).BeginInit();
            SuspendLayout();
            // 
            // dgv_adminProduct
            // 
            dgv_adminProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_adminProduct.Location = new Point(2, 190);
            dgv_adminProduct.Name = "dgv_adminProduct";
            dgv_adminProduct.RowHeadersWidth = 51;
            dgv_adminProduct.Size = new Size(676, 255);
            dgv_adminProduct.TabIndex = 0;
            dgv_adminProduct.RowHeaderMouseDoubleClick += dgv_adminProduct_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(184, 24);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(184, 78);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 2;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(184, 143);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(151, 28);
            cb_category.TabIndex = 3;
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(43, 31);
            v.Name = "v";
            v.Size = new Size(106, 20);
            v.TabIndex = 4;
            v.Text = "Product_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 81);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // button1
            // 
            button1.Location = new Point(511, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 90);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(511, 142);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(v);
            Controls.Add(cb_category);
            Controls.Add(txt_price);
            Controls.Add(txt_name);
            Controls.Add(dgv_adminProduct);
            Name = "AdminProduct";
            Text = "AdminProduct";
            Load += AdminProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adminProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_adminProduct;
        private TextBox txt_name;
        private TextBox txt_price;
        private ComboBox cb_category;
        private Label v;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}