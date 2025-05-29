namespace UI
{
    partial class Login
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
            boss = new Button();
            shopkipper = new Button();
            SuspendLayout();
            // 
            // boss
            // 
            boss.Location = new Point(443, 143);
            boss.Name = "boss";
            boss.Size = new Size(195, 141);
            boss.TabIndex = 0;
            boss.Text = "מנהל";
            boss.UseVisualStyleBackColor = true;
            boss.Click += boss_Click;
            // 
            // shopkipper
            // 
            shopkipper.Location = new Point(187, 143);
            shopkipper.Name = "shopkipper";
            shopkipper.Size = new Size(195, 141);
            shopkipper.TabIndex = 0;
            shopkipper.Text = "קופאי";
            shopkipper.UseVisualStyleBackColor = true;
            shopkipper.Click += shopkipper_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shopkipper);
            Controls.Add(boss);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button boss;
        private Button shopkipper;
    }
}