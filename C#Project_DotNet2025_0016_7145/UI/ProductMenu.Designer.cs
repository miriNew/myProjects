namespace UI
{
    partial class ProductMenu
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
            tabControl1 = new TabControl();
            adProduct = new TabPage();
            addProductBtn = new Button();
            saleInProduct = new ListBox();
            category = new ComboBox();
            QuantityInStock = new NumericUpDown();
            priceProduct = new NumericUpDown();
            productName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            price = new Label();
            minQuantity = new Label();
            productIdA = new Label();
            readAllProducts = new TabPage();
            productDeatails = new Button();
            productIdInput = new TextBox();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            deleteProduct = new TabPage();
            deleteProductBtn = new Button();
            productIDd = new TextBox();
            label8 = new Label();
            updateProduct = new TabPage();
            saleInProductU = new ListBox();
            categoryU = new ComboBox();
            updateProductBtn = new Button();
            quantityInStockU = new NumericUpDown();
            priceProductU = new NumericUpDown();
            productIdU = new TextBox();
            productNameU = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            adProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceProduct).BeginInit();
            readAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            deleteProduct.SuspendLayout();
            updateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInStockU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceProductU).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(adProduct);
            tabControl1.Controls.Add(readAllProducts);
            tabControl1.Controls.Add(deleteProduct);
            tabControl1.Controls.Add(updateProduct);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(764, 437);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // adProduct
            // 
            adProduct.Controls.Add(addProductBtn);
            adProduct.Controls.Add(saleInProduct);
            adProduct.Controls.Add(category);
            adProduct.Controls.Add(QuantityInStock);
            adProduct.Controls.Add(priceProduct);
            adProduct.Controls.Add(productName);
            adProduct.Controls.Add(label2);
            adProduct.Controls.Add(label1);
            adProduct.Controls.Add(price);
            adProduct.Controls.Add(minQuantity);
            adProduct.Controls.Add(productIdA);
            adProduct.Location = new Point(4, 29);
            adProduct.Name = "adProduct";
            adProduct.Padding = new Padding(3);
            adProduct.Size = new Size(756, 404);
            adProduct.TabIndex = 0;
            adProduct.Text = "הוספה";
            adProduct.UseVisualStyleBackColor = true;
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(309, 303);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(166, 45);
            addProductBtn.TabIndex = 22;
            addProductBtn.Text = "הוספת המוצר";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // saleInProduct
            // 
            saleInProduct.FormattingEnabled = true;
            saleInProduct.ItemHeight = 20;
            saleInProduct.Location = new Point(254, 195);
            saleInProduct.Name = "saleInProduct";
            saleInProduct.Size = new Size(150, 64);
            saleInProduct.TabIndex = 21;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "kitchen,", "sleepDeprivation ", " livingRoom ", " lighting" });
            category.Location = new Point(278, 69);
            category.Name = "category";
            category.Size = new Size(151, 28);
            category.TabIndex = 20;
            category.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // QuantityInStock
            // 
            QuantityInStock.Location = new Point(283, 154);
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Size = new Size(158, 27);
            QuantityInStock.TabIndex = 13;
            QuantityInStock.ValueChanged += priceN_ValueChanged;
            // 
            // priceProduct
            // 
            priceProduct.Location = new Point(283, 113);
            priceProduct.Name = "priceProduct";
            priceProduct.Size = new Size(158, 27);
            priceProduct.TabIndex = 13;
            priceProduct.ValueChanged += priceN_ValueChanged;
            // 
            // productName
            // 
            productName.Location = new Point(283, 25);
            productName.Name = "productName";
            productName.Size = new Size(146, 27);
            productName.TabIndex = 12;
            productName.TextChanged += productIdL_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 195);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 8;
            label2.Text = "רשימת מבצעים למוצר";
            label2.Click += price_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 156);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 8;
            label1.Text = "כמות במלאי";
            label1.Click += price_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(498, 120);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 8;
            price.Text = "מחיר";
            price.Click += price_Click;
            // 
            // minQuantity
            // 
            minQuantity.AutoSize = true;
            minQuantity.Location = new Point(487, 72);
            minQuantity.Name = "minQuantity";
            minQuantity.Size = new Size(62, 20);
            minQuantity.TabIndex = 10;
            minQuantity.Text = "קטגוריה";
            minQuantity.Click += minQuantity_Click;
            // 
            // productIdA
            // 
            productIdA.AutoSize = true;
            productIdA.Location = new Point(483, 28);
            productIdA.Name = "productIdA";
            productIdA.Size = new Size(66, 20);
            productIdA.TabIndex = 11;
            productIdA.Text = "שם מוצר";
            productIdA.Click += productIdA_Click;
            // 
            // readAllProducts
            // 
            readAllProducts.Controls.Add(productDeatails);
            readAllProducts.Controls.Add(productIdInput);
            readAllProducts.Controls.Add(label10);
            readAllProducts.Controls.Add(dataGridView1);
            readAllProducts.Location = new Point(4, 29);
            readAllProducts.Name = "readAllProducts";
            readAllProducts.Padding = new Padding(3);
            readAllProducts.Size = new Size(756, 404);
            readAllProducts.TabIndex = 1;
            readAllProducts.Text = "תצוגה";
            readAllProducts.UseVisualStyleBackColor = true;
            // 
            // productDeatails
            // 
            productDeatails.Location = new Point(563, 216);
            productDeatails.Name = "productDeatails";
            productDeatails.Size = new Size(153, 40);
            productDeatails.TabIndex = 6;
            productDeatails.Text = "הצג פרטי מוצר";
            productDeatails.UseVisualStyleBackColor = true;
            productDeatails.Click += customerDeatails_Click;
            // 
            // productIdInput
            // 
            productIdInput.Location = new Point(549, 132);
            productIdInput.Name = "productIdInput";
            productIdInput.Size = new Size(187, 27);
            productIdInput.TabIndex = 5;
            productIdInput.TextChanged += customerIdInput_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(587, 95);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 4;
            label10.Text = "הכנס מזהה מוצר";
            label10.Click += label10_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(523, 391);
            dataGridView1.TabIndex = 0;
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(deleteProductBtn);
            deleteProduct.Controls.Add(productIDd);
            deleteProduct.Controls.Add(label8);
            deleteProduct.Location = new Point(4, 29);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Padding = new Padding(3);
            deleteProduct.Size = new Size(756, 404);
            deleteProduct.TabIndex = 2;
            deleteProduct.Text = "מחיקה";
            deleteProduct.UseVisualStyleBackColor = true;
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Location = new Point(238, 160);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(191, 54);
            deleteProductBtn.TabIndex = 2;
            deleteProductBtn.Text = "מחק מוצר";
            deleteProductBtn.UseVisualStyleBackColor = true;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // productIDd
            // 
            productIDd.Location = new Point(173, 55);
            productIDd.Name = "productIDd";
            productIDd.Size = new Size(187, 27);
            productIDd.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 55);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 0;
            label8.Text = "הכנס קוד מוצר";
            // 
            // updateProduct
            // 
            updateProduct.Controls.Add(saleInProductU);
            updateProduct.Controls.Add(categoryU);
            updateProduct.Controls.Add(updateProductBtn);
            updateProduct.Controls.Add(quantityInStockU);
            updateProduct.Controls.Add(priceProductU);
            updateProduct.Controls.Add(productIdU);
            updateProduct.Controls.Add(productNameU);
            updateProduct.Controls.Add(label3);
            updateProduct.Controls.Add(label4);
            updateProduct.Controls.Add(label5);
            updateProduct.Controls.Add(label6);
            updateProduct.Controls.Add(label9);
            updateProduct.Controls.Add(label7);
            updateProduct.Location = new Point(4, 29);
            updateProduct.Name = "updateProduct";
            updateProduct.Padding = new Padding(3);
            updateProduct.Size = new Size(756, 404);
            updateProduct.TabIndex = 3;
            updateProduct.Text = "עדכון";
            updateProduct.UseVisualStyleBackColor = true;
            // 
            // saleInProductU
            // 
            saleInProductU.FormattingEnabled = true;
            saleInProductU.ItemHeight = 20;
            saleInProductU.Location = new Point(262, 230);
            saleInProductU.Name = "saleInProductU";
            saleInProductU.Size = new Size(150, 64);
            saleInProductU.TabIndex = 32;
            // 
            // categoryU
            // 
            categoryU.FormattingEnabled = true;
            categoryU.Items.AddRange(new object[] { "kitchen,", "sleepDeprivation ", " livingRoom ", " lighting" });
            categoryU.Location = new Point(286, 104);
            categoryU.Name = "categoryU";
            categoryU.Size = new Size(151, 28);
            categoryU.TabIndex = 31;
            // 
            // updateProductBtn
            // 
            updateProductBtn.Location = new Point(24, 246);
            updateProductBtn.Name = "updateProductBtn";
            updateProductBtn.Size = new Size(213, 39);
            updateProductBtn.TabIndex = 30;
            updateProductBtn.Text = "לעדכון המוצר";
            updateProductBtn.UseVisualStyleBackColor = true;
            // 
            // quantityInStockU
            // 
            quantityInStockU.Location = new Point(291, 189);
            quantityInStockU.Name = "quantityInStockU";
            quantityInStockU.Size = new Size(158, 27);
            quantityInStockU.TabIndex = 28;
            quantityInStockU.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // priceProductU
            // 
            priceProductU.Location = new Point(291, 148);
            priceProductU.Name = "priceProductU";
            priceProductU.Size = new Size(158, 27);
            priceProductU.TabIndex = 29;
            // 
            // productIdU
            // 
            productIdU.Location = new Point(291, 27);
            productIdU.Name = "productIdU";
            productIdU.Size = new Size(146, 27);
            productIdU.TabIndex = 27;
            // 
            // productNameU
            // 
            productNameU.Location = new Point(291, 60);
            productNameU.Name = "productNameU";
            productNameU.Size = new Size(146, 27);
            productNameU.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 230);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 22;
            label3.Text = "רשימת מבצעים למוצר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 191);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 23;
            label4.Text = "כמות במלאי";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 155);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 24;
            label5.Text = "מחיר";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 107);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 25;
            label6.Text = "קטגוריה";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(491, 27);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 26;
            label9.Text = "קוד מוצר";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 63);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 26;
            label7.Text = "שם מוצר";
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ProductMenu";
            Text = "ProductMenu";
            tabControl1.ResumeLayout(false);
            adProduct.ResumeLayout(false);
            adProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceProduct).EndInit();
            readAllProducts.ResumeLayout(false);
            readAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            updateProduct.ResumeLayout(false);
            updateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInStockU).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceProductU).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage adProduct;
        private TabPage readAllProducts;
        private TabPage deleteProduct;
        private TabPage updateProduct;
        private Button addSaleBtn;
        private DateTimePicker endSaleDate;
        private DateTimePicker beginSaleDate;
        private NumericUpDown priceProduct;
        private TextBox productName;
        private Label endSale;
        private Label beginSale;
        private Label price;
        private Label minQuantity;
        private Label productIdA;
        private ComboBox category;
        private NumericUpDown QuantityInStock;
        private Label label1;
        private ListBox saleInProduct;
        private Label label2;
        private ListBox saleInProductU;
        private ComboBox categoryU;
        private Button updateProductBtn;
        private NumericUpDown quantityInStockU;
        private NumericUpDown priceProductU;
        private TextBox productNameU;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Button deleteProductBtn;
        private TextBox productIDd;
        private Label label8;
        private TextBox productIdU;
        private Label label9;
        private Button addProductBtn;
        private Button productDeatails;
        private TextBox productIdInput;
        private Label label10;
    }
}