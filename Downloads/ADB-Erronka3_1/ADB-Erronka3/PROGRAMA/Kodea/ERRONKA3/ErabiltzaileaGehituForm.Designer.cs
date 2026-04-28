namespace ERRONKA3
{
    partial class ErabiltzaileaGehituForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErabiltzaileaGehituForm));
            txtIzena = new TextBox();
            txtPasahitza = new TextBox();
            btnGorde = new Button();
            btnAtzera = new Button();
            cmbRola = new ComboBox();
            cmbMintegia = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIzena
            // 
            txtIzena.Location = new Point(259, 113);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(209, 27);
            txtIzena.TabIndex = 4;
            txtIzena.TextChanged += txtIzena_TextChanged;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Location = new Point(259, 193);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(209, 27);
            txtPasahitza.TabIndex = 5;
            // 
            // btnGorde
            // 
            btnGorde.BackColor = Color.FromArgb(128, 255, 128);
            btnGorde.Location = new Point(617, 153);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(128, 67);
            btnGorde.TabIndex = 8;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = false;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.BackColor = Color.Red;
            btnAtzera.Location = new Point(617, 289);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(128, 66);
            btnAtzera.TabIndex = 9;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = false;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // cmbRola
            // 
            cmbRola.FormattingEnabled = true;
            cmbRola.Items.AddRange(new object[] { "admin", "ikt_arduraduna", "irakaslea" });
            cmbRola.Location = new Point(259, 273);
            cmbRola.Name = "cmbRola";
            cmbRola.Size = new Size(151, 28);
            cmbRola.TabIndex = 10;
            // 
            // cmbMintegia
            // 
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Items.AddRange(new object[] { "1", "2", "3" });
            cmbMintegia.Location = new Point(259, 363);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAtzera);
            panel1.Controls.Add(cmbMintegia);
            panel1.Controls.Add(btnGorde);
            panel1.Controls.Add(txtIzena);
            panel1.Controls.Add(txtPasahitza);
            panel1.Controls.Add(cmbRola);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 516);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // ErabiltzaileaGehituForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 517);
            Controls.Add(panel1);
            Name = "ErabiltzaileaGehituForm";
            Text = "ErabiltzaileaGehituForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtIzena;
        private TextBox txtPasahitza;
        private Button btnGorde;
        private Button btnAtzera;
        private ComboBox cmbRola;
        private ComboBox cmbMintegia;
        private Panel panel1;
    }
}