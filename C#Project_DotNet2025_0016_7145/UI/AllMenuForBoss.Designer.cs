namespace UI
{
    partial class AllMenuForBoss
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
            forProducts = new Button();
            forCustomers = new Button();
            forSales = new Button();
            SuspendLayout();
            // 
            // forProducts
            // 
            forProducts.Location = new Point(508, 133);
            forProducts.Name = "forProducts";
            forProducts.Size = new Size(225, 194);
            forProducts.TabIndex = 0;
            forProducts.Text = "מוצרים";
            forProducts.UseVisualStyleBackColor = true;
            forProducts.Click += forProducts_Click;
            // 
            // forCustomers
            // 
            forCustomers.Location = new Point(277, 133);
            forCustomers.Name = "forCustomers";
            forCustomers.Size = new Size(225, 194);
            forCustomers.TabIndex = 0;
            forCustomers.Text = "לקוחות";
            forCustomers.UseVisualStyleBackColor = true;
            forCustomers.Click += forCustomers_Click;
            // 
            // forSales
            // 
            forSales.Location = new Point(46, 133);
            forSales.Name = "forSales";
            forSales.Size = new Size(225, 194);
            forSales.TabIndex = 0;
            forSales.Text = "מבצעים";
            forSales.UseVisualStyleBackColor = true;
            forSales.Click += forSales_Click;
            // 
            // AllMenuForBoss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(forSales);
            Controls.Add(forCustomers);
            Controls.Add(forProducts);
            Name = "AllMenuForBoss";
            Text = "AllMenuForBoss";
            ResumeLayout(false);
        }

        #endregion

        private Button forProducts;
        private Button forCustomers;
        private Button forSales;
    }
}