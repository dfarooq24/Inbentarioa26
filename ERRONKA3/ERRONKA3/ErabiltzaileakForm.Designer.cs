namespace ERRONKA3
{
    partial class ErabiltzaileakForm
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
            dgvErabiltzaileak = new DataGridView();
            btnKargatu = new Button();
            btnGehitu = new Button();
            btnAtzera = new Button();
            btnEzabatu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).BeginInit();
            SuspendLayout();
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErabiltzaileak.Location = new Point(137, 12);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.Size = new Size(505, 280);
            dgvErabiltzaileak.TabIndex = 0;
            dgvErabiltzaileak.CellContentClick += dgvErabiltzaileak_CellContentClick;
            // 
            // btnKargatu
            // 
            btnKargatu.Location = new Point(103, 358);
            btnKargatu.Name = "btnKargatu";
            btnKargatu.Size = new Size(94, 29);
            btnKargatu.TabIndex = 1;
            btnKargatu.Text = "Kargatu";
            btnKargatu.UseVisualStyleBackColor = true;
            btnKargatu.Click += btnKargatu_Click_1;
            // 
            // btnGehitu
            // 
            btnGehitu.Location = new Point(332, 330);
            btnGehitu.Name = "btnGehitu";
            btnGehitu.Size = new Size(94, 29);
            btnGehitu.TabIndex = 2;
            btnGehitu.Text = "Gehitu";
            btnGehitu.UseVisualStyleBackColor = true;
            btnGehitu.Click += btnGehitu_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.Location = new Point(564, 358);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(94, 29);
            btnAtzera.TabIndex = 3;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = true;
            btnAtzera.Click += btnAtzera_Click_1;
            // 
            // btnEzabatu
            // 
            btnEzabatu.Location = new Point(332, 398);
            btnEzabatu.Name = "btnEzabatu";
            btnEzabatu.Size = new Size(94, 29);
            btnEzabatu.TabIndex = 4;
            btnEzabatu.Text = "Ezabatu";
            btnEzabatu.UseVisualStyleBackColor = true;
            btnEzabatu.Click += btnEzabatu_Click;
            // 
            // ErabiltzaileakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEzabatu);
            Controls.Add(btnAtzera);
            Controls.Add(btnGehitu);
            Controls.Add(btnKargatu);
            Controls.Add(dgvErabiltzaileak);
            Name = "ErabiltzaileakForm";
            Text = "ErabiltzaileakForm";
            Load += ErabiltzaileakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvErabiltzaileak;
        private Button btnKargatu;
        private Button btnGehitu;
        private Button btnAtzera;
        private Button btnEzabatu;
    }
}