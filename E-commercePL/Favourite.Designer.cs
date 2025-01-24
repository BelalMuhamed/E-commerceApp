namespace E_commercePL
{
    partial class Favourite
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_Name = new TextBox();
            txt_price = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(267, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(340, 459);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(156, 31);
            button1.TabIndex = 1;
            button1.Text = "Categories";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 126);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 13;
            label2.Text = "Product_Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 67);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 12;
            label1.Text = "Product_Name";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(395, 56);
            txt_Name.Margin = new Padding(3, 4, 3, 4);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(199, 27);
            txt_Name.TabIndex = 11;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(395, 116);
            txt_price.Margin = new Padding(3, 4, 3, 4);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(199, 27);
            txt_price.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(366, 223);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Favourite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 600);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Name);
            Controls.Add(txt_price);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Favourite";
            Text = "Favourite";
            Load += Favourite_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txt_Name;
        private TextBox txt_price;
        private Button button2;
    }
}