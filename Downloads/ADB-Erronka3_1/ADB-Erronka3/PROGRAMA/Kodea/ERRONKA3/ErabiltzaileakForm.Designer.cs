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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErabiltzaileakForm));
            dgvErabiltzaileak = new DataGridView();
            btnKargatu = new Button();
            btnGehitu = new Button();
            btnAtzera = new Button();
            btnEzabatu = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvErabiltzaileak
            // 
            dgvErabiltzaileak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErabiltzaileak.Location = new Point(158, 41);
            dgvErabiltzaileak.Name = "dgvErabiltzaileak";
            dgvErabiltzaileak.RowHeadersWidth = 51;
            dgvErabiltzaileak.Size = new Size(640, 366);
            dgvErabiltzaileak.TabIndex = 0;
            dgvErabiltzaileak.CellContentClick += dgvErabiltzaileak_CellContentClick;
            // 
            // btnKargatu
            // 
            btnKargatu.BackColor = Color.FromArgb(128, 128, 255);
            btnKargatu.Location = new Point(92, 413);
            btnKargatu.Name = "btnKargatu";
            btnKargatu.Size = new Size(143, 78);
            btnKargatu.TabIndex = 1;
            btnKargatu.Text = "Kargatu";
            btnKargatu.UseVisualStyleBackColor = false;
            btnKargatu.Click += btnKargatu_Click_1;
            // 
            // btnGehitu
            // 
            btnGehitu.BackColor = Color.Lime;
            btnGehitu.Location = new Point(492, 413);
            btnGehitu.Name = "btnGehitu";
            btnGehitu.Size = new Size(140, 78);
            btnGehitu.TabIndex = 2;
            btnGehitu.Text = "Gehitu";
            btnGehitu.UseVisualStyleBackColor = false;
            btnGehitu.Click += btnGehitu_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.BackColor = Color.Red;
            btnAtzera.Location = new Point(689, 413);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(138, 78);
            btnAtzera.TabIndex = 3;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = false;
            btnAtzera.Click += btnAtzera_Click_1;
            // 
            // btnEzabatu
            // 
            btnEzabatu.BackColor = Color.FromArgb(255, 128, 128);
            btnEzabatu.Location = new Point(289, 413);
            btnEzabatu.Name = "btnEzabatu";
            btnEzabatu.Size = new Size(137, 78);
            btnEzabatu.TabIndex = 4;
            btnEzabatu.Text = "Ezabatu";
            btnEzabatu.UseVisualStyleBackColor = false;
            btnEzabatu.Click += btnEzabatu_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dgvErabiltzaileak);
            panel1.Controls.Add(btnKargatu);
            panel1.Controls.Add(btnGehitu);
            panel1.Controls.Add(btnEzabatu);
            panel1.Controls.Add(btnAtzera);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 542);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // ErabiltzaileakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(947, 542);
            Controls.Add(panel1);
            Name = "ErabiltzaileakForm";
            Text = "ErabiltzaileakForm";
            Load += ErabiltzaileakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvErabiltzaileak).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvErabiltzaileak;
        private Button btnKargatu;
        private Button btnGehitu;
        private Button btnAtzera;
        private Button btnEzabatu;
        private Panel panel1;
    }
}