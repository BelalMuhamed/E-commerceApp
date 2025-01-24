namespace E_commercePL
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox1 = new ComboBox();
            catogrey = new Label();
            txt_price = new TextBox();
            txt_Name = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(302, 604);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(546, 527);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(163, 57);
            button1.TabIndex = 1;
            button1.Text = "Favorite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(585, 27);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // catogrey
            // 
            catogrey.AutoSize = true;
            catogrey.Location = new Point(476, 37);
            catogrey.Name = "catogrey";
            catogrey.Size = new Size(80, 20);
            catogrey.TabIndex = 3;
            catogrey.Text = "Categories";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(585, 155);
            txt_price.Margin = new Padding(3, 4, 3, 4);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(199, 27);
            txt_price.TabIndex = 4;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(585, 95);
            txt_Name.Margin = new Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(199, 27);
            txt_Name.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(546, 451);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(163, 55);
            button2.TabIndex = 7;
            button2.Text = "Add_ToFavorite";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(463, 106);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 8;
            label1.Text = "Product_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 165);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 9;
            label2.Text = "Product_Price";
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(831, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txt_Name);
            Controls.Add(txt_price);
            Controls.Add(catogrey);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox1;
        private Label catogrey;
        private TextBox txt_price;
        private TextBox txt_Name;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}