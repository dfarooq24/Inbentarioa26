namespace ERRONKA3
{
    partial class GailuaEditatuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GailuaEditatuForm));
            txtMarka = new TextBox();
            txtModelo = new TextBox();
            dtpErosketaData = new DateTimePicker();
            cmbMota = new ComboBox();
            cmbMintegia = new ComboBox();
            cmbEgoera = new ComboBox();
            txtRAM = new TextBox();
            txtROM = new TextBox();
            txtCPU = new TextBox();
            btnGorde = new Button();
            btnAztera = new Button();
            chkKolorea = new CheckBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(245, 53);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(250, 27);
            txtMarka.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(245, 141);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(250, 27);
            txtModelo.TabIndex = 2;
            // 
            // dtpErosketaData
            // 
            dtpErosketaData.Location = new Point(245, 225);
            dtpErosketaData.Name = "dtpErosketaData";
            dtpErosketaData.Size = new Size(250, 27);
            dtpErosketaData.TabIndex = 8;
            // 
            // cmbMota
            // 
            cmbMota.FormattingEnabled = true;
            cmbMota.Items.AddRange(new object[] { "ordenagailua", "inprimagailua" });
            cmbMota.Location = new Point(245, 312);
            cmbMota.Name = "cmbMota";
            cmbMota.Size = new Size(151, 28);
            cmbMota.TabIndex = 9;
            cmbMota.SelectedIndexChanged += cmbMota_SelectedIndexChanged;
            // 
            // cmbMintegia
            // 
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Items.AddRange(new object[] { "1", "2", "3" });
            cmbMintegia.Location = new Point(245, 405);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 10;
            // 
            // cmbEgoera
            // 
            cmbEgoera.FormattingEnabled = true;
            cmbEgoera.Items.AddRange(new object[] { "aktibo", "", "apurtuta", "", "konpontzen", "", "ezabatuta" });
            cmbEgoera.Location = new Point(245, 490);
            cmbEgoera.Name = "cmbEgoera";
            cmbEgoera.Size = new Size(151, 28);
            cmbEgoera.TabIndex = 11;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(761, 53);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(186, 27);
            txtRAM.TabIndex = 15;
            // 
            // txtROM
            // 
            txtROM.Location = new Point(761, 141);
            txtROM.Name = "txtROM";
            txtROM.Size = new Size(186, 27);
            txtROM.TabIndex = 16;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(761, 225);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(186, 27);
            txtCPU.TabIndex = 17;
            // 
            // btnGorde
            // 
            btnGorde.BackColor = Color.FromArgb(128, 255, 128);
            btnGorde.Location = new Point(587, 426);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(177, 58);
            btnGorde.TabIndex = 18;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = false;
            btnGorde.Click += btnGorde_Click_1;
            // 
            // btnAztera
            // 
            btnAztera.BackColor = Color.Red;
            btnAztera.Location = new Point(800, 426);
            btnAztera.Name = "btnAztera";
            btnAztera.Size = new Size(177, 58);
            btnAztera.TabIndex = 19;
            btnAztera.Text = "Atzera";
            btnAztera.UseVisualStyleBackColor = false;
            btnAztera.Click += btnAztera_Click;
            // 
            // chkKolorea
            // 
            chkKolorea.AutoSize = true;
            chkKolorea.Location = new Point(728, 338);
            chkKolorea.Name = "chkKolorea";
            chkKolorea.Size = new Size(83, 24);
            chkKolorea.TabIndex = 20;
            chkKolorea.Text = "Kolorea";
            chkKolorea.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtROM);
            panel1.Controls.Add(txtCPU);
            panel1.Controls.Add(btnAztera);
            panel1.Controls.Add(chkKolorea);
            panel1.Controls.Add(btnGorde);
            panel1.Controls.Add(txtRAM);
            panel1.Controls.Add(cmbEgoera);
            panel1.Controls.Add(dtpErosketaData);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(cmbMintegia);
            panel1.Controls.Add(cmbMota);
            panel1.Controls.Add(txtModelo);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 585);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // GailuaEditatuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1022, 582);
            Controls.Add(panel1);
            Name = "GailuaEditatuForm";
            Text = "GailuaEditatuForm";
            Load += GailuaEditatuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtMarka;
        private TextBox txtModelo;
        private DateTimePicker dtpErosketaData;
        private ComboBox cmbMota;
        private ComboBox cmbMintegia;
        private ComboBox cmbEgoera;
        private TextBox txtRAM;
        private TextBox txtROM;
        private TextBox txtCPU;
        private Button btnGorde;
        private Button btnAztera;
        private CheckBox chkKolorea;
        private Panel panel1;
    }
}