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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GailuakForm));
            dgvGailuak = new DataGridView();
            btnKargatu = new Button();
            btnAtzera = new Button();
            btnEzabatu = new Button();
            btnEditatu = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGailuak
            // 
            dgvGailuak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGailuak.Location = new Point(57, 13);
            dgvGailuak.Name = "dgvGailuak";
            dgvGailuak.RowHeadersWidth = 51;
            dgvGailuak.Size = new Size(771, 362);
            dgvGailuak.TabIndex = 0;
            dgvGailuak.CellContentClick += dgvGailuak_CellContentClick;
            // 
            // btnKargatu
            // 
            btnKargatu.BackColor = Color.FromArgb(128, 128, 255);
            btnKargatu.Location = new Point(57, 399);
            btnKargatu.Name = "btnKargatu";
            btnKargatu.Size = new Size(123, 47);
            btnKargatu.TabIndex = 1;
            btnKargatu.Text = "Kargatu";
            btnKargatu.UseVisualStyleBackColor = false;
            btnKargatu.Click += btnKargatu_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.BackColor = Color.Red;
            btnAtzera.Location = new Point(728, 394);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(150, 59);
            btnAtzera.TabIndex = 2;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = false;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // btnEzabatu
            // 
            btnEzabatu.BackColor = Color.FromArgb(255, 128, 128);
            btnEzabatu.Location = new Point(212, 399);
            btnEzabatu.Name = "btnEzabatu";
            btnEzabatu.Size = new Size(140, 48);
            btnEzabatu.TabIndex = 3;
            btnEzabatu.Text = "Ezabatu";
            btnEzabatu.UseVisualStyleBackColor = false;
            btnEzabatu.Click += button1_Click;
            // 
            // btnEditatu
            // 
            btnEditatu.BackColor = Color.FromArgb(128, 255, 128);
            btnEditatu.Location = new Point(383, 399);
            btnEditatu.Name = "btnEditatu";
            btnEditatu.Size = new Size(146, 48);
            btnEditatu.TabIndex = 4;
            btnEditatu.Text = "Editatu";
            btnEditatu.UseVisualStyleBackColor = false;
            btnEditatu.Click += btnEditatu_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnAtzera);
            panel1.Controls.Add(btnEditatu);
            panel1.Controls.Add(dgvGailuak);
            panel1.Controls.Add(btnEzabatu);
            panel1.Controls.Add(btnKargatu);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 474);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // GailuakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(956, 488);
            Controls.Add(panel1);
            Name = "GailuakForm";
            Text = "GailuakForm";
            Load += GailuakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGailuak).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGailuak;
        private Button btnKargatu;
        private Button btnAtzera;
        private Button btnEzabatu;
        private Button btnEditatu;
        private Panel panel1;
    }
}