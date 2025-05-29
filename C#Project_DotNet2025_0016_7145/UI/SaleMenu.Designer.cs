namespace UI
{
    partial class SaleMenu
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


        #endregion


        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            addSale = new TabPage();
            addSaleBtn = new Button();
            endSaleDate = new DateTimePicker();
            beginSaleDate = new DateTimePicker();
            no = new RadioButton();
            yes = new RadioButton();
            priceN = new NumericUpDown();
            minQuantityN = new NumericUpDown();
            productIdL = new TextBox();
            endSale = new Label();
            beginSale = new Label();
            price = new Label();
            inClab = new Label();
            minQuantity = new Label();
            productIdA = new Label();
            readAllSales = new TabPage();
            dataGridView1 = new DataGridView();
            deleteSale = new TabPage();
            saleId = new TextBox();
            label1 = new Label();
            deleteSaleBtn = new Button();
            updateSale = new TabPage();
            updateSaleBtn = new Button();
            endSaleU = new DateTimePicker();
            beginSaleU = new DateTimePicker();
            noU = new RadioButton();
            yesU = new RadioButton();
            priceU = new NumericUpDown();
            minQuantityU = new NumericUpDown();
            saleIdTB = new TextBox();
            productIdU = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            saleIdU = new Label();
            label7 = new Label();
            saleDeatails = new Button();
            saleIdInput = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            addSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minQuantityN).BeginInit();
            readAllSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            deleteSale.SuspendLayout();
            updateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minQuantityU).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addSale);
            tabControl1.Controls.Add(readAllSales);
            tabControl1.Controls.Add(deleteSale);
            tabControl1.Controls.Add(updateSale);
            tabControl1.Location = new Point(12, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(836, 364);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // addSale
            // 
            addSale.Controls.Add(addSaleBtn);
            addSale.Controls.Add(endSaleDate);
            addSale.Controls.Add(beginSaleDate);
            addSale.Controls.Add(no);
            addSale.Controls.Add(yes);
            addSale.Controls.Add(priceN);
            addSale.Controls.Add(minQuantityN);
            addSale.Controls.Add(productIdL);
            addSale.Controls.Add(endSale);
            addSale.Controls.Add(beginSale);
            addSale.Controls.Add(price);
            addSale.Controls.Add(inClab);
            addSale.Controls.Add(minQuantity);
            addSale.Controls.Add(productIdA);
            addSale.Location = new Point(4, 29);
            addSale.Name = "addSale";
            addSale.Padding = new Padding(3);
            addSale.Size = new Size(828, 331);
            addSale.TabIndex = 0;
            addSale.Text = "הוספה";
            addSale.UseVisualStyleBackColor = true;
            addSale.Click += addSale_Click;
            // 
            // addSaleBtn
            // 
            addSaleBtn.Location = new Point(379, 251);
            addSaleBtn.Name = "addSaleBtn";
            addSaleBtn.Size = new Size(247, 39);
            addSaleBtn.TabIndex = 5;
            addSaleBtn.Text = "להוספת המבצע";
            addSaleBtn.UseVisualStyleBackColor = true;
            addSaleBtn.Click += addSaleBtn_Click;
            // 
            // endSaleDate
            // 
            endSaleDate.Location = new Point(406, 207);
            endSaleDate.Name = "endSaleDate";
            endSaleDate.Size = new Size(191, 27);
            endSaleDate.TabIndex = 4;
            // 
            // beginSaleDate
            // 
            beginSaleDate.Location = new Point(406, 174);
            beginSaleDate.Name = "beginSaleDate";
            beginSaleDate.Size = new Size(191, 27);
            beginSaleDate.TabIndex = 4;
            // 
            // no
            // 
            no.AutoSize = true;
            no.Location = new Point(538, 91);
            no.Name = "no";
            no.Size = new Size(48, 24);
            no.TabIndex = 3;
            no.TabStop = true;
            no.Text = "לא";
            no.UseVisualStyleBackColor = true;
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.Location = new Point(607, 90);
            yes.Name = "yes";
            yes.Size = new Size(42, 24);
            yes.TabIndex = 3;
            yes.TabStop = true;
            yes.Text = "כן";
            yes.UseVisualStyleBackColor = true;
            yes.CheckedChanged += yes_CheckedChanged;
            // 
            // priceN
            // 
            priceN.Location = new Point(508, 127);
            priceN.Name = "priceN";
            priceN.Size = new Size(158, 27);
            priceN.TabIndex = 2;
            // 
            // minQuantityN
            // 
            minQuantityN.Location = new Point(496, 58);
            minQuantityN.Name = "minQuantityN";
            minQuantityN.Size = new Size(158, 27);
            minQuantityN.TabIndex = 2;
            // 
            // productIdL
            // 
            productIdL.Location = new Point(508, 25);
            productIdL.Name = "productIdL";
            productIdL.Size = new Size(146, 27);
            productIdL.TabIndex = 1;
            // 
            // endSale
            // 
            endSale.AutoSize = true;
            endSale.Location = new Point(630, 207);
            endSale.Name = "endSale";
            endSale.Size = new Size(157, 20);
            endSale.TabIndex = 0;
            endSale.Text = "תאריך תפוגת הממבצע";
            // 
            // beginSale
            // 
            beginSale.AutoSize = true;
            beginSale.Location = new Point(622, 174);
            beginSale.Name = "beginSale";
            beginSale.Size = new Size(165, 20);
            beginSale.TabIndex = 0;
            beginSale.Text = "תאריך התחלת הממבצע";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(738, 127);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 0;
            price.Text = "מחיר";
            price.Click += price_Click;
            // 
            // inClab
            // 
            inClab.AutoSize = true;
            inClab.Location = new Point(655, 95);
            inClab.Name = "inClab";
            inClab.Size = new Size(124, 20);
            inClab.TabIndex = 0;
            inClab.Text = "האם לחברי מועדון";
            // 
            // minQuantity
            // 
            minQuantity.AutoSize = true;
            minQuantity.Location = new Point(680, 58);
            minQuantity.Name = "minQuantity";
            minQuantity.Size = new Size(99, 20);
            minQuantity.TabIndex = 0;
            minQuantity.Text = "כמות מינמלית";
            // 
            // productIdA
            // 
            productIdA.AutoSize = true;
            productIdA.Location = new Point(710, 32);
            productIdA.Name = "productIdA";
            productIdA.Size = new Size(69, 20);
            productIdA.TabIndex = 0;
            productIdA.Text = " קוד מוצר";
            // 
            // readAllSales
            // 
            readAllSales.Controls.Add(saleDeatails);
            readAllSales.Controls.Add(saleIdInput);
            readAllSales.Controls.Add(label8);
            readAllSales.Controls.Add(dataGridView1);
            readAllSales.Location = new Point(4, 29);
            readAllSales.Name = "readAllSales";
            readAllSales.Padding = new Padding(3);
            readAllSales.Size = new Size(828, 331);
            readAllSales.TabIndex = 1;
            readAllSales.Text = "תצוגה";
            readAllSales.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(566, 318);
            dataGridView1.TabIndex = 0;
            // 
            // deleteSale
            // 
            deleteSale.Controls.Add(saleId);
            deleteSale.Controls.Add(label1);
            deleteSale.Controls.Add(deleteSaleBtn);
            deleteSale.Location = new Point(4, 29);
            deleteSale.Name = "deleteSale";
            deleteSale.Padding = new Padding(3);
            deleteSale.Size = new Size(828, 331);
            deleteSale.TabIndex = 2;
            deleteSale.Text = "מחיקה";
            deleteSale.UseVisualStyleBackColor = true;
            // 
            // saleId
            // 
            saleId.Location = new Point(181, 56);
            saleId.Name = "saleId";
            saleId.Size = new Size(182, 27);
            saleId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 59);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "הכנס מזהה מבצע";
            label1.Click += label1_Click;
            // 
            // deleteSaleBtn
            // 
            deleteSaleBtn.Location = new Point(212, 132);
            deleteSaleBtn.Name = "deleteSaleBtn";
            deleteSaleBtn.Size = new Size(265, 76);
            deleteSaleBtn.TabIndex = 0;
            deleteSaleBtn.Text = "למחיקת המבצע";
            deleteSaleBtn.UseVisualStyleBackColor = true;
            deleteSaleBtn.Click += deleteSaleBtn_Click;
            // 
            // updateSale
            // 
            updateSale.Controls.Add(updateSaleBtn);
            updateSale.Controls.Add(endSaleU);
            updateSale.Controls.Add(beginSaleU);
            updateSale.Controls.Add(noU);
            updateSale.Controls.Add(yesU);
            updateSale.Controls.Add(priceU);
            updateSale.Controls.Add(minQuantityU);
            updateSale.Controls.Add(saleIdTB);
            updateSale.Controls.Add(productIdU);
            updateSale.Controls.Add(label2);
            updateSale.Controls.Add(label3);
            updateSale.Controls.Add(label4);
            updateSale.Controls.Add(label5);
            updateSale.Controls.Add(label6);
            updateSale.Controls.Add(saleIdU);
            updateSale.Controls.Add(label7);
            updateSale.Location = new Point(4, 29);
            updateSale.Name = "updateSale";
            updateSale.Padding = new Padding(3);
            updateSale.Size = new Size(828, 331);
            updateSale.TabIndex = 3;
            updateSale.Text = "עדכון";
            updateSale.UseVisualStyleBackColor = true;
            // 
            // updateSaleBtn
            // 
            updateSaleBtn.Location = new Point(363, 278);
            updateSaleBtn.Name = "updateSaleBtn";
            updateSaleBtn.Size = new Size(247, 39);
            updateSaleBtn.TabIndex = 19;
            updateSaleBtn.Text = "לעדכון המבצע";
            updateSaleBtn.UseVisualStyleBackColor = true;
            updateSaleBtn.Click += updateSaleBtn_Click;
            // 
            // endSaleU
            // 
            endSaleU.Location = new Point(390, 234);
            endSaleU.Name = "endSaleU";
            endSaleU.Size = new Size(191, 27);
            endSaleU.TabIndex = 17;
            // 
            // beginSaleU
            // 
            beginSaleU.Location = new Point(390, 201);
            beginSaleU.Name = "beginSaleU";
            beginSaleU.Size = new Size(191, 27);
            beginSaleU.TabIndex = 18;
            // 
            // noU
            // 
            noU.AutoSize = true;
            noU.Location = new Point(522, 118);
            noU.Name = "noU";
            noU.Size = new Size(48, 24);
            noU.TabIndex = 15;
            noU.TabStop = true;
            noU.Text = "לא";
            noU.UseVisualStyleBackColor = true;
            // 
            // yesU
            // 
            yesU.AutoSize = true;
            yesU.Location = new Point(591, 117);
            yesU.Name = "yesU";
            yesU.Size = new Size(42, 24);
            yesU.TabIndex = 16;
            yesU.TabStop = true;
            yesU.Text = "כן";
            yesU.UseVisualStyleBackColor = true;
            // 
            // priceU
            // 
            priceU.Location = new Point(492, 154);
            priceU.Name = "priceU";
            priceU.Size = new Size(158, 27);
            priceU.TabIndex = 13;
            // 
            // minQuantityU
            // 
            minQuantityU.Location = new Point(480, 85);
            minQuantityU.Name = "minQuantityU";
            minQuantityU.Size = new Size(158, 27);
            minQuantityU.TabIndex = 14;
            // 
            // saleIdTB
            // 
            saleIdTB.Location = new Point(492, 21);
            saleIdTB.Name = "saleIdTB";
            saleIdTB.Size = new Size(146, 27);
            saleIdTB.TabIndex = 12;
            // 
            // productIdU
            // 
            productIdU.Location = new Point(492, 52);
            productIdU.Name = "productIdU";
            productIdU.Size = new Size(146, 27);
            productIdU.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 234);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 6;
            label2.Text = "תאריך תפוגת הממבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(606, 201);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 7;
            label3.Text = "תאריך התחלת הממבצע";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 154);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "מחיר";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(639, 122);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 9;
            label5.Text = "האם לחברי מועדון";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(664, 85);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 10;
            label6.Text = "כמות מינמלית";
            // 
            // saleIdU
            // 
            saleIdU.AutoSize = true;
            saleIdU.Location = new Point(688, 21);
            saleIdU.Name = "saleIdU";
            saleIdU.Size = new Size(75, 20);
            saleIdU.TabIndex = 11;
            saleIdU.Text = " קוד מבצע";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(694, 55);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 11;
            label7.Text = " קוד מוצר";
            // 
            // saleDeatails
            // 
            saleDeatails.Location = new Point(616, 193);
            saleDeatails.Name = "saleDeatails";
            saleDeatails.Size = new Size(153, 40);
            saleDeatails.TabIndex = 6;
            saleDeatails.Text = "הצג פרטי לקוח";
            saleDeatails.UseVisualStyleBackColor = true;
            saleDeatails.Click += saleDeatails_Click;
            // 
            // saleIdInput
            // 
            saleIdInput.Location = new Point(602, 109);
            saleIdInput.Name = "saleIdInput";
            saleIdInput.Size = new Size(187, 27);
            saleIdInput.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(640, 72);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 4;
            label8.Text = "הכנס מזהה מבצע";
            // 
            // SaleMenu
            // 
            ClientSize = new Size(860, 367);
            Controls.Add(tabControl1);
            Name = "SaleMenu";
            tabControl1.ResumeLayout(false);
            addSale.ResumeLayout(false);
            addSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceN).EndInit();
            ((System.ComponentModel.ISupportInitialize)minQuantityN).EndInit();
            readAllSales.ResumeLayout(false);
            readAllSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            deleteSale.ResumeLayout(false);
            deleteSale.PerformLayout();
            updateSale.ResumeLayout(false);
            updateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceU).EndInit();
            ((System.ComponentModel.ISupportInitialize)minQuantityU).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage addSale;
        private Label endSale;
        private Label beginSale;
        private Label price;
        private Label inClab;
        private Label minQuantity;
        private Label productIdA;
        private TabPage readAllSales;
        private TabPage deleteSale;
        private TabPage updateSale;
        private RadioButton no;
        private RadioButton yes;
        private NumericUpDown priceN;
        private NumericUpDown minQuantityN;
        private TextBox productIdL;
        private DateTimePicker endSaleDate;
        private DateTimePicker beginSaleDate;
        private Button addSaleBtn;
        private Label label1;
        private Button deleteSaleBtn;
        private TextBox saleId;
        private Button updateSaleBtn;
        private DateTimePicker endSaleU;
        private DateTimePicker beginSaleU;
        private RadioButton noU;
        private RadioButton yesU;
        private NumericUpDown priceU;
        private NumericUpDown minQuantityU;
        private TextBox productIdU;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox saleIdTB;
        private Label saleIdU;
        private Button saleDeatails;
        private TextBox saleIdInput;
        private Label label8;
    }
}