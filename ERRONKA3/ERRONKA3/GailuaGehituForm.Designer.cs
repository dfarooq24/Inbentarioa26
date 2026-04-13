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
            lblMarka = new Label();
            lblModelo = new Label();
            lblErosketaData = new Label();
            lblMota = new Label();
            lblMintegia = new Label();
            lblRAM = new Label();
            lblROM = new Label();
            lblCPU = new Label();
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
            lblEgoera = new Label();
            cmbEgoera = new ComboBox();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(68, 64);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(50, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            lblMarka.Click += label1_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(68, 133);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo";
            // 
            // lblErosketaData
            // 
            lblErosketaData.AutoSize = true;
            lblErosketaData.Location = new Point(43, 209);
            lblErosketaData.Name = "lblErosketaData";
            lblErosketaData.Size = new Size(101, 20);
            lblErosketaData.TabIndex = 2;
            lblErosketaData.Text = "Erosketa Data";
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.Location = new Point(68, 270);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(44, 20);
            lblMota.TabIndex = 3;
            lblMota.Text = "Mota";
            // 
            // lblMintegia
            // 
            lblMintegia.AutoSize = true;
            lblMintegia.Location = new Point(68, 329);
            lblMintegia.Name = "lblMintegia";
            lblMintegia.Size = new Size(68, 20);
            lblMintegia.TabIndex = 4;
            lblMintegia.Text = "Mintegia";
            // 
            // lblRAM
            // 
            lblRAM.AutoSize = true;
            lblRAM.Location = new Point(422, 48);
            lblRAM.Name = "lblRAM";
            lblRAM.Size = new Size(41, 20);
            lblRAM.TabIndex = 6;
            lblRAM.Text = "RAM";
            // 
            // lblROM
            // 
            lblROM.AutoSize = true;
            lblROM.Location = new Point(423, 114);
            lblROM.Name = "lblROM";
            lblROM.Size = new Size(42, 20);
            lblROM.TabIndex = 7;
            lblROM.Text = "ROM";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(423, 172);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(36, 20);
            lblCPU.TabIndex = 8;
            lblCPU.Text = "CPU";
            // 
            // chkKolorea
            // 
            chkKolorea.AutoSize = true;
            chkKolorea.Location = new Point(510, 265);
            chkKolorea.Name = "chkKolorea";
            chkKolorea.Size = new Size(83, 24);
            chkKolorea.TabIndex = 9;
            chkKolorea.Text = "Kolorea";
            chkKolorea.UseVisualStyleBackColor = true;
            // 
            // btnGorde
            // 
            btnGorde.Location = new Point(448, 354);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(94, 29);
            btnGorde.TabIndex = 10;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = true;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnAtzera
            // 
            btnAtzera.Location = new Point(625, 354);
            btnAtzera.Name = "btnAtzera";
            btnAtzera.Size = new Size(94, 29);
            btnAtzera.TabIndex = 11;
            btnAtzera.Text = "Atzera";
            btnAtzera.UseVisualStyleBackColor = true;
            btnAtzera.Click += btnAtzera_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(182, 64);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(182, 130);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 13;
            // 
            // dtpErosketaData
            // 
            dtpErosketaData.Location = new Point(150, 204);
            dtpErosketaData.Name = "dtpErosketaData";
            dtpErosketaData.Size = new Size(250, 27);
            dtpErosketaData.TabIndex = 14;
            // 
            // cmbMota
            // 
            cmbMota.FormattingEnabled = true;
            cmbMota.Items.AddRange(new object[] { "ordenagailua", "inprimagailua" });
            cmbMota.Location = new Point(181, 265);
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
            cmbMintegia.Location = new Point(181, 321);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 16;
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(510, 45);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(125, 27);
            txtRAM.TabIndex = 17;
            // 
            // txtROM
            // 
            txtROM.Location = new Point(510, 111);
            txtROM.Name = "txtROM";
            txtROM.Size = new Size(125, 27);
            txtROM.TabIndex = 18;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(510, 172);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(125, 27);
            txtCPU.TabIndex = 19;
            // 
            // lblEgoera
            // 
            lblEgoera.AutoSize = true;
            lblEgoera.Location = new Point(68, 386);
            lblEgoera.Name = "lblEgoera";
            lblEgoera.Size = new Size(56, 20);
            lblEgoera.TabIndex = 20;
            lblEgoera.Text = "Egoera";
            // 
            // cmbEgoera
            // 
            cmbEgoera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgoera.FormattingEnabled = true;
            cmbEgoera.Items.AddRange(new object[] { "aktibo", "apurtuta", "konpontzen", "ezabatuta" });
            cmbEgoera.Location = new Point(181, 386);
            cmbEgoera.Name = "cmbEgoera";
            cmbEgoera.Size = new Size(151, 28);
            cmbEgoera.TabIndex = 21;
            // 
            // GailuaGehituForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbEgoera);
            Controls.Add(lblEgoera);
            Controls.Add(txtCPU);
            Controls.Add(txtROM);
            Controls.Add(txtRAM);
            Controls.Add(cmbMintegia);
            Controls.Add(cmbMota);
            Controls.Add(dtpErosketaData);
            Controls.Add(txtModelo);
            Controls.Add(txtMarka);
            Controls.Add(btnAtzera);
            Controls.Add(btnGorde);
            Controls.Add(chkKolorea);
            Controls.Add(lblCPU);
            Controls.Add(lblROM);
            Controls.Add(lblRAM);
            Controls.Add(lblMintegia);
            Controls.Add(lblMota);
            Controls.Add(lblErosketaData);
            Controls.Add(lblModelo);
            Controls.Add(lblMarka);
            Name = "GailuaGehituForm";
            Text = "GailuaGehituForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModelo;
        private Label lblErosketaData;
        private Label lblMota;
        private Label lblMintegia;
        private Label lblRAM;
        private Label lblROM;
        private Label lblCPU;
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
        private Label lblEgoera;
        private ComboBox cmbEgoera;
    }
}