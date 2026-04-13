namespace ERRONKA3
{
    partial class LoginForm
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
        private void InitializeComponent()
        {
            lblErabiltzailea = new Label();
            lblPasahitza = new Label();
            txtErabiltzailea = new TextBox();
            txtPasahitza = new TextBox();
            btnSaioaHasi = new Button();
            SuspendLayout();
            // 
            // lblErabiltzailea
            // 
            lblErabiltzailea.AutoSize = true;
            lblErabiltzailea.Location = new Point(213, 133);
            lblErabiltzailea.Name = "lblErabiltzailea";
            lblErabiltzailea.Size = new Size(91, 20);
            lblErabiltzailea.TabIndex = 0;
            lblErabiltzailea.Text = "Erabiltzailea";
            // 
            // lblPasahitza
            // 
            lblPasahitza.AutoSize = true;
            lblPasahitza.Location = new Point(213, 224);
            lblPasahitza.Name = "lblPasahitza";
            lblPasahitza.Size = new Size(70, 20);
            lblPasahitza.TabIndex = 1;
            lblPasahitza.Text = "Pasahitza";
            // 
            // txtErabiltzailea
            // 
            txtErabiltzailea.Location = new Point(397, 133);
            txtErabiltzailea.Name = "txtErabiltzailea";
            txtErabiltzailea.Size = new Size(125, 27);
            txtErabiltzailea.TabIndex = 2;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Location = new Point(397, 224);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(125, 27);
            txtPasahitza.TabIndex = 3;
            txtPasahitza.UseSystemPasswordChar = true;
            // 
            // btnSaioaHasi
            // 
            btnSaioaHasi.Location = new Point(313, 307);
            btnSaioaHasi.Name = "btnSaioaHasi";
            btnSaioaHasi.Size = new Size(94, 29);
            btnSaioaHasi.TabIndex = 4;
            btnSaioaHasi.Text = "Saioa Hasi";
            btnSaioaHasi.UseVisualStyleBackColor = true;
            btnSaioaHasi.Click += btnSaioaHasi_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaioaHasi);
            Controls.Add(txtPasahitza);
            Controls.Add(txtErabiltzailea);
            Controls.Add(lblPasahitza);
            Controls.Add(lblErabiltzailea);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErabiltzailea;
        private Label lblPasahitza;
        private TextBox txtErabiltzailea;
        private TextBox txtPasahitza;
        private Button btnSaioaHasi;
    }
}
