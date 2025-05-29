namespace UI
{
    partial class CustomerMenu
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
            idCustomer1 = new Label();
            idCustomer = new TextBox();
            label1 = new Label();
            customerName = new TextBox();
            label2 = new Label();
            addressCustomer = new TextBox();
            phoneCustomer1 = new Label();
            phoneCustomer = new TextBox();
            addCustomerBtn = new Button();
            tabControl1 = new TabControl();
            addCustomer = new TabPage();
            readAllCustomers = new TabPage();
            dataGridView1 = new DataGridView();
            deleteCustomers = new TabPage();
            deleteCustomerBtn = new Button();
            label7 = new Label();
            customerId = new TextBox();
            updateCustomers = new TabPage();
            productNameU = new TextBox();
            updateCustomerBtn = new Button();
            label3 = new Label();
            phoneCustomerU = new TextBox();
            cutomerIdU = new TextBox();
            label4 = new Label();
            label5 = new Label();
            addressCustomerU = new TextBox();
            label6 = new Label();
            label8 = new Label();
            customerIdInput = new TextBox();
            customerDeatails = new Button();
            tabControl1.SuspendLayout();
            addCustomer.SuspendLayout();
            readAllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            deleteCustomers.SuspendLayout();
            updateCustomers.SuspendLayout();
            SuspendLayout();
            // 
            // idCustomer1
            // 
            idCustomer1.AutoSize = true;
            idCustomer1.Location = new Point(427, 40);
            idCustomer1.Name = "idCustomer1";
            idCustomer1.Size = new Size(66, 20);
            idCustomer1.TabIndex = 0;
            idCustomer1.Text = "קוד לקוח";
            // 
            // idCustomer
            // 
            idCustomer.Location = new Point(238, 40);
            idCustomer.Name = "idCustomer";
            idCustomer.Size = new Size(151, 27);
            idCustomer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 73);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "שם";
            label1.Click += label1_Click;
            // 
            // customerName
            // 
            customerName.Location = new Point(238, 73);
            customerName.Name = "customerName";
            customerName.Size = new Size(151, 27);
            customerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 106);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 0;
            label2.Text = "כתובת";
            // 
            // addressCustomer
            // 
            addressCustomer.Location = new Point(238, 106);
            addressCustomer.Name = "addressCustomer";
            addressCustomer.Size = new Size(151, 27);
            addressCustomer.TabIndex = 1;
            // 
            // phoneCustomer1
            // 
            phoneCustomer1.AutoSize = true;
            phoneCustomer1.Location = new Point(422, 139);
            phoneCustomer1.Name = "phoneCustomer1";
            phoneCustomer1.Size = new Size(71, 20);
            phoneCustomer1.TabIndex = 0;
            phoneCustomer1.Text = "מס' טלפון";
            phoneCustomer1.Click += label3_Click;
            // 
            // phoneCustomer
            // 
            phoneCustomer.Location = new Point(238, 139);
            phoneCustomer.Name = "phoneCustomer";
            phoneCustomer.Size = new Size(151, 27);
            phoneCustomer.TabIndex = 1;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(202, 217);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(187, 59);
            addCustomerBtn.TabIndex = 2;
            addCustomerBtn.Text = "הוספת לקוח";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addCustomer);
            tabControl1.Controls.Add(readAllCustomers);
            tabControl1.Controls.Add(deleteCustomers);
            tabControl1.Controls.Add(updateCustomers);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(766, 426);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // addCustomer
            // 
            addCustomer.Controls.Add(customerName);
            addCustomer.Controls.Add(addCustomerBtn);
            addCustomer.Controls.Add(idCustomer1);
            addCustomer.Controls.Add(phoneCustomer);
            addCustomer.Controls.Add(idCustomer);
            addCustomer.Controls.Add(phoneCustomer1);
            addCustomer.Controls.Add(label1);
            addCustomer.Controls.Add(addressCustomer);
            addCustomer.Controls.Add(label2);
            addCustomer.Location = new Point(4, 29);
            addCustomer.Name = "addCustomer";
            addCustomer.Padding = new Padding(3);
            addCustomer.Size = new Size(630, 322);
            addCustomer.TabIndex = 0;
            addCustomer.Text = "הוספה";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click;
            // 
            // readAllCustomers
            // 
            readAllCustomers.Controls.Add(customerDeatails);
            readAllCustomers.Controls.Add(customerIdInput);
            readAllCustomers.Controls.Add(label8);
            readAllCustomers.Controls.Add(dataGridView1);
            readAllCustomers.Location = new Point(4, 29);
            readAllCustomers.Name = "readAllCustomers";
            readAllCustomers.Padding = new Padding(3);
            readAllCustomers.Size = new Size(758, 393);
            readAllCustomers.TabIndex = 1;
            readAllCustomers.Text = "תצוגה";
            readAllCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(490, 363);
            dataGridView1.TabIndex = 0;
            // 
            // deleteCustomers
            // 
            deleteCustomers.Controls.Add(deleteCustomerBtn);
            deleteCustomers.Controls.Add(label7);
            deleteCustomers.Controls.Add(customerId);
            deleteCustomers.Location = new Point(4, 29);
            deleteCustomers.Name = "deleteCustomers";
            deleteCustomers.Padding = new Padding(3);
            deleteCustomers.Size = new Size(630, 322);
            deleteCustomers.TabIndex = 2;
            deleteCustomers.Text = "מחיקה";
            deleteCustomers.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Location = new Point(211, 161);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(189, 56);
            deleteCustomerBtn.TabIndex = 12;
            deleteCustomerBtn.Text = "מחק לקוח";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 77);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 10;
            label7.Text = "קוד לקוח";
            // 
            // customerId
            // 
            customerId.Location = new Point(193, 77);
            customerId.Name = "customerId";
            customerId.Size = new Size(151, 27);
            customerId.TabIndex = 11;
            // 
            // updateCustomers
            // 
            updateCustomers.Controls.Add(productNameU);
            updateCustomers.Controls.Add(updateCustomerBtn);
            updateCustomers.Controls.Add(label3);
            updateCustomers.Controls.Add(phoneCustomerU);
            updateCustomers.Controls.Add(cutomerIdU);
            updateCustomers.Controls.Add(label4);
            updateCustomers.Controls.Add(label5);
            updateCustomers.Controls.Add(addressCustomerU);
            updateCustomers.Controls.Add(label6);
            updateCustomers.Location = new Point(4, 29);
            updateCustomers.Name = "updateCustomers";
            updateCustomers.Padding = new Padding(3);
            updateCustomers.Size = new Size(630, 322);
            updateCustomers.TabIndex = 3;
            updateCustomers.Text = "עדכון";
            updateCustomers.UseVisualStyleBackColor = true;
            // 
            // productNameU
            // 
            productNameU.Location = new Point(230, 75);
            productNameU.Name = "productNameU";
            productNameU.Size = new Size(151, 27);
            productNameU.TabIndex = 7;
            // 
            // updateCustomerBtn
            // 
            updateCustomerBtn.Location = new Point(194, 219);
            updateCustomerBtn.Name = "updateCustomerBtn";
            updateCustomerBtn.Size = new Size(187, 59);
            updateCustomerBtn.TabIndex = 11;
            updateCustomerBtn.Text = "עדכון לקוח";
            updateCustomerBtn.UseVisualStyleBackColor = true;
            updateCustomerBtn.Click += updateCustomerBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 42);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "קוד לקוח";
            // 
            // phoneCustomerU
            // 
            phoneCustomerU.Location = new Point(230, 141);
            phoneCustomerU.Name = "phoneCustomerU";
            phoneCustomerU.Size = new Size(151, 27);
            phoneCustomerU.TabIndex = 8;
            // 
            // cutomerIdU
            // 
            cutomerIdU.Location = new Point(230, 42);
            cutomerIdU.Name = "cutomerIdU";
            cutomerIdU.Size = new Size(151, 27);
            cutomerIdU.TabIndex = 9;
            cutomerIdU.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 141);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "מס' טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 75);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 5;
            label5.Text = "שם";
            // 
            // addressCustomerU
            // 
            addressCustomerU.Location = new Point(230, 108);
            addressCustomerU.Name = "addressCustomerU";
            addressCustomerU.Size = new Size(151, 27);
            addressCustomerU.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 108);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "כתובת";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 57);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 1;
            label8.Text = "הכנס מזהה לקוח";
            // 
            // customerIdInput
            // 
            customerIdInput.Location = new Point(534, 94);
            customerIdInput.Name = "customerIdInput";
            customerIdInput.Size = new Size(187, 27);
            customerIdInput.TabIndex = 2;
            // 
            // customerDeatails
            // 
            customerDeatails.Location = new Point(548, 178);
            customerDeatails.Name = "customerDeatails";
            customerDeatails.Size = new Size(153, 40);
            customerDeatails.TabIndex = 3;
            customerDeatails.Text = "הצג פרטי לקוח";
            customerDeatails.UseVisualStyleBackColor = true;
            customerDeatails.Click += customerDeatails_Click;
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "CustomerMenu";
            Text = "CustomerMenu";
            tabControl1.ResumeLayout(false);
            addCustomer.ResumeLayout(false);
            addCustomer.PerformLayout();
            readAllCustomers.ResumeLayout(false);
            readAllCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            deleteCustomers.ResumeLayout(false);
            deleteCustomers.PerformLayout();
            updateCustomers.ResumeLayout(false);
            updateCustomers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label idCustomer1;
        private TextBox idCustomer;
        private Label label1;
        private TextBox customerName;
        private Label label2;
        private TextBox addressCustomer;
        private Label phoneCustomer1;
        private TextBox phoneCustomer;
        private Button addCustomerBtn;
        private TabControl tabControl1;
        private TabPage addCustomer;
        private TabPage readAllCustomers;
        private TabPage deleteCustomers;
        private TabPage updateCustomers;
        private TextBox productNameU;
        private Button updateCustomerBtn;
        private Label label3;
        private TextBox phoneCustomerU;
        private TextBox cutomerIdU;
        private Label label4;
        private Label label5;
        private TextBox addressCustomerU;
        private Label label6;
        private Label label7;
        private TextBox customerId;
        private DataGridView dataGridView1;
        private Button deleteCustomerBtn;
        private Button customerDeatails;
        private TextBox customerIdInput;
        private Label label8;
    }
}