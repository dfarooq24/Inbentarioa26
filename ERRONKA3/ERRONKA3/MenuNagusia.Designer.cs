namespace ERRONKA3
{
    partial class MenuNagusia
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
            lblMenuNagusia = new Label();
            btnGailuakIkusi = new Button();
            btnGailuaGehitu = new Button();
            btnErabiltzaileakKudeatu = new Button();
            btnIrten = new Button();
            SuspendLayout();
            // 
            // lblMenuNagusia
            // 
            lblMenuNagusia.AutoSize = true;
            lblMenuNagusia.Location = new Point(333, 33);
            lblMenuNagusia.Name = "lblMenuNagusia";
            lblMenuNagusia.Size = new Size(118, 20);
            lblMenuNagusia.TabIndex = 0;
            lblMenuNagusia.Text = "MENU NAGUSIA";
            // 
            // btnGailuakIkusi
            // 
            btnGailuakIkusi.Location = new Point(90, 128);
            btnGailuakIkusi.Name = "btnGailuakIkusi";
            btnGailuakIkusi.Size = new Size(145, 29);
            btnGailuakIkusi.TabIndex = 1;
            btnGailuakIkusi.Text = "Gailuak Ikusi";
            btnGailuakIkusi.UseVisualStyleBackColor = true;
            btnGailuakIkusi.Click += btnGailuakIkusi_Click_1;
            // 
            // btnGailuaGehitu
            // 
            btnGailuaGehitu.Location = new Point(319, 128);
            btnGailuaGehitu.Name = "btnGailuaGehitu";
            btnGailuaGehitu.Size = new Size(145, 29);
            btnGailuaGehitu.TabIndex = 2;
            btnGailuaGehitu.Text = "Gailua Gehitu";
            btnGailuaGehitu.UseVisualStyleBackColor = true;
            btnGailuaGehitu.Click += btnGailuaGehitu_Click;
            // 
            // btnErabiltzaileakKudeatu
            // 
            btnErabiltzaileakKudeatu.Location = new Point(545, 128);
            btnErabiltzaileakKudeatu.Name = "btnErabiltzaileakKudeatu";
            btnErabiltzaileakKudeatu.Size = new Size(179, 29);
            btnErabiltzaileakKudeatu.TabIndex = 3;
            btnErabiltzaileakKudeatu.Text = "Erabiltzaileak kudeatu";
            btnErabiltzaileakKudeatu.UseVisualStyleBackColor = true;
            btnErabiltzaileakKudeatu.Click += btnErabiltzaileakKudeatu_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(333, 299);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click_1;
            // 
            // MenuNagusia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIrten);
            Controls.Add(btnErabiltzaileakKudeatu);
            Controls.Add(btnGailuaGehitu);
            Controls.Add(btnGailuakIkusi);
            Controls.Add(lblMenuNagusia);
            Name = "MenuNagusia";
            Text = "MenuNagusia";
            Load += MenuNagusia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuNagusia;
        private Button btnGailuakIkusi;
        private Button btnGailuaGehitu;
        private Button btnErabiltzaileakKudeatu;
        private Button btnIrten;
    }
}