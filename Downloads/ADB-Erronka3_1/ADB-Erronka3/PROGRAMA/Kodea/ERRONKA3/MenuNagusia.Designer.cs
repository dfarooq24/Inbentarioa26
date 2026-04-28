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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNagusia));
            lblMenuNagusia = new Label();
            btnGailuakIkusi = new Button();
            btnGailuaGehitu = new Button();
            btnErabiltzaileakKudeatu = new Button();
            btnIrten = new Button();
            panel11 = new Panel();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // lblMenuNagusia
            // 
            lblMenuNagusia.AutoSize = true;
            lblMenuNagusia.BackColor = Color.Transparent;
            lblMenuNagusia.ForeColor = Color.Red;
            lblMenuNagusia.Location = new Point(316, 89);
            lblMenuNagusia.Name = "lblMenuNagusia";
            lblMenuNagusia.Size = new Size(118, 20);
            lblMenuNagusia.TabIndex = 0;
            lblMenuNagusia.Text = "MENU NAGUSIA";
            // 
            // btnGailuakIkusi
            // 
            btnGailuakIkusi.BackColor = Color.FromArgb(128, 128, 255);
            btnGailuakIkusi.Location = new Point(3, 161);
            btnGailuakIkusi.Name = "btnGailuakIkusi";
            btnGailuakIkusi.Size = new Size(205, 72);
            btnGailuakIkusi.TabIndex = 1;
            btnGailuakIkusi.Text = "Gailuak Ikusi";
            btnGailuakIkusi.UseVisualStyleBackColor = false;
            btnGailuakIkusi.Click += btnGailuakIkusi_Click_1;
            // 
            // btnGailuaGehitu
            // 
            btnGailuaGehitu.BackColor = Color.FromArgb(128, 128, 255);
            btnGailuaGehitu.Location = new Point(263, 161);
            btnGailuaGehitu.Name = "btnGailuaGehitu";
            btnGailuaGehitu.Size = new Size(222, 72);
            btnGailuaGehitu.TabIndex = 2;
            btnGailuaGehitu.Text = "Gailua Gehitu";
            btnGailuaGehitu.UseVisualStyleBackColor = false;
            btnGailuaGehitu.Click += btnGailuaGehitu_Click;
            // 
            // btnErabiltzaileakKudeatu
            // 
            btnErabiltzaileakKudeatu.BackColor = Color.FromArgb(128, 128, 255);
            btnErabiltzaileakKudeatu.Location = new Point(537, 159);
            btnErabiltzaileakKudeatu.Name = "btnErabiltzaileakKudeatu";
            btnErabiltzaileakKudeatu.Size = new Size(226, 76);
            btnErabiltzaileakKudeatu.TabIndex = 3;
            btnErabiltzaileakKudeatu.Text = "Erabiltzaileak kudeatu";
            btnErabiltzaileakKudeatu.UseVisualStyleBackColor = false;
            btnErabiltzaileakKudeatu.Click += btnErabiltzaileakKudeatu_Click;
            // 
            // btnIrten
            // 
            btnIrten.BackColor = Color.FromArgb(255, 128, 128);
            btnIrten.Location = new Point(295, 300);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(157, 55);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = false;
            btnIrten.Click += btnIrten_Click_1;
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.Controls.Add(btnGailuaGehitu);
            panel11.Controls.Add(lblMenuNagusia);
            panel11.Controls.Add(btnErabiltzaileakKudeatu);
            panel11.Controls.Add(btnIrten);
            panel11.Controls.Add(btnGailuakIkusi);
            panel11.Location = new Point(12, 12);
            panel11.Name = "panel11";
            panel11.Size = new Size(791, 443);
            panel11.TabIndex = 5;
            panel11.Paint += panel1_Paint;
            // 
            // MenuNagusia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panel11);
            Name = "MenuNagusia";
            Text = "MenuNagusia";
            Load += MenuNagusia_Load;
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMenuNagusia;
        private Button btnGailuakIkusi;
        private Button btnGailuaGehitu;
        private Button btnErabiltzaileakKudeatu;
        private Button btnIrten;
        private Panel panel11;
    }
}