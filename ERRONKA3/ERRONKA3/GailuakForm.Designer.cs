namespace ERRONKA3
{
    partial class GailuakForm
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
            dgvGailuak = new DataGridView();
            btnKargatu = new Button();
            btnAtzera = new Button();
            btnEzabatu = new Button();
            btnEditatu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).BeginInit();
            SuspendLayout();
            // 
            // dgvGailuak
            // 
            dgvGailuak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGailuak.Location = new Point(33, 12);
            dgvGailuak.Name = "dgvGailuak";
            dgvGailuak.RowHeadersWidth = 51;
            dgvGailuak.Size = new Size(711, 338);
            dgvGailuak.TabIndex = 0;
            dgvGailuak.CellContentClick += dgvGailuak_CellContentClick;
            // 
            // btnKargatu
            // 
            btnKargatu.Location = new Point(93, 392);
            btnKargatu.Name = "btnKargatu";
            btnKargatu.Size = new Size(94, 29);
            btnKargatu.TabIndex = 1;
            btnKargatu.Text = "Kargatu";
            btnKargatu.UseVisualStyleBackColor = true;
            btnKargatu.Click += btnKargatu_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.Location = new Point(650, 392);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(94, 29);
            btnAtzera.TabIndex = 2;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = true;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // btnEzabatu
            // 
            btnEzabatu.Location = new Point(212, 392);
            btnEzabatu.Name = "btnEzabatu";
            btnEzabatu.Size = new Size(94, 29);
            btnEzabatu.TabIndex = 3;
            btnEzabatu.Text = "Ezabatu";
            btnEzabatu.UseVisualStyleBackColor = true;
            btnEzabatu.Click += button1_Click;
            // 
            // btnEditatu
            // 
            btnEditatu.Location = new Point(373, 393);
            btnEditatu.Name = "btnEditatu";
            btnEditatu.Size = new Size(94, 29);
            btnEditatu.TabIndex = 4;
            btnEditatu.Text = "Editatu";
            btnEditatu.UseVisualStyleBackColor = true;
            btnEditatu.Click += btnEditatu_Click;
            // 
            // GailuakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditatu);
            Controls.Add(btnEzabatu);
            Controls.Add(btnAtzera);
            Controls.Add(btnKargatu);
            Controls.Add(dgvGailuak);
            Name = "GailuakForm";
            Text = "GailuakForm";
            Load += GailuakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGailuak;
        private Button btnKargatu;
        private Button btnAtzera;
        private Button btnEzabatu;
        private Button btnEditatu;
    }
}