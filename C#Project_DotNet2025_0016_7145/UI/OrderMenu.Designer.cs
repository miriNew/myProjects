namespace UI
{
    partial class OrderMenu
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
            label1 = new Label();
            productNameTB = new TextBox();
            label2 = new Label();
            quantityTB = new TextBox();
            dataGridView1 = new DataGridView();
            totalOrder = new Button();
            addToOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(640, 65);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "הכנס שם מוצר";
            // 
            // productNameTB
            // 
            productNameTB.Location = new Point(491, 62);
            productNameTB.Name = "productNameTB";
            productNameTB.Size = new Size(143, 27);
            productNameTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 104);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 0;
            label2.Text = "הכנס כמות";
            // 
            // quantityTB
            // 
            quantityTB.Location = new Point(491, 97);
            quantityTB.Name = "quantityTB";
            quantityTB.Size = new Size(143, 27);
            quantityTB.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(409, 258);
            dataGridView1.TabIndex = 2;
            // 
            // totalOrder
            // 
            totalOrder.Location = new Point(522, 301);
            totalOrder.Name = "totalOrder";
            totalOrder.Size = new Size(205, 89);
            totalOrder.TabIndex = 3;
            totalOrder.Text = "לסיום ההזמנה";
            totalOrder.UseVisualStyleBackColor = true;
            // 
            // addToOrder
            // 
            addToOrder.Location = new Point(522, 168);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(205, 37);
            addToOrder.TabIndex = 4;
            addToOrder.Text = "הוסף להזמנה";
            addToOrder.UseVisualStyleBackColor = true;
            // 
            // OrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addToOrder);
            Controls.Add(totalOrder);
            Controls.Add(dataGridView1);
            Controls.Add(quantityTB);
            Controls.Add(productNameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderMenu";
            Text = "OrderMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productNameTB;
        private Label label2;
        private TextBox quantityTB;
        private DataGridView dataGridView1;
        private Button totalOrder;
        private Button addToOrder;
    }
}