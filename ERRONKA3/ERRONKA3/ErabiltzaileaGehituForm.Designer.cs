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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIzena = new TextBox();
            txtPasahitza = new TextBox();
            btnGorde = new Button();
            btnAtzera = new Button();
            cmbRola = new ComboBox();
            cmbMintegia = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Izena";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 153);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Pasahitza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 275);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Rola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 372);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Mintegia";
            // 
            // txtIzena
            // 
            txtIzena.Location = new Point(235, 42);
            txtIzena.Name = "txtIzena";
            txtIzena.Size = new Size(125, 27);
            txtIzena.TabIndex = 4;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Location = new Point(235, 146);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.Size = new Size(125, 27);
            txtPasahitza.TabIndex = 5;
            // 
            // btnGorde
            // 
            btnGorde.Location = new Point(603, 120);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(94, 43);
            btnGorde.TabIndex = 8;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = true;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.Location = new Point(603, 247);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(94, 29);
            btnAtzera.TabIndex = 9;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = true;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // cmbRola
            // 
            cmbRola.FormattingEnabled = true;
            cmbRola.Items.AddRange(new object[] { "admin", "ikt_arduraduna", "irakaslea" });
            cmbRola.Location = new Point(235, 272);
            cmbRola.Name = "cmbRola";
            cmbRola.Size = new Size(151, 28);
            cmbRola.TabIndex = 10;
            // 
            // cmbMintegia
            // 
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Items.AddRange(new object[] { "1", "2", "3" });
            cmbMintegia.Location = new Point(235, 352);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 11;
            // 
            // ErabiltzaileaGehituForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMintegia);
            Controls.Add(cmbRola);
            Controls.Add(btnAtzera);
            Controls.Add(btnGorde);
            Controls.Add(txtPasahitza);
            Controls.Add(txtIzena);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ErabiltzaileaGehituForm";
            Text = "ErabiltzaileaGehituForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIzena;
        private TextBox txtPasahitza;
        private Button btnGorde;
        private Button btnAtzera;
        private ComboBox cmbRola;
        private ComboBox cmbMintegia;
    }
}