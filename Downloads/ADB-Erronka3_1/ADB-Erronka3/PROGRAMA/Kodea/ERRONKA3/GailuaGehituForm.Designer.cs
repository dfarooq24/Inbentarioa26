namespace ERRONKA3
{
    partial class GailuaGehituForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GailuaGehituForm));
            chkKolorea = new CheckBox();
            btnGorde = new Button();
            btnAtzera = new Button();
            txtMarka = new TextBox();
            txtModelo = new TextBox();
            dtpErosketaData = new DateTimePicker();
            cmbMota = new ComboBox();
            cmbMintegia = new ComboBox();
            txtRAM = new TextBox();
            txtROM = new TextBox();
            txtCPU = new TextBox();
            cmbEgoera = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkKolorea
            // 
            chkKolorea.AutoSize = true;
            chkKolorea.Location = new Point(621, 292);
            chkKolorea.Name = "chkKolorea";
            chkKolorea.Size = new Size(83, 24);
            chkKolorea.TabIndex = 9;
            chkKolorea.Text = "Kolorea";
            chkKolorea.UseVisualStyleBackColor = true;
            // 
            // btnGorde
            // 
            btnGorde.BackColor = Color.FromArgb(128, 255, 128);
            btnGorde.Location = new Point(514, 371);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(155, 55);
            btnGorde.TabIndex = 10;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = false;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.BackColor = Color.Red;
            btnAtzera.Location = new Point(713, 371);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(155, 55);
            btnAtzera.TabIndex = 11;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = false;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(181, 41);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(250, 27);
            txtMarka.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(181, 108);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(250, 27);
            txtModelo.TabIndex = 13;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // dtpErosketaData
            // 
            dtpErosketaData.Location = new Point(214, 193);
            dtpErosketaData.Name = "dtpErosketaData";
            dtpErosketaData.Size = new Size(250, 27);
            dtpErosketaData.TabIndex = 14;
            // 
            // cmbMota
            // 
            cmbMota.FormattingEnabled = true;
            cmbMota.Items.AddRange(new object[] { "ordenagailua", "inprimagailua" });
            cmbMota.Location = new Point(182, 278);
            cmbMota.Name = "cmbMota";
            cmbMota.Size = new Size(151, 28);
            cmbMota.TabIndex = 15;
            cmbMota.SelectedIndexChanged += cmbMota_SelectedIndexChanged;
            // 
            // cmbMintegia
            // 
            cmbMintegia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Items.AddRange(new object[] { "1", "2", "3" });
            cmbMintegia.Location = new Point(182, 356);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 16;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(645, 41);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(125, 27);
            txtRAM.TabIndex = 17;
            // 
            // txtROM
            // 
            txtROM.Location = new Point(645, 121);
            txtROM.Name = "txtROM";
            txtROM.Size = new Size(125, 27);
            txtROM.TabIndex = 18;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(645, 193);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(125, 27);
            txtCPU.TabIndex = 19;
            // 
            // cmbEgoera
            // 
            cmbEgoera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgoera.FormattingEnabled = true;
            cmbEgoera.Items.AddRange(new object[] { "aktibo", "apurtuta", "konpontzen", "ezabatuta" });
            cmbEgoera.Location = new Point(181, 429);
            cmbEgoera.Name = "cmbEgoera";
            cmbEgoera.Size = new Size(151, 28);
            cmbEgoera.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cmbEgoera);
            panel1.Controls.Add(txtMarka);
            panel1.Controls.Add(btnGorde);
            panel1.Controls.Add(btnAtzera);
            panel1.Controls.Add(txtCPU);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(chkKolorea);
            panel1.Controls.Add(txtROM);
            panel1.Controls.Add(dtpErosketaData);
            panel1.Controls.Add(txtRAM);
            panel1.Controls.Add(cmbMota);
            panel1.Controls.Add(cmbMintegia);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 514);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // GailuaGehituForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(905, 515);
            Controls.Add(panel1);
            Name = "GailuaGehituForm";
            Text = "GailuaGehituForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chkKolorea;
        private Button btnGorde;
        private Button btnAtzera;
        private TextBox txtMarka;
        private TextBox txtModelo;
        private DateTimePicker dtpErosketaData;
        private ComboBox cmbMota;
        private ComboBox cmbMintegia;
        private TextBox txtRAM;
        private TextBox txtROM;
        private TextBox txtCPU;
        private ComboBox cmbEgoera;
        private Panel panel1;
    }
}