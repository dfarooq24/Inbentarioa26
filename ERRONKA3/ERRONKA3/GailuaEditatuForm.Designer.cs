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
            label1 = new Label();
            txtMarka = new TextBox();
            txtModelo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpErosketaData = new DateTimePicker();
            cmbMota = new ComboBox();
            cmbMintegia = new ComboBox();
            cmbEgoera = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRAM = new TextBox();
            txtROM = new TextBox();
            txtCPU = new TextBox();
            btnGorde = new Button();
            btnAztera = new Button();
            chkKolorea = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 32);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            label1.Click += label1_Click;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(168, 32);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(168, 106);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 113);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 183);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Erosketa Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 249);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Mota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 315);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 6;
            label5.Text = "Mintegia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 385);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 7;
            label6.Text = "Egoera";
            // 
            // dtpErosketaData
            // 
            dtpErosketaData.Location = new Point(168, 178);
            dtpErosketaData.Name = "dtpErosketaData";
            dtpErosketaData.Size = new Size(250, 27);
            dtpErosketaData.TabIndex = 8;
            // 
            // cmbMota
            // 
            cmbMota.FormattingEnabled = true;
            cmbMota.Items.AddRange(new object[] { "ordenagailua", "inprimagailua" });
            cmbMota.Location = new Point(197, 246);
            cmbMota.Name = "cmbMota";
            cmbMota.Size = new Size(151, 28);
            cmbMota.TabIndex = 9;
            cmbMota.SelectedIndexChanged += cmbMota_SelectedIndexChanged;
            // 
            // cmbMintegia
            // 
            cmbMintegia.FormattingEnabled = true;
            cmbMintegia.Items.AddRange(new object[] { "1", "2", "3" });
            cmbMintegia.Location = new Point(197, 312);
            cmbMintegia.Name = "cmbMintegia";
            cmbMintegia.Size = new Size(151, 28);
            cmbMintegia.TabIndex = 10;
            // 
            // cmbEgoera
            // 
            cmbEgoera.FormattingEnabled = true;
            cmbEgoera.Items.AddRange(new object[] { "aktibo", "", "apurtuta", "", "konpontzen", "", "ezabatuta" });
            cmbEgoera.Location = new Point(197, 377);
            cmbEgoera.Name = "cmbEgoera";
            cmbEgoera.Size = new Size(151, 28);
            cmbEgoera.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(522, 32);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 12;
            label7.Text = "RAM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 106);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 13;
            label8.Text = "ROM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 169);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 14;
            label9.Text = "CPU";
            // 
            // txtRAM
            // 
            txtRAM.Location = new Point(639, 29);
            txtRAM.Name = "txtRAM";
            txtRAM.Size = new Size(125, 27);
            txtRAM.TabIndex = 15;
            // 
            // txtROM
            // 
            txtROM.Location = new Point(639, 110);
            txtROM.Name = "txtROM";
            txtROM.Size = new Size(125, 27);
            txtROM.TabIndex = 16;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(639, 166);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(125, 27);
            txtCPU.TabIndex = 17;
            // 
            // btnGorde
            // 
            btnGorde.Location = new Point(478, 332);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(94, 29);
            btnGorde.TabIndex = 18;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = true;
            btnGorde.Click += btnGorde_Click_1;
            // 
            // btnAztera
            // 
            btnAztera.Location = new Point(639, 332);
            btnAztera.Name = "btnAztera";
            btnAztera.Size = new Size(94, 29);
            btnAztera.TabIndex = 19;
            btnAztera.Text = "Atzera";
            btnAztera.UseVisualStyleBackColor = true;
            btnAztera.Click += btnAztera_Click;
            // 
            // chkKolorea
            // 
            chkKolorea.AutoSize = true;
            chkKolorea.Location = new Point(581, 260);
            chkKolorea.Name = "chkKolorea";
            chkKolorea.Size = new Size(83, 24);
            chkKolorea.TabIndex = 20;
            chkKolorea.Text = "Kolorea";
            chkKolorea.UseVisualStyleBackColor = true;
            // 
            // GailuaEditatuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkKolorea);
            Controls.Add(btnAztera);
            Controls.Add(btnGorde);
            Controls.Add(txtCPU);
            Controls.Add(txtROM);
            Controls.Add(txtRAM);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbEgoera);
            Controls.Add(cmbMintegia);
            Controls.Add(cmbMota);
            Controls.Add(dtpErosketaData);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModelo);
            Controls.Add(txtMarka);
            Controls.Add(label1);
            Name = "GailuaEditatuForm";
            Text = "GailuaEditatuForm";
            Load += GailuaEditatuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMarka;
        private TextBox txtModelo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpErosketaData;
        private ComboBox cmbMota;
        private ComboBox cmbMintegia;
        private ComboBox cmbEgoera;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtRAM;
        private TextBox txtROM;
        private TextBox txtCPU;
        private Button btnGorde;
        private Button btnAztera;
        private CheckBox chkKolorea;
    }
}