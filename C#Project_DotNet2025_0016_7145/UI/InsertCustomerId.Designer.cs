namespace UI
{
    partial class InsertCustomerId
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
            label2 = new Label();
            customerIdTB = new TextBox();
            send = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 101);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "הכנס מזהה לקוח";
            // 
            // customerIdTB
            // 
            customerIdTB.Location = new Point(298, 148);
            customerIdTB.Name = "customerIdTB";
            customerIdTB.Size = new Size(198, 27);
            customerIdTB.TabIndex = 3;
            // 
            // send
            // 
            send.Location = new Point(331, 215);
            send.Name = "send";
            send.Size = new Size(130, 59);
            send.TabIndex = 4;
            send.Text = "התחל הזמנה";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // InsertCustomerId
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(send);
            Controls.Add(customerIdTB);
            Controls.Add(label2);
            Name = "InsertCustomerId";
            Text = "InsertCustomerId";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox customerIdTB;
        private Button send;
    }
}